Imports System.Text

Public Class BookFlight2
    Private booking As Booking = App.Session.Get("Booking")
    Public AllSeatList As New List(Of String)

    Private Sub LoadAllSeats()
        Dim flight As Flight = App.Session.Get("selectedFlight")
        Dim plane = DB.Get(Of Plane)(flight.PlaneID)
        Dim totalRows = plane.Capacity / plane.MaxColumns

        For counter As Integer = 1 To totalRows
            'For each row 1-end

            For columnCounter As Integer = 1 To plane.MaxColumns
                'For each column A-end
                Dim seat = counter & Quick.IntToChar(columnCounter)
                If (From dbTicket In DB.context.Tickets Where dbTicket.Booking.Flight.FlightID = flight.FlightID And dbTicket.Seat = seat).FirstOrDefault Is Nothing Then
                    ' If seat is not taken
                    AllSeatList.Add(seat)
                End If
            Next


        Next
    End Sub

    Public Sub TakeSeat(newSeat As String, previousSeat As String, senderName As String)
        'Removes the seat from all dropdownlists except sender

        If newSeat Is previousSeat Then
            Return
        End If

        For counter As Integer = 1 To booking.NoOfPassengers
            Dim passengerItem As PassengerItem = CType(Me.Controls("passengerItem" & counter), PassengerItem)
            If passengerItem.Name IsNot senderName Then
                passengerItem.cboSeat.Items.Remove(newSeat)
                'Add back previous one

                If previousSeat IsNot Nothing AndAlso previousSeat IsNot "" Then
                    passengerItem.cboSeat.Items.Add(previousSeat)

                End If

            End If
        Next


    End Sub

    Private Sub BookFlight2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNext.Hide()
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
            passengerItem.Name = "passengerItem" & (passengerCount + 1)
            passengerItem.bookFlightForm = Me
            For Each seat In AllSeatList
                passengerItem.cboSeat.Items.Add(seat)
            Next

            AddHandler passengerItem.txtName.TextChanged, AddressOf LockButton
            AddHandler passengerItem.cboSeat.SelectedIndexChanged, AddressOf LockButton

            Me.Controls.Add(passengerItem)
        Next

        'Fill in the first passenger with user name is logged in
        If App.User IsNot Nothing Then
            CType(Me.Controls("passengerItem1"), PassengerItem).txtName.Text = App.User.Name
        End If

    End Sub

    Private Sub LockButton()
        Dim hasError = False
        For passengerCount As Integer = 0 To booking.NoOfPassengers - 1 Step 1
            Dim ticket As New Ticket()
            Dim passengerItem As PassengerItem = CType(Me.Controls("passengerItem" & (passengerCount + 1)), PassengerItem)
            ticket.BookingID = booking.BookingID
            ticket.Name = passengerItem.txtName.Text
            If ticket.Name.Length = 0 Then
                hasError = True
            End If

            If passengerItem.cboSeat.SelectedItem Is Nothing Then
                hasError = True
            End If

        Next

        If hasError Then
            btnNext.Hide()
        Else
            btnNext.Show()
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
            Dim passengerItem As PassengerItem = CType(Me.Controls("passengerItem" & (passengerCount + 1)), PassengerItem)
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

        If errorMsg.ToString.Trim.Length > 0 Then
            Quick.ShowError("Error", errorMsg.ToString)
            Return
        End If

        'Add passenger names
        App.Session.Set("passengerList", passengerList)

        'Calculate price
        booking.TotalPrice = CType(App.Session.Get("selectedFlight"), Flight).Price * booking.NoOfPassengers + (15 * booking.ExtraBaggageKG)

        'Update session
        App.Session.Update("Booking", booking)

        'Navigate
        Quick.Navigate(Me, New BookingSummary)
    End Sub
End Class