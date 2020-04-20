<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketItem
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
		Me.lblTicketId = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.lblSeatLocation = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lblSeatColumn = New System.Windows.Forms.Label()
		Me.lblNameTitle = New System.Windows.Forms.Label()
		Me.lblName = New System.Windows.Forms.Label()
		Me.lblSeatRow = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.Panel2.Controls.Add(Me.lblTicketId)
		Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Panel2.Location = New System.Drawing.Point(0, 0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(200, 100)
		Me.Panel2.TabIndex = 46
		'
		'lblTicketId
		'
		Me.lblTicketId.Font = New System.Drawing.Font("OCR A Extended", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTicketId.ForeColor = System.Drawing.Color.White
		Me.lblTicketId.Location = New System.Drawing.Point(0, 23)
		Me.lblTicketId.Name = "lblTicketId"
		Me.lblTicketId.Size = New System.Drawing.Size(200, 54)
		Me.lblTicketId.TabIndex = 41
		Me.lblTicketId.Text = "00144"
		Me.lblTicketId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.White
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.lblSeatLocation)
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.lblSeatColumn)
		Me.Panel1.Controls.Add(Me.lblNameTitle)
		Me.Panel1.Controls.Add(Me.lblName)
		Me.Panel1.Controls.Add(Me.lblSeatRow)
		Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Panel1.Location = New System.Drawing.Point(60, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1000, 100)
		Me.Panel1.TabIndex = 45
		'
		'lblSeatLocation
		'
		Me.lblSeatLocation.AutoSize = True
		Me.lblSeatLocation.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSeatLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.lblSeatLocation.Location = New System.Drawing.Point(812, 62)
		Me.lblSeatLocation.Name = "lblSeatLocation"
		Me.lblSeatLocation.Size = New System.Drawing.Size(94, 36)
		Me.lblSeatLocation.TabIndex = 55
		Me.lblSeatLocation.Text = "column"
		Me.lblSeatLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(732, 62)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(55, 36)
		Me.Label3.TabIndex = 54
		Me.Label3.Text = "row"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblSeatColumn
		'
		Me.lblSeatColumn.AutoSize = True
		Me.lblSeatColumn.Font = New System.Drawing.Font("Poppins", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSeatColumn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.lblSeatColumn.Location = New System.Drawing.Point(834, 7)
		Me.lblSeatColumn.Name = "lblSeatColumn"
		Me.lblSeatColumn.Size = New System.Drawing.Size(61, 82)
		Me.lblSeatColumn.TabIndex = 53
		Me.lblSeatColumn.Text = "F"
		Me.lblSeatColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblNameTitle
		'
		Me.lblNameTitle.AutoSize = True
		Me.lblNameTitle.Font = New System.Drawing.Font("Poppins", 20.0!, System.Drawing.FontStyle.Bold)
		Me.lblNameTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.lblNameTitle.Location = New System.Drawing.Point(158, 29)
		Me.lblNameTitle.Name = "lblNameTitle"
		Me.lblNameTitle.Size = New System.Drawing.Size(104, 48)
		Me.lblNameTitle.TabIndex = 45
		Me.lblNameTitle.Text = "Name"
		Me.lblNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Font = New System.Drawing.Font("Poppins", 22.0!, System.Drawing.FontStyle.Bold)
		Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.lblName.Location = New System.Drawing.Point(268, 26)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(202, 53)
		Me.lblName.TabIndex = 44
		Me.lblName.Text = "Johann Lee "
		Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblSeatRow
		'
		Me.lblSeatRow.AutoSize = True
		Me.lblSeatRow.Font = New System.Drawing.Font("Poppins", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSeatRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.lblSeatRow.Location = New System.Drawing.Point(717, 7)
		Me.lblSeatRow.Name = "lblSeatRow"
		Me.lblSeatRow.Size = New System.Drawing.Size(92, 82)
		Me.lblSeatRow.TabIndex = 42
		Me.lblSeatRow.Text = "25"
		Me.lblSeatRow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Poppins", 20.0!, System.Drawing.FontStyle.Bold)
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(629, 29)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(82, 48)
		Me.Label1.TabIndex = 56
		Me.Label1.Text = "Seat"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TicketItem
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "TicketItem"
		Me.Size = New System.Drawing.Size(1063, 103)
		Me.Panel2.ResumeLayout(False)
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel2 As Panel
	Friend WithEvents lblTicketId As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents lblNameTitle As Label
	Friend WithEvents lblName As Label
	Friend WithEvents lblSeatRow As Label
	Friend WithEvents lblSeatLocation As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents lblSeatColumn As Label
	Friend WithEvents Label1 As Label
End Class
