Imports System.Text

Public Class ErrorMsg
    Private ErrorStr As New StringBuilder()
    Private AdditionalHeight As Integer
    Private ErrorCount As Integer
    Public ErrorTitle As String
    Private LineCount As Integer

    Public Sub Add(errorLine As String)
        ErrorStr.AppendLine(errorLine)
        ErrorCount += 1
        AdditionalHeight += 8 * ErrorCount 'eg. 8px * 3
        LineCount += 1
    End Sub

    Sub New()
        Me.AdditionalHeight = 0
        Me.ErrorCount = 0
        Me.LineCount = 0
    End Sub

    Sub New(errorTitle As String)
        Me.ErrorTitle = errorTitle

        Me.AdditionalHeight = 0
        Me.ErrorCount = 0
        Me.LineCount = 0
    End Sub

    'Returns true if got error
    Public Function ShowIfError() As Boolean
        If ErrorStr.ToString.Trim.Length > 0 Then

            If Not AdditionalHeight = 0 Then
                Dim errorDialog As New ErrorDialog(ErrorStr.ToString.Trim, AdditionalHeight, LineCount)
                errorDialog.ErrorTitle = ErrorTitle
                errorDialog.ShowDialog()
            Else
                Dim errorDialog As New ErrorDialog(ErrorStr.ToString.Trim, LineCount)
                errorDialog.ShowDialog()
                errorDialog.ErrorTitle = ErrorTitle
            End If

            Return True
        Else
            Return False
        End If
    End Function
End Class
