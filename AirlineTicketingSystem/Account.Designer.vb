<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account
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
		Me.rbMale = New System.Windows.Forms.RadioButton()
		Me.rbNonBinary = New System.Windows.Forms.RadioButton()
		Me.rbFemale = New System.Windows.Forms.RadioButton()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.btnBack = New System.Windows.Forms.Button()
		Me.btnUpdate = New System.Windows.Forms.Button()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.dtpDate = New System.Windows.Forms.DateTimePicker()
		Me.txtDate = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtCreditCardNo = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtCountry = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.txtCity = New System.Windows.Forms.TextBox()
		Me.pnlGender.SuspendLayout()
		Me.SuspendLayout()
		'
		'pnlGender
		'
		Me.pnlGender.BackColor = System.Drawing.Color.White
		Me.pnlGender.Controls.Add(Me.rbMale)
		Me.pnlGender.Controls.Add(Me.rbNonBinary)
		Me.pnlGender.Controls.Add(Me.rbFemale)
		Me.pnlGender.Location = New System.Drawing.Point(247, 418)
		Me.pnlGender.Name = "pnlGender"
		Me.pnlGender.Size = New System.Drawing.Size(375, 50)
		Me.pnlGender.TabIndex = 58
		'
		'rbMale
		'
		Me.rbMale.AutoSize = True
		Me.rbMale.BackColor = System.Drawing.Color.White
		Me.rbMale.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbMale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.rbMale.Location = New System.Drawing.Point(10, 5)
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
		Me.rbNonBinary.Location = New System.Drawing.Point(214, 5)
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
		Me.rbFemale.Location = New System.Drawing.Point(99, 4)
		Me.rbFemale.Name = "rbFemale"
		Me.rbFemale.Size = New System.Drawing.Size(109, 40)
		Me.rbFemale.TabIndex = 42
		Me.rbFemale.TabStop = True
		Me.rbFemale.Text = "Female"
		Me.rbFemale.UseVisualStyleBackColor = False
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.White
		Me.Label4.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold)
		Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label4.Location = New System.Drawing.Point(76, 418)
		Me.Label4.Name = "Label4"
		Me.Label4.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label4.Size = New System.Drawing.Size(175, 50)
		Me.Label4.TabIndex = 57
		Me.Label4.Text = "gender"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.White
		Me.Label3.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold)
		Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(76, 203)
		Me.Label3.Name = "Label3"
		Me.Label3.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label3.Size = New System.Drawing.Size(175, 50)
		Me.Label3.TabIndex = 56
		Me.Label3.Text = "name"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtName
		'
		Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtName.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtName.Location = New System.Drawing.Point(247, 203)
		Me.txtName.Multiline = True
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(375, 50)
		Me.txtName.TabIndex = 55
		Me.txtName.Tag = ""
		'
		'btnBack
		'
		Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.btnBack.FlatAppearance.BorderSize = 0
		Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBack.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnBack.ForeColor = System.Drawing.Color.White
		Me.btnBack.Location = New System.Drawing.Point(34, 30)
		Me.btnBack.Name = "btnBack"
		Me.btnBack.Size = New System.Drawing.Size(150, 75)
		Me.btnBack.TabIndex = 53
		Me.btnBack.Text = "back"
		Me.btnBack.UseVisualStyleBackColor = False
		'
		'btnUpdate
		'
		Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.btnUpdate.FlatAppearance.BorderSize = 0
		Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnUpdate.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnUpdate.ForeColor = System.Drawing.Color.White
		Me.btnUpdate.Location = New System.Drawing.Point(551, 547)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(165, 75)
		Me.btnUpdate.TabIndex = 52
		Me.btnUpdate.Text = "update"
		Me.btnUpdate.UseVisualStyleBackColor = False
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.lblTitle.Location = New System.Drawing.Point(539, 35)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(203, 70)
		Me.lblTitle.TabIndex = 45
		Me.lblTitle.Text = "account"
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.White
		Me.Label1.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold)
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(76, 274)
		Me.Label1.Name = "Label1"
		Me.Label1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label1.Size = New System.Drawing.Size(175, 50)
		Me.Label1.TabIndex = 60
		Me.Label1.Text = "email"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtEmail
		'
		Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtEmail.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtEmail.Location = New System.Drawing.Point(247, 274)
		Me.txtEmail.Multiline = True
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(375, 50)
		Me.txtEmail.TabIndex = 59
		Me.txtEmail.Tag = ""
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.White
		Me.Label2.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold)
		Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(76, 347)
		Me.Label2.Name = "Label2"
		Me.Label2.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label2.Size = New System.Drawing.Size(175, 50)
		Me.Label2.TabIndex = 62
		Me.Label2.Text = "password"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtPassword
		'
		Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtPassword.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPassword.Location = New System.Drawing.Point(247, 347)
		Me.txtPassword.Multiline = True
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(375, 50)
		Me.txtPassword.TabIndex = 61
		Me.txtPassword.Tag = ""
		'
		'dtpDate
		'
		Me.dtpDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
		Me.dtpDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.dtpDate.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpDate.Location = New System.Drawing.Point(862, 206)
		Me.dtpDate.Name = "dtpDate"
		Me.dtpDate.Size = New System.Drawing.Size(274, 37)
		Me.dtpDate.TabIndex = 65
		'
		'txtDate
		'
		Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtDate.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDate.Location = New System.Drawing.Point(831, 201)
		Me.txtDate.Multiline = True
		Me.txtDate.Name = "txtDate"
		Me.txtDate.Size = New System.Drawing.Size(375, 50)
		Me.txtDate.TabIndex = 64
		Me.txtDate.Tag = ""
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.Color.White
		Me.Label5.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold)
		Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label5.Location = New System.Drawing.Point(656, 201)
		Me.Label5.Name = "Label5"
		Me.Label5.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label5.Size = New System.Drawing.Size(175, 50)
		Me.Label5.TabIndex = 63
		Me.Label5.Text = "date of birth"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.White
		Me.Label6.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold)
		Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label6.Location = New System.Drawing.Point(657, 275)
		Me.Label6.Name = "Label6"
		Me.Label6.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label6.Size = New System.Drawing.Size(185, 50)
		Me.Label6.TabIndex = 67
		Me.Label6.Text = "credit card no."
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtCreditCardNo
		'
		Me.txtCreditCardNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtCreditCardNo.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCreditCardNo.Location = New System.Drawing.Point(841, 275)
		Me.txtCreditCardNo.Multiline = True
		Me.txtCreditCardNo.Name = "txtCreditCardNo"
		Me.txtCreditCardNo.Size = New System.Drawing.Size(365, 50)
		Me.txtCreditCardNo.TabIndex = 66
		Me.txtCreditCardNo.Tag = ""
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.Color.White
		Me.Label7.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold)
		Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label7.Location = New System.Drawing.Point(657, 348)
		Me.Label7.Name = "Label7"
		Me.Label7.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label7.Size = New System.Drawing.Size(175, 50)
		Me.Label7.TabIndex = 69
		Me.Label7.Text = "country"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtCountry
		'
		Me.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtCountry.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCountry.Location = New System.Drawing.Point(828, 348)
		Me.txtCountry.Multiline = True
		Me.txtCountry.Name = "txtCountry"
		Me.txtCountry.Size = New System.Drawing.Size(375, 50)
		Me.txtCountry.TabIndex = 68
		Me.txtCountry.Tag = ""
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.Color.White
		Me.Label8.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold)
		Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label8.Location = New System.Drawing.Point(657, 418)
		Me.Label8.Name = "Label8"
		Me.Label8.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label8.Size = New System.Drawing.Size(175, 50)
		Me.Label8.TabIndex = 71
		Me.Label8.Text = "city"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtCity
		'
		Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtCity.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCity.Location = New System.Drawing.Point(828, 418)
		Me.txtCity.Multiline = True
		Me.txtCity.Name = "txtCity"
		Me.txtCity.Size = New System.Drawing.Size(375, 50)
		Me.txtCity.TabIndex = 70
		Me.txtCity.Tag = ""
		'
		'Account
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(1264, 681)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.txtCity)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.txtCountry)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.txtCreditCardNo)
		Me.Controls.Add(Me.dtpDate)
		Me.Controls.Add(Me.txtDate)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtPassword)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtEmail)
		Me.Controls.Add(Me.pnlGender)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.btnBack)
		Me.Controls.Add(Me.btnUpdate)
		Me.Controls.Add(Me.lblTitle)
		Me.Name = "Account"
		Me.Text = "Account"
		Me.pnlGender.ResumeLayout(False)
		Me.pnlGender.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents pnlGender As Panel
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbNonBinary As RadioButton
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCreditCardNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCity As TextBox
End Class
