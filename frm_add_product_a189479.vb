Public Class frm_add_product_a189479
    Dim defaultpicture0 As String = Application.StartupPath & "\pictures\elite_hoops_logo.jpeg"
    Dim defaultpicture As String = defaultpicture0
    Private Sub frm_add_product_a189479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_product_view.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A189479 order by fld_product_id")
        txt_product_id.Text = generate_matric()
        pic_product.BackgroundImage = Image.FromFile(defaultpicture0)
        txt_product_name.Select()
    End Sub

    Private Function generate_matric() As String
        Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTMATRIC FROM TBL_PRODUCTS_A189479").Rows(0).Item("LASTMATRIC")
        'MsgBox(lastmatric)
        Dim newmatric As String = "A0" & Mid(lastmatric, 2) + 1
        Return newmatric
    End Function

    Private Sub refresh_grid()
        grd_product_view.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A189479 order by fld_product_id")
    End Sub

    Private Sub clear_fields()
        txt_product_brand.Text = ""
        txt_product_description.Text = ""
        txt_product_name.Text = ""
        txt_product_price.Text = ""
        txt_product_type.Text = ""
        txt_warranty_year.Text = ""
    End Sub

    Private Sub btn_add_product_Click(sender As Object, e As EventArgs) Handles btn_add_product.Click
        Dim thissql As String = "INSERT INTO TBL_PRODUCTS_A189479 VALUES ('" & txt_product_id.Text & "', '" & txt_product_name.Text & "', '" & txt_product_price.Text & "','" & txt_product_brand.Text & "','" & txt_product_type.Text & "','" & txt_product_description.Text & "','" & txt_warranty_year.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(thissql, connectionString2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()
            My.Computer.FileSystem.CopyFile(defaultpicture, "pictures\" & txt_product_id.Text & ".jpg")
            pic_product.BackgroundImage = Image.FromFile(defaultpicture)
            refresh_grid()
            clear_fields()
            txt_product_id.Text = generate_matric()
            frm_product_details_a189479.init()
        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try
    End Sub

    Private Sub btn_select_picture_Click(sender As Object, e As EventArgs) Handles btn_select_picture.Click
        Try
            Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop
            OpenFileDialog1.InitialDirectory = mydesktop
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
            OpenFileDialog1.ShowDialog()
            pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            defaultpicture = OpenFileDialog1.FileName
        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in selecting picture, as shown below" & vbCrLf & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btn_clear_fields_Click(sender As Object, e As EventArgs) Handles btn_clear_fields.Click
        clear_fields()
    End Sub
End Class