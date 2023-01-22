<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_mainmenu_a189479
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_menutitle = New System.Windows.Forms.Label()
        Me.lbl_short_menu_decription = New System.Windows.Forms.Label()
        Me.btn_view_products = New System.Windows.Forms.Button()
        Me.btn_view_customers = New System.Windows.Forms.Button()
        Me.btn_view_staff = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.linklbl_github = New System.Windows.Forms.LinkLabel()
        Me.btn_view_orders = New System.Windows.Forms.Button()
        Me.btn_add_order = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_menutitle
        '
        Me.lbl_menutitle.AutoSize = True
        Me.lbl_menutitle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_menutitle.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menutitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_menutitle.Location = New System.Drawing.Point(23, -4)
        Me.lbl_menutitle.Name = "lbl_menutitle"
        Me.lbl_menutitle.Size = New System.Drawing.Size(237, 54)
        Me.lbl_menutitle.TabIndex = 0
        Me.lbl_menutitle.Text = "Elite Hoops"
        Me.lbl_menutitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_short_menu_decription
        '
        Me.lbl_short_menu_decription.AutoSize = True
        Me.lbl_short_menu_decription.BackColor = System.Drawing.SystemColors.InfoText
        Me.lbl_short_menu_decription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_short_menu_decription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_short_menu_decription.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_short_menu_decription.Location = New System.Drawing.Point(33, 49)
        Me.lbl_short_menu_decription.Name = "lbl_short_menu_decription"
        Me.lbl_short_menu_decription.Size = New System.Drawing.Size(415, 27)
        Me.lbl_short_menu_decription.TabIndex = 1
        Me.lbl_short_menu_decription.Text = "#1 BasketBall && Equipments shop in Malaysia "
        '
        'btn_view_products
        '
        Me.btn_view_products.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_view_products.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view_products.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_view_products.Location = New System.Drawing.Point(33, 131)
        Me.btn_view_products.Name = "btn_view_products"
        Me.btn_view_products.Size = New System.Drawing.Size(195, 40)
        Me.btn_view_products.TabIndex = 2
        Me.btn_view_products.Text = "Products"
        Me.btn_view_products.UseVisualStyleBackColor = False
        '
        'btn_view_customers
        '
        Me.btn_view_customers.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_view_customers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view_customers.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btn_view_customers.Location = New System.Drawing.Point(542, 258)
        Me.btn_view_customers.Margin = New System.Windows.Forms.Padding(3, 3, 30, 3)
        Me.btn_view_customers.Name = "btn_view_customers"
        Me.btn_view_customers.Size = New System.Drawing.Size(195, 40)
        Me.btn_view_customers.TabIndex = 4
        Me.btn_view_customers.Text = "Customers"
        Me.btn_view_customers.UseVisualStyleBackColor = False
        '
        'btn_view_staff
        '
        Me.btn_view_staff.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_view_staff.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_view_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view_staff.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btn_view_staff.Location = New System.Drawing.Point(542, 168)
        Me.btn_view_staff.Margin = New System.Windows.Forms.Padding(3, 3, 30, 3)
        Me.btn_view_staff.Name = "btn_view_staff"
        Me.btn_view_staff.Size = New System.Drawing.Size(195, 40)
        Me.btn_view_staff.TabIndex = 5
        Me.btn_view_staff.Text = "Staffs"
        Me.btn_view_staff.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.DarkRed
        Me.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_exit.Location = New System.Drawing.Point(623, 401)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(3, 3, 30, 3)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(114, 37)
        Me.btn_exit.TabIndex = 6
        Me.btn_exit.Text = "Exit Program"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'linklbl_github
        '
        Me.linklbl_github.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.linklbl_github.AutoSize = True
        Me.linklbl_github.BackColor = System.Drawing.Color.Transparent
        Me.linklbl_github.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linklbl_github.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.linklbl_github.LinkArea = New System.Windows.Forms.LinkArea(28, 11)
        Me.linklbl_github.Location = New System.Drawing.Point(6, 420)
        Me.linklbl_github.Name = "linklbl_github"
        Me.linklbl_github.Size = New System.Drawing.Size(291, 22)
        Me.linklbl_github.TabIndex = 9
        Me.linklbl_github.TabStop = True
        Me.linklbl_github.Text = "For more info, check out my github page"
        Me.linklbl_github.UseCompatibleTextRendering = True
        '
        'btn_view_orders
        '
        Me.btn_view_orders.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_view_orders.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view_orders.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_view_orders.Location = New System.Drawing.Point(32, 218)
        Me.btn_view_orders.Name = "btn_view_orders"
        Me.btn_view_orders.Size = New System.Drawing.Size(195, 40)
        Me.btn_view_orders.TabIndex = 3
        Me.btn_view_orders.Text = "View Orders"
        Me.btn_view_orders.UseVisualStyleBackColor = False
        '
        'btn_add_order
        '
        Me.btn_add_order.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_add_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_order.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_add_order.Location = New System.Drawing.Point(33, 305)
        Me.btn_add_order.Name = "btn_add_order"
        Me.btn_add_order.Size = New System.Drawing.Size(195, 40)
        Me.btn_add_order.TabIndex = 10
        Me.btn_add_order.Text = "Add Order"
        Me.btn_add_order.UseVisualStyleBackColor = False
        '
        'frm_mainmenu_a189479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.PRJ_ELITEHOOPS_A189479.My.Resources.Resources.tj_dragotta_Gl0jBJJTDWs_unsplash
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(793, 450)
        Me.Controls.Add(Me.btn_add_order)
        Me.Controls.Add(Me.linklbl_github)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_view_staff)
        Me.Controls.Add(Me.btn_view_customers)
        Me.Controls.Add(Me.btn_view_orders)
        Me.Controls.Add(Me.btn_view_products)
        Me.Controls.Add(Me.lbl_short_menu_decription)
        Me.Controls.Add(Me.lbl_menutitle)
        Me.Name = "frm_mainmenu_a189479"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_menutitle As Label
    Friend WithEvents lbl_short_menu_decription As Label
    Friend WithEvents btn_view_products As Button
    Friend WithEvents btn_view_orders As Button
    Friend WithEvents btn_view_customers As Button
    Friend WithEvents btn_view_staff As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents linklbl_github As LinkLabel
    Friend WithEvents btn_add_order As Button
End Class
