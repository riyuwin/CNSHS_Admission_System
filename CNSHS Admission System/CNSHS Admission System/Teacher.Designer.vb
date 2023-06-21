<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teacher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Teacher))
        Me.teacher_dgv = New System.Windows.Forms.DataGridView()
        Me.tdesignation_text = New System.Windows.Forms.TextBox()
        Me.tdesignation_label = New System.Windows.Forms.Label()
        Me.tlname_text = New System.Windows.Forms.TextBox()
        Me.tlname_label = New System.Windows.Forms.Label()
        Me.teacherid_cbdo = New System.Windows.Forms.ComboBox()
        Me.tmname_text = New System.Windows.Forms.TextBox()
        Me.tmname_label = New System.Windows.Forms.Label()
        Me.tfname_text = New System.Windows.Forms.TextBox()
        Me.tfname_label = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lrn_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.insert_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.teacher_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'teacher_dgv
        '
        Me.teacher_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.teacher_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.teacher_dgv.Location = New System.Drawing.Point(425, 140)
        Me.teacher_dgv.Name = "teacher_dgv"
        Me.teacher_dgv.ReadOnly = True
        Me.teacher_dgv.Size = New System.Drawing.Size(498, 337)
        Me.teacher_dgv.TabIndex = 119
        '
        'tdesignation_text
        '
        Me.tdesignation_text.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.tdesignation_text.Location = New System.Drawing.Point(155, 154)
        Me.tdesignation_text.Name = "tdesignation_text"
        Me.tdesignation_text.Size = New System.Drawing.Size(137, 22)
        Me.tdesignation_text.TabIndex = 114
        '
        'tdesignation_label
        '
        Me.tdesignation_label.AutoSize = True
        Me.tdesignation_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.tdesignation_label.Location = New System.Drawing.Point(17, 154)
        Me.tdesignation_label.Name = "tdesignation_label"
        Me.tdesignation_label.Size = New System.Drawing.Size(124, 15)
        Me.tdesignation_label.TabIndex = 113
        Me.tdesignation_label.Text = "Teacher Designation:"
        '
        'tlname_text
        '
        Me.tlname_text.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.tlname_text.Location = New System.Drawing.Point(155, 117)
        Me.tlname_text.Name = "tlname_text"
        Me.tlname_text.Size = New System.Drawing.Size(137, 22)
        Me.tlname_text.TabIndex = 112
        '
        'tlname_label
        '
        Me.tlname_label.AutoSize = True
        Me.tlname_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.tlname_label.Location = New System.Drawing.Point(17, 117)
        Me.tlname_label.Name = "tlname_label"
        Me.tlname_label.Size = New System.Drawing.Size(70, 15)
        Me.tlname_label.TabIndex = 111
        Me.tlname_label.Text = "Last Name:"
        '
        'teacherid_cbdo
        '
        Me.teacherid_cbdo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teacherid_cbdo.FormattingEnabled = True
        Me.teacherid_cbdo.Location = New System.Drawing.Point(25, 41)
        Me.teacherid_cbdo.Name = "teacherid_cbdo"
        Me.teacherid_cbdo.Size = New System.Drawing.Size(160, 23)
        Me.teacherid_cbdo.TabIndex = 110
        '
        'tmname_text
        '
        Me.tmname_text.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.tmname_text.Location = New System.Drawing.Point(155, 80)
        Me.tmname_text.Name = "tmname_text"
        Me.tmname_text.Size = New System.Drawing.Size(137, 22)
        Me.tmname_text.TabIndex = 109
        '
        'tmname_label
        '
        Me.tmname_label.AutoSize = True
        Me.tmname_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.tmname_label.Location = New System.Drawing.Point(17, 80)
        Me.tmname_label.Name = "tmname_label"
        Me.tmname_label.Size = New System.Drawing.Size(85, 15)
        Me.tmname_label.TabIndex = 108
        Me.tmname_label.Text = "Middle Name:"
        '
        'tfname_text
        '
        Me.tfname_text.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfname_text.Location = New System.Drawing.Point(156, 46)
        Me.tfname_text.Name = "tfname_text"
        Me.tfname_text.Size = New System.Drawing.Size(136, 22)
        Me.tfname_text.TabIndex = 107
        '
        'tfname_label
        '
        Me.tfname_label.AutoSize = True
        Me.tfname_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfname_label.Location = New System.Drawing.Point(17, 46)
        Me.tfname_label.Name = "tfname_label"
        Me.tfname_label.Size = New System.Drawing.Size(70, 15)
        Me.tfname_label.TabIndex = 106
        Me.tfname_label.Text = "First Name:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(973, 80)
        Me.Panel1.TabIndex = 197
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(107, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 21)
        Me.Label3.TabIndex = 169
        Me.Label3.Text = "Admission System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(105, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(341, 23)
        Me.Label2.TabIndex = 168
        Me.Label2.Text = "Camarines Norte Senior High School"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(836, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 24)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "TEACHER"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Location = New System.Drawing.Point(0, 512)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(968, 25)
        Me.Panel2.TabIndex = 198
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tfname_label)
        Me.GroupBox1.Controls.Add(Me.tfname_text)
        Me.GroupBox1.Controls.Add(Me.tlname_text)
        Me.GroupBox1.Controls.Add(Me.tmname_label)
        Me.GroupBox1.Controls.Add(Me.tmname_text)
        Me.GroupBox1.Controls.Add(Me.tlname_label)
        Me.GroupBox1.Controls.Add(Me.tdesignation_label)
        Me.GroupBox1.Controls.Add(Me.tdesignation_text)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 212)
        Me.GroupBox1.TabIndex = 199
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Teacher Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lrn_btn)
        Me.GroupBox2.Controls.Add(Me.exit_btn)
        Me.GroupBox2.Controls.Add(Me.update_btn)
        Me.GroupBox2.Controls.Add(Me.insert_btn)
        Me.GroupBox2.Controls.Add(Me.delete_btn)
        Me.GroupBox2.Controls.Add(Me.teacherid_cbdo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(44, 312)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 165)
        Me.GroupBox2.TabIndex = 201
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Action"
        '
        'lrn_btn
        '
        Me.lrn_btn.BackColor = System.Drawing.Color.Transparent
        Me.lrn_btn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lrn_btn.ForeColor = System.Drawing.Color.ForestGreen
        Me.lrn_btn.Location = New System.Drawing.Point(210, 39)
        Me.lrn_btn.Name = "lrn_btn"
        Me.lrn_btn.Size = New System.Drawing.Size(72, 23)
        Me.lrn_btn.TabIndex = 204
        Me.lrn_btn.Text = "SEARCH"
        Me.lrn_btn.UseVisualStyleBackColor = False
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.Color.Transparent
        Me.exit_btn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_btn.ForeColor = System.Drawing.Color.ForestGreen
        Me.exit_btn.Location = New System.Drawing.Point(164, 119)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(118, 26)
        Me.exit_btn.TabIndex = 165
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.UseVisualStyleBackColor = False
        '
        'update_btn
        '
        Me.update_btn.BackColor = System.Drawing.Color.Transparent
        Me.update_btn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_btn.ForeColor = System.Drawing.Color.ForestGreen
        Me.update_btn.Location = New System.Drawing.Point(164, 77)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(118, 26)
        Me.update_btn.TabIndex = 164
        Me.update_btn.Text = "Update"
        Me.update_btn.UseVisualStyleBackColor = False
        '
        'insert_btn
        '
        Me.insert_btn.BackColor = System.Drawing.Color.Transparent
        Me.insert_btn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert_btn.ForeColor = System.Drawing.Color.ForestGreen
        Me.insert_btn.Location = New System.Drawing.Point(25, 77)
        Me.insert_btn.Name = "insert_btn"
        Me.insert_btn.Size = New System.Drawing.Size(118, 26)
        Me.insert_btn.TabIndex = 163
        Me.insert_btn.Text = "Insert"
        Me.insert_btn.UseVisualStyleBackColor = False
        '
        'delete_btn
        '
        Me.delete_btn.BackColor = System.Drawing.Color.Transparent
        Me.delete_btn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.ForeColor = System.Drawing.Color.ForestGreen
        Me.delete_btn.Location = New System.Drawing.Point(25, 119)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(118, 26)
        Me.delete_btn.TabIndex = 160
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(582, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 23)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "Teacher Information"
        '
        'Teacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 536)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.teacher_dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Teacher"
        Me.Text = "Teacher"
        CType(Me.teacher_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents teacher_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents tdesignation_text As System.Windows.Forms.TextBox
    Friend WithEvents tdesignation_label As System.Windows.Forms.Label
    Friend WithEvents tlname_text As System.Windows.Forms.TextBox
    Friend WithEvents tlname_label As System.Windows.Forms.Label
    Friend WithEvents teacherid_cbdo As System.Windows.Forms.ComboBox
    Friend WithEvents tmname_text As System.Windows.Forms.TextBox
    Friend WithEvents tmname_label As System.Windows.Forms.Label
    Friend WithEvents tfname_text As System.Windows.Forms.TextBox
    Friend WithEvents tfname_label As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lrn_btn As System.Windows.Forms.Button
    Friend WithEvents exit_btn As System.Windows.Forms.Button
    Friend WithEvents update_btn As System.Windows.Forms.Button
    Friend WithEvents insert_btn As System.Windows.Forms.Button
    Friend WithEvents delete_btn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
