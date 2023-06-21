Imports MySql.Data.MySqlClient

Public Class Applicant_Acad_Year
    Dim connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnshs_admission_system")
    Dim table As New DataTable()
    Dim adapter As New MySqlDataAdapter("SELECT * FROM cnshs_admission_system.applicant_acad_year", connection)

    Private Sub Applicant_Acad_Year_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_Table()
        Search_Load()
    End Sub


    Public Sub Show_Table()

        adapter.Fill(table)

        section_dgv.DataSource = table

        section_dgv.Columns("lrn").HeaderText = "LRN"
        section_dgv.Columns("section_id").HeaderText = "Section ID"
        section_dgv.Columns("acad_year").HeaderText = "Academic Year" 

        section_dgv.DefaultCellStyle.Font = New Font("Century Gothic", 8, FontStyle.Regular)
    End Sub

    Public Sub clear_table()

        table.Clear()

    End Sub

    Public Sub Clear_Item()
        lrn_cbdo.Text = ""
        section_cbdo.Text = ""
        roomnum_text.Clear()
        gradelevel_text.Clear()
        acad_year_text.Text = "" 
        fname_text.Clear()
        mname_text.Clear()
        lname_text.Clear()
        extname_text.Clear()
        address_text.Clear()
        contact_number_text.Clear()
        school_name_text.Clear()
        lrn_text.Clear()

        insert_btn.Enabled = True


    End Sub

    Private Sub Search_Load()
        Dim str As String 
         
        Dim applicant_str As String
        applicant_str = "Select lrn from applicant"
        Try
            readqueary(applicant_str)
            With cmdread
                While .Read
                    lrn_cbdo.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception

        End Try
         
        Dim section_str = "Select section_id from section"
        Try
            readqueary(section_str)
            With cmdread
                While .Read
                    section_cbdo.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception

        End Try

    End Sub

     
    Private Sub exam_id_btn_Click(sender As Object, e As EventArgs) Handles exam_id_btn.Click
        '----------------------------------SEARCH FOR APPLICANT DETAILS-------------------------------------------------------------------
        Dim str As String
        Try
            str = "Select lrn, fname, mname, lname, ext_name, address, contact_num, school_name from applicant where lrn = '" & lrn_cbdo.Text & "' "
            Dim applicant_acad_year_str = "Select lrn, section_id, acad_year from applicant_acad_year where lrn = '" & lrn_cbdo.Text & "' "
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
                    readqueary(applicant_acad_year_str)
                    With cmdread
                        While .Read

                            acad_year_text.Text = .GetValue(2)

                            Dim applicant_acad_year = "Select section_id, section_name, room_num, grade_level from section where section_id = '" & .GetValue(1) & "' "
                            readqueary(applicant_acad_year)
                            With cmdread
                                While .Read
                                    section_cbdo.Text = .GetValue(0)
                                    sec_name_text.Text = .GetValue(1)
                                    roomnum_text.Text = .GetValue(2)
                                    gradelevel_text.Text = .GetValue(3)
                                End While
                            End With

                        End While
                    End With

                Catch ex As Exception

                End Try

                '----------------------------------SEARCH FOR APPLICANT DETAILS-------------------------------------------------------------------

            Catch ex As Exception

            End Try

        Catch ex As Exception

        End Try

    End Sub

    Private Sub insert_btn_Click(sender As Object, e As EventArgs) Handles insert_btn.Click
        Dim Academic_Year_str = "INSERT INTO applicant_acad_year (LRN, section_id, acad_year)" & "VALUES ('" & lrn_cbdo.Text & "', '" & section_cbdo.Text & "', '" & acad_year_text.Text & "')"

        Try
            readqueary(Academic_Year_str)
            Clear_Item()
            clear_table()
            Show_Table()
            MsgBox("New Record Added")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try



    End Sub

    Private Sub section_cbdo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles section_cbdo.SelectedIndexChanged
        '----------------------------------SEARCH FOR APPLICANT DETAILS-------------------------------------------------------------------


        Dim str As String
        Try


            'str = "Select lrn, fname, mname, lname, ext_name, address, contact_num, school_name from applicant where lrn = '" & lrn_cbdo.Text & "' "
            Dim applicant_acad_year_str = "Select section_id, section_name, room_num, grade_level from section where section_id = '" & section_cbdo.Text & "'"
            Try
                readqueary(applicant_acad_year_str)
                With cmdread
                    While .Read

                        section_cbdo.Text = .GetValue(0)
                        sec_name_text.Text = .GetValue(1)
                        roomnum_text.Text = .GetValue(2)
                        gradelevel_text.Text = .GetValue(3)

                    End While
                End With

            Catch ex As Exception

            End Try

        Catch ex As Exception

        End Try

    End Sub

    Private Sub update_button_Click(sender As Object, e As EventArgs) Handles update_button.Click

        Dim acad_year = "Update applicant_acad_year set acad_year = '" & acad_year_text.Text & "' where section_id = '" & section_cbdo.Text & "' "

        Try
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
        Dim exam = "Delete from applicant_acad_year where lrn = '" & lrn_cbdo.Text & "' and section_id = '" & section_cbdo.Text & "' "

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

    Private Sub lrn_cbdo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lrn_cbdo.SelectedIndexChanged

    End Sub
End Class