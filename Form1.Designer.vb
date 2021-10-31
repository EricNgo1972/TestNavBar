<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NavBarView1 = New TestNavBar.Views.NavBarUC()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem7 = New DevExpress.XtraNavBar.NavBarItem()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.AdornerUIManager1 = New DevExpress.Utils.VisualEffects.AdornerUIManager(Me.components)
        Me.Badge1 = New DevExpress.Utils.VisualEffects.Badge()
        Me.Badge2 = New DevExpress.Utils.VisualEffects.Badge()
        Me.Badge3 = New DevExpress.Utils.VisualEffects.Badge()
        Me.Badge4 = New DevExpress.Utils.VisualEffects.Badge()
        CType(Me.NavBarView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdornerUIManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NavBarView1
        '
        Me.NavBarView1.ActiveGroup = Me.NavBarGroup2
        Me.NavBarView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.NavBarView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarView1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup2, Me.NavBarGroup1})
        Me.NavBarView1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBarItem1, Me.NavBarItem2, Me.NavBarItem3, Me.NavBarItem4, Me.NavBarItem5, Me.NavBarItem6, Me.NavBarItem7})
        Me.NavBarView1.Location = New System.Drawing.Point(5, 5)
        Me.NavBarView1.Name = "NavBarView1"
        Me.NavBarView1.OptionsNavPane.ExpandedWidth = 264
        Me.NavBarView1.OptionsNavPane.ShowGroupImageInHeader = True
        Me.NavBarView1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar
        Me.NavBarView1.ScaleImages = DevExpress.Utils.DefaultBoolean.[True]
        Me.NavBarView1.Size = New System.Drawing.Size(264, 440)
        Me.NavBarView1.StoreDefaultPaintStyleName = True
        Me.NavBarView1.TabIndex = 0
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "NavBarGroup2"
        Me.NavBarGroup2.Expanded = True
        Me.NavBarGroup2.ImageOptions.SvgImage = CType(resources.GetObject("NavBarGroup2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.NavBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem3)})
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Caption = "NavBarItem1"
        Me.NavBarItem1.Name = "NavBarItem1"
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = "NavBarItem2"
        Me.NavBarItem2.Name = "NavBarItem2"
        '
        'NavBarItem3
        '
        Me.NavBarItem3.Caption = "NavBarItem3"
        Me.NavBarItem3.Name = "NavBarItem3"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "NavBarGroup1"
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem4), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem5), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem7)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'NavBarItem4
        '
        Me.NavBarItem4.Caption = "NavBarItem4"
        Me.NavBarItem4.Name = "NavBarItem4"
        '
        'NavBarItem5
        '
        Me.NavBarItem5.Caption = "NavBarItem5"
        Me.NavBarItem5.Name = "NavBarItem5"
        '
        'NavBarItem6
        '
        Me.NavBarItem6.Caption = "NavBarItem6"
        Me.NavBarItem6.Name = "NavBarItem6"
        '
        'NavBarItem7
        '
        Me.NavBarItem7.Caption = "NavBarItem7"
        Me.NavBarItem7.Name = "NavBarItem7"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.CausesValidation = False
        Me.SplitterControl1.Location = New System.Drawing.Point(269, 5)
        Me.SplitterControl1.MinExtra = 10
        Me.SplitterControl1.MinSize = 10
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.ShowSplitGlyph = DevExpress.Utils.DefaultBoolean.[False]
        Me.SplitterControl1.Size = New System.Drawing.Size(10, 440)
        Me.SplitterControl1.TabIndex = 1
        Me.SplitterControl1.TabStop = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title
        Me.GroupControl1.Location = New System.Drawing.Point(279, 5)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(516, 440)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'AdornerUIManager1
        '
        Me.AdornerUIManager1.Elements.Add(Me.Badge1)
        Me.AdornerUIManager1.Elements.Add(Me.Badge2)
        Me.AdornerUIManager1.Elements.Add(Me.Badge3)
        Me.AdornerUIManager1.Elements.Add(Me.Badge4)
        Me.AdornerUIManager1.Owner = Me
        '
        'Badge1
        '
        Me.Badge1.Properties.PaintStyle = DevExpress.Utils.VisualEffects.BadgePaintStyle.System
        Me.Badge1.Properties.Text = "55"
        '
        'Badge2
        '
        Me.Badge2.Properties.PaintStyle = DevExpress.Utils.VisualEffects.BadgePaintStyle.Critical
        Me.Badge2.Properties.Text = "sdf"
        '
        'Badge3
        '
        Me.Badge3.Properties.PaintStyle = DevExpress.Utils.VisualEffects.BadgePaintStyle.Information
        Me.Badge3.Properties.Text = "kl99"
        '
        'Badge4
        '
        Me.Badge4.Properties.PaintStyle = DevExpress.Utils.VisualEffects.BadgePaintStyle.Critical
        Me.Badge4.Properties.Text = "34324"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.NavBarView1)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "Form1"
        CType(Me.NavBarView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdornerUIManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NavBarView1 As Views.NavBarUC
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem3 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem4 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem5 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem6 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem7 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents AdornerUIManager1 As DevExpress.Utils.VisualEffects.AdornerUIManager
    Friend WithEvents Badge1 As DevExpress.Utils.VisualEffects.Badge
    Friend WithEvents Badge2 As DevExpress.Utils.VisualEffects.Badge
    Friend WithEvents Badge3 As DevExpress.Utils.VisualEffects.Badge
    Friend WithEvents Badge4 As DevExpress.Utils.VisualEffects.Badge
End Class
