Public Class FlightDetails
    Private Flight As New Flight
    Private IsBooking = True
    Private ViewingBooking As New Booking

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Flight = App.Session.Get("selectedFlight")
    End Sub
    Sub New(ViewingBooking As Booking)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.IsBooking = False
        Me.ViewingBooking = ViewingBooking
        Me.Flight = ViewingBooking.Flight
    End Sub

    Private Sub FlightDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim route = DB.Get(Of Route)(Flight.RouteID)
        Dim plane = DB.Get(Of Plane)(Flight.PlaneID)

        Dim totalPassengers = DB.GetTotalPassengers(Flight.FlightID)
        Me.DoubleBuffered = True
        TitleBar.Load(Me)
        lblSeats.Text = totalPassengers & "/" & DB.Get(Of Plane)(Flight.PlaneID).Capacity
        If Flight.IsDaily Then
            lblDate.Text = "DAILY"
            lblSeats.Hide()
            lblSeatsTitle.Hide()
        Else
            lblDate.Text = Flight.DepartureTime.DayOfWeek.ToString & ", " & DateAndTime.MonthName(Flight.DepartureTime.Month) & " " & Flight.DepartureTime.Day.ToString
        End If
        lblId.Text = Flight.FlightNo
        lblDuration.Text = route.DurationHour.ToString & "h " & route.DurationMins.ToString & "m approx."
        lblSource.Text = DB.GetFlightSource(Flight.FlightID).City.Name
        lblDepartureTime.Text = Flight.DepartureTime.ToString("HH:mm")
        lblDestination.Text = DB.GetFlightDestination(Flight.FlightID).City.Name
        lblArrivalTime.Text = Flight.ArrivalTime.ToString("HH:mm")
        lblDuration.Text = Flight.ArrivalTime.Subtract(Flight.DepartureTime).Hours & "h " & Flight.ArrivalTime.Subtract(Flight.DepartureTime).Minutes & "M approx."
        lblPrice.Text = "RM " & Flight.Price

        'Whether to show Edit Flight button or not
        If (App.Session.Get("role") = "staff") Then
            btnGo.Hide()
        Else
            btnGo.Show()
        End If

        If IsBooking = False OrElse totalPassengers >= plane.Capacity Then
            btnGo.Hide()
        End If


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If Not IsBooking Then
            Quick.Navigate(Me, New BookingDetails(ViewingBooking))
        Else
            'Clear selected flight
            App.Session.Delete("selectedFlight")

            Quick.Navigate(Me, New FlightList)
        End If
    End Sub


    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Quick.Navigate(Me, New BookFlight1)
    End Sub

End Class