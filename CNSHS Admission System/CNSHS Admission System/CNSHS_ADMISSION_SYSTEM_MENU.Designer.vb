<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CNSHS_ADMISSION_SYSTEM_MENU
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MasterFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequirementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicantRequirementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValidatesApplicantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicantExamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicantSectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicantSubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterFilesToolStripMenuItem, Me.TransactionsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(952, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MasterFilesToolStripMenuItem
        '
        Me.MasterFilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicantToolStripMenuItem, Me.ExamToolStripMenuItem, Me.RequirementsToolStripMenuItem, Me.SectionToolStripMenuItem, Me.SubjectToolStripMenuItem, Me.TeacherToolStripMenuItem})
        Me.MasterFilesToolStripMenuItem.Name = "MasterFilesToolStripMenuItem"
        Me.MasterFilesToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.MasterFilesToolStripMenuItem.Text = "Master Files"
        '
        'ApplicantToolStripMenuItem
        '
        Me.ApplicantToolStripMenuItem.Name = "ApplicantToolStripMenuItem"
        Me.ApplicantToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ApplicantToolStripMenuItem.Text = "Applicant"
        '
        'ExamToolStripMenuItem
        '
        Me.ExamToolStripMenuItem.Name = "ExamToolStripMenuItem"
        Me.ExamToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExamToolStripMenuItem.Text = "Exam"
        '
        'RequirementsToolStripMenuItem
        '
        Me.RequirementsToolStripMenuItem.Name = "RequirementsToolStripMenuItem"
        Me.RequirementsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RequirementsToolStripMenuItem.Text = "Requirements"
        '
        'SectionToolStripMenuItem
        '
        Me.SectionToolStripMenuItem.Name = "SectionToolStripMenuItem"
        Me.SectionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SectionToolStripMenuItem.Text = "Section"
        '
        'SubjectToolStripMenuItem
        '
        Me.SubjectToolStripMenuItem.Name = "SubjectToolStripMenuItem"
        Me.SubjectToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SubjectToolStripMenuItem.Text = "Subject"
        '
        'TeacherToolStripMenuItem
        '
        Me.TeacherToolStripMenuItem.Name = "TeacherToolStripMenuItem"
        Me.TeacherToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TeacherToolStripMenuItem.Text = "Teacher"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicantRequirementsToolStripMenuItem, Me.ValidatesApplicantToolStripMenuItem, Me.ApplicantExamToolStripMenuItem, Me.ApplicantSectionToolStripMenuItem, Me.ApplicantSubjectToolStripMenuItem})
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.TransactionsToolStripMenuItem.Text = "Transactions"
        '
        'ApplicantRequirementsToolStripMenuItem
        '
        Me.ApplicantRequirementsToolStripMenuItem.Name = "ApplicantRequirementsToolStripMenuItem"
        Me.ApplicantRequirementsToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ApplicantRequirementsToolStripMenuItem.Text = "Applicant Requirements"
        '
        'ValidatesApplicantToolStripMenuItem
        '
        Me.ValidatesApplicantToolStripMenuItem.Name = "ValidatesApplicantToolStripMenuItem"
        Me.ValidatesApplicantToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ValidatesApplicantToolStripMenuItem.Text = "Validates Applicant"
        '
        'ApplicantExamToolStripMenuItem
        '
        Me.ApplicantExamToolStripMenuItem.Name = "ApplicantExamToolStripMenuItem"
        Me.ApplicantExamToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ApplicantExamToolStripMenuItem.Text = "Applicant Exam"
        '
        'ApplicantSectionToolStripMenuItem
        '
        Me.ApplicantSectionToolStripMenuItem.Name = "ApplicantSectionToolStripMenuItem"
        Me.ApplicantSectionToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ApplicantSectionToolStripMenuItem.Text = "Applicant Section"
        '
        'ApplicantSubjectToolStripMenuItem
        '
        Me.ApplicantSubjectToolStripMenuItem.Name = "ApplicantSubjectToolStripMenuItem"
        Me.ApplicantSubjectToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ApplicantSubjectToolStripMenuItem.Text = "Applicant Subject"
        '
        'CNSHS_ADMISSION_SYSTEM_MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 544)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "CNSHS_ADMISSION_SYSTEM_MENU"
        Me.Text = "CNSHS Admission System"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplicantToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequirementsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeacherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplicantExamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplicantRequirementsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplicantSectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplicantSubjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValidatesApplicantToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
