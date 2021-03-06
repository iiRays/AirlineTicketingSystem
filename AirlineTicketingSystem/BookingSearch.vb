﻿Public Class BookingSearch
    Private Sub BookingSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        TitleBar.Load(Me)
        'AddHandler txtBookingID., AddressOf btSearch_Click
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If App.IsLoggedIn Then
            Quick.Navigate(Me, New HomeUser)
        Else
            Quick.Navigate(Me, New HomeGuest)
        End If
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        Search(txtBookingID.Text)
    End Sub

    Public Sub Search(bookingID As String)
        Dim booking As Booking = DB.Get(Of Booking)(bookingID)
        If booking Is Nothing Then
            Quick.ShowError("Incorrect booking ID", "No booking with this ID can be found.")
            Return
        End If
        Quick.Navigate(Me, New BookingDetails(booking))
    End Sub
End Class