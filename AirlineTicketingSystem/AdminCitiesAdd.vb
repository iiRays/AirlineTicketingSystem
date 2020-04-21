Public Class AdminCitiesAdd
    Private Sub AdminCitiesAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New AdminCitiesDashboard)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim city As New City
        city.CityID = Quick.GenerateId(Of City)
        city.Name = txtName.Text
        city.Country = txtCountry.Text
        city.State = txtState.Text
        city.Latitude = txtLatitude.Text
        city.Longitude = txtLongitude.Text

        DB.Insert(city)

        App.Session.Set("city", city)

        Quick.Navigate(Me, New AdminCitiesAddSummary)
    End Sub
End Class