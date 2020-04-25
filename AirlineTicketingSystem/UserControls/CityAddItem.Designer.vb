<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CityAddItem
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
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
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
        Me.Panel2.Size = New System.Drawing.Size(254, 50)
        Me.Panel2.TabIndex = 48
        '
        'lblId
        '
        Me.lblId.Font = New System.Drawing.Font("OCR A Extended", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.Color.White
        Me.lblId.Location = New System.Drawing.Point(3, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(248, 50)
        Me.lblId.TabIndex = 41
        Me.lblId.Text = "00144"
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnSelect)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(248, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 50)
        Me.Panel1.TabIndex = 47
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnSelect.FlatAppearance.BorderSize = 0
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnSelect.ForeColor = System.Drawing.Color.White
        Me.btnSelect.Location = New System.Drawing.Point(275, 0)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(125, 50)
        Me.btnSelect.TabIndex = 45
        Me.btnSelect.Text = "select"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(15, 6)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(189, 42)
        Me.lblName.TabIndex = 44
        Me.lblName.Text = "Kuala Lumpur"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CityAddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CityAddItem"
        Me.Size = New System.Drawing.Size(653, 57)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblId As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSelect As Button
    Friend WithEvents lblName As Label
End Class
