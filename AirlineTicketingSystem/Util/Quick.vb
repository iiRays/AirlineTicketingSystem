﻿Public Class Quick
    'This class aids in shortening code
    Public Shared Sub Print(text As String)
        Console.WriteLine(text)
    End Sub

    Public Shared Sub ShowError(title As String, message As String)
        'Code possible thanks to Dot Net Perls @ https://www.dotnetperls.com/messagebox-show-vbnet
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    End Sub

    Public Shared Sub ShowWarning(title As String, message As String)
        'Code possible thanks to Dot Net Perls @ https://www.dotnetperls.com/messagebox-show-vbnet
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
    End Sub
End Class
