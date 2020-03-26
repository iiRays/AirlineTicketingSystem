Public Class Quick
    'This class aids in shortening code

    Public Shared Function GetRandomString(size As Integer) As String
        Dim randomNo As New Random()
        Dim stringPool = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim generatedString = ""

        For counter As Integer = 0 To size - 1 Step 1
            generatedString &= stringPool(randomNo.Next(1, stringPool.Length))
        Next

        Return generatedString
    End Function

    Public Shared Sub Navigate([from] As Form, [to] As Form)
        [to].Show()
        from.Close()
    End Sub
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

    Public Shared Function GenerateId(Of T)() As String
        Dim total = DB.GetCount(Of T)()
        Dim id As String = ""

        If GetType(T) = GetType(Customer) Then
            id += "C"
        ElseIf GetType(T) = GetType(Booking) Then
            id += "B"
        ElseIf GetType(T) = GetType(City) Then
            id += "S" 'Customer already uses C
        ElseIf GetType(T) = GetType(Flight) Then
            id += "F"
        ElseIf GetType(T) = GetType(Route) Then
            id += "R"
        ElseIf GetType(T) = GetType(Plane) Then
            id += "P"
        ElseIf GetType(T) = GetType(Ticket) Then
            id += "T"
        Else
            Throw New Exception("Object's type is not present in Airline Database.")
        End If

        For i As Integer = 0 To 8 - total.ToString.Length
            id += "0"
        Next
        id += (total + 1).ToString

        Return id
    End Function
End Class
