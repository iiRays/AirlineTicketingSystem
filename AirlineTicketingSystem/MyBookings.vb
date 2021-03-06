﻿Public Class MyBookings
    Private Sub MyBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleBar.Load(Me)
        Dim user As User = App.User

        Dim bookingList As List(Of Booking) = (From booking In DB.context.Bookings Where booking.UserID = user.UserID Order By booking.PaymentDate).ToList
        bookingList.Reverse()

        Dim loopCount = 0

        For Each booking As Booking In bookingList
            Quick.Print("Size is " & bookingList.Count)
            Dim bookingItem As New BookingItem(booking)
            bookingItem.Location = New Point(80, 162 + (loopCount * 180))
            Me.Controls.Add(bookingItem)
            loopCount += 1
        Next
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New HomeUser)
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub
End Class