Public Class Hash
    ' Code is possible thanks to Coding With Andrew @ https://www.youtube.com/watch?v=XkphcCDeysE

    Public hashedPassword As String
    Public salt As String

    Public Sub New(password As String)
        salt = CreateSalt()
        hashedPassword = Combine(password, salt)
    End Sub

    Public Sub New(password As String, salt As String)
        Me.salt = salt
        hashedPassword = Combine(password, salt)
    End Sub

    'Combines password + salt to create a unique hashed password
    Private Shared Function Combine(password As String, salt As String) As String
        Return salt + Hash(password)
    End Function

    Public Shared Function Hash([string] As String) As String
        Dim bytes As Byte() = Text.Encoding.ASCII.GetBytes([string])
        Return Convert.ToBase64String(Security.Cryptography.SHA256.Create().ComputeHash(bytes))
    End Function

    Public Function CreateSalt() As String
        Using crypto As New Security.Cryptography.RNGCryptoServiceProvider
            Dim str As New Text.StringBuilder
            Dim data As Byte() = New Byte(4) {}
            For i = 0 To 10
                crypto.GetBytes(data)
                Dim value As String = BitConverter.ToString(data, 0)
                str.Append(value)
            Next
            Return Hash(str.ToString())
        End Using
    End Function

    Public Shared Function Compare(enteredPassword As String, storedHashedPassword As String, storedSalt As String) As Boolean

        If (New Hash(enteredPassword, storedSalt)).Equals(storedHashedPassword) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
