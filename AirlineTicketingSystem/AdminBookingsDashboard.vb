Public Class AdminBookingsDashboard
    Private Sub AdminBookingsDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        Me.DoubleBuffered = True
        TitleBar.Load(Me, True)
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New AdminDashboard)
    End Sub

    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Quick.Navigate(Me, New AdminBookingsView)
    End Sub
End Class