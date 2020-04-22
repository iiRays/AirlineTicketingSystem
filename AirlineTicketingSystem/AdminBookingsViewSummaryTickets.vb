Public Class AdminBookingsViewSummaryTickets
    Private booking As Booking = App.Session.Get("booking")
    Private Sub AdminBookingsViewSummaryTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)

        Dim tickets As List(Of Ticket) = DB.GetList(Of Ticket)("BookingID", booking.BookingID)
        Dim loopCount As Integer = 0

        For Each ticket In tickets
            Dim ticketViewItem As New TicketViewItem()
            ticketViewItem.Location = New Point(130, 120 + (loopCount * 100))
            ticketViewItem.Ticket = ticket
            ticketViewItem.AdminBookingsViewSummaryTickets = Me
            Me.Controls.Add(ticketViewItem)
            loopCount += 1
        Next
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New AdminBookingsViewSummary)
    End Sub
End Class