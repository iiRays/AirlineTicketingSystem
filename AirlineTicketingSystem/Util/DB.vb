Public Class DB
    Public Shared context As New AirlineSystemDataContext()


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

        If GetType(T) = GetType(Plane) Then
            Select Case searchBy
                Case "planeid"
                    Return context.Planes.Where(Function(o) o.PlaneID = searchFor).ToList().Cast(Of T).ToList()
                Case "model"
                    Return context.Planes.Where(Function(o) o.Model = searchFor).ToList().Cast(Of T).ToList()
                Case "manufacturer"
                    Return context.Planes.Where(Function(o) o.Manufacturer = searchFor).ToList().Cast(Of T).ToList()
                Case "capacity"
                    Return context.Planes.Where(Function(o) o.Capacity = Convert.ToInt32(searchFor)).ToList().Cast(Of T).ToList()
                Case Else
                    Throw New Exception("Variable type is not present in Airline Database.")
            End Select

        ElseIf GetType(T) = GetType(User) Then 'no searching by password/salt
            Select Case searchBy
                Case "userid"
                    Return context.Users.Where(Function(o) o.UserID = searchFor).ToList().Cast(Of T).ToList()
                Case "name"
                    Return context.Users.Where(Function(o) o.Name = searchFor).ToList().Cast(Of T).ToList()
                Case "gender"
                    Return context.Users.Where(Function(o) o.Gender = Convert.ToChar(searchFor)).ToList().Cast(Of T).ToList()
                Case "email"
                    Return context.Users.Where(Function(o) o.Email = searchFor).ToList().Cast(Of T).ToList()
                Case "isregistered"
                    Return context.Users.Where(Function(o) o.IsRegistered = Convert.ToBoolean(searchFor)).ToList().Cast(Of T).ToList()
                Case "dateofbirth"
                    Return context.Users.Where(Function(o) o.DateOfBirth = Convert.ToDateTime(searchFor)).ToList().Cast(Of T).ToList()
                Case "phoneno"
                    Return context.Users.Where(Function(o) o.PhoneNo = searchFor).ToList().Cast(Of T).ToList()
                Case "creditcardno"
                    Return context.Users.Where(Function(o) o.CreditCardNo = searchFor).ToList().Cast(Of T).ToList()
                Case "country"
                    Return context.Users.Where(Function(o) o.Country = searchFor).ToList().Cast(Of T).ToList()
                Case "city"
                    Return context.Users.Where(Function(o) o.City = searchFor).ToList().Cast(Of T).ToList()
                Case "isstaff"
                    Return context.Users.Where(Function(o) o.IsStaff = Convert.ToBoolean(searchFor)).ToList().Cast(Of T).ToList()
                Case Else
                    Throw New Exception("Variable type is not present in Airline Database.")
            End Select

        ElseIf GetType(T) = GetType(Booking) Then
            Select Case searchBy
                Case "bookingid"
                    Return context.Bookings.Where(Function(o) o.BookingID = searchFor).ToList().Cast(Of T).ToList()
                Case "userid"
                    Return context.Bookings.Where(Function(o) o.UserID = searchFor).ToList().Cast(Of T).ToList()
                Case "noofpassengers"
                    Return context.Bookings.Where(Function(o) o.NoOfPassengers = Convert.ToInt32(searchFor)).ToList().Cast(Of T).ToList()
                Case "totalprice"
                    Return context.Bookings.Where(Function(o) o.TotalPrice = Convert.ToDecimal(searchFor)).ToList().Cast(Of T).ToList()
                Case "paymentdate"
                    Return context.Bookings.Where(Function(o) o.PaymentDate = Convert.ToDateTime(searchFor)).ToList().Cast(Of T).ToList()
                Case "creditcardno"
                    Return context.Bookings.Where(Function(o) o.CreditCardNo = searchFor).ToList().Cast(Of T).ToList()
                Case "iscancelled"
                    Return context.Bookings.Where(Function(o) o.IsCancelled = Convert.ToBoolean(searchFor)).ToList().Cast(Of T).ToList()
                Case "extrabaggagekg"
                    Return context.Bookings.Where(Function(o) o.ExtraBaggageKG = Convert.ToInt32(searchFor)).ToList().Cast(Of T).ToList()
                Case Else
                    Throw New Exception("Variable type is not present in Airline Database.")
            End Select

        ElseIf GetType(T) = GetType(City) Then
            Select Case searchBy
                Case "cityid"
                    Return context.Cities.Where(Function(o) o.CityID = searchFor).ToList().Cast(Of T).ToList()
                Case "name"
                    Return context.Cities.Where(Function(o) o.Name = searchFor).ToList().Cast(Of T).ToList()
                Case "country"
                    Return context.Cities.Where(Function(o) o.Country = searchFor).ToList().Cast(Of T).ToList()
                Case "state"
                    Return context.Cities.Where(Function(o) o.State = searchFor).ToList().Cast(Of T).ToList()
                Case "longitude"
                    Return context.Cities.Where(Function(o) o.Longitude = searchFor).ToList().Cast(Of T).ToList()
                Case "latitude"
                    Return context.Cities.Where(Function(o) o.Latitude = searchFor).ToList().Cast(Of T).ToList()
                Case Else
                    Throw New Exception("Variable type is not present in Airline Database.")
            End Select

        ElseIf GetType(T) = GetType(Flight) Then
            Select Case searchBy
                Case "flightid"
                    Return context.Flights.Where(Function(o) o.FlightID = searchFor).ToList().Cast(Of T).ToList()
                Case "routeid"
                    Return context.Flights.Where(Function(o) o.RouteID = searchFor).ToList().Cast(Of T).ToList()
                Case "planeid"
                    Return context.Flights.Where(Function(o) o.PlaneID = searchFor).ToList().Cast(Of T).ToList()
                Case "departuretime"
                    Return context.Flights.Where(Function(o) o.DepartureTime = Convert.ToDateTime(searchFor)).ToList().Cast(Of T).ToList()
                Case "arrivaltime"
                    Return context.Flights.Where(Function(o) o.ArrivalTime = Convert.ToDateTime(searchFor)).ToList().Cast(Of T).ToList()
                Case "price"
                    Return context.Flights.Where(Function(o) o.Price = Convert.ToDecimal(searchFor)).ToList().Cast(Of T).ToList()
                Case "isdaily"
                    Return context.Flights.Where(Function(o) o.IsDaily = Convert.ToBoolean(searchFor)).ToList().Cast(Of T).ToList()
                Case Else
                    Throw New Exception("Variable type is not present in Airline Database.")
            End Select

        ElseIf GetType(T) = GetType(Route) Then
            Select Case searchBy
                Case "routeid"
                    Return context.Routes.Where(Function(o) o.RouteID = searchFor).ToList().Cast(Of T).ToList()
                Case "durationhour"
                    Return context.Routes.Where(Function(o) o.DurationHour = Convert.ToInt32(searchFor)).ToList().Cast(Of T).ToList()
                Case "durationmins"
                    Return context.Routes.Where(Function(o) o.DurationMins = Convert.ToInt32(searchFor)).ToList().Cast(Of T).ToList()
                Case Else
                    Throw New Exception("Variable type is not present in Airline Database.")
            End Select

        ElseIf GetType(T) = GetType(Ticket) Then
            Select Case searchBy
                Case "ticketid"
                    Return context.Tickets.Where(Function(o) o.TicketID = searchFor).ToList().Cast(Of T).ToList()
                Case "bookingid"
                    Return context.Tickets.Where(Function(o) o.BookingID = searchFor).ToList().Cast(Of T).ToList()
                Case "name"
                    Return context.Tickets.Where(Function(o) o.Name = searchFor).ToList().Cast(Of T).ToList()
                Case "seat"
                    Return context.Tickets.Where(Function(o) o.Seat = searchFor).ToList().Cast(Of T).ToList()
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

    Public Shared Sub Update(obj As Object, currentId As String)
        If TypeOf obj Is Plane Then
            'Update Plane
            Dim plane As Plane = [Get](Of Plane)(currentId)
            Dim newPlane As Plane = CType(obj, Plane)

            plane.Model = newPlane.Model
            plane.Manufacturer = newPlane.Manufacturer
            plane.Capacity = newPlane.Capacity


        ElseIf TypeOf obj Is User Then
            'Update User
            Dim cust As User = [Get](Of User)(currentId)

        ElseIf TypeOf obj Is Booking Then
            'Update Booking
            Dim booking As Booking = [Get](Of Booking)(currentId)
            booking = obj
        ElseIf TypeOf obj Is City Then
            'Update City
            Dim city As City = [Get](Of City)(currentId)
            city = obj
        ElseIf TypeOf obj Is Flight Then
            'Update Flight
            Dim flight As Plane = [Get](Of Flight)(currentId)
            flight = obj
        ElseIf TypeOf obj Is Route Then
            'Update route
            Dim route As Plane = [Get](Of Route)(currentId)
            route = obj
        ElseIf TypeOf obj Is Ticket Then
            'Update ticket
            Dim ticket As Ticket = [Get](Of Ticket)(currentId)
            ticket = obj
        Else
            Throw New Exception("Object's type is not present in Airline Database.")
        End If

        context.SubmitChanges()

        context = New AirlineSystemDataContext()
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
