Public Class App
    'To handle app-wide data

    Public Shared Session As LinkedList(Of Object)

    'Logs the user in
    Public Shared Sub LoginUser(Of T)(user As T)
        If GetType(T) = GetType(Customer) Then
            Session.Add("user", user)
            ' To add staff login later
        End If
    End Sub

End Class
