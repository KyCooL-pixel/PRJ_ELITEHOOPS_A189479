Public Class frm_add_order_a189479
    'declare the datatable
    Dim staffTable As New DataTable
    Dim productTable As New DataTable
    Dim customerTable As New DataTable
    Dim orderTable As New DataTable
    Dim orderListTable As New DataTable

    'Control states to be updated as development goes on
    Dim staffSelected As New Boolean
    Dim customerSelected As New Boolean
    Dim productSelected As New Boolean
    Dim isCartEmpty As New Boolean

    'Declare var String for pic path
    Dim curr_picture_path As String

    'Declare dummy pic var for pic
    Dim currentImage As Image

    Dim totalprice As New Double
    Dim cartTotal As New Double
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        'maybe handle transcation end here also
        ' Rerolling transcation
        frm_mainmenu_a189479.Show()
        dispose_pic_curr()
        Me.Close()
    End Sub

    Private Sub frm_add_order_a189479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub

    'wrap onload function into a init function incase it is needed to be call explicitly from other forms
    'Note: closing the form everytime its not used will call onload everytime, seems legit and cleaner instead of calling init()
    Public Sub init()
        'fill datatable from database
        staffTable = run_sql_query("SELECT * FROM TBL_STAFFS_A189479 ORDER BY FLD_STAFF_ID")
        productTable = run_sql_query("Select * from tbl_products_a189479 order by fld_product_id")
        customerTable = run_sql_query("Select * from tbl_customers_a189479 order by fld_customer_id")
        orderTable = run_sql_query($"SELECT * FROM TBL_ORDER_A189479 ORDER BY FLD_ORDER_ID")

        'fill combobox with values
        With cmb_staff_id
            .DataSource = staffTable
            .DisplayMember = "FLD_STAFF_ID"
            .ValueMember = "FLD_STAFF_ID"
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedItem = Nothing
        End With
        With cmb_customer_id
            .DataSource = customerTable
            .DisplayMember = "FLD_CUSTOMER_ID"
            .ValueMember = "FLD_CUSTOMER_ID"
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedItem = Nothing
        End With
        With cmb_product_id
            .DataSource = productTable
            .DisplayMember = "FLD_PRODUCT_ID"
            .ValueMember = "FLD_PRODUCT_ID"
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedItem = Nothing
        End With

        'makes the default value of comboboxes and the display fields null
        lbl_order_id_data.Text = generate_order_id()
        'starts with empty field
        reset_ids()
        reset_fields()
        cmb_staff_id.Enabled = True
        cmb_customer_id.Enabled = True

    End Sub

    Private Sub cmb_staff_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_staff_id.SelectedIndexChanged
        If cmb_staff_id.SelectedItem IsNot Nothing Then
            txt_staff_name.Text = staffTable.Rows(cmb_staff_id.SelectedIndex).Item(1).ToString
            staffSelected = True
            cmb_staff_id.Enabled = False
            cmb_customer_id.Select()
        End If
    End Sub
    Private Sub cmb_customer_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_customer_id.SelectedIndexChanged
        If cmb_customer_id.SelectedItem IsNot Nothing Then
            txt_customer_name.Text = customerTable.Rows(cmb_customer_id.SelectedIndex).Item(1).ToString
            customerSelected = True
            cmb_customer_id.Enabled = False
            cmb_product_id.Select()
        End If
    End Sub

    Private Sub btn_restart_Click(sender As Object, e As EventArgs) Handles btn_restart.Click
        Dim delete_confirmation = MsgBox($"Are you sure you would like to remake the order? Everything will be cleared including cart", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            reset_ids()
            reset_fields()
            cmb_staff_id.Enabled = True
            cmb_customer_id.Enabled = True
            clear_cart()
        End If
        Beep()
        MsgBox("Order is cleared")
        init()

    End Sub

    Private Sub cmb_product_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_product_id.SelectedIndexChanged
        reset_product_fields()
        If cmb_product_id.SelectedItem IsNot Nothing Then
            txt_product_name.Text = productTable.Rows(cmb_product_id.SelectedIndex).Item(1).ToString
            txt_product_price.Text = productTable.Rows(cmb_product_id.SelectedIndex).Item(2).ToString
            txt_product_brand.Text = productTable.Rows(cmb_product_id.SelectedIndex).Item(3).ToString
            txt_product_type.Text = productTable.Rows(cmb_product_id.SelectedIndex).Item(4).ToString
            'Prevent user from changing the quantity without a product
            updown_quantity.Enabled = True
            calc_product_total()
            productSelected = True
        End If
    End Sub

    Private Sub reset_fields()
        txt_staff_name.Text = ""
        txt_customer_name.Text = ""
        reset_product_fields()
    End Sub

    Private Sub reset_product_fields()
        txt_product_name.Text = ""
        txt_product_price.Text = ""
        txt_product_brand.Text = ""
        txt_product_type.Text = ""
        updown_quantity.Value = 1
        updown_quantity.Enabled = False
        txt_product_total.Text = "0.00"
        Try
            curr_picture_path = $"pictures\{cmb_product_id.Text}.jpg"
            dispose_pic_curr()
            currentImage = Image.FromFile(curr_picture_path)
            pic_product.Image = currentImage
        Catch ex As Exception
            pic_product.Image = Image.FromFile("pictures/elite_hoops_logo.jpeg")
        End Try
    End Sub

    Private Sub reset_ids()
        cmb_staff_id.SelectedItem = Nothing
        cmb_customer_id.SelectedItem = Nothing
        staffSelected = False
        customerSelected = False
        reset_product_id()
    End Sub

    Private Sub reset_product_id()
        cmb_product_id.SelectedItem = Nothing
        productSelected = False
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
    Private Sub updown_quantity_ValueChanged(sender As Object, e As EventArgs) Handles updown_quantity.ValueChanged
        calc_product_total()
    End Sub

    Private Sub calc_product_total()
        If txt_product_price.Text.Equals("") Then
            txt_product_total.Text = "0.00"
        Else
            totalprice = updown_quantity.Value * Double.Parse(txt_product_price.Text)
            txt_product_total.Text = totalprice.ToString
        End If
    End Sub

    Private Sub reset_product_all()
        reset_product_id()
        reset_product_fields()
    End Sub
    Private Function generate_order_id()
        If orderTable.Rows.Count > 0 Then
            Dim lastorderid As String = orderTable.Rows(orderTable.Rows.Count - 1).Item("fld_order_id")
            'MsgBox(lastmatric)l
            Dim neworderid As String = "K0" & Mid(lastorderid, 2) + 1
            Return neworderid
        Else
            Dim neworderid As String
            neworderid = "K00"
            Return neworderid
        End If
    End Function

    Private Sub btn_add_cart_Click(sender As Object, e As EventArgs) Handles btn_add_cart.Click
        'Make sure all info is selected before adding to cart
        If staffSelected And productSelected And customerSelected Then
            'add product to cart
            grd_cart_view.Rows.Add(cmb_product_id.Text, txt_product_name.Text, updown_quantity.Value, totalprice)
            reset_product_all()
            render_cart_total()
            isCartEmpty = False
        Else
            Beep()
            MsgBox("Please fill out all information!!")
        End If
    End Sub

    Private Sub clear_cart()
        For Each row As DataGridViewRow In grd_cart_view.Rows
            grd_cart_view.Rows.RemoveAt(grd_cart_view.Rows.Count - 1)
        Next
        ' for some reasons, the first row will not be deleted, so deleting it explicitly seems like a good idea
        If grd_cart_view.Rows.Count > 0 Then
            grd_cart_view.Rows.RemoveAt(0)
        End If
        isCartEmpty = True
        txt_cart_total.Text = "0.00"
    End Sub

    Private Sub render_cart_total()
        If grd_cart_view.Rows.Count > 0 Then
            cartTotal = 0.00
            For i As Integer = 0 To grd_cart_view.Rows.Count - 1
                cartTotal += Double.Parse(grd_cart_view.Rows(i).Cells(3).Value.ToString)
            Next
        Else
            cartTotal = 0.00
        End If
        txt_cart_total.Text = cartTotal
    End Sub

    Private Sub btn_clear_cart_Click(sender As Object, e As EventArgs) Handles btn_clear_cart.Click
        clear_cart()
    End Sub

    Private Sub btn_checkout_Click(sender As Object, e As EventArgs) Handles btn_checkout.Click
        Dim order_confirmation = MsgBox($"Are you sure you want to order ?", MsgBoxStyle.YesNo)
        'If confirm order
        If order_confirmation = MsgBoxResult.Yes Then
            Try
                Dim mytransaction As OleDb.OleDbTransaction
                connectionString2.Open()
                mytransaction = connectionString2.BeginTransaction
                'insert into order table first
                Dim ordersql As String = $"insert into tbl_order_a189479 values('{lbl_order_id_data.Text}','{cmb_staff_id.Text}','{cmb_customer_id.Text}')"
                Dim orderwriter As New OleDb.OleDbCommand(ordersql, connectionString2, mytransaction)
                orderwriter.ExecuteNonQuery()
                'insert into orderlist row by row
                For i As Integer = 0 To grd_cart_view.Rows.Count - 1
                    Dim mysql As String = $"insert into tbl_orderlist_a189479 values('{lbl_order_id_data.Text}','{grd_cart_view.Rows(i).Cells(0).Value}',{grd_cart_view.Rows(i).Cells(2).Value})"
                    Dim mywriter As New OleDb.OleDbCommand(mysql, connectionString2, mytransaction)
                    mywriter.ExecuteNonQuery()
                Next
                mytransaction.Commit()
                connectionString2.Close()
                ' reset all the fields, ready for next order
                MsgBox("Order Successed!!")
                cmb_staff_id.Enabled = True
                cmb_customer_id.Enabled = True
                clear_cart()
                init()
            Catch
                Beep()
                MsgBox("Please add a product first!!")
            End Try
        End If
    End Sub

    'catch user deleting rows and rerender the cart total price
    Private Sub dgv_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles grd_cart_view.KeyDown
        If e.KeyValue = 46 Then
            Dim j As Integer
            grd_cart_view.Rows.RemoveAt(grd_cart_view.SelectedCells(j).RowIndex)
            Application.DoEvents()
            render_cart_total()
        End If
    End Sub
End Class