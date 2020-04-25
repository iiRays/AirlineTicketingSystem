<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrorDialog
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
		Me.lblError = New System.Windows.Forms.Label()
		Me.btnOK = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lblTitle
		'
		Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblTitle.BackColor = System.Drawing.Color.Transparent
		Me.lblTitle.Font = New System.Drawing.Font("Poppins", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.White
		Me.lblTitle.Location = New System.Drawing.Point(92, 42)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.lblTitle.Size = New System.Drawing.Size(187, 40)
		Me.lblTitle.TabIndex = 56
		Me.lblTitle.Text = "Oh, an error!"
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblError
		'
		Me.lblError.AutoSize = True
		Me.lblError.BackColor = System.Drawing.Color.Transparent
		Me.lblError.Font = New System.Drawing.Font("Poppins", 15.0!)
		Me.lblError.ForeColor = System.Drawing.Color.White
		Me.lblError.Location = New System.Drawing.Point(-2, 107)
		Me.lblError.Margin = New System.Windows.Forms.Padding(3, 0, 6, 3)
		Me.lblError.Name = "lblError"
		Me.lblError.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.lblError.Size = New System.Drawing.Size(139, 36)
		Me.lblError.TabIndex = 58
		Me.lblError.Text = "- errorMsg"
		Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btnOK
		'
		Me.btnOK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.btnOK.FlatAppearance.BorderSize = 0
		Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnOK.Font = New System.Drawing.Font("Poppins", 17.0!, System.Drawing.FontStyle.Bold)
		Me.btnOK.ForeColor = System.Drawing.Color.White
		Me.btnOK.Location = New System.Drawing.Point(140, 163)
		Me.btnOK.Name = "btnOK"
		Me.btnOK.Size = New System.Drawing.Size(90, 46)
		Me.btnOK.TabIndex = 59
		Me.btnOK.Text = "ok"
		Me.btnOK.UseVisualStyleBackColor = False
		'
		'ErrorDialog
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = True
		Me.AutoSize = True
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(370, 292)
		Me.Controls.Add(Me.btnOK)
		Me.Controls.Add(Me.lblError)
		Me.Controls.Add(Me.lblTitle)
		Me.Name = "ErrorDialog"
		Me.Text = "ErrorWindow"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblTitle As Label
	Friend WithEvents lblError As Label
	Friend WithEvents btnOK As Button
End Class
