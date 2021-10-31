Imports DevExpress.Utils.VisualEffects

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Await Me.NavBarView1.LoadNavBarAsync()

        '  Dim AdornerUIManager1 = New DevExpress.Utils.VisualEffects.AdornerUIManager(Me.Container)

        Dim first = Me.NavBarItem1
        Dim last = Me.NavBarItem2

        Dim b1 As Badge = AdornerUIManager1.Elements.FirstOrDefault
        b1.TargetElement = GroupControl1

        Dim b2 As Badge = AdornerUIManager1.Elements.LastOrDefault
        b2.TargetElement = NavBarView1

    End Sub
End Class
