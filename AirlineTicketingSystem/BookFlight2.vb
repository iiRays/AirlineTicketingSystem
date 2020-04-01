﻿Public Class BookFlight2
    Private booking As Booking = App.Session.Get("Booking")
    Private Sub BookFlight2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        booking.BookingID = Quick.GenerateId(Of Booking)()

        For passengerCount As Integer = 0 To booking.NoOfPassengers - 1 Step 1
            'Add single passenger name textbox
            Dim passengerItem As New PassengerItem()
            passengerItem.Location = New Point(138, 193 + (passengerCount * 100))
            passengerItem.lblName.Text = "name " & (passengerCount + 1)
            passengerItem.Name = "txtPassenger" & (passengerCount + 1)
            Me.Controls.Add(passengerItem)
        Next

        'Fill in the first passenger with user name is logged in
        If App.Session.Get("user") IsNot Nothing Then
            CType(Me.Controls("txtPassenger1"), TextBox).Text = CType(App.Session.Get("user"), User).Name
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New BookFlight1)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim passengerList As New List(Of Ticket)

        For passengerCount As Integer = 0 To booking.NoOfPassengers - 1 Step 1
            Dim ticket As New Ticket()
            ticket.BookingID = booking.BookingID
            ticket.Name = CType(Me.Controls("txtPassenger" & (passengerCount + 1)), PassengerItem).txtName.Text
            ticket.Seat = "ECO"
            ticket.TicketID = Quick.GenerateId(Of Ticket)()
            passengerList.Add(ticket)
        Next

        'Add passenger names
        App.Session.Add("passengerList", passengerList)

        'Calculate price
        booking.TotalPrice = CType(App.Session.Get("selectedFlight"), Flight).Price + (15 * booking.NoOfPassengers)

        'Update session
        App.Session.Set("Booking", booking)

        'Navigate
        Quick.Navigate(Me, New BookingSummary)
    End Sub
End Class