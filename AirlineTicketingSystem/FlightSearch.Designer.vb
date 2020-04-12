<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlightSearch
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
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtFrom = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.txtTo = New System.Windows.Forms.TextBox()
		Me.btnSearch = New System.Windows.Forms.Button()
		Me.dtpDate = New System.Windows.Forms.DateTimePicker()
		Me.txtDate = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.lblTitle.Location = New System.Drawing.Point(531, 49)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(160, 70)
		Me.lblTitle.TabIndex = 28
		Me.lblTitle.Text = "flights"
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnBack
		'
		Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.btnBack.FlatAppearance.BorderSize = 0
		Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBack.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnBack.ForeColor = System.Drawing.Color.White
		Me.btnBack.Location = New System.Drawing.Point(38, 33)
		Me.btnBack.Name = "btnBack"
		Me.btnBack.Size = New System.Drawing.Size(150, 75)
		Me.btnBack.TabIndex = 36
		Me.btnBack.Text = "back"
		Me.btnBack.UseVisualStyleBackColor = False
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.White
		Me.Label3.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
		Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(289, 183)
		Me.Label3.Name = "Label3"
		Me.Label3.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label3.Size = New System.Drawing.Size(125, 75)
		Me.Label3.TabIndex = 45
		Me.Label3.Text = "from"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtFrom
		'
		Me.txtFrom.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtFrom.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFrom.Location = New System.Drawing.Point(410, 183)
		Me.txtFrom.Multiline = True
		Me.txtFrom.Name = "txtFrom"
		Me.txtFrom.Size = New System.Drawing.Size(550, 75)
		Me.txtFrom.TabIndex = 44
		Me.txtFrom.Tag = ""
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.White
		Me.Label2.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
		Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(403, 389)
		Me.Label2.Name = "Label2"
		Me.Label2.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label2.Size = New System.Drawing.Size(125, 75)
		Me.Label2.TabIndex = 42
		Me.Label2.Text = "date"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.White
		Me.Label1.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(289, 288)
		Me.Label1.Name = "Label1"
		Me.Label1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label1.Size = New System.Drawing.Size(125, 75)
		Me.Label1.TabIndex = 41
		Me.Label1.Text = "to"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TextBox1
		'
		Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox1.Location = New System.Drawing.Point(464, 363)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(1, 1)
		Me.TextBox1.TabIndex = 40
		Me.TextBox1.Tag = ""
		Me.TextBox1.Text = "Email"
		'
		'txtTo
		'
		Me.txtTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtTo.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTo.Location = New System.Drawing.Point(410, 288)
		Me.txtTo.Multiline = True
		Me.txtTo.Name = "txtTo"
		Me.txtTo.Size = New System.Drawing.Size(550, 75)
		Me.txtTo.TabIndex = 39
		Me.txtTo.Tag = ""
		'
		'btnSearch
		'
		Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.btnSearch.FlatAppearance.BorderSize = 0
		Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSearch.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnSearch.ForeColor = System.Drawing.Color.White
		Me.btnSearch.Location = New System.Drawing.Point(501, 489)
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Size = New System.Drawing.Size(165, 75)
		Me.btnSearch.TabIndex = 46
		Me.btnSearch.Text = "search"
		Me.btnSearch.UseVisualStyleBackColor = False
		'
		'dtpDate
		'
		Me.dtpDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
		Me.dtpDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.dtpDate.CustomFormat = "d MMM yyyy"
		Me.dtpDate.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDate.Location = New System.Drawing.Point(524, 403)
		Me.dtpDate.Name = "dtpDate"
		Me.dtpDate.Size = New System.Drawing.Size(274, 43)
		Me.dtpDate.TabIndex = 49
		'
		'txtDate
		'
		Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtDate.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDate.Location = New System.Drawing.Point(524, 389)
		Me.txtDate.Multiline = True
		Me.txtDate.Name = "txtDate"
		Me.txtDate.Size = New System.Drawing.Size(300, 75)
		Me.txtDate.TabIndex = 43
		Me.txtDate.Tag = ""
		'
		'FlightSearch
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(1264, 681)
		Me.Controls.Add(Me.dtpDate)
		Me.Controls.Add(Me.btnSearch)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtFrom)
		Me.Controls.Add(Me.txtDate)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.txtTo)
		Me.Controls.Add(Me.btnBack)
		Me.Controls.Add(Me.lblTitle)
		Me.Name = "FlightSearch"
		Me.Text = "Flight Search"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblTitle As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtTo As TextBox
    Friend WithEvents btnSearch As Button
	Friend WithEvents dtpDate As DateTimePicker
	Friend WithEvents txtDate As TextBox
End Class
