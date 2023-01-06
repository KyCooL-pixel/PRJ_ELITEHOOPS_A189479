<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insert_staff_a189479
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
        Me.lbl_add_staff = New System.Windows.Forms.Label()
        Me.lb_staff_id = New System.Windows.Forms.Label()
        Me.lbl_staff_name = New System.Windows.Forms.Label()
        Me.lbl_staff_role = New System.Windows.Forms.Label()
        Me.txt_staff_id = New System.Windows.Forms.TextBox()
        Me.txt_staff_name = New System.Windows.Forms.TextBox()
        Me.cmb_staff_role = New System.Windows.Forms.ComboBox()
        Me.btn_back_to_details = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_add_staff = New System.Windows.Forms.Button()
        Me.grd_staff_view = New System.Windows.Forms.DataGridView()
        CType(Me.grd_staff_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_add_staff
        '
        Me.lbl_add_staff.AutoSize = True
        Me.lbl_add_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_add_staff.Location = New System.Drawing.Point(12, 9)
        Me.lbl_add_staff.Name = "lbl_add_staff"
        Me.lbl_add_staff.Size = New System.Drawing.Size(105, 25)
        Me.lbl_add_staff.TabIndex = 0
        Me.lbl_add_staff.Text = "New Staff"
        '
        'lb_staff_id
        '
        Me.lb_staff_id.AutoSize = True
        Me.lb_staff_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_staff_id.Location = New System.Drawing.Point(30, 52)
        Me.lb_staff_id.Name = "lb_staff_id"
        Me.lb_staff_id.Size = New System.Drawing.Size(22, 18)
        Me.lb_staff_id.TabIndex = 1
        Me.lb_staff_id.Text = "ID"
        '
        'lbl_staff_name
        '
        Me.lbl_staff_name.AutoSize = True
        Me.lbl_staff_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_name.Location = New System.Drawing.Point(30, 125)
        Me.lbl_staff_name.Name = "lbl_staff_name"
        Me.lbl_staff_name.Size = New System.Drawing.Size(53, 20)
        Me.lbl_staff_name.TabIndex = 2
        Me.lbl_staff_name.Text = "Name"
        '
        'lbl_staff_role
        '
        Me.lbl_staff_role.AutoSize = True
        Me.lbl_staff_role.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_role.Location = New System.Drawing.Point(30, 201)
        Me.lbl_staff_role.Name = "lbl_staff_role"
        Me.lbl_staff_role.Size = New System.Drawing.Size(43, 20)
        Me.lbl_staff_role.TabIndex = 3
        Me.lbl_staff_role.Text = "Role"
        '
        'txt_staff_id
        '
        Me.txt_staff_id.Location = New System.Drawing.Point(33, 81)
        Me.txt_staff_id.Name = "txt_staff_id"
        Me.txt_staff_id.Size = New System.Drawing.Size(441, 22)
        Me.txt_staff_id.TabIndex = 4
        '
        'txt_staff_name
        '
        Me.txt_staff_name.Location = New System.Drawing.Point(33, 163)
        Me.txt_staff_name.Name = "txt_staff_name"
        Me.txt_staff_name.Size = New System.Drawing.Size(441, 22)
        Me.txt_staff_name.TabIndex = 4
        '
        'cmb_staff_role
        '
        Me.cmb_staff_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_staff_role.FormattingEnabled = True
        Me.cmb_staff_role.Items.AddRange(New Object() {"Manager", "Sales", "Technical"})
        Me.cmb_staff_role.Location = New System.Drawing.Point(33, 236)
        Me.cmb_staff_role.Name = "cmb_staff_role"
        Me.cmb_staff_role.Size = New System.Drawing.Size(441, 24)
        Me.cmb_staff_role.TabIndex = 5
        '
        'btn_back_to_details
        '
        Me.btn_back_to_details.Location = New System.Drawing.Point(17, 315)
        Me.btn_back_to_details.Name = "btn_back_to_details"
        Me.btn_back_to_details.Size = New System.Drawing.Size(75, 23)
        Me.btn_back_to_details.TabIndex = 6
        Me.btn_back_to_details.Text = "Back"
        Me.btn_back_to_details.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(322, 315)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 6
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_add_staff
        '
        Me.btn_add_staff.Location = New System.Drawing.Point(413, 315)
        Me.btn_add_staff.Name = "btn_add_staff"
        Me.btn_add_staff.Size = New System.Drawing.Size(75, 23)
        Me.btn_add_staff.TabIndex = 6
        Me.btn_add_staff.Text = "Add"
        Me.btn_add_staff.UseVisualStyleBackColor = True
        '
        'grd_staff_view
        '
        Me.grd_staff_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff_view.Location = New System.Drawing.Point(464, 81)
        Me.grd_staff_view.Name = "grd_staff_view"
        Me.grd_staff_view.RowHeadersWidth = 51
        Me.grd_staff_view.RowTemplate.Height = 24
        Me.grd_staff_view.Size = New System.Drawing.Size(10, 18)
        Me.grd_staff_view.TabIndex = 7
        Me.grd_staff_view.Visible = False
        '
        'frm_insert_staff_a189479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 364)
        Me.Controls.Add(Me.btn_add_staff)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_back_to_details)
        Me.Controls.Add(Me.cmb_staff_role)
        Me.Controls.Add(Me.txt_staff_name)
        Me.Controls.Add(Me.txt_staff_id)
        Me.Controls.Add(Me.lbl_staff_role)
        Me.Controls.Add(Me.lbl_staff_name)
        Me.Controls.Add(Me.lb_staff_id)
        Me.Controls.Add(Me.lbl_add_staff)
        Me.Controls.Add(Me.grd_staff_view)
        Me.Name = "frm_insert_staff_a189479"
        Me.Text = "frm_insert_staff_a189479"
        CType(Me.grd_staff_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_add_staff As Label
    Friend WithEvents lb_staff_id As Label
    Friend WithEvents lbl_staff_name As Label
    Friend WithEvents lbl_staff_role As Label
    Friend WithEvents txt_staff_id As TextBox
    Friend WithEvents txt_staff_name As TextBox
    Friend WithEvents cmb_staff_role As ComboBox
    Friend WithEvents btn_back_to_details As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_add_staff As Button
    Friend WithEvents grd_staff_view As DataGridView
End Class
