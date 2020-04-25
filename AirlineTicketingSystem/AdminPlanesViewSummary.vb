Public Class AdminPlanesViewSummary
    Private plane As Plane = App.Session.Get("plane")
    Private Sub AdminPlanesViewSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)

        lblId.Text = plane.PlaneID
        lblModel.Text = plane.Model
        lblManufacturer.Text = plane.Manufacturer
        lblCapacity.Text = plane.Capacity.ToString()
        lblMaxCols.Text = plane.MaxColumns.ToString()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        App.Session.Delete("plane")
        Quick.Navigate(Me, New AdminPlanesViewResults)
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        App.Session.Set("sourceScreen", "view")
        Quick.Navigate(Me, New AdminPlanesEdit)
    End Sub
End Class