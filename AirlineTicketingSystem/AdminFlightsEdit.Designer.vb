<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminFlightsEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlGender = New System.Windows.Forms.Panel()
        Me.rbDailyYes = New System.Windows.Forms.RadioButton()
        Me.rbDailyNo = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dtpDeparture = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFlightNo = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPlaneId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRouteId = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnEditRoute = New System.Windows.Forms.Button()
        Me.btnEditPlane = New System.Windows.Forms.Button()
        Me.pnlGender.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGender
        '
        Me.pnlGender.BackColor = System.Drawing.Color.White
        Me.pnlGender.Controls.Add(Me.rbDailyYes)
        Me.pnlGender.Controls.Add(Me.rbDailyNo)
        Me.pnlGender.Location = New System.Drawing.Point(715, 449)
        Me.pnlGender.Name = "pnlGender"
        Me.pnlGender.Size = New System.Drawing.Size(217, 65)
        Me.pnlGender.TabIndex = 113
        '
        'rbDailyYes
        '
        Me.rbDailyYes.AutoSize = True
        Me.rbDailyYes.BackColor = System.Drawing.Color.White
        Me.rbDailyYes.Enabled = False
        Me.rbDailyYes.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDailyYes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.rbDailyYes.Location = New System.Drawing.Point(23, 11)
        Me.rbDailyYes.Name = "rbDailyYes"
        Me.rbDailyYes.Size = New System.Drawing.Size(70, 40)
        Me.rbDailyYes.TabIndex = 41
        Me.rbDailyYes.TabStop = True
        Me.rbDailyYes.Text = "Yes"
        Me.rbDailyYes.UseVisualStyleBackColor = False
        '
        'rbDailyNo
        '
        Me.rbDailyNo.AutoSize = True
        Me.rbDailyNo.BackColor = System.Drawing.Color.White
        Me.rbDailyNo.Enabled = False
        Me.rbDailyNo.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDailyNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.rbDailyNo.Location = New System.Drawing.Point(117, 11)
        Me.rbDailyNo.Name = "rbDailyNo"
        Me.rbDailyNo.Size = New System.Drawing.Size(61, 40)
        Me.rbDailyNo.TabIndex = 42
        Me.rbDailyNo.TabStop = True
        Me.rbDailyNo.Text = "No"
        Me.rbDailyNo.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(606, 449)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Label9.Size = New System.Drawing.Size(130, 65)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "is daily?"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(732, 449)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 65)
        Me.TextBox1.TabIndex = 111
        Me.TextBox1.Tag = ""
        '
        'dtpDeparture
        '
        Me.dtpDeparture.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.dtpDeparture.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dtpDeparture.Enabled = False
        Me.dtpDeparture.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDeparture.Location = New System.Drawing.Point(491, 384)
        Me.dtpDeparture.Name = "dtpDeparture"
        Me.dtpDeparture.Size = New System.Drawing.Size(317, 37)
        Me.dtpDeparture.TabIndex = 105
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(479, 373)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label8.Size = New System.Drawing.Size(453, 60)
        Me.Label8.TabIndex = 110
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(257, 373)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(228, 60)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "departure time"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(257, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(200, 60)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "flight no."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFlightNo
        '
        Me.txtFlightNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFlightNo.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlightNo.Location = New System.Drawing.Point(453, 298)
        Me.txtFlightNo.Multiline = True
        Me.txtFlightNo.Name = "txtFlightNo"
        Me.txtFlightNo.Size = New System.Drawing.Size(479, 60)
        Me.txtFlightNo.TabIndex = 103
        Me.txtFlightNo.Tag = ""
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(767, 530)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(165, 75)
        Me.btnSave.TabIndex = 102
        Me.btnSave.Text = "save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(258, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(130, 65)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "price"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrice.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(384, 449)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(200, 65)
        Me.txtPrice.TabIndex = 100
        Me.txtPrice.Tag = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(257, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(200, 60)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "plane ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPlaneId
        '
        Me.txtPlaneId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPlaneId.Enabled = False
        Me.txtPlaneId.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaneId.Location = New System.Drawing.Point(453, 225)
        Me.txtPlaneId.Multiline = True
        Me.txtPlaneId.Name = "txtPlaneId"
        Me.txtPlaneId.Size = New System.Drawing.Size(479, 60)
        Me.txtPlaneId.TabIndex = 98
        Me.txtPlaneId.Tag = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(257, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(200, 60)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "route ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRouteId
        '
        Me.txtRouteId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRouteId.Enabled = False
        Me.txtRouteId.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRouteId.Location = New System.Drawing.Point(453, 148)
        Me.txtRouteId.Multiline = True
        Me.txtRouteId.Name = "txtRouteId"
        Me.txtRouteId.Size = New System.Drawing.Size(479, 60)
        Me.txtRouteId.TabIndex = 96
        Me.txtRouteId.Tag = ""
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(26, 22)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 75)
        Me.btnCancel.TabIndex = 95
        Me.btnCancel.Text = "cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(491, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(261, 70)
        Me.lblTitle.TabIndex = 94
        Me.lblTitle.Text = "edit a flight"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEditRoute
        '
        Me.btnEditRoute.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnEditRoute.Enabled = False
        Me.btnEditRoute.FlatAppearance.BorderSize = 0
        Me.btnEditRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditRoute.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnEditRoute.ForeColor = System.Drawing.Color.White
        Me.btnEditRoute.Location = New System.Drawing.Point(949, 148)
        Me.btnEditRoute.Name = "btnEditRoute"
        Me.btnEditRoute.Size = New System.Drawing.Size(165, 60)
        Me.btnEditRoute.TabIndex = 114
        Me.btnEditRoute.Text = "edit"
        Me.btnEditRoute.UseVisualStyleBackColor = False
        '
        'btnEditPlane
        '
        Me.btnEditPlane.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnEditPlane.Enabled = False
        Me.btnEditPlane.FlatAppearance.BorderSize = 0
        Me.btnEditPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditPlane.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnEditPlane.ForeColor = System.Drawing.Color.White
        Me.btnEditPlane.Location = New System.Drawing.Point(949, 225)
        Me.btnEditPlane.Name = "btnEditPlane"
        Me.btnEditPlane.Size = New System.Drawing.Size(165, 60)
        Me.btnEditPlane.TabIndex = 115
        Me.btnEditPlane.Text = "edit"
        Me.btnEditPlane.UseVisualStyleBackColor = False
        '
        'AdminFlightsEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btnEditPlane)
        Me.Controls.Add(Me.btnEditRoute)
        Me.Controls.Add(Me.pnlGender)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dtpDeparture)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFlightNo)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPlaneId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRouteId)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "AdminFlightsEdit"
        Me.Text = "AdminFlightsEdit"
        Me.pnlGender.ResumeLayout(False)
        Me.pnlGender.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlGender As Panel
    Friend WithEvents rbDailyYes As RadioButton
    Friend WithEvents rbDailyNo As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dtpDeparture As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFlightNo As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPlaneId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRouteId As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnEditRoute As Button
    Friend WithEvents btnEditPlane As Button
End Class
