﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlightDetails
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FlightDetails))
		Me.btnBack = New System.Windows.Forms.Button()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.lblPrice = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.lblArrivalTime = New System.Windows.Forms.Label()
		Me.lblDestination = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblId = New System.Windows.Forms.Label()
		Me.btnGo = New System.Windows.Forms.Button()
		Me.lblSeatsTitle = New System.Windows.Forms.Label()
		Me.lblSeats = New System.Windows.Forms.Label()
		Me.lblDepartureTime = New System.Windows.Forms.Label()
		Me.lblSource = New System.Windows.Forms.Label()
		Me.lblDuration = New System.Windows.Forms.Label()
		Me.lblDate = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnBack
		'
		Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.btnBack.FlatAppearance.BorderSize = 0
		Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBack.Font = New System.Drawing.Font("Poppins", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnBack.ForeColor = System.Drawing.Color.White
		Me.btnBack.Location = New System.Drawing.Point(44, 39)
		Me.btnBack.Name = "btnBack"
		Me.btnBack.Size = New System.Drawing.Size(175, 75)
		Me.btnBack.TabIndex = 1
		Me.btnBack.Text = "back"
		Me.btnBack.UseVisualStyleBackColor = False
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.White
		Me.Panel1.Controls.Add(Me.Label6)
		Me.Panel1.Controls.Add(Me.lblPrice)
		Me.Panel1.Controls.Add(Me.Label5)
		Me.Panel1.Controls.Add(Me.lblArrivalTime)
		Me.Panel1.Controls.Add(Me.lblDestination)
		Me.Panel1.Controls.Add(Me.Label4)
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.lblId)
		Me.Panel1.Controls.Add(Me.btnGo)
		Me.Panel1.Controls.Add(Me.lblSeatsTitle)
		Me.Panel1.Controls.Add(Me.lblSeats)
		Me.Panel1.Controls.Add(Me.lblDepartureTime)
		Me.Panel1.Controls.Add(Me.lblSource)
		Me.Panel1.Controls.Add(Me.lblDuration)
		Me.Panel1.Controls.Add(Me.lblDate)
		Me.Panel1.Location = New System.Drawing.Point(135, 218)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1000, 375)
		Me.Panel1.TabIndex = 41
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold)
		Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.Label6.Location = New System.Drawing.Point(475, 104)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(66, 36)
		Me.Label6.TabIndex = 58
		Me.Label6.Text = "Price"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblPrice
		'
		Me.lblPrice.AutoSize = True
		Me.lblPrice.Font = New System.Drawing.Font("Poppins", 20.0!, System.Drawing.FontStyle.Bold)
		Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.lblPrice.Location = New System.Drawing.Point(474, 130)
		Me.lblPrice.Name = "lblPrice"
		Me.lblPrice.Size = New System.Drawing.Size(108, 48)
		Me.lblPrice.TabIndex = 57
		Me.lblPrice.Text = "RM 123"
		Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
		Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label5.Location = New System.Drawing.Point(447, 199)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(148, 42)
		Me.Label5.TabIndex = 56
		Me.Label5.Text = "Arriving at"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblArrivalTime
		'
		Me.lblArrivalTime.AutoSize = True
		Me.lblArrivalTime.Font = New System.Drawing.Font("Poppins", 25.0!, System.Drawing.FontStyle.Bold)
		Me.lblArrivalTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.lblArrivalTime.Location = New System.Drawing.Point(444, 277)
		Me.lblArrivalTime.Name = "lblArrivalTime"
		Me.lblArrivalTime.Size = New System.Drawing.Size(106, 60)
		Me.lblArrivalTime.TabIndex = 55
		Me.lblArrivalTime.Text = "17:30"
		Me.lblArrivalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblDestination
		'
		Me.lblDestination.AutoSize = True
		Me.lblDestination.Font = New System.Drawing.Font("Poppins", 32.0!, System.Drawing.FontStyle.Bold)
		Me.lblDestination.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.lblDestination.Location = New System.Drawing.Point(441, 225)
		Me.lblDestination.Name = "lblDestination"
		Me.lblDestination.Size = New System.Drawing.Size(345, 76)
		Me.lblDestination.TabIndex = 54
		Me.lblDestination.Text = "Kota Kinabalu"
		Me.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
		Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label4.Location = New System.Drawing.Point(51, 199)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(206, 42)
		Me.Label4.TabIndex = 53
		Me.Label4.Text = "Departing from"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold)
		Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(245, 104)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(107, 36)
		Me.Label3.TabIndex = 52
		Me.Label3.Text = "Duration"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Poppins", 20.0!, System.Drawing.FontStyle.Bold)
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(243, 11)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(86, 48)
		Me.Label1.TabIndex = 51
		Me.Label1.Text = "Date"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblId
		'
		Me.lblId.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.lblId.Font = New System.Drawing.Font("Poppins", 33.0!, System.Drawing.FontStyle.Bold)
		Me.lblId.ForeColor = System.Drawing.Color.White
		Me.lblId.Location = New System.Drawing.Point(0, 0)
		Me.lblId.Name = "lblId"
		Me.lblId.Size = New System.Drawing.Size(225, 150)
		Me.lblId.TabIndex = 50
		Me.lblId.Text = "001"
		Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnGo
		'
		Me.btnGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
		Me.btnGo.FlatAppearance.BorderSize = 0
		Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGo.Font = New System.Drawing.Font("Poppins", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.btnGo.ForeColor = System.Drawing.Color.White
		Me.btnGo.Location = New System.Drawing.Point(825, 300)
		Me.btnGo.Name = "btnGo"
		Me.btnGo.Size = New System.Drawing.Size(175, 75)
		Me.btnGo.TabIndex = 41
		Me.btnGo.Text = "book"
		Me.btnGo.UseVisualStyleBackColor = False
		'
		'lblSeatsTitle
		'
		Me.lblSeatsTitle.AutoSize = True
		Me.lblSeatsTitle.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
		Me.lblSeatsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.lblSeatsTitle.Location = New System.Drawing.Point(766, 97)
		Me.lblSeatsTitle.Name = "lblSeatsTitle"
		Me.lblSeatsTitle.Size = New System.Drawing.Size(182, 42)
		Me.lblSeatsTitle.TabIndex = 49
		Me.lblSeatsTitle.Text = "seats booked"
		Me.lblSeatsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblSeats
		'
		Me.lblSeats.AutoSize = True
		Me.lblSeats.Font = New System.Drawing.Font("Poppins", 35.0!, System.Drawing.FontStyle.Bold)
		Me.lblSeats.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.lblSeats.Location = New System.Drawing.Point(738, 36)
		Me.lblSeats.Name = "lblSeats"
		Me.lblSeats.Size = New System.Drawing.Size(225, 82)
		Me.lblSeats.TabIndex = 48
		Me.lblSeats.Text = "150 / 150"
		Me.lblSeats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblDepartureTime
		'
		Me.lblDepartureTime.AutoSize = True
		Me.lblDepartureTime.Font = New System.Drawing.Font("Poppins", 25.0!, System.Drawing.FontStyle.Bold)
		Me.lblDepartureTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.lblDepartureTime.Location = New System.Drawing.Point(48, 277)
		Me.lblDepartureTime.Name = "lblDepartureTime"
		Me.lblDepartureTime.Size = New System.Drawing.Size(112, 60)
		Me.lblDepartureTime.TabIndex = 45
		Me.lblDepartureTime.Text = "15:00"
		Me.lblDepartureTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblSource
		'
		Me.lblSource.AutoSize = True
		Me.lblSource.Font = New System.Drawing.Font("Poppins", 32.0!, System.Drawing.FontStyle.Bold)
		Me.lblSource.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.lblSource.Location = New System.Drawing.Point(45, 225)
		Me.lblSource.Name = "lblSource"
		Me.lblSource.Size = New System.Drawing.Size(343, 76)
		Me.lblSource.TabIndex = 44
		Me.lblSource.Text = "Kuala Lumpur"
		Me.lblSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblDuration
		'
		Me.lblDuration.AutoSize = True
		Me.lblDuration.Font = New System.Drawing.Font("Poppins", 20.0!, System.Drawing.FontStyle.Bold)
		Me.lblDuration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.lblDuration.Location = New System.Drawing.Point(244, 130)
		Me.lblDuration.Name = "lblDuration"
		Me.lblDuration.Size = New System.Drawing.Size(201, 48)
		Me.lblDuration.TabIndex = 43
		Me.lblDuration.Text = "2h 30 approx."
		Me.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblDate
		'
		Me.lblDate.AutoSize = True
		Me.lblDate.BackColor = System.Drawing.Color.Transparent
		Me.lblDate.Font = New System.Drawing.Font("Poppins", 25.0!, System.Drawing.FontStyle.Bold)
		Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.lblDate.Location = New System.Drawing.Point(241, 44)
		Me.lblDate.Name = "lblDate"
		Me.lblDate.Size = New System.Drawing.Size(413, 60)
		Me.lblDate.TabIndex = 42
		Me.lblDate.Text = "Monday, 9 March 2020"
		Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'FlightDetails
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(1264, 681)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.btnBack)
		Me.Name = "FlightDetails"
		Me.Text = "FlightDetails"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents btnBack As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblId As Label
    Friend WithEvents lblSeatsTitle As Label
    Friend WithEvents lblSeats As Label
    Friend WithEvents lblDepartureTime As Label
    Friend WithEvents lblSource As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblArrivalTime As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGo As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPrice As Label
End Class
