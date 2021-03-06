﻿Public Class AdminRoutesEdit
    Private route As Route = App.Session.Get("route")
    Private Sub AdminRoutesEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        Me.DoubleBuffered = True
        TitleBar.Load(Me, True)

        If App.Session.Get("source") Is Nothing Then
            App.Session.Set("source", DB.GetRouteSource(route.RouteID).City)
        End If

        If App.Session.Get("destination") Is Nothing Then
            App.Session.Set("destination", DB.GetRouteDestination(route.RouteID).City)
        End If

        Dim source As City = App.Session.Get("source")
        Dim destination As City = App.Session.Get("destination")

        txtID.Text = route.RouteID
        txtSource.Text = source.Name
        txtDestination.Text = destination.Name
        txtHrs.Text = route.DurationHour.ToString()
        txtMins.Text = route.DurationMins.ToString()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Dim newRoute As Route = DB.Get(Of Route)(route.RouteID)
        'Dim newSource As [Stop] = DB.GetRouteSource(route.RouteID)
        ' Dim newDestination As [Stop] = DB.GetRouteDestination(route.RouteID)

        'newRoute.DurationHour = Convert.ToInt32(txtHrs.Text) 'to add validation
        'newRoute.DurationMins = Convert.ToInt32(txtMins.Text) 'to add validation

        'Dim source As City = App.Session.Get("source")
        'Dim destination As City = App.Session.Get("destination")

        'newSource.City = source 'newSource.CityID = source.CityID

        'newDestination.City = destination 'newDesination.CityID = destination.CityID

        'newRoute.Stops.Clear() '?????
        'newRoute.Stops.Add(newSource) '?????
        'newRoute.Stops.Add(newDestination) '?????

        'DB.Update(newRoute, route.RouteID)

        App.Session.Delete("source")
        App.Session.Delete("destination")

        If App.Session.Get("sourceScreen") = "add" Then
            App.Session.Delete("sourceScreen")
            Quick.Navigate(Me, New AdminRoutesAddSummary)

        ElseIf App.Session.Get("sourceScreen") = "view" Then
            App.Session.Delete("sourceScreen")
            Quick.Navigate(Me, New AdminRoutesViewSummary)

        Else
            Quick.Navigate(Me, New AdminDashboard)
        End If
    End Sub

    Private Sub BtnEditSource_Click(sender As Object, e As EventArgs) Handles btnEditSource.Click
        Quick.ShowWarning("Function disabled!", "[Source city] may not be edited.]")
        'Quick.Navigate(Me, New AdminRoutesEditSource)
    End Sub

    Private Sub BtnEditDestination_Click(sender As Object, e As EventArgs) Handles btnEditDestination.Click
        Quick.ShowWarning("Function disabled!", "[Destination city] may not be edited.]")
        'Quick.Navigate(Me, New AdminRoutesEditDestination)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If App.Session.Get("sourceScreen") = "add" Then
            App.Session.Delete("sourceScreen")
            Quick.Navigate(Me, New AdminRoutesAddSummary)

        ElseIf App.Session.Get("sourceScreen") = "view" Then
            App.Session.Delete("sourceScreen")
            Quick.Navigate(Me, New AdminRoutesViewSummary)

        Else
            Quick.Navigate(Me, New AdminDashboard)
        End If
    End Sub

    Private Sub TxtID_DoubleClick(sender As Object, e As EventArgs) Handles txtID.DoubleClick
        Quick.ShowWarning("Function disabled!", "[Route ID] may not be edited.]")
    End Sub

    Private Sub TxtSource_DoubleClick(sender As Object, e As EventArgs) Handles txtSource.DoubleClick
        Quick.ShowWarning("Function disabled!", "[Source city] may not be edited.]")
    End Sub

    Private Sub TxtDestination_DoubleClick(sender As Object, e As EventArgs) Handles txtDestination.DoubleClick
        Quick.ShowWarning("Function disabled!", "[Destination city] may not be edited.]")
    End Sub

    Private Sub TxtHrs_DoubleClick(sender As Object, e As EventArgs) Handles txtHrs.DoubleClick
        Quick.ShowWarning("Function disabled!", "[Hrs] may not be edited.]")
    End Sub

    Private Sub TxtMins_DoubleClick(sender As Object, e As EventArgs) Handles txtMins.DoubleClick
        Quick.ShowWarning("Function disabled!", "[Mins] may not be edited.]")
    End Sub
End Class