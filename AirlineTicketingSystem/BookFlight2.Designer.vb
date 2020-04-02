<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookFlight2
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
		Me.btnBack = New System.Windows.Forms.Button()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.btnNext = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnBack
		'
		Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.btnBack.FlatAppearance.BorderSize = 0
		Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnBack.ForeColor = System.Drawing.Color.White
		Me.btnBack.Location = New System.Drawing.Point(30, 24)
		Me.btnBack.Name = "btnBack"
		Me.btnBack.Size = New System.Drawing.Size(150, 75)
		Me.btnBack.TabIndex = 42
		Me.btnBack.Text = "back"
		Me.btnBack.UseVisualStyleBackColor = False
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.lblTitle.Location = New System.Drawing.Point(499, 38)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(214, 46)
		Me.lblTitle.TabIndex = 41
		Me.lblTitle.Text = "book flight"
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnNext
		'
		Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.btnNext.FlatAppearance.BorderSize = 0
		Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnNext.ForeColor = System.Drawing.Color.White
		Me.btnNext.Location = New System.Drawing.Point(1081, 577)
		Me.btnNext.Name = "btnNext"
		Me.btnNext.Size = New System.Drawing.Size(150, 75)
		Me.btnNext.TabIndex = 54
		Me.btnNext.Text = "next"
		Me.btnNext.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(135, 119)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(273, 39)
		Me.Label1.TabIndex = 55
		Me.Label1.Text = "add passengers"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'BookFlight2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = True
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(1264, 681)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnNext)
		Me.Controls.Add(Me.btnBack)
		Me.Controls.Add(Me.lblTitle)
		Me.Name = "BookFlight2"
		Me.Text = "Book Flight"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnBack As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents Label1 As Label
End Class
