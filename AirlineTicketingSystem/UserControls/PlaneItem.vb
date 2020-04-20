Public Class PlaneItem
    Public Plane As Plane
    Public AdminPlanesViewResults As AdminPlanesViewResults
    Private Sub PlaneItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblId.Text = Plane.PlaneID
        lblModel.Text = Plane.Model
        lblManufacturer.Text = Plane.Manufacturer
        lblCapacity.Text = Plane.Capacity.ToString("0 persons")
    End Sub
    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        App.Session.Add("plane", Plane)
        Quick.Navigate(AdminCitiesViewResults, New AdminPlanesViewSummary)
    End Sub
End Class
