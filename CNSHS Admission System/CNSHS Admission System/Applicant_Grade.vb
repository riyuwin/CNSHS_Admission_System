Imports MySql.Data.MySqlClient

Public Class Applicant_Grade
    Dim connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnshs_admission_system")
    Dim table As New DataTable()
    Dim adapter As New MySqlDataAdapter("SELECT lrn, requirement_id, name, subject_grade FROM cnshs_admission_system.applicant_grade", connection)

    Dim req_id As String

    Private Sub Applicant_Grade_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Show_Table()
        Search_Load()

    End Sub


    Public Sub Show_Table()

        adapter.Fill(table)

        applicant_grade_dgv.DataSource = table

        applicant_grade_dgv.Columns("lrn").HeaderText = "LRN"
        applicant_grade_dgv.Columns("requirement_id").HeaderText = "Requirement ID"
        applicant_grade_dgv.Columns("name").HeaderText = "Subject Name"
        applicant_grade_dgv.Columns("subject_grade").HeaderText = "Subject Grade"

        applicant_grade_dgv.DefaultCellStyle.Font = New Font("Century Gothic", 8, FontStyle.Regular)

    End Sub

    Public Sub clear_table()

        table.Clear()

    End Sub

    Public Sub Clear_Item() 
        lrn_cbdo.Items.Clear() 
        subject_name_text.Clear()
        subject_grade_text.Clear() 

        Search_Load() 

    End Sub


    Private Sub Search_Load() 

        Dim Applicant As String
        Applicant = "Select lrn from applicant"
        Try
            readqueary(Applicant)
            With cmdread
                While .Read
                    lrn_cbdo.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception

        End Try


    End Sub

    Private Sub lrn_cbdo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lrn_cbdo.SelectedIndexChanged
        Dim str As String
        str = "Select lrn, fname, mname, lname, ext_name, address, contact_num, school_name from applicant where lrn = '" & lrn_cbdo.Text & "' "
        Try
            readqueary(str)
            With cmdread
                While .Read
                    fname_text.Text = .GetValue(1)
                    mname_text.Text = .GetValue(2)
                    lname_text.Text = .GetValue(3)
                    extname_text.Text = .GetValue(4)
                    contact_number_text.Text = .GetValue(5)
                    contact_number_text.Text = .GetValue(6)
                    school_name_text.Text = .GetValue(7)

                End While
            End With
        Catch ex As Exception

        End Try


        ReqList.Items.Clear()

        Dim applicant_grade_str As String


        applicant_grade_str = "Select lrn, requirement_id, name, subject_grade from applicant_grade where lrn = '" & lrn_cbdo.Text & "' "

        Try
            readqueary(applicant_grade_str)
            With cmdread
                While .Read
                    
                    lrn_cbdo.Text = .GetValue(0)
                    subject_name_text.Text = .GetValue(2)
                    subject_grade_text.Text = .GetValue(3)
                End While
            End With
        Catch ex As Exception

        End Try

        'fix this'
        Dim req_str = "Select requirement_id, name, type, gwa from requirements where lrn = '" & lrn_cbdo.Text & "' "

        Try
            readqueary(req_str)
            With cmdread
                While .Read
                    gwa_text.Text = .GetValue(3)
                    req_id = .GetValue(0) 


                    'Splitting the type of requirements' 
                    Dim type As String = .GetValue(2)
                    Dim delimiter As Char = ","
                    Dim substrings As String() = type.Split(delimiter)

                    For Each substring As String In substrings
                        ReqList.Items.Add(substring)
                    Next

                End While
            End With
        Catch ex As Exception

        End Try



    End Sub

     
    Private Sub insert_btn_Click(sender As Object, e As EventArgs) Handles insert_btn.Click
        Dim subject_name, subject_grade As String
        Try

            Dim save = "Insert into applicant_grade  (lrn, requirement_id, name, subject_grade) values ('" & lrn_cbdo.Text & "', '" & req_id & "', '" & subject_name_text.Text & "', '" & subject_grade_text.Text & "')"

            subject_name = "Update applicant_grade set name = '" & subject_name_text.Text & "' where   lrn = '" & lrn_cbdo.Text & "' "
            subject_grade = "Update applicant_grade set subject_grade = '" & subject_grade_text.Text & "' where lrn = '" & lrn_cbdo.Text & "' "

            readqueary(save)

            Clear_Item()
            clear_table()
            Show_Table()

            MsgBox("New Record Added")
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub


    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        Dim subject_name, subject_grade As String
         
        subject_name = "Update applicant_grade set name = '" & subject_grade_text.Text & "' where lrn = '" & lrn_cbdo.Text & "' "
        subject_grade = "Update applicant_grade set subject_grade = '" & subject_name_text.Text & "' where lrn = '" & lrn_cbdo.Text & "' "

        Try
            readqueary(subject_name)
            readqueary(subject_grade)

            Clear_Item()
            clear_table()
            Show_Table()

            MsgBox("Update Record")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Dim applicant As String

        applicant = "Delete from applicant_grade where lrn = '" & lrn_cbdo.Text & "' "

        Try
            readqueary(applicant)
            Clear_Item()
            clear_table()
            Show_Table()
            MsgBox("Delete Record")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class