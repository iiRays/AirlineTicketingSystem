Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PlaneID_Click(sender As Object, e As EventArgs) Handles PlaneID.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Create plane object
        Dim plane As New Plane()
        plane.PlaneID = TextBox1.Text
        plane.Model = TextBox2.Text
        plane.Manufacturer = TextBox3.Text
        plane.Capacity = TextBox4.Text

        'Insert into DB
        DBUtil.Insert(plane)

    End Sub
End Class
