Namespace Views

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class NavBarView
        Inherits DevExpress.XtraEditors.XtraUserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NavBarView))
            Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
            Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
            Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
            Me.NavBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
            Me.NavBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
            CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'NavBarControl1
            '
            Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
            Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1})
            Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBarItem1, Me.NavBarItem2, Me.NavBarItem3, Me.NavBarItem4})
            Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
            Me.NavBarControl1.Name = "NavBarControl1"
            Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 264
            Me.NavBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
            Me.NavBarControl1.Size = New System.Drawing.Size(264, 609)
            Me.NavBarControl1.StoreDefaultPaintStyleName = True
            Me.NavBarControl1.TabIndex = 0
            Me.NavBarControl1.Text = "NavBarControl1"
            '
            'NavBarGroup1
            '
            Me.NavBarGroup1.Caption = "NavBarGroup1"
            Me.NavBarGroup1.Expanded = True
            Me.NavBarGroup1.ImageOptions.SvgImage = CType(resources.GetObject("NavBarGroup1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem4)})
            Me.NavBarGroup1.Name = "NavBarGroup1"
            '
            'NavBarItem1
            '
            Me.NavBarItem1.Caption = "NavBarItem1"
            Me.NavBarItem1.ImageOptions.SvgImage = CType(resources.GetObject("NavBarItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            Me.NavBarItem1.Name = "NavBarItem1"
            '
            'NavBarItem2
            '
            Me.NavBarItem2.Caption = "NavBarItem2"
            Me.NavBarItem2.ImageOptions.SvgImage = CType(resources.GetObject("NavBarItem2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            Me.NavBarItem2.Name = "NavBarItem2"
            '
            'NavBarItem3
            '
            Me.NavBarItem3.Caption = "NavBarItem3"
            Me.NavBarItem3.ImageOptions.SvgImage = CType(resources.GetObject("NavBarItem3.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            Me.NavBarItem3.Name = "NavBarItem3"
            '
            'NavBarItem4
            '
            Me.NavBarItem4.Caption = "NavBarItem4"
            Me.NavBarItem4.ImageOptions.SvgImage = CType(resources.GetObject("NavBarItem4.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            Me.NavBarItem4.Name = "NavBarItem4"
            '
            'NavBarView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.NavBarControl1)
            Me.Name = "NavBarView"
            Me.Size = New System.Drawing.Size(264, 609)
            CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
        Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
        Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
        Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
        Friend WithEvents NavBarItem3 As DevExpress.XtraNavBar.NavBarItem
        Friend WithEvents NavBarItem4 As DevExpress.XtraNavBar.NavBarItem
    End Class

End Namespace
