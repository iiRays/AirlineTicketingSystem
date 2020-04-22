<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminUsersView
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
        Me.btnAll = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearchFor = New System.Windows.Forms.TextBox()
        Me.cbSearchBy = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnAll.FlatAppearance.BorderSize = 0
        Me.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAll.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnAll.ForeColor = System.Drawing.Color.White
        Me.btnAll.Location = New System.Drawing.Point(785, 262)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(150, 75)
        Me.btnAll.TabIndex = 74
        Me.btnAll.Text = "view all"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(511, 415)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(150, 75)
        Me.btnSearch.TabIndex = 73
        Me.btnSearch.Text = "search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(136, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(175, 50)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "search for"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSearchFor
        '
        Me.txtSearchFor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchFor.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchFor.Location = New System.Drawing.Point(311, 340)
        Me.txtSearchFor.Multiline = True
        Me.txtSearchFor.Name = "txtSearchFor"
        Me.txtSearchFor.Size = New System.Drawing.Size(350, 50)
        Me.txtSearchFor.TabIndex = 71
        Me.txtSearchFor.Tag = ""
        '
        'cbSearchBy
        '
        Me.cbSearchBy.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSearchBy.FormattingEnabled = True
        Me.cbSearchBy.Items.AddRange(New Object() {"UserID", "Name", "Gender", "Email", "IsRegistered", "DateOfBirth", "PhoneNo", "CreditCardNo", "Country", "City", "IsStaff"})
        Me.cbSearchBy.Location = New System.Drawing.Point(311, 263)
        Me.cbSearchBy.Name = "cbSearchBy"
        Me.cbSearchBy.Size = New System.Drawing.Size(350, 50)
        Me.cbSearchBy.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(136, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(175, 50)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "search by"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(124, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 60)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "search"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(775, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 60)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "or"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Poppins", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(22, 22)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 75)
        Me.btnBack.TabIndex = 66
        Me.btnBack.Text = "back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Poppins", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(499, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(247, 70)
        Me.lblTitle.TabIndex = 65
        Me.lblTitle.Text = "view users"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdminUsersView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSearchFor)
        Me.Controls.Add(Me.cbSearchBy)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "AdminUsersView"
        Me.Text = "AdminUsersView"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAll As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSearchFor As TextBox
    Friend WithEvents cbSearchBy As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblTitle As Label
End Class
