Public Class frm_customers_a189479
    Private Sub frm_customers_a189479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMERS_A189479"
        Dim datatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, connectionString)
        myreader.Fill(datatable)
        grd_customers.DataSource = datatable
    End Sub

    Private Sub btn_back_mainmenu_Click(sender As Object, e As EventArgs) Handles btn_back_mainmenu.Click
        frm_customer_details_a189479.Show()
        Me.Hide()
    End Sub
End Class