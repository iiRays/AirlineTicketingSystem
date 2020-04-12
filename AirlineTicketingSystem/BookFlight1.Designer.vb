<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookFlight1
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
		Me.btnBack = New System.Windows.Forms.Button()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.lblId = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.lblArrival = New System.Windows.Forms.Label()
		Me.lblDestination = New System.Windows.Forms.Label()
		Me.lblDepartureTime = New System.Windows.Forms.Label()
		Me.lblSource = New System.Windows.Forms.Label()
		Me.lblDate = New System.Windows.Forms.Label()
		Me.txtPeople = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtCard = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.btnNext = New System.Windows.Forms.Button()
		Me.txtLuggageKg = New System.Windows.Forms.TextBox()
		Me.lblLuggage = New System.Windows.Forms.Label()
		Me.Panel2.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnBack
		'
		Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.btnBack.FlatAppearance.BorderSize = 0
		Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
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
		Me.lblTitle.Location = New System.Drawing.Point(496, 32)
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
		Me.lblId.Font = New System.Drawing.Font("OCR A Extended", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblId.ForeColor = System.Drawing.Color.White
		Me.lblId.Location = New System.Drawing.Point(0, 27)
		Me.lblId.Name = "lblId"
		Me.lblId.Size = New System.Drawing.Size(197, 54)
		Me.lblId.TabIndex = 41
		Me.lblId.Text = "001"
		Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Panel1
		'
		Me.Panel1.AutoSize = True
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
		'lblArrival
		'
		Me.lblArrival.AutoSize = True
		Me.lblArrival.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold)
		Me.lblArrival.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.lblArrival.Location = New System.Drawing.Point(605, 45)
		Me.lblArrival.Name = "lblArrival"
		Me.lblArrival.Size = New System.Drawing.Size(107, 39)
		Me.lblArrival.TabIndex = 47
		Me.lblArrival.Text = "15:00"
		Me.lblArrival.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblDestination
		'
		Me.lblDestination.AutoSize = True
		Me.lblDestination.Font = New System.Drawing.Font("Poppins", 20.0!, System.Drawing.FontStyle.Bold)
		Me.lblDestination.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.lblDestination.Location = New System.Drawing.Point(718, 45)
		Me.lblDestination.Name = "lblDestination"
		Me.lblDestination.Size = New System.Drawing.Size(214, 48)
		Me.lblDestination.TabIndex = 46
		Me.lblDestination.Text = "Kuala Lumpur"
		Me.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblDepartureTime
		'
		Me.lblDepartureTime.AutoSize = True
		Me.lblDepartureTime.Font = New System.Drawing.Font("Poppins", 25.0!, System.Drawing.FontStyle.Bold)
		Me.lblDepartureTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.lblDepartureTime.Location = New System.Drawing.Point(226, 38)
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
		Me.lblSource.Location = New System.Drawing.Point(344, 45)
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
		'txtPeople
		'
		Me.txtPeople.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtPeople.Font = New System.Drawing.Font("Microsoft Sans Serif", 37.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPeople.Location = New System.Drawing.Point(313, 289)
		Me.txtPeople.Name = "txtPeople"
		Me.txtPeople.Size = New System.Drawing.Size(100, 57)
		Me.txtPeople.TabIndex = 50
		Me.txtPeople.Tag = ""
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.White
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
		Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label4.Location = New System.Drawing.Point(104, 289)
		Me.Label4.Name = "Label4"
		Me.Label4.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label4.Size = New System.Drawing.Size(214, 57)
		Me.Label4.TabIndex = 49
		Me.Label4.Text = "no. of people"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtCard
		'
		Me.txtCard.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 37.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCard.Location = New System.Drawing.Point(326, 384)
		Me.txtCard.MaxLength = 19
		Me.txtCard.Name = "txtCard"
		Me.txtCard.Size = New System.Drawing.Size(453, 57)
		Me.txtCard.TabIndex = 52
		Me.txtCard.Tag = ""
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.White
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
		Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(105, 384)
		Me.Label3.Name = "Label3"
		Me.Label3.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label3.Size = New System.Drawing.Size(225, 57)
		Me.Label3.TabIndex = 51
		Me.Label3.Text = "credit card no."
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btnNext
		'
		Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.btnNext.FlatAppearance.BorderSize = 0
		Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnNext.ForeColor = System.Drawing.Color.White
		Me.btnNext.Location = New System.Drawing.Point(1077, 574)
		Me.btnNext.Name = "btnNext"
		Me.btnNext.Size = New System.Drawing.Size(150, 75)
		Me.btnNext.TabIndex = 53
		Me.btnNext.Text = "next"
		Me.btnNext.UseVisualStyleBackColor = False
		'
		'txtLuggageKg
		'
		Me.txtLuggageKg.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtLuggageKg.Font = New System.Drawing.Font("Microsoft Sans Serif", 37.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLuggageKg.Location = New System.Drawing.Point(391, 466)
		Me.txtLuggageKg.MaxLength = 19
		Me.txtLuggageKg.Name = "txtLuggageKg"
		Me.txtLuggageKg.Size = New System.Drawing.Size(100, 57)
		Me.txtLuggageKg.TabIndex = 55
		Me.txtLuggageKg.Tag = ""
		'
		'lblLuggage
		'
		Me.lblLuggage.BackColor = System.Drawing.Color.White
		Me.lblLuggage.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
		Me.lblLuggage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.lblLuggage.Location = New System.Drawing.Point(105, 466)
		Me.lblLuggage.Name = "lblLuggage"
		Me.lblLuggage.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.lblLuggage.Size = New System.Drawing.Size(290, 57)
		Me.lblLuggage.TabIndex = 54
		Me.lblLuggage.Text = "luggage kg. ($15/kg)"
		Me.lblLuggage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'BookFlight1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(1264, 681)
		Me.Controls.Add(Me.txtLuggageKg)
		Me.Controls.Add(Me.lblLuggage)
		Me.Controls.Add(Me.btnNext)
		Me.Controls.Add(Me.txtCard)
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
	Friend WithEvents txtCard As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents btnNext As Button
	Friend WithEvents txtLuggageKg As TextBox
	Friend WithEvents lblLuggage As Label
End Class
