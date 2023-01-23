Public Class frm_insert_staff_a189479

    Private Sub frm_insert_staff_a189479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub

    Public Sub init()
        grd_staff_view.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A189479 order by fld_product_id")
        txt_staff_id.Text = generate_matric()
    End Sub

    Private Function generate_matric() As String
        Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_STAFF_ID) AS LASTMATRIC FROM TBL_STAFFS_A189479").Rows(0).Item("LASTMATRIC")
        'MsgBox(lastmatric)
        Dim newmatric As String = "S0" & Mid(lastmatric, 2) + 1
        Return newmatric
    End Function
    Private Sub refresh_grid()
        grd_staff_view.DataSource = run_sql_query("SELECT * FROM TBL_STAFFS_A189479 order by fld_staff_id")
    End Sub

    Private Sub clear_fields()
        txt_staff_name.Text = ""
        cmb_staff_role.SelectedItem = Nothing
    End Sub

    Private Sub btn_add_staff_Click(sender As Object, e As EventArgs) Handles btn_add_staff.Click
        If Not txt_staff_name.Text.Equals("") Then
            run_sql_command($"INSERT INTO TBL_STAFFS_A189479 VALUES('{txt_staff_id.Text}','{txt_staff_name.Text}','{cmb_staff_role.Text}')")
            refresh_grid()
            Beep()
            MsgBox($"You have successfully added the staff {txt_staff_id.Text}: {txt_staff_name.Text}.")
            clear_fields()
            txt_staff_id.Text = generate_matric()
            frm_staff_details_a189479.init()
        Else
            MsgBox("Please fill in all details")
        End If

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear_fields()
    End Sub

    Private Sub btn_back_to_details_Click(sender As Object, e As EventArgs) Handles btn_back_to_details.Click
        frm_staff_details_a189479.Show()
        Me.Close()
    End Sub
End Class