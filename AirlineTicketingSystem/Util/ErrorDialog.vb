Public Class ErrorDialog
    Private ErrorMsg As String
    Private ErrorTitle As String

    Sub New(errorMsg As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ErrorMsg = errorMsg
        Me.ErrorTitle = ""
    End Sub

    Sub New(errorMsg As String, errorTitle As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ErrorMsg = errorMsg
        Me.ErrorTitle = errorTitle
    End Sub

    Sub New(errorMsg As String, additionalHeight As Integer, errorTitle As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ErrorMsg = errorMsg
        Me.Height += additionalHeight
        Me.ErrorTitle = errorTitle
    End Sub


    Private Sub ErrorWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleBar.LoadResizable(Me)
        lblError.Text = ErrorMsg
        Me.MaximumSize = New Size(1270, 720)
        Me.AutoScrollPosition = New Point(0, 0)
        Quick.CenterForm(Me)

        If Not ErrorTitle = "" Then
            lblTitle.Text = ErrorTitle
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub
End Class