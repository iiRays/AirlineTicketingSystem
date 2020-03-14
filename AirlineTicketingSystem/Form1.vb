
Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PlaneID_Click(sender As Object, e As EventArgs) Handles PlaneID.Click

    End Sub



    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim plane As New Plane
        plane.PlaneID = TextBox1.Text
        plane.Model = TextBox2.Text
        plane.Manufacturer = TextBox3.Text
        plane.Capacity = TextBox4.Text

        DB.Update(plane, TextBox5.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim plane As Plane = DB.Get(Of Plane)(TextBox5.Text)
        TextBox1.Text = plane.PlaneID
        TextBox2.Text = plane.Model
        TextBox3.Text = plane.Manufacturer
        TextBox4.Text = plane.Capacity
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Quick.Print("test")

    End Sub
End Class
