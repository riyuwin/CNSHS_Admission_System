<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Applicant_Exam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Applicant_Exam))
        Me.exam_sub_text = New System.Windows.Forms.TextBox()
        Me.result_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.applicant_exam_dgv = New System.Windows.Forms.DataGridView()
        Me.date_picker = New System.Windows.Forms.DateTimePicker()
        Me.examtime_label = New System.Windows.Forms.Label()
        Me.date_label = New System.Windows.Forms.Label()
        Me.examid_cbdo = New System.Windows.Forms.ComboBox()
        Me.room_text = New System.Windows.Forms.TextBox()
        Me.room_label = New System.Windows.Forms.Label()
        Me.examsub_label = New System.Windows.Forms.Label()
        Me.examid_label = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lrn_text = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lrn_btn = New System.Windows.Forms.Button()
        Me.lrn_cbdo = New System.Windows.Forms.ComboBox()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.insert_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.time_picker = New System.Windows.Forms.DateTimePicker()
        CType(Me.applicant_exam_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'exam_sub_text
        '
        Me.exam_sub_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exam_sub_text.Location = New System.Drawing.Point(96, 24)
        Me.exam_sub_text.Name = "exam_sub_text"
        Me.exam_sub_text.ReadOnly = True
        Me.exam_sub_text.Size = New System.Drawing.Size(134, 21)
        Me.exam_sub_text.TabIndex = 165
        '
        'result_txt
        '
        Me.result_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result_txt.Location = New System.Drawing.Point(97, 61)
        Me.result_txt.Name = "result_txt"
        Me.result_txt.Size = New System.Drawing.Size(134, 21)
        Me.result_txt.TabIndex = 164
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(12, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 163
        Me.Label4.Text = "Result:"
        '
        'applicant_exam_dgv
        '
        Me.applicant_exam_dgv.AllowUserToAddRows = False
        Me.applicant_exam_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.applicant_exam_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.applicant_exam_dgv.Location = New System.Drawing.Point(608, 100)
        Me.applicant_exam_dgv.Name = "applicant_exam_dgv"
        Me.applicant_exam_dgv.ReadOnly = True
        Me.applicant_exam_dgv.RowHeadersVisible = False
        Me.applicant_exam_dgv.Size = New System.Drawing.Size(316, 209)
        Me.applicant_exam_dgv.TabIndex = 161
        '
        'date_picker
        '
        Me.date_picker.CustomFormat = "yyyy/mm/dd"
        Me.date_picker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.date_picker.Location = New System.Drawing.Point(78, 114)
        Me.date_picker.Name = "date_picker"
        Me.date_picker.Size = New System.Drawing.Size(204, 21)
        Me.date_picker.TabIndex = 159
        Me.date_picker.Value = New Date(2023, 4, 23, 17, 28, 14, 0)
        '
        'examtime_label
        '
        Me.examtime_label.AutoSize = True
        Me.examtime_label.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.examtime_label.Location = New System.Drawing.Point(21, 154)
        Me.examtime_label.Name = "examtime_label"
        Me.examtime_label.Size = New System.Drawing.Size(35, 16)
        Me.examtime_label.TabIndex = 158
        Me.examtime_label.Text = "Time:"
        '
        'date_label
        '
        Me.date_label.AutoSize = True
        Me.date_label.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.date_label.Location = New System.Drawing.Point(17, 118)
        Me.date_label.Name = "date_label"
        Me.date_label.Size = New System.Drawing.Size(38, 16)
        Me.date_label.TabIndex = 157
        Me.date_label.Text = "Date:"
        '
        'examid_cbdo
        '
        Me.examid_cbdo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.examid_cbdo.FormattingEnabled = True
        Me.examid_cbdo.Location = New System.Drawing.Point(78, 37)
        Me.examid_cbdo.Name = "examid_cbdo"
        Me.examid_cbdo.Size = New System.Drawing.Size(204, 23)
        Me.examid_cbdo.TabIndex = 156
        '
        'room_text
        '
        Me.room_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.room_text.Location = New System.Drawing.Point(78, 77)
        Me.room_text.Name = "room_text"
        Me.room_text.ReadOnly = True
        Me.room_text.Size = New System.Drawing.Size(204, 21)
        Me.room_text.TabIndex = 155
        '
        'room_label
        '
        Me.room_label.AutoSize = True
        Me.room_label.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.room_label.Location = New System.Drawing.Point(17, 77)
        Me.room_label.Name = "room_label"
        Me.room_label.Size = New System.Drawing.Size(42, 16)
        Me.room_label.TabIndex = 154
        Me.room_label.Text = "Room:"
        '
        'examsub_label
        '
        Me.examsub_label.AutoSize = True
        Me.examsub_label.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.examsub_label.Location = New System.Drawing.Point(11, 25)
        Me.examsub_label.Name = "examsub_label"
        Me.examsub_label.Size = New System.Drawing.Size(65, 16)
        Me.examsub_label.TabIndex = 153
        Me.examsub_label.Text = "Exam Sub:"
        '
        'examid_label
        '
        Me.examid_label.AutoSize = True
        Me.examid_label.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.examid_label.Location = New System.Drawing.Point(16, 40)
        Me.examid_label.Name = "examid_label"
        Me.examid_label.Size = New System.Drawing.Size(55, 16)
        Me.examid_label.TabIndex = 152
        Me.examid_label.Text = "Exam Id:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(973, 80)
        Me.Panel1.TabIndex = 200
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(107, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 21)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "Admission System"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(105, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(341, 23)
        Me.Label6.TabIndex = 168
        Me.Label6.Text = "Camarines Norte Senior High School"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(836, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 24)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "TEACHER"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lrn_text)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.address_text)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.school_name_text)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.contact_number_text)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.extname_text)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.lname_text)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.mname_text)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.fname_text)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.Location = New System.Drawing.Point(14, 93)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(262, 374)
        Me.GroupBox5.TabIndex = 202
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Applicant Details"
        '
        'lrn_text
        '
        Me.lrn_text.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.lrn_text.Location = New System.Drawing.Point(120, 39)
        Me.lrn_text.Name = "lrn_text"
        Me.lrn_text.ReadOnly = True
        Me.lrn_text.Size = New System.Drawing.Size(124, 21)
        Me.lrn_text.TabIndex = 203
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label14.Location = New System.Drawing.Point(13, 315)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 16)
        Me.Label14.TabIndex = 201
        Me.Label14.Text = "Address:"
        '
        'address_text
        '
        Me.address_text.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.address_text.Location = New System.Drawing.Point(120, 312)
        Me.address_text.MaximumSize = New System.Drawing.Size(500, 30)
        Me.address_text.MinimumSize = New System.Drawing.Size(124, 30)
        Me.address_text.Name = "address_text"
        Me.address_text.ReadOnly = True
        Me.address_text.Size = New System.Drawing.Size(124, 21)
        Me.address_text.TabIndex = 202
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(13, 273)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 16)
        Me.Label13.TabIndex = 199
        Me.Label13.Text = "School Name:"
        '
        'school_name_text
        '
        Me.school_name_text.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.school_name_text.Location = New System.Drawing.Point(120, 270)
        Me.school_name_text.Name = "school_name_text"
        Me.school_name_text.ReadOnly = True
        Me.school_name_text.Size = New System.Drawing.Size(124, 21)
        Me.school_name_text.TabIndex = 200
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(13, 235)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 16)
        Me.Label12.TabIndex = 197
        Me.Label12.Text = "Contact Number:"
        '
        'contact_number_text
        '
        Me.contact_number_text.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.contact_number_text.Location = New System.Drawing.Point(120, 232)
        Me.contact_number_text.Name = "contact_number_text"
        Me.contact_number_text.ReadOnly = True
        Me.contact_number_text.Size = New System.Drawing.Size(124, 21)
        Me.contact_number_text.TabIndex = 198
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(13, 197)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 16)
        Me.Label11.TabIndex = 195
        Me.Label11.Text = "Ext. Name:"
        '
        'extname_text
        '
        Me.extname_text.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.extname_text.Location = New System.Drawing.Point(120, 194)
        Me.extname_text.Name = "extname_text"
        Me.extname_text.ReadOnly = True
        Me.extname_text.Size = New System.Drawing.Size(124, 21)
        Me.extname_text.TabIndex = 196
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(13, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 193
        Me.Label10.Text = "Last Name:"
        '
        'lname_text
        '
        Me.lname_text.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.lname_text.Location = New System.Drawing.Point(120, 152)
        Me.lname_text.Name = "lname_text"
        Me.lname_text.ReadOnly = True
        Me.lname_text.Size = New System.Drawing.Size(124, 21)
        Me.lname_text.TabIndex = 194
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(13, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 16)
        Me.Label9.TabIndex = 191
        Me.Label9.Text = "Middle Name:"
        '
        'mname_text
        '
        Me.mname_text.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.mname_text.Location = New System.Drawing.Point(120, 113)
        Me.mname_text.Name = "mname_text"
        Me.mname_text.ReadOnly = True
        Me.mname_text.Size = New System.Drawing.Size(124, 21)
        Me.mname_text.TabIndex = 192
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(13, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 16)
        Me.Label8.TabIndex = 176
        Me.Label8.Text = "First Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(15, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 190
        Me.Label1.Text = "LRN:"
        '
        'fname_text
        '
        Me.fname_text.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.fname_text.Location = New System.Drawing.Point(120, 76)
        Me.fname_text.Name = "fname_text"
        Me.fname_text.ReadOnly = True
        Me.fname_text.Size = New System.Drawing.Size(124, 21)
        Me.fname_text.TabIndex = 177
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.time_picker)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.examid_label)
        Me.GroupBox1.Controls.Add(Me.examid_cbdo)
        Me.GroupBox1.Controls.Add(Me.room_label)
        Me.GroupBox1.Controls.Add(Me.room_text)
        Me.GroupBox1.Controls.Add(Me.date_picker)
        Me.GroupBox1.Controls.Add(Me.date_label)
        Me.GroupBox1.Controls.Add(Me.examtime_label)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(291, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 331)
        Me.GroupBox1.TabIndex = 203
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exam Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.exam_sub_text)
        Me.GroupBox2.Controls.Add(Me.examsub_label)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.result_txt)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 101)
        Me.GroupBox2.TabIndex = 166
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lrn_btn)
        Me.GroupBox3.Controls.Add(Me.lrn_cbdo)
        Me.GroupBox3.Controls.Add(Me.exit_btn)
        Me.GroupBox3.Controls.Add(Me.update_btn)
        Me.GroupBox3.Controls.Add(Me.insert_btn)
        Me.GroupBox3.Controls.Add(Me.delete_btn)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(608, 315)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(316, 165)
        Me.GroupBox3.TabIndex = 204
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Action"
        '
        'lrn_btn
        '
        Me.lrn_btn.BackColor = System.Drawing.Color.Transparent
        Me.lrn_btn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lrn_btn.ForeColor = System.Drawing.Color.ForestGreen
        Me.lrn_btn.Location = New System.Drawing.Point(214, 39)
        Me.lrn_btn.Name = "lrn_btn"
        Me.lrn_btn.Size = New System.Drawing.Size(72, 23)
        Me.lrn_btn.TabIndex = 204
        Me.lrn_btn.Text = "SEARCH"
        Me.lrn_btn.UseVisualStyleBackColor = False
        '
        'lrn_cbdo
        '
        Me.lrn_cbdo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lrn_cbdo.FormattingEnabled = True
        Me.lrn_cbdo.Location = New System.Drawing.Point(29, 38)
        Me.lrn_cbdo.Name = "lrn_cbdo"
        Me.lrn_cbdo.Size = New System.Drawing.Size(171, 24)
        Me.lrn_cbdo.TabIndex = 203
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.Color.Transparent
        Me.exit_btn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_btn.ForeColor = System.Drawing.Color.ForestGreen
        Me.exit_btn.Location = New System.Drawing.Point(168, 119)
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
        Me.update_btn.Location = New System.Drawing.Point(168, 77)
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
        Me.insert_btn.Location = New System.Drawing.Point(29, 77)
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
        Me.delete_btn.Location = New System.Drawing.Point(29, 119)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(118, 26)
        Me.delete_btn.TabIndex = 160
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Location = New System.Drawing.Point(-1, 494)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(968, 25)
        Me.Panel2.TabIndex = 205
        '
        'time_picker
        '
        Me.time_picker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.time_picker.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.time_picker.CustomFormat = "HH:mm:ss"
        Me.time_picker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.time_picker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.time_picker.Location = New System.Drawing.Point(78, 150)
        Me.time_picker.Name = "time_picker"
        Me.time_picker.Size = New System.Drawing.Size(204, 21)
        Me.time_picker.TabIndex = 166
        Me.time_picker.Value = New Date(2023, 4, 23, 17, 28, 0, 0)
        '
        'Applicant_Exam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 515)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.applicant_exam_dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Applicant_Exam"
        Me.Text = "Applicant_Exam"
        CType(Me.applicant_exam_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents exam_sub_text As System.Windows.Forms.TextBox
    Friend WithEvents result_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents applicant_exam_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents date_picker As System.Windows.Forms.DateTimePicker
    Friend WithEvents examtime_label As System.Windows.Forms.Label
    Friend WithEvents date_label As System.Windows.Forms.Label
    Friend WithEvents examid_cbdo As System.Windows.Forms.ComboBox
    Friend WithEvents room_text As System.Windows.Forms.TextBox
    Friend WithEvents room_label As System.Windows.Forms.Label
    Friend WithEvents examsub_label As System.Windows.Forms.Label
    Friend WithEvents examid_label As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lrn_btn As System.Windows.Forms.Button
    Friend WithEvents lrn_cbdo As System.Windows.Forms.ComboBox
    Friend WithEvents exit_btn As System.Windows.Forms.Button
    Friend WithEvents update_btn As System.Windows.Forms.Button
    Friend WithEvents insert_btn As System.Windows.Forms.Button
    Friend WithEvents delete_btn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lrn_text As System.Windows.Forms.TextBox
    Friend WithEvents time_picker As System.Windows.Forms.DateTimePicker
End Class
