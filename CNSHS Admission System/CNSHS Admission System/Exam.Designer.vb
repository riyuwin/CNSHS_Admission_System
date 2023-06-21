<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Exam))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.exam_dgv = New System.Windows.Forms.DataGridView()
        Me.time_picker = New System.Windows.Forms.DateTimePicker()
        Me.date_picker = New System.Windows.Forms.DateTimePicker()
        Me.examtime_label = New System.Windows.Forms.Label()
        Me.date_label = New System.Windows.Forms.Label()
        Me.room_text = New System.Windows.Forms.TextBox()
        Me.room_label = New System.Windows.Forms.Label()
        Me.examsub_text = New System.Windows.Forms.TextBox()
        Me.examsub_label = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.exam_id_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.update_button = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.delete_button = New System.Windows.Forms.Button()
        Me.examid_cbdo = New System.Windows.Forms.ComboBox()
        CType(Me.exam_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Marker", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(638, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 21)
        Me.Label2.TabIndex = 147
        Me.Label2.Text = "Exam Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Marker", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(618, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 21)
        Me.Label3.TabIndex = 146
        '
        'exam_dgv
        '
        Me.exam_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.exam_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.exam_dgv.Location = New System.Drawing.Point(491, 126)
        Me.exam_dgv.Name = "exam_dgv"
        Me.exam_dgv.ReadOnly = True
        Me.exam_dgv.Size = New System.Drawing.Size(424, 371)
        Me.exam_dgv.TabIndex = 145
        '
        'time_picker
        '
        Me.time_picker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.time_picker.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.time_picker.CustomFormat = "HH:mm:ss"
        Me.time_picker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.time_picker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.time_picker.Location = New System.Drawing.Point(110, 169)
        Me.time_picker.Name = "time_picker"
        Me.time_picker.Size = New System.Drawing.Size(224, 21)
        Me.time_picker.TabIndex = 138
        Me.time_picker.Value = New Date(2023, 4, 23, 17, 28, 0, 0)
        '
        'date_picker
        '
        Me.date_picker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_picker.CustomFormat = "yyyy/mm/dd"
        Me.date_picker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.date_picker.Location = New System.Drawing.Point(110, 122)
        Me.date_picker.Name = "date_picker"
        Me.date_picker.Size = New System.Drawing.Size(224, 21)
        Me.date_picker.TabIndex = 137
        Me.date_picker.Value = New Date(2023, 4, 23, 17, 28, 14, 0)
        '
        'examtime_label
        '
        Me.examtime_label.AutoSize = True
        Me.examtime_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.examtime_label.Location = New System.Drawing.Point(22, 173)
        Me.examtime_label.Name = "examtime_label"
        Me.examtime_label.Size = New System.Drawing.Size(42, 16)
        Me.examtime_label.TabIndex = 136
        Me.examtime_label.Text = "Time:"
        '
        'date_label
        '
        Me.date_label.AutoSize = True
        Me.date_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.date_label.Location = New System.Drawing.Point(22, 129)
        Me.date_label.Name = "date_label"
        Me.date_label.Size = New System.Drawing.Size(40, 16)
        Me.date_label.TabIndex = 135
        Me.date_label.Text = "Date:"
        '
        'room_text
        '
        Me.room_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.room_text.Location = New System.Drawing.Point(110, 82)
        Me.room_text.Name = "room_text"
        Me.room_text.Size = New System.Drawing.Size(224, 21)
        Me.room_text.TabIndex = 133
        '
        'room_label
        '
        Me.room_label.AutoSize = True
        Me.room_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.room_label.Location = New System.Drawing.Point(22, 82)
        Me.room_label.Name = "room_label"
        Me.room_label.Size = New System.Drawing.Size(48, 16)
        Me.room_label.TabIndex = 132
        Me.room_label.Text = "Room:"
        '
        'examsub_text
        '
        Me.examsub_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.examsub_text.Location = New System.Drawing.Point(110, 36)
        Me.examsub_text.Name = "examsub_text"
        Me.examsub_text.Size = New System.Drawing.Size(224, 21)
        Me.examsub_text.TabIndex = 131
        '
        'examsub_label
        '
        Me.examsub_label.AutoSize = True
        Me.examsub_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.examsub_label.Location = New System.Drawing.Point(20, 39)
        Me.examsub_label.Name = "examsub_label"
        Me.examsub_label.Size = New System.Drawing.Size(72, 16)
        Me.examsub_label.TabIndex = 130
        Me.examsub_label.Text = "Exam Sub:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(-4, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(973, 80)
        Me.Panel1.TabIndex = 199
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
        Me.Label6.Location = New System.Drawing.Point(836, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 24)
        Me.Label6.TabIndex = 156
        Me.Label6.Text = "TEACHER"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Location = New System.Drawing.Point(1, 513)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(968, 25)
        Me.Panel2.TabIndex = 200
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.date_picker)
        Me.GroupBox1.Controls.Add(Me.examsub_label)
        Me.GroupBox1.Controls.Add(Me.examsub_text)
        Me.GroupBox1.Controls.Add(Me.room_label)
        Me.GroupBox1.Controls.Add(Me.room_text)
        Me.GroupBox1.Controls.Add(Me.date_label)
        Me.GroupBox1.Controls.Add(Me.examtime_label)
        Me.GroupBox1.Controls.Add(Me.time_picker)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 235)
        Me.GroupBox1.TabIndex = 201
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exam Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.exam_id_btn)
        Me.GroupBox2.Controls.Add(Me.exit_btn)
        Me.GroupBox2.Controls.Add(Me.update_button)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.delete_button)
        Me.GroupBox2.Controls.Add(Me.examid_cbdo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(42, 332)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 165)
        Me.GroupBox2.TabIndex = 202
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
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Button2.Location = New System.Drawing.Point(53, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 26)
        Me.Button2.TabIndex = 163
        Me.Button2.Text = "Insert"
        Me.Button2.UseVisualStyleBackColor = False
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
        'examid_cbdo
        '
        Me.examid_cbdo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.examid_cbdo.FormattingEnabled = True
        Me.examid_cbdo.Location = New System.Drawing.Point(53, 38)
        Me.examid_cbdo.Name = "examid_cbdo"
        Me.examid_cbdo.Size = New System.Drawing.Size(171, 23)
        Me.examid_cbdo.TabIndex = 134
        '
        'Exam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 536)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.exam_dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Exam"
        Me.Text = "Exam"
        CType(Me.exam_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents exam_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents time_picker As System.Windows.Forms.DateTimePicker
    Friend WithEvents date_picker As System.Windows.Forms.DateTimePicker
    Friend WithEvents examtime_label As System.Windows.Forms.Label
    Friend WithEvents date_label As System.Windows.Forms.Label
    Friend WithEvents room_text As System.Windows.Forms.TextBox
    Friend WithEvents room_label As System.Windows.Forms.Label
    Friend WithEvents examsub_text As System.Windows.Forms.TextBox
    Friend WithEvents examsub_label As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents exam_id_btn As System.Windows.Forms.Button
    Friend WithEvents exit_btn As System.Windows.Forms.Button
    Friend WithEvents update_button As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents delete_button As System.Windows.Forms.Button
    Friend WithEvents examid_cbdo As System.Windows.Forms.ComboBox
End Class
