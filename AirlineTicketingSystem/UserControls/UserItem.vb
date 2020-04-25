Public Class UserItem
    Public User As User
    Public AdminUsersViewResults As AdminUsersViewResults

    Private Sub UserItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblId.Text = User.UserID
        lblName.Text = User.Name
        lblIsStaff.Text = User.IsStaff.ToString()
    End Sub
    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        App.Session.Set("user", User)
        Quick.Navigate(DirectCast(sender, Button).FindForm, New AdminUsersViewSummary)
    End Sub
End Class
