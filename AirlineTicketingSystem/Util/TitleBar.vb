Public Class TitleBar
    Private Form As Form
    Private IsFormDraggable As Boolean
    Private IsMouseDown = False
    Private RemoveBorder As Boolean
    Private X As Integer
    Private Y As Integer

    'Constructors
    Public Sub New(Form As Form, IsFormDraggable As Boolean)
        Me.Form = Form
        Me.IsFormDraggable = IsFormDraggable
        Me.RemoveBorder = True

        Me.Form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Form.WindowState = FormWindowState.Normal
        Me.Form.MinimizeBox = False
        Me.Form.MinimumSize = New Size(1280, 720)
        Me.Form.MaximizeBox = False
        Me.Form.MaximumSize = New Size(1280, 720)

        LoadTitleBar()
    End Sub

    Public Sub New(Form As Form, IsFormDraggable As Boolean, RemoveBorder As Boolean)
        Me.Form = Form
        Me.IsFormDraggable = IsFormDraggable
        Me.RemoveBorder = RemoveBorder

        Me.Form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Form.WindowState = FormWindowState.Normal
        Me.Form.MinimizeBox = False
        Me.Form.MinimumSize = New Size(1280, 720)
        Me.Form.MaximizeBox = False
        Me.Form.MaximumSize = New Size(1280, 720)

        LoadTitleBar()
    End Sub

    'Static load methods
    Public Shared Sub Load(Form As Form)
        Dim CustomBar = New TitleBar(Form, True)
    End Sub

    Public Shared Sub Load(Form As Form, IsFormDraggable As Boolean)
        Dim CustomBar = New TitleBar(Form, IsFormDraggable)
    End Sub

    Public Shared Sub Load(Form As Form, IsFormDraggable As Boolean, RemoveBorder As Boolean)
        Dim CustomBar = New TitleBar(Form, IsFormDraggable, RemoveBorder)
    End Sub

    'Private nonstatic methods
    Private Sub LoadTitleBar()
        Dim btColor = Color.White

        If RemoveBorder Then
            Form.FormBorderStyle = FormBorderStyle.None
        End If

        'Check if the background is light (RGB is > 200)
        If CType(Form.BackColor.R, Integer) > 200 Or CType(Form.BackColor.G, Integer) > 200 Or CType(Form.BackColor.B, Integer) > 200 Then
            btColor = Color.Black
        End If

        Dim closeButton As New Label()
        closeButton.Anchor = AnchorStyles.Top
        closeButton.Anchor = AnchorStyles.Right
        closeButton.AutoSize = True
        closeButton.Font = New Font("Poppins", 14, FontStyle.Regular)
        closeButton.ForeColor = btColor
        closeButton.Text = "x"
        AddHandler closeButton.Click, AddressOf Quick.CloseForm

        Dim minimizeButton As New Label()
        minimizeButton.Anchor = AnchorStyles.Top
        minimizeButton.Anchor = AnchorStyles.Right
        minimizeButton.AutoSize = True
        minimizeButton.Font = New Font("Poppins", 14, FontStyle.Regular)
        minimizeButton.ForeColor = btColor
        minimizeButton.Text = "-"
        AddHandler minimizeButton.Click, AddressOf Quick.MinimizeForm

        Dim panel As New FlowLayoutPanel()
        panel.Dock = DockStyle.Top
        panel.FlowDirection = FlowDirection.RightToLeft
        panel.Controls.Add(closeButton)
        panel.Controls.Add(minimizeButton)
        panel.BackColor = Color.Transparent
        panel.AutoSize = True

        'Make the panel itself draggable
        AddHandler panel.MouseDown, AddressOf DragMouseDown
        AddHandler panel.MouseUp, AddressOf DragMouseUp
        AddHandler panel.MouseMove, AddressOf Drag

        If IsFormDraggable Then
            'Make the form itself draggable
            AddHandler Form.MouseDown, AddressOf DragMouseDown
            AddHandler Form.MouseUp, AddressOf DragMouseUp
            AddHandler Form.MouseMove, AddressOf Drag
        End If

        Form.Controls.Add(panel)

    End Sub

    'Draggable title bar code below is possible thanks to user2536474 @ https://stackoverflow.com/questions/17392088/allow-a-user-to-move-a-borderless-window

    Private Sub DragMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            IsMouseDown = True
            X = e.X
            Y = e.Y
        End If
    End Sub

    Private Sub DragMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            IsMouseDown = False
        End If
    End Sub

    Private Sub Drag(ByVal sender As Object, ByVal e As MouseEventArgs)
        If IsMouseDown Then
            Form.Location = New Point(Form.Location.X + (e.X - X), Form.Location.Y + (e.Y - Y))
        End If
    End Sub
End Class
