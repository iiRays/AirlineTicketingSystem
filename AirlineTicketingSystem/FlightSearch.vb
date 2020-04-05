Public Class FlightSearch
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New FlightList)
    End Sub

    Private Sub FlightSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class