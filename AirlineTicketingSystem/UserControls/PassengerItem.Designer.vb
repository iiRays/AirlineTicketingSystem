﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PassengerItem
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
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.lblName = New System.Windows.Forms.Label()
		Me.cboSeat = New System.Windows.Forms.ComboBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.White
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
		Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(-248, 38)
		Me.Label3.Name = "Label3"
		Me.Label3.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label3.Size = New System.Drawing.Size(150, 75)
		Me.Label3.TabIndex = 58
		Me.Label3.Text = "name 1"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtName
		'
		Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtName.Location = New System.Drawing.Point(195, 26)
		Me.txtName.MaxLength = 30
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(364, 28)
		Me.txtName.TabIndex = 60
		Me.txtName.Tag = ""
		'
		'lblName
		'
		Me.lblName.BackColor = System.Drawing.Color.White
		Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
		Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.lblName.Location = New System.Drawing.Point(6, 3)
		Me.lblName.Name = "lblName"
		Me.lblName.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.lblName.Size = New System.Drawing.Size(183, 75)
		Me.lblName.TabIndex = 59
		Me.lblName.Text = "passenger 1"
		Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'cboSeat
		'
		Me.cboSeat.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.cboSeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboSeat.Font = New System.Drawing.Font("Poppins", 18.0!)
		Me.cboSeat.FormattingEnabled = True
		Me.cboSeat.Location = New System.Drawing.Point(652, 19)
		Me.cboSeat.Name = "cboSeat"
		Me.cboSeat.Size = New System.Drawing.Size(137, 50)
		Me.cboSeat.Sorted = True
		Me.cboSeat.TabIndex = 61
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.White
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(551, 3)
		Me.Label1.Name = "Label1"
		Me.Label1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label1.Size = New System.Drawing.Size(95, 75)
		Me.Label1.TabIndex = 62
		Me.Label1.Text = "seat"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'PassengerItem
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.cboSeat)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.lblName)
		Me.Controls.Add(Me.Label3)
		Me.Name = "PassengerItem"
		Me.Size = New System.Drawing.Size(807, 84)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
	Friend WithEvents cboSeat As ComboBox
	Friend WithEvents Label1 As Label
End Class
