<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Section
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Section))
        Me.section_dgv = New System.Windows.Forms.DataGridView()
        Me.gradelevel_text = New System.Windows.Forms.TextBox()
        Me.gradelevel_label = New System.Windows.Forms.Label()
        Me.sectionid_cbdo = New System.Windows.Forms.ComboBox()
        Me.roomnum_text = New System.Windows.Forms.TextBox()
        Me.roomnum_label = New System.Windows.Forms.Label()
        Me.secname_text = New System.Windows.Forms.TextBox()
        Me.secname_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.exam_id_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.update_button = New System.Windows.Forms.Button()
        Me.insert_btn = New System.Windows.Forms.Button()
        Me.delete_button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.section_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'section_dgv
        '
        Me.section_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.section_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.section_dgv.Location = New System.Drawing.Point(480, 136)
        Me.section_dgv.Name = "section_dgv"
        Me.section_dgv.ReadOnly = True
        Me.section_dgv.Size = New System.Drawing.Size(424, 358)
        Me.section_dgv.TabIndex = 141
        '
        'gradelevel_text
        '
        Me.gradelevel_text.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradelevel_text.Location = New System.Drawing.Point(149, 137)
        Me.gradelevel_text.Name = "gradelevel_text"
        Me.gradelevel_text.Size = New System.Drawing.Size(178, 22)
        Me.gradelevel_text.TabIndex = 136
        '
        'gradelevel_label
        '
        Me.gradelevel_label.AutoSize = True
        Me.gradelevel_label.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradelevel_label.Location = New System.Drawing.Point(25, 141)
        Me.gradelevel_label.Name = "gradelevel_label"
        Me.gradelevel_label.Size = New System.Drawing.Size(85, 17)
        Me.gradelevel_label.TabIndex = 135
        Me.gradelevel_label.Text = "Grade Level:"
        '
        'sectionid_cbdo
        '
        Me.sectionid_cbdo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sectionid_cbdo.FormattingEnabled = True
        Me.sectionid_cbdo.Location = New System.Drawing.Point(53, 39)
        Me.sectionid_cbdo.Name = "sectionid_cbdo"
        Me.sectionid_cbdo.Size = New System.Drawing.Size(167, 23)
        Me.sectionid_cbdo.TabIndex = 134
        '
        'roomnum_text
        '
        Me.roomnum_text.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomnum_text.Location = New System.Drawing.Point(148, 92)
        Me.roomnum_text.Name = "roomnum_text"
        Me.roomnum_text.Size = New System.Drawing.Size(178, 22)
        Me.roomnum_text.TabIndex = 133
        '
        'roomnum_label
        '
        Me.roomnum_label.AutoSize = True
        Me.roomnum_label.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomnum_label.Location = New System.Drawing.Point(24, 96)
        Me.roomnum_label.Name = "roomnum_label"
        Me.roomnum_label.Size = New System.Drawing.Size(95, 17)
        Me.roomnum_label.TabIndex = 132
        Me.roomnum_label.Text = "Room Number:"
        '
        'secname_text
        '
        Me.secname_text.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secname_text.Location = New System.Drawing.Point(149, 49)
        Me.secname_text.Name = "secname_text"
        Me.secname_text.Size = New System.Drawing.Size(177, 22)
        Me.secname_text.TabIndex = 131
        '
        'secname_label
        '
        Me.secname_label.AutoSize = True
        Me.secname_label.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secname_label.Location = New System.Drawing.Point(24, 53)
        Me.secname_label.Name = "secname_label"
        Me.secname_label.Size = New System.Drawing.Size(96, 17)
        Me.secname_label.TabIndex = 130
        Me.secname_label.Text = "Section Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(107, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 21)
        Me.Label1.TabIndex = 169
        Me.Label1.Text = "Admission System"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 80)
        Me.Panel1.TabIndex = 197
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(844, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 24)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "SECTION"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Location = New System.Drawing.Point(0, 511)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(968, 25)
        Me.Panel2.TabIndex = 198
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.exam_id_btn)
        Me.GroupBox2.Controls.Add(Me.exit_btn)
        Me.GroupBox2.Controls.Add(Me.update_button)
        Me.GroupBox2.Controls.Add(Me.insert_btn)
        Me.GroupBox2.Controls.Add(Me.delete_button)
        Me.GroupBox2.Controls.Add(Me.sectionid_cbdo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(42, 326)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 165)
        Me.GroupBox2.TabIndex = 203
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.secname_text)
        Me.GroupBox1.Controls.Add(Me.secname_label)
        Me.GroupBox1.Controls.Add(Me.roomnum_text)
        Me.GroupBox1.Controls.Add(Me.roomnum_label)
        Me.GroupBox1.Controls.Add(Me.gradelevel_text)
        Me.GroupBox1.Controls.Add(Me.gradelevel_label)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 210)
        Me.GroupBox1.TabIndex = 204
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Section Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Marker", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(631, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 21)
        Me.Label3.TabIndex = 205
        Me.Label3.Text = "Section Information"
        '
        'Section
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 536)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.section_dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Section"
        Me.Text = "Section"
        CType(Me.section_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents section_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents gradelevel_text As System.Windows.Forms.TextBox
    Friend WithEvents gradelevel_label As System.Windows.Forms.Label
    Friend WithEvents sectionid_cbdo As System.Windows.Forms.ComboBox
    Friend WithEvents roomnum_text As System.Windows.Forms.TextBox
    Friend WithEvents roomnum_label As System.Windows.Forms.Label
    Friend WithEvents secname_text As System.Windows.Forms.TextBox
    Friend WithEvents secname_label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents exam_id_btn As System.Windows.Forms.Button
    Friend WithEvents exit_btn As System.Windows.Forms.Button
    Friend WithEvents update_button As System.Windows.Forms.Button
    Friend WithEvents insert_btn As System.Windows.Forms.Button
    Friend WithEvents delete_button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
