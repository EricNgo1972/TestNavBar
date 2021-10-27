Public Class Form1
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Await Me.NavBarView1.LoadNavBarAsync()

    End Sub
End Class
