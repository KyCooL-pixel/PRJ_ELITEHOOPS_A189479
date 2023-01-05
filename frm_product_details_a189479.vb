Public Class frm_product_details_a189479
    Public current_id As String

    Public Sub frm_product_details_a189479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
        AddHandler lst_productid.SelectedIndexChanged, AddressOf lst_productid_SelectedIndexChanged
    End Sub


    Public Sub init()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A189479 order by fld_product_id"
        Dim productdatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, connectionString)
        myreader.Fill(productdatatable)
        lst_productid.DataSource = productdatatable
        lst_productid.DisplayMember = "fld_product_id"
        refresh_text(lst_productid.Text)
    End Sub


    Public Sub refresh_text(productid As String)
        Dim mysql As String = "select * from tbl_products_a189479 where fld_product_id='" & productid & "'"
        Dim mytable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, connectionString)
        myreader.Fill(mytable)
        txt_product_id.Text = mytable.Rows(0).Item("fld_product_id")
        txt_product_name.Text = mytable.Rows(0).Item("fld_product_name")
        txt_price.Text = mytable.Rows(0).Item("fld_price")
        txt_brand.Text = mytable.Rows(0).Item("fld_brand")
        txt_type.Text = mytable.Rows(0).Item("fld_type")
        txt_description.Text = mytable.Rows(0).Item("fld_description")
        txt_year.Text = mytable.Rows(0).Item("fld_warrantylength")
        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_product_id.Text & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/elite_hoops_logo.jpeg")
        End Try
    End Sub

    Private Sub lst_productid_SelectedIndexChanged(sender As Object, e As EventArgs)
        refresh_text(lst_productid.Text)
    End Sub

    Private Sub btn_update_product_Click(sender As Object, e As EventArgs) Handles btn_update_product.Click

    End Sub

    Private Sub btn_save_product_Click(sender As Object, e As EventArgs) Handles btn_save_product.Click

    End Sub

    Private Sub btn_new_product_Click(sender As Object, e As EventArgs) Handles btn_new_product.Click
        frm_add_product_a189479.Show()
    End Sub

    Private Sub btn_back_main_menu_Click(sender As Object, e As EventArgs) Handles btn_back_main_menu.Click
        frm_mainmenu_a189479.Show()
        Me.Hide()
    End Sub
End Class