Public Class AdminPlanesEdit
    Private plane As Plane = App.Session.Get("plane")
    Private Sub AdminPlanesEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)

        txtID.Text = plane.PlaneID
        txtModel.Text = plane.Model
        txtManufacturer.Text = plane.Manufacturer
        txtCapacity.Text = plane.Capacity.ToString()
        txtMaxCols.Text = plane.MaxColumns.ToString()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If App.Session.Get("sourceScreen") = "add" Then
            App.Session.Delete("sourceScreen")
            Quick.Navigate(Me, New AdminPlanesAddSummary)

        ElseIf App.Session.Get("sourceScreen") = "view" Then
            App.Session.Delete("sourceScreen")
            Quick.Navigate(Me, New AdminPlanesViewSummary)

        Else
            Quick.Navigate(Me, New AdminDashboard)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newPlane As Plane = DB.Get(Of Plane)(plane.PlaneID)
        newPlane.Model = txtModel.Text
        newPlane.Manufacturer = txtManufacturer.Text
        newPlane.Capacity = txtCapacity.Text.ToString() 'to add validation
        newPlane.MaxColumns = txtMaxCols.Text.ToString() 'to add validation

        If App.Session.Get("sourceScreen") = "add" Then
            App.Session.Delete("sourceScreen")
            Quick.Navigate(Me, New AdminPlanesAddSummary)

        ElseIf App.Session.Get("sourceScreen") = "view" Then
            App.Session.Delete("sourceScreen")
            Quick.Navigate(Me, New AdminPlanesViewSummary)

        Else
            Quick.Navigate(Me, New AdminDashboard)
        End If
    End Sub
End Class