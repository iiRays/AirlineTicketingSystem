Public Class ErrorDialog
    Private ErrorMsg As String

    Sub New(errorMsg As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ErrorMsg = errorMsg
    End Sub


    Private Sub ErrorWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleBar.LoadResizable(Me)
        lblError.Text = ErrorMsg
        Me.MaximumSize = New Size(1270, 720)
        Me.AutoScrollPosition = New Point(0, 0)
        Quick.CenterForm(Me)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub
End Class