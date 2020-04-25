Public Class CityAddItem
    Public City As City
    Public Form As String
    Public AdminRoutesAdd1 As AdminRoutesAdd1
    Public AdminRoutesAdd2 As AdminRoutesAdd2
    Public AdminRoutesEditSource As AdminRoutesEditSource
    Public AdminRoutesEditDestination As AdminRoutesEditDestination
    Private Sub CityAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblId.Text = City.CityID
        lblName.Text = City.Name
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If Form = "AdminRoutesAdd1" Then
            App.Session.Set("source", City)
            Quick.Navigate(DirectCast(sender, Button).FindForm, New AdminRoutesAdd2)
        ElseIf Form = "AdminRoutesAdd2" Then
            App.Session.Set("destination", City)
            Quick.Navigate(DirectCast(sender, Button).FindForm, New AdminRoutesAdd3)
        ElseIf Form = "AdminRoutesEditSource" Then
            App.Session.Set("source", City)
            Quick.Navigate(DirectCast(sender, Button).FindForm, New AdminRoutesEdit)
        ElseIf Form = "AdminRoutesEditDestination" Then
            App.Session.Set("destination", City)
            Quick.Navigate(DirectCast(sender, Button).FindForm, New AdminRoutesEdit)
        End If
    End Sub
End Class
