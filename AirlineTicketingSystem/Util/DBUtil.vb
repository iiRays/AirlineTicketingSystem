Public Class DBUtil
    Public Shared db As New AirlineSystemDataContext()
    Public Shared Sub Insert(obj As Object)

        If TypeOf obj Is Plane Then
            'Insert Plane
            db.Planes.InsertOnSubmit(obj)
        ElseIf TypeOf obj Is Customer Then
            'Insert Customer
            db.Customers.InsertOnSubmit(obj)
        ElseIf TypeOf obj Is Booking Then
            'Insert Booking
            db.Bookings.InsertOnSubmit(obj)
        ElseIf TypeOf obj Is City Then
            'Insert City
            db.Cities.InsertOnSubmit(obj)
        ElseIf TypeOf obj Is Flight Then
            'Insert Flight
            db.Flights.InsertOnSubmit(obj)
        ElseIf TypeOf obj Is Route Then
            'Insert route
            db.Routes.InsertOnSubmit(obj)
        ElseIf TypeOf obj Is [Stop] Then
            'Insert Stop
            db.Stops.InsertOnSubmit(obj)
        ElseIf TypeOf obj Is Ticket Then
            'Insert ticket
            db.Tickets.InsertOnSubmit(obj)
        Else
            Throw New Exception("Object's type is not present in Airline Database.")
        End If

        Try
            db.SubmitChanges()
        Catch ex As SqlClient.SqlException
            Quick.Print(ex.Message)
        End Try


    End Sub

    Public Shared Sub Delete(obj As Object)

        If TypeOf obj Is Plane Then
            'Delete Plane
            db.Planes.DeleteOnSubmit(DBUtil.Get(Of Plane)(CType(obj, Plane).PlaneID))
        ElseIf TypeOf obj Is Customer Then
            'Delete Customer
            db.Customers.DeleteOnSubmit(DBUtil.Get(Of Customer)(CType(obj, Customer).CustomerID))
        ElseIf TypeOf obj Is Booking Then
            'Delete Booking
            db.Bookings.DeleteOnSubmit(DBUtil.Get(Of Booking)(CType(obj, Booking).BookingID))
        ElseIf TypeOf obj Is City Then
            'Delete City
            db.Cities.DeleteOnSubmit(DBUtil.Get(Of City)(CType(obj, City).CityID))
        ElseIf TypeOf obj Is Flight Then
            'Delete Flight
            db.Flights.DeleteOnSubmit(DBUtil.Get(Of Flight)(CType(obj, Flight).FlightID))
        ElseIf TypeOf obj Is Route Then
            'Delete route
            db.Routes.DeleteOnSubmit(DBUtil.Get(Of Route)(CType(obj, Route).RouteID))
        ElseIf TypeOf obj Is [Stop] Then
            'Delete Stop
            db.Stops.DeleteOnSubmit(obj)
        ElseIf TypeOf obj Is Ticket Then
            'Delete ticket
            db.Tickets.DeleteOnSubmit(DBUtil.Get(Of Ticket)(CType(obj, Ticket).TicketID))
        Else
            Throw New Exception("Object's type is not present in Airline Database.")
        End If

        db.SubmitChanges()

    End Sub

    Public Shared Function [Get](Of T)(id As String) As Object
        If GetType(T) = GetType(Plane) Then
            Return db.Planes.FirstOrDefault(Function(o) o.PlaneID = id)
        ElseIf GetType(T) = GetType(Customer) Then
            Return db.Customers.FirstOrDefault(Function(o) o.CustomerID = id)
        ElseIf GetType(T) = GetType(Booking) Then
            Return db.Bookings.FirstOrDefault(Function(o) o.BookingID = id)
        ElseIf GetType(T) = GetType(City) Then
            Return db.Cities.FirstOrDefault(Function(o) o.CityID = id)
        ElseIf GetType(T) = GetType(Flight) Then
            Return db.Flights.FirstOrDefault(Function(o) o.FlightID = id)
        ElseIf GetType(T) = GetType(Route) Then
            Return db.Routes.FirstOrDefault(Function(o) o.RouteID = id)
        ElseIf GetType(T) = GetType(Ticket) Then
            Return db.Tickets.FirstOrDefault(Function(o) o.TicketID = id)
        Else
            Throw New Exception("Object's type is not present in Airline Database.")
        End If

        'Note: Stop is not here because it has a composite key



        db.SubmitChanges()

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

        db.SubmitChanges()

        db = New AirlineSystemDataContext()
    End Sub

    Public Shared Function GetCount(Of T)() As Integer

        If GetType(T) = GetType(Customer) Then
            Return Aggregate cust In db.Customers Into Count()
        ElseIf GetType(T) = GetType(Booking) Then
            Return Aggregate booking In db.Bookings Into Count()
        ElseIf GetType(T) = GetType(City) Then
            Return Aggregate city In db.Cities Into Count()
        ElseIf GetType(T) = GetType(Flight) Then
            Return Aggregate flight In db.Flights Into Count()
        ElseIf GetType(T) = GetType(Route) Then
            Return Aggregate route In db.Routes Into Count()
        ElseIf GetType(T) = GetType(Plane) Then
            Return Aggregate plane In db.Planes Into Count()
        ElseIf GetType(T) = GetType(Ticket) Then
            Return Aggregate ticket In db.Tickets Into Count()
        Else
            Throw New Exception("Object's type is not present in Airline Database.")
        End If


    End Function

End Class
