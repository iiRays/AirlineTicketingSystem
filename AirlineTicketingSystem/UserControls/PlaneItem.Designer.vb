<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlaneItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblId)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(254, 75)
        Me.Panel2.TabIndex = 46
        '
        'lblId
        '
        Me.lblId.Font = New System.Drawing.Font("OCR A Extended", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.Color.White
        Me.lblId.Location = New System.Drawing.Point(3, 11)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(248, 54)
        Me.lblId.TabIndex = 41
        Me.lblId.Text = "00144"
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnGo)
        Me.Panel1.Controls.Add(Me.lblCapacity)
        Me.Panel1.Controls.Add(Me.lblModel)
        Me.Panel1.Controls.Add(Me.lblManufacturer)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(248, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 75)
        Me.Panel1.TabIndex = 45
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnGo.FlatAppearance.BorderSize = 0
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnGo.ForeColor = System.Drawing.Color.White
        Me.btnGo.Location = New System.Drawing.Point(622, 6)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(125, 65)
        Me.btnGo.TabIndex = 45
        Me.btnGo.Text = "go"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Font = New System.Drawing.Font("Poppins", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblCapacity.Location = New System.Drawing.Point(468, 20)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(148, 39)
        Me.lblCapacity.TabIndex = 45
        Me.lblCapacity.Text = "130 persons"
        Me.lblCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Poppins", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblModel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblModel.Location = New System.Drawing.Point(27, 11)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(140, 53)
        Me.lblModel.TabIndex = 44
        Me.lblModel.Text = "737-700"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblManufacturer
        '
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.Font = New System.Drawing.Font("Poppins", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManufacturer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblManufacturer.Location = New System.Drawing.Point(275, 20)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(95, 39)
        Me.lblManufacturer.TabIndex = 42
        Me.lblManufacturer.Text = "Boeing"
        Me.lblManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlaneItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PlaneItem"
        Me.Size = New System.Drawing.Size(1004, 85)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblId As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGo As Button
    Friend WithEvents lblCapacity As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblManufacturer As Label
End Class
