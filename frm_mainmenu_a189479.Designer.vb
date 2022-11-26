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
        Me.btn_view_orders = New System.Windows.Forms.Button()
        Me.btn_view_customers = New System.Windows.Forms.Button()
        Me.btn_view_staff = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lbl_motto = New System.Windows.Forms.Label()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_menutitle
        '
        Me.lbl_menutitle.AutoSize = True
        Me.lbl_menutitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menutitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_menutitle.Location = New System.Drawing.Point(219, 18)
        Me.lbl_menutitle.Name = "lbl_menutitle"
        Me.lbl_menutitle.Size = New System.Drawing.Size(179, 36)
        Me.lbl_menutitle.TabIndex = 0
        Me.lbl_menutitle.Text = "Elite Hoops"
        Me.lbl_menutitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_short_menu_decription
        '
        Me.lbl_short_menu_decription.AutoSize = True
        Me.lbl_short_menu_decription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_short_menu_decription.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_short_menu_decription.Location = New System.Drawing.Point(224, 56)
        Me.lbl_short_menu_decription.Name = "lbl_short_menu_decription"
        Me.lbl_short_menu_decription.Size = New System.Drawing.Size(357, 20)
        Me.lbl_short_menu_decription.TabIndex = 1
        Me.lbl_short_menu_decription.Text = "#1 BasketBall && Equipments shop in Malaysia "
        '
        'btn_view_products
        '
        Me.btn_view_products.Location = New System.Drawing.Point(36, 243)
        Me.btn_view_products.Name = "btn_view_products"
        Me.btn_view_products.Size = New System.Drawing.Size(130, 40)
        Me.btn_view_products.TabIndex = 2
        Me.btn_view_products.Text = "View Products"
        Me.btn_view_products.UseVisualStyleBackColor = True
        '
        'btn_view_orders
        '
        Me.btn_view_orders.Location = New System.Drawing.Point(411, 363)
        Me.btn_view_orders.Name = "btn_view_orders"
        Me.btn_view_orders.Size = New System.Drawing.Size(130, 40)
        Me.btn_view_orders.TabIndex = 3
        Me.btn_view_orders.Text = "View Orders"
        Me.btn_view_orders.UseVisualStyleBackColor = True
        '
        'btn_view_customers
        '
        Me.btn_view_customers.Location = New System.Drawing.Point(411, 243)
        Me.btn_view_customers.Name = "btn_view_customers"
        Me.btn_view_customers.Size = New System.Drawing.Size(130, 40)
        Me.btn_view_customers.TabIndex = 4
        Me.btn_view_customers.Text = "View Customers"
        Me.btn_view_customers.UseVisualStyleBackColor = True
        '
        'btn_view_staff
        '
        Me.btn_view_staff.Location = New System.Drawing.Point(36, 363)
        Me.btn_view_staff.Name = "btn_view_staff"
        Me.btn_view_staff.Size = New System.Drawing.Size(130, 40)
        Me.btn_view_staff.TabIndex = 5
        Me.btn_view_staff.Text = "View Staffs"
        Me.btn_view_staff.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.DarkRed
        Me.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_exit.Location = New System.Drawing.Point(650, 393)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(114, 37)
        Me.btn_exit.TabIndex = 6
        Me.btn_exit.Text = "Exit Program"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'lbl_motto
        '
        Me.lbl_motto.AutoSize = True
        Me.lbl_motto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_motto.Location = New System.Drawing.Point(224, 103)
        Me.lbl_motto.Name = "lbl_motto"
        Me.lbl_motto.Size = New System.Drawing.Size(562, 34)
        Me.lbl_motto.TabIndex = 8
        Me.lbl_motto.Text = "We strive to provide best basketball equipments and create joy in basketball comm" &
    "unity." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Everyone can have fun !!!"
        '
        'pic_logo
        '
        Me.pic_logo.BackgroundImage = Global.PRJ_ELITEHOOPS_A189479.My.Resources.Resources.elite_hoops_logo
        Me.pic_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_logo.Image = Global.PRJ_ELITEHOOPS_A189479.My.Resources.Resources.elite_hoops_logo
        Me.pic_logo.Location = New System.Drawing.Point(18, 12)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(195, 141)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_logo.TabIndex = 7
        Me.pic_logo.TabStop = False
        '
        'frm_mainmenu_a189479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_motto)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_view_staff)
        Me.Controls.Add(Me.btn_view_customers)
        Me.Controls.Add(Me.btn_view_orders)
        Me.Controls.Add(Me.btn_view_products)
        Me.Controls.Add(Me.lbl_short_menu_decription)
        Me.Controls.Add(Me.lbl_menutitle)
        Me.Name = "frm_mainmenu_a189479"
        Me.Text = "Main Menu"
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents lbl_motto As Label
End Class
