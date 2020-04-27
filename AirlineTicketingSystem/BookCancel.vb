Public Class BookCancel
    Private Booking As Booking
    Public BookingDetailsForm As BookingDetails
    Private X As Integer
    Private IsMouseDown As Boolean = False

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(booking As Booking)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Booking = booking
    End Sub


    Private Sub btnCancel_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlCancel.MouseDown, lblCancel.MouseDown
        If e.Button = MouseButtons.Left Then
            IsMouseDown = True
            X = e.X
        End If
    End Sub

    Private Sub btnCancel_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlCancel.MouseUp, lblCancel.MouseUp
        If e.Button = MouseButtons.Left Then
            IsMouseDown = False
            pnlCancel.Location = New Point(0, pnlCancel.Location.Y)
        End If
    End Sub

    Private Sub Drag(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnlCancel.MouseMove, lblCancel.MouseMove
        If IsMouseDown AndAlso pnlCancel.Location.X >= 0 Then
            If pnlCancel.Location.X >= 463 Then
                btnCancel.Show()
                pnlCancelContainer.Hide()
                Return
            End If

            If pnlCancel.Location.X <= 463 Then

                If pnlCancel.Location.X >= 0 AndAlso pnlCancel.Location.X <= 463 Then
                    pnlCancel.Location = New Point(pnlCancel.Location.X + (e.X - X), pnlCancel.Location.Y)
                End If
            End If


        End If
    End Sub

    Private Sub BookingCancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleBar.Load(Me)
        pnlCancel.Location = New Point(0, pnlCancel.Location.Y)
        btnCancel.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Update booking in DB
        Booking.IsCancelled = True
        DB.Update(Booking, Booking.BookingID)

        'Send email
        Email.Send("Booking cancelled", "<h1>Booking cancelled</h1>We would like to inform you that your booking of <b>" & Booking.BookingID & "</b> to <b><i>" & DB.GetFlightDestination(Booking.FlightID).City.Name & "</i></b> has been cancelled. <br/> You have been refunded " & (Booking.TotalPrice * 0.1).ToString("RM 0.00"), Booking.User.Email)

        'Navigate
        BookingDetailsForm.UpdateBooking()
        Me.Close()
    End Sub
End Class