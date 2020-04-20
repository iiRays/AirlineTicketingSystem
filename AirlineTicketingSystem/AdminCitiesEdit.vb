Public Class AdminCitiesEdit
    Private city As City = App.Session.Get("city")
    Private Sub AdminCitiesEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)

        txtID.Text = city.CityID
        txtName.Text = city.Name
        txtCountry.Text = city.Country
        txtState.Text = city.State
        txtLatitude.Text = city.Latitude
        txtLongitude.Text = city.Longitude
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If App.Session.Get("sourceScreen") = "add" Then
            App.Session.Delete("sourceScreen")
            Quick.Navigate(Me, New AdminCitiesAddSummary)

        ElseIf App.Session.Get("sourceScreen") = "view" Then
            App.Session.Delete("sourceScreen")
            Quick.Navigate(Me, New AdminCitiesViewSummary)

        Else
            Quick.Navigate(Me, New AdminDashboard)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newCity = DB.Get(Of City)(city.CityID)
        newCity.Name = txtName.Text
        newCity.Country = txtCountry.Text
        newCity.State = txtState.Text
        newCity.Latitude = txtLatitude.Text
        newCity.Longitude = txtLongitude.Text

        Quick.Navigate(Me, New AdminCitiesViewSummary)
    End Sub
End Class