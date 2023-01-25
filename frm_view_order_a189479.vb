Public Class frm_view_order_a189479
    Dim orderTable As New DataTable
    Dim orderListTable As New DataTable
    Dim productTable As New DataTable
    Dim customerTable As New DataTable
    Dim staffTable As New DataTable

    Dim totalPrice As New Double

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a189479.Show()
        Me.Close()
    End Sub

    Private Sub frm_view_order_a189479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub

    Private Sub init()
        'fill all table for usage
        orderTable = run_sql_query($"SELECT * FROM TBL_ORDER_A189479 ORDER BY FLD_ORDER_ID")
        staffTable = run_sql_query("SELECT * FROM TBL_STAFFS_A189479 ORDER BY FLD_STAFF_ID")
        customerTable = run_sql_query("Select * from tbl_customers_a189479 order by fld_customer_id")
        orderListTable = run_sql_query($"SELECT * FROM TBL_ORDERLIST_A189479")

        'fill the order_id combobox from ordertable
        With cmb_order_id
            .DataSource = orderTable
            .DisplayMember = "FLD_ORDER_ID"
            .ValueMember = "FLD_ORDER_ID"
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedItem = Nothing
        End With
        clear_fields()
    End Sub

    Private Sub cmb_order_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_order_id.SelectedIndexChanged
        'clear for new inputs
        clear_fields()

        'start fetching
        Dim orderIdString As String
        orderIdString = $"FLD_ORDER_ID = '{cmb_order_id.Text}'"
        Dim orderRows() As DataRow = orderTable.Select(orderIdString)
        Dim orderListRows() As DataRow = orderListTable.Select(orderIdString)

        ' from order
        If orderRows.Count > 0 Then
            lbl_order_datetime_data.Text = orderRows(0).Item("FLD_DATETIME")
            lbl_staff_id_data.Text = orderRows(0).Item("FLD_PROCESS_STAFF_ID")
            lbl_customer_id_data.Text = orderRows(0).Item("FLD_CUSTOMER_ID")
        End If

        ' from order list to grid
        ' try to loop here to include product price
        If orderListRows.Count > 0 Then
            totalPrice = 0
            For i As Integer = 0 To orderListRows.Count - 1
                'product id
                Dim productID As String = orderListRows(i).Item("FLD_PRODUCT_ID")
                ' Run a sql_query here to get the exact product 
                productTable = run_sql_query($"Select * from tbl_products_a189479 where fld_product_id='{productID}'")

                'product quantity
                Dim productQuantity As Integer = orderListRows(i).Item("FLD_QUANTITY")
                Dim productPrice As Double = Double.Parse(Format(productTable.Rows(0).Item("FLD_PRICE"), "0.00"))
                Dim totalCurrentPrice As Double = productPrice * productQuantity
                totalPrice += totalCurrentPrice
                grd_order_view.Rows.Add(productID, productQuantity, Format(productPrice, "0.00"), Format(totalCurrentPrice, "0.00"))
            Next
        End If

        ' Get staff name from id
        Dim staffRows() As DataRow = staffTable.Select($"FLD_STAFF_ID ='{lbl_staff_id_data.Text}'")
        If staffRows.Count > 0 Then
            lbl_staff_name_data.Text = staffRows(0).Item("FLD_STAFF_NAME")
        End If

        'get user name from id
        Dim customerRows() As DataRow = customerTable.Select($"FLD_CUSTOMER_ID ='{lbl_customer_id_data.Text}'")
        If customerRows.Count > 0 Then
            lbl_customer_name_data.Text = customerRows(0).Item("FLD_CUSTOMER_NAME")
        End If

        'display total price
        lbl_total_price_data.Text = Format(totalPrice, "0.00")

    End Sub


    Private Sub clear_fields()
        lbl_order_datetime_data.Text = "----"
        lbl_staff_id_data.Text = "----"
        lbl_customer_id_data.Text = "----"
        lbl_staff_name_data.Text = "----"
        lbl_customer_name_data.Text = "----"
        lbl_total_price_data.Text = "0.00"
        clear_grd_order()
    End Sub

    Private Sub clear_grd_order()
        grd_order_view.Rows.Clear()
    End Sub

End Class