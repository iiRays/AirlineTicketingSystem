Public Class AdminDashboard
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New HomeAdmin)
    End Sub
End Class