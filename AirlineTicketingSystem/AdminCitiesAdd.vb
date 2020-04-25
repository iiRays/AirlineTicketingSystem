Public Class AdminCitiesAdd
    Private Sub AdminCitiesAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True, False)
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New AdminCitiesDashboard)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim name As String = txtName.Text
        Dim country As String = txtCountry.Text
        Dim state As String = txtState.Text
        Dim latitude As String = txtLatitude.Text
        Dim longitude As String = txtLongitude.Text

        Dim errorMsg As String = ""
        Dim errorsFound As Boolean = False

        If String.IsNullOrEmpty(name) Then
            errorMsg += "- [Name] must not be empty." & vbNewLine
        End If

        If String.IsNullOrEmpty(country) Then
            errorMsg += "- [Country] must not be empty." & vbNewLine
        End If

        If String.IsNullOrEmpty(state) Then
            errorMsg += "- [State] must not be empty." & vbNewLine
        End If

        Try
            Dim latitudeDec = Convert.ToDecimal(latitude)
        Catch ex As Exception
            errorMsg += "- [Latitude] must be numeric." & vbNewLine
        End Try

        Try
            Dim longitudeDec = Convert.ToDecimal(longitude)
        Catch ex As Exception
            errorMsg += "- [Longitude] must be numeric." & vbNewLine
        End Try

        If Not errorMsg = "" Then
            errorsFound = True
        End If

        If Not errorsFound Then
            Dim city As New City
            city.CityID = Quick.GenerateId(Of City)
            city.Name = name
            city.Country = country
            city.State = state
            city.Latitude = latitude
            city.Longitude = longitude

            DB.Insert(city)

            App.Session.Set("city", city)

            Quick.Navigate(Me, New AdminCitiesAddSummary)
        Else
            MessageBox.Show("Errors found:" & vbNewLine & errorMsg, "Errors found!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class