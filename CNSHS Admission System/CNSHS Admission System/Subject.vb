Imports MySql.Data.MySqlClient

Public Class Subject

    Dim connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnshs_admission_system")
    Dim table As New DataTable()
    Dim adapter As New MySqlDataAdapter("SELECT * FROM cnshs_admission_system.subject", connection)


    Private Sub Subject(sender As Object, e As EventArgs) Handles MyBase.Load

        Show_Table()
        Search_Load()

    End Sub

    Public Sub Show_Table()

        adapter.Fill(table) 

        subject_dgv.DataSource = table

        subject_dgv.Columns("sub_num").HeaderText = "Subject ID"
        subject_dgv.Columns("sub_name").HeaderText = "Subject Name"
        subject_dgv.Columns("sub_instructor").HeaderText = "Subject Instructor"

        subject_dgv.DefaultCellStyle.Font = New Font("Century Gothic", 8, FontStyle.Regular)

    End Sub

    Public Sub clear_table()

        table.Clear()

    End Sub

    Public Sub Clear_Item()
        subid_cbdo.Text = ""
        subname_text.Clear()
        subinstructor_cbdo.Text = ""

        insert_btn.Enabled = True


    End Sub

    Private Sub Search_Load()
        Dim Subject As String
        Subject = "Select sub_num from subject"
        Try
            readqueary(Subject)
            With cmdread
                While .Read
                    subid_cbdo.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception

        End Try

        Dim Teacher As String
        Dim tlname_cbdo_str, tfname_cbdo_str, tmname_cbdo_str


        Teacher = "SELECT teacher_id, teacher_name, teacher_designation FROM teacher"

        Try
            readqueary(Teacher)
            With cmdread
                While .Read
                    Dim Teacher_Name = .GetValue(1)

                    Dim delimiter As Char = ", "
                    Dim substrings() As String = Teacher_Name.Split(delimiter)

                    tfname_cbdo_str = substrings(1).TrimStart()
                    tmname_cbdo_str = substrings(2).TrimStart()
                    tlname_cbdo_str = substrings(0).TrimStart()
                    
                    subinstructor_cbdo.Items.Add(.GetValue(1))

                End While
            End With


        Catch ex As Exception

        End Try

    End Sub
     
     
     
    Private Sub delete_btn_Click(sender As Object, e As EventArgs)
        Dim str As String

        str = "Delete from subject where sub_id = '" & subid_cbdo.Text & "' "

        Try
            readqueary(str)

            Clear_Item()
            clear_table()
            Show_Table()
            MsgBox("Delete Record")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub Subject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub insert_btn_Click_1(sender As Object, e As EventArgs) Handles insert_btn.Click

        Dim str As String

        str = "INSERT INTO subject (sub_name, sub_instructor)" &
            "VALUES ( '" & subname_text.Text & "', '" & subinstructor_cbdo.Text & "')"
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

    Private Sub update_button_Click(sender As Object, e As EventArgs) Handles update_button.Click

        Dim sub_name, sub_instructor As String

        sub_name = "Update subject set sub_name = '" & subname_text.Text & "' where sub_num = '" & subid_cbdo.Text & "' "
        sub_instructor = "Update subject set sub_instructor = '" & subinstructor_cbdo.Text & "' where sub_num = '" & subid_cbdo.Text & "' "


        Try
            readqueary(sub_name)
            readqueary(sub_instructor)


            Clear_Item()
            clear_table()
            Show_Table()

            MsgBox("Update Record")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub



    Private Sub delete_button_Click(sender As Object, e As EventArgs) Handles delete_button.Click
        Dim str As String

        str = "Delete from subject where sub_num = '" & subid_cbdo.Text & "' "

        Try
            readqueary(str)

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
        str = "Select sub_num, sub_name, sub_instructor from subject where sub_num = '" & subid_cbdo.Text & "' "
        Try
            readqueary(str)
            With cmdread
                While .Read
                    subname_text.Text = .GetValue(1)
                    subinstructor_cbdo.Text = .GetValue(2)
                End While
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub subinstructor_cbdo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subinstructor_cbdo.SelectedIndexChanged

    End Sub
End Class