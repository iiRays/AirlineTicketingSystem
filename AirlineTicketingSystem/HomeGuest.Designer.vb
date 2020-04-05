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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeGuest))
		Me.btnLogin = New System.Windows.Forms.Button()
		Me.btnFlights = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.btnBookingSearch = New System.Windows.Forms.Button()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnLogin
		'
		Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(78, Byte), Integer))
		Me.btnLogin.FlatAppearance.BorderSize = 0
		Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLogin.Font = New System.Drawing.Font("Poppins", 35.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
		Me.btnLogin.Location = New System.Drawing.Point(654, 318)
		Me.btnLogin.Name = "btnLogin"
		Me.btnLogin.Size = New System.Drawing.Size(300, 300)
		Me.btnLogin.TabIndex = 32
		Me.btnLogin.UseVisualStyleBackColor = False
		'
		'btnFlights
		'
		Me.btnFlights.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(78, Byte), Integer))
		Me.btnFlights.FlatAppearance.BorderSize = 0
		Me.btnFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnFlights.Font = New System.Drawing.Font("Poppins", 35.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnFlights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.btnFlights.Image = CType(resources.GetObject("btnFlights.Image"), System.Drawing.Image)
		Me.btnFlights.Location = New System.Drawing.Point(328, 318)
		Me.btnFlights.Name = "btnFlights"
		Me.btnFlights.Size = New System.Drawing.Size(300, 300)
		Me.btnFlights.TabIndex = 31
		Me.btnFlights.UseVisualStyleBackColor = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(-1, 30)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(1280, 690)
		Me.PictureBox1.TabIndex = 33
		Me.PictureBox1.TabStop = False
		'
		'btnBookingSearch
		'
		Me.btnBookingSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.btnBookingSearch.FlatAppearance.BorderSize = 0
		Me.btnBookingSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBookingSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnBookingSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.btnBookingSearch.Location = New System.Drawing.Point(1067, 63)
		Me.btnBookingSearch.Name = "btnBookingSearch"
		Me.btnBookingSearch.Size = New System.Drawing.Size(183, 118)
		Me.btnBookingSearch.TabIndex = 34
		Me.btnBookingSearch.Text = "Search booking"
		Me.btnBookingSearch.UseVisualStyleBackColor = False
		'
		'HomeGuest
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(1280, 720)
		Me.Controls.Add(Me.btnBookingSearch)
		Me.Controls.Add(Me.btnLogin)
		Me.Controls.Add(Me.btnFlights)
		Me.Controls.Add(Me.PictureBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "HomeGuest"
		Me.Text = "Home"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents btnLogin As Button
	Friend WithEvents btnFlights As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBookingSearch As Button
End Class
