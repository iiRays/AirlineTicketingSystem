Imports System.Runtime.Serialization
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json

Public Class Quick
    'This class aids in shortening code


    Public Shared Function Clone(Of T)(source As T) As T
        Return JsonConvert.DeserializeObject(Of T)(JsonConvert.SerializeObject(source))
    End Function


    'Closes a form
    Public Shared Function CloseForm(ByVal sender As Object, ByVal e As EventArgs)
        Dim form = DirectCast(sender, Label).FindForm
        form.FormBorderStyle = FormBorderStyle.Sizable
        form.Close()
    End Function

    'Minimizes a form
    Public Shared Function MinimizeForm(ByVal sender As Object, ByVal e As EventArgs)
        Dim form = DirectCast(sender, Label).FindForm
        form.FormBorderStyle = FormBorderStyle.Sizable
        form.WindowState = FormWindowState.Minimized
        form.FormBorderStyle = FormBorderStyle.None
    End Function
    Public Shared Sub SetFormFont(FontName As String, Form As Form)
        For Each Control As Control In Form.Controls
            Control.Font = New Font(FontName, Control.Font.Size, Control.Font.Style)
            If TypeOf Control Is Panel Then
                SetFormFont(FontName, Control)
            End If
        Next
    End Sub

    Public Shared Sub SetFormFont(FontName As String, ParentControl As Control)
        For Each Control As Control In ParentControl.Controls
            Control.Font = New Font(FontName, Control.Font.Size, Control.Font.Style)
            If TypeOf Control Is Panel Then
                SetFormFont(FontName, Control)
            End If
        Next
    End Sub

    Public Shared Function CheckRegex(regex As String, str As String) As Boolean
        ' Code is possible thanks to Dot Net Perls @ https://www.dotnetperls.com/regex-vbnet

        Dim reg As Regex = New Regex(regex)

        If reg.Match(str).Success Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Shared Function GetRandomInt(from As Integer, until As Integer) As Integer
        Dim random As New Random()
        Return random.Next(from, until + 1)
    End Function

    'For seat generation
    Public Shared Function IntToChar(num As Integer) As Char
        If num = 0 OrElse num > 26 Then
            Throw New Exception("Integer out of alphabetical bounds of ASCII value")
        End If

        'Return ascii character
        Return Chr(64 + num)
    End Function


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

        If GetType(T) = GetType(User) Then
            id += "C"
        ElseIf GetType(T) = GetType(Booking) Then
            id += "B"
        ElseIf GetType(T) = GetType(City) Then
            id += "S" 'User already uses C
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

        id += (total + 1).ToString("000000000")

        Return id
    End Function

    Public Shared Function GenerateId(Of T)(count As Integer) As String
        Dim total = count
        Dim id As String = ""

        If GetType(T) = GetType(User) Then
            id += "C"
        ElseIf GetType(T) = GetType(Booking) Then
            id += "B"
        ElseIf GetType(T) = GetType(City) Then
            id += "S" 'User already uses C
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

        id += (total + 1).ToString("000000000")

        Return id
    End Function
End Class
