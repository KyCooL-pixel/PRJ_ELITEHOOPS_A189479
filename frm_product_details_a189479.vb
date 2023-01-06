Public Class frm_product_details_a189479
    Public current_id As String
    Dim new_picture_path As String
    Dim curr_picture_path As String
    'Important for deletion to be possible
    Dim currentImage As Image

    Public Sub frm_product_details_a189479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
        AddHandler lst_productid.SelectedIndexChanged, AddressOf lst_productid_SelectedIndexChanged
    End Sub

    'move load functions to init so that it maybe called again
    Public Sub init()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A189479 order by fld_product_id"
        Dim productdatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, connectionString)
        myreader.Fill(productdatatable)
        lst_productid.DataSource = productdatatable
        lst_productid.DisplayMember = "fld_product_id"
        'focus on the list
        lst_productid.Select()
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
            curr_picture_path = $"pictures\{txt_product_id.Text}.jpg"
            currentImage = Image.FromFile(curr_picture_path)
            pic_product.Image = currentImage
        Catch ex As Exception
            pic_product.Image = Image.FromFile("pictures/elite_hoops_logo.jpeg")
        End Try
    End Sub

    Private Sub lst_productid_SelectedIndexChanged(sender As Object, e As EventArgs)
        refresh_text(lst_productid.Text)
    End Sub

    Private Sub btn_update_product_Click(sender As Object, e As EventArgs) Handles btn_update_product.Click
        to_enable_edit(True)
        clear_image()

    End Sub

    Private Sub btn_save_product_Click(sender As Object, e As EventArgs) Handles btn_save_product.Click
        to_enable_edit(False)
        run_sql_command($"UPDATE TBL_PRODUCTS_A189479 SET FLD_PRODUCT_NAME='{txt_product_name.Text}' WHERE FLD_PRODUCT_ID='{txt_product_id.Text}'")
        run_sql_command($"UPDATE TBL_PRODUCTS_A189479 SET FLD_PRICE={txt_price.Text} WHERE FLD_PRODUCT_ID='{txt_product_id.Text}'")
        run_sql_command($"UPDATE TBL_PRODUCTS_A189479 SET FLD_BRAND='{txt_brand.Text}' WHERE FLD_PRODUCT_ID='{txt_product_id.Text}'")
        run_sql_command($"UPDATE TBL_PRODUCTS_A189479 SET FLD_TYPE='{txt_type.Text}' WHERE FLD_PRODUCT_ID='{txt_product_id.Text}'")
        run_sql_command($"UPDATE TBL_PRODUCTS_A189479 SET FLD_DESCRIPTION='{txt_description.Text}' WHERE FLD_PRODUCT_ID='{txt_product_id.Text}'")
        run_sql_command($"UPDATE TBL_PRODUCTS_A189479 SET FLD_WARRANTYLENGTH={txt_year.Text} WHERE FLD_PRODUCT_ID='{txt_product_id.Text}'")
        Beep()
        MsgBox($"You have successfully updated the product '{txt_product_id.Text}'.")

        'Dont update picture if it is the same file (no changes made) by comparing the path
        If new_picture_path IsNot Nothing Then
            If System.IO.File.Exists($"pictures\{txt_product_id.Text}.jpg") Then
                pic_product.Image.Dispose()
                'pic_product.Image = Nothing
                clear_image()
                System.IO.File.Delete($"pictures\{txt_product_id.Text}.jpg")
            End If
            My.Computer.FileSystem.CopyFile(new_picture_path, ($"pictures\{txt_product_id.Text}.jpg"))
            pic_product.Image = Image.FromFile(curr_picture_path)
        End If
        clear_image()
        'adds a new jpg
    End Sub


    Private Sub to_enable_edit(state As Boolean)
        btn_back_main_menu.Enabled = Not state
        btn_new_product.Enabled = Not state
        btn_delete_product.Enabled = Not state
        btn_change_picture.Enabled = state
        btn_save_product.Enabled = state
        btn_update_product.Enabled = Not state
        lst_productid.Enabled = Not state
        txt_product_name.ReadOnly = Not state
        txt_price.ReadOnly = Not state
        txt_brand.ReadOnly = Not state
        txt_type.ReadOnly = Not state
        txt_description.ReadOnly = Not state
        txt_year.ReadOnly = Not state
    End Sub


    Private Sub btn_new_product_Click(sender As Object, e As EventArgs) Handles btn_new_product.Click
        frm_add_product_a189479.Show()
    End Sub

    Private Sub btn_back_main_menu_Click(sender As Object, e As EventArgs) Handles btn_back_main_menu.Click
        frm_mainmenu_a189479.Show()
        Me.Hide()
    End Sub

    Private Sub btn_delete_product_Click(sender As Object, e As EventArgs) Handles btn_delete_product.Click
        Dim delete_confirmation = MsgBox($"Are you sure you would like to delete this product {txt_product_id.Text}?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command($"DELETE FROM TBL_PRODUCTS_A189479 WHERE FLD_PRODUCT_ID='{txt_product_id.Text}'")
            ' this will release the picture resources for it to be deleted
            If System.IO.File.Exists($"pictures\{txt_product_id.Text}.jpg") = True Then
                dispose_pic_curr()
                System.IO.File.Delete($"pictures\{txt_product_id.Text}.jpg")
            End If
            Beep()
            MsgBox("The product """ & lst_productid.Text & """ has been successfully deleted.")
            init()
            frm_add_product_a189479.init()
        End If

    End Sub

    Private Sub clear_image()
        If currentImage IsNot Nothing Then currentImage.Dispose()
        currentImage = Nothing

    End Sub

    Private Sub dispose_pic_curr()
        clear_image()
        pic_product.Image.Dispose()
        pic_product.Image = Nothing
        pic_product.Refresh()
    End Sub

    Private Sub btn_change_picture_Click(sender As Object, e As EventArgs) Handles btn_change_picture.Click
        Try

            Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop
            OpenFileDialog1.InitialDirectory = mydesktop
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName?.Length > 0 Then
                dispose_pic_curr()
                currentImage = Image.FromFile(OpenFileDialog1.FileName)
                pic_product.Image = currentImage
            End If

        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in selecting picture, as shown below" & vbCrLf & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub btn_table_view_Click(sender As Object, e As EventArgs) Handles btn_table_view.Click
        frm_products_a189479.Show()
        Me.Hide()
    End Sub
End Class