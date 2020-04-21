Imports System.Drawing.Printing
Imports System.Text

Public Class FlightScheduleReport
    Dim dbo As New AirlineSystemDataContext()
    Dim value As Integer = 1
    Dim intCounter As Integer = 30
    Dim total As Integer = 0

    Private Sub FlightScheduleReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim nyear As String = Date.Today.Year.ToString

        For value As Integer = (CInt(nyear) - 2) To CInt(nyear)
            cboYear.Items.Add(value)
        Next

        cboYear.Enabled = False
        cboDay.Enabled = False
        btnPrint.Enabled = False
    End Sub

    Public Function GetLastDayOfMonth(intMonth, intYear) As Date
        GetLastDayOfMonth = DateSerial(intYear, intMonth + 1, 0)
    End Function

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        cboYear.Enabled = True
    End Sub

    Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged

        cboDay.Items.Clear()

        Dim selectedMonth As Integer = cboMonth.SelectedIndex + 1
        Dim selectedYear As Integer = cboYear.SelectedItem
        Dim lastDay As Integer = GetLastDayOfMonth(selectedMonth, selectedYear).Day

        For value As Integer = 1 To lastDay
            cboDay.Items.Add(value)
        Next

        cboDay.Enabled = True

    End Sub

    Private Sub cboDay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged, cboYear.SelectedIndexChanged, cboDay.SelectedIndexChanged
        lstSchedule.Items.Clear()
        Try
            Dim selectedMonth As Integer = cboMonth.SelectedIndex + 1
            Dim selectedYear As Integer = cboYear.SelectedItem
            Dim selectedDay As Integer = cboDay.SelectedItem

            Dim selectedDate As Date = New DateTime(selectedYear, selectedMonth, selectedDay)

            Dim cnt As Integer = 0

            For Each row1 In dbo.Flights
                For Each row2 In dbo.Cities
                    For Each row3 In dbo.Stops
                        For Each row4 In dbo.Routes
                            Dim dbFlightDepart As String = row1.DepartureTime.ToString("MM/dd/yyyy")
                            If selectedDate.ToString("MM/dd/yyyy") = dbFlightDepart Then
                                If row1.RouteID = row4.RouteID And row3.CityID = row2.CityID And row4.RouteID = row3.RouteID And row3.IsOrigin = 0 Then
                                    Dim from As String = DB.GetFlightSource(row1.FlightID).City.Name
                                    Dim destination As String = DB.GetFlightDestination(row1.FlightID).City.Name
                                    cnt += 1
                                    total += 1
                                    lstSchedule.Items.Add(cnt & vbTab & row1.FlightNo & vbTab & from & vbTab & destination.ToString & vbTab & row1.DepartureTime.ToString("MM/dd/yyyy hh:mmtt") & vbTab & row1.ArrivalTime.ToString("MM/dd/yyyy hh:mmtt"))
                                    Exit For
                                End If
                            End If
                        Next
                    Next
                Next
            Next

            If cnt = 0 Then
                lstSchedule.Items.Add("No available result found")
                btnPrint.Enabled = False
            Else
                btnPrint.Enabled = True
            End If

            lblCount.Text = cnt.ToString + " item(s)"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        printDialog.PrinterSettings = doc.PrinterSettings

        If printDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            doc.PrinterSettings = printDialog.PrinterSettings

            Dim PageSetup As New PageSettings
            With PageSetup
                .Margins.Left = 50
                .Margins.Right = 50
                .Margins.Top = 50
                .Margins.Bottom = 50
                .Landscape = False
            End With
            doc.DefaultPageSettings = PageSetup
        End If

        dlgPreview.Document = doc
        dlgPreview.ShowDialog(Me)

        lstSchedule.Items.Clear()
        cboMonth.SelectedIndex = -1
        cboDay.SelectedIndex = -1
        cboYear.SelectedIndex = -1
        cboDay.Enabled = False
        cboYear.Enabled = False
        total = 0
        value = 1
    End Sub

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Dim intCountPage As Integer = 1

        Dim selectedMonth As Integer = cboMonth.SelectedIndex + 1
        Dim selectedYear As Integer = cboYear.SelectedItem
        Dim selectedDay As Integer = cboDay.SelectedItem
        Dim cnt1 As Integer = 0

        '(1) Fonts 
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 15)
        Dim fontBody As New Font("Consilas", 12)

        '(2) Prepare header and sub-header
        Dim header As String = "ABC Flight"
        Dim subHeader As String = String.Format(
                    "Generated on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
                    "Auto-generated by the system", DateTime.Now
                    )

        Dim title As New StringBuilder()
        title.AppendLine()
        title.AppendLine("----------------------------------------------------------------------------------------------------------------------------------")
        title.AppendLine()
        title.AppendLine("Daily Flight Route & Schedule Report")
        title.AppendLine("For the Day " + selectedDay.ToString + " on Month " + selectedMonth.ToString + " at the year " + selectedYear.ToString)
        title.AppendLine()
        title.AppendLine()
        title.AppendLine("No" + "   " + "Flight No." + vbTab + "From" + vbTab + vbTab + "To" + vbTab + vbTab + "Depart Date & Time" + vbTab + "Arrival Date & Time")
        title.AppendLine("---" + "     " + "--------------" + vbTab + "-----------------" + vbTab + "-----------------" + vbTab + "---------------------------" + vbTab + "--------------------------")
        title.AppendLine()

        With e.Graphics
            .DrawImage(My.Resources.TempLogo, 230, 30, 80, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 330, 30)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 330, 70)
            .DrawString(title.ToString(), fontBody, Brushes.Black, 50, 150)
        End With

        Dim body As New StringBuilder()
        Dim parts() As String
        For value = value To lstSchedule.Items.Count

            If value <= 30 Then
                cnt1 += 1
                parts = CStr(lstSchedule.Items(value - 1)).Split(CChar(vbTab))
                body.AppendFormat("{0,0}" & "     " & "{1,0}" & vbTab & "{2,10}" & vbTab & "{3,-5}" & vbTab & "{4,0}" & vbTab & "{5,0}" & vbNewLine, parts(0), parts(1), parts(2), parts(3), parts(4), parts(5))

                e.Graphics.DrawString(body.ToString(), fontBody, Brushes.Black, 50, 320)
                e.HasMorePages = False
                If value = 30 Then
                    e.HasMorePages = True
                    intCounter -= 1
                    value += 1
                    intCountPage += 1
                End If

                If e.HasMorePages = True Then
                    Exit For
                End If

            ElseIf value <= value + intCounter Then
                cnt1 += 1
                parts = CStr(lstSchedule.Items(value - 1)).Split(CChar(vbTab))
                body.AppendFormat("{0,0}" & vbTab & vbTab & "{1,0}" & vbTab & vbTab & vbTab & "{2,0}" & vbTab & vbTab & vbTab & "{3,-5}" & vbTab & vbTab & "{4,0}" & vbTab & vbTab & "{5,0}" & vbNewLine, parts(0), parts(1), parts(2), parts(3), parts(4), parts(5))

                Dim max As Integer = value + intCounter

                If value = max Then
                    e.HasMorePages = True
                    intCounter = 30
                    value += 1
                    intCountPage += 1
                End If
                e.Graphics.DrawString(body.ToString(), fontBody, Brushes.Black, 50, 320)
                intCounter -= 1

                If e.HasMorePages = True Then
                    Exit For
                End If
            Else
                e.HasMorePages = False
                Exit For
            End If
        Next

        Dim footer As New StringBuilder()
        footer.AppendLine()
        footer.AppendFormat("{0,2} record(s) out of", cnt1)
        footer.AppendFormat(" {0,2} record(s)", total)
        footer.AppendLine()
        footer.AppendFormat(" Page " & intCountPage)

        e.Graphics.DrawString(footer.ToString(), fontBody, Brushes.Black, 50, 1000)
    End Sub
End Class