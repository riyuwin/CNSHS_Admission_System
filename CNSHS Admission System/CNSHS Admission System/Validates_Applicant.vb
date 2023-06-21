Imports MySql.Data.MySqlClient

Public Class Validates_Applicant
    Dim connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnshs_admission_system")
    Dim table As New DataTable()
    Dim adapter As New MySqlDataAdapter("SELECT teacher_id, requirement_id, remarks FROM cnshs_admission_system.validates_applicant", connection)
     
    Private Sub Validates_Applicant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Show_Table()
        Search_Load()

    End Sub


    Public Sub Show_Table()

        adapter.Fill(table)

        validates_applicant_dgv.DataSource = table

        validates_applicant_dgv.Columns("teacher_id").HeaderText = "Teacher ID"
        validates_applicant_dgv.Columns("requirement_id").HeaderText = "Requirement ID"
        validates_applicant_dgv.Columns("remarks").HeaderText = "Remarks"

        validates_applicant_dgv.DefaultCellStyle.Font = New Font("Century Gothic", 8, FontStyle.Regular)

    End Sub

    Public Sub clear_table()

        table.Clear()

    End Sub


    Public Sub Clear_Item()
        lrn_combobox.Text = ""
        english_grade_text.Clear()
        science_grade_text.Clear()
        math_grade_text.Clear()
        gwa_text.Clear()
         

        teacher_id_txt.Clear()
        tfname_cbdo.Text = ""
        tmname_cbdo.Text = ""
        tlname_cbdo.Text = ""
        tdesignation_text.Text = ""
        eng_remarks_cbdo.Text = ""
        sci_remarks_cbdo.Text = ""
        math_remarks_cbdo.Text = ""

        Search_Load()


    End Sub



    Private Sub Search_Load()
        Dim Teacher As String
        Dim tlname_cbdo_str, tfname_cbdo_str, tmname_cbdo_str

        Teacher = "Select teacher_name from teacher"
        Try
            readqueary(Teacher)
            With cmdread
                While .Read

                    Dim Teacher_Name = .GetValue(0)

                    Dim delimiter As Char = ", "
                    Dim substrings() As String = Teacher_Name.Split(delimiter)

                    tfname_cbdo_str = substrings(1).TrimStart()
                    tmname_cbdo_str = substrings(2).TrimStart()
                    tlname_cbdo_str = substrings(0).TrimStart()

                    tfname_cbdo.Items.Add(tfname_cbdo_str)
                    tmname_cbdo.Items.Add(tmname_cbdo_str)
                    tlname_cbdo.Items.Add(tlname_cbdo_str)

                End While
            End With
        Catch ex As Exception

        End Try


        Teacher = "Select distinct lrn from applicant_grade"
        Try
            readqueary(Teacher)
            With cmdread
                While .Read 
                    lrn_combobox.Items.Add(.GetValue(0))
                End While
            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tfname_cbdo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tfname_cbdo.SelectedIndexChanged
        Dim Teacher As String
        Dim tlname_cbdo_str, tfname_cbdo_str, tmname_cbdo_str


        Teacher = "SELECT teacher_id, teacher_name, teacher_designation FROM teacher WHERE teacher_name LIKE '%" & tfname_cbdo.Text & "%'"

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

                    teacher_id_txt.Text = .GetValue(0)
                    tfname_cbdo.Text = tfname_cbdo_str
                    tmname_cbdo.Text = tmname_cbdo_str
                    tlname_cbdo.Text = tlname_cbdo_str
                    tdesignation_text.Text = .GetValue(2)

                End While
            End With


            Catch ex As Exception

            End Try

    End Sub

    Private Sub tmname_cbdo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tmname_cbdo.SelectedIndexChanged
        Dim Teacher As String
        Dim tlname_cbdo_str, tfname_cbdo_str, tmname_cbdo_str

        Teacher = "SELECT teacher_id, teacher_name, teacher_designation FROM teacher WHERE teacher_name LIKE '%" & tmname_cbdo.Text & "%'"

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

                    teacher_id_txt.Text = .GetValue(0)
                    tfname_cbdo.Text = tfname_cbdo_str
                    tmname_cbdo.Text = tmname_cbdo_str
                    tlname_cbdo.Text = tlname_cbdo_str
                    tdesignation_text.Text = .GetValue(2)

                End While
            End With


        Catch ex As Exception

        End Try

    End Sub

    Private Sub tlname_cbdo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tlname_cbdo.SelectedIndexChanged
        Dim Teacher As String
        Dim tlname_cbdo_str, tfname_cbdo_str, tmname_cbdo_str

        Teacher = "SELECT teacher_id, teacher_name, teacher_designation FROM teacher WHERE teacher_name LIKE '%" & tlname_cbdo.Text & "%'"

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

                    teacher_id_txt.Text = .GetValue(0)
                    tfname_cbdo.Text = tfname_cbdo_str
                    tmname_cbdo.Text = tmname_cbdo_str
                    tlname_cbdo.Text = tlname_cbdo_str
                    tdesignation_text.Text = .GetValue(2)

                End While
            End With


        Catch ex As Exception

        End Try

    End Sub

    Private Sub lrn_combobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lrn_combobox.SelectedIndexChanged

        ReqList.Items.Clear()

        '----------------------------------SEARCH FOR REQUIREMENT DETAILS-------------------------------------------------------------------

        Dim math_grade_str, sci_grade_str, eng_grade_str, requirement_id_str As String
        Dim Math, Sci, Eng As String
        Dim requirement_id As String

        Math = "Mathematics"
        Sci = "Science"
        Eng = "English"

        requirement_id_str = "Select lrn, requirement_id, name, subject_grade from applicant_grade where lrn = '" & lrn_combobox.Text & "'"
        math_grade_str = "Select lrn, requirement_id, name, subject_grade from applicant_grade where lrn = '" & lrn_combobox.Text & "' and name ='" & Math & "' "
        sci_grade_str = "Select lrn, requirement_id, name, subject_grade from applicant_grade where lrn = '" & lrn_combobox.Text & "' and name ='" & Sci & "' "
        eng_grade_str = "Select lrn, requirement_id, name, subject_grade from applicant_grade where lrn = '" & lrn_combobox.Text & "' and name ='" & Eng & "' "

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
                            Next
                             
                        End While
                    End With

                    Dim lastThreeIDsReqId As New List(Of Integer)() 

                    'Retrieve the requirement ids
                    Dim retrieve_reqid = "SELECT requirement_id from applicant_grade where lrn = '" & lrn_combobox.Text & "'"

                    readqueary(retrieve_reqid)
                    With cmdread
                        While .Read
                            lastThreeIDsReqId.Add(.GetValue(0))
                        End While
                    End With

                    Dim eng_remarks_str = "Select teacher_id, requirement_id, remarks from validates_applicant where requirement_id = '" & lastThreeIDsReqId(0) & "'  "
                    Dim sci_remarks_str = "Select teacher_id, requirement_id, remarks from validates_applicant where requirement_id = '" & lastThreeIDsReqId(1) & "'  "
                    Dim math_remarks_str = "Select teacher_id, requirement_id, remarks from validates_applicant where requirement_id = '" & lastThreeIDsReqId(2) & "'  "

                    Dim below_quota = "Below Quota"
                    Dim above_quota = "Above Quota"

                    readqueary(math_remarks_str)
                    With cmdread
                        While .Read 
                            math_remarks_cbdo.Text = .GetValue(3)
                        End While
                    End With

                    readqueary(sci_remarks_str)
                    With cmdread
                        While .Read
                            sci_remarks_cbdo.Text = .GetValue(3)
                        End While
                    End With

                    readqueary(eng_remarks_str)
                    With cmdread
                        While .Read
                            english_grade_text.Text = .GetValue(3)
                        End While
                    End With



                End While
            End With

            '----------------------------------SEARCH FOR REQUIREMENT DETAILS-------------------------------------------------------------------
             
        Catch ex As Exception

        End Try



    End Sub

    Private Sub insert_btn_Click(sender As Object, e As EventArgs) Handles insert_btn.Click
        ReqList.Items.Clear() 
        Dim lastThreeIDsReqId As New List(Of Integer)() 
        Dim subRemarks As New List(Of String)()
          
        'Retrieve the requirement ids
        Dim retrieve_reqid = "SELECT requirement_id from applicant_grade where lrn = '" & lrn_combobox.Text & "'"

        readqueary(retrieve_reqid)
        With cmdread
            While .Read
                lastThreeIDsReqId.Add(.GetValue(0))
            End While
        End With

        Dim above_quota = "Above Quota"
        Dim below_quota = "Below Quota"

        Try 

            If Not String.IsNullOrEmpty(eng_remarks_cbdo.Text) Then
                Dim insert_eng_remarks = "Insert into validates_applicant (teacher_id, requirement_id, remarks) values ('" & teacher_id_txt.Text & "', '" & lastThreeIDsReqId(0) & "', '" & eng_remarks_cbdo.Text & "')"
                readqueary(insert_eng_remarks)
            End If
            If Not String.IsNullOrEmpty(sci_remarks_cbdo.Text) Then
                Dim insert_sci_remarks = "Insert into validates_applicant (teacher_id, requirement_id, remarks) values ('" & teacher_id_txt.Text & "', '" & lastThreeIDsReqId(1) & "', '" & sci_remarks_cbdo.Text & "')"
                readqueary(insert_sci_remarks)
            End If
            If Not String.IsNullOrEmpty(math_remarks_cbdo.Text) Then
                Dim insert_math_remarks = "Insert into validates_applicant (teacher_id, requirement_id, remarks) values ('" & teacher_id_txt.Text & "', '" & lastThreeIDsReqId(2) & "', '" & math_remarks_cbdo.Text & "')"
                readqueary(insert_math_remarks)
            End If

            '----------------------------------SEARCH FOR REQUIREMENT DETAILS-------------------------------------------------------------------
            MsgBox("Data Inserted")
        Catch ex As Exception

        End Try

        Clear_Item()
        clear_table()
        Show_Table()

    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        ReqList.Items.Clear()
        Dim lastThreeIDsReqId As New List(Of Integer)()
        Dim subRemarks As New List(Of String)()

        'Retrieve the requirement ids
        Dim retrieve_reqid = "SELECT requirement_id from applicant_grade where lrn = '" & lrn_combobox.Text & "'"

        readqueary(retrieve_reqid)
        With cmdread
            While .Read
                lastThreeIDsReqId.Add(.GetValue(0))
            End While
        End With
          
        Try
            If Not String.IsNullOrEmpty(eng_remarks_cbdo.Text) Then 
                Dim eng_remarks = "Update validates_applicant set remarks = '" & eng_remarks_cbdo.Text & "' where teacher_id = '" & teacher_id_txt.Text & "' and requirement_id = '" & lastThreeIDsReqId(0) & "' " 
                readqueary(eng_remarks)
            End If
            If Not String.IsNullOrEmpty(sci_remarks_cbdo.Text) Then
                Dim sci_remarks = "Update validates_applicant set remarks = '" & sci_remarks_cbdo.Text & "' where teacher_id = '" & teacher_id_txt.Text & "' and requirement_id = '" & lastThreeIDsReqId(1) & "' "
                readqueary(sci_remarks)
            End If
            If Not String.IsNullOrEmpty(math_remarks_cbdo.Text) Then
                Dim math_remarks = "Update validates_applicant set remarks = '" & math_remarks_cbdo.Text & "' where teacher_id = '" & teacher_id_txt.Text & "' and requirement_id = '" & lastThreeIDsReqId(2) & "' "
                readqueary(math_remarks)
            End If


            '------------------------REFRESH --------------------------

            Clear_Item()
            clear_table()
            Show_Table()
            MsgBox("Update Record")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        ReqList.Items.Clear()
        Dim lastThreeIDsReqId As New List(Of Integer)()
        Dim subRemarks As New List(Of String)()

        'Retrieve the requirement ids
        Dim retrieve_reqid = "SELECT requirement_id from applicant_grade where lrn = '" & lrn_combobox.Text & "'"

        readqueary(retrieve_reqid)
        With cmdread
            While .Read
                lastThreeIDsReqId.Add(.GetValue(0))
            End While
        End With

        Try
            '---------------------------UPDATING GWA -----------------------------------------------
            For Each Req_Id In lastThreeIDsReqId
                Dim Applicant_Grade = "Delete from validates_applicant where requirement_id = '" & Req_Id & "' "

                readqueary(Applicant_Grade) 

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
End Class