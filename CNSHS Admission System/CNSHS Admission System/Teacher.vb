Imports MySql.Data.MySqlClient

Public Class Teacher
    Dim connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnshs_admission_system")
    Dim table As New DataTable()
    Dim adapter As New MySqlDataAdapter("SELECT teacher_id, teacher_name, teacher_designation FROM cnshs_admission_system.teacher", connection)

    Private Sub Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Show_Table()
        Search_Load()

    End Sub


    Public Sub Show_Table()

        adapter.Fill(table)

        teacher_dgv.DataSource = table

        teacher_dgv.Columns("teacher_id").HeaderText = "Teacher ID"
        teacher_dgv.Columns("teacher_name").HeaderText = "Teacher Name"
        teacher_dgv.Columns("teacher_designation").HeaderText = "Teacher Designation"

        teacher_dgv.DefaultCellStyle.Font = New Font("Century Gothic", 8, FontStyle.Regular)

    End Sub

    Public Sub clear_table()

        table.Clear()

    End Sub


    Private Sub Search_Load()
        Dim Applicant As String
        Applicant = "Select teacher_id from teacher"
        Try
            readqueary(Applicant)
            With cmdread
                While .Read
                    teacherid_cbdo.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception

        End Try
    End Sub


    Public Sub Clear_Item() 
        tfname_text.Clear()
        tmname_text.Clear()
        tlname_text.Clear()
        tdesignation_text.Clear()

        teacherid_cbdo.Items.Clear()

        Search_Load()


    End Sub

      
    Private Sub insert_btn_Click(sender As Object, e As EventArgs) Handles insert_btn.Click 
        Dim teacher_fullname As String
        Dim insert_teacher As String

        teacher_fullname = tlname_text.Text + ", " + tfname_text.Text + ", " + tmname_text.Text
         
        'Dim insert_teacher = "Insert teacher_name, teacher_designation from TEACHER values ('" & teacher_fullname & "', '" & tdesignation_text.Text & "')"

        insert_teacher = "INSERT INTO teacher (teacher_name, teacher_designation)" &
            "VALUES ('" & teacher_fullname & "', '" & tdesignation_text.Text & "')"

        Try
            readqueary(insert_teacher)

            Clear_Item()
            clear_table()
            Show_Table()
            
            MsgBox("Update Record")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
         

    End Sub



    Private Sub lrn_btn_Click(sender As Object, e As EventArgs) Handles lrn_btn.Click

        '----------------------------------SEARCH FOR APPLICANT DETAILS-------------------------------------------------------------------
        Dim str As String
        Dim teacher_name As String

        str = "Select teacher_id, teacher_name, teacher_designation from teacher where teacher_id = '" & teacherid_cbdo.Text & "' "

        Try 
            readqueary(str)
            With cmdread
                While .Read

                    teacher_name = .GetValue(1)

                    Dim delimiter As Char = ", "
                    Dim substrings() As String = teacher_name.Split(delimiter)
                      
                    tfname_text.Text = substrings(1).TrimStart()
                    tmname_text.Text = substrings(2).TrimStart()
                    tlname_text.Text = substrings(0).TrimStart()

                    tdesignation_text.Text = .GetValue(2)

                End While
            End With

        Catch ex As Exception

        End Try
        '----------------------------------SEARCH FOR APPLICANT DETAILS-------------------------------------------------------------------

    End Sub
     
    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        Dim teacher_name, teacher_designation As String
        Dim teacher_fullname As String
         
        teacher_fullname = tlname_text.Text + ", " + tfname_text.Text + ", " + tmname_text.Text
         
        teacher_name = "Update teacher set teacher_name = '" & teacher_fullname & "' where teacher_id = '" & teacherid_cbdo.Text & "' "
        teacher_designation = "Update teacher set teacher_designation = '" & tdesignation_text.Text & "' where teacher_id = '" & teacherid_cbdo.Text & "'"


        Try
            readqueary(teacher_name)
            readqueary(teacher_designation) 

            Clear_Item()
            clear_table()
            Show_Table()

            MsgBox("Update Record")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
     
End Class