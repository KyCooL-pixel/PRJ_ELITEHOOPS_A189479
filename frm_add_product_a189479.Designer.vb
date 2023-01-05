<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_add_product_a189479
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
        Me.lbl_add_product = New System.Windows.Forms.Label()
        Me.txt_product_id = New System.Windows.Forms.TextBox()
        Me.lbl_product_id = New System.Windows.Forms.Label()
        Me.lbl_year = New System.Windows.Forms.Label()
        Me.txt_warranty_year = New System.Windows.Forms.TextBox()
        Me.lbl_product_brand = New System.Windows.Forms.Label()
        Me.txt_product_brand = New System.Windows.Forms.TextBox()
        Me.lbl_product_price = New System.Windows.Forms.Label()
        Me.txt_product_price = New System.Windows.Forms.TextBox()
        Me.lbl_product_name = New System.Windows.Forms.Label()
        Me.txt_product_name = New System.Windows.Forms.TextBox()
        Me.txt_product_type = New System.Windows.Forms.TextBox()
        Me.lbl_product_type = New System.Windows.Forms.Label()
        Me.txt_product_description = New System.Windows.Forms.TextBox()
        Me.lbl_product_description = New System.Windows.Forms.Label()
        Me.grd_product_view = New System.Windows.Forms.DataGridView()
        Me.btn_add_product = New System.Windows.Forms.Button()
        Me.btn_clear_fields = New System.Windows.Forms.Button()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.btn_select_picture = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_back_to_details = New System.Windows.Forms.Button()
        CType(Me.grd_product_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_add_product
        '
        Me.lbl_add_product.AutoSize = True
        Me.lbl_add_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_add_product.Location = New System.Drawing.Point(25, 22)
        Me.lbl_add_product.Name = "lbl_add_product"
        Me.lbl_add_product.Size = New System.Drawing.Size(115, 24)
        Me.lbl_add_product.TabIndex = 0
        Me.lbl_add_product.Text = "Add Product"
        '
        'txt_product_id
        '
        Me.txt_product_id.Location = New System.Drawing.Point(28, 69)
        Me.txt_product_id.Name = "txt_product_id"
        Me.txt_product_id.ReadOnly = True
        Me.txt_product_id.Size = New System.Drawing.Size(202, 22)
        Me.txt_product_id.TabIndex = 1
        '
        'lbl_product_id
        '
        Me.lbl_product_id.AutoSize = True
        Me.lbl_product_id.Location = New System.Drawing.Point(25, 49)
        Me.lbl_product_id.Name = "lbl_product_id"
        Me.lbl_product_id.Size = New System.Drawing.Size(93, 17)
        Me.lbl_product_id.TabIndex = 2
        Me.lbl_product_id.Text = "PRODUCT ID"
        '
        'lbl_year
        '
        Me.lbl_year.AutoSize = True
        Me.lbl_year.Location = New System.Drawing.Point(244, 49)
        Me.lbl_year.Name = "lbl_year"
        Me.lbl_year.Size = New System.Drawing.Size(151, 17)
        Me.lbl_year.TabIndex = 4
        Me.lbl_year.Text = "YEAR OF WARRANTY"
        '
        'txt_warranty_year
        '
        Me.txt_warranty_year.Location = New System.Drawing.Point(247, 69)
        Me.txt_warranty_year.Name = "txt_warranty_year"
        Me.txt_warranty_year.Size = New System.Drawing.Size(202, 22)
        Me.txt_warranty_year.TabIndex = 3
        '
        'lbl_product_brand
        '
        Me.lbl_product_brand.AutoSize = True
        Me.lbl_product_brand.Location = New System.Drawing.Point(28, 229)
        Me.lbl_product_brand.Name = "lbl_product_brand"
        Me.lbl_product_brand.Size = New System.Drawing.Size(128, 17)
        Me.lbl_product_brand.TabIndex = 6
        Me.lbl_product_brand.Text = "PRODUCT BRAND"
        '
        'txt_product_brand
        '
        Me.txt_product_brand.Location = New System.Drawing.Point(28, 249)
        Me.txt_product_brand.Name = "txt_product_brand"
        Me.txt_product_brand.Size = New System.Drawing.Size(202, 22)
        Me.txt_product_brand.TabIndex = 5
        '
        'lbl_product_price
        '
        Me.lbl_product_price.AutoSize = True
        Me.lbl_product_price.Location = New System.Drawing.Point(28, 169)
        Me.lbl_product_price.Name = "lbl_product_price"
        Me.lbl_product_price.Size = New System.Drawing.Size(120, 17)
        Me.lbl_product_price.TabIndex = 8
        Me.lbl_product_price.Text = "PRODUCT PRICE"
        '
        'txt_product_price
        '
        Me.txt_product_price.Location = New System.Drawing.Point(28, 189)
        Me.txt_product_price.Name = "txt_product_price"
        Me.txt_product_price.Size = New System.Drawing.Size(202, 22)
        Me.txt_product_price.TabIndex = 7
        '
        'lbl_product_name
        '
        Me.lbl_product_name.AutoSize = True
        Me.lbl_product_name.Location = New System.Drawing.Point(25, 112)
        Me.lbl_product_name.Name = "lbl_product_name"
        Me.lbl_product_name.Size = New System.Drawing.Size(119, 17)
        Me.lbl_product_name.TabIndex = 10
        Me.lbl_product_name.Text = "PRODUCT NAME"
        '
        'txt_product_name
        '
        Me.txt_product_name.Location = New System.Drawing.Point(28, 132)
        Me.txt_product_name.Name = "txt_product_name"
        Me.txt_product_name.Size = New System.Drawing.Size(202, 22)
        Me.txt_product_name.TabIndex = 9
        '
        'txt_product_type
        '
        Me.txt_product_type.Location = New System.Drawing.Point(28, 308)
        Me.txt_product_type.Name = "txt_product_type"
        Me.txt_product_type.Size = New System.Drawing.Size(202, 22)
        Me.txt_product_type.TabIndex = 3
        '
        'lbl_product_type
        '
        Me.lbl_product_type.AutoSize = True
        Me.lbl_product_type.Location = New System.Drawing.Point(28, 288)
        Me.lbl_product_type.Name = "lbl_product_type"
        Me.lbl_product_type.Size = New System.Drawing.Size(116, 17)
        Me.lbl_product_type.TabIndex = 4
        Me.lbl_product_type.Text = "PRODUCT TYPE"
        '
        'txt_product_description
        '
        Me.txt_product_description.Location = New System.Drawing.Point(247, 142)
        Me.txt_product_description.Multiline = True
        Me.txt_product_description.Name = "txt_product_description"
        Me.txt_product_description.Size = New System.Drawing.Size(202, 198)
        Me.txt_product_description.TabIndex = 3
        '
        'lbl_product_description
        '
        Me.lbl_product_description.AutoSize = True
        Me.lbl_product_description.Location = New System.Drawing.Point(244, 112)
        Me.lbl_product_description.Name = "lbl_product_description"
        Me.lbl_product_description.Size = New System.Drawing.Size(172, 17)
        Me.lbl_product_description.TabIndex = 4
        Me.lbl_product_description.Text = "PRODUCT DESCRIPTION"
        '
        'grd_product_view
        '
        Me.grd_product_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product_view.Location = New System.Drawing.Point(315, 251)
        Me.grd_product_view.Name = "grd_product_view"
        Me.grd_product_view.RowHeadersWidth = 51
        Me.grd_product_view.RowTemplate.Height = 24
        Me.grd_product_view.Size = New System.Drawing.Size(10, 20)
        Me.grd_product_view.TabIndex = 11
        Me.grd_product_view.Visible = False
        '
        'btn_add_product
        '
        Me.btn_add_product.Location = New System.Drawing.Point(552, 430)
        Me.btn_add_product.Name = "btn_add_product"
        Me.btn_add_product.Size = New System.Drawing.Size(137, 40)
        Me.btn_add_product.TabIndex = 12
        Me.btn_add_product.Text = "Add Product"
        Me.btn_add_product.UseVisualStyleBackColor = True
        '
        'btn_clear_fields
        '
        Me.btn_clear_fields.Location = New System.Drawing.Point(410, 430)
        Me.btn_clear_fields.Name = "btn_clear_fields"
        Me.btn_clear_fields.Size = New System.Drawing.Size(127, 40)
        Me.btn_clear_fields.TabIndex = 13
        Me.btn_clear_fields.Text = "Clear"
        Me.btn_clear_fields.UseVisualStyleBackColor = True
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(474, 69)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(215, 236)
        Me.pic_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pic_product.TabIndex = 14
        Me.pic_product.TabStop = False
        '
        'btn_select_picture
        '
        Me.btn_select_picture.Location = New System.Drawing.Point(474, 316)
        Me.btn_select_picture.Name = "btn_select_picture"
        Me.btn_select_picture.Size = New System.Drawing.Size(215, 23)
        Me.btn_select_picture.TabIndex = 15
        Me.btn_select_picture.Text = "Select Picture"
        Me.btn_select_picture.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_back_to_details
        '
        Me.btn_back_to_details.Location = New System.Drawing.Point(31, 430)
        Me.btn_back_to_details.Name = "btn_back_to_details"
        Me.btn_back_to_details.Size = New System.Drawing.Size(109, 40)
        Me.btn_back_to_details.TabIndex = 16
        Me.btn_back_to_details.Text = "Back"
        Me.btn_back_to_details.UseVisualStyleBackColor = True
        '
        'frm_add_product_a189479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 496)
        Me.Controls.Add(Me.btn_back_to_details)
        Me.Controls.Add(Me.btn_select_picture)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.btn_clear_fields)
        Me.Controls.Add(Me.btn_add_product)
        Me.Controls.Add(Me.lbl_product_name)
        Me.Controls.Add(Me.txt_product_name)
        Me.Controls.Add(Me.lbl_product_price)
        Me.Controls.Add(Me.txt_product_price)
        Me.Controls.Add(Me.lbl_product_brand)
        Me.Controls.Add(Me.txt_product_brand)
        Me.Controls.Add(Me.lbl_product_type)
        Me.Controls.Add(Me.lbl_product_description)
        Me.Controls.Add(Me.lbl_year)
        Me.Controls.Add(Me.txt_product_description)
        Me.Controls.Add(Me.txt_product_type)
        Me.Controls.Add(Me.txt_warranty_year)
        Me.Controls.Add(Me.lbl_product_id)
        Me.Controls.Add(Me.txt_product_id)
        Me.Controls.Add(Me.lbl_add_product)
        Me.Controls.Add(Me.grd_product_view)
        Me.Name = "frm_add_product_a189479"
        Me.Text = "frm_add_product_a189479"
        CType(Me.grd_product_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_add_product As Label
    Friend WithEvents txt_product_id As TextBox
    Friend WithEvents lbl_product_id As Label
    Friend WithEvents lbl_year As Label
    Friend WithEvents txt_warranty_year As TextBox
    Friend WithEvents lbl_product_brand As Label
    Friend WithEvents txt_product_brand As TextBox
    Friend WithEvents lbl_product_price As Label
    Friend WithEvents txt_product_price As TextBox
    Friend WithEvents lbl_product_name As Label
    Friend WithEvents txt_product_name As TextBox
    Friend WithEvents txt_product_type As TextBox
    Friend WithEvents lbl_product_type As Label
    Friend WithEvents txt_product_description As TextBox
    Friend WithEvents lbl_product_description As Label
    Friend WithEvents grd_product_view As DataGridView
    Friend WithEvents btn_add_product As Button
    Friend WithEvents btn_clear_fields As Button
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents btn_select_picture As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_back_to_details As Button
End Class
