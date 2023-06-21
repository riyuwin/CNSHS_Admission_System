<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Subject))
        Me.subject_dgv = New System.Windows.Forms.DataGridView()
        Me.subid_cbdo = New System.Windows.Forms.ComboBox()
        Me.subinstructor_label = New System.Windows.Forms.Label()
        Me.subname_text = New System.Windows.Forms.TextBox()
        Me.subname_label = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.subinstructor_cbdo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.exam_id_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.update_button = New System.Windows.Forms.Button()
        Me.insert_btn = New System.Windows.Forms.Button()
        Me.delete_button = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.subject_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'subject_dgv
        '
        Me.subject_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.subject_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.subject_dgv.Location = New System.Drawing.Point(476, 108)
        Me.subject_dgv.Name = "subject_dgv"
        Me.subject_dgv.ReadOnly = True
        Me.subject_dgv.Size = New System.Drawing.Size(424, 376)
        Me.subject_dgv.TabIndex = 112
        '
        'subid_cbdo
        '
        Me.subid_cbdo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subid_cbdo.FormattingEnabled = True
        Me.subid_cbdo.Location = New System.Drawing.Point(53, 41)
        Me.subid_cbdo.Name = "subid_cbdo"
        Me.subid_cbdo.Size = New System.Drawing.Size(162, 23)
        Me.subid_cbdo.TabIndex = 107
        '
        'subinstructor_label
        '
        Me.subinstructor_label.AutoSize = True
        Me.subinstructor_label.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subinstructor_label.Location = New System.Drawing.Point(19, 124)
        Me.subinstructor_label.Name = "subinstructor_label"
        Me.subinstructor_label.Size = New System.Drawing.Size(116, 17)
        Me.subinstructor_label.TabIndex = 105
        Me.subinstructor_label.Text = "Subject Instructor:"
        '
        'subname_text
        '
        Me.subname_text.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subname_text.Location = New System.Drawing.Point(160, 60)
        Me.subname_text.Name = "subname_text"
        Me.subname_text.Size = New System.Drawing.Size(172, 22)
        Me.subname_text.TabIndex = 104
        '
        'subname_label
        '
        Me.subname_label.AutoSize = True
        Me.subname_label.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subname_label.Location = New System.Drawing.Point(19, 65)
        Me.subname_label.Name = "subname_label"
        Me.subname_label.Size = New System.Drawing.Size(96, 17)
        Me.subname_label.TabIndex = 103
        Me.subname_label.Text = "Subject Name:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(973, 80)
        Me.Panel1.TabIndex = 198
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
        Me.Label1.Location = New System.Drawing.Point(835, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 24)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "SUBJECT"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.subinstructor_cbdo)
        Me.GroupBox1.Controls.Add(Me.subname_label)
        Me.GroupBox1.Controls.Add(Me.subname_text)
        Me.GroupBox1.Controls.Add(Me.subinstructor_label)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 210)
        Me.GroupBox1.TabIndex = 206
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Subject Details"
        '
        'subinstructor_cbdo
        '
        Me.subinstructor_cbdo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subinstructor_cbdo.FormattingEnabled = True
        Me.subinstructor_cbdo.Location = New System.Drawing.Point(160, 120)
        Me.subinstructor_cbdo.Name = "subinstructor_cbdo"
        Me.subinstructor_cbdo.Size = New System.Drawing.Size(172, 23)
        Me.subinstructor_cbdo.TabIndex = 205
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.exam_id_btn)
        Me.GroupBox2.Controls.Add(Me.exit_btn)
        Me.GroupBox2.Controls.Add(Me.update_button)
        Me.GroupBox2.Controls.Add(Me.insert_btn)
        Me.GroupBox2.Controls.Add(Me.subid_cbdo)
        Me.GroupBox2.Controls.Add(Me.delete_button)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(37, 319)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 165)
        Me.GroupBox2.TabIndex = 205
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Action"
        '
        'exam_id_btn
        '
        Me.exam_id_btn.BackColor = System.Drawing.Color.Transparent
        Me.exam_id_btn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exam_id_btn.ForeColor = System.Drawing.Color.ForestGreen
        Me.exam_id_btn.Location = New System.Drawing.Point(238, 39)
        Me.exam_id_btn.Name = "exam_id_btn"
        Me.exam_id_btn.Size = New System.Drawing.Size(72, 23)
        Me.exam_id_btn.TabIndex = 204
        Me.exam_id_btn.Text = "SEARCH"
        Me.exam_id_btn.UseVisualStyleBackColor = False
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.Color.Transparent
        Me.exit_btn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_btn.ForeColor = System.Drawing.Color.ForestGreen
        Me.exit_btn.Location = New System.Drawing.Point(192, 120)
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
        Me.update_button.Location = New System.Drawing.Point(192, 78)
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
        Me.insert_btn.Location = New System.Drawing.Point(53, 78)
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
        Me.delete_button.Location = New System.Drawing.Point(53, 120)
        Me.delete_button.Name = "delete_button"
        Me.delete_button.Size = New System.Drawing.Size(118, 26)
        Me.delete_button.TabIndex = 160
        Me.delete_button.Text = "Delete"
        Me.delete_button.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Location = New System.Drawing.Point(-2, 495)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(968, 25)
        Me.Panel2.TabIndex = 207
        '
        'Subject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 515)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.subject_dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Subject"
        Me.Text = "Subject"
        CType(Me.subject_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents subject_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents subid_cbdo As System.Windows.Forms.ComboBox
    Friend WithEvents subinstructor_label As System.Windows.Forms.Label
    Friend WithEvents subname_text As System.Windows.Forms.TextBox
    Friend WithEvents subname_label As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents exam_id_btn As System.Windows.Forms.Button
    Friend WithEvents exit_btn As System.Windows.Forms.Button
    Friend WithEvents update_button As System.Windows.Forms.Button
    Friend WithEvents insert_btn As System.Windows.Forms.Button
    Friend WithEvents delete_button As System.Windows.Forms.Button
    Friend WithEvents subinstructor_cbdo As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
