<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentTrip
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radLevel4 = New System.Windows.Forms.RadioButton()
        Me.radLevel3 = New System.Windows.Forms.RadioButton()
        Me.radLevel2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkBag = New System.Windows.Forms.CheckBox()
        Me.chkCap = New System.Windows.Forms.CheckBox()
        Me.chkTshirt = New System.Windows.Forms.CheckBox()
        Me.btnTotalDue = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(710, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Trip"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name:"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(507, 231)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(78, 20)
        Me.label.TabIndex = 3
        Me.label.Text = "Surname:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(361, 233)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radLevel4)
        Me.GroupBox1.Controls.Add(Me.radLevel3)
        Me.GroupBox1.Controls.Add(Me.radLevel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 277)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 105)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NCV Level"
        '
        'radLevel4
        '
        Me.radLevel4.AutoSize = True
        Me.radLevel4.Location = New System.Drawing.Point(24, 66)
        Me.radLevel4.Name = "radLevel4"
        Me.radLevel4.Size = New System.Drawing.Size(77, 24)
        Me.radLevel4.TabIndex = 2
        Me.radLevel4.TabStop = True
        Me.radLevel4.Text = "Level 4"
        Me.radLevel4.UseVisualStyleBackColor = True
        '
        'radLevel3
        '
        Me.radLevel3.AutoSize = True
        Me.radLevel3.Location = New System.Drawing.Point(24, 42)
        Me.radLevel3.Name = "radLevel3"
        Me.radLevel3.Size = New System.Drawing.Size(77, 24)
        Me.radLevel3.TabIndex = 1
        Me.radLevel3.TabStop = True
        Me.radLevel3.Text = "Level 3"
        Me.radLevel3.UseVisualStyleBackColor = True
        '
        'radLevel2
        '
        Me.radLevel2.AutoSize = True
        Me.radLevel2.Location = New System.Drawing.Point(24, 19)
        Me.radLevel2.Name = "radLevel2"
        Me.radLevel2.Size = New System.Drawing.Size(77, 24)
        Me.radLevel2.TabIndex = 0
        Me.radLevel2.TabStop = True
        Me.radLevel2.Text = "Level 2"
        Me.radLevel2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkBag)
        Me.GroupBox2.Controls.Add(Me.chkCap)
        Me.GroupBox2.Controls.Add(Me.chkTshirt)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(269, 277)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 105)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Optional"
        '
        'chkBag
        '
        Me.chkBag.AutoSize = True
        Me.chkBag.Location = New System.Drawing.Point(39, 66)
        Me.chkBag.Name = "chkBag"
        Me.chkBag.Size = New System.Drawing.Size(126, 24)
        Me.chkBag.TabIndex = 2
        Me.chkBag.Text = "Bag - R 90.00"
        Me.chkBag.UseVisualStyleBackColor = True
        '
        'chkCap
        '
        Me.chkCap.AutoSize = True
        Me.chkCap.Location = New System.Drawing.Point(39, 43)
        Me.chkCap.Name = "chkCap"
        Me.chkCap.Size = New System.Drawing.Size(122, 24)
        Me.chkCap.TabIndex = 1
        Me.chkCap.Text = "Cap - R45.00"
        Me.chkCap.UseVisualStyleBackColor = True
        '
        'chkTshirt
        '
        Me.chkTshirt.AutoSize = True
        Me.chkTshirt.Location = New System.Drawing.Point(39, 20)
        Me.chkTshirt.Name = "chkTshirt"
        Me.chkTshirt.Size = New System.Drawing.Size(140, 24)
        Me.chkTshirt.TabIndex = 0
        Me.chkTshirt.Text = "T-Shirt - R70.00"
        Me.chkTshirt.UseVisualStyleBackColor = True
        '
        'btnTotalDue
        '
        Me.btnTotalDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalDue.Location = New System.Drawing.Point(564, 314)
        Me.btnTotalDue.Name = "btnTotalDue"
        Me.btnTotalDue.Size = New System.Drawing.Size(104, 29)
        Me.btnTotalDue.TabIndex = 8
        Me.btnTotalDue.Text = "T&otal Due"
        Me.btnTotalDue.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(616, 349)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 33)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(535, 349)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 30)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(673, 69)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ATTENTION ALL STUNDENTS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Join us for a fun WEEKEND at Sun City"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblResults
        '
        Me.lblResults.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(27, 396)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(673, 115)
        Me.lblResults.TabIndex = 11
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(591, 231)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(100, 20)
        Me.txtSurname.TabIndex = 12
        '
        'frmStudentTrip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 520)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTotalDue)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStudentTrip"
        Me.Text = "Student Trip"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radLevel4 As System.Windows.Forms.RadioButton
    Friend WithEvents radLevel3 As System.Windows.Forms.RadioButton
    Friend WithEvents radLevel2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkBag As System.Windows.Forms.CheckBox
    Friend WithEvents chkCap As System.Windows.Forms.CheckBox
    Friend WithEvents chkTshirt As System.Windows.Forms.CheckBox
    Friend WithEvents btnTotalDue As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox

End Class
