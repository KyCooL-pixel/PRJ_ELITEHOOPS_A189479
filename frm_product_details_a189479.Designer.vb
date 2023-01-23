<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_product_details_a189479
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_product_details_a189479))
        Me.btn_delete_product = New System.Windows.Forms.Button()
        Me.btn_new_product = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_product_id = New System.Windows.Forms.RichTextBox()
        Me.txt_type = New System.Windows.Forms.RichTextBox()
        Me.txt_year = New System.Windows.Forms.RichTextBox()
        Me.txt_brand = New System.Windows.Forms.RichTextBox()
        Me.txt_price = New System.Windows.Forms.RichTextBox()
        Me.txt_description = New System.Windows.Forms.RichTextBox()
        Me.btn_update_product = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lst_productid = New System.Windows.Forms.ListBox()
        Me.btn_save_product = New System.Windows.Forms.Button()
        Me.txt_product_name = New System.Windows.Forms.RichTextBox()
        Me.btn_back_main_menu = New System.Windows.Forms.Button()
        Me.btn_change_picture = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_table_view = New System.Windows.Forms.Button()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_delete_product
        '
        Me.btn_delete_product.ForeColor = System.Drawing.Color.Crimson
        Me.btn_delete_product.Location = New System.Drawing.Point(817, 488)
        Me.btn_delete_product.Name = "btn_delete_product"
        Me.btn_delete_product.Size = New System.Drawing.Size(95, 29)
        Me.btn_delete_product.TabIndex = 1
        Me.btn_delete_product.Text = "Delete"
        Me.btn_delete_product.UseVisualStyleBackColor = True
        '
        'btn_new_product
        '
        Me.btn_new_product.Location = New System.Drawing.Point(723, 488)
        Me.btn_new_product.Name = "btn_new_product"
        Me.btn_new_product.Size = New System.Drawing.Size(93, 29)
        Me.btn_new_product.TabIndex = 2
        Me.btn_new_product.Text = "Add"
        Me.btn_new_product.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(248, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(248, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(248, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "PRICE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(248, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "BRAND"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(248, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "TYPE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(248, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "YEARS OF WARRANTY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(23, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "DESCRIPTION"
        '
        'txt_product_id
        '
        Me.txt_product_id.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_product_id.Location = New System.Drawing.Point(429, 56)
        Me.txt_product_id.Name = "txt_product_id"
        Me.txt_product_id.ReadOnly = True
        Me.txt_product_id.Size = New System.Drawing.Size(266, 24)
        Me.txt_product_id.TabIndex = 11
        Me.txt_product_id.Text = ""
        '
        'txt_type
        '
        Me.txt_type.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_type.Location = New System.Drawing.Point(429, 239)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.ReadOnly = True
        Me.txt_type.Size = New System.Drawing.Size(266, 24)
        Me.txt_type.TabIndex = 12
        Me.txt_type.Text = ""
        '
        'txt_year
        '
        Me.txt_year.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_year.Location = New System.Drawing.Point(429, 283)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.ReadOnly = True
        Me.txt_year.Size = New System.Drawing.Size(266, 24)
        Me.txt_year.TabIndex = 13
        Me.txt_year.Text = ""
        '
        'txt_brand
        '
        Me.txt_brand.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_brand.Location = New System.Drawing.Point(429, 191)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.ReadOnly = True
        Me.txt_brand.Size = New System.Drawing.Size(266, 24)
        Me.txt_brand.TabIndex = 14
        Me.txt_brand.Text = ""
        '
        'txt_price
        '
        Me.txt_price.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_price.Location = New System.Drawing.Point(429, 142)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(266, 24)
        Me.txt_price.TabIndex = 15
        Me.txt_price.Text = ""
        '
        'txt_description
        '
        Me.txt_description.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_description.Location = New System.Drawing.Point(26, 338)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.ReadOnly = True
        Me.txt_description.Size = New System.Drawing.Size(669, 139)
        Me.txt_description.TabIndex = 17
        Me.txt_description.Text = ""
        '
        'btn_update_product
        '
        Me.btn_update_product.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_update_product.Location = New System.Drawing.Point(580, 488)
        Me.btn_update_product.Name = "btn_update_product"
        Me.btn_update_product.Size = New System.Drawing.Size(115, 29)
        Me.btn_update_product.TabIndex = 18
        Me.btn_update_product.Text = "Update"
        Me.btn_update_product.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(23, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(252, 29)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "PRODUCT DETAILS"
        '
        'lst_productid
        '
        Me.lst_productid.FormattingEnabled = True
        Me.lst_productid.ItemHeight = 16
        Me.lst_productid.Location = New System.Drawing.Point(723, 56)
        Me.lst_productid.Name = "lst_productid"
        Me.lst_productid.Size = New System.Drawing.Size(189, 420)
        Me.lst_productid.TabIndex = 20
        '
        'btn_save_product
        '
        Me.btn_save_product.Enabled = False
        Me.btn_save_product.Location = New System.Drawing.Point(464, 488)
        Me.btn_save_product.Name = "btn_save_product"
        Me.btn_save_product.Size = New System.Drawing.Size(115, 29)
        Me.btn_save_product.TabIndex = 21
        Me.btn_save_product.Text = "Save"
        Me.btn_save_product.UseVisualStyleBackColor = True
        '
        'txt_product_name
        '
        Me.txt_product_name.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_product_name.Location = New System.Drawing.Point(429, 97)
        Me.txt_product_name.Name = "txt_product_name"
        Me.txt_product_name.ReadOnly = True
        Me.txt_product_name.Size = New System.Drawing.Size(266, 24)
        Me.txt_product_name.TabIndex = 11
        Me.txt_product_name.Text = ""
        '
        'btn_back_main_menu
        '
        Me.btn_back_main_menu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_back_main_menu.Location = New System.Drawing.Point(28, 492)
        Me.btn_back_main_menu.Name = "btn_back_main_menu"
        Me.btn_back_main_menu.Size = New System.Drawing.Size(112, 24)
        Me.btn_back_main_menu.TabIndex = 22
        Me.btn_back_main_menu.Text = "Back"
        Me.btn_back_main_menu.UseVisualStyleBackColor = False
        '
        'btn_change_picture
        '
        Me.btn_change_picture.Enabled = False
        Me.btn_change_picture.Location = New System.Drawing.Point(88, 288)
        Me.btn_change_picture.Name = "btn_change_picture"
        Me.btn_change_picture.Size = New System.Drawing.Size(88, 28)
        Me.btn_change_picture.TabIndex = 23
        Me.btn_change_picture.Text = "change"
        Me.btn_change_picture.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_table_view
        '
        Me.btn_table_view.Location = New System.Drawing.Point(723, 27)
        Me.btn_table_view.Name = "btn_table_view"
        Me.btn_table_view.Size = New System.Drawing.Size(189, 24)
        Me.btn_table_view.TabIndex = 24
        Me.btn_table_view.Text = "Table View"
        Me.btn_table_view.UseVisualStyleBackColor = True
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Enabled = False
        Me.pic_product.Location = New System.Drawing.Point(26, 56)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(220, 227)
        Me.pic_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_product.TabIndex = 3
        Me.pic_product.TabStop = False
        '
        'frm_product_details_a189479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(941, 539)
        Me.Controls.Add(Me.btn_table_view)
        Me.Controls.Add(Me.btn_change_picture)
        Me.Controls.Add(Me.btn_back_main_menu)
        Me.Controls.Add(Me.btn_save_product)
        Me.Controls.Add(Me.lst_productid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_update_product)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_product_name)
        Me.Controls.Add(Me.txt_product_id)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.btn_new_product)
        Me.Controls.Add(Me.btn_delete_product)
        Me.Name = "frm_product_details_a189479"
        Me.Text = "Products"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_delete_product As Button
    Friend WithEvents btn_new_product As Button
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_product_id As RichTextBox
    Friend WithEvents txt_type As RichTextBox
    Friend WithEvents txt_year As RichTextBox
    Friend WithEvents txt_brand As RichTextBox
    Friend WithEvents txt_price As RichTextBox
    Friend WithEvents txt_description As RichTextBox
    Friend WithEvents btn_update_product As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lst_productid As ListBox
    Friend WithEvents btn_save_product As Button
    Friend WithEvents txt_product_name As RichTextBox
    Friend WithEvents btn_back_main_menu As Button
    Friend WithEvents btn_change_picture As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_table_view As Button
End Class
