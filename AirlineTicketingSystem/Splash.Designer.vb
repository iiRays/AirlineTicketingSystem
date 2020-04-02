<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Splash
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
	Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
	Friend WithEvents Version As System.Windows.Forms.Label
	Friend WithEvents Copyright As System.Windows.Forms.Label
	Friend WithEvents MainLayoutPanel As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents DetailsLayoutPanel As System.Windows.Forms.TableLayoutPanel

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.MainLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
		Me.DetailsLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
		Me.Version = New System.Windows.Forms.Label()
		Me.Copyright = New System.Windows.Forms.Label()
		Me.ApplicationTitle = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.MainLayoutPanel.SuspendLayout()
		Me.DetailsLayoutPanel.SuspendLayout()
		Me.SuspendLayout()
		'
		'MainLayoutPanel
		'
		Me.MainLayoutPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.MainLayoutPanel.ColumnCount = 2
		Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243.0!))
		Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
		Me.MainLayoutPanel.Controls.Add(Me.DetailsLayoutPanel, 1, 1)
		Me.MainLayoutPanel.Controls.Add(Me.ApplicationTitle, 1, 0)
		Me.MainLayoutPanel.Controls.Add(Me.Label1, 0, 0)
		Me.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
		Me.MainLayoutPanel.Location = New System.Drawing.Point(0, 0)
		Me.MainLayoutPanel.Name = "MainLayoutPanel"
		Me.MainLayoutPanel.RowCount = 2
		Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218.0!))
		Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
		Me.MainLayoutPanel.Size = New System.Drawing.Size(496, 303)
		Me.MainLayoutPanel.TabIndex = 0
		'
		'DetailsLayoutPanel
		'
		Me.DetailsLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.DetailsLayoutPanel.BackColor = System.Drawing.Color.Transparent
		Me.DetailsLayoutPanel.ColumnCount = 1
		Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247.0!))
		Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
		Me.DetailsLayoutPanel.Controls.Add(Me.Version, 0, 0)
		Me.DetailsLayoutPanel.Controls.Add(Me.Copyright, 0, 1)
		Me.DetailsLayoutPanel.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DetailsLayoutPanel.Location = New System.Drawing.Point(246, 221)
		Me.DetailsLayoutPanel.Name = "DetailsLayoutPanel"
		Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
		Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
		Me.DetailsLayoutPanel.Size = New System.Drawing.Size(247, 79)
		Me.DetailsLayoutPanel.TabIndex = 1
		'
		'Version
		'
		Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Version.BackColor = System.Drawing.Color.Transparent
		Me.Version.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Version.ForeColor = System.Drawing.Color.White
		Me.Version.Location = New System.Drawing.Point(3, 9)
		Me.Version.Name = "Version"
		Me.Version.Size = New System.Drawing.Size(241, 20)
		Me.Version.TabIndex = 1
		Me.Version.Text = "Version {0}.{1:00}"
		'
		'Copyright
		'
		Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Copyright.BackColor = System.Drawing.Color.Transparent
		Me.Copyright.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Copyright.ForeColor = System.Drawing.Color.White
		Me.Copyright.Location = New System.Drawing.Point(3, 39)
		Me.Copyright.Name = "Copyright"
		Me.Copyright.Size = New System.Drawing.Size(241, 40)
		Me.Copyright.TabIndex = 2
		Me.Copyright.Text = "Copyright"
		'
		'ApplicationTitle
		'
		Me.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
		Me.ApplicationTitle.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ApplicationTitle.ForeColor = System.Drawing.Color.White
		Me.ApplicationTitle.Location = New System.Drawing.Point(246, 3)
		Me.ApplicationTitle.Name = "ApplicationTitle"
		Me.ApplicationTitle.Size = New System.Drawing.Size(247, 212)
		Me.ApplicationTitle.TabIndex = 0
		Me.ApplicationTitle.Text = "AoZora"
		Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Poppins", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.DarkCyan
		Me.Label1.Location = New System.Drawing.Point(3, 3)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(237, 212)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "アオゾラ"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'Splash
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(496, 303)
		Me.ControlBox = False
		Me.Controls.Add(Me.MainLayoutPanel)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Splash"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.MainLayoutPanel.ResumeLayout(False)
		Me.DetailsLayoutPanel.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Label1 As Label
End Class
