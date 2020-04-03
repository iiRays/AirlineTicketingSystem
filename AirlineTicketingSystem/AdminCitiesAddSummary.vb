Public Class AdminCitiesAddSummary
    Private city As City = App.Session.Get("city")
    Private Sub AdminCitiesAddSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)

        lblId.Text = city.CityID
        lblName.Text = city.Name
        lblCountry.Text = city.Country
        lblState.Text = city.State
        lbllatitude.Text = city.Latitude
        lblLongitude.Text = city.Longitude
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        App.Session.Delete("city")
        Quick.Navigate(Me, New AdminCitiesDashboard)
    End Sub

    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        DB.Delete(city)
        App.Session.Delete("city")
        Quick.Navigate(Me, New AdminCitiesDashboard)
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Quick.Navigate(Me, New AdminCitiesEdit)
    End Sub
End Class