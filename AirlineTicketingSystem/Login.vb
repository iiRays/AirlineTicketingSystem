Public Class Login
    Private Sub btnRedirect_Click(sender As Object, e As EventArgs) Handles btnRedirect.Click
        Dim form As New Register
        form.Show()
        Me.Close()

    End Sub
End Class