Public Class App
    'To handle app-wide data

    Public Shared Session As LinkedList(Of Object)

    'Logs the user in
    Public Shared Sub LoginUser(Of T)(user As T)
        If GetType(T) = GetType(User) Then
            Session.Add("user", user)
            ' To add staff login later
        End If
    End Sub

    'Unneeded methods but may prove useful
    Public Shared Sub SaveState(form As Form)
        App.Session.Add(form.Name, form)
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
