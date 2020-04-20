Public Class TicketList
    Public Booking As Booking
    Private Sub TicketList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleBar.Load(Me)

        Dim loopCount = 0

        For Each ticket In Booking.Tickets

        Next

    End Sub
End Class