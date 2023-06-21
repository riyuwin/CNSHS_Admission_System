Imports MySql.Data.MySqlClient

Public Class Section

    Dim connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnshs_admission_system")
    Dim table As New DataTable()
    Dim adapter As New MySqlDataAdapter("SELECT * FROM cnshs_admission_system.section", connection)


    Private Sub Section_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Show_Table()
        Search_Load()

    End Sub


    Public Sub Show_Table()

        adapter.Fill(table)

        section_dgv.DataSource = table

        section_dgv.Columns("section_id").HeaderText = "Section ID"
        section_dgv.Columns("section_name").HeaderText = "Section Name"
        section_dgv.Columns("room_num").HeaderText = "Room"
        section_dgv.Columns("grade_level").HeaderText = "Grade Level"

        section_dgv.DefaultCellStyle.Font = New Font("Century Gothic", 8, FontStyle.Regular)
    End Sub

    Public Sub clear_table()

        table.Clear()

    End Sub

    Public Sub Clear_Item()
        sectionid_cbdo.Text = ""
        secname_text.Clear()
        roomnum_text.Clear()
        gradelevel_text.Clear()


        insert_btn.Enabled = True


    End Sub
     
    Private Sub Search_Load()
        Dim str As String
        str = "Select section_id from section"
        Try
            readqueary(str)
            With cmdread
                While .Read
                    sectionid_cbdo.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception

        End Try
    End Sub


    Private Sub sectionid_cbdo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sectionid_cbdo.SelectedIndexChanged
        
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs)

        Dim secname, room_num, gradelevel As String

        secname = "Update section set section_name = '" & secname_text.Text & "' where section_id = '" & sectionid_cbdo.Text & "' "
        room_num = "Update section set room_num = '" & roomnum_text.Text & "' where section_id = '" & sectionid_cbdo.Text & "' "
        gradelevel = "Update section set grade_level = '" & gradelevel_text.Text & "' where section_id = '" & sectionid_cbdo.Text & "' "


        Try
            readqueary(secname)
            readqueary(room_num)
            readqueary(gradelevel)

            Clear_Item()
            clear_table()
            Show_Table()

            MsgBox("Update Record")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim str As String

        str = "Delete from section where section_id = '" & sectionid_cbdo.Text & "' "

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

    Private Sub insert_btn_Click_1(sender As Object, e As EventArgs) Handles insert_btn.Click
        Dim str As String

        str = "INSERT INTO section (section_name, room_num, grade_level)" &
            "VALUES ('" & secname_text.Text & "', '" & roomnum_text.Text & "', '" & gradelevel_text.Text & "')"
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

        Dim secname, room_num, gradelevel As String

        secname = "Update section set section_name = '" & secname_text.Text & "' where section_id = '" & sectionid_cbdo.Text & "' "
        room_num = "Update section set room_num = '" & roomnum_text.Text & "' where section_id = '" & sectionid_cbdo.Text & "' "
        gradelevel = "Update section set grade_level = '" & gradelevel_text.Text & "' where section_id = '" & sectionid_cbdo.Text & "' "


        Try
            readqueary(secname)
            readqueary(room_num)
            readqueary(gradelevel)

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

        str = "Delete from section where section_id = '" & sectionid_cbdo.Text & "' "

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

    Private Sub exam_id_btn_Click(sender As Object, e As EventArgs)
        Dim str As String
        str = "Select section_id, section_name, room_num, grade_level from section where section_id = '" & sectionid_cbdo.Text & "' "

        Try
            readqueary(str)
            With cmdread
                While .Read
                    secname_text.Text = .GetValue(1)
                    roomnum_text.Text = .GetValue(2)
                    gradelevel_text.Text = .GetValue(3)

                End While
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class