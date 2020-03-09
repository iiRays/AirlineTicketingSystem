Public Class DBUtil
    Public Shared Sub Insert(obj As Object)
        Dim db As New AirlineSystemDataContext

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
            'Insert route
            db.Tickets.InsertOnSubmit(obj)
        Else
            Throw New Exception("Object's type is not present in Airline Database.")
        End If

        db.SubmitChanges()

    End Sub
End Class
