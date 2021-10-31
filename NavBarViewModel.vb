Namespace ViewModels
    Public Class NavBarViewModel

#Region "Properties"
        ''' <summary>
        ''' ExplorerBar, SideBar, NavigationPane
        ''' </summary>
        ''' <returns></returns>
        Property Style As String = "NavigationPane"


        Private _items As List(Of NavItem)
        Public ReadOnly Property Items() As List(Of NavItem)
            Get
                If _items Is Nothing Then _items = New List(Of NavItem)
                Return _items
            End Get
        End Property

        Friend Shared Function SampleVM() As NavBarViewModel

            Dim ret = New NavBarViewModel()

            ret.Items.Add(New NavItem() With {.Code = "LA", .Description = "Ledger accounting", .CommandUrl = "LA", .ItemType = ""})

            ret.Items.Add(New NavItem() With {.Code = "NA", .Description = "Name and Address", .CommandUrl = "NA", .ItemType = "", .GroupCode = "LA"})
            ret.Items.Add(New NavItem() With {.Code = "CA", .Description = "Chart of Accounts", .CommandUrl = "CA", .ItemType = "", .GroupCode = "LA"})

            ret.Items.Add(New NavItem() With {.Code = "CRM", .Description = "Customer Relationship management", .CommandUrl = "CRM", .ItemType = ""})
            ret.Items.Add(New NavItem() With {.Code = "CUS", .Description = "Customer record", .CommandUrl = "CUS", .ItemType = "", .GroupCode = "CRM"})

            Return ret

        End Function


        Friend Function PaintStyleName() As String
            Return ""
        End Function

#End Region

#Region "Loading"
        Friend Function LoadDataAsync() As Task
            Return Task.CompletedTask
        End Function

#End Region

#Region "interactive"
        Friend Sub LaunchCmd(commandUrl As String)
            System.Windows.Forms.MessageBox.Show(commandUrl)
        End Sub

#End Region

        <Serializable>
        Class NavItem

            Private _itemType As String = ""
            ''' <summary>
            ''' G-group. S-Seperator
            ''' </summary>
            ''' <returns></returns>
            Public Property ItemType() As String
                Get
                    Return _itemType
                End Get
                Set(ByVal value As String)
                    _itemType = value
                End Set
            End Property

            Private _code As String = ""
            Public Property Code() As String
                Get
                    Return _code
                End Get
                Set(ByVal value As String)
                    _code = value
                End Set
            End Property

            Private _description As String = ""
            Public Property Description() As String
                Get
                    Return _description
                End Get
                Set(ByVal value As String)
                    _description = value
                End Set
            End Property

            Private _iconId As String = ""
            Public Property IconId As String
                Get
                    Return _iconId
                End Get
                Set(ByVal value As String)
                    _iconId = value
                End Set
            End Property


            Private _groupCode As String = ""
            Public Property GroupCode As String
                Get
                    Return _groupCode
                End Get
                Set(ByVal value As String)
                    _groupCode = value
                End Set
            End Property

            Private _commandUrl As String = ""
            Public Property CommandUrl() As String
                Get
                    Return _commandUrl
                End Get
                Set(ByVal value As String)
                    _commandUrl = value
                End Set
            End Property


            Public Function GetCommandUrl() As String
                If String.IsNullOrEmpty(_commandUrl) Then
                    Return _code
                Else
                    Return _commandUrl
                End If
            End Function

        End Class


    End Class

End Namespace
