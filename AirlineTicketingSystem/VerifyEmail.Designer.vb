﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerifyEmail
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
		Me.btnVerify = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtCode = New System.Windows.Forms.TextBox()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.lblEmail = New System.Windows.Forms.Label()
		Me.lblDesc = New System.Windows.Forms.Label()
		Me.btnReset = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'btnVerify
		'
		Me.btnVerify.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.btnVerify.FlatAppearance.BorderSize = 0
		Me.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnVerify.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnVerify.ForeColor = System.Drawing.Color.White
		Me.btnVerify.Location = New System.Drawing.Point(679, 476)
		Me.btnVerify.Name = "btnVerify"
		Me.btnVerify.Size = New System.Drawing.Size(150, 75)
		Me.btnVerify.TabIndex = 54
		Me.btnVerify.Text = "verify"
		Me.btnVerify.UseVisualStyleBackColor = False
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.White
		Me.Label3.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
		Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(386, 372)
		Me.Label3.Name = "Label3"
		Me.Label3.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label3.Size = New System.Drawing.Size(175, 75)
		Me.Label3.TabIndex = 53
		Me.Label3.Text = "Email Code"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtCode
		'
		Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtCode.Font = New System.Drawing.Font("Poppins", 37.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCode.Location = New System.Drawing.Point(561, 372)
		Me.txtCode.Name = "txtCode"
		Me.txtCode.Size = New System.Drawing.Size(302, 75)
		Me.txtCode.TabIndex = 52
		Me.txtCode.Tag = ""
		'
		'btnCancel
		'
		Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.btnCancel.FlatAppearance.BorderSize = 0
		Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCancel.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnCancel.ForeColor = System.Drawing.Color.White
		Me.btnCancel.Location = New System.Drawing.Point(36, 33)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(150, 75)
		Me.btnCancel.TabIndex = 51
		Me.btnCancel.Text = "cancel"
		Me.btnCancel.UseVisualStyleBackColor = False
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.BackColor = System.Drawing.Color.Transparent
		Me.lblTitle.Font = New System.Drawing.Font("Poppins", 25.0!, System.Drawing.FontStyle.Bold)
		Me.lblTitle.ForeColor = System.Drawing.Color.White
		Me.lblTitle.Location = New System.Drawing.Point(459, 129)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.lblTitle.Size = New System.Drawing.Size(347, 60)
		Me.lblTitle.TabIndex = 55
		Me.lblTitle.Text = "Verify your email"
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblEmail
		'
		Me.lblEmail.BackColor = System.Drawing.Color.Transparent
		Me.lblEmail.Font = New System.Drawing.Font("Poppins", 18.0!)
		Me.lblEmail.ForeColor = System.Drawing.Color.White
		Me.lblEmail.Location = New System.Drawing.Point(9, 189)
		Me.lblEmail.Name = "lblEmail"
		Me.lblEmail.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.lblEmail.Size = New System.Drawing.Size(1247, 42)
		Me.lblEmail.TabIndex = 56
		Me.lblEmail.Text = "Email: "
		Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblDesc
		'
		Me.lblDesc.BackColor = System.Drawing.Color.Transparent
		Me.lblDesc.Font = New System.Drawing.Font("Poppins", 18.0!)
		Me.lblDesc.ForeColor = System.Drawing.Color.White
		Me.lblDesc.Location = New System.Drawing.Point(258, 222)
		Me.lblDesc.Name = "lblDesc"
		Me.lblDesc.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.lblDesc.Size = New System.Drawing.Size(748, 147)
		Me.lblDesc.TabIndex = 57
		Me.lblDesc.Text = "Key in the code we've sent to your email here to verify your email and officially" &
	" create your account"
		Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnReset
		'
		Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.btnReset.FlatAppearance.BorderSize = 0
		Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnReset.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnReset.ForeColor = System.Drawing.Color.White
		Me.btnReset.Location = New System.Drawing.Point(436, 476)
		Me.btnReset.Name = "btnReset"
		Me.btnReset.Size = New System.Drawing.Size(223, 75)
		Me.btnReset.TabIndex = 58
		Me.btnReset.Text = "resend"
		Me.btnReset.UseVisualStyleBackColor = False
		'
		'VerifyEmail
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(1264, 681)
		Me.Controls.Add(Me.btnReset)
		Me.Controls.Add(Me.lblDesc)
		Me.Controls.Add(Me.lblEmail)
		Me.Controls.Add(Me.lblTitle)
		Me.Controls.Add(Me.btnVerify)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtCode)
		Me.Controls.Add(Me.btnCancel)
		Me.Name = "VerifyEmail"
		Me.Text = "VerifyEmail"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnVerify As Button
	Friend WithEvents Label3 As Label
	Friend WithEvents txtCode As TextBox
	Friend WithEvents btnCancel As Button
	Friend WithEvents lblTitle As Label
	Friend WithEvents lblEmail As Label
	Friend WithEvents lblDesc As Label
	Friend WithEvents btnReset As Button
End Class