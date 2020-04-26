Public Class AdminCitiesAdd
    Private Sub AdminCitiesAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        Me.DoubleBuffered = True
        TitleBar.Load(Me, True)
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

        Dim errors As New List(Of String)
        Dim errorsFound As Boolean = False

        If String.IsNullOrEmpty(name) Then
            errors.Add("- [Name] must not be empty.")
        End If

        If String.IsNullOrEmpty(country) Then
            errors.Add("- [Country] must not be empty.")
        End If

        If String.IsNullOrEmpty(state) Then
            errors.Add("- [State] must not be empty.")
        End If

        Try
            Dim latitudeDec = Convert.ToDecimal(latitude)
        Catch ex As Exception
            errors.Add("- [Latitude] must be numeric.")
        End Try

        Try
            Dim longitudeDec = Convert.ToDecimal(longitude)
        Catch ex As Exception
            errors.Add("- [Longitude] must be numeric.")
        End Try

        If Not errors.Count = 0 Then
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
            Quick.ShowErrors("Errors found!", errors)
        End If
    End Sub
End Class