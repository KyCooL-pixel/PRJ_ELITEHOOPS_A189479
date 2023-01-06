Public Class frm_customer_details_a189479
    Private Sub frm_customer_details_a189479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub
    Public Sub init()
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMERS_A189479 order by fld_customer_id"
        Dim productdatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, connectionString)
        myreader.Fill(productdatatable)
        lst_customerid.DataSource = productdatatable
        lst_customerid.DisplayMember = "fld_customer_id"
        'focus on the list
        lst_customerid.Select()
        refresh_text(lst_customerid.Text)
    End Sub

    Public Sub refresh_text(staffid As String)
        Dim mysql As String = "select * from TBL_CUSTOMERS_A189479 where fld_customer_id='" & staffid & "'"
        Dim mytable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, connectionString)
        myreader.Fill(mytable)
        If mytable.Rows.Count > 0 Then
            txt_customer_id.Text = mytable.Rows(0).Item("fld_customer_id")
            txt_customer_name.Text = mytable.Rows(0).Item("fld_customer_name")
            txt_customer_address.Text = mytable.Rows(0).Item("fld_customer_address")
            txt_customer_number.Text = mytable.Rows(0).Item("fld_customer_phone_number")
            cmb_customer_tier.Text = mytable.Rows(0).Item("fld_customer_tier")
        End If
    End Sub

    Private Sub lst_customerid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_customerid.SelectedIndexChanged
        refresh_text(lst_customerid.Text)
    End Sub

    Private Sub to_enable_edit(state As Boolean)
        btn_add_staff.Enabled = Not state
        btn_delete_staff.Enabled = Not state
        btn_save_staff.Enabled = state
        btn_update_staff.Enabled = Not state
        txt_customer_name.ReadOnly = Not state
        cmb_customer_tier.Enabled = state
        lst_customerid.Enabled = Not state
    End Sub

    Private Sub btn_update_staff_Click(sender As Object, e As EventArgs) Handles btn_update_staff.Click
        to_enable_edit(True)
    End Sub

    Private Sub btn_save_staff_Click(sender As Object, e As EventArgs) Handles btn_save_staff.Click
        to_enable_edit(False)
        run_sql_command($"UPDATE TBL_CUSTOMERS_A189479 SET fld_customer_name='{txt_customer_name.Text}' WHERE fld_customer_id='{txt_customer_id.Text}'")
        run_sql_command($"UPDATE TBL_CUSTOMERS_A189479 SET fld_customer_tier='{cmb_customer_tier.Text}' WHERE fld_customer_id='{txt_customer_id.Text}'")
        Beep()
        MsgBox($"You have successfully updated the product '{txt_customer_id.Text}'.")
    End Sub

    Private Sub btn_view_customer_table_Click(sender As Object, e As EventArgs) Handles btn_view_customer_table.Click
        frm_customers_a189479.Show()
        Me.Hide()
    End Sub

    Private Sub btn_delete_staff_Click(sender As Object, e As EventArgs) Handles btn_delete_staff.Click
        Dim delete_confirmation = MsgBox($"Are you sure you would like to delete this product {txt_customer_id.Text}?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command($"DELETE FROM TBL_CUSTOMERS_A189479 WHERE fld_customer_id='{txt_customer_id.Text}'")
        End If
        init()
    End Sub

    Private Sub btn_add_staff_Click(sender As Object, e As EventArgs) Handles btn_add_staff.Click
        frm_insert_customer_a189479.Show()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a189479.Show()
        Me.Hide()
    End Sub
End Class