<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeGuest
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.btnLogin = New System.Windows.Forms.Button()
		Me.btnFlights = New System.Windows.Forms.Button()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnLogin
		'
		Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.btnLogin.FlatAppearance.BorderSize = 0
		Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.btnLogin.Location = New System.Drawing.Point(639, 244)
		Me.btnLogin.Name = "btnLogin"
		Me.btnLogin.Size = New System.Drawing.Size(225, 250)
		Me.btnLogin.TabIndex = 32
		Me.btnLogin.Text = "login"
		Me.btnLogin.UseVisualStyleBackColor = False
		'
		'btnFlights
		'
		Me.btnFlights.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.btnFlights.FlatAppearance.BorderSize = 0
		Me.btnFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnFlights.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnFlights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.btnFlights.Location = New System.Drawing.Point(369, 244)
		Me.btnFlights.Name = "btnFlights"
		Me.btnFlights.Size = New System.Drawing.Size(225, 250)
		Me.btnFlights.TabIndex = 31
		Me.btnFlights.Text = "flights"
		Me.btnFlights.UseVisualStyleBackColor = False
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.lblTitle.Location = New System.Drawing.Point(523, 107)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(181, 70)
		Me.lblTitle.TabIndex = 30
		Me.lblTitle.Text = "ao zora"
		'
		'HomeGuest
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(1264, 681)
		Me.Controls.Add(Me.btnLogin)
		Me.Controls.Add(Me.btnFlights)
		Me.Controls.Add(Me.lblTitle)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "HomeGuest"
		Me.Text = "Home"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnLogin As Button
	Friend WithEvents btnFlights As Button
	Friend WithEvents lblTitle As Label
End Class
