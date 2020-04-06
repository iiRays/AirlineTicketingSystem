Public Class BookFlight2
    Private booking As Booking = App.Session.Get("Booking")
    Private Sub BookFlight2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        For passengerCount As Integer = 0 To booking.NoOfPassengers - 1 Step 1
            Dim ticket As New Ticket()
            ticket.BookingID = booking.BookingID
            ticket.Name = CType(Me.Controls("txtPassenger" & (passengerCount + 1)), PassengerItem).txtName.Text
            If ticket.Name.Length = 0 Then
                Quick.ShowError("Missing passengers", "Passenger " & (passengerCount + 1) & " is empty.")
                Return
            End If
            ticket.Seat = "ECO"
            ticket.TicketID = Quick.GenerateId(Of Ticket)(DB.GetCount(Of Ticket) + passengerCount)
            passengerList.Add(ticket)
        Next

        'Add passenger names
        App.Session.Add("passengerList", passengerList)

        'Calculate price
        booking.TotalPrice = CType(App.Session.Get("selectedFlight"), Flight).Price * booking.NoOfPassengers + (15 * booking.ExtraBaggageKG)

        'Update session
        App.Session.Set("Booking", booking)

        'Navigate
        Quick.Navigate(Me, New BookingSummary)
    End Sub
End Class