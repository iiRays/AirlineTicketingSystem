﻿Public Class AdminUsersDashboard
    Private Sub AdminUsersDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New AdminDashboard)
    End Sub

    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Quick.Navigate(Me, New AdminUsersView)
    End Sub
End Class