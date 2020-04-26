<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerifyEmailSuccess
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerifyEmailSuccess))
		Me.lblDesc = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnVerify = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lblDesc
		'
		Me.lblDesc.BackColor = System.Drawing.Color.Transparent
		Me.lblDesc.Font = New System.Drawing.Font("Poppins", 30.0!, System.Drawing.FontStyle.Bold)
		Me.lblDesc.ForeColor = System.Drawing.Color.White
		Me.lblDesc.Location = New System.Drawing.Point(257, 212)
		Me.lblDesc.Name = "lblDesc"
		Me.lblDesc.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.lblDesc.Size = New System.Drawing.Size(748, 147)
		Me.lblDesc.TabIndex = 58
		Me.lblDesc.Text = "Verification success!"
		Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Poppins", 18.0!)
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(257, 311)
		Me.Label1.Name = "Label1"
		Me.Label1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label1.Size = New System.Drawing.Size(748, 48)
		Me.Label1.TabIndex = 59
		Me.Label1.Text = "You can now proceed to login."
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnVerify
		'
		Me.btnVerify.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.btnVerify.FlatAppearance.BorderSize = 0
		Me.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnVerify.Font = New System.Drawing.Font("Poppins", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnVerify.ForeColor = System.Drawing.Color.White
		Me.btnVerify.Location = New System.Drawing.Point(527, 394)
		Me.btnVerify.Name = "btnVerify"
		Me.btnVerify.Size = New System.Drawing.Size(210, 75)
		Me.btnVerify.TabIndex = 60
		Me.btnVerify.Text = "proceed"
		Me.btnVerify.UseVisualStyleBackColor = False
		'
		'VerifyEmailSuccess
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(1264, 681)
		Me.Controls.Add(Me.btnVerify)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.lblDesc)
		Me.Name = "VerifyEmailSuccess"
		Me.Text = "VerifyEmailSuccess"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents lblDesc As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents btnVerify As Button
End Class
