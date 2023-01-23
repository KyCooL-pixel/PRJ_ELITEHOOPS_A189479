<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insert_customer_a189479
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
        Me.btn_add_staff = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_back_to_details = New System.Windows.Forms.Button()
        Me.cmb_customer_tier = New System.Windows.Forms.ComboBox()
        Me.txt_customer_name = New System.Windows.Forms.TextBox()
        Me.txt_customer_id = New System.Windows.Forms.TextBox()
        Me.lbl_customer_tier = New System.Windows.Forms.Label()
        Me.lbl_customer_name = New System.Windows.Forms.Label()
        Me.lbl_customer_id = New System.Windows.Forms.Label()
        Me.lbl_add_customer = New System.Windows.Forms.Label()
        Me.grd_staff_view = New System.Windows.Forms.DataGridView()
        Me.lbl_customer_address = New System.Windows.Forms.Label()
        Me.txt_customer_address = New System.Windows.Forms.TextBox()
        Me.lbl_customer_phone_number = New System.Windows.Forms.Label()
        Me.txt_customer_number = New System.Windows.Forms.TextBox()
        CType(Me.grd_staff_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_add_staff
        '
        Me.btn_add_staff.Location = New System.Drawing.Point(678, 405)
        Me.btn_add_staff.Name = "btn_add_staff"
        Me.btn_add_staff.Size = New System.Drawing.Size(75, 23)
        Me.btn_add_staff.TabIndex = 15
        Me.btn_add_staff.Text = "Add"
        Me.btn_add_staff.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(577, 405)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 16
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_back_to_details
        '
        Me.btn_back_to_details.Location = New System.Drawing.Point(27, 405)
        Me.btn_back_to_details.Name = "btn_back_to_details"
        Me.btn_back_to_details.Size = New System.Drawing.Size(75, 23)
        Me.btn_back_to_details.TabIndex = 17
        Me.btn_back_to_details.Text = "Back"
        Me.btn_back_to_details.UseVisualStyleBackColor = True
        '
        'cmb_customer_tier
        '
        Me.cmb_customer_tier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_customer_tier.FormattingEnabled = True
        Me.cmb_customer_tier.Items.AddRange(New Object() {"SILVER", "GOLD", "PLATINUM"})
        Me.cmb_customer_tier.Location = New System.Drawing.Point(27, 242)
        Me.cmb_customer_tier.Name = "cmb_customer_tier"
        Me.cmb_customer_tier.Size = New System.Drawing.Size(329, 24)
        Me.cmb_customer_tier.TabIndex = 14
        '
        'txt_customer_name
        '
        Me.txt_customer_name.Location = New System.Drawing.Point(384, 87)
        Me.txt_customer_name.Name = "txt_customer_name"
        Me.txt_customer_name.Size = New System.Drawing.Size(369, 22)
        Me.txt_customer_name.TabIndex = 12
        '
        'txt_customer_id
        '
        Me.txt_customer_id.Location = New System.Drawing.Point(27, 87)
        Me.txt_customer_id.Name = "txt_customer_id"
        Me.txt_customer_id.Size = New System.Drawing.Size(329, 22)
        Me.txt_customer_id.TabIndex = 13
        '
        'lbl_customer_tier
        '
        Me.lbl_customer_tier.AutoSize = True
        Me.lbl_customer_tier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_tier.Location = New System.Drawing.Point(24, 207)
        Me.lbl_customer_tier.Name = "lbl_customer_tier"
        Me.lbl_customer_tier.Size = New System.Drawing.Size(38, 20)
        Me.lbl_customer_tier.TabIndex = 11
        Me.lbl_customer_tier.Text = "Tier"
        '
        'lbl_customer_name
        '
        Me.lbl_customer_name.AutoSize = True
        Me.lbl_customer_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_name.Location = New System.Drawing.Point(380, 56)
        Me.lbl_customer_name.Name = "lbl_customer_name"
        Me.lbl_customer_name.Size = New System.Drawing.Size(53, 20)
        Me.lbl_customer_name.TabIndex = 10
        Me.lbl_customer_name.Text = "Name"
        '
        'lbl_customer_id
        '
        Me.lbl_customer_id.AutoSize = True
        Me.lbl_customer_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_id.Location = New System.Drawing.Point(24, 58)
        Me.lbl_customer_id.Name = "lbl_customer_id"
        Me.lbl_customer_id.Size = New System.Drawing.Size(22, 18)
        Me.lbl_customer_id.TabIndex = 9
        Me.lbl_customer_id.Text = "ID"
        '
        'lbl_add_customer
        '
        Me.lbl_add_customer.AutoSize = True
        Me.lbl_add_customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_add_customer.Location = New System.Drawing.Point(23, 21)
        Me.lbl_add_customer.Name = "lbl_add_customer"
        Me.lbl_add_customer.Size = New System.Drawing.Size(153, 25)
        Me.lbl_add_customer.TabIndex = 8
        Me.lbl_add_customer.Text = "New Customer"
        '
        'grd_staff_view
        '
        Me.grd_staff_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff_view.Location = New System.Drawing.Point(337, 87)
        Me.grd_staff_view.Name = "grd_staff_view"
        Me.grd_staff_view.RowHeadersWidth = 51
        Me.grd_staff_view.RowTemplate.Height = 24
        Me.grd_staff_view.Size = New System.Drawing.Size(10, 18)
        Me.grd_staff_view.TabIndex = 18
        Me.grd_staff_view.Visible = False
        '
        'lbl_customer_address
        '
        Me.lbl_customer_address.AutoSize = True
        Me.lbl_customer_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_address.Location = New System.Drawing.Point(24, 128)
        Me.lbl_customer_address.Name = "lbl_customer_address"
        Me.lbl_customer_address.Size = New System.Drawing.Size(62, 18)
        Me.lbl_customer_address.TabIndex = 9
        Me.lbl_customer_address.Text = "Address"
        '
        'txt_customer_address
        '
        Me.txt_customer_address.Location = New System.Drawing.Point(27, 161)
        Me.txt_customer_address.Name = "txt_customer_address"
        Me.txt_customer_address.Size = New System.Drawing.Size(329, 22)
        Me.txt_customer_address.TabIndex = 13
        '
        'lbl_customer_phone_number
        '
        Me.lbl_customer_phone_number.AutoSize = True
        Me.lbl_customer_phone_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_phone_number.Location = New System.Drawing.Point(380, 127)
        Me.lbl_customer_phone_number.Name = "lbl_customer_phone_number"
        Me.lbl_customer_phone_number.Size = New System.Drawing.Size(120, 20)
        Me.lbl_customer_phone_number.TabIndex = 19
        Me.lbl_customer_phone_number.Text = "Phone Number"
        '
        'txt_customer_number
        '
        Me.txt_customer_number.Location = New System.Drawing.Point(384, 162)
        Me.txt_customer_number.Name = "txt_customer_number"
        Me.txt_customer_number.Size = New System.Drawing.Size(369, 22)
        Me.txt_customer_number.TabIndex = 20
        '
        'frm_insert_customer_a189479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_customer_number)
        Me.Controls.Add(Me.lbl_customer_phone_number)
        Me.Controls.Add(Me.btn_add_staff)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_back_to_details)
        Me.Controls.Add(Me.cmb_customer_tier)
        Me.Controls.Add(Me.txt_customer_name)
        Me.Controls.Add(Me.txt_customer_address)
        Me.Controls.Add(Me.txt_customer_id)
        Me.Controls.Add(Me.lbl_customer_tier)
        Me.Controls.Add(Me.lbl_customer_name)
        Me.Controls.Add(Me.lbl_customer_address)
        Me.Controls.Add(Me.lbl_customer_id)
        Me.Controls.Add(Me.lbl_add_customer)
        Me.Controls.Add(Me.grd_staff_view)
        Me.Name = "frm_insert_customer_a189479"
        Me.Text = "Add Customer"
        CType(Me.grd_staff_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_add_staff As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_back_to_details As Button
    Friend WithEvents cmb_customer_tier As ComboBox
    Friend WithEvents txt_customer_name As TextBox
    Friend WithEvents txt_customer_id As TextBox
    Friend WithEvents lbl_customer_tier As Label
    Friend WithEvents lbl_customer_name As Label
    Friend WithEvents lbl_customer_id As Label
    Friend WithEvents lbl_add_customer As Label
    Friend WithEvents grd_staff_view As DataGridView
    Friend WithEvents lbl_customer_address As Label
    Friend WithEvents txt_customer_address As TextBox
    Friend WithEvents lbl_customer_phone_number As Label
    Friend WithEvents txt_customer_number As TextBox
End Class
