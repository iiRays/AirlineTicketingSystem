Public Class AdminCitiesDashboard
    Private Sub AdminCitiesDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New AdminDashboard)
    End Sub

    Private Sub BtnFlights_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Quick.Navigate(Me, New AdminCitiesAdd)
    End Sub

    Private Sub BtnRoutes_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Quick.Navigate(Me, New AdminCitiesView)
    End Sub
End Class