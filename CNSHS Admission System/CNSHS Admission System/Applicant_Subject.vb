Imports MySql.Data.MySqlClient

Public Class Applicant_Subject

    Dim connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnshs_admission_system")
    Dim table As New DataTable()
    Dim adapter As New MySqlDataAdapter("SELECT * FROM cnshs_admission_system.applicant_subject", connection)

    Private Sub Applicant_Subject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_Table()
        Search_Load()

    End Sub
     
    Public Sub Show_Table()

        adapter.Fill(table)

        subject_dgv.DataSource = table

        subject_dgv.Columns("lrn").HeaderText = "LRN"
        subject_dgv.Columns("sub_num").HeaderText = "Subject ID"
        subject_dgv.Columns("schedule").HeaderText = "Schedule"
        subject_dgv.Columns("subject_grade").HeaderText = "Subject Grade"
        subject_dgv.Columns("acad_year").HeaderText = "Academic Year"

        subject_dgv.DefaultCellStyle.Font = New Font("Century Gothic", 8, FontStyle.Regular)
    End Sub

    Public Sub clear_table()

        table.Clear()

    End Sub

    Public Sub Clear_Item()
        subjectid_cbdo.Text = ""
        subinstructor_text.Clear()
        time_picker.Value = time_picker.Value.Date
        subgrade_text.Clear()
        acadyear_text.Clear()
        fname_text.Clear()
        mname_text.Clear()
        lname_text.Clear()
        extname_text.Clear()
        address_text.Clear()
        contact_number_text.Clear()
        school_name_text.Clear()
        lrn_text.Clear()
        subid_cbdo.Text = ""
        subject_name_text.Clear()

        insert_btn.Enabled = True


    End Sub

    Private Sub Search_Load()
        Dim str As String
        str = "Select distinct lrn from applicant"
        Try
            readqueary(str)
            With cmdread
                While .Read
                    subid_cbdo.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception

        End Try

        Dim subject_str As String
        subject_str = "Select distinct sub_num from subject"
        Try
            readqueary(subject_str)
            With cmdread
                While .Read
                    subjectid_cbdo.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception

        End Try

    End Sub


    Private Sub insert_btn_Click(sender As Object, e As EventArgs) Handles insert_btn.Click
        Dim str As String

        Dim startTime As String

        startTime = time_picker.Value.ToString("HH:mm:ss")

        str = "INSERT INTO applicant_subject (lrn, sub_num, schedule, subject_grade, acad_year)" &
            "VALUES ('" & lrn_text.Text & "', '" & subjectid_cbdo.Text & "', '" & startTime & "', '" & subgrade_text.Text & "', '" & acadyear_text.Text & "')"
        Try
            readqueary(str)
            Clear_Item()
            clear_table()
            Show_Table()
            MsgBox("New Record Added")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub subname_cbdo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subjectid_cbdo.SelectedIndexChanged
        Dim str As String
        str = "Select sub_num, sub_name, sub_instructor from subject where sub_num = '" & subjectid_cbdo.Text & "' "
        Try
            readqueary(str)
            With cmdread
                While .Read
                    subject_name_text.Text = .GetValue(1)
                    subinstructor_text.Text = .GetValue(2)
                End While
            End With
        Catch ex As Exception

        End Try


    End Sub

    Private Sub exam_id_btn_Click(sender As Object, e As EventArgs) Handles exam_id_btn.Click 
        '----------------------------------SEARCH FOR APPLICANT DETAILS-------------------------------------------------------------------
        Dim str As String
        Try
            str = "Select lrn, fname, mname, lname, ext_name, address, contact_num, school_name from applicant where lrn = '" & subid_cbdo.Text & "' "
            Dim applicant_sub_str = "Select lrn, sub_num, schedule, subject_grade, acad_year from applicant_subject where lrn = '" & subid_cbdo.Text & "' "
            Try
                readqueary(str)
                With cmdread
                    While .Read

                        lrn_text.Text = .GetValue(0)
                        fname_text.Text = .GetValue(1)
                        mname_text.Text = .GetValue(2)
                        lname_text.Text = .GetValue(3)
                        extname_text.Text = .GetValue(4)
                        address_text.Text = .GetValue(5)
                        contact_number_text.Text = .GetValue(6)
                        school_name_text.Text = .GetValue(7)

                    End While
                End With

                Try
                    readqueary(applicant_sub_str)
                    With cmdread
                        While .Read

                            subjectid_cbdo.Text = .GetValue(1)
                            acadyear_text.Text = .GetValue(4)
                            subgrade_text.Text = .GetValue(3)

                            Dim get_sub = "Select sub_num, sub_name, sub_instructor from subject where sub_num = '" & .GetValue(1) & "'"
                            Try
                                readqueary(get_sub)
                                With cmdread
                                    While .Read
                                        subject_name_text.Text = .GetValue(1)
                                    End While
                                End With
                            Catch ex As Exception

                            End Try




                        End While
                    End With

                Catch ex As Exception

                End Try

                '----------------------------------SEARCH FOR APPLICANT DETAILS-------------------------------------------------------------------

            Catch ex As Exception

            End Try

        Catch ex As Exception

        End Try


        Dim get_time = "SELECT TIME_FORMAT(schedule, '%h:%i %p') AS formatted_time FROM applicant_subject where lrn = '" & subid_cbdo.Text & "' "
        Try
            readqueary(get_time)
            With cmdread
                While .Read
                    time_picker.Text = .GetValue(0)
                End While
            End With
        Catch ex As Exception

        End Try


        Dim applicant_subject_str = "Select lrn, sub_num, schedule, subject_grade, acad_year from applicant_subject where lrn = '" & subid_cbdo.Text & "' "

        Try
            readqueary(applicant_subject_str)
            With cmdread
                While .Read

                    subgrade_text.Text = .GetValue(3)
                    acadyear_text.Text = .GetValue(4)

                End While
            End With

        Catch ex As Exception

        End Try

    End Sub

    Private Sub update_button_Click(sender As Object, e As EventArgs) Handles update_button.Click

        Dim startTime As String

        startTime = time_picker.Value.ToString("HH:mm:ss")

        Dim time_picker_str = "Update applicant_subject set schedule = '" & startTime & "' where lrn = '" & subid_cbdo.Text & "' "
        Dim subject_grade_str = "Update applicant_subject set subject_grade = '" & subgrade_text.Text & "' where lrn = '" & subid_cbdo.Text & "' "
        Dim acad_year = "Update applicant_subject set acad_year = '" & acadyear_text.Text & "' where lrn = '" & subid_cbdo.Text & "' "

        Try
            readqueary(time_picker_str)
            readqueary(subject_grade_str)
            readqueary(acad_year)

            Clear_Item()
            clear_table()
            Show_Table()
            MsgBox("Update Record")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub delete_button_Click(sender As Object, e As EventArgs) Handles delete_button.Click
        Dim exam = "Delete from applicant_subject where lrn = '" & subid_cbdo.Text & "' and sub_num = '" & subjectid_cbdo.Text & "' "

        Try
            readqueary(exam)

            Clear_Item()
            clear_table()
            Show_Table()
            MsgBox("Delete Record")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class