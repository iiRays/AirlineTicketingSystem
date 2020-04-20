<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookCancel
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
		Me.cancelForm = New System.Windows.Forms.Label()
		Me.lblDesc = New System.Windows.Forms.Label()
		Me.pnlCancelContainer = New System.Windows.Forms.Panel()
		Me.pnlCancel = New System.Windows.Forms.Panel()
		Me.lblCancel = New System.Windows.Forms.Label()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnBack = New System.Windows.Forms.Button()
		Me.pnlCancelContainer.SuspendLayout()
		Me.pnlCancel.SuspendLayout()
		Me.SuspendLayout()
		'
		'cancelForm
		'
		Me.cancelForm.AutoSize = True
		Me.cancelForm.Font = New System.Drawing.Font("Poppins", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cancelForm.ForeColor = System.Drawing.Color.White
		Me.cancelForm.Location = New System.Drawing.Point(127, 37)
		Me.cancelForm.Name = "cancelForm"
		Me.cancelForm.Size = New System.Drawing.Size(489, 70)
		Me.cancelForm.TabIndex = 43
		Me.cancelForm.Text = "Confirm cancellation?"
		Me.cancelForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblDesc
		'
		Me.lblDesc.BackColor = System.Drawing.Color.Transparent
		Me.lblDesc.Font = New System.Drawing.Font("Poppins", 18.0!)
		Me.lblDesc.ForeColor = System.Drawing.Color.White
		Me.lblDesc.Location = New System.Drawing.Point(88, 125)
		Me.lblDesc.Name = "lblDesc"
		Me.lblDesc.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.lblDesc.Size = New System.Drawing.Size(566, 147)
		Me.lblDesc.TabIndex = 58
		Me.lblDesc.Text = "Once cancelled, the booking will no longer be valid. This action is irreversible." &
	""
		Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pnlCancelContainer
		'
		Me.pnlCancelContainer.BackColor = System.Drawing.Color.White
		Me.pnlCancelContainer.Controls.Add(Me.pnlCancel)
		Me.pnlCancelContainer.Location = New System.Drawing.Point(79, 337)
		Me.pnlCancelContainer.Name = "pnlCancelContainer"
		Me.pnlCancelContainer.Size = New System.Drawing.Size(585, 45)
		Me.pnlCancelContainer.TabIndex = 59
		'
		'pnlCancel
		'
		Me.pnlCancel.BackColor = System.Drawing.Color.Red
		Me.pnlCancel.Controls.Add(Me.lblCancel)
		Me.pnlCancel.Location = New System.Drawing.Point(200, 0)
		Me.pnlCancel.Name = "pnlCancel"
		Me.pnlCancel.Size = New System.Drawing.Size(122, 45)
		Me.pnlCancel.TabIndex = 60
		'
		'lblCancel
		'
		Me.lblCancel.AutoSize = True
		Me.lblCancel.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCancel.ForeColor = System.Drawing.Color.White
		Me.lblCancel.Location = New System.Drawing.Point(8, 4)
		Me.lblCancel.Name = "lblCancel"
		Me.lblCancel.Size = New System.Drawing.Size(107, 36)
		Me.lblCancel.TabIndex = 60
		Me.lblCancel.Text = "cancel >>"
		Me.lblCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnCancel
		'
		Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.btnCancel.FlatAppearance.BorderSize = 0
		Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCancel.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnCancel.ForeColor = System.Drawing.Color.White
		Me.btnCancel.Location = New System.Drawing.Point(247, 304)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(248, 75)
		Me.btnCancel.TabIndex = 67
		Me.btnCancel.Text = "cancel booking"
		Me.btnCancel.UseVisualStyleBackColor = False
		'
		'btnBack
		'
		Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.btnBack.FlatAppearance.BorderSize = 0
		Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBack.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnBack.ForeColor = System.Drawing.Color.White
		Me.btnBack.Location = New System.Drawing.Point(296, 405)
		Me.btnBack.Name = "btnBack"
		Me.btnBack.Size = New System.Drawing.Size(150, 75)
		Me.btnBack.TabIndex = 68
		Me.btnBack.Text = "back"
		Me.btnBack.UseVisualStyleBackColor = False
		'
		'BookCancel
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(743, 506)
		Me.Controls.Add(Me.btnBack)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.pnlCancelContainer)
		Me.Controls.Add(Me.lblDesc)
		Me.Controls.Add(Me.cancelForm)
		Me.Name = "BookCancel"
		Me.Text = "BookingCancel"
		Me.pnlCancelContainer.ResumeLayout(False)
		Me.pnlCancel.ResumeLayout(False)
		Me.pnlCancel.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents cancelForm As Label
	Friend WithEvents lblDesc As Label
	Friend WithEvents pnlCancelContainer As Panel
	Friend WithEvents pnlCancel As Panel
	Friend WithEvents lblCancel As Label
	Friend WithEvents btnCancel As Button
	Friend WithEvents btnBack As Button
End Class
