Imports System.Text

Public Class ErrorMsg
    Private ErrorStr As New StringBuilder()
    Private AdditionalHeight As Integer = 0
    Private ErrorCount As Integer = 0
    Private ErrorTitle As String

    Sub New()
        ErrorTitle = ""
    End Sub

    Sub New(errorTitle As String)
        Me.ErrorTitle = errorTitle
    End Sub

    Public Sub Add(errorLine As String)
        ErrorStr.AppendLine(errorLine)
        ErrorCount += 1
        AdditionalHeight += 8 * ErrorCount 'eg. 8px * 3
    End Sub

    'Returns true if got error
    Public Function ShowIfError() As Boolean
        If ErrorStr.ToString.Trim.Length > 0 Then

            If Not AdditionalHeight = 0 Then
                Dim errorDialog As New ErrorDialog(ErrorStr.ToString.Trim, AdditionalHeight, ErrorTitle)
                errorDialog.ShowDialog()
            Else
                Dim errorDialog As New ErrorDialog(ErrorStr.ToString.Trim, ErrorTitle)
                errorDialog.ShowDialog()
            End If

            Return True
        Else
            Return False
        End If
    End Function
End Class
