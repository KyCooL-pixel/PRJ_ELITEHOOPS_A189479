Public Class frm_add_order_a189479
    'declare the datatable
    Dim staffTable As New DataTable
    Dim productTable As New DataTable
    Dim customerTable As New DataTable
    Dim orderTable As New DataTable
    Dim orderListTable As New DataTable

    Dim totalprice As New Double
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        'maybe handle transcation end here also
        frm_mainmenu_a189479.Show()
        Me.Hide()
    End Sub

    Private Sub frm_add_order_a189479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub

    Public Sub init()
        'fill datatable from database
        staffTable = run_sql_query("SELECT * FROM TBL_STAFFS_A189479 ORDER BY FLD_STAFF_ID")
        productTable = run_sql_query("Select * from tbl_products_a189479")
        customerTable = run_sql_query("Select * from tbl_customers_a189479")
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
        reset_ids()
        reset_fields()

    End Sub

    Private Sub cmb_staff_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_staff_id.SelectedIndexChanged
        If cmb_staff_id.SelectedItem IsNot Nothing Then
            txt_staff_name.Text = staffTable.Rows(cmb_staff_id.SelectedIndex).Item(1).ToString
        End If
    End Sub
    Private Sub cmb_customer_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_customer_id.SelectedIndexChanged
        If cmb_customer_id.SelectedItem IsNot Nothing Then
            txt_customer_name.Text = customerTable.Rows(cmb_customer_id.SelectedIndex).Item(1).ToString
        End If
    End Sub

    Private Sub btn_restart_Click(sender As Object, e As EventArgs) Handles btn_restart.Click
        reset_ids()
        reset_fields()
    End Sub

    Private Sub cmb_product_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_product_id.SelectedIndexChanged
        reset_product_fields()
        If cmb_product_id.SelectedItem IsNot Nothing Then
            txt_product_name.Text = productTable.Rows(cmb_product_id.SelectedIndex).Item(1).ToString
            txt_product_price.Text = productTable.Rows(cmb_product_id.SelectedIndex).Item(2).ToString
            txt_product_brand.Text = productTable.Rows(cmb_product_id.SelectedIndex).Item(3).ToString
            txt_product_type.Text = productTable.Rows(cmb_product_id.SelectedIndex).Item(4).ToString
            updown_quantity.Enabled = True
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
        updown_quantity.Value = 0
        updown_quantity.Enabled = False
        txt_product_total.Text = "0.00"
    End Sub

    Private Sub reset_ids()
        cmb_staff_id.SelectedItem = Nothing
        cmb_customer_id.SelectedItem = Nothing
        reset_product_id()
    End Sub

    Private Sub reset_product_id()
        cmb_product_id.SelectedItem = Nothing
    End Sub
    Private Sub updown_quantity_ValueChanged(sender As Object, e As EventArgs) Handles updown_quantity.ValueChanged
        If txt_product_price.Text.Equals("") Then
            txt_product_total.Text = "0.00"
        Else
            totalprice = updown_quantity.Value * Double.Parse(txt_product_price.Text)
            txt_product_total.Text = totalprice.ToString
        End If
    End Sub

    Private Function generate_order_id()
        If orderTable.Rows.Count > 0 Then
            Dim lastorderid As String = orderTable.Rows(0).Item("fld_order_id")
            'MsgBox(lastmatric)
            Dim neworderid As String = "K0" & Mid(lastorderid, 2) + 1
            Return neworderid
        Else
            Dim neworderid As String
            neworderid = "K00"
            Return neworderid
        End If
    End Function
End Class