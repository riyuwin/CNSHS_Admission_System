Imports System.Windows.Forms

Public Class CNSHS_ADMISSION_SYSTEM_MENU


    Dim Applicant As New Applicant 


    Private Sub CNSHS_ADMISSION_SYSTEM_MENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create a new instance of the child form
        Dim ChildForm As New Landing_Page
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        'm_ChildformNumber += 1
        'ChildForm.Text = "Window" & m_ChildFormNumber
        ChildForm.Dock = DockStyle.Fill

        Tag = 1
        ChildForm.Show()
    End Sub

    Private Sub ApplicantToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicantToolStripMenuItem.Click
        ' Create a new instance of the child form
        Dim ChildForm As New Applicant
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        'm_ChildformNumber += 1
        'ChildForm.Text = "Window" & m_ChildFormNumber
        ChildForm.Dock = DockStyle.Fill

        Tag = 1
        ChildForm.Show()
    End Sub
     

    Private Sub ExamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExamToolStripMenuItem.Click
        ' Create a new instance of the child form
        Dim ChildForm As New Exam
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        'm_ChildformNumber += 1
        'ChildForm.Text = "Window" & m_ChildFormNumber
        ChildForm.Dock = DockStyle.Fill

        Tag = 1
        ChildForm.Show()
    End Sub
     
    Private Sub SectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectionToolStripMenuItem.Click
        ' Create a new instance of the child form
        Dim ChildForm As New Section
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        'm_ChildformNumber += 1
        'ChildForm.Text = "Window" & m_ChildFormNumber
        ChildForm.Dock = DockStyle.Fill

        Tag = 1
        ChildForm.Show()
    End Sub

    Private Sub SubjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubjectToolStripMenuItem.Click
        ' Create a new instance of the child form
        Dim ChildForm As New Subject
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        'm_ChildformNumber += 1
        'ChildForm.Text = "Window" & m_ChildFormNumber
        ChildForm.Dock = DockStyle.Fill

        Tag = 1
        ChildForm.Show()
    End Sub


    Private Sub TeacherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeacherToolStripMenuItem.Click
        ' Create a new instance of the child form
        Dim ChildForm As New Teacher
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        'm_ChildformNumber += 1
        'ChildForm.Text = "Window" & m_ChildFormNumber
        ChildForm.Dock = DockStyle.Fill

        Tag = 1
        ChildForm.Show()
    End Sub

    Private Sub ApplicantExamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicantExamToolStripMenuItem.Click
        ' Create a new instance of the child form
        Dim ChildForm As New Applicant_Exam
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        'm_ChildformNumber += 1
        'ChildForm.Text = "Window" & m_ChildFormNumber
        ChildForm.Dock = DockStyle.Fill

        Tag = 1
        ChildForm.Show()
    End Sub
     
    Private Sub RequirementsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RequirementsToolStripMenuItem.Click
        ' Create a new instance of the child form
        Dim ChildForm As New Requirement
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        'm_ChildformNumber += 1
        'ChildForm.Text = "Window" & m_ChildFormNumber
        ChildForm.Dock = DockStyle.Fill

        Tag = 1
        ChildForm.Show()
         
    End Sub
      
    Private Sub ValidatesApplicantToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValidatesApplicantToolStripMenuItem.Click
        ' Create a new instance of the child form
        Dim ChildForm As New Validates_Applicant
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        'm_ChildformNumber += 1
        'ChildForm.Text = "Window" & m_ChildFormNumber
        ChildForm.Dock = DockStyle.Fill

        Tag = 1
        ChildForm.Show()
    End Sub

    Private Sub ApplicantSectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicantSectionToolStripMenuItem.Click
        ' Create a new instance of the child form
        Dim ChildForm As New Applicant_Acad_Year
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        'm_ChildformNumber += 1
        'ChildForm.Text = "Window" & m_ChildFormNumber
        ChildForm.Dock = DockStyle.Fill

        Tag = 1
        ChildForm.Show()
    End Sub

    Private Sub ApplicantSubjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicantSubjectToolStripMenuItem.Click
        ' Create a new instance of the child form
        Dim ChildForm As New Applicant_Subject
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        'm_ChildformNumber += 1
        'ChildForm.Text = "Window" & m_ChildFormNumber
        ChildForm.Dock = DockStyle.Fill

        Tag = 1
        ChildForm.Show()
    End Sub

    Private Sub ApplicantRequirementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicantRequirementsToolStripMenuItem.Click
        ' Create a new instance of the child form
        Dim ChildForm As New Requirement
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        'm_ChildformNumber += 1
        'ChildForm.Text = "Window" & m_ChildFormNumber
        ChildForm.Dock = DockStyle.Fill

        Tag = 1
        ChildForm.Show()
    End Sub
End Class
