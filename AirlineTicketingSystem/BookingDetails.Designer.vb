﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingDetails
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblArrivalTime = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBookingId = New System.Windows.Forms.Label()
        Me.btnViewTickets = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPassengers = New System.Windows.Forms.Label()
        Me.lblDepartureTime = New System.Windows.Forms.Label()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblFlightId = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblBaggageKg = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblBaggageKg)
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblPrice)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblFlightId)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblArrivalTime)
        Me.Panel1.Controls.Add(Me.lblDestination)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblBookingId)
        Me.Panel1.Controls.Add(Me.btnViewTickets)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblPassengers)
        Me.Panel1.Controls.Add(Me.lblDepartureTime)
        Me.Panel1.Controls.Add(Me.lblSource)
        Me.Panel1.Controls.Add(Me.lblDuration)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Location = New System.Drawing.Point(109, 161)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 425)
        Me.Panel1.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(909, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 31)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Price"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblPrice.Location = New System.Drawing.Point(871, 46)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(98, 42)
        Me.lblPrice.TabIndex = 57
        Me.lblPrice.Text = "RM 123"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(436, 221)
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
        Me.lblArrivalTime.Location = New System.Drawing.Point(433, 299)
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
        Me.lblDestination.Location = New System.Drawing.Point(430, 247)
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
        Me.Label4.Location = New System.Drawing.Point(40, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 42)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Departing from"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(825, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 31)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Payment Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(253, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 40)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Date"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBookingId
        '
        Me.lblBookingId.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.lblBookingId.Font = New System.Drawing.Font("OCR A Extended", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookingId.ForeColor = System.Drawing.Color.White
        Me.lblBookingId.Location = New System.Drawing.Point(0, 0)
        Me.lblBookingId.Name = "lblBookingId"
        Me.lblBookingId.Size = New System.Drawing.Size(225, 150)
        Me.lblBookingId.TabIndex = 50
        Me.lblBookingId.Text = "001"
        Me.lblBookingId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnViewTickets
        '
        Me.btnViewTickets.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnViewTickets.FlatAppearance.BorderSize = 0
        Me.btnViewTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewTickets.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnViewTickets.ForeColor = System.Drawing.Color.White
        Me.btnViewTickets.Location = New System.Drawing.Point(775, 350)
        Me.btnViewTickets.Name = "btnViewTickets"
        Me.btnViewTickets.Size = New System.Drawing.Size(225, 75)
        Me.btnViewTickets.TabIndex = 41
        Me.btnViewTickets.Text = "view tickets"
        Me.btnViewTickets.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(867, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 42)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "people"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPassengers
        '
        Me.lblPassengers.AutoSize = True
        Me.lblPassengers.Font = New System.Drawing.Font("Poppins", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassengers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblPassengers.Location = New System.Drawing.Point(909, 228)
        Me.lblPassengers.Name = "lblPassengers"
        Me.lblPassengers.Size = New System.Drawing.Size(76, 95)
        Me.lblPassengers.TabIndex = 48
        Me.lblPassengers.Text = "4"
        Me.lblPassengers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDepartureTime
        '
        Me.lblDepartureTime.AutoSize = True
        Me.lblDepartureTime.Font = New System.Drawing.Font("Poppins", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lblDepartureTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblDepartureTime.Location = New System.Drawing.Point(37, 299)
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
        Me.lblSource.Location = New System.Drawing.Point(34, 247)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(343, 76)
        Me.lblSource.TabIndex = 44
        Me.lblSource.Text = "Kuala Lumpur"
        Me.lblSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblDuration.Location = New System.Drawing.Point(829, 121)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(140, 42)
        Me.lblDuration.TabIndex = 43
        Me.lblDuration.Text = "Jan 1 2020"
        Me.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Poppins", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(380, 81)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(361, 53)
        Me.lblDate.TabIndex = 42
        Me.lblDate.Text = "Monday, 9 March 2020"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(25, 27)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 75)
        Me.btnBack.TabIndex = 43
        Me.btnBack.Text = "back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(453, 32)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(347, 70)
        Me.lblTitle.TabIndex = 42
        Me.lblTitle.Text = "booking details"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Poppins", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(252, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 48)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Flight ID"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFlightId
        '
        Me.lblFlightId.AutoSize = True
        Me.lblFlightId.BackColor = System.Drawing.Color.Transparent
        Me.lblFlightId.Font = New System.Drawing.Font("Poppins", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlightId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblFlightId.Location = New System.Drawing.Point(379, 19)
        Me.lblFlightId.Name = "lblFlightId"
        Me.lblFlightId.Size = New System.Drawing.Size(121, 60)
        Me.lblFlightId.TabIndex = 59
        Me.lblFlightId.Text = "00123"
        Me.lblFlightId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Poppins", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(601, 19)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(125, 50)
        Me.btnEdit.TabIndex = 61
        Me.btnEdit.Text = "view"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(254, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 36)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Status"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Poppins", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(381, 134)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(81, 48)
        Me.lblStatus.TabIndex = 63
        Me.lblStatus.Text = "Paid"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(792, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(177, 31)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Extra Baggage Kg"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBaggageKg
        '
        Me.lblBaggageKg.AutoSize = True
        Me.lblBaggageKg.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaggageKg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblBaggageKg.Location = New System.Drawing.Point(928, 195)
        Me.lblBaggageKg.Name = "lblBaggageKg"
        Me.lblBaggageKg.Size = New System.Drawing.Size(41, 42)
        Me.lblBaggageKg.TabIndex = 64
        Me.lblBaggageKg.Text = "12"
        Me.lblBaggageKg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BookingDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "BookingDetails"
        Me.Text = "BookingDetails"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblArrivalTime As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBookingId As Label
    Friend WithEvents btnViewTickets As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPassengers As Label
    Friend WithEvents lblDepartureTime As Label
    Friend WithEvents lblSource As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblFlightId As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblBaggageKg As Label
End Class