Public Class TicketItem
	Private Ticket As Ticket

	Sub New(ticket As Ticket)

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub


	Private Sub TicketItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lblName.Text = Ticket.Name

		lblSeatColumn.Text = Ticket.Seat.Chars(Ticket.Seat.Length - 1)
		lblSeatRow.Text = Ticket.Seat.Substring(0, If(Ticket.Seat.Length > 2, 2, 1))
		lblTicketId.Text = Ticket.TicketID
	End Sub
End Class
