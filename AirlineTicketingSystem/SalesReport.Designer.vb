<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesReport))
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lstSales = New System.Windows.Forms.ListBox()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.printDialog = New System.Windows.Forms.PrintDialog()
        Me.grpDateSelection = New System.Windows.Forms.GroupBox()
        Me.cboDay = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpDateSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(901, 21)
        Me.cboYear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(185, 37)
        Me.cboYear.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(792, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 29)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Year : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(423, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 29)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Month : "
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonth.Location = New System.Drawing.Point(556, 21)
        Me.cboMonth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(185, 37)
        Me.cboMonth.TabIndex = 14
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCount.Location = New System.Drawing.Point(53, 677)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(100, 26)
        Me.lblCount.TabIndex = 19
        Me.lblCount.Text = "lblCount"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(1392, 711)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(233, 92)
        Me.btnPrint.TabIndex = 21
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'lstSales
        '
        Me.lstSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSales.FormattingEnabled = True
        Me.lstSales.ItemHeight = 26
        Me.lstSales.Location = New System.Drawing.Point(61, 192)
        Me.lstSales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstSales.Name = "lstSales"
        Me.lstSales.Size = New System.Drawing.Size(1563, 446)
        Me.lstSales.TabIndex = 22
        '
        'doc
        '
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
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(59, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1245, 39)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "No"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(183, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1210, 39)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Flight No."
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(504, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1011, 39)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "No Of Passenger(s)"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(939, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(686, 39)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Total Sales"
        '
        'printDialog
        '
        Me.printDialog.UseEXDialog = True
        '
        'grpDateSelection
        '
        Me.grpDateSelection.Controls.Add(Me.cboDay)
        Me.grpDateSelection.Controls.Add(Me.Label1)
        Me.grpDateSelection.Controls.Add(Me.cboYear)
        Me.grpDateSelection.Controls.Add(Me.cboMonth)
        Me.grpDateSelection.Controls.Add(Me.Label4)
        Me.grpDateSelection.Controls.Add(Me.Label3)
        Me.grpDateSelection.Location = New System.Drawing.Point(452, 41)
        Me.grpDateSelection.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpDateSelection.Name = "grpDateSelection"
        Me.grpDateSelection.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpDateSelection.Size = New System.Drawing.Size(1173, 107)
        Me.grpDateSelection.TabIndex = 27
        Me.grpDateSelection.TabStop = False
        '
        'cboDay
        '
        Me.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDay.FormattingEnabled = True
        Me.cboDay.Location = New System.Drawing.Point(203, 21)
        Me.cboDay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboDay.Name = "cboDay"
        Me.cboDay.Size = New System.Drawing.Size(172, 37)
        Me.cboDay.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(103, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 29)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Day : "
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTotalSales.Location = New System.Drawing.Point(1297, 640)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(172, 29)
        Me.lblTotalSales.TabIndex = 28
        Me.lblTotalSales.Text = "lblTotalSales"
        Me.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(1139, 711)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(233, 92)
        Me.btnBack.TabIndex = 29
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(43, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(326, 58)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Sales Report"
        '
        'SalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1685, 838)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Controls.Add(Me.grpDateSelection)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstSales)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblCount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "SalesReport"
        Me.Text = "SalesReport"
        Me.grpDateSelection.ResumeLayout(False)
        Me.grpDateSelection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents lblCount As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents lstSales As ListBox
    Friend WithEvents doc As Printing.PrintDocument
    Friend WithEvents dlgPreview As PrintPreviewDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents printDialog As PrintDialog
    Friend WithEvents grpDateSelection As GroupBox
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents cboDay As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label8 As Label
End Class
