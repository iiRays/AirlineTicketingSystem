<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminFlightsDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminFlightsDashboard))
        Me.btnRoutes = New System.Windows.Forms.Button()
        Me.btnFlights = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRoutes
        '
        Me.btnRoutes.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnRoutes.FlatAppearance.BorderSize = 0
        Me.btnRoutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoutes.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnRoutes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnRoutes.Location = New System.Drawing.Point(627, 272)
        Me.btnRoutes.Name = "btnRoutes"
        Me.btnRoutes.Size = New System.Drawing.Size(300, 300)
        Me.btnRoutes.TabIndex = 37
        Me.btnRoutes.Text = "view flights"
        Me.btnRoutes.UseVisualStyleBackColor = False
        '
        'btnFlights
        '
        Me.btnFlights.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnFlights.FlatAppearance.BorderSize = 0
        Me.btnFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFlights.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnFlights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnFlights.Location = New System.Drawing.Point(296, 230)
        Me.btnFlights.Name = "btnFlights"
        Me.btnFlights.Size = New System.Drawing.Size(300, 300)
        Me.btnFlights.TabIndex = 36
        Me.btnFlights.Text = "add flight"
        Me.btnFlights.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Poppins", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(45, 34)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(175, 75)
        Me.btnBack.TabIndex = 35
        Me.btnBack.Text = "back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'AdminFlightsDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btnRoutes)
        Me.Controls.Add(Me.btnFlights)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "AdminFlightsDashboard"
        Me.Text = "AdminFlightsDashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRoutes As Button
    Friend WithEvents btnFlights As Button
    Friend WithEvents btnBack As Button
End Class
