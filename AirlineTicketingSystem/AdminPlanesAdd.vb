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

        Dim errors As New List(Of String)
        Dim errorsFound As Boolean = False

        If String.IsNullOrEmpty(model) Then
            errors.Add("- [Model] must not be empty.")
        End If

        If String.IsNullOrEmpty(manufacturer) Then
            errors.Add("- [Manufacturer] must not be empty.")
        End If

        Try
            capacity = Convert.ToInt32(capacityStr)
        Catch ex As Exception
            errors.Add("- [Capacity] must be numeric.")
        End Try

        Try
            maxCols = Convert.ToInt32(maxColsStr)
        Catch ex As Exception
            errors.Add("- [Max cols] must be numeric.")
        End Try

        If Not errors.Count = 0 Then
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
            Quick.ShowErrors("Errors found!", errors)
        End If
    End Sub
End Class