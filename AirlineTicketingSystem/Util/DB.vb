Public Class DB
    Public Shared context As New AirlineSystemDataContext()
    Public Shared Sub Insert(obj As Object)

        If TypeOf obj Is Plane Then
            'Insert Plane
            context.Planes.InsertOnSubmit(obj)
        ElseIf TypeOf obj Is Customer Then
            'Insert Customer
            context.Customers.InsertOnSubmit(obj)
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
        ElseIf TypeOf obj Is Customer Then
            'Delete Customer
            context.Customers.DeleteOnSubmit(AirlineTicketingSystem.DB.Get(Of Customer)(CType(obj, Customer).CustomerID))
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
        ElseIf GetType(T) = GetType(Customer) Then
            Return context.Customers.FirstOrDefault(Function(o) o.CustomerID = id)
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


    Public Shared Function GetAll(Of T)() As List(Of T)
        If GetType(T) = GetType(Plane) Then
            Return context.Planes.ToList().Cast(Of T)().ToList() 'https://visualstudiomagazine.com/blogs/tool-tracker/2015/12/convert-list-types.aspx
        ElseIf GetType(T) = GetType(Customer) Then
            Return context.Customers.ToList().Cast(Of T)().ToList()
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
        Return context.Stops.FirstOrDefault(Function(o) o.FlightID = flightID And o.IsOrigin = True)
        context.SubmitChanges()
    End Function

    Public Shared Function GetFlightDestination(flightID As String) As [Stop]
        Return context.Stops.FirstOrDefault(Function(o) o.FlightID = flightID And o.IsOrigin = False)
        context.SubmitChanges()
    End Function

    Public Shared Sub Update(obj As Object, currentId As String)
        If TypeOf obj Is Plane Then
            'Update Plane
            Dim plane As Plane = [Get](Of Plane)(currentId)
            Dim newPlane As Plane = CType(obj, Plane)

            plane.Model = newPlane.Model
            plane.Manufacturer = newPlane.Manufacturer
            plane.Capacity = newPlane.Capacity


        ElseIf TypeOf obj Is Customer Then
            'Update Customer
            Dim cust As Customer = [Get](Of Customer)(currentId)

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

        If GetType(T) = GetType(Customer) Then
            Return Aggregate cust In context.Customers Into Count()
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
