Public Class AdminPlanesView
    Private Sub AdminPlanesView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        App.Session.Delete("viewAll")
        Quick.Navigate(Me, New AdminCitiesDashboard)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        App.Session.Set("viewAll", False)
        App.Session.Set("searchBy", cbSearchBy.SelectedItem)
        App.Session.Set("searchFor", txtSearchFor.Text)
        Quick.Navigate(Me, New AdminPlanesViewResults)
    End Sub

    Private Sub BtnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        App.Session.Set("viewAll", True)
        Quick.Navigate(Me, New AdminPlanesViewResults)
    End Sub
End Class