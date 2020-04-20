Public Class AdminPlanesAdd
    Private Sub AdminPlanesAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New AdminPlanesDashboard)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim plane As New Plane
        plane.PlaneID = Quick.GenerateId(Of Plane)
        plane.Model = txtModel.Text
        plane.Manufacturer = txtManufacturer.Text
        plane.Capacity = Convert.ToInt32(txtCapacity.Text) 'to add validation
        plane.MaxColumns = Convert.ToInt32(txtMaxCols.Text) 'to add validation

        DB.Insert(plane)

        App.Session.Add("plane", plane)

        Quick.Navigate(Me, New AdminPlanesAddSummary)
    End Sub
End Class