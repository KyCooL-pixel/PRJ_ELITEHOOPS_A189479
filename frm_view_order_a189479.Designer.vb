<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_view_order_a189479
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
        Me.lbl_view_order = New System.Windows.Forms.Label()
        Me.lbl_order_id = New System.Windows.Forms.Label()
        Me.lbl_staff_id = New System.Windows.Forms.Label()
        Me.lbl_staff_id_data = New System.Windows.Forms.Label()
        Me.lbl_customer_id = New System.Windows.Forms.Label()
        Me.lbl_customer_id_data = New System.Windows.Forms.Label()
        Me.cmb_order_id = New System.Windows.Forms.ComboBox()
        Me.lbl_customer_name_data = New System.Windows.Forms.Label()
        Me.lbl_customer_name = New System.Windows.Forms.Label()
        Me.lbl_staff_name_data = New System.Windows.Forms.Label()
        Me.lbl_staff_name = New System.Windows.Forms.Label()
        Me.grd_order_view = New System.Windows.Forms.DataGridView()
        Me.lbl_order_datetime = New System.Windows.Forms.Label()
        Me.lbl_order_datetime_data = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_total_price_data = New System.Windows.Forms.Label()
        Me.lbl_total_price = New System.Windows.Forms.Label()
        Me.clm_product_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_product_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_total_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grd_order_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_view_order
        '
        Me.lbl_view_order.AutoSize = True
        Me.lbl_view_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_view_order.Location = New System.Drawing.Point(12, 9)
        Me.lbl_view_order.Name = "lbl_view_order"
        Me.lbl_view_order.Size = New System.Drawing.Size(145, 29)
        Me.lbl_view_order.TabIndex = 0
        Me.lbl_view_order.Text = "View Order"
        '
        'lbl_order_id
        '
        Me.lbl_order_id.AutoSize = True
        Me.lbl_order_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order_id.Location = New System.Drawing.Point(12, 63)
        Me.lbl_order_id.Name = "lbl_order_id"
        Me.lbl_order_id.Size = New System.Drawing.Size(91, 24)
        Me.lbl_order_id.TabIndex = 1
        Me.lbl_order_id.Text = "Order ID: "
        '
        'lbl_staff_id
        '
        Me.lbl_staff_id.AutoSize = True
        Me.lbl_staff_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_id.Location = New System.Drawing.Point(12, 91)
        Me.lbl_staff_id.Name = "lbl_staff_id"
        Me.lbl_staff_id.Size = New System.Drawing.Size(76, 24)
        Me.lbl_staff_id.TabIndex = 2
        Me.lbl_staff_id.Text = "Staff ID: "
        '
        'lbl_staff_id_data
        '
        Me.lbl_staff_id_data.AutoSize = True
        Me.lbl_staff_id_data.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_id_data.Location = New System.Drawing.Point(144, 92)
        Me.lbl_staff_id_data.Name = "lbl_staff_id_data"
        Me.lbl_staff_id_data.Size = New System.Drawing.Size(31, 22)
        Me.lbl_staff_id_data.TabIndex = 3
        Me.lbl_staff_id_data.Text = "---"
        '
        'lbl_customer_id
        '
        Me.lbl_customer_id.AutoSize = True
        Me.lbl_customer_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_id.Location = New System.Drawing.Point(12, 118)
        Me.lbl_customer_id.Name = "lbl_customer_id"
        Me.lbl_customer_id.Size = New System.Drawing.Size(123, 24)
        Me.lbl_customer_id.TabIndex = 4
        Me.lbl_customer_id.Text = "Customer ID: "
        '
        'lbl_customer_id_data
        '
        Me.lbl_customer_id_data.AutoSize = True
        Me.lbl_customer_id_data.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_id_data.Location = New System.Drawing.Point(144, 120)
        Me.lbl_customer_id_data.Name = "lbl_customer_id_data"
        Me.lbl_customer_id_data.Size = New System.Drawing.Size(31, 22)
        Me.lbl_customer_id_data.TabIndex = 5
        Me.lbl_customer_id_data.Text = "---"
        '
        'cmb_order_id
        '
        Me.cmb_order_id.FormattingEnabled = True
        Me.cmb_order_id.Location = New System.Drawing.Point(138, 63)
        Me.cmb_order_id.Name = "cmb_order_id"
        Me.cmb_order_id.Size = New System.Drawing.Size(104, 24)
        Me.cmb_order_id.TabIndex = 6
        '
        'lbl_customer_name_data
        '
        Me.lbl_customer_name_data.AutoSize = True
        Me.lbl_customer_name_data.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_name_data.Location = New System.Drawing.Point(411, 120)
        Me.lbl_customer_name_data.Name = "lbl_customer_name_data"
        Me.lbl_customer_name_data.Size = New System.Drawing.Size(31, 22)
        Me.lbl_customer_name_data.TabIndex = 10
        Me.lbl_customer_name_data.Text = "---"
        '
        'lbl_customer_name
        '
        Me.lbl_customer_name.AutoSize = True
        Me.lbl_customer_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_name.Location = New System.Drawing.Point(248, 118)
        Me.lbl_customer_name.Name = "lbl_customer_name"
        Me.lbl_customer_name.Size = New System.Drawing.Size(157, 24)
        Me.lbl_customer_name.TabIndex = 9
        Me.lbl_customer_name.Text = "Customer Name: "
        '
        'lbl_staff_name_data
        '
        Me.lbl_staff_name_data.AutoSize = True
        Me.lbl_staff_name_data.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_name_data.Location = New System.Drawing.Point(411, 91)
        Me.lbl_staff_name_data.Name = "lbl_staff_name_data"
        Me.lbl_staff_name_data.Size = New System.Drawing.Size(31, 22)
        Me.lbl_staff_name_data.TabIndex = 8
        Me.lbl_staff_name_data.Text = "---"
        '
        'lbl_staff_name
        '
        Me.lbl_staff_name.AutoSize = True
        Me.lbl_staff_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_name.Location = New System.Drawing.Point(248, 90)
        Me.lbl_staff_name.Name = "lbl_staff_name"
        Me.lbl_staff_name.Size = New System.Drawing.Size(110, 24)
        Me.lbl_staff_name.TabIndex = 7
        Me.lbl_staff_name.Text = "Staff Name: "
        '
        'grd_order_view
        '
        Me.grd_order_view.AllowUserToAddRows = False
        Me.grd_order_view.AllowUserToDeleteRows = False
        Me.grd_order_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_order_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order_view.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clm_product_id, Me.clm_quantity, Me.clm_product_price, Me.clm_total_price})
        Me.grd_order_view.Location = New System.Drawing.Point(12, 145)
        Me.grd_order_view.Name = "grd_order_view"
        Me.grd_order_view.RowHeadersWidth = 51
        Me.grd_order_view.RowTemplate.Height = 24
        Me.grd_order_view.Size = New System.Drawing.Size(830, 361)
        Me.grd_order_view.TabIndex = 11
        '
        'lbl_order_datetime
        '
        Me.lbl_order_datetime.AutoSize = True
        Me.lbl_order_datetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order_datetime.Location = New System.Drawing.Point(546, 61)
        Me.lbl_order_datetime.Name = "lbl_order_datetime"
        Me.lbl_order_datetime.Size = New System.Drawing.Size(110, 24)
        Me.lbl_order_datetime.TabIndex = 12
        Me.lbl_order_datetime.Text = "Ordered at: "
        '
        'lbl_order_datetime_data
        '
        Me.lbl_order_datetime_data.AutoSize = True
        Me.lbl_order_datetime_data.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order_datetime_data.Location = New System.Drawing.Point(652, 63)
        Me.lbl_order_datetime_data.Name = "lbl_order_datetime_data"
        Me.lbl_order_datetime_data.Size = New System.Drawing.Size(31, 22)
        Me.lbl_order_datetime_data.TabIndex = 13
        Me.lbl_order_datetime_data.Text = "---"
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(727, 574)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(115, 36)
        Me.btn_back.TabIndex = 14
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'lbl_total_price_data
        '
        Me.lbl_total_price_data.AutoSize = True
        Me.lbl_total_price_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_price_data.Location = New System.Drawing.Point(745, 509)
        Me.lbl_total_price_data.Name = "lbl_total_price_data"
        Me.lbl_total_price_data.Size = New System.Drawing.Size(64, 24)
        Me.lbl_total_price_data.TabIndex = 16
        Me.lbl_total_price_data.Text = "---------"
        Me.lbl_total_price_data.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_total_price
        '
        Me.lbl_total_price.AutoSize = True
        Me.lbl_total_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_price.Location = New System.Drawing.Point(546, 509)
        Me.lbl_total_price.Name = "lbl_total_price"
        Me.lbl_total_price.Size = New System.Drawing.Size(155, 24)
        Me.lbl_total_price.TabIndex = 15
        Me.lbl_total_price.Text = "Total Price (RM): "
        '
        'clm_product_id
        '
        Me.clm_product_id.HeaderText = "Product ID"
        Me.clm_product_id.MinimumWidth = 6
        Me.clm_product_id.Name = "clm_product_id"
        Me.clm_product_id.ReadOnly = True
        '
        'clm_quantity
        '
        Me.clm_quantity.HeaderText = "Quantity"
        Me.clm_quantity.MinimumWidth = 6
        Me.clm_quantity.Name = "clm_quantity"
        Me.clm_quantity.ReadOnly = True
        '
        'clm_product_price
        '
        Me.clm_product_price.HeaderText = "Price (RM)"
        Me.clm_product_price.MinimumWidth = 6
        Me.clm_product_price.Name = "clm_product_price"
        Me.clm_product_price.ReadOnly = True
        '
        'clm_total_price
        '
        Me.clm_total_price.HeaderText = "Total (RM)"
        Me.clm_total_price.MinimumWidth = 6
        Me.clm_total_price.Name = "clm_total_price"
        '
        'frm_view_order_a189479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 622)
        Me.Controls.Add(Me.lbl_total_price_data)
        Me.Controls.Add(Me.lbl_total_price)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_order_datetime_data)
        Me.Controls.Add(Me.lbl_order_datetime)
        Me.Controls.Add(Me.grd_order_view)
        Me.Controls.Add(Me.lbl_customer_name_data)
        Me.Controls.Add(Me.lbl_customer_name)
        Me.Controls.Add(Me.lbl_staff_name_data)
        Me.Controls.Add(Me.lbl_staff_name)
        Me.Controls.Add(Me.cmb_order_id)
        Me.Controls.Add(Me.lbl_customer_id_data)
        Me.Controls.Add(Me.lbl_customer_id)
        Me.Controls.Add(Me.lbl_staff_id_data)
        Me.Controls.Add(Me.lbl_staff_id)
        Me.Controls.Add(Me.lbl_order_id)
        Me.Controls.Add(Me.lbl_view_order)
        Me.Name = "frm_view_order_a189479"
        Me.Text = "frm_view_order_a189479"
        CType(Me.grd_order_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_view_order As Label
    Friend WithEvents lbl_order_id As Label
    Friend WithEvents lbl_staff_id As Label
    Friend WithEvents lbl_staff_id_data As Label
    Friend WithEvents lbl_customer_id As Label
    Friend WithEvents lbl_customer_id_data As Label
    Friend WithEvents cmb_order_id As ComboBox
    Friend WithEvents lbl_customer_name_data As Label
    Friend WithEvents lbl_customer_name As Label
    Friend WithEvents lbl_staff_name_data As Label
    Friend WithEvents lbl_staff_name As Label
    Friend WithEvents grd_order_view As DataGridView
    Friend WithEvents lbl_order_datetime As Label
    Friend WithEvents lbl_order_datetime_data As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_total_price_data As Label
    Friend WithEvents lbl_total_price As Label
    Friend WithEvents clm_product_id As DataGridViewTextBoxColumn
    Friend WithEvents clm_quantity As DataGridViewTextBoxColumn
    Friend WithEvents clm_product_price As DataGridViewTextBoxColumn
    Friend WithEvents clm_total_price As DataGridViewTextBoxColumn
End Class
