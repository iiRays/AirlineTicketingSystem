Public Class AdminReport

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New HomeAdmin)
    End Sub

    Private Sub btnDaily_Click(sender As Object, e As EventArgs) Handles btnSalesDaily.Click
        Quick.Navigate(Me, New SalesReport)
    End Sub

    Private Sub btnFlightSch_Click(sender As Object, e As EventArgs) Handles btnFlightSch.Click
        Quick.Navigate(Me, New FlightScheduleReport)
    End Sub

    Private Sub btnDailyCancel_Click(sender As Object, e As EventArgs) Handles btnDailyCancel.Click
        Quick.Navigate(Me, New CancellationReport)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Quick.Navigate(Me, New UserReport)
    End Sub
End Class