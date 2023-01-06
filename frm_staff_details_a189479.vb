Public Class frm_staff_details_a189479

    Private Sub frm_staff_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
        AddHandler lst_staffid.SelectedIndexChanged, AddressOf lst_staffid_SelectedIndexChanged

    End Sub

    Public Sub init()
        Dim mysql As String = "SELECT * FROM TBL_STAFFS_A189479 order by fld_staff_id"
        Dim productdatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, connectionString)
        myreader.Fill(productdatatable)
        lst_staffid.DataSource = productdatatable
        lst_staffid.DisplayMember = "fld_staff_id"
        'focus on the list
        lst_staffid.Select()
        refresh_text(lst_staffid.Text)
    End Sub

    Public Sub refresh_text(staffid As String)
        Dim mysql As String = "select * from tbl_staffs_a189479 where fld_staff_id='" & staffid & "'"
        Dim mytable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, connectionString)
        myreader.Fill(mytable)
        If mytable.Rows.Count > 0 Then
            txt_staff_id.Text = mytable.Rows(0).Item("fld_staff_id")
            txt_staff_name.Text = mytable.Rows(0).Item("fld_staff_name")
            cmb_staff_role.Text = mytable.Rows(0).Item("fld_staff_role")
        End If
    End Sub

    Private Sub lst_staffid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_staffid.SelectedIndexChanged
        refresh_text(lst_staffid.Text)
    End Sub

    Private Sub to_enable_edit(state As Boolean)
        btn_add_staff.Enabled = Not state
        btn_delete_staff.Enabled = Not state
        btn_save_staff.Enabled = state
        btn_update_staff.Enabled = Not state
        txt_staff_name.ReadOnly = Not state
        cmb_staff_role.Enabled = state
        lst_staffid.Enabled = Not state
    End Sub

    Private Sub btn_update_staff_Click(sender As Object, e As EventArgs) Handles btn_update_staff.Click
        to_enable_edit(True)
    End Sub

    Private Sub btn_save_staff_Click(sender As Object, e As EventArgs) Handles btn_save_staff.Click
        to_enable_edit(False)
        run_sql_command($"UPDATE TBL_STAFFS_A189479 SET FLD_STAFF_NAME='{txt_staff_name.Text}' WHERE FLD_STAFF_ID='{txt_staff_id.Text}'")
        run_sql_command($"UPDATE TBL_STAFFS_A189479 SET FLD_STAFF_ROLE='{cmb_staff_role.Text}' WHERE FLD_STAFF_ID='{txt_staff_id.Text}'")
        Beep()
        MsgBox($"You have successfully updated the product '{txt_staff_id.Text}'.")
    End Sub

    Private Sub btn_view_staff_table_Click(sender As Object, e As EventArgs) Handles btn_view_staff_table.Click
        frm_staffs_a189479.Show()
        Me.Hide()
    End Sub

    Private Sub btn_delete_staff_Click(sender As Object, e As EventArgs) Handles btn_delete_staff.Click
        Dim delete_confirmation = MsgBox($"Are you sure you would like to delete this product {txt_staff_id.Text}?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command($"DELETE FROM TBL_STAFFS_A189479 WHERE FLD_STAFF_ID='{txt_staff_id.Text}'")
        End If
        init()
    End Sub
End Class