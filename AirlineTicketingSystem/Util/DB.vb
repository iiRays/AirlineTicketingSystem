Public Class DB
    Public Shared context As New AirlineSystemDataContext()

    Public Shared Function GetTotalPassengers(id As String) As Integer
        Dim bookings = CType(DB.Get(Of Flight)(id), Flight).Bookings.ToList
        Dim totalPassengers = 0
        For Each booking In bookings
            If booking.IsCancelled = False Then

                For Each ticket In booking.Tickets
                    totalPassengers += 1
                Next
            End If

        Next

        Return totalPassengers
    End Function

    Public Shared Function GetExistingFlight(flight As Flight, selectedDate As Date) As Flight
        Dim results = From dbFlight In DB.context.Flights Where dbFlight.FlightNo = flight.FlightNo And dbFlight.DepartureTime.Day = selectedDate.Day And dbFlight.DepartureTime.Month = selectedDate.Month And dbFlight.DepartureTime.Year = selectedDate.Year
        If results.Count = 0 Then
            Return Nothing
        Else
            Return results.First
        End If
    End Function
    Public Shared Sub Insert(obj As Object)

        If TypeOf obj Is Plane Then
            'Insert Plane
            context.Planes.InsertOnSubmit(obj)
        ElseIf TypeOf obj Is User Then
            'Insert User
            context.Users.InsertOnSubmit(obj)
        ElseIf TypeOf obj Is Booking Then
            'Insert Booking
            context.Bookings.InsertOnSubmit(obj)
        ElseIf TypeOf obj Is City Then
            'Insert City
            context.Cities.InsertOnSubmit(obj)
        ElseIf TypeOf obj Is Flight Then
            'Insert Flight
            context.Flights.InsertOnSubmit(obj)
        ElseIf TypeOf obj Is Route Then
            'Insert route
            context.Routes.InsertOnSubmit(obj)
        ElseIf TypeOf obj Is [Stop] Then
            'Insert Stop
            context.Stops.InsertOnSubmit(obj)
        ElseIf TypeOf obj Is Ticket Then
            'Insert ticket
            context.Tickets.InsertOnSubmit(obj)
        Else
            Throw New Exception("Object's type is not present in Airline Database.")
        End If

        Try
            context.SubmitChanges()
        Catch ex As SqlClient.SqlException
            Quick.Print(ex.Message)
        End Try


    End Sub

    Public Shared Sub Delete(obj As Object)

        If TypeOf obj Is Plane Then
            'Delete Plane
            context.Planes.DeleteOnSubmit(AirlineTicketingSystem.DB.Get(Of Plane)(CType(obj, Plane).PlaneID))
        ElseIf TypeOf obj Is User Then
            'Delete User
            context.Users.DeleteOnSubmit(AirlineTicketingSystem.DB.Get(Of User)(CType(obj, User).UserID))
        ElseIf TypeOf obj Is Booking Then
            'Delete Booking
            context.Bookings.DeleteOnSubmit(AirlineTicketingSystem.DB.Get(Of Booking)(CType(obj, Booking).BookingID))
        ElseIf TypeOf obj Is City Then
            'Delete City
            context.Cities.DeleteOnSubmit(AirlineTicketingSystem.DB.Get(Of City)(CType(obj, City).CityID))
        ElseIf TypeOf obj Is Flight Then
            'Delete Flight
            context.Flights.DeleteOnSubmit(AirlineTicketingSystem.DB.Get(Of Flight)(CType(obj, Flight).FlightID))
        ElseIf TypeOf obj Is Route Then
            'Delete route
            context.Routes.DeleteOnSubmit(AirlineTicketingSystem.DB.Get(Of Route)(CType(obj, Route).RouteID))
        ElseIf TypeOf obj Is [Stop] Then
            'Delete Stop
            context.Stops.DeleteOnSubmit(obj)
        ElseIf TypeOf obj Is Ticket Then
            'Delete ticket
            context.Tickets.DeleteOnSubmit(AirlineTicketingSystem.DB.Get(Of Ticket)(CType(obj, Ticket).TicketID))
        Else
            Throw New Exception("Object's type is not present in Airline Database.")
        End If

        context.SubmitChanges()

    End Sub

    Public Shared Function [Get](Of T)(id As String) As Object
        If GetType(T) = GetType(Plane) Then
            Return context.Planes.FirstOrDefault(Function(o) o.PlaneID = id)
        ElseIf GetType(T) = GetType(User) Then
            Return context.Users.FirstOrDefault(Function(o) o.UserID = id)
        ElseIf GetType(T) = GetType(Booking) Then
            Return context.Bookings.FirstOrDefault(Function(o) o.BookingID = id)
        ElseIf GetType(T) = GetType(City) Then
            Return context.Cities.FirstOrDefault(Function(o) o.CityID = id)
        ElseIf GetType(T) = GetType(Flight) Then
            Return context.Flights.FirstOrDefault(Function(o) o.FlightID = id)
        ElseIf GetType(T) = GetType(Route) Then
            Return context.Routes.FirstOrDefault(Function(o) o.RouteID = id)
        ElseIf GetType(T) = GetType(Ticket) Then
            Return context.Tickets.FirstOrDefault(Function(o) o.TicketID = id)
        Else
            Throw New Exception("Object's type is not present in Airline Database.")
        End If

        'Note: Stop is not here because it has a composite key



        context.SubmitChanges()

    End Function


    Public Shared Function GetList(Of T)(searchBy As String, searchFor As String) As List(Of T)
        searchBy = searchBy.ToLower()
        searchFor = searchFor.ToLower().Trim()

        If GetType(T) = GetType(Plane) Then
            Select Case searchBy
                Case "planeid"
                    Return (From plane In context.Planes Where plane.PlaneID.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "model"
                    Return (From plane In context.Planes Where plane.Model.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "manufacturer"
                    Return (From plane In context.Planes Where plane.Manufacturer.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "capacity"
                    Return (From plane In context.Planes Where plane.Capacity = Convert.ToDecimal(searchFor)).Cast(Of T).ToList()
                Case "maxcolumns"
                    Return (From plane In context.Planes Where plane.MaxColumns = Convert.ToDecimal(searchFor)).Cast(Of T).ToList()
                Case Else
                    Throw New Exception("Variable type is not present in Airline Database.")
            End Select

        ElseIf GetType(T) = GetType(User) Then 'no searching by password/salt
            Select Case searchBy
                Case "userid"
                    Return (From user In context.Users Where user.UserID.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "name"
                    Return (From user In context.Users Where user.Name.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "gender"
                    Return (From user In context.Users Where user.Gender = Convert.ToChar(searchFor)).Cast(Of T).ToList()
                Case "email"
                    Return (From user In context.Users Where user.Email.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "isregistered"
                    Return (From user In context.Users Where user.IsRegistered = Convert.ToBoolean(searchFor)).Cast(Of T).ToList()
                Case "dateofbirth"
                    Return (From user In context.Users Where user.UserID = Convert.ToDateTime(searchFor)).Cast(Of T).ToList()
                Case "phoneno"
                    Return (From user In context.Users Where user.PhoneNo.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "creditcardno"
                    Return (From user In context.Users Where user.CreditCardNo.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "country"
                    Return (From user In context.Users Where user.Country.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "city"
                    Return (From user In context.Users Where user.City.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "isstaff"
                    Return (From user In context.Users Where user.IsStaff = Convert.ToBoolean(searchFor)).Cast(Of T).ToList()
                Case Else
                    Throw New Exception("Variable type is not present in Airline Database.")
            End Select

        ElseIf GetType(T) = GetType(Booking) Then
            Select Case searchBy
                Case "bookingid"
                    Return (From booking In context.Bookings Where booking.BookingID.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "userid"
                    Return (From booking In context.Bookings Where booking.UserID.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "flightid"
                    Return (From booking In context.Bookings Where booking.FlightID.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "noofpassengers"
                    Return (From booking In context.Bookings Where booking.NoOfPassengers = Convert.ToDecimal(searchFor)).Cast(Of T).ToList()
                Case "totalprice"
                    Return (From booking In context.Bookings Where booking.TotalPrice = Convert.ToDecimal(searchFor)).Cast(Of T).ToList()
                Case "paymentdate"
                    Return (From booking In context.Bookings Where booking.PaymentDate = Convert.ToDateTime(searchFor)).Cast(Of T).ToList()
                Case "creditcardno"
                    Return (From booking In context.Bookings Where booking.CreditCardNo.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "iscancelled"
                    Return (From booking In context.Bookings Where booking.IsCancelled = Convert.ToBoolean(searchFor)).Cast(Of T).ToList()
                Case "extrabaggagekg"
                    Return (From booking In context.Bookings Where booking.ExtraBaggageKG = Convert.ToDecimal(searchFor)).Cast(Of T).ToList()
                Case "flightno"
                    Return (From booking In context.Bookings Where booking.Flight.FlightNo.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case Else
                    Throw New Exception("Variable type is not present in Airline Database.")
            End Select

        ElseIf GetType(T) = GetType(City) Then
            Select Case searchBy
                Case "cityid"
                    Return (From city In context.Cities Where city.CityID.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "name"
                    Return (From city In context.Cities Where city.Name.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "country"
                    Return (From city In context.Cities Where city.Country.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "state"
                    Return (From city In context.Cities Where city.State.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "longitude"
                    Return (From city In context.Cities Where city.Longitude.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "latitude"
                    Return (From city In context.Cities Where city.Latitude.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case Else
                    Throw New Exception("Variable type is not present in Airline Database.")
            End Select

        ElseIf GetType(T) = GetType(Flight) Then
            Select Case searchBy
                Case "flightid"
                    Return (From flight In context.Flights Where flight.FlightID.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "routeid"
                    Return (From flight In context.Flights Where flight.RouteID.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "planeid"
                    Return (From flight In context.Flights Where flight.PlaneID.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "departuretime"
                    Return (From flight In context.Flights Where flight.DepartureTime = Convert.ToDateTime(searchFor)).Cast(Of T).ToList()
                Case "arrivaltime"
                    Return (From flight In context.Flights Where flight.ArrivalTime = Convert.ToDateTime(searchFor)).Cast(Of T).ToList()
                Case "price"
                    Return (From flight In context.Flights Where flight.Price = Convert.ToDecimal(searchFor)).Cast(Of T).ToList()
                Case "isdaily"
                    Return (From flight In context.Flights Where flight.IsDaily = Convert.ToBoolean(searchFor)).Cast(Of T).ToList()
                Case Else
                    Throw New Exception("Variable type is not present in Airline Database.")
            End Select

        ElseIf GetType(T) = GetType(Route) Then
            Select Case searchBy
                Case "routeid"
                    Return (From route In context.Routes Where route.RouteID.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "durationhour"
                    Return (From route In context.Routes Where route.DurationHour = Convert.ToInt32(searchFor)).Cast(Of T).ToList()
                Case "durationmins"
                    Return (From route In context.Routes Where route.DurationMins = Convert.ToInt32(searchFor)).Cast(Of T).ToList()
                Case "city id"
                    Return (From route In context.Routes Where route.RouteID = (From [stop] In context.Stops Where [stop].CityID.Contains(searchFor)).First().RouteID).Cast(Of T).ToList()
                Case "city name"
                    Return (From route In context.Routes Where route.RouteID = (From [stop] In context.Stops Where [stop].City.Name.Contains(searchFor)).First().RouteID).Cast(Of T).ToList()
                Case "source city id"
                    Return (From route In context.Routes Where route.RouteID = (From [stop] In context.Stops Where [stop].CityID.Contains(searchFor) And [stop].IsOrigin = True).First().RouteID).Cast(Of T).ToList()
                Case "source city name"
                    Return (From route In context.Routes Where route.RouteID = (From [stop] In context.Stops Where [stop].City.Name.Contains(searchFor) And [stop].IsOrigin = True).First().RouteID).Cast(Of T).ToList()
                Case "destination city id"
                    Return (From route In context.Routes Where route.RouteID = (From [stop] In context.Stops Where [stop].CityID.Contains(searchFor) And [stop].IsOrigin = False).First().RouteID).Cast(Of T).ToList()
                Case "destination city name"
                    Return (From route In context.Routes Where route.RouteID = (From [stop] In context.Stops Where [stop].City.Name.Contains(searchFor) And [stop].IsOrigin = False).First().RouteID).Cast(Of T).ToList()
                Case Else
                    Throw New Exception("Variable type is not present in Airline Database.")
            End Select

        ElseIf GetType(T) = GetType(Ticket) Then
            Select Case searchBy
                Case "ticketid"
                    Return (From ticket In context.Tickets Where ticket.TicketID.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "bookingid"
                    Return (From ticket In context.Tickets Where ticket.BookingID.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "name"
                    Return (From ticket In context.Tickets Where ticket.Name.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case "seat"
                    Return (From ticket In context.Tickets Where ticket.Seat.ToLower().Contains(searchFor)).Cast(Of T).ToList()
                Case Else
                    Throw New Exception("Variable type is not present in Airline Database.")
            End Select

        Else
            Throw New Exception("Object's type is not present in Airline Database.")
        End If

        context.SubmitChanges()
    End Function


    Public Shared Function GetAll(Of T)() As List(Of T)
        If GetType(T) = GetType(Plane) Then
            Return context.Planes.ToList().Cast(Of T)().ToList() 'https://visualstudiomagazine.com/blogs/tool-tracker/2015/12/convert-list-types.aspx
        ElseIf GetType(T) = GetType(User) Then
            Return context.Users.ToList().Cast(Of T)().ToList()
        ElseIf GetType(T) = GetType(Booking) Then
            Return context.Bookings.ToList().Cast(Of T)().ToList()
        ElseIf GetType(T) = GetType(City) Then
            Return context.Cities.ToList().Cast(Of T)().ToList()
        ElseIf GetType(T) = GetType(Flight) Then
            Return context.Flights.ToList().Cast(Of T)().ToList()
        ElseIf GetType(T) = GetType(Route) Then
            Return context.Routes.ToList().Cast(Of T)().ToList()
        ElseIf GetType(T) = GetType(Ticket) Then
            Return context.Tickets.ToList().Cast(Of T)().ToList()
        Else
            Throw New Exception("Object's type is not present in Airline Database.")
        End If

        context.SubmitChanges()
    End Function

    Public Shared Function GetFlightSource(flightID As String) As [Stop]
        Return (From stops In context.Stops Where stops.RouteID = (From flight In context.Flights Where flight.FlightID = flightID).First().RouteID And stops.IsOrigin = True).First()
    End Function

    Public Shared Function GetFlightDestination(flightID As String) As [Stop]
        Return (From stops In context.Stops Where stops.RouteID = (From flight In context.Flights Where flight.FlightID = flightID).First().RouteID And stops.IsOrigin = False).First()
    End Function

    Public Shared Function GetRouteSource(routeId As String) As [Stop]
        Return (From stops In context.Stops Where stops.RouteID = routeId And stops.IsOrigin = True).First()
    End Function

    Public Shared Function GetRouteDestination(routeId As String) As [Stop]
        Return (From stops In context.Stops Where stops.RouteID = routeId And stops.IsOrigin = False).First()
    End Function

    Public Shared Sub Update(obj As Object, currentId As String)
        If TypeOf obj Is Plane Then
            'Update Plane
            Dim plane As Plane = [Get](Of Plane)(currentId)
            plane = CType(obj, Plane)

        ElseIf TypeOf obj Is User Then
            'Update User
            Dim user As User = [Get](Of User)(currentId)
            user = CType(obj, User)

        ElseIf TypeOf obj Is Booking Then
            'Update Booking
            Dim booking As Booking = [Get](Of Booking)(currentId)
            booking = CType(obj, Booking)
        ElseIf TypeOf obj Is City Then
            'Update City
            Dim city As City = [Get](Of City)(currentId)
            city = CType(obj, City)
        ElseIf TypeOf obj Is Flight Then
            'Update Flight
            Dim flight As Flight = [Get](Of Flight)(currentId)
            flight = CType(obj, Flight)
        ElseIf TypeOf obj Is Route Then
            'Update route
            Dim route As Route = [Get](Of Route)(currentId)
            route = CType(obj, Route)
        ElseIf TypeOf obj Is Ticket Then
            'Update ticket
            Dim ticket As Ticket = [Get](Of Ticket)(currentId)
            ticket = CType(obj, Ticket)
        Else
            Throw New Exception("Object's type is not present in Airline Database.")
        End If

        context.SubmitChanges()

    End Sub


    Public Shared Function GetCount(Of T)() As Integer

        If GetType(T) = GetType(User) Then
            Return Aggregate cust In context.Users Into Count()
        ElseIf GetType(T) = GetType(Booking) Then
            Return Aggregate booking In context.Bookings Into Count()
        ElseIf GetType(T) = GetType(City) Then
            Return Aggregate city In context.Cities Into Count()
        ElseIf GetType(T) = GetType(Flight) Then
            Return Aggregate flight In context.Flights Into Count()
        ElseIf GetType(T) = GetType(Route) Then
            Return Aggregate route In context.Routes Into Count()
        ElseIf GetType(T) = GetType(Plane) Then
            Return Aggregate plane In context.Planes Into Count()
        ElseIf GetType(T) = GetType(Ticket) Then
            Return Aggregate ticket In context.Tickets Into Count()
        Else
            Throw New Exception("Object's type is not present in Airline Database.")
        End If


    End Function

End Class
