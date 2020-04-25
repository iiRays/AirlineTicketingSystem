﻿Public Class FlightSearch
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Dim user = App.User
        If user IsNot Nothing Then
            If user.IsStaff Then
                Quick.Navigate(Me, New HomeAdmin)
            Else
                Quick.Navigate(Me, New HomeUser)
            End If
        Else
            Quick.Navigate(Me, HomeGuest)
        End If
    End Sub

    Private Sub FlightSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleBar.Load(Me)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        App.Session.Delete("flightResults")
        App.Session.Delete("selectedDate")

        If dtpDate.Value < (DateAndTime.Now()) Then
            Quick.ShowWarning("Wrong date", "Ensure that your selected date is at least 1 day after today.")
            Return
        End If

        Dim selectedDate = New Date(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day)

        Dim results As List(Of Flight) = (From flight In DB.context.Flights Where txtFrom.Text = (From stops In DB.context.Stops Where stops.IsOrigin = True And stops.RouteID = flight.RouteID).First.City.Name And txtTo.Text = (From stops In DB.context.Stops Where stops.IsOrigin = False And stops.RouteID = flight.RouteID).First.City.Name And flight.IsDaily Or (flight.DepartureTime.Day = selectedDate.Day And flight.DepartureTime.Month = selectedDate.Month And flight.DepartureTime.Year = selectedDate.Year)).ToList

        Dim filteredResults As New List(Of Flight)

        For Each flight In results

            If DB.GetTotalPassengers(flight.FlightID) < flight.Plane.Capacity Then

                If flight.IsDaily AndAlso DB.GetExistingFlight(flight, dtpDate.Value) Is Nothing Then
                    filteredResults.Add(flight)

                ElseIf flight.IsFlightInstance = True Then
                    filteredResults.Add(flight)
                Else
                    filteredResults.Add(flight)
                End If
            End If

        Next

        App.Session.Set("flightResults", results)
        App.Session.Set("selectedDate", selectedDate)

        Quick.Navigate(Me, New FlightList)
    End Sub

End Class