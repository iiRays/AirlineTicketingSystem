Public Class ErrorDialog
    Private ErrorMsg As String
    Public ErrorTitle As String
    Private LineCount As Integer

    Sub New(errorMsg As String, LineCount As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ErrorMsg = errorMsg
        Me.LineCount = 0
        Me.ErrorTitle = ""
    End Sub

    Sub New(errorMsg As String, additionalHeight As Integer, LineCount As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ErrorMsg = errorMsg
        Me.Height += additionalHeight
        Me.LineCount = 0
        Me.ErrorTitle = ""
    End Sub


    Private Sub ErrorWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleBar.LoadResizable(Me)
        lblError.Text = ErrorMsg

        If Not ErrorTitle = "" Then
            lblTitle.Text = ErrorTitle
        End If

        Me.MaximumSize = New Size(1270, 720)
        Me.AutoScrollPosition = New Point(0, 0)
        Quick.CenterForm(Me)

    End Sub

    Private Sub ErrorWindow_Activated(sender As Object, e As EventArgs) Handles MyBase.Resize
        If LineCount = 0 Then
            'Code possible thanks to Robbins @ https://searchwindevelopment.techtarget.com/answer/How-do-you-center-controls-on-a-form-in-VBNET
            lblError.Top = (Me.ClientSize.Height / 2) - (lblError.Height / 2)
            lblError.Left = (Me.ClientSize.Width / 2) - (lblError.Width / 2)
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub
End Class