Public Class AdminUsersViewResults
    Private Sub AdminUsersViewResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quick.SetFormFont("Poppins", Me)
        TitleBar.Load(Me, True)

        Dim users As List(Of User) = New List(Of User)
        Dim loopCount As Integer = 0

        Dim viewAll As Boolean = App.Session.Get("viewAll")

        If viewAll Then
            users = DB.GetAll(Of User)
        Else
            Dim searchBy As String = App.Session.Get("searchBy")
            Dim searchFor As String = App.Session.Get("searchFor")

            users = DB.GetList(Of User)(searchBy, searchFor)
        End If

        For Each user In users
            Dim userItem As New UserItem()
            userItem.Location = New Point(130, 120 + (loopCount * 100))
            userItem.User = user
            userItem.AdminUsersViewResults = Me
            Me.Controls.Add(userItem)
            loopCount += 1
        Next
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        App.Session.Delete("viewAll")
        App.Session.Delete("searchBy")
        App.Session.Delete("searchFor")
        Quick.Navigate(Me, New AdminUsersView)
    End Sub
End Class