Public Class CityItem
    Public City As City
    Public AdminCitiesViewResults As AdminCitiesViewResults

    Private Sub CityItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblId.Text = City.CityID
        lblName.Text = City.Name
        lblCountry.Text = City.Country
        lblState.Text = City.State
    End Sub

    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        App.Session.Set("city", City)
        Quick.Navigate(AdminCitiesViewResults, New AdminCitiesViewSummary)
    End Sub
End Class
