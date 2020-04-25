<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeUser))
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.btnMyBookings = New System.Windows.Forms.Button()
        Me.btnFlights = New System.Windows.Forms.Button()
        Me.lblLoginMsg = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnBookingSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAccount
        '
        Me.btnAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnAccount.FlatAppearance.BorderSize = 0
        Me.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccount.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnAccount.Location = New System.Drawing.Point(833, 324)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(300, 300)
        Me.btnAccount.TabIndex = 2
        Me.btnAccount.Text = "account"
        Me.btnAccount.UseVisualStyleBackColor = False
        '
        'btnMyBookings
        '
        Me.btnMyBookings.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnMyBookings.FlatAppearance.BorderSize = 0
        Me.btnMyBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyBookings.Font = New System.Drawing.Font("Poppins", 27.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnMyBookings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnMyBookings.Location = New System.Drawing.Point(502, 273)
        Me.btnMyBookings.Name = "btnMyBookings"
        Me.btnMyBookings.Size = New System.Drawing.Size(300, 300)
        Me.btnMyBookings.TabIndex = 1
        Me.btnMyBookings.Text = "my bookings"
        Me.btnMyBookings.UseVisualStyleBackColor = False
        '
        'btnFlights
        '
        Me.btnFlights.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnFlights.FlatAppearance.BorderSize = 0
        Me.btnFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFlights.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnFlights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnFlights.Location = New System.Drawing.Point(175, 229)
        Me.btnFlights.Name = "btnFlights"
        Me.btnFlights.Size = New System.Drawing.Size(300, 300)
        Me.btnFlights.TabIndex = 0
        Me.btnFlights.Text = "flights"
        Me.btnFlights.UseVisualStyleBackColor = False
        '
        'lblLoginMsg
        '
        Me.lblLoginMsg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoginMsg.AutoSize = True
        Me.lblLoginMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginMsg.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoginMsg.ForeColor = System.Drawing.Color.Snow
        Me.lblLoginMsg.Location = New System.Drawing.Point(182, 598)
        Me.lblLoginMsg.Name = "lblLoginMsg"
        Me.lblLoginMsg.Size = New System.Drawing.Size(145, 36)
        Me.lblLoginMsg.TabIndex = 34
        Me.lblLoginMsg.Text = "Logged in as"
        Me.lblLoginMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.ForeColor = System.Drawing.Color.Salmon
        Me.lblUsername.Location = New System.Drawing.Point(182, 634)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(524, 36)
        Me.lblUsername.TabIndex = 35
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Poppins", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(34, 33)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(175, 75)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnBookingSearch
        '
        Me.btnBookingSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnBookingSearch.FlatAppearance.BorderSize = 0
        Me.btnBookingSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookingSearch.Font = New System.Drawing.Font("Poppins", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnBookingSearch.ForeColor = System.Drawing.Color.White
        Me.btnBookingSearch.Location = New System.Drawing.Point(250, 33)
        Me.btnBookingSearch.Name = "btnBookingSearch"
        Me.btnBookingSearch.Size = New System.Drawing.Size(175, 75)
        Me.btnBookingSearch.TabIndex = 36
        Me.btnBookingSearch.Text = "Search booking"
        Me.btnBookingSearch.UseVisualStyleBackColor = False
        '
        'HomeUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btnBookingSearch)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblLoginMsg)
        Me.Controls.Add(Me.btnAccount)
        Me.Controls.Add(Me.btnMyBookings)
        Me.Controls.Add(Me.btnFlights)
        Me.Name = "HomeUser"
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAccount As Button
    Friend WithEvents btnMyBookings As Button
    Friend WithEvents btnFlights As Button
    Friend WithEvents lblLoginMsg As Label
    Friend WithEvents lblUsername As Label
	Friend WithEvents btnLogout As Button
    Friend WithEvents btnBookingSearch As Button
End Class
