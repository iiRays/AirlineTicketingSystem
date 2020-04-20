<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnFlights = New System.Windows.Forms.Button()
        Me.btnRoutes = New System.Windows.Forms.Button()
        Me.btnCities = New System.Windows.Forms.Button()
        Me.btnPlanes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(532, 109)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(181, 70)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "ao zora"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(36, 34)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 75)
        Me.btnBack.TabIndex = 26
        Me.btnBack.Text = "back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnFlights
        '
        Me.btnFlights.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnFlights.FlatAppearance.BorderSize = 0
        Me.btnFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFlights.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnFlights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnFlights.Location = New System.Drawing.Point(120, 252)
        Me.btnFlights.Name = "btnFlights"
        Me.btnFlights.Size = New System.Drawing.Size(225, 250)
        Me.btnFlights.TabIndex = 27
        Me.btnFlights.Text = "flights"
        Me.btnFlights.UseVisualStyleBackColor = False
        '
        'btnRoutes
        '
        Me.btnRoutes.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnRoutes.FlatAppearance.BorderSize = 0
        Me.btnRoutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoutes.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnRoutes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnRoutes.Location = New System.Drawing.Point(390, 252)
        Me.btnRoutes.Name = "btnRoutes"
        Me.btnRoutes.Size = New System.Drawing.Size(225, 250)
        Me.btnRoutes.TabIndex = 28
        Me.btnRoutes.Text = "routes"
        Me.btnRoutes.UseVisualStyleBackColor = False
        '
        'btnCities
        '
        Me.btnCities.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnCities.FlatAppearance.BorderSize = 0
        Me.btnCities.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCities.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnCities.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnCities.Location = New System.Drawing.Point(658, 252)
        Me.btnCities.Name = "btnCities"
        Me.btnCities.Size = New System.Drawing.Size(225, 250)
        Me.btnCities.TabIndex = 29
        Me.btnCities.Text = "cities"
        Me.btnCities.UseVisualStyleBackColor = False
        '
        'btnPlanes
        '
        Me.btnPlanes.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnPlanes.FlatAppearance.BorderSize = 0
        Me.btnPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlanes.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnPlanes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnPlanes.Location = New System.Drawing.Point(924, 252)
        Me.btnPlanes.Name = "btnPlanes"
        Me.btnPlanes.Size = New System.Drawing.Size(225, 250)
        Me.btnPlanes.TabIndex = 30
        Me.btnPlanes.Text = "planes"
        Me.btnPlanes.UseVisualStyleBackColor = False
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btnPlanes)
        Me.Controls.Add(Me.btnCities)
        Me.Controls.Add(Me.btnRoutes)
        Me.Controls.Add(Me.btnFlights)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "AdminDashboard"
        Me.Text = "Admin Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnFlights As Button
    Friend WithEvents btnRoutes As Button
    Friend WithEvents btnCities As Button
    Friend WithEvents btnPlanes As Button
End Class
