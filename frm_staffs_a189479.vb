Public Class frm_staffs_a189479
    Private Sub btn_back_mainmenu_Click(sender As Object, e As EventArgs) Handles btn_back_details.Click
        frm_staff_details_a189479.Show()
        Me.Hide()
    End Sub

    Private Sub frm_staffs_a189479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_STAFFS_A189479"
        Dim datatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, connectionString)
        myreader.Fill(datatable)
        grd_staffs.DataSource = datatable
    End Sub
End Class