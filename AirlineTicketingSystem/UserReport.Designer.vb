﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserReport))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.grpDateSelection = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.printDialog = New System.Windows.Forms.PrintDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.lstStatistic = New System.Windows.Forms.ListBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.grpDateSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(232, 454)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 39
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'grpDateSelection
        '
        Me.grpDateSelection.Controls.Add(Me.txtSearch)
        Me.grpDateSelection.Controls.Add(Me.Label3)
        Me.grpDateSelection.Controls.Add(Me.cboCategory)
        Me.grpDateSelection.Controls.Add(Me.Label1)
        Me.grpDateSelection.Location = New System.Drawing.Point(31, 12)
        Me.grpDateSelection.Name = "grpDateSelection"
        Me.grpDateSelection.Size = New System.Drawing.Size(385, 91)
        Me.grpDateSelection.TabIndex = 37
        Me.grpDateSelection.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(124, 54)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(218, 22)
        Me.txtSearch.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(16, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Search Name :"
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"All", "Staffs", "Customers"})
        Me.cboCategory.Location = New System.Drawing.Point(124, 21)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(98, 24)
        Me.cboCategory.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(44, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Category :"
        '
        'printDialog
        '
        Me.printDialog.UseEXDialog = True
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(269, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 20)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Contact No."
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(88, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Name"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(31, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "No"
        '
        'doc
        '
        '
        'lstStatistic
        '
        Me.lstStatistic.FormattingEnabled = True
        Me.lstStatistic.ItemHeight = 16
        Me.lstStatistic.Location = New System.Drawing.Point(31, 144)
        Me.lstStatistic.Name = "lstStatistic"
        Me.lstStatistic.Size = New System.Drawing.Size(385, 276)
        Me.lstStatistic.TabIndex = 32
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(335, 454)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 31
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCount.Location = New System.Drawing.Point(28, 423)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(120, 16)
        Me.lblCount.TabIndex = 30
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
        'StatisticReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(449, 488)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.grpDateSelection)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstStatistic)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblCount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "StatisticReport"
        Me.Text = "StatisticReport"
        Me.grpDateSelection.ResumeLayout(False)
        Me.grpDateSelection.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents grpDateSelection As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents printDialog As PrintDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents doc As Printing.PrintDocument
    Friend WithEvents lstStatistic As ListBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblCount As Label
    Friend WithEvents dlgPreview As PrintPreviewDialog
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label3 As Label
End Class
