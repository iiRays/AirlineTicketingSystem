<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingFinish
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
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.lblDesc = New System.Windows.Forms.Label()
		Me.btnOK = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.BackColor = System.Drawing.Color.Transparent
		Me.lblTitle.Font = New System.Drawing.Font("Poppins", 25.0!, System.Drawing.FontStyle.Bold)
		Me.lblTitle.ForeColor = System.Drawing.Color.White
		Me.lblTitle.Location = New System.Drawing.Point(455, 201)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.lblTitle.Size = New System.Drawing.Size(351, 60)
		Me.lblTitle.TabIndex = 56
		Me.lblTitle.Text = "Booking success!"
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblDesc
		'
		Me.lblDesc.BackColor = System.Drawing.Color.Transparent
		Me.lblDesc.Font = New System.Drawing.Font("Poppins", 18.0!)
		Me.lblDesc.ForeColor = System.Drawing.Color.White
		Me.lblDesc.Location = New System.Drawing.Point(256, 249)
		Me.lblDesc.Name = "lblDesc"
		Me.lblDesc.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.lblDesc.Size = New System.Drawing.Size(748, 147)
		Me.lblDesc.TabIndex = 58
		Me.lblDesc.Text = "We have emailed the booking details to you in the provided email."
		Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnOK
		'
		Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.btnOK.FlatAppearance.BorderSize = 0
		Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnOK.Font = New System.Drawing.Font("Poppins", 20.0!, System.Drawing.FontStyle.Bold)
		Me.btnOK.ForeColor = System.Drawing.Color.White
		Me.btnOK.Location = New System.Drawing.Point(561, 399)
		Me.btnOK.Name = "btnOK"
		Me.btnOK.Size = New System.Drawing.Size(150, 75)
		Me.btnOK.TabIndex = 60
		Me.btnOK.Text = "OK"
		Me.btnOK.UseVisualStyleBackColor = False
		'
		'BookingFinish
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(1260, 674)
		Me.Controls.Add(Me.btnOK)
		Me.Controls.Add(Me.lblDesc)
		Me.Controls.Add(Me.lblTitle)
		Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.Name = "BookingFinish"
		Me.Text = "BookingFinish"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblTitle As Label
	Friend WithEvents lblDesc As Label
	Friend WithEvents btnOK As Button
End Class
