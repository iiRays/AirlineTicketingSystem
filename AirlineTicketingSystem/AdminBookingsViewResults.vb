Public Class AdminBookingsViewResults
    Private Sub AdminBookingsViewResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)

        Dim bookings As List(Of Booking) = New List(Of Booking)
        Dim loopCount As Integer = 0

        Dim viewAll As Boolean = App.Session.Get("viewAll")

        If viewAll Then
            bookings = DB.GetAll(Of Booking)
        Else
            Dim searchBy As String = App.Session.Get("searchBy")
            Dim searchFor As String = App.Session.Get("searchFor")

            bookings = DB.GetList(Of Booking)(searchBy, searchFor)
        End If

        For Each booking In bookings
            Dim bookingViewItem As New BookingViewItem()
            bookingViewItem.Location = New Point(50, 120 + (loopCount * 100))
            bookingViewItem.Booking = booking
            bookingViewItem.AdminBookingsViewResults = Me
            Me.Controls.Add(bookingViewItem)
            loopCount += 1
        Next
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        App.Session.Delete("viewAll")
        App.Session.Delete("searchBy")
        App.Session.Delete("searchFor")
        Quick.Navigate(Me, New AdminBookingsView)
    End Sub
End Class