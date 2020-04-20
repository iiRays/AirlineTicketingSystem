Public Class FlightViewItem
    Public Flight As Flight
    Public AdminFlightsViewResults As AdminFlightsViewResults
    Private Sub FlightViewItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblId.Text = Flight.FlightID
        lblSource.Text = DB.GetFlightSource(Flight.FlightID).City.Name
        lblDestination.Text = DB.GetFlightDestination(Flight.FlightID).City.Name
        lblDate.Text = Flight.DepartureTime.DayOfWeek.ToString & ", " & DateAndTime.MonthName(Flight.DepartureTime.Month).ToString("MMM") & " " & Flight.DepartureTime.Day.ToString
    End Sub

    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        App.Session.Add("flight", Flight)
        Quick.Navigate(AdminFlightsViewResults, New AdminFlightsViewSummary)
    End Sub
End Class
