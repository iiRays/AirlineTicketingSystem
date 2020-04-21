Public Class AdminFlightsEditPlane
    Private Sub AdminFlightsEditPlane_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Quick.Navigate(Me, AdminFlightsEdit)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchBy As String = cbSearchBy.SelectedItem
        Dim searchFor As String = If(String.IsNullOrEmpty(txtSearchFor.Text), "", txtSearchFor.Text)

        Dim planes As List(Of Plane) = DB.GetList(Of Plane)(searchBy, searchFor)
        Dim loopCount As Integer = 0

        For Each plane In planes
            Dim planeAddItem As New PlaneAddItem()
            planeAddItem.Location = New Point(130, 120 + (loopCount * 50))
            planeAddItem.Form = "AdminFlightsEditPlane"
            planeAddItem.Plane = plane
            planeAddItem.AdminFlightsEditPlane = Me
            Me.Controls.Add(planeAddItem)
            loopCount += 1
        Next
    End Sub
End Class