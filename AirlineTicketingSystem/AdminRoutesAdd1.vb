Public Class AdminRoutesAdd1
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchBy As String = cbSearchBy.SelectedItem
        Dim searchFor As String = If(String.IsNullOrEmpty(txtSearchFor.Text), "", txtSearchFor.Text)

        Dim cities As List(Of City) = DB.GetList(Of City)(searchBy, searchFor)
        Dim loopCount As Integer = 0

        For Each city In cities
            Dim cityAddItem As New CityAddItem()
            cityAddItem.Location = New Point(130, 120 + (loopCount * 50))
            cityAddItem.Form = "AdminRoutesAdd1"
            cityAddItem.City = city
            cityAddItem.AdminRoutesAdd1 = Me
            Me.Controls.Add(cityAddItem)
            loopCount += 1
        Next
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New AdminCitiesView)
    End Sub

    Private Sub AdminRoutesAdd1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)
    End Sub
End Class