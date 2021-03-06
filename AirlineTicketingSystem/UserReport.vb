﻿Imports System.Drawing.Printing
Imports System.Text

Public Class UserReport
    Dim dbo As New AirlineSystemDataContext()
    Dim value As Integer = 1
    Dim intCounter As Integer = 30
    Dim total As Integer = 0

    Private Sub UserReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleBar.Load(Me)
        Dim cnt As Integer = 0
        btnPrint.Enabled = False
        cboCategory.SelectedIndex = 0
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        total = 0
        lstStatistic.Items.Clear()

        Dim category As String = cboCategory.SelectedItem
        Dim cnt As Integer = 0
        Try
            For Each row1 In dbo.Users
                If row1.Email = Nothing Then
                    cnt += 1
                    total += 1
                    lstStatistic.Items.Add(cnt & vbTab & String.Format("{0,-140}", row1.Name) & vbTab & "-")
                Else
                    If category = "All" Then
                        cnt += 1
                        total += 1
                        lstStatistic.Items.Add(cnt & vbTab & String.Format("{0,-140}", row1.Name) & vbTab & row1.Email)
                    ElseIf row1.IsStaff = False And category = "Customers" Then
                        cnt += 1
                        total += 1
                        lstStatistic.Items.Add(cnt & vbTab & String.Format("{0,-140}", row1.Name) & vbTab & row1.Email)
                    ElseIf row1.IsStaff = True And category = "Staffs" Then
                        cnt += 1
                        total += 1
                        lstStatistic.Items.Add(cnt & vbTab & String.Format("{0,-140}", row1.Name) & vbTab & row1.Email)
                    End If
                End If

            Next

            If cnt = 0 Then
                lstStatistic.Items.Add("No available result found")
                btnPrint.Enabled = False
            Else
                btnPrint.Enabled = True
            End If

            lblCount.Text = cnt.ToString + " item(s)"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        total = 0
        Dim cnt As Integer = 0
        Dim category As String = cboCategory.SelectedItem
        lstStatistic.Items.Clear()

        For Each row1 In dbo.Users
            If (row1.Name.ToUpper).Contains((txtSearch.Text).ToUpper) Then
                If row1.Email = Nothing Then
                    cnt += 1
                    total += 1
                    lstStatistic.Items.Add(cnt & vbTab & String.Format("{0,-140}", row1.Name) & vbTab & "-")
                Else
                    If category = "All" Then
                        cnt += 1
                        total += 1
                        lstStatistic.Items.Add(cnt & vbTab & String.Format("{0,-140}", row1.Name) & vbTab & row1.Email)
                    ElseIf row1.IsStaff = False And category = "Customers" Then
                        cnt += 1
                        total += 1
                        lstStatistic.Items.Add(cnt & vbTab & String.Format("{0,-140}", row1.Name) & vbTab & row1.Email)
                    ElseIf row1.IsStaff = True And category = "Staffs" Then
                        cnt += 1
                        total += 1
                        lstStatistic.Items.Add(cnt & vbTab & String.Format("{0,-140}", row1.Name) & vbTab & row1.Email)
                    End If
                End If
            End If

        Next

        If cnt = 0 Then
            lstStatistic.Items.Add("No available result found")
            btnPrint.Enabled = False
        Else
            btnPrint.Enabled = True
        End If

        lblCount.Text = cnt.ToString + " item(s)"
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

        lstStatistic.Items.Clear()
        cboCategory.SelectedIndex = -1
        txtSearch.Text = Nothing
        lblCount.Text = Nothing
        total = 0
        value = 1
    End Sub

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Dim intCountPage As Integer = 1

        Dim cnt1 As Integer = 0

        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 15)
        Dim fontBody As New Font("Consilas", 12)

        Dim header As String = "AOZORA Flight"
        Dim subHeader As String = String.Format(
                            "Generated on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
                            "Auto-generated by the system", DateTime.Now
                            )

        Dim title As New StringBuilder()
        title.AppendLine()
        title.AppendLine("-----------------------------------------------------------------------------------------------------------------------------")
        title.AppendLine()
        title.AppendLine("Staffs and Customers Report")
        title.AppendLine("For the " + cboCategory.SelectedItem.ToString + " Account")
        title.AppendLine()
        title.AppendLine()
        title.AppendLine("No" + vbTab + vbTab + "Name" + vbTab + vbTab + vbTab + vbTab + vbTab + "Email")
        title.AppendLine("-----" + vbTab + vbTab + "--------------------------------" + vbTab + vbTab + vbTab + "-----------------------------")
        title.AppendLine()

        With e.Graphics
            .DrawImage(My.Resources.Logo, 130, 30, 150, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 330, 30)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 330, 70)
            .DrawString(title.ToString(), fontBody, Brushes.Black, 80, 150)
        End With

        Dim body As New StringBuilder()
        Dim parts() As String
        For value = value To lstStatistic.Items.Count

            If value <= 30 Then
                cnt1 += 1
                parts = CStr(lstStatistic.Items(value - 1)).Split(CChar(vbTab))
                body.AppendFormat("{0,0}" & vbTab & vbTab & "{1,-40}" & vbTab & vbTab & "{2,0}" & vbNewLine, parts(0), parts(1).Trim, parts(2))

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
                parts = CStr(lstStatistic.Items(value - 1)).Split(CChar(vbTab))
                body.AppendFormat("{0,0}" & vbTab & vbTab & "{1,-40}" & vbTab & "{2,0}" & vbNewLine, parts(0), parts(1), parts(2))

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
        footer.AppendFormat("{0,2} record(s) out of", cnt1)
        footer.AppendFormat(" {0,2} record(s)", total)
        footer.AppendLine()
        footer.AppendFormat(" Page " & intCountPage)

        e.Graphics.DrawString(footer.ToString(), fontBody, Brushes.Black, 80, 1000)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        total = 0
        Quick.Navigate(Me, New AdminReport)
    End Sub

End Class
