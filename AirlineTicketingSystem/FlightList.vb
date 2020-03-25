Public Class FlightList
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Quick.Navigate(Me, New FlightDetails)
    End Sub
End Class