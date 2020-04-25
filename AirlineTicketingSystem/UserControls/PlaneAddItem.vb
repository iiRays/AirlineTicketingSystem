Public Class PlaneAddItem
    Public Plane As Plane
    Public Form As String
    Public AdminFlightsAdd2 As AdminFlightsAdd2
    Public AdminFlightsEditPlane As AdminFlightsEditPlane
    Private Sub PlaneAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblId.Text = Plane.PlaneID
        lblModel.Text = Plane.Model
        lblCapacity.Text = Plane.Capacity.ToString("0 persons")
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If Form = "AdminFlightAdd2" Then
            App.Session.Set("plane", Plane)
            Quick.Navigate(DirectCast(sender, Button).FindForm, New AdminFlightsAdd3)
        ElseIf Form = "AdminFlightsEditPlane" Then
            App.Session.Set("plane", Plane)
            Quick.Navigate(DirectCast(sender, Button).FindForm, New AdminFlightsEdit)
        End If
    End Sub
End Class
