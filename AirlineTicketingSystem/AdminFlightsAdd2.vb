Public Class AdminFlightsAdd2
    Private Sub AdminFlightsAdd2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)

        cbSearchBy.SelectedIndex = 0
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        App.Session.Delete("route")
        Quick.Navigate(Me, New AdminFlightsAdd1)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        For Each control In Me.Controls
            If TypeOf control Is CityAddItem Then
                Me.Controls.Remove(control)
                control.Dispose()
            End If
        Next

        Dim searchBy As String = cbSearchBy.SelectedItem
        Dim searchFor As String = If(String.IsNullOrEmpty(txtSearchFor.Text), "", txtSearchFor.Text)

        Dim planes As List(Of Plane) = DB.GetList(Of Plane)(searchBy, searchFor)
        Dim loopCount As Integer = 0

        For Each plane In planes
            Dim planeAddItem As New PlaneAddItem()
            planeAddItem.Location = New Point(500, 250 + (loopCount * 50))
            planeAddItem.Form = "AdminFlightsAdd2"
            planeAddItem.Plane = plane
            planeAddItem.AdminFlightsAdd2 = Me
            Me.Controls.Add(planeAddItem)
            loopCount += 1
        Next
    End Sub
End Class