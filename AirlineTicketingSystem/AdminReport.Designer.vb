<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminReport))
        Me.btnSalesDaily = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnFlightSch = New System.Windows.Forms.Button()
        Me.btnDailyCancel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSalesDaily
        '
        Me.btnSalesDaily.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnSalesDaily.FlatAppearance.BorderSize = 0
        Me.btnSalesDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalesDaily.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnSalesDaily.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnSalesDaily.Location = New System.Drawing.Point(132, 323)
        Me.btnSalesDaily.Name = "btnSalesDaily"
        Me.btnSalesDaily.Size = New System.Drawing.Size(500, 100)
        Me.btnSalesDaily.TabIndex = 34
        Me.btnSalesDaily.Text = "daily sales report"
        Me.btnSalesDaily.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Poppins", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(46, 38)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(175, 75)
        Me.btnBack.TabIndex = 33
        Me.btnBack.Text = "back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnFlightSch
        '
        Me.btnFlightSch.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnFlightSch.FlatAppearance.BorderSize = 0
        Me.btnFlightSch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFlightSch.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnFlightSch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnFlightSch.Location = New System.Drawing.Point(648, 323)
        Me.btnFlightSch.Name = "btnFlightSch"
        Me.btnFlightSch.Size = New System.Drawing.Size(500, 100)
        Me.btnFlightSch.TabIndex = 35
        Me.btnFlightSch.Text = "flights schedule && route report"
        Me.btnFlightSch.UseVisualStyleBackColor = False
        '
        'btnDailyCancel
        '
        Me.btnDailyCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnDailyCancel.FlatAppearance.BorderSize = 0
        Me.btnDailyCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDailyCancel.Font = New System.Drawing.Font("Poppins", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnDailyCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnDailyCancel.Location = New System.Drawing.Point(648, 438)
        Me.btnDailyCancel.Name = "btnDailyCancel"
        Me.btnDailyCancel.Size = New System.Drawing.Size(500, 100)
        Me.btnDailyCancel.TabIndex = 36
        Me.btnDailyCancel.Text = "daily cancellation report"
        Me.btnDailyCancel.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(132, 436)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(500, 100)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "user report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AdminReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDailyCancel)
        Me.Controls.Add(Me.btnFlightSch)
        Me.Controls.Add(Me.btnSalesDaily)
        Me.Controls.Add(Me.btnBack)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "AdminReport"
        Me.Text = "AdminReport"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalesDaily As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnFlightSch As Button
    Friend WithEvents btnDailyCancel As Button
    Friend WithEvents Button1 As Button
End Class
