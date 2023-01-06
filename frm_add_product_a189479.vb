Public Class frm_add_product_a189479
    Dim defaultpicture As String = defaultpicture0
    Dim currentImage As Image
    Private Sub frm_add_product_a189479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub

    Public Sub init()
        grd_product_view.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A189479 order by fld_product_id")
        txt_product_id.Text = generate_matric()
        dispose_pic_curr()
        currentImage = Image.FromFile(defaultpicture0)
        pic_product.Image = currentImage
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
            'This will allow overwriting in updating by deleting the current jpg with the name
            If System.IO.File.Exists($"pictures\{txt_product_id.Text}.jpg") = True Then
                System.IO.File.Delete($"pictures\{txt_product_id.Text}.jpg")
            End If
            'adds a new jpg
            My.Computer.FileSystem.CopyFile(defaultpicture, "pictures\" & txt_product_id.Text & ".jpg")

            'Reset form status as like new baby
            dispose_pic_curr()
            currentImage = Image.FromFile(defaultpicture0)
            pic_product.Image = currentImage
            defaultpicture = defaultpicture0
            refresh_grid()
            Beep()
            MsgBox($"You have successfully added the product {txt_product_id.Text}.")
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
            If OpenFileDialog1.FileName?.Length > 0 Then
                dispose_pic_curr()
                currentImage = Image.FromFile(OpenFileDialog1.FileName)
                pic_product.Image = currentImage
                defaultpicture = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in selecting picture, as shown below" & vbCrLf & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btn_clear_fields_Click(sender As Object, e As EventArgs) Handles btn_clear_fields.Click
        clear_fields()
    End Sub

    Private Sub btn_back_to_details_Click(sender As Object, e As EventArgs) Handles btn_back_to_details.Click
        frm_product_details_a189479.Show()
        Me.Close()
    End Sub

    Private Sub clear_image()
        If currentImage IsNot Nothing Then currentImage.Dispose()
        currentImage = Nothing

    End Sub

    Private Sub dispose_pic_curr()
        clear_image()
        If pic_product.Image IsNot Nothing Then pic_product.Image.Dispose()
        pic_product.Image = Nothing
        pic_product.Refresh()
    End Sub
End Class