Public Class PassengerItem
    Public bookFlightForm As BookFlight2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub txtName1_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub PassengerItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cboSeat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSeat.SelectedIndexChanged
        bookFlightForm.TakeSeat(cboSeat.SelectedItem.ToString, sender)
    End Sub
End Class
