Public Class AdminCitiesView
    Private Sub AdminCitiesView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        App.Session.Delete("viewAll")
        Quick.Navigate(Me, New AdminCitiesDashboard)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        App.Session.Add("viewAll", False)
        App.Session.Add("searchBy", cbSearchBy.SelectedItem)
        App.Session.Add("searchFor", txtSearchFor.Text)
        Quick.Navigate(Me, New AdminCitiesViewResults)
    End Sub

    Private Sub BtnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        App.Session.Add("viewAll", True)
        Quick.Navigate(Me, New AdminCitiesViewResults)
    End Sub
End Class