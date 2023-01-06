<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staff_details_a189479
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
        Me.lbl_staff_details = New System.Windows.Forms.Label()
        Me.lbl_staff_id = New System.Windows.Forms.Label()
        Me.lbl_staff_name = New System.Windows.Forms.Label()
        Me.lbl_staff_role = New System.Windows.Forms.Label()
        Me.txt_staff_id = New System.Windows.Forms.TextBox()
        Me.txt_staff_name = New System.Windows.Forms.TextBox()
        Me.cmb_staff_role = New System.Windows.Forms.ComboBox()
        Me.btn_update_staff = New System.Windows.Forms.Button()
        Me.btn_save_staff = New System.Windows.Forms.Button()
        Me.lst_staffid = New System.Windows.Forms.ListBox()
        Me.btn_add_staff = New System.Windows.Forms.Button()
        Me.btn_delete_staff = New System.Windows.Forms.Button()
        Me.btn_view_staff_table = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_staff_details
        '
        Me.lbl_staff_details.AutoSize = True
        Me.lbl_staff_details.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_details.Location = New System.Drawing.Point(25, 22)
        Me.lbl_staff_details.Name = "lbl_staff_details"
        Me.lbl_staff_details.Size = New System.Drawing.Size(129, 25)
        Me.lbl_staff_details.TabIndex = 0
        Me.lbl_staff_details.Text = "Staff Details"
        '
        'lbl_staff_id
        '
        Me.lbl_staff_id.AutoSize = True
        Me.lbl_staff_id.Location = New System.Drawing.Point(27, 66)
        Me.lbl_staff_id.Name = "lbl_staff_id"
        Me.lbl_staff_id.Size = New System.Drawing.Size(21, 17)
        Me.lbl_staff_id.TabIndex = 1
        Me.lbl_staff_id.Text = "ID"
        '
        'lbl_staff_name
        '
        Me.lbl_staff_name.AutoSize = True
        Me.lbl_staff_name.Location = New System.Drawing.Point(27, 128)
        Me.lbl_staff_name.Name = "lbl_staff_name"
        Me.lbl_staff_name.Size = New System.Drawing.Size(45, 17)
        Me.lbl_staff_name.TabIndex = 1
        Me.lbl_staff_name.Text = "Name"
        '
        'lbl_staff_role
        '
        Me.lbl_staff_role.AutoSize = True
        Me.lbl_staff_role.Location = New System.Drawing.Point(27, 186)
        Me.lbl_staff_role.Name = "lbl_staff_role"
        Me.lbl_staff_role.Size = New System.Drawing.Size(37, 17)
        Me.lbl_staff_role.TabIndex = 1
        Me.lbl_staff_role.Text = "Role"
        '
        'txt_staff_id
        '
        Me.txt_staff_id.Location = New System.Drawing.Point(30, 92)
        Me.txt_staff_id.Name = "txt_staff_id"
        Me.txt_staff_id.ReadOnly = True
        Me.txt_staff_id.Size = New System.Drawing.Size(203, 22)
        Me.txt_staff_id.TabIndex = 2
        '
        'txt_staff_name
        '
        Me.txt_staff_name.Location = New System.Drawing.Point(30, 148)
        Me.txt_staff_name.Name = "txt_staff_name"
        Me.txt_staff_name.ReadOnly = True
        Me.txt_staff_name.Size = New System.Drawing.Size(203, 22)
        Me.txt_staff_name.TabIndex = 2
        '
        'cmb_staff_role
        '
        Me.cmb_staff_role.Enabled = False
        Me.cmb_staff_role.FormattingEnabled = True
        Me.cmb_staff_role.Items.AddRange(New Object() {"Manager", "Sales", "Technical"})
        Me.cmb_staff_role.Location = New System.Drawing.Point(30, 220)
        Me.cmb_staff_role.Name = "cmb_staff_role"
        Me.cmb_staff_role.Size = New System.Drawing.Size(203, 24)
        Me.cmb_staff_role.TabIndex = 3
        '
        'btn_update_staff
        '
        Me.btn_update_staff.Location = New System.Drawing.Point(30, 361)
        Me.btn_update_staff.Name = "btn_update_staff"
        Me.btn_update_staff.Size = New System.Drawing.Size(90, 23)
        Me.btn_update_staff.TabIndex = 4
        Me.btn_update_staff.Text = "Update"
        Me.btn_update_staff.UseVisualStyleBackColor = True
        '
        'btn_save_staff
        '
        Me.btn_save_staff.Enabled = False
        Me.btn_save_staff.Location = New System.Drawing.Point(143, 361)
        Me.btn_save_staff.Name = "btn_save_staff"
        Me.btn_save_staff.Size = New System.Drawing.Size(90, 23)
        Me.btn_save_staff.TabIndex = 4
        Me.btn_save_staff.Text = "Save"
        Me.btn_save_staff.UseVisualStyleBackColor = True
        '
        'lst_staffid
        '
        Me.lst_staffid.FormattingEnabled = True
        Me.lst_staffid.ItemHeight = 16
        Me.lst_staffid.Location = New System.Drawing.Point(332, 47)
        Me.lst_staffid.Name = "lst_staffid"
        Me.lst_staffid.Size = New System.Drawing.Size(224, 308)
        Me.lst_staffid.TabIndex = 5
        '
        'btn_add_staff
        '
        Me.btn_add_staff.Location = New System.Drawing.Point(332, 361)
        Me.btn_add_staff.Name = "btn_add_staff"
        Me.btn_add_staff.Size = New System.Drawing.Size(117, 23)
        Me.btn_add_staff.TabIndex = 6
        Me.btn_add_staff.Text = "New"
        Me.btn_add_staff.UseVisualStyleBackColor = True
        '
        'btn_delete_staff
        '
        Me.btn_delete_staff.Location = New System.Drawing.Point(455, 361)
        Me.btn_delete_staff.Name = "btn_delete_staff"
        Me.btn_delete_staff.Size = New System.Drawing.Size(101, 23)
        Me.btn_delete_staff.TabIndex = 6
        Me.btn_delete_staff.Text = "Delete"
        Me.btn_delete_staff.UseVisualStyleBackColor = True
        '
        'btn_view_staff_table
        '
        Me.btn_view_staff_table.Location = New System.Drawing.Point(332, 22)
        Me.btn_view_staff_table.Name = "btn_view_staff_table"
        Me.btn_view_staff_table.Size = New System.Drawing.Size(224, 23)
        Me.btn_view_staff_table.TabIndex = 7
        Me.btn_view_staff_table.Text = "Table View"
        Me.btn_view_staff_table.UseVisualStyleBackColor = True
        '
        'frm_staff_details_a189479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 396)
        Me.Controls.Add(Me.btn_view_staff_table)
        Me.Controls.Add(Me.btn_delete_staff)
        Me.Controls.Add(Me.btn_add_staff)
        Me.Controls.Add(Me.lst_staffid)
        Me.Controls.Add(Me.btn_save_staff)
        Me.Controls.Add(Me.btn_update_staff)
        Me.Controls.Add(Me.cmb_staff_role)
        Me.Controls.Add(Me.txt_staff_name)
        Me.Controls.Add(Me.txt_staff_id)
        Me.Controls.Add(Me.lbl_staff_role)
        Me.Controls.Add(Me.lbl_staff_name)
        Me.Controls.Add(Me.lbl_staff_id)
        Me.Controls.Add(Me.lbl_staff_details)
        Me.Name = "frm_staff_details_a189479"
        Me.Text = "frm_staff_details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_staff_details As Label
    Friend WithEvents lbl_staff_id As Label
    Friend WithEvents lbl_staff_name As Label
    Friend WithEvents lbl_staff_role As Label
    Friend WithEvents txt_staff_id As TextBox
    Friend WithEvents txt_staff_name As TextBox
    Friend WithEvents cmb_staff_role As ComboBox
    Friend WithEvents btn_update_staff As Button
    Friend WithEvents btn_save_staff As Button
    Friend WithEvents lst_staffid As ListBox
    Friend WithEvents btn_add_staff As Button
    Friend WithEvents btn_delete_staff As Button
    Friend WithEvents btn_view_staff_table As Button
End Class
