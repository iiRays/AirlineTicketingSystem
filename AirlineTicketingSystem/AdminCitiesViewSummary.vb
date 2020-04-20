Public Class AdminCitiesViewSummary
    Private city As City = App.Session.Get("city")
    Private Sub AdminCitiesViewSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)

        lblId.Text = city.CityID
        lblName.Text = city.Name
        lblCountry.Text = city.Country
        lblState.Text = city.State
        lbllatitude.Text = city.Latitude
        lblLongitude.Text = city.Longitude
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        App.Session.Delete("city")
        Quick.Navigate(Me, New AdminCitiesViewResults)
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        App.Session.Add("sourceScreen", "view")
        Quick.Navigate(Me, New AdminCitiesEdit)
    End Sub
End Class