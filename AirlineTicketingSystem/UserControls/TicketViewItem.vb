Public Class TicketViewItem
    Public Ticket As Ticket
    Public AdminBookingsViewSummaryTickets As AdminBookingsViewSummaryTickets
    Private Sub TicketViewItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblId.Text = Ticket.TicketID
        lblName.Text = Ticket.Name
        lblSeat.Text = Ticket.Seat
    End Sub
End Class
