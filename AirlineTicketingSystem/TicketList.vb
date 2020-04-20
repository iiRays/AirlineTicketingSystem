Public Class TicketList
    Private Booking As Booking
    Sub New(booking As Booking)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Booking = booking
    End Sub
    Private Sub TicketList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleBar.Load(Me)

        Dim loopCount = 0

        For Each ticket In Booking.Tickets
            Dim ticketItem As New TicketItem(ticket)
            ticketItem.Location = New Point(80, 162 + (loopCount * 180))
            Me.Controls.Add(ticketItem)
            loopCount += 1
        Next

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New BookingDetails(Booking))
    End Sub
End Class