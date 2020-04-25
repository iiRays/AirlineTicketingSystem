Public Class AdminPlanesAdd
    Private Sub AdminPlanesAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New AdminPlanesDashboard)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim model As String = txtModel.Text
        Dim manufacturer As String = txtManufacturer.Text
        Dim capacityStr As String = txtCapacity.Text
        Dim maxColsStr As String = txtMaxCols.Text
        Dim capacity As Integer
        Dim maxCols As Integer

        Dim errorMsg As String = ""
        Dim errorsFound As Boolean = False

        If String.IsNullOrEmpty(model) Then
            errorMsg += "- [Model] must not be empty." & vbNewLine
        End If

        If String.IsNullOrEmpty(manufacturer) Then
            errorMsg += "- [Manufacturer] must not be empty." & vbNewLine
        End If

        Try
            capacity = Convert.ToInt32(capacityStr)
        Catch ex As Exception
            errorMsg += "- [Capacity] must be numeric." & vbNewLine
        End Try

        Try
            maxCols = Convert.ToInt32(maxColsStr)
        Catch ex As Exception
            errorMsg += "- [Max cols] must be numeric." & vbNewLine
        End Try

        If Not errorMsg = "" Then
            errorsFound = True
        End If

        If Not errorsFound Then
            Dim plane As New Plane
            plane.PlaneID = Quick.GenerateId(Of Plane)
            plane.Model = txtModel.Text
            plane.Manufacturer = txtManufacturer.Text
            plane.Capacity = Convert.ToInt32(txtCapacity.Text)
            plane.MaxColumns = Convert.ToInt32(txtMaxCols.Text)

            DB.Insert(plane)

            App.Session.Set("plane", plane)

            Quick.Navigate(Me, New AdminPlanesAddSummary)
        Else
            MessageBox.Show("Errors found:" & vbNewLine & errorMsg, "Errors found!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class