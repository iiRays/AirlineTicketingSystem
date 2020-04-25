Imports System.Text

Public Class ErrorMsg
    Private ErrorStr As New StringBuilder()

    Public Sub Add(errorLine As String)
        ErrorStr.AppendLine(errorLine)
    End Sub

    'Returns true if got error
    Public Function ShowIfError() As Boolean
        If ErrorStr.ToString.Trim.Length > 0 Then

            Dim errorDialog As New ErrorDialog(ErrorStr.ToString.Trim)
            errorDialog.ShowDialog()

            Return True
        Else
            Return False
        End If
    End Function
End Class
