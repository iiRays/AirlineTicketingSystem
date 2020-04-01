Public Class Startup
    Private Sub Startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialize session
        App.Session = New LinkedList(Of Object)

        'Show first screen
        Dim form As New HomeGuest
        form.Show()
        Me.Close()
    End Sub
End Class