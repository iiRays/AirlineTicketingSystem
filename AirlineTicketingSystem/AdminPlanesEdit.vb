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
        Dim model As String = txtModel.Text
        Dim manufacturer As String = txtManufacturer.Text

        Dim errorMsg As String = ""
        Dim errorsFound As Boolean = False

        If String.IsNullOrEmpty(model) Then
            errorMsg += "- [Model] must not be empty." & vbNewLine
        End If

        If String.IsNullOrEmpty(manufacturer) Then
            errorMsg += "- [Manufacturer] must not be empty." & vbNewLine
        End If

        If Not errorMsg = "" Then
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
            MessageBox.Show("Errors found:" & vbNewLine & errorMsg, "Errors found!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TxtID_DoubleClick(sender As Object, e As EventArgs) Handles txtID.DoubleClick
        MessageBox.Show("[Plane ID] may not be edited.", "Function disabled!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub TxtCapacity_DoubleClick(sender As Object, e As EventArgs) Handles txtCapacity.DoubleClick
        MessageBox.Show("[Capacity] may not be edited.", "Function disabled!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub TxtMaxCols_DoubleClick(sender As Object, e As EventArgs) Handles txtMaxCols.DoubleClick
        MessageBox.Show("[Max cols] may not be edited.", "Function disabled!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
End Class