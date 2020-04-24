﻿Imports System.Text

Public Class BookFlight2
    Private booking As Booking = App.Session.Get("Booking")
    Public AllSeatList As New List(Of String)

    Private Sub LoadAllSeats()
        Dim flight As Flight = App.Session.Get("selectedFlight")
        Dim totalRows = flight.Plane.Capacity / flight.Plane.MaxColumns

        For counter As Integer = 1 To totalRows
            'For each row 1-end

            For columnCounter As Integer = 1 To flight.Plane.MaxColumns
                'For each column A-end
                Dim seat = counter & Quick.IntToChar(columnCounter)
                If (From dbTicket In DB.context.Tickets Where dbTicket.Booking.Flight.FlightID = flight.FlightID And dbTicket.Seat = seat).FirstOrDefault Is Nothing Then
                    ' If seat is not taken
                    AllSeatList.Add(seat)
                End If
            Next


        Next
    End Sub

    Public Sub TakeSeat(seat As String, sender As Object)
        'Removes the seat from all dropdownlists except sender

        For Each cControl In Me.Controls
            If TypeOf cControl Is ComboBox Then
                Dim cboSeats = CType(cControl, ComboBox)
                If cboSeats IsNot sender Then
                    cboSeats.Items.Remove(seat)

                End If
            End If
        Next
    End Sub

    Private Sub BookFlight2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllSeats()
        TitleBar.Load(Me)
        Dim exists = True
        Dim generatedId = ""
        While exists
            generatedId = Quick.GetRandomString(6)
            If DB.Get(Of Booking)(generatedId) Is Nothing Then
                'Cannot find similar ID in db, can proceed
                exists = False
            End If
        End While

        booking.BookingID = generatedId

        For passengerCount As Integer = 0 To booking.NoOfPassengers - 1 Step 1
            'Add single passenger name textbox
            Dim passengerItem As New PassengerItem()
            passengerItem.Location = New Point(138, 193 + (passengerCount * 100))
            passengerItem.lblName.Text = "name " & (passengerCount + 1)
            passengerItem.Name = "txtPassenger" & (passengerCount + 1)
            passengerItem.bookFlightForm = Me
            For Each seat In AllSeatList
                passengerItem.cboSeat.Items.Add(seat)
            Next


            Me.Controls.Add(passengerItem)
        Next

        'Fill in the first passenger with user name is logged in
        If App.User IsNot Nothing Then
            CType(Me.Controls("txtPassenger1"), PassengerItem).txtName.Text = App.User.Name
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New BookFlight1)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim passengerList As New List(Of Ticket)

        Dim errorMsg As New StringBuilder()

        For passengerCount As Integer = 0 To booking.NoOfPassengers - 1 Step 1
            Dim ticket As New Ticket()
            Dim passengerItem As PassengerItem = CType(Me.Controls("txtPassenger" & (passengerCount + 1)), PassengerItem)
            ticket.BookingID = booking.BookingID
            ticket.Name = passengerItem.txtName.Text
            If ticket.Name.Length = 0 Then
                errorMsg.AppendLine("Passenger " & (passengerCount + 1) & "'s name is empty.")
            Else
                ticket.TicketID = Quick.GenerateId(Of Ticket)(DB.GetCount(Of Ticket) + passengerCount)
            End If

            If passengerItem.cboSeat.SelectedItem Is Nothing Then
                errorMsg.AppendLine("Passenger " & (passengerCount + 1) & "'s seat hasn't been chosen.")
            Else
                ticket.Seat = passengerItem.cboSeat.SelectedItem.ToString
            End If

            passengerList.Add(ticket)
        Next

        If errorMsg.Length > 0 Then
            Quick.ShowError("Error", errorMsg.ToString)
            Return
        End If

        'Add passenger names
        App.Session.Add("passengerList", passengerList)

        'Calculate price
        booking.TotalPrice = CType(App.Session.Get("selectedFlight"), Flight).Price * booking.NoOfPassengers + (15 * booking.ExtraBaggageKG)

        'Update session
        App.Session.Update("Booking", booking)

        'Navigate
        Quick.Navigate(Me, New BookingSummary)
    End Sub
End Class