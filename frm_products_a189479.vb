Public Class frm_products_a189479
    Private Sub btn_back_mainmenu_Click(sender As Object, e As EventArgs) Handles btn_back_details.Click
        frm_product_details_a189479.Show()
        Me.Hide()
    End Sub

    Private Sub frm_products_a189479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A189479"
        Dim productdatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, connectionString)
        myreader.Fill(productdatatable)
        grd_products.DataSource = productdatatable
    End Sub
End Class