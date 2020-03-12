Public Class DBUtil
    Private Shared db As New AirlineSystemDataContext()
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

        db.SubmitChanges()

    End Sub

    Public Shared Sub Delete(obj As Object)

        If TypeOf obj Is Plane Then
            'Delete Plane
            db.Planes.DeleteOnSubmit(DBUtil.Get(CType(obj, Plane).PlaneID, "plane"))
        ElseIf TypeOf obj Is Customer Then
            'Delete Customer
            db.Customers.DeleteOnSubmit(DBUtil.Get(CType(obj, Customer).CustomerID, "customer"))
        ElseIf TypeOf obj Is Booking Then
            'Delete Booking
            db.Bookings.DeleteOnSubmit(DBUtil.Get(CType(obj, Booking).BookingID, "booking"))
        ElseIf TypeOf obj Is City Then
            'Delete City
            db.Cities.DeleteOnSubmit(DBUtil.Get(CType(obj, City).CityID, "city"))
        ElseIf TypeOf obj Is Flight Then
            'Delete Flight
            db.Flights.DeleteOnSubmit(DBUtil.Get(CType(obj, Flight).FlightID, "flight"))
        ElseIf TypeOf obj Is Route Then
            'Delete route
            db.Routes.DeleteOnSubmit(DBUtil.Get(CType(obj, Route).RouteID, "route"))
        ElseIf TypeOf obj Is [Stop] Then
            'Delete Stop
            db.Stops.DeleteOnSubmit(obj)
        ElseIf TypeOf obj Is Ticket Then
            'Delete ticket
            db.Tickets.DeleteOnSubmit(DBUtil.Get(CType(obj, Ticket).TicketID, "ticket"))
        Else
            Throw New Exception("Object's type is not present in Airline Database.")
        End If

        db.SubmitChanges()

    End Sub

    Public Shared Function [Get](id As String, type As String) As Object
        If type = "plane" Then
            Return db.Planes.FirstOrDefault(Function(o) o.PlaneID = id)
        ElseIf type = "customer" Then
            Return db.Customers.FirstOrDefault(Function(o) o.CustomerID = id)
        ElseIf type = "booking" Then
            Return db.Bookings.FirstOrDefault(Function(o) o.BookingID = id)
        ElseIf type = "city" Then
            Return db.Cities.FirstOrDefault(Function(o) o.CityID = id)
        ElseIf type = "flight" Then
            Return db.Flights.FirstOrDefault(Function(o) o.FlightID = id)
        ElseIf type = "route" Then
            Return db.Routes.FirstOrDefault(Function(o) o.RouteID = id)
        ElseIf type = "ticket" Then
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
            Dim plane As Plane = [Get](currentId, "plane")
            Dim newPlane As Plane = CType(obj, Plane)

            plane.Model = newPlane.Model
            plane.Manufacturer = newPlane.Manufacturer
            plane.Capacity = newPlane.Capacity


        ElseIf TypeOf obj Is Customer Then
            'Update Customer
            Dim cust As Customer = [Get](currentId, "customer")

        ElseIf TypeOf obj Is Booking Then
            'Update Booking
            Dim booking As Booking = [Get](currentId, "booking")
            booking = obj
        ElseIf TypeOf obj Is City Then
            'Update City
            Dim city As City = [Get](currentId, "city")
            city = obj
        ElseIf TypeOf obj Is Flight Then
            'Update Flight
            Dim flight As Plane = [Get](currentId, "flight")
            flight = obj
        ElseIf TypeOf obj Is Route Then
            'Update route
            Dim route As Plane = [Get](currentId, "route")
            route = obj
        ElseIf TypeOf obj Is Ticket Then
            'Update ticket
            Dim ticket As Ticket = [Get](currentId, "ticket")
            ticket = obj
        Else
            Throw New Exception("Object's type is not present in Airline Database.")
        End If

        db.SubmitChanges()

        db = New AirlineSystemDataContext()
    End Sub

End Class
