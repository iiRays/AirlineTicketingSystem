Public Class App
    'To handle app-wide data

    Public Shared Session As LinkedList(Of Object)
    Public Shared User As User

    Public Shared Function IsLoggedIn() As Boolean
        If User Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    'Unneeded methods but may prove useful
    Public Shared Sub SaveState(form As Form)
        App.Session.Set(form.Name, form)
    End Sub

    Public Shared Function RestoreState(form As Form) As Form
        Dim restoredForm As New Form
        Try
            restoredForm = App.Session.Get(form.Name)
        Catch ex As NullReferenceException
            Return form
        End Try

        If restoredForm Is Nothing Then
            Return form
        End If

        Return restoredForm
    End Function

End Class
