<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeAdmin))
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnFlights = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAccount
        '
        Me.btnAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnAccount.FlatAppearance.BorderSize = 0
        Me.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccount.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnAccount.Location = New System.Drawing.Point(831, 293)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(300, 300)
        Me.btnAccount.TabIndex = 33
        Me.btnAccount.Text = "account"
        Me.btnAccount.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnDashboard.Location = New System.Drawing.Point(501, 241)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(300, 300)
        Me.btnDashboard.TabIndex = 32
        Me.btnDashboard.Text = "dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnFlights
        '
        Me.btnFlights.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnFlights.FlatAppearance.BorderSize = 0
        Me.btnFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFlights.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnFlights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnFlights.Location = New System.Drawing.Point(174, 196)
        Me.btnFlights.Name = "btnFlights"
        Me.btnFlights.Size = New System.Drawing.Size(300, 300)
        Me.btnFlights.TabIndex = 31
        Me.btnFlights.Text = "flights"
        Me.btnFlights.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Poppins", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(36, 31)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(175, 75)
        Me.btnLogout.TabIndex = 34
        Me.btnLogout.Text = "logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'HomeAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnAccount)
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.btnFlights)
        Me.Name = "HomeAdmin"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAccount As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnFlights As Button
    Friend WithEvents btnLogout As Button
End Class
