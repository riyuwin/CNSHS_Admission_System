Imports MySql.Data.MySqlClient
Public Class Exam
    Dim connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnshs_admission_system")
    Dim table As New DataTable()
    Dim adapter As New MySqlDataAdapter("SELECT exam_id, exam_sub, room, date, time FROM cnshs_admission_system.exam", connection)

    Private Sub Exam(sender As Object, e As EventArgs) Handles MyBase.Load

        Show_Table()
        Search_Load()

    End Sub
     


    Public Sub Show_Table()

        adapter.Fill(table)

        exam_dgv.DataSource = table

        exam_dgv.Columns("exam_id").HeaderText = "Exam ID"
        exam_dgv.Columns("exam_sub").HeaderText = "Exam Subject"
        exam_dgv.Columns("room").HeaderText = "Room"
        exam_dgv.Columns("date").HeaderText = "Date"
        exam_dgv.Columns("time").HeaderText = "Time"

        exam_dgv.DefaultCellStyle.Font = New Font("Century Gothic", 8, FontStyle.Regular)

    End Sub

    Public Sub clear_table()

        table.Clear()

    End Sub



    Public Sub Clear_Item()
        examsub_text.Clear()
        room_text.Clear() 
        date_picker.Value = DateTimePicker.MinimumDateTime
        time_picker.Value = time_picker.Value.Date

        examid_cbdo.Items.Clear()

        Search_Load()


    End Sub



    Private Sub insert_btn_Click(sender As Object, e As EventArgs)
        Dim str As String
        Dim startDate, startTime As String

        startDate = date_picker.Value.ToString("yyyy/MM/dd")
        startTime = time_picker.Value.ToString("HH:mm:ss")

        str = "INSERT INTO exam (exam_id, exam_sub, room, date, time)" &
            "VALUES ('" & examid_cbdo.Text & "', '" & examsub_text.Text & "', '" & room_text.Text & "', '" & startDate & "', '" & startTime & "')"
        Try
            readqueary(str)
            MsgBox("New Record Added")

            Clear_Item()
            clear_table()
            Show_Table()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Search_Load()
        Dim Applicant As String
        Applicant = "Select exam_id from exam"
        Try
            readqueary(Applicant)
            With cmdread
                While .Read
                    examid_cbdo.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub examid_cbdo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles examid_cbdo.SelectedIndexChanged

    End Sub
     
    Private Sub update_button_Click(sender As Object, e As EventArgs) Handles update_button.Click
        Dim exam_id, exam_sub, room, exam_date, exam_time As String

        Dim startDate, startTime As String

        startDate = date_picker.Value.ToString("yyyy/MM/dd")
        startTime = time_picker.Value.ToString("HH:mm:ss")

        exam_id = "Update exam set exam_id = '" & examid_cbdo.Text & "' where exam_id = '" & examid_cbdo.Text & "' "
        exam_sub = "Update exam set exam_sub = '" & examsub_text.Text & "' where exam_id = '" & examid_cbdo.Text & "' "
        room = "Update exam set room = '" & room_text.Text & "' where exam_id = '" & examid_cbdo.Text & "' "
        exam_date = "Update exam set date = '" & startDate & "' where exam_id = '" & examid_cbdo.Text & "' "
        exam_time = "Update exam set time = '" & startTime & "' where exam_id = '" & examid_cbdo.Text & "' "

        Try
            readqueary(exam_id)
            readqueary(exam_sub)
            readqueary(room)
            readqueary(exam_date)
            readqueary(exam_time)

            Clear_Item()
            clear_table()
            Show_Table()
            MsgBox("Update Record")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
     
    Private Sub delete_button_Click(sender As Object, e As EventArgs) Handles delete_button.Click
        Dim exam As String

        exam = "Delete from exam where exam_id = '" & examid_cbdo.Text & "' "

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



    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Private Sub exam_id_btn_Click(sender As Object, e As EventArgs) Handles exam_id_btn.Click
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
                    examsub_text.Text = .GetValue(1)
                    room_text.Text = .GetValue(2)
                    date_picker.Text = .GetValue(3)
                    time_picker.Text = .GetValue(4)

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str As String
        Dim startDate, startTime As String

        startDate = date_picker.Value.ToString("yyyy/MM/dd")
        startTime = time_picker.Value.ToString("HH:mm:ss")

        str = "INSERT INTO exam (exam_id, exam_sub, room, date, time)" &
            "VALUES ('" & examid_cbdo.Text & "', '" & examsub_text.Text & "', '" & room_text.Text & "', '" & startDate & "', '" & startTime & "')"
        Try
            readqueary(str)
            MsgBox("New Record Added")

            Clear_Item()
            clear_table()
            Show_Table()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub examsub_text_TextChanged(sender As Object, e As EventArgs) Handles examsub_text.TextChanged

    End Sub
End Class