<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_add_order_a189479
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_new_order = New System.Windows.Forms.Label()
        Me.lbl_order_id = New System.Windows.Forms.Label()
        Me.lbl_staff = New System.Windows.Forms.Label()
        Me.cmb_staff_id = New System.Windows.Forms.ComboBox()
        Me.lbl_order_id_data = New System.Windows.Forms.Label()
        Me.lbl_staff_id = New System.Windows.Forms.Label()
        Me.pnl_staff = New System.Windows.Forms.Panel()
        Me.txt_staff_name = New System.Windows.Forms.TextBox()
        Me.lbl_staff_name = New System.Windows.Forms.Label()
        Me.pnl_order = New System.Windows.Forms.Panel()
        Me.btn_clear_cart = New System.Windows.Forms.Button()
        Me.btn_checkout = New System.Windows.Forms.Button()
        Me.txt_cart_total = New System.Windows.Forms.TextBox()
        Me.grd_cart_view = New System.Windows.Forms.DataGridView()
        Me.fld_product_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fld_product_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fld_product_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fld_product_total_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_instruction_1 = New System.Windows.Forms.Label()
        Me.lbl_instruction_2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_customer_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_customer_id = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_add_cart = New System.Windows.Forms.Button()
        Me.txt_product_total = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_product_quantity = New System.Windows.Forms.Label()
        Me.txt_product_price = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.updown_quantity = New System.Windows.Forms.NumericUpDown()
        Me.txt_product_type = New System.Windows.Forms.TextBox()
        Me.lbl_product_type = New System.Windows.Forms.Label()
        Me.txt_product_brand = New System.Windows.Forms.TextBox()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.txt_product_name = New System.Windows.Forms.TextBox()
        Me.lbl_product_name = New System.Windows.Forms.Label()
        Me.lbl_product_id = New System.Windows.Forms.Label()
        Me.cmb_product_id = New System.Windows.Forms.ComboBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_product = New System.Windows.Forms.Label()
        Me.lbl_instruction_3 = New System.Windows.Forms.Label()
        Me.lbl_instruction_4 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_restart = New System.Windows.Forms.Button()
        Me.pnl_staff.SuspendLayout()
        Me.pnl_order.SuspendLayout()
        CType(Me.grd_cart_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.updown_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_new_order
        '
        Me.lbl_new_order.AutoSize = True
        Me.lbl_new_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_new_order.Location = New System.Drawing.Point(12, 9)
        Me.lbl_new_order.Name = "lbl_new_order"
        Me.lbl_new_order.Size = New System.Drawing.Size(95, 36)
        Me.lbl_new_order.TabIndex = 0
        Me.lbl_new_order.Text = "Order"
        '
        'lbl_order_id
        '
        Me.lbl_order_id.AutoSize = True
        Me.lbl_order_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_order_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order_id.Location = New System.Drawing.Point(14, 14)
        Me.lbl_order_id.Name = "lbl_order_id"
        Me.lbl_order_id.Size = New System.Drawing.Size(84, 20)
        Me.lbl_order_id.TabIndex = 1
        Me.lbl_order_id.Text = "Order ID: "
        '
        'lbl_staff
        '
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff.Location = New System.Drawing.Point(84, 16)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(52, 25)
        Me.lbl_staff.TabIndex = 3
        Me.lbl_staff.Text = "Staff"
        '
        'cmb_staff_id
        '
        Me.cmb_staff_id.FormattingEnabled = True
        Me.cmb_staff_id.Location = New System.Drawing.Point(98, 58)
        Me.cmb_staff_id.Name = "cmb_staff_id"
        Me.cmb_staff_id.Size = New System.Drawing.Size(132, 24)
        Me.cmb_staff_id.TabIndex = 1
        '
        'lbl_order_id_data
        '
        Me.lbl_order_id_data.AutoSize = True
        Me.lbl_order_id_data.BackColor = System.Drawing.Color.Transparent
        Me.lbl_order_id_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order_id_data.Location = New System.Drawing.Point(113, 13)
        Me.lbl_order_id_data.Name = "lbl_order_id_data"
        Me.lbl_order_id_data.Size = New System.Drawing.Size(33, 20)
        Me.lbl_order_id_data.TabIndex = 7
        Me.lbl_order_id_data.Text = "----"
        '
        'lbl_staff_id
        '
        Me.lbl_staff_id.AutoSize = True
        Me.lbl_staff_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_id.Location = New System.Drawing.Point(14, 58)
        Me.lbl_staff_id.Name = "lbl_staff_id"
        Me.lbl_staff_id.Size = New System.Drawing.Size(32, 24)
        Me.lbl_staff_id.TabIndex = 8
        Me.lbl_staff_id.Text = "ID:"
        '
        'pnl_staff
        '
        Me.pnl_staff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_staff.Controls.Add(Me.txt_staff_name)
        Me.pnl_staff.Controls.Add(Me.lbl_staff_name)
        Me.pnl_staff.Controls.Add(Me.lbl_staff)
        Me.pnl_staff.Controls.Add(Me.lbl_staff_id)
        Me.pnl_staff.Controls.Add(Me.cmb_staff_id)
        Me.pnl_staff.Location = New System.Drawing.Point(16, 80)
        Me.pnl_staff.Name = "pnl_staff"
        Me.pnl_staff.Size = New System.Drawing.Size(239, 162)
        Me.pnl_staff.TabIndex = 9
        '
        'txt_staff_name
        '
        Me.txt_staff_name.CausesValidation = False
        Me.txt_staff_name.Location = New System.Drawing.Point(98, 118)
        Me.txt_staff_name.Name = "txt_staff_name"
        Me.txt_staff_name.ReadOnly = True
        Me.txt_staff_name.Size = New System.Drawing.Size(132, 22)
        Me.txt_staff_name.TabIndex = 10
        '
        'lbl_staff_name
        '
        Me.lbl_staff_name.AutoSize = True
        Me.lbl_staff_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_name.Location = New System.Drawing.Point(14, 117)
        Me.lbl_staff_name.Name = "lbl_staff_name"
        Me.lbl_staff_name.Size = New System.Drawing.Size(66, 24)
        Me.lbl_staff_name.TabIndex = 9
        Me.lbl_staff_name.Text = "Name:"
        '
        'pnl_order
        '
        Me.pnl_order.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_order.Controls.Add(Me.btn_clear_cart)
        Me.pnl_order.Controls.Add(Me.btn_checkout)
        Me.pnl_order.Controls.Add(Me.txt_cart_total)
        Me.pnl_order.Controls.Add(Me.grd_cart_view)
        Me.pnl_order.Controls.Add(Me.Label3)
        Me.pnl_order.Controls.Add(Me.lbl_order_id)
        Me.pnl_order.Controls.Add(Me.lbl_order_id_data)
        Me.pnl_order.Location = New System.Drawing.Point(786, 80)
        Me.pnl_order.Name = "pnl_order"
        Me.pnl_order.Size = New System.Drawing.Size(484, 486)
        Me.pnl_order.TabIndex = 10
        '
        'btn_clear_cart
        '
        Me.btn_clear_cart.Location = New System.Drawing.Point(208, 438)
        Me.btn_clear_cart.Name = "btn_clear_cart"
        Me.btn_clear_cart.Size = New System.Drawing.Size(124, 37)
        Me.btn_clear_cart.TabIndex = 30
        Me.btn_clear_cart.Text = "Clear Cart"
        Me.btn_clear_cart.UseVisualStyleBackColor = True
        '
        'btn_checkout
        '
        Me.btn_checkout.Location = New System.Drawing.Point(348, 438)
        Me.btn_checkout.Name = "btn_checkout"
        Me.btn_checkout.Size = New System.Drawing.Size(124, 37)
        Me.btn_checkout.TabIndex = 29
        Me.btn_checkout.Text = "Confirm Order"
        Me.btn_checkout.UseVisualStyleBackColor = True
        '
        'txt_cart_total
        '
        Me.txt_cart_total.Location = New System.Drawing.Point(265, 378)
        Me.txt_cart_total.Name = "txt_cart_total"
        Me.txt_cart_total.Size = New System.Drawing.Size(207, 22)
        Me.txt_cart_total.TabIndex = 28
        '
        'grd_cart_view
        '
        Me.grd_cart_view.AllowUserToAddRows = False
        Me.grd_cart_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_cart_view.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fld_product_id, Me.fld_product_name, Me.fld_product_quantity, Me.fld_product_total_price})
        Me.grd_cart_view.Location = New System.Drawing.Point(12, 37)
        Me.grd_cart_view.Name = "grd_cart_view"
        Me.grd_cart_view.RowHeadersWidth = 51
        Me.grd_cart_view.RowTemplate.Height = 24
        Me.grd_cart_view.Size = New System.Drawing.Size(460, 321)
        Me.grd_cart_view.TabIndex = 8
        '
        'fld_product_id
        '
        Me.fld_product_id.HeaderText = "Product ID"
        Me.fld_product_id.MinimumWidth = 6
        Me.fld_product_id.Name = "fld_product_id"
        Me.fld_product_id.ReadOnly = True
        Me.fld_product_id.Width = 125
        '
        'fld_product_name
        '
        Me.fld_product_name.HeaderText = "Product Name"
        Me.fld_product_name.MinimumWidth = 6
        Me.fld_product_name.Name = "fld_product_name"
        Me.fld_product_name.ReadOnly = True
        Me.fld_product_name.Width = 125
        '
        'fld_product_quantity
        '
        Me.fld_product_quantity.HeaderText = "Quantity"
        Me.fld_product_quantity.MinimumWidth = 6
        Me.fld_product_quantity.Name = "fld_product_quantity"
        Me.fld_product_quantity.ReadOnly = True
        Me.fld_product_quantity.Width = 125
        '
        'fld_product_total_price
        '
        Me.fld_product_total_price.HeaderText = "Total Price(RM)"
        Me.fld_product_total_price.MinimumWidth = 6
        Me.fld_product_total_price.Name = "fld_product_total_price"
        Me.fld_product_total_price.ReadOnly = True
        Me.fld_product_total_price.Width = 125
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 378)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 25)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Total Price:          RM"
        '
        'lbl_instruction_1
        '
        Me.lbl_instruction_1.AutoSize = True
        Me.lbl_instruction_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instruction_1.Location = New System.Drawing.Point(12, 57)
        Me.lbl_instruction_1.Name = "lbl_instruction_1"
        Me.lbl_instruction_1.Size = New System.Drawing.Size(114, 20)
        Me.lbl_instruction_1.TabIndex = 11
        Me.lbl_instruction_1.Text = "1. Select Staff"
        '
        'lbl_instruction_2
        '
        Me.lbl_instruction_2.AutoSize = True
        Me.lbl_instruction_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instruction_2.Location = New System.Drawing.Point(14, 303)
        Me.lbl_instruction_2.Name = "lbl_instruction_2"
        Me.lbl_instruction_2.Size = New System.Drawing.Size(152, 20)
        Me.lbl_instruction_2.TabIndex = 13
        Me.lbl_instruction_2.Text = "2. Select Customer"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txt_customer_name)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbl_customer)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmb_customer_id)
        Me.Panel1.Location = New System.Drawing.Point(18, 326)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 162)
        Me.Panel1.TabIndex = 12
        '
        'txt_customer_name
        '
        Me.txt_customer_name.Location = New System.Drawing.Point(98, 118)
        Me.txt_customer_name.Name = "txt_customer_name"
        Me.txt_customer_name.ReadOnly = True
        Me.txt_customer_name.Size = New System.Drawing.Size(132, 22)
        Me.txt_customer_name.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name:"
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer.Location = New System.Drawing.Point(64, 14)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(97, 25)
        Me.lbl_customer.TabIndex = 3
        Me.lbl_customer.Text = "Customer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ID:"
        '
        'cmb_customer_id
        '
        Me.cmb_customer_id.FormattingEnabled = True
        Me.cmb_customer_id.Location = New System.Drawing.Point(98, 58)
        Me.cmb_customer_id.Name = "cmb_customer_id"
        Me.cmb_customer_id.Size = New System.Drawing.Size(132, 24)
        Me.cmb_customer_id.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_add_cart)
        Me.Panel2.Controls.Add(Me.txt_product_total)
        Me.Panel2.Controls.Add(Me.lbl_total)
        Me.Panel2.Controls.Add(Me.lbl_product_quantity)
        Me.Panel2.Controls.Add(Me.txt_product_price)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.updown_quantity)
        Me.Panel2.Controls.Add(Me.txt_product_type)
        Me.Panel2.Controls.Add(Me.lbl_product_type)
        Me.Panel2.Controls.Add(Me.txt_product_brand)
        Me.Panel2.Controls.Add(Me.lbl_brand)
        Me.Panel2.Controls.Add(Me.txt_product_name)
        Me.Panel2.Controls.Add(Me.lbl_product_name)
        Me.Panel2.Controls.Add(Me.lbl_product_id)
        Me.Panel2.Controls.Add(Me.cmb_product_id)
        Me.Panel2.Controls.Add(Me.pic_product)
        Me.Panel2.Controls.Add(Me.lbl_product)
        Me.Panel2.Location = New System.Drawing.Point(283, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(483, 486)
        Me.Panel2.TabIndex = 11
        '
        'btn_add_cart
        '
        Me.btn_add_cart.Location = New System.Drawing.Point(322, 438)
        Me.btn_add_cart.Name = "btn_add_cart"
        Me.btn_add_cart.Size = New System.Drawing.Size(122, 38)
        Me.btn_add_cart.TabIndex = 5
        Me.btn_add_cart.Text = "Add to Cart"
        Me.btn_add_cart.UseVisualStyleBackColor = True
        '
        'txt_product_total
        '
        Me.txt_product_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product_total.Location = New System.Drawing.Point(230, 400)
        Me.txt_product_total.Name = "txt_product_total"
        Me.txt_product_total.ReadOnly = True
        Me.txt_product_total.Size = New System.Drawing.Size(214, 27)
        Me.txt_product_total.TabIndex = 25
        Me.txt_product_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(25, 400)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(191, 25)
        Me.lbl_total.TabIndex = 24
        Me.lbl_total.Text = "Total Price:          RM"
        '
        'lbl_product_quantity
        '
        Me.lbl_product_quantity.AutoSize = True
        Me.lbl_product_quantity.Location = New System.Drawing.Point(27, 325)
        Me.lbl_product_quantity.Name = "lbl_product_quantity"
        Me.lbl_product_quantity.Size = New System.Drawing.Size(61, 17)
        Me.lbl_product_quantity.TabIndex = 23
        Me.lbl_product_quantity.Text = "Quantity"
        '
        'txt_product_price
        '
        Me.txt_product_price.Location = New System.Drawing.Point(30, 291)
        Me.txt_product_price.Name = "txt_product_price"
        Me.txt_product_price.ReadOnly = True
        Me.txt_product_price.Size = New System.Drawing.Size(163, 22)
        Me.txt_product_price.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Price (RM)"
        '
        'updown_quantity
        '
        Me.updown_quantity.Location = New System.Drawing.Point(30, 350)
        Me.updown_quantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updown_quantity.Name = "updown_quantity"
        Me.updown_quantity.Size = New System.Drawing.Size(163, 22)
        Me.updown_quantity.TabIndex = 4
        Me.updown_quantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txt_product_type
        '
        Me.txt_product_type.Location = New System.Drawing.Point(30, 234)
        Me.txt_product_type.Name = "txt_product_type"
        Me.txt_product_type.ReadOnly = True
        Me.txt_product_type.Size = New System.Drawing.Size(163, 22)
        Me.txt_product_type.TabIndex = 20
        '
        'lbl_product_type
        '
        Me.lbl_product_type.AutoSize = True
        Me.lbl_product_type.Location = New System.Drawing.Point(27, 213)
        Me.lbl_product_type.Name = "lbl_product_type"
        Me.lbl_product_type.Size = New System.Drawing.Size(40, 17)
        Me.lbl_product_type.TabIndex = 19
        Me.lbl_product_type.Text = "Type"
        '
        'txt_product_brand
        '
        Me.txt_product_brand.Location = New System.Drawing.Point(30, 179)
        Me.txt_product_brand.Name = "txt_product_brand"
        Me.txt_product_brand.ReadOnly = True
        Me.txt_product_brand.Size = New System.Drawing.Size(163, 22)
        Me.txt_product_brand.TabIndex = 18
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.Location = New System.Drawing.Point(27, 158)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(46, 17)
        Me.lbl_brand.TabIndex = 17
        Me.lbl_brand.Text = "Brand"
        '
        'txt_product_name
        '
        Me.txt_product_name.Location = New System.Drawing.Point(30, 122)
        Me.txt_product_name.Name = "txt_product_name"
        Me.txt_product_name.ReadOnly = True
        Me.txt_product_name.Size = New System.Drawing.Size(163, 22)
        Me.txt_product_name.TabIndex = 16
        '
        'lbl_product_name
        '
        Me.lbl_product_name.AutoSize = True
        Me.lbl_product_name.Location = New System.Drawing.Point(27, 101)
        Me.lbl_product_name.Name = "lbl_product_name"
        Me.lbl_product_name.Size = New System.Drawing.Size(45, 17)
        Me.lbl_product_name.TabIndex = 15
        Me.lbl_product_name.Text = "Name"
        '
        'lbl_product_id
        '
        Me.lbl_product_id.AutoSize = True
        Me.lbl_product_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_id.Location = New System.Drawing.Point(26, 56)
        Me.lbl_product_id.Name = "lbl_product_id"
        Me.lbl_product_id.Size = New System.Drawing.Size(32, 24)
        Me.lbl_product_id.TabIndex = 12
        Me.lbl_product_id.Text = "ID:"
        '
        'cmb_product_id
        '
        Me.cmb_product_id.FormattingEnabled = True
        Me.cmb_product_id.Location = New System.Drawing.Point(64, 56)
        Me.cmb_product_id.Name = "cmb_product_id"
        Me.cmb_product_id.Size = New System.Drawing.Size(132, 24)
        Me.cmb_product_id.TabIndex = 3
        '
        'pic_product
        '
        Me.pic_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_product.Location = New System.Drawing.Point(211, 92)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(256, 280)
        Me.pic_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_product.TabIndex = 14
        Me.pic_product.TabStop = False
        '
        'lbl_product
        '
        Me.lbl_product.AutoSize = True
        Me.lbl_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product.Location = New System.Drawing.Point(167, 9)
        Me.lbl_product.Name = "lbl_product"
        Me.lbl_product.Size = New System.Drawing.Size(79, 25)
        Me.lbl_product.TabIndex = 11
        Me.lbl_product.Text = "Product"
        '
        'lbl_instruction_3
        '
        Me.lbl_instruction_3.AutoSize = True
        Me.lbl_instruction_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instruction_3.Location = New System.Drawing.Point(279, 57)
        Me.lbl_instruction_3.Name = "lbl_instruction_3"
        Me.lbl_instruction_3.Size = New System.Drawing.Size(135, 20)
        Me.lbl_instruction_3.TabIndex = 14
        Me.lbl_instruction_3.Text = "3. Select product"
        '
        'lbl_instruction_4
        '
        Me.lbl_instruction_4.AutoSize = True
        Me.lbl_instruction_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instruction_4.Location = New System.Drawing.Point(795, 57)
        Me.lbl_instruction_4.Name = "lbl_instruction_4"
        Me.lbl_instruction_4.Size = New System.Drawing.Size(196, 20)
        Me.lbl_instruction_4.TabIndex = 15
        Me.lbl_instruction_4.Text = "4. View and Confirm Cart"
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(18, 528)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(89, 38)
        Me.btn_back.TabIndex = 16
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_restart
        '
        Me.btn_restart.Location = New System.Drawing.Point(128, 528)
        Me.btn_restart.Name = "btn_restart"
        Me.btn_restart.Size = New System.Drawing.Size(129, 38)
        Me.btn_restart.TabIndex = 17
        Me.btn_restart.Text = "Remake Order"
        Me.btn_restart.UseVisualStyleBackColor = True
        '
        'frm_add_order_a189479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 589)
        Me.Controls.Add(Me.btn_restart)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_instruction_4)
        Me.Controls.Add(Me.lbl_instruction_3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbl_instruction_2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_instruction_1)
        Me.Controls.Add(Me.pnl_order)
        Me.Controls.Add(Me.pnl_staff)
        Me.Controls.Add(Me.lbl_new_order)
        Me.Name = "frm_add_order_a189479"
        Me.Text = "frm_add_order_a189479"
        Me.pnl_staff.ResumeLayout(False)
        Me.pnl_staff.PerformLayout()
        Me.pnl_order.ResumeLayout(False)
        Me.pnl_order.PerformLayout()
        CType(Me.grd_cart_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.updown_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_new_order As Label
    Friend WithEvents lbl_order_id As Label
    Friend WithEvents lbl_staff As Label
    Friend WithEvents cmb_staff_id As ComboBox
    Friend WithEvents lbl_order_id_data As Label
    Friend WithEvents lbl_staff_id As Label
    Friend WithEvents pnl_staff As Panel
    Friend WithEvents txt_staff_name As TextBox
    Friend WithEvents lbl_staff_name As Label
    Friend WithEvents pnl_order As Panel
    Friend WithEvents lbl_instruction_1 As Label
    Friend WithEvents lbl_instruction_2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_customer_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_customer As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_customer_id As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_product As Label
    Friend WithEvents lbl_instruction_3 As Label
    Friend WithEvents lbl_instruction_4 As Label
    Friend WithEvents updown_quantity As NumericUpDown
    Friend WithEvents txt_product_type As TextBox
    Friend WithEvents lbl_product_type As Label
    Friend WithEvents txt_product_brand As TextBox
    Friend WithEvents lbl_brand As Label
    Friend WithEvents txt_product_name As TextBox
    Friend WithEvents lbl_product_name As Label
    Friend WithEvents lbl_product_id As Label
    Friend WithEvents cmb_product_id As ComboBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents btn_add_cart As Button
    Friend WithEvents txt_product_total As TextBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_product_quantity As Label
    Friend WithEvents txt_product_price As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_clear_cart As Button
    Friend WithEvents btn_checkout As Button
    Friend WithEvents txt_cart_total As TextBox
    Friend WithEvents grd_cart_view As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_restart As Button
    Friend WithEvents fld_product_id As DataGridViewTextBoxColumn
    Friend WithEvents fld_product_name As DataGridViewTextBoxColumn
    Friend WithEvents fld_product_quantity As DataGridViewTextBoxColumn
    Friend WithEvents fld_product_total_price As DataGridViewTextBoxColumn
End Class
