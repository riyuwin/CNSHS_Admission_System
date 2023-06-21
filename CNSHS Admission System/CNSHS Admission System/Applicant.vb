Imports MySql.Data.MySqlClient

Public Class Applicant


    Dim connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnshs_admission_system")
    Dim table As New DataTable()
    Dim adapter As New MySqlDataAdapter("SELECT * FROM cnshs_admission_system.applicant", connection)


    Private Sub Applicant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Show_Table()
        Search_Load()

    End Sub

    Public Sub Show_Table()

        adapter.Fill(table)

        applicant_dgv.DataSource = table


        applicant_dgv.Columns("lrn").HeaderText = "LRN"
        applicant_dgv.Columns("fname").HeaderText = "Fname"
        applicant_dgv.Columns("mname").HeaderText = "Mname"
        applicant_dgv.Columns("lname").HeaderText = "Lname"
        applicant_dgv.Columns("ext_name").HeaderText = "ExtName"
        applicant_dgv.Columns("address").HeaderText = "Address"
        applicant_dgv.Columns("contact_num").HeaderText = "Contact Num"
        applicant_dgv.Columns("school_name").HeaderText = "School Name"

        applicant_dgv.DefaultCellStyle.Font = New Font("Century Gothic", 8, FontStyle.Regular)


    End Sub

    Public Sub clear_table()

        table.Clear()

    End Sub

    Public Sub Clear_Item()
        lrn_cbdo.Items.Clear()

        fname_text.Clear()
        mname_text.Clear()
        lname_text.Clear()
        extname_text.Clear()
        address_text.Clear()
        contact_number_text.Clear()
        school_name_text.Clear()
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

    Private Sub lrn_cbdo_SelectedIndexChanged(sender As Object, e As EventArgs)
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
                    address_text.Text = .GetValue(5)
                    contact_number_text.Text = .GetValue(6)
                    school_name_text.Text = .GetValue(7)

                End While
            End With
        Catch ex As Exception

        End Try
    End Sub

      



    Private Sub update_button_Click(sender As Object, e As EventArgs) Handles update_button.Click
        Dim fname, mname, lname, extname, address, contact_num, school_name As String

        fname = "Update applicant set fname = '" & fname_text.Text & "' where lrn = '" & lrn_cbdo.Text & "' "
        mname = "Update applicant set mname = '" & mname_text.Text & "' where lrn = '" & lrn_cbdo.Text & "' "
        lname = "Update applicant set lname = '" & lname_text.Text & "' where lrn = '" & lrn_cbdo.Text & "' "
        extname = "Update applicant set ext_name = '" & extname_text.Text & "' where lrn = '" & lrn_cbdo.Text & "' "
        address = "Update applicant set address = '" & address_text.Text & "' where lrn = '" & lrn_cbdo.Text & "' "
        contact_num = "Update applicant set contact_num = '" & contact_number_text.Text & "' where lrn = '" & lrn_cbdo.Text & "' "
        school_name = "Update applicant set school_name = '" & school_name_text.Text & "' where lrn = '" & lrn_cbdo.Text & "' "

        Try
            readqueary(fname)
            readqueary(mname)
            readqueary(lname)
            readqueary(extname)
            readqueary(address)
            readqueary(contact_num)
            readqueary(school_name)

            Clear_Item()
            clear_table()
            Show_Table()

            MsgBox("Update Record")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub delete_button_Click(sender As Object, e As EventArgs) Handles delete_button.Click
        Dim applicant As String

        applicant = "Delete from applicant where lrn = '" & lrn_cbdo.Text & "' "

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

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Private Sub lrn_cbdo_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lrn_cbdo.SelectedIndexChanged
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
                    address_text.Text = .GetValue(5)
                    contact_number_text.Text = .GetValue(6)
                    school_name_text.Text = .GetValue(7)

                End While
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub insert_btn_Click(sender As Object, e As EventArgs) Handles insert_btn.Click
        Dim str As String

        str = "INSERT INTO applicant (lrn, fname, mname, lname, ext_name, address, contact_num, school_name)" &
            "VALUES ('" & lrn_cbdo.Text & "', '" & fname_text.Text & "', '" & mname_text.Text & "', '" & lname_text.Text & "', '" & extname_text.Text & "', '" & address_text.Text & "', '" & contact_number_text.Text & "', '" & school_name_text.Text & "')"
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
End Class
