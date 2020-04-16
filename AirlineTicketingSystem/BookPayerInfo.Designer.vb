<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookPayerInfo
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtCountry = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtCity = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.pnlGender = New System.Windows.Forms.Panel()
		Me.rbMale = New System.Windows.Forms.RadioButton()
		Me.rbNonBinary = New System.Windows.Forms.RadioButton()
		Me.rbFemale = New System.Windows.Forms.RadioButton()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.btnOK = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.dtpDate = New System.Windows.Forms.DateTimePicker()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.txtCard = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.pnlGender.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Poppins", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(463, 20)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(239, 70)
		Me.Label1.TabIndex = 62
		Me.Label1.Text = "payer info"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.White
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
		Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(23, 176)
		Me.Label3.Name = "Label3"
		Me.Label3.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label3.Size = New System.Drawing.Size(113, 57)
		Me.Label3.TabIndex = 63
		Me.Label3.Text = "name"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtName
		'
		Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 37.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtName.Location = New System.Drawing.Point(132, 176)
		Me.txtName.MaxLength = 19
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(432, 57)
		Me.txtName.TabIndex = 64
		Me.txtName.Tag = ""
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.White
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
		Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(643, 179)
		Me.Label2.Name = "Label2"
		Me.Label2.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label2.Size = New System.Drawing.Size(124, 57)
		Me.Label2.TabIndex = 65
		Me.Label2.Text = "country"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtCountry
		'
		Me.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 37.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCountry.Location = New System.Drawing.Point(763, 179)
		Me.txtCountry.MaxLength = 19
		Me.txtCountry.Name = "txtCountry"
		Me.txtCountry.Size = New System.Drawing.Size(232, 57)
		Me.txtCountry.TabIndex = 66
		Me.txtCountry.Tag = ""
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.White
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
		Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label4.Location = New System.Drawing.Point(643, 260)
		Me.Label4.Name = "Label4"
		Me.Label4.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label4.Size = New System.Drawing.Size(124, 57)
		Me.Label4.TabIndex = 67
		Me.Label4.Text = "city"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtCity
		'
		Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 37.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCity.Location = New System.Drawing.Point(763, 260)
		Me.txtCity.MaxLength = 19
		Me.txtCity.Name = "txtCity"
		Me.txtCity.Size = New System.Drawing.Size(232, 57)
		Me.txtCity.TabIndex = 68
		Me.txtCity.Tag = ""
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Poppins", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.White
		Me.Label5.Location = New System.Drawing.Point(640, 128)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(133, 48)
		Me.Label5.TabIndex = 69
		Me.Label5.Text = "address"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Poppins", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.White
		Me.Label6.Location = New System.Drawing.Point(23, 128)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(148, 48)
		Me.Label6.TabIndex = 70
		Me.Label6.Text = "personal "
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.Color.White
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
		Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label7.Location = New System.Drawing.Point(23, 254)
		Me.Label7.Name = "Label7"
		Me.Label7.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label7.Size = New System.Drawing.Size(113, 57)
		Me.Label7.TabIndex = 71
		Me.Label7.Text = "email"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtEmail
		'
		Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 37.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtEmail.Location = New System.Drawing.Point(132, 254)
		Me.txtEmail.MaxLength = 50
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(432, 57)
		Me.txtEmail.TabIndex = 72
		Me.txtEmail.Tag = ""
		'
		'pnlGender
		'
		Me.pnlGender.BackColor = System.Drawing.Color.White
		Me.pnlGender.Controls.Add(Me.rbMale)
		Me.pnlGender.Controls.Add(Me.rbNonBinary)
		Me.pnlGender.Controls.Add(Me.rbFemale)
		Me.pnlGender.Location = New System.Drawing.Point(189, 330)
		Me.pnlGender.Name = "pnlGender"
		Me.pnlGender.Size = New System.Drawing.Size(375, 57)
		Me.pnlGender.TabIndex = 74
		'
		'rbMale
		'
		Me.rbMale.AutoSize = True
		Me.rbMale.BackColor = System.Drawing.Color.White
		Me.rbMale.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbMale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.rbMale.Location = New System.Drawing.Point(7, 8)
		Me.rbMale.Name = "rbMale"
		Me.rbMale.Size = New System.Drawing.Size(83, 40)
		Me.rbMale.TabIndex = 41
		Me.rbMale.TabStop = True
		Me.rbMale.Text = "Male"
		Me.rbMale.UseVisualStyleBackColor = False
		'
		'rbNonBinary
		'
		Me.rbNonBinary.AutoSize = True
		Me.rbNonBinary.BackColor = System.Drawing.Color.White
		Me.rbNonBinary.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbNonBinary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.rbNonBinary.Location = New System.Drawing.Point(211, 8)
		Me.rbNonBinary.Name = "rbNonBinary"
		Me.rbNonBinary.Size = New System.Drawing.Size(155, 40)
		Me.rbNonBinary.TabIndex = 43
		Me.rbNonBinary.TabStop = True
		Me.rbNonBinary.Text = "Non-Binary"
		Me.rbNonBinary.UseVisualStyleBackColor = False
		'
		'rbFemale
		'
		Me.rbFemale.AutoSize = True
		Me.rbFemale.BackColor = System.Drawing.Color.White
		Me.rbFemale.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbFemale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.rbFemale.Location = New System.Drawing.Point(96, 8)
		Me.rbFemale.Name = "rbFemale"
		Me.rbFemale.Size = New System.Drawing.Size(109, 40)
		Me.rbFemale.TabIndex = 42
		Me.rbFemale.TabStop = True
		Me.rbFemale.Text = "Female"
		Me.rbFemale.UseVisualStyleBackColor = False
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.Color.White
		Me.Label8.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
		Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label8.Location = New System.Drawing.Point(23, 330)
		Me.Label8.Name = "Label8"
		Me.Label8.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label8.Size = New System.Drawing.Size(167, 57)
		Me.Label8.TabIndex = 73
		Me.Label8.Text = "gender"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btnOK
		'
		Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.btnOK.FlatAppearance.BorderSize = 0
		Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnOK.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnOK.ForeColor = System.Drawing.Color.White
		Me.btnOK.Location = New System.Drawing.Point(615, 517)
		Me.btnOK.Name = "btnOK"
		Me.btnOK.Size = New System.Drawing.Size(91, 52)
		Me.btnOK.TabIndex = 75
		Me.btnOK.Text = "ok"
		Me.btnOK.UseVisualStyleBackColor = False
		'
		'btnCancel
		'
		Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.btnCancel.FlatAppearance.BorderSize = 0
		Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCancel.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnCancel.ForeColor = System.Drawing.Color.White
		Me.btnCancel.Location = New System.Drawing.Point(458, 517)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(140, 52)
		Me.btnCancel.TabIndex = 76
		Me.btnCancel.Text = "cancel"
		Me.btnCancel.UseVisualStyleBackColor = False
		'
		'Label9
		'
		Me.Label9.BackColor = System.Drawing.Color.White
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
		Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label9.Location = New System.Drawing.Point(22, 404)
		Me.Label9.Name = "Label9"
		Me.Label9.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label9.Size = New System.Drawing.Size(190, 57)
		Me.Label9.TabIndex = 77
		Me.Label9.Text = "Date of Birth"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TextBox1
		'
		Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 37.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox1.Location = New System.Drawing.Point(208, 404)
		Me.TextBox1.MaxLength = 19
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(356, 57)
		Me.TextBox1.TabIndex = 78
		Me.TextBox1.Tag = ""
		'
		'dtpDate
		'
		Me.dtpDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
		Me.dtpDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.dtpDate.CustomFormat = "d MMM yyyy"
		Me.dtpDate.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDate.Location = New System.Drawing.Point(251, 412)
		Me.dtpDate.Name = "dtpDate"
		Me.dtpDate.Size = New System.Drawing.Size(274, 43)
		Me.dtpDate.TabIndex = 79
		'
		'Label10
		'
		Me.Label10.BackColor = System.Drawing.Color.White
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
		Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label10.Location = New System.Drawing.Point(643, 398)
		Me.Label10.Name = "Label10"
		Me.Label10.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label10.Size = New System.Drawing.Size(225, 57)
		Me.Label10.TabIndex = 80
		Me.Label10.Text = "credit card no."
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtCard
		'
		Me.txtCard.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 37.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCard.Location = New System.Drawing.Point(864, 398)
		Me.txtCard.MaxLength = 19
		Me.txtCard.Name = "txtCard"
		Me.txtCard.Size = New System.Drawing.Size(278, 57)
		Me.txtCard.TabIndex = 81
		Me.txtCard.Tag = ""
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Poppins", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.ForeColor = System.Drawing.Color.White
		Me.Label11.Location = New System.Drawing.Point(640, 350)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(206, 48)
		Me.Label11.TabIndex = 82
		Me.Label11.Text = "payment info"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'BookPayerInfo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(1165, 598)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.txtCard)
		Me.Controls.Add(Me.dtpDate)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnOK)
		Me.Controls.Add(Me.pnlGender)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.txtEmail)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtCity)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtCountry)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.Label1)
		Me.Name = "BookPayerInfo"
		Me.Text = "BookPayerInfo"
		Me.pnlGender.ResumeLayout(False)
		Me.pnlGender.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents txtName As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txtCountry As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtCity As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents pnlGender As Panel
	Friend WithEvents rbMale As RadioButton
	Friend WithEvents rbNonBinary As RadioButton
	Friend WithEvents rbFemale As RadioButton
	Friend WithEvents Label8 As Label
	Friend WithEvents btnOK As Button
	Friend WithEvents btnCancel As Button
	Friend WithEvents Label9 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents dtpDate As DateTimePicker
	Friend WithEvents Label10 As Label
	Friend WithEvents txtCard As TextBox
	Friend WithEvents Label11 As Label
End Class
