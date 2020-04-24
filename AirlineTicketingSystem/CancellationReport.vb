Imports System.Drawing.Printing
Imports System.Text

Public Class CancellationReport

    Dim dbo As New AirlineSystemDataContext()
    Dim value As Integer = 1
    Dim intCounter As Integer = 30
    Dim total As Integer = 0

    Private Sub CancellationReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim nyear As String = Date.Today.Year.ToString

        For value As Integer = (CInt(nyear) - 2) To (CInt(nyear) + 2)
            cboYear.Items.Add(value)
        Next

        cboYear.Enabled = False
        cboDay.Enabled = False
        btnPrint.Enabled = False
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        cboYear.Enabled = True
    End Sub

    Public Function GetLastDayOfMonth(intMonth, intYear) As Date
        GetLastDayOfMonth = DateSerial(intYear, intMonth + 1, 0)
    End Function

    Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged
        cboDay.Enabled = True
    End Sub

    Private Sub Date_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged, cboMonth.SelectedIndexChanged

        cboDay.Items.Clear()

        Dim selectedMonth As Integer = cboMonth.SelectedIndex + 1
        Dim selectedYear As Integer = cboYear.SelectedItem
        Dim lastDay As Integer = GetLastDayOfMonth(selectedMonth, selectedYear).Day

        For value As Integer = 1 To lastDay
            cboDay.Items.Add(value)
        Next

    End Sub

    Private Sub cboDay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged, cboYear.SelectedIndexChanged, cboDay.SelectedIndexChanged
        lstLoss.Items.Clear()
        Try
            Dim selectedMonth As Integer = cboMonth.SelectedIndex + 1
            Dim selectedYear As Integer = cboYear.SelectedItem
            Dim selectedDay As Integer = cboDay.SelectedItem

            Dim selectedDate As Date = New DateTime(selectedYear, selectedMonth, selectedDay)

            Dim cnt As Integer = 0
            Dim totalLoss As Decimal = 0D

            For Each row1 In dbo.Flights

                Dim dbFlightDepart As String = row1.DepartureTime.ToString("MM/dd/yyyy")
                If selectedDate.ToString("MM/dd/yyyy") = dbFlightDepart Then

                    Dim passengerNo As Integer = 0
                    Dim loss As Decimal = 0D
                    For Each row2 In dbo.Bookings
                        If row1.FlightID = row2.FlightID And row2.IsCancelled = True Then
                            For Each row3 In dbo.Bookings
                                If row3.FlightID = row1.FlightID Then
                                    passengerNo += row3.NoOfPassengers
                                    loss += row3.TotalPrice * 0.1
                                End If
                            Next
                            totalLoss += loss
                            cnt += 1
                            total += 1
                            lstLoss.Items.Add(cnt & vbTab & row1.FlightNo & vbTab & passengerNo & vbTab & loss.ToString("                                 RM 00.00"))
                            Exit For

                        End If
                    Next
                End If
            Next

            If cnt = 0 Then
                lstLoss.Items.Add("No available result found")
                btnPrint.Enabled = False
            Else
                btnPrint.Enabled = True
            End If

            lblCount.Text = cnt.ToString + " item(s)"
            lblTotalLoss.Text = "Total: " + totalLoss.ToString("RM 00.00")
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

        lstLoss.Items.Clear()
        cboMonth.SelectedIndex = -1
        cboYear.SelectedIndex = -1
        lblTotalLoss.Text = Nothing
        lblCount.Text = Nothing
        total = 0
        value = 1
    End Sub

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Dim intCountPage As Integer = 1

        Dim selectedMonth As Integer = cboMonth.SelectedIndex + 1
        Dim selectedYear As Integer = cboYear.SelectedItem
        Dim selectedDay As Integer = cboDay.SelectedItem
        Dim cnt1 As Integer = 0

        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 15)
        Dim fontBody As New Font("Consilas", 12)

        Dim header As String = "AoZora Flight"
        Dim subHeader As String = String.Format(
                        "Generated on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
                        "Auto-generated by the system", DateTime.Now
                        )

        Dim title As New StringBuilder()
        title.AppendLine()
        title.AppendLine("-----------------------------------------------------------------------------------------------------------------------------")
        title.AppendLine()
        title.AppendLine("Daily Cancellation Report")
        title.AppendLine("For the Day " + selectedDay.ToString + " on Month of " + cboMonth.SelectedItem.ToString + " at the year " + selectedYear.ToString)
        title.AppendLine()
        title.AppendLine()
        title.AppendLine("No" + vbTab + vbTab + "Flight No" + vbTab + vbTab + "No Of Passenger(s) Cancel" + vbTab + "Refund (10%)")
        title.AppendLine("-----" + vbTab + vbTab + "--------------" + vbTab + vbTab + "---------------------------------------" + vbTab + "------------------")
        title.AppendLine()

        With e.Graphics
            .DrawImage(My.Resources.Logo, 130, 30, 150, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 330, 30)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 330, 70)
            .DrawString(title.ToString(), fontBody, Brushes.Black, 80, 150)
        End With

        Dim body As New StringBuilder()
        Dim parts() As String
        For value = value To lstLoss.Items.Count

            If value <= 30 Then
                cnt1 += 1
                parts = CStr(lstLoss.Items(value - 1)).Split(CChar(vbTab))
                body.AppendFormat("{0,0}" & vbTab & vbTab & "{1,0}" & vbTab & vbTab & vbTab & "{2,0}" & vbTab & vbTab & "{3,-5}" & vbNewLine, parts(0), parts(1), parts(2), parts(3))

                e.Graphics.DrawString(body.ToString(), fontBody, Brushes.Black, 80, 320)
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
                parts = CStr(lstLoss.Items(value - 1)).Split(CChar(vbTab))
                body.AppendFormat("{0,0}" & vbTab & vbTab & "{1,0}" & vbTab & vbTab & vbTab & "{2,0}" & vbTab & vbTab & "{3,-5}" & vbNewLine, parts(0), parts(1), parts(2), parts(3))

                Dim max As Integer = value + intCounter

                If value = max Then
                    e.HasMorePages = True
                    intCounter = 30
                    value += 1
                    intCountPage += 1
                End If
                e.Graphics.DrawString(body.ToString(), fontBody, Brushes.Black, 80, 320)
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
        footer.AppendFormat(vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + " Total Loss: {0,2}", lblTotalLoss.Text)
        footer.AppendLine()
        footer.AppendFormat("{0,2} record(s) out of", cnt1)
        footer.AppendFormat(" {0,2} record(s)", total)
        footer.AppendLine()
        footer.AppendFormat(" Page " & intCountPage)

        e.Graphics.DrawString(footer.ToString(), fontBody, Brushes.Black, 80, 1000)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Quick.Navigate(Me, New AdminReport)
    End Sub
End Class