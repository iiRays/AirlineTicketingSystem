﻿Public Class AdminCitiesEdit
    Private city As City = App.Session.Get("city")
    Private Sub AdminCitiesEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        Me.DoubleBuffered = True
        TitleBar.Load(Me, True)

        txtID.Text = city.CityID
        txtName.Text = city.Name
        txtCountry.Text = city.Country
        txtState.Text = city.State
        txtLatitude.Text = city.Latitude
        txtLongitude.Text = city.Longitude
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If App.Session.Get("sourceScreen") = "add" Then
            App.Session.Delete("sourceScreen")
            Quick.Navigate(Me, New AdminCitiesAddSummary)

        ElseIf App.Session.Get("sourceScreen") = "view" Then
            App.Session.Delete("sourceScreen")
            Quick.Navigate(Me, New AdminCitiesViewSummary)

        Else
            Quick.Navigate(Me, New AdminDashboard)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
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
            Dim newCity As City = DB.Get(Of City)(city.CityID)
            newCity.Name = name
            newCity.Country = country
            newCity.State = state
            newCity.Latitude = latitude
            newCity.Longitude = longitude

            DB.Update(newCity, city.CityID)

            If App.Session.Get("sourceScreen") = "add" Then
                App.Session.Delete("sourceScreen")
                Quick.Navigate(Me, New AdminCitiesAddSummary)

            ElseIf App.Session.Get("sourceScreen") = "view" Then
                App.Session.Delete("sourceScreen")
                Quick.Navigate(Me, New AdminCitiesViewSummary)

            Else
                Quick.Navigate(Me, New AdminDashboard)
            End If
        Else
            Quick.ShowErrors("Errors found!", errors)
        End If
    End Sub

    Private Sub TxtID_DoubleClick(sender As Object, e As EventArgs) Handles txtID.DoubleClick
        Quick.ShowWarning("Function disabled!", "City ID may not be edited.")
    End Sub
End Class