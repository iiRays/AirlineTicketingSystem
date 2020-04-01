Public Class BookFlight2
    Private Sub BookFlight2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim booking As Booking = App.Session.Get("Booking")

        For passengerCount As Integer = 0 To booking.NoOfPassengers - 1 Step 1
            'Add single passenger name textbox
            Dim passengerItem As New PassengerItem()
            passengerItem.Location = New Point(138, 193 + (passengerCount * 100))
            passengerItem.lblName.Text = "name " & (passengerCount + 1)
            Me.Controls.Add(passengerItem)
        Next

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New BookFlight1)
    End Sub
End Class