Public Class AdminPlanesEdit
    Private plane As Plane = App.Session.Get("plane")
    Private Sub AdminPlanesEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        Me.DoubleBuffered = True
        TitleBar.Load(Me, True)

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
        Dim model As String = txtModel.Text
        Dim manufacturer As String = txtManufacturer.Text

        Dim errors As New List(Of String)
        Dim errorsFound As Boolean = False

        If String.IsNullOrEmpty(model) Then
            errors.Add("- [Model] must not be empty.")
        End If

        If String.IsNullOrEmpty(manufacturer) Then
            errors.Add("- [Manufacturer] must not be empty.")
        End If

        If Not errors.Count = 0 Then
            errorsFound = True
        End If

        If Not errorsFound Then
            Dim newPlane As Plane = DB.Get(Of Plane)(plane.PlaneID)
            newPlane.Model = model
            newPlane.Manufacturer = manufacturer

            DB.Update(newPlane, plane.PlaneID)

            If App.Session.Get("sourceScreen") = "add" Then
                App.Session.Delete("sourceScreen")
                Quick.Navigate(Me, New AdminPlanesAddSummary)

            ElseIf App.Session.Get("sourceScreen") = "view" Then
                App.Session.Delete("sourceScreen")
                Quick.Navigate(Me, New AdminPlanesViewSummary)

            Else
                Quick.Navigate(Me, New AdminDashboard)
            End If
        Else
            Quick.ShowErrors("Errors found!", errors)
        End If
    End Sub

    Private Sub TxtID_DoubleClick(sender As Object, e As EventArgs) Handles txtID.DoubleClick
        Quick.ShowWarning("Function disabled!", "[Plane ID] may not be edited.]")
    End Sub

    Private Sub TxtCapacity_DoubleClick(sender As Object, e As EventArgs) Handles txtCapacity.DoubleClick
        Quick.ShowWarning("Function disabled!", "[Capacity] may not be edited.]")
    End Sub

    Private Sub TxtMaxCols_DoubleClick(sender As Object, e As EventArgs) Handles txtMaxCols.DoubleClick
        Quick.ShowWarning("Function disabled!", "[Max cols] may not be edited.]")
    End Sub
End Class