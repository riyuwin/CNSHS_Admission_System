Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Requirement
    Dim connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnshs_admission_system")
    Dim table As New DataTable()
    Dim adapter As New MySqlDataAdapter("SELECT lrn, requirement_id, name, subject_grade FROM cnshs_admission_system.applicant_grade", connection)

    Private Sub Requirements1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Show_Table()
        Search_Load()

    End Sub


    Public Sub Show_Table()

        adapter.Fill(table)

        requirements_dgv.DataSource = table

        requirements_dgv.Columns("lrn").HeaderText = "LRN"
        requirements_dgv.Columns("requirement_id").HeaderText = "Requirement ID"
        requirements_dgv.Columns("name").HeaderText = "Subject Name"
        requirements_dgv.Columns("subject_grade").HeaderText = "Subject Grade"

        requirements_dgv.DefaultCellStyle.Font = New Font("Century Gothic", 8, FontStyle.Regular)

    End Sub

    Public Sub clear_table()

        table.Clear()

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


    Public Sub Clear_Item()
        bcert.Checked = False
        form138.Checked = False
        good_moral.Checked = False
        ncae.Checked = False
        gwa_text.Clear()
        fname_text.Clear()
        mname_text.Clear()
        lname_text.Clear()
        extname_text.Clear()
        address_text.Clear()
        contact_number_text.Clear()
        school_name_text.Clear()
        lrn_text.Clear()

        english_grade_text.Clear()
        science_grade_text.Clear()
        math_grade_text.Clear()

        lrn_cbdo.Items.Clear()

        Search_Load()


    End Sub


    Private Sub lrn_btn_Click(sender As Object, e As EventArgs) Handles lrn_btn.Click

        ReqList.Items.Clear()
        Clear_Item()

        '----------------------------------SEARCH FOR APPLICANT DETAILS-------------------------------------------------------------------
        Dim str As String
        Try
            str = "Select lrn, fname, mname, lname, ext_name, address, contact_num, school_name from applicant where lrn = '" & lrn_cbdo.Text & "' "
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

            '----------------------------------SEARCH FOR APPLICANT DETAILS-------------------------------------------------------------------


            '----------------------------------SEARCH FOR REQUIREMENT DETAILS-------------------------------------------------------------------

            Dim math_grade_str, sci_grade_str, eng_grade_str, requirement_id_str As String
            Dim Math, Sci, Eng As String
            Dim requirement_id As String

            Math = "Mathematics"
            Sci = "Science"
            Eng = "English"

            requirement_id_str = "Select lrn, requirement_id, name, subject_grade from applicant_grade where lrn = '" & lrn_cbdo.Text & "'"
            math_grade_str = "Select lrn, requirement_id, name, subject_grade from applicant_grade where lrn = '" & lrn_cbdo.Text & "' and name ='" & Math & "' "
            sci_grade_str = "Select lrn, requirement_id, name, subject_grade from applicant_grade where lrn = '" & lrn_cbdo.Text & "' and name ='" & Sci & "' "
            eng_grade_str = "Select lrn, requirement_id, name, subject_grade from applicant_grade where lrn = '" & lrn_cbdo.Text & "' and name ='" & Eng & "' "

            Try
                readqueary(math_grade_str)
                With cmdread
                    While .Read
                        requirement_id = .GetValue(1)
                        math_grade_text.Text = .GetValue(3)
                    End While
                End With

                readqueary(sci_grade_str)
                With cmdread
                    While .Read
                        science_grade_text.Text = .GetValue(3)
                    End While
                End With

                readqueary(eng_grade_str)
                With cmdread
                    While .Read
                        english_grade_text.Text = .GetValue(3)
                    End While
                End With

                readqueary(requirement_id_str)
                With cmdread
                    While .Read

                        Dim requ_id As String

                        requ_id = .GetValue(1)


                        Dim requirements_str = "Select requirement_id, name, type, gwa from requirements where requirement_id = '" & requ_id & "'  "

                        readqueary(requirements_str)
                        With cmdread
                            While .Read

                                gwa_text.Text = .GetValue(3)

                                'Splitting the type of requirements' 
                                Dim type As String = .GetValue(2)
                                Dim delimiter As Char = ","
                                Dim substrings As String() = type.Split(delimiter)

                                For Each substring As String In substrings
                                    ReqList.Items.Add(substring)
                                    If substring = "Birth Certificate" Then
                                        bcert.Checked = True
                                    End If
                                    If substring = "Form 138" Then
                                        form138.Checked = True
                                    End If
                                    If substring = "Good Moral" Then
                                        good_moral.Checked = True
                                    End If
                                    If substring = "NCAE" Then
                                        ncae.Checked = True
                                    End If
                                Next

                            End While
                        End With

                    End While
                End With

                '----------------------------------SEARCH FOR REQUIREMENT DETAILS-------------------------------------------------------------------

            Catch ex As Exception

            End Try


        Catch ex As Exception

        End Try


    End Sub


    Private Sub insert_btn_Click(sender As Object, e As EventArgs) Handles insert_btn.Click
        ReqList.Items.Clear()

        Try
            Dim checks = {bcert, form138, good_moral, ncae}
            Dim requirements_type As New List(Of String)
            Dim subject_name As New List(Of String)
            Dim subject_grade As New List(Of String)
            Dim lastThreeIDsReqId As New List(Of Integer)()


            'checking if the other btn is not empty'
            If Not String.IsNullOrEmpty(english_grade_text.Text) Then
                subject_name.Add("English")
                subject_grade.Add(english_grade_text.Text)
            End If
            If Not String.IsNullOrEmpty(science_grade_text.Text) Then
                subject_name.Add("Science")
                subject_grade.Add(science_grade_text.Text)
            End If
            If Not String.IsNullOrEmpty(math_grade_text.Text) Then
                subject_name.Add("Mathematics")
                subject_grade.Add(math_grade_text.Text)
            End If

            '------------------------ GETTING THE DATA OF ALL CHECKBOXES THAT ARE CHECKED ---------------------------------
            For Each type In checks
                If type.Checked Then
                    requirements_type.Add(type.Text)
                    ReqList.Items.Add(type.Text)

                End If
            Next

            Dim value = String.Join(",", requirements_type.ToArray)
            Dim subject_grade_value = String.Join(",", subject_grade.ToArray)
            Dim requirement_ids As New List(Of String)

            'inserting the requirements first
            For Each sub_name In subject_name
                Dim save = "Insert into requirements (name, type, gwa) values ('" & sub_name & "', '" & value & "', '" & gwa_text.Text & "')"
                readqueary(save)
            Next


            'retrieving the last three subject name and grade entered
            Dim retrieve_reqid = "SELECT requirement_id " &
                          "FROM requirements " &
                          "ORDER BY requirement_id DESC " &
                          "LIMIT 3"

            Using connection As New MySqlConnection(strconn)
                connection.Open()

                Using command As New MySqlCommand(retrieve_reqid, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim id As Integer = Convert.ToInt32(reader("requirement_id"))
                            lastThreeIDsReqId.Add(id)
                        End While
                    End Using
                End Using
            End Using


            '----------------------------------ZIPPING AND UNZIPPING SUBJECT NAMES FOR REQUIREMENTS-------------------------------------------------------------------

            Dim SubInfozippedList = subject_name.Zip(subject_grade, Function(a, b) New With {a, b}).Zip(lastThreeIDsReqId, Function(ab, c) New With {ab.a, ab.b, c})

            For Each item In SubInfozippedList

                Dim name_of_subject As String = item.a
                Dim sub_grade As Integer = item.b
                Dim requirement_id As Integer = item.c

                Dim applicant_grade = "Insert into applicant_grade (lrn, requirement_id, name, subject_grade) values ('" & lrn_cbdo.Text & "', '" & requirement_id & "', '" & name_of_subject & "', '" & sub_grade & "')"
                readqueary(applicant_grade)

            Next

            Clear_Item()
            clear_table()
            Show_Table()

            MsgBox("New Record Added")
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        Dim english_grade, sci_grade, math_grade, gwa As String
        Dim lastThreeIDsReqId As New List(Of Integer)()

        Dim checks = {bcert, form138, good_moral, ncae}
        Dim requirements_type As New List(Of String) 

        'Retrieve the requirement ids
        Dim retrieve_reqid = "SELECT requirement_id from applicant_grade where lrn = '" & lrn_cbdo.Text & "'"
        readqueary(retrieve_reqid)
        With cmdread
            While .Read
                lastThreeIDsReqId.Add(.GetValue(0))
            End While
        End With
         
        Dim english_var = "English"
        Dim science_var = "Science"
        Dim math_var = "Mathematics"

        english_grade = "Update applicant_grade set subject_grade = '" & english_grade_text.Text & "' where lrn = '" & lrn_cbdo.Text & "' and name = '" & english_var & "' "
        sci_grade = "Update applicant_grade set subject_grade = '" & science_grade_text.Text & "' where lrn = '" & lrn_cbdo.Text & "' and name = '" & science_var & "'"
        math_grade = "Update applicant_grade set subject_grade = '" & science_grade_text.Text & "' where lrn = '" & lrn_cbdo.Text & "' and name = '" & math_var & "'"
        
        Try
            readqueary(english_grade)
            readqueary(sci_grade)
            readqueary(math_grade)

            '--------------------------UPDATING REQUIREMENT TYPES -------------------------------------
            For Each type In checks
                If type.Checked Then
                    requirements_type.Add(type.Text)
                    ReqList.Items.Add(type.Text)

                End If
            Next

            Dim value = String.Join(",", requirements_type.ToArray)

            '---------------------------UPDATING GWA -----------------------------------------------
            For Each Req_Id In lastThreeIDsReqId
                gwa = "Update requirements set gwa = '" & gwa_text.Text & "' where requirement_id = '" & Req_Id & "' "
                readqueary(gwa) 


                Dim requirements = "Update requirements set type = '" & value & "' where requirement_id = '" & Req_Id & "' "
                readqueary(requirements)

            Next
             

            '------------------------REFRESH --------------------------

            Clear_Item()
            clear_table()
            Show_Table()
            MsgBox("Update Record")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Dim Applicant_Grade, Requirements As String

        Dim lastThreeIDsReqId As New List(Of Integer)()

        Dim checks = {bcert, form138, good_moral, ncae}
        Dim requirements_type As New List(Of String)

        'Retrieve the requirement ids
        Dim retrieve_reqid = "SELECT requirement_id from applicant_grade where lrn = '" & lrn_cbdo.Text & "'"
        readqueary(retrieve_reqid)
        With cmdread
            While .Read
                lastThreeIDsReqId.Add(.GetValue(0))
            End While
        End With



        Try
            '---------------------------UPDATING GWA -----------------------------------------------
            For Each Req_Id In lastThreeIDsReqId
                Applicant_Grade = "Delete from applicant_grade where lrn = '" & lrn_cbdo.Text & "' "
                Requirements = "Delete from requirements where requirement_id = '" & Req_Id & "' "

                readqueary(Applicant_Grade)
                readqueary(Requirements)

            Next

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