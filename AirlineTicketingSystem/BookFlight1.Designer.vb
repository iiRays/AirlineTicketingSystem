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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookFlight1))
		Me.btnBack = New System.Windows.Forms.Button()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.lblId = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.lblArrival = New System.Windows.Forms.Label()
		Me.lblDestination = New System.Windows.Forms.Label()
		Me.lblDepartureTime = New System.Windows.Forms.Label()
		Me.lblSource = New System.Windows.Forms.Label()
		Me.lblDate = New System.Windows.Forms.Label()
		Me.btnNext = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.btnPayerInfo = New System.Windows.Forms.Button()
		Me.lblInfoStatus = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtPeople = New System.Windows.Forms.TextBox()
		Me.lblLuggage = New System.Windows.Forms.Label()
		Me.txtLuggageKg = New System.Windows.Forms.TextBox()
		Me.Panel2.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnBack
		'
		Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.btnBack.FlatAppearance.BorderSize = 0
		Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBack.Font = New System.Drawing.Font("Poppins", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnBack.ForeColor = System.Drawing.Color.White
		Me.btnBack.Location = New System.Drawing.Point(59, 40)
		Me.btnBack.Name = "btnBack"
		Me.btnBack.Size = New System.Drawing.Size(175, 75)
		Me.btnBack.TabIndex = 3
		Me.btnBack.Text = "back"
		Me.btnBack.UseVisualStyleBackColor = False
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.Panel2.Controls.Add(Me.lblId)
		Me.Panel2.Font = New System.Drawing.Font("Poppins", 8.25!)
		Me.Panel2.Location = New System.Drawing.Point(100, 177)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(200, 115)
		Me.Panel2.TabIndex = 44
		'
		'lblId
		'
		Me.lblId.Font = New System.Drawing.Font("Poppins", 29.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Panel1.Location = New System.Drawing.Point(100, 177)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1000, 115)
		Me.Panel1.TabIndex = 43
		'
		'lblArrival
		'
		Me.lblArrival.AutoSize = True
		Me.lblArrival.Font = New System.Drawing.Font("Poppins", 25.0!, System.Drawing.FontStyle.Bold)
		Me.lblArrival.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.lblArrival.Location = New System.Drawing.Point(600, 38)
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
		Me.lblDate.Font = New System.Drawing.Font("Poppins", 16.0!, System.Drawing.FontStyle.Bold)
		Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.lblDate.Location = New System.Drawing.Point(229, 6)
		Me.lblDate.Name = "lblDate"
		Me.lblDate.Size = New System.Drawing.Size(266, 39)
		Me.lblDate.TabIndex = 42
		Me.lblDate.Text = "Monday, 9 March 2020"
		Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnNext
		'
		Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.btnNext.FlatAppearance.BorderSize = 0
		Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNext.Font = New System.Drawing.Font("Poppins", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnNext.ForeColor = System.Drawing.Color.White
		Me.btnNext.Location = New System.Drawing.Point(1028, 564)
		Me.btnNext.Name = "btnNext"
		Me.btnNext.Size = New System.Drawing.Size(175, 75)
		Me.btnNext.TabIndex = 2
		Me.btnNext.Text = "next"
		Me.btnNext.UseVisualStyleBackColor = False
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.Label5.Location = New System.Drawing.Point(99, 314)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(307, 70)
		Me.Label5.TabIndex = 59
		Me.Label5.Text = "payment info"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnPayerInfo
		'
		Me.btnPayerInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.btnPayerInfo.FlatAppearance.BorderSize = 0
		Me.btnPayerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnPayerInfo.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnPayerInfo.ForeColor = System.Drawing.Color.White
		Me.btnPayerInfo.Location = New System.Drawing.Point(111, 387)
		Me.btnPayerInfo.Name = "btnPayerInfo"
		Me.btnPayerInfo.Size = New System.Drawing.Size(248, 58)
		Me.btnPayerInfo.TabIndex = 72
		Me.btnPayerInfo.Text = "click to enter info"
		Me.btnPayerInfo.UseVisualStyleBackColor = False
		'
		'lblInfoStatus
		'
		Me.lblInfoStatus.BackColor = System.Drawing.Color.Transparent
		Me.lblInfoStatus.Font = New System.Drawing.Font("Poppins", 20.0!, System.Drawing.FontStyle.Bold)
		Me.lblInfoStatus.ForeColor = System.Drawing.Color.DarkRed
		Me.lblInfoStatus.Location = New System.Drawing.Point(365, 390)
		Me.lblInfoStatus.Name = "lblInfoStatus"
		Me.lblInfoStatus.Size = New System.Drawing.Size(214, 52)
		Me.lblInfoStatus.TabIndex = 62
		Me.lblInfoStatus.Text = "not yet filled"
		Me.lblInfoStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.Label6.Location = New System.Drawing.Point(767, 314)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(287, 70)
		Me.Label6.TabIndex = 74
		Me.Label6.Text = "booking info"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.White
		Me.Label4.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
		Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label4.Location = New System.Drawing.Point(657, 384)
		Me.Label4.Name = "Label4"
		Me.Label4.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label4.Size = New System.Drawing.Size(291, 57)
		Me.Label4.TabIndex = 49
		Me.Label4.Text = "no. of people"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtPeople
		'
		Me.txtPeople.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtPeople.Font = New System.Drawing.Font("Microsoft Sans Serif", 37.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPeople.Location = New System.Drawing.Point(945, 384)
		Me.txtPeople.MaxLength = 10
		Me.txtPeople.Name = "txtPeople"
		Me.txtPeople.Size = New System.Drawing.Size(170, 57)
		Me.txtPeople.TabIndex = 0
		Me.txtPeople.Tag = ""
		'
		'lblLuggage
		'
		Me.lblLuggage.BackColor = System.Drawing.Color.White
		Me.lblLuggage.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
		Me.lblLuggage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.lblLuggage.Location = New System.Drawing.Point(658, 456)
		Me.lblLuggage.Name = "lblLuggage"
		Me.lblLuggage.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.lblLuggage.Size = New System.Drawing.Size(290, 57)
		Me.lblLuggage.TabIndex = 54
		Me.lblLuggage.Text = "luggage kg. ($15/kg)"
		Me.lblLuggage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtLuggageKg
		'
		Me.txtLuggageKg.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtLuggageKg.Font = New System.Drawing.Font("Microsoft Sans Serif", 37.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLuggageKg.Location = New System.Drawing.Point(945, 456)
		Me.txtLuggageKg.MaxLength = 10
		Me.txtLuggageKg.Name = "txtLuggageKg"
		Me.txtLuggageKg.Size = New System.Drawing.Size(170, 57)
		Me.txtLuggageKg.TabIndex = 1
		Me.txtLuggageKg.Tag = ""
		'
		'BookFlight1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(1264, 681)
		Me.Controls.Add(Me.lblLuggage)
		Me.Controls.Add(Me.txtLuggageKg)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtPeople)
		Me.Controls.Add(Me.btnPayerInfo)
		Me.Controls.Add(Me.lblInfoStatus)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.btnNext)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.btnBack)
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblId As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents lblArrival As Label
	Friend WithEvents lblDestination As Label
	Friend WithEvents lblDepartureTime As Label
	Friend WithEvents lblSource As Label
	Friend WithEvents lblDate As Label
	Friend WithEvents btnNext As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents lblInfoStatus As Label
	Friend WithEvents btnPayerInfo As Button
	Friend WithEvents Label6 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents txtPeople As TextBox
	Friend WithEvents lblLuggage As Label
	Friend WithEvents txtLuggageKg As TextBox
End Class
