Imports MySql.Data.MySqlClient

Public Class Applicant_Exam


    Dim connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnshs_admission_system")
    Dim table As New DataTable()
    Dim adapter As New MySqlDataAdapter("SELECT * FROM cnshs_admission_system.exam_result", connection)

    Private Sub Applicant_Exam(sender As Object, e As EventArgs) Handles MyBase.Load

        Show_Table()
        Search_Load()

    End Sub

    Public Sub Show_Table()

        adapter.Fill(table)

        applicant_exam_dgv.DataSource = table

        applicant_exam_dgv.Columns("lrn").HeaderText = "LRN"
        applicant_exam_dgv.Columns("exam_id").HeaderText = "Exam ID"
        applicant_exam_dgv.Columns("exam_sub").HeaderText = "Subject"
        applicant_exam_dgv.Columns("result").HeaderText = "Result"

        applicant_exam_dgv.DefaultCellStyle.Font = New Font("Century Gothic", 8, FontStyle.Regular)

    End Sub

    Public Sub clear_table()

        table.Clear()

    End Sub



    Public Sub Clear_Item()
        lrn_text.Clear()
        fname_text.Clear()
        mname_text.Clear()
        lname_text.Clear()
        extname_text.Clear()
        address_text.Clear()
        contact_number_text.Clear()
        school_name_text.Clear()

        examid_cbdo.Text = ""
        lrn_cbdo.Text = ""
        exam_sub_text.Clear()
        room_text.Clear()
        result_txt.Clear()

        insert_btn.Enabled = True


        Search_Load()

    End Sub

    Private Sub Search_Load()
        Dim Applicant As String
        Dim Applicant_Exam As String

        Applicant = "Select lrn from applicant"
        Applicant_Exam = "Select exam_id from exam_result"

        Try
            readqueary(Applicant)
            With cmdread
                While .Read
                    lrn_cbdo.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception

        End Try

        Applicant_Exam = "Select exam_id from exam"
        Try
            readqueary(Applicant_Exam)
            With cmdread
                While .Read
                    examid_cbdo.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lrn_cbdo_SelectedIndexChanged(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub examid_cbdo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles examid_cbdo.SelectedIndexChanged
        Dim str As String
        Dim startDate, startTime, get_time As String

        startDate = date_picker.Value.ToString("yyyy/MM/dd")
        startTime = time_picker.Value.ToString("HH:mm:ss")

        str = "Select exam_id, exam_sub, room, date, time from exam where exam_id = '" & examid_cbdo.Text & "' "
        get_time = "SELECT TIME_FORMAT(time, '%h:%i %p') AS formatted_time FROM exam where exam_id = '" & examid_cbdo.Text & "' "
        Try
            readqueary(str)
            With cmdread
                While .Read
                    exam_sub_text.Text = .GetValue(1)
                    room_text.Text = .GetValue(2)
                    date_picker.Text = .GetValue(3)
                     

                End While
            End With
        Catch ex As Exception

        End Try

        Try
            readqueary(get_time)
            With cmdread
                While .Read
                    time_picker.Text = .GetValue(0) 
                End While
            End With
        Catch ex As Exception

        End Try

    End Sub
     
     
    Private Sub insert_btn_Click(sender As Object, e As EventArgs) Handles insert_btn.Click
        Dim Exam_Result As String

        Exam_Result = "INSERT INTO exam_result (LRN, exam_id, exam_sub, result)" & "VALUES ('" & lrn_cbdo.Text & "', '" & examid_cbdo.Text & "', '" & exam_sub_text.Text & "', '" & result_txt.Text & "')"

        Try
            readqueary(Exam_Result)
            Clear_Item()
            clear_table()
            Show_Table()
            MsgBox("New Record Added")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        Dim exam_sub, exam_result As String

        exam_sub = "Update exam_result set exam_sub = '" & exam_sub_text.Text & "' where lrn = '" & lrn_cbdo.Text & "' and exam_id = '" & examid_cbdo.Text & "'  "
        exam_result = "Update exam_result set result = '" & result_txt.Text & "' where lrn = '" & lrn_cbdo.Text & "' and exam_id = '" & examid_cbdo.Text & "'  "

        Try
            readqueary(exam_sub)
            readqueary(exam_result)
            Clear_Item()
            clear_table()
            Show_Table()
            MsgBox("Update Record")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub delete_btn_Click_1(sender As Object, e As EventArgs) Handles delete_btn.Click
        Dim Exam_Result As String

        Exam_Result = "Delete from exam_result where lrn = '" & lrn_cbdo.Text & "' and exam_id = '" & examid_cbdo.Text & "' "

        Try
            readqueary(Exam_Result)
            Clear_Item()
            clear_table()
            Show_Table()
            MsgBox("Delete Record")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub lrn_btn_Click(sender As Object, e As EventArgs) Handles lrn_btn.Click
        Dim str As String
        str = "Select lrn, fname, mname, lname, ext_name, address, contact_num, school_name from applicant where lrn = '" & lrn_cbdo.Text & "' "
        Dim Retireve_Applicant_Exam = "Select lrn, exam_id, exam_sub, result from exam_result where lrn = '" & lrn_cbdo.Text & "' "

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
        Catch ex As Exception

        End Try

    End Sub

    Private Sub lrn_cbdo_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lrn_cbdo.SelectedIndexChanged

    End Sub
End Class