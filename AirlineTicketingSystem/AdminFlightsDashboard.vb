﻿Public Class AdminFlightsDashboard
    Private Sub AdminFlightsDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)
    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New AdminDashboard)
    End Sub

    Private Sub BtnFlights_Click(sender As Object, e As EventArgs) Handles btnFlights.Click
        'Quick.Navigate(Me, New ???)
    End Sub

    Private Sub BtnRoutes_Click(sender As Object, e As EventArgs) Handles btnRoutes.Click
        'Quick.Navigate(Me, New ???)
    End Sub
End Class