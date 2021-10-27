Imports DevExpress.XtraNavBar
Imports DevExpress.XtraNavBar.ViewInfo

Imports TestNavBar.ViewModels

Namespace Views
    Public Class NavBarUC
        Inherits DevExpress.XtraNavBar.NavBarControl

        Private _vm As NavBarViewModel

        Public Sub New()
            _vm = NavBarViewModel.SampleVM
        End Sub

        Public Sub New(pViewModel As NavBarViewModel)

            _vm = pViewModel
            If _vm Is Nothing Then _vm = NavBarViewModel.SampleVM

        End Sub

#Region "Loading"
        Public Async Function LoadNavBarAsync() As Task

            Await _vm.LoadDataAsync()

            SetAppearance()

            LoadItems()

        End Function

        Private Sub SetAppearance()

            Select Case _vm.Style
                Case "ExplorerBar"
                    Me.PaintStyleKind = NavBarViewKind.ExplorerBar
                Case "SideBar"
                    Me.PaintStyleKind = NavBarViewKind.SideBar
                Case "NavigationPane"
                    Me.PaintStyleKind = NavBarViewKind.NavigationPane
                Case Else
                    Me.PaintStyleKind = NavBarViewKind.Default
            End Select

            Me.PaintStyleName = _vm.PaintStyleName

        End Sub

        Private Sub LoadItems()


            Dim groups = New Dictionary(Of String, NavBarGroup)

            For Each itm In _vm.Items
                If itm.GroupCode = "" Then

                    If Not groups.ContainsKey(itm.Code) Then

                        Dim gr = New NavBarGroup(itm.Description) With {.Name = itm.Code}
                        groups.Add(itm.Code, gr)
                        If Not String.IsNullOrEmpty(itm.IconId) Then
                            'insert image here
                            'gr.ImageOptions.SvgImage = 

                        End If

                        Me.Groups.Add(gr)

                    End If

                End If
            Next


            Dim items = From itm In _vm.Items Where Not itm.GroupCode = "" Group By itm.GroupCode Into Group

            For Each gr In items

                Dim grcode = gr.GroupCode

                If groups.ContainsKey(grcode) Then

                    Dim navgr = groups(grcode)

                    For Each itm In gr.Group
                        Dim navitm = New NavBarItem(itm.Description) With {.Name = itm.Code, .Tag = itm}

                        If Not String.IsNullOrEmpty(itm.IconId) Then
                            'insert image here
                            'gr.ImageOptions.SvgImage = 

                        End If

                        Me.Items.Add(navitm)

                        navgr.ItemLinks.Add(New NavBarItemLink(navitm))

                    Next

                End If


            Next



        End Sub

#End Region

#Region "interactive"


        Private Sub NavBarUC_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles Me.LinkClicked
            Dim node = TryCast(e.Link.Item.Tag, ViewModels.NavBarViewModel.NavItem)
            If node IsNot Nothing Then
                _vm.LaunchCmd(node.GetCommandUrl)
            End If
        End Sub

        'Private Sub NavBarUC_SelectedLinkChanged(sender As Object, e As NavBarSelectedLinkChangedEventArgs) Handles Me.SelectedLinkChanged
        '    Dim node = TryCast(e.Link.Item.Tag, ViewModels.NavBarViewModel.NavItem)
        '    If node IsNot Nothing Then
        '        _vm.SelectedItemChange(node)
        '    End If
        'End Sub

#End Region

    End Class

End Namespace
