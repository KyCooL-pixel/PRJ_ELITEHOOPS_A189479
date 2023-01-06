<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customer_details_a189479
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
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_view_customer_table = New System.Windows.Forms.Button()
        Me.btn_delete_staff = New System.Windows.Forms.Button()
        Me.btn_add_staff = New System.Windows.Forms.Button()
        Me.lst_customerid = New System.Windows.Forms.ListBox()
        Me.btn_save_staff = New System.Windows.Forms.Button()
        Me.btn_update_staff = New System.Windows.Forms.Button()
        Me.cmb_customer_tier = New System.Windows.Forms.ComboBox()
        Me.txt_customer_name = New System.Windows.Forms.TextBox()
        Me.txt_customer_id = New System.Windows.Forms.TextBox()
        Me.lbl_customer_tier = New System.Windows.Forms.Label()
        Me.lbl_customer_name = New System.Windows.Forms.Label()
        Me.lbl_customer_id = New System.Windows.Forms.Label()
        Me.lbl_customer_details = New System.Windows.Forms.Label()
        Me.lbl_customer_address = New System.Windows.Forms.Label()
        Me.lbl_phone_number = New System.Windows.Forms.Label()
        Me.txt_customer_address = New System.Windows.Forms.TextBox()
        Me.txt_customer_number = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(20, 360)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(56, 23)
        Me.btn_back.TabIndex = 22
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_view_customer_table
        '
        Me.btn_view_customer_table.Location = New System.Drawing.Point(322, 21)
        Me.btn_view_customer_table.Name = "btn_view_customer_table"
        Me.btn_view_customer_table.Size = New System.Drawing.Size(224, 23)
        Me.btn_view_customer_table.TabIndex = 21
        Me.btn_view_customer_table.Text = "Table View"
        Me.btn_view_customer_table.UseVisualStyleBackColor = True
        '
        'btn_delete_staff
        '
        Me.btn_delete_staff.Location = New System.Drawing.Point(445, 360)
        Me.btn_delete_staff.Name = "btn_delete_staff"
        Me.btn_delete_staff.Size = New System.Drawing.Size(101, 23)
        Me.btn_delete_staff.TabIndex = 19
        Me.btn_delete_staff.Text = "Delete"
        Me.btn_delete_staff.UseVisualStyleBackColor = True
        '
        'btn_add_staff
        '
        Me.btn_add_staff.Location = New System.Drawing.Point(322, 360)
        Me.btn_add_staff.Name = "btn_add_staff"
        Me.btn_add_staff.Size = New System.Drawing.Size(117, 23)
        Me.btn_add_staff.TabIndex = 20
        Me.btn_add_staff.Text = "New"
        Me.btn_add_staff.UseVisualStyleBackColor = True
        '
        'lst_customerid
        '
        Me.lst_customerid.FormattingEnabled = True
        Me.lst_customerid.ItemHeight = 16
        Me.lst_customerid.Location = New System.Drawing.Point(322, 46)
        Me.lst_customerid.Name = "lst_customerid"
        Me.lst_customerid.Size = New System.Drawing.Size(224, 308)
        Me.lst_customerid.TabIndex = 18
        '
        'btn_save_staff
        '
        Me.btn_save_staff.Enabled = False
        Me.btn_save_staff.Location = New System.Drawing.Point(192, 360)
        Me.btn_save_staff.Name = "btn_save_staff"
        Me.btn_save_staff.Size = New System.Drawing.Size(74, 23)
        Me.btn_save_staff.TabIndex = 16
        Me.btn_save_staff.Text = "Save"
        Me.btn_save_staff.UseVisualStyleBackColor = True
        '
        'btn_update_staff
        '
        Me.btn_update_staff.Location = New System.Drawing.Point(114, 360)
        Me.btn_update_staff.Name = "btn_update_staff"
        Me.btn_update_staff.Size = New System.Drawing.Size(72, 23)
        Me.btn_update_staff.TabIndex = 17
        Me.btn_update_staff.Text = "Update"
        Me.btn_update_staff.UseVisualStyleBackColor = True
        '
        'cmb_customer_tier
        '
        Me.cmb_customer_tier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_customer_tier.Enabled = False
        Me.cmb_customer_tier.FormattingEnabled = True
        Me.cmb_customer_tier.Items.AddRange(New Object() {"SILVER", "GOLD", "PLATINUM"})
        Me.cmb_customer_tier.Location = New System.Drawing.Point(20, 289)
        Me.cmb_customer_tier.Name = "cmb_customer_tier"
        Me.cmb_customer_tier.Size = New System.Drawing.Size(246, 24)
        Me.cmb_customer_tier.TabIndex = 15
        '
        'txt_customer_name
        '
        Me.txt_customer_name.Location = New System.Drawing.Point(20, 120)
        Me.txt_customer_name.Name = "txt_customer_name"
        Me.txt_customer_name.ReadOnly = True
        Me.txt_customer_name.Size = New System.Drawing.Size(246, 22)
        Me.txt_customer_name.TabIndex = 13
        '
        'txt_customer_id
        '
        Me.txt_customer_id.Location = New System.Drawing.Point(20, 75)
        Me.txt_customer_id.Name = "txt_customer_id"
        Me.txt_customer_id.ReadOnly = True
        Me.txt_customer_id.Size = New System.Drawing.Size(246, 22)
        Me.txt_customer_id.TabIndex = 14
        '
        'lbl_customer_tier
        '
        Me.lbl_customer_tier.AutoSize = True
        Me.lbl_customer_tier.Location = New System.Drawing.Point(17, 269)
        Me.lbl_customer_tier.Name = "lbl_customer_tier"
        Me.lbl_customer_tier.Size = New System.Drawing.Size(33, 17)
        Me.lbl_customer_tier.TabIndex = 10
        Me.lbl_customer_tier.Text = "Tier"
        '
        'lbl_customer_name
        '
        Me.lbl_customer_name.AutoSize = True
        Me.lbl_customer_name.Location = New System.Drawing.Point(17, 100)
        Me.lbl_customer_name.Name = "lbl_customer_name"
        Me.lbl_customer_name.Size = New System.Drawing.Size(45, 17)
        Me.lbl_customer_name.TabIndex = 11
        Me.lbl_customer_name.Text = "Name"
        '
        'lbl_customer_id
        '
        Me.lbl_customer_id.AutoSize = True
        Me.lbl_customer_id.Location = New System.Drawing.Point(17, 55)
        Me.lbl_customer_id.Name = "lbl_customer_id"
        Me.lbl_customer_id.Size = New System.Drawing.Size(21, 17)
        Me.lbl_customer_id.TabIndex = 12
        Me.lbl_customer_id.Text = "ID"
        '
        'lbl_customer_details
        '
        Me.lbl_customer_details.AutoSize = True
        Me.lbl_customer_details.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_details.Location = New System.Drawing.Point(15, 21)
        Me.lbl_customer_details.Name = "lbl_customer_details"
        Me.lbl_customer_details.Size = New System.Drawing.Size(177, 25)
        Me.lbl_customer_details.TabIndex = 9
        Me.lbl_customer_details.Text = "Customer Details"
        '
        'lbl_customer_address
        '
        Me.lbl_customer_address.AutoSize = True
        Me.lbl_customer_address.Location = New System.Drawing.Point(17, 156)
        Me.lbl_customer_address.Name = "lbl_customer_address"
        Me.lbl_customer_address.Size = New System.Drawing.Size(60, 17)
        Me.lbl_customer_address.TabIndex = 23
        Me.lbl_customer_address.Text = "Address"
        '
        'lbl_phone_number
        '
        Me.lbl_phone_number.AutoSize = True
        Me.lbl_phone_number.Location = New System.Drawing.Point(17, 210)
        Me.lbl_phone_number.Name = "lbl_phone_number"
        Me.lbl_phone_number.Size = New System.Drawing.Size(101, 17)
        Me.lbl_phone_number.TabIndex = 24
        Me.lbl_phone_number.Text = "Phone number"
        '
        'txt_customer_address
        '
        Me.txt_customer_address.Location = New System.Drawing.Point(20, 176)
        Me.txt_customer_address.Name = "txt_customer_address"
        Me.txt_customer_address.ReadOnly = True
        Me.txt_customer_address.Size = New System.Drawing.Size(246, 22)
        Me.txt_customer_address.TabIndex = 13
        '
        'txt_customer_number
        '
        Me.txt_customer_number.Location = New System.Drawing.Point(20, 230)
        Me.txt_customer_number.Name = "txt_customer_number"
        Me.txt_customer_number.ReadOnly = True
        Me.txt_customer_number.Size = New System.Drawing.Size(246, 22)
        Me.txt_customer_number.TabIndex = 13
        '
        'frm_customer_details_a189479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 401)
        Me.Controls.Add(Me.lbl_phone_number)
        Me.Controls.Add(Me.lbl_customer_address)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_view_customer_table)
        Me.Controls.Add(Me.btn_delete_staff)
        Me.Controls.Add(Me.btn_add_staff)
        Me.Controls.Add(Me.lst_customerid)
        Me.Controls.Add(Me.btn_save_staff)
        Me.Controls.Add(Me.btn_update_staff)
        Me.Controls.Add(Me.cmb_customer_tier)
        Me.Controls.Add(Me.txt_customer_number)
        Me.Controls.Add(Me.txt_customer_address)
        Me.Controls.Add(Me.txt_customer_name)
        Me.Controls.Add(Me.txt_customer_id)
        Me.Controls.Add(Me.lbl_customer_tier)
        Me.Controls.Add(Me.lbl_customer_name)
        Me.Controls.Add(Me.lbl_customer_id)
        Me.Controls.Add(Me.lbl_customer_details)
        Me.Name = "frm_customer_details_a189479"
        Me.Text = "frm_customer_details_a189479"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents btn_view_customer_table As Button
    Friend WithEvents btn_delete_staff As Button
    Friend WithEvents btn_add_staff As Button
    Friend WithEvents lst_customerid As ListBox
    Friend WithEvents btn_save_staff As Button
    Friend WithEvents btn_update_staff As Button
    Friend WithEvents cmb_customer_tier As ComboBox
    Friend WithEvents txt_customer_name As TextBox
    Friend WithEvents txt_customer_id As TextBox
    Friend WithEvents lbl_customer_tier As Label
    Friend WithEvents lbl_customer_name As Label
    Friend WithEvents lbl_customer_id As Label
    Friend WithEvents lbl_customer_details As Label
    Friend WithEvents lbl_customer_address As Label
    Friend WithEvents lbl_phone_number As Label
    Friend WithEvents txt_customer_address As TextBox
    Friend WithEvents txt_customer_number As TextBox
End Class
