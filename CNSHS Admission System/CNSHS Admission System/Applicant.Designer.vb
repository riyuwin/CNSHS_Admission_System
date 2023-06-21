<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Applicant
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Applicant))
        Me.applicant_dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.address_text = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.school_name_text = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.contact_number_text = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.extname_text = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lname_text = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mname_text = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fname_text = New System.Windows.Forms.TextBox()
        Me.lrn_cbdo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.update_button = New System.Windows.Forms.Button()
        Me.insert_btn = New System.Windows.Forms.Button()
        Me.delete_button = New System.Windows.Forms.Button()
        CType(Me.applicant_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'applicant_dgv
        '
        Me.applicant_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.applicant_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.applicant_dgv.Location = New System.Drawing.Point(487, 90)
        Me.applicant_dgv.Name = "applicant_dgv"
        Me.applicant_dgv.ReadOnly = True
        Me.applicant_dgv.Size = New System.Drawing.Size(421, 207)
        Me.applicant_dgv.TabIndex = 148
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(-13, -13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(973, 80)
        Me.Panel1.TabIndex = 201
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(107, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 21)
        Me.Label4.TabIndex = 169
        Me.Label4.Text = "Admission System"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(105, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(341, 23)
        Me.Label5.TabIndex = 168
        Me.Label5.Text = "Camarines Norte Senior High School"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 167
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(832, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 24)
        Me.Label6.TabIndex = 156
        Me.Label6.Text = "APPLICANT"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Location = New System.Drawing.Point(-8, 503)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(968, 25)
        Me.Panel2.TabIndex = 202
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.address_text)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.school_name_text)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.contact_number_text)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.extname_text)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.lname_text)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.mname_text)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.fname_text)
        Me.GroupBox4.Controls.Add(Me.lrn_cbdo)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.Location = New System.Drawing.Point(86, 83)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(308, 377)
        Me.GroupBox4.TabIndex = 203
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Applicant Details"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label14.Location = New System.Drawing.Point(14, 323)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 16)
        Me.Label14.TabIndex = 201
        Me.Label14.Text = "Address:"
        '
        'address_text
        '
        Me.address_text.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.address_text.Location = New System.Drawing.Point(121, 320)
        Me.address_text.MaximumSize = New System.Drawing.Size(500, 30)
        Me.address_text.MinimumSize = New System.Drawing.Size(124, 30)
        Me.address_text.Name = "address_text"
        Me.address_text.Size = New System.Drawing.Size(163, 21)
        Me.address_text.TabIndex = 202
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(14, 281)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 16)
        Me.Label13.TabIndex = 199
        Me.Label13.Text = "School Name:"
        '
        'school_name_text
        '
        Me.school_name_text.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.school_name_text.Location = New System.Drawing.Point(121, 278)
        Me.school_name_text.Name = "school_name_text"
        Me.school_name_text.Size = New System.Drawing.Size(163, 21)
        Me.school_name_text.TabIndex = 200
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(14, 243)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 16)
        Me.Label12.TabIndex = 197
        Me.Label12.Text = "Contact Number:"
        '
        'contact_number_text
        '
        Me.contact_number_text.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.contact_number_text.Location = New System.Drawing.Point(121, 240)
        Me.contact_number_text.Name = "contact_number_text"
        Me.contact_number_text.Size = New System.Drawing.Size(163, 21)
        Me.contact_number_text.TabIndex = 198
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(14, 205)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 16)
        Me.Label11.TabIndex = 195
        Me.Label11.Text = "Ext. Name:"
        '
        'extname_text
        '
        Me.extname_text.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.extname_text.Location = New System.Drawing.Point(121, 202)
        Me.extname_text.Name = "extname_text"
        Me.extname_text.Size = New System.Drawing.Size(163, 21)
        Me.extname_text.TabIndex = 196
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(14, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 193
        Me.Label10.Text = "Lastt Name:"
        '
        'lname_text
        '
        Me.lname_text.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.lname_text.Location = New System.Drawing.Point(121, 160)
        Me.lname_text.Name = "lname_text"
        Me.lname_text.Size = New System.Drawing.Size(163, 21)
        Me.lname_text.TabIndex = 194
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(14, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 16)
        Me.Label9.TabIndex = 191
        Me.Label9.Text = "Middle Name:"
        '
        'mname_text
        '
        Me.mname_text.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.mname_text.Location = New System.Drawing.Point(121, 121)
        Me.mname_text.Name = "mname_text"
        Me.mname_text.Size = New System.Drawing.Size(163, 21)
        Me.mname_text.TabIndex = 192
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(14, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 16)
        Me.Label8.TabIndex = 176
        Me.Label8.Text = "First Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 190
        Me.Label1.Text = "LRN:"
        '
        'fname_text
        '
        Me.fname_text.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.fname_text.Location = New System.Drawing.Point(121, 84)
        Me.fname_text.Name = "fname_text"
        Me.fname_text.Size = New System.Drawing.Size(163, 21)
        Me.fname_text.TabIndex = 177
        '
        'lrn_cbdo
        '
        Me.lrn_cbdo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lrn_cbdo.FormattingEnabled = True
        Me.lrn_cbdo.Location = New System.Drawing.Point(121, 42)
        Me.lrn_cbdo.Name = "lrn_cbdo"
        Me.lrn_cbdo.Size = New System.Drawing.Size(163, 24)
        Me.lrn_cbdo.TabIndex = 189
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.exit_btn)
        Me.GroupBox2.Controls.Add(Me.update_button)
        Me.GroupBox2.Controls.Add(Me.insert_btn)
        Me.GroupBox2.Controls.Add(Me.delete_button)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(519, 313)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 165)
        Me.GroupBox2.TabIndex = 206
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Action"
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.Color.Transparent
        Me.exit_btn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_btn.ForeColor = System.Drawing.Color.ForestGreen
        Me.exit_btn.Location = New System.Drawing.Point(192, 98)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(118, 26)
        Me.exit_btn.TabIndex = 165
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.UseVisualStyleBackColor = False
        '
        'update_button
        '
        Me.update_button.BackColor = System.Drawing.Color.Transparent
        Me.update_button.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_button.ForeColor = System.Drawing.Color.ForestGreen
        Me.update_button.Location = New System.Drawing.Point(192, 51)
        Me.update_button.Name = "update_button"
        Me.update_button.Size = New System.Drawing.Size(118, 26)
        Me.update_button.TabIndex = 164
        Me.update_button.Text = "Update"
        Me.update_button.UseVisualStyleBackColor = False
        '
        'insert_btn
        '
        Me.insert_btn.BackColor = System.Drawing.Color.Transparent
        Me.insert_btn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert_btn.ForeColor = System.Drawing.Color.ForestGreen
        Me.insert_btn.Location = New System.Drawing.Point(53, 51)
        Me.insert_btn.Name = "insert_btn"
        Me.insert_btn.Size = New System.Drawing.Size(118, 26)
        Me.insert_btn.TabIndex = 163
        Me.insert_btn.Text = "Insert"
        Me.insert_btn.UseVisualStyleBackColor = False
        '
        'delete_button
        '
        Me.delete_button.BackColor = System.Drawing.Color.Transparent
        Me.delete_button.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_button.ForeColor = System.Drawing.Color.ForestGreen
        Me.delete_button.Location = New System.Drawing.Point(53, 98)
        Me.delete_button.Name = "delete_button"
        Me.delete_button.Size = New System.Drawing.Size(118, 26)
        Me.delete_button.TabIndex = 160
        Me.delete_button.Text = "Delete"
        Me.delete_button.UseVisualStyleBackColor = False
        '
        'Applicant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 515)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.applicant_dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Applicant"
        Me.Text = "Applicant"
        CType(Me.applicant_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents applicant_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents address_text As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents school_name_text As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents contact_number_text As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents extname_text As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lname_text As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents mname_text As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fname_text As System.Windows.Forms.TextBox
    Friend WithEvents lrn_cbdo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents exit_btn As System.Windows.Forms.Button
    Friend WithEvents update_button As System.Windows.Forms.Button
    Friend WithEvents insert_btn As System.Windows.Forms.Button
    Friend WithEvents delete_button As System.Windows.Forms.Button

End Class
