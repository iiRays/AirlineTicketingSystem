<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CancellationReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CancellationReport))
        Me.lblTotalLoss = New System.Windows.Forms.Label()
        Me.grpDateSelection = New System.Windows.Forms.GroupBox()
        Me.cboDay = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.printDialog = New System.Windows.Forms.PrintDialog()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.lstLoss = New System.Windows.Forms.ListBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grpDateSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTotalLoss
        '
        Me.lblTotalLoss.AutoSize = True
        Me.lblTotalLoss.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalLoss.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTotalLoss.Location = New System.Drawing.Point(1465, 652)
        Me.lblTotalLoss.Name = "lblTotalLoss"
        Me.lblTotalLoss.Size = New System.Drawing.Size(150, 39)
        Me.lblTotalLoss.TabIndex = 37
        Me.lblTotalLoss.Text = "lblTotalLoss"
        Me.lblTotalLoss.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grpDateSelection
        '
        Me.grpDateSelection.Controls.Add(Me.cboDay)
        Me.grpDateSelection.Controls.Add(Me.Label1)
        Me.grpDateSelection.Controls.Add(Me.cboYear)
        Me.grpDateSelection.Controls.Add(Me.cboMonth)
        Me.grpDateSelection.Controls.Add(Me.Label4)
        Me.grpDateSelection.Controls.Add(Me.Label3)
        Me.grpDateSelection.Location = New System.Drawing.Point(625, 41)
        Me.grpDateSelection.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpDateSelection.Name = "grpDateSelection"
        Me.grpDateSelection.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpDateSelection.Size = New System.Drawing.Size(1005, 149)
        Me.grpDateSelection.TabIndex = 36
        Me.grpDateSelection.TabStop = False
        '
        'cboDay
        '
        Me.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDay.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold)
        Me.cboDay.FormattingEnabled = True
        Me.cboDay.Location = New System.Drawing.Point(141, 47)
        Me.cboDay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboDay.Name = "cboDay"
        Me.cboDay.Size = New System.Drawing.Size(167, 52)
        Me.cboDay.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(41, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 44)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Day : "
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold)
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(800, 50)
        Me.cboYear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(164, 52)
        Me.cboYear.TabIndex = 17
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold)
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonth.Location = New System.Drawing.Point(484, 50)
        Me.cboMonth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(164, 52)
        Me.cboMonth.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(351, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 44)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Month : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(691, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 44)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Year : "
        '
        'printDialog
        '
        Me.printDialog.UseEXDialog = True
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(1109, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(519, 32)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Refund (10%)"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(649, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(862, 32)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "No Of Passenger(s) Cancel"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(213, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1130, 32)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Flight No."
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(59, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1194, 32)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "No"
        '
        'dlgPreview
        '
        Me.dlgPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreview.Document = Me.doc
        Me.dlgPreview.Enabled = True
        Me.dlgPreview.Icon = CType(resources.GetObject("dlgPreview.Icon"), System.Drawing.Icon)
        Me.dlgPreview.Name = "PrintPreviewDialog1"
        Me.dlgPreview.Visible = False
        '
        'doc
        '
        '
        'lstLoss
        '
        Me.lstLoss.Font = New System.Drawing.Font("Poppins", 13.0!)
        Me.lstLoss.FormattingEnabled = True
        Me.lstLoss.ItemHeight = 39
        Me.lstLoss.Location = New System.Drawing.Point(64, 226)
        Me.lstLoss.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstLoss.Name = "lstLoss"
        Me.lstLoss.Size = New System.Drawing.Size(1564, 394)
        Me.lstLoss.TabIndex = 31
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Poppins", 25.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(1397, 713)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(233, 92)
        Me.btnPrint.TabIndex = 30
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblCount.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCount.Location = New System.Drawing.Point(71, 697)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(114, 39)
        Me.lblCount.TabIndex = 29
        Me.lblCount.Text = "lblCount"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Poppins", 25.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(1137, 713)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(233, 92)
        Me.btnBack.TabIndex = 46
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(51, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(459, 74)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Cancellation Report"
        '
        'CancellationReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1685, 838)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTotalLoss)
        Me.Controls.Add(Me.grpDateSelection)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstLoss)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblCount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "CancellationReport"
        Me.Text = "CancellationReport"
        Me.grpDateSelection.ResumeLayout(False)
        Me.grpDateSelection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalLoss As Label
    Friend WithEvents grpDateSelection As GroupBox
    Friend WithEvents cboDay As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents printDialog As PrintDialog
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dlgPreview As PrintPreviewDialog
    Friend WithEvents doc As Printing.PrintDocument
    Friend WithEvents lstLoss As ListBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblCount As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label10 As Label
End Class
