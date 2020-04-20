Public Class AdminPlanesAddSummary
    Private plane As Plane = App.Session.Get("plane")
    Private Sub AdminPlanesAddSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)

        lblId.Text = plane.PlaneID
        lblModel.Text = plane.Model
        lblManufacturer.Text = plane.Manufacturer
        lblCapacity.Text = plane.Capacity.ToString()
        lblMaxCols.Text = plane.MaxColumns.ToString()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        App.Session.Delete("plane")
        Quick.Navigate(Me, New AdminPlanesDashboard)
    End Sub

    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        DB.Delete(plane)
        App.Session.Delete("plane")
        Quick.Navigate(Me, New AdminPlanesDashboard)
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        App.Session.Add("sourceScreen", "add")
        Quick.Navigate(Me, New AdminPlanesEdit)
    End Sub
End Class