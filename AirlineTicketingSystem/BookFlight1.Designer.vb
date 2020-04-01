<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookFlight1
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDepartureTime = New System.Windows.Forms.Label()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblArrival = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.txtPeople = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(27, 27)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 75)
        Me.btnBack.TabIndex = 40
        Me.btnBack.Text = "back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(496, 41)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(249, 70)
        Me.lblTitle.TabIndex = 39
        Me.lblTitle.Text = "book flight"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblId)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(100, 140)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 115)
        Me.Panel2.TabIndex = 44
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("OCR A Extended", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.Color.White
        Me.lblId.Location = New System.Drawing.Point(41, 27)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(122, 54)
        Me.lblId.TabIndex = 41
        Me.lblId.Text = "001"
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblArrival)
        Me.Panel1.Controls.Add(Me.lblDestination)
        Me.Panel1.Controls.Add(Me.lblDepartureTime)
        Me.Panel1.Controls.Add(Me.lblSource)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(100, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 115)
        Me.Panel1.TabIndex = 43
        '
        'lblDepartureTime
        '
        Me.lblDepartureTime.AutoSize = True
        Me.lblDepartureTime.Font = New System.Drawing.Font("Poppins", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lblDepartureTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblDepartureTime.Location = New System.Drawing.Point(238, 45)
        Me.lblDepartureTime.Name = "lblDepartureTime"
        Me.lblDepartureTime.Size = New System.Drawing.Size(112, 60)
        Me.lblDepartureTime.TabIndex = 45
        Me.lblDepartureTime.Text = "15:00"
        Me.lblDepartureTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Font = New System.Drawing.Font("Poppins", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblSource.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblSource.Location = New System.Drawing.Point(345, 52)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(214, 48)
        Me.lblSource.TabIndex = 44
        Me.lblSource.Text = "Kuala Lumpur"
        Me.lblSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Poppins", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(241, 13)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(266, 39)
        Me.lblDate.TabIndex = 42
        Me.lblDate.Text = "Monday, 9 March 2020"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblArrival
        '
        Me.lblArrival.AutoSize = True
        Me.lblArrival.Font = New System.Drawing.Font("Poppins", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lblArrival.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblArrival.Location = New System.Drawing.Point(605, 45)
        Me.lblArrival.Name = "lblArrival"
        Me.lblArrival.Size = New System.Drawing.Size(112, 60)
        Me.lblArrival.TabIndex = 47
        Me.lblArrival.Text = "15:00"
        Me.lblArrival.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Font = New System.Drawing.Font("Poppins", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblDestination.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblDestination.Location = New System.Drawing.Point(712, 52)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(214, 48)
        Me.lblDestination.TabIndex = 46
        Me.lblDestination.Text = "Kuala Lumpur"
        Me.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPeople
        '
        Me.txtPeople.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPeople.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeople.Location = New System.Drawing.Point(255, 284)
        Me.txtPeople.Multiline = True
        Me.txtPeople.Name = "txtPeople"
        Me.txtPeople.Size = New System.Drawing.Size(100, 75)
        Me.txtPeople.TabIndex = 50
        Me.txtPeople.Tag = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(101, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(160, 75)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "people"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(255, 382)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(300, 75)
        Me.TextBox1.TabIndex = 52
        Me.TextBox1.Tag = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(101, 382)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(160, 75)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "card no."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1077, 574)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 75)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "next"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BookFlight1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPeople)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "BookFlight1"
        Me.Text = "Book Flight"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblId As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblArrival As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents lblDepartureTime As Label
    Friend WithEvents lblSource As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtPeople As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
