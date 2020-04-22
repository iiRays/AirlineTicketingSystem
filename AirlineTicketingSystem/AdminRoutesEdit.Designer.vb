<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminRoutesEdit
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHrs = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMins = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnEditSource = New System.Windows.Forms.Button()
        Me.btnEditDestination = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(733, 538)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(165, 75)
        Me.btnSave.TabIndex = 80
        Me.btnSave.Text = "save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(224, 447)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(130, 65)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "hrs"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHrs
        '
        Me.txtHrs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHrs.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHrs.Location = New System.Drawing.Point(351, 447)
        Me.txtHrs.Multiline = True
        Me.txtHrs.Name = "txtHrs"
        Me.txtHrs.Size = New System.Drawing.Size(200, 65)
        Me.txtHrs.TabIndex = 78
        Me.txtHrs.Tag = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(572, 447)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(130, 65)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "mins"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMins
        '
        Me.txtMins.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMins.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMins.Location = New System.Drawing.Point(698, 447)
        Me.txtMins.Multiline = True
        Me.txtMins.Name = "txtMins"
        Me.txtMins.Size = New System.Drawing.Size(200, 65)
        Me.txtMins.TabIndex = 76
        Me.txtMins.Tag = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(223, 345)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(200, 75)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "destination"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDestination
        '
        Me.txtDestination.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDestination.Enabled = False
        Me.txtDestination.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestination.Location = New System.Drawing.Point(419, 345)
        Me.txtDestination.Multiline = True
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(479, 75)
        Me.txtDestination.TabIndex = 74
        Me.txtDestination.Tag = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(223, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(200, 75)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "source"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSource
        '
        Me.txtSource.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSource.Enabled = False
        Me.txtSource.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSource.Location = New System.Drawing.Point(419, 238)
        Me.txtSource.Multiline = True
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(479, 75)
        Me.txtSource.TabIndex = 72
        Me.txtSource.Tag = ""
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(32, 26)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 75)
        Me.btnCancel.TabIndex = 71
        Me.btnCancel.Text = "cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(497, 26)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(264, 70)
        Me.lblTitle.TabIndex = 70
        Me.lblTitle.Text = "edit a route"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(223, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(200, 75)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "ID"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(419, 137)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(479, 75)
        Me.txtID.TabIndex = 81
        Me.txtID.Tag = ""
        '
        'btnEditSource
        '
        Me.btnEditSource.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnEditSource.Enabled = False
        Me.btnEditSource.FlatAppearance.BorderSize = 0
        Me.btnEditSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditSource.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnEditSource.ForeColor = System.Drawing.Color.White
        Me.btnEditSource.Location = New System.Drawing.Point(920, 238)
        Me.btnEditSource.Name = "btnEditSource"
        Me.btnEditSource.Size = New System.Drawing.Size(165, 75)
        Me.btnEditSource.TabIndex = 83
        Me.btnEditSource.Text = "edit"
        Me.btnEditSource.UseVisualStyleBackColor = False
        '
        'btnEditDestination
        '
        Me.btnEditDestination.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnEditDestination.Enabled = False
        Me.btnEditDestination.FlatAppearance.BorderSize = 0
        Me.btnEditDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditDestination.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnEditDestination.ForeColor = System.Drawing.Color.White
        Me.btnEditDestination.Location = New System.Drawing.Point(920, 345)
        Me.btnEditDestination.Name = "btnEditDestination"
        Me.btnEditDestination.Size = New System.Drawing.Size(165, 75)
        Me.btnEditDestination.TabIndex = 84
        Me.btnEditDestination.Text = "edit"
        Me.btnEditDestination.UseVisualStyleBackColor = False
        '
        'AdminRoutesEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btnEditDestination)
        Me.Controls.Add(Me.btnEditSource)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtHrs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMins)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDestination)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSource)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "AdminRoutesEdit"
        Me.Text = "AdminRoutesEdit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHrs As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMins As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSource As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnEditSource As Button
    Friend WithEvents btnEditDestination As Button
End Class
