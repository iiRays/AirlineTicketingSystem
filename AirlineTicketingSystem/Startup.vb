Public Class Startup
    Private Sub Startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim form As New HomeGuest
        form.Show()
        Me.Close()
    End Sub
End Class