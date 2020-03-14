Public Class HomeGuest
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim form As New Login
        form.Show()
        Me.Close()

    End Sub
End Class