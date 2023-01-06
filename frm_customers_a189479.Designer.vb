<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customers_a189479
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
        Me.btn_back_mainmenu = New System.Windows.Forms.Button()
        Me.lbl_customers = New System.Windows.Forms.Label()
        Me.grd_customers = New System.Windows.Forms.DataGridView()
        CType(Me.grd_customers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back_mainmenu
        '
        Me.btn_back_mainmenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_back_mainmenu.Location = New System.Drawing.Point(612, 412)
        Me.btn_back_mainmenu.Name = "btn_back_mainmenu"
        Me.btn_back_mainmenu.Size = New System.Drawing.Size(151, 23)
        Me.btn_back_mainmenu.TabIndex = 5
        Me.btn_back_mainmenu.Text = "Back to Details"
        Me.btn_back_mainmenu.UseVisualStyleBackColor = True
        '
        'lbl_customers
        '
        Me.lbl_customers.AutoSize = True
        Me.lbl_customers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customers.Location = New System.Drawing.Point(26, 16)
        Me.lbl_customers.Name = "lbl_customers"
        Me.lbl_customers.Size = New System.Drawing.Size(116, 25)
        Me.lbl_customers.TabIndex = 4
        Me.lbl_customers.Text = "Customers"
        '
        'grd_customers
        '
        Me.grd_customers.AllowUserToAddRows = False
        Me.grd_customers.AllowUserToDeleteRows = False
        Me.grd_customers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grd_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grd_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customers.Location = New System.Drawing.Point(12, 52)
        Me.grd_customers.Name = "grd_customers"
        Me.grd_customers.ReadOnly = True
        Me.grd_customers.RowHeadersWidth = 51
        Me.grd_customers.RowTemplate.Height = 24
        Me.grd_customers.Size = New System.Drawing.Size(776, 341)
        Me.grd_customers.TabIndex = 3
        '
        'frm_customers_a189479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_back_mainmenu)
        Me.Controls.Add(Me.lbl_customers)
        Me.Controls.Add(Me.grd_customers)
        Me.Name = "frm_customers_a189479"
        Me.Text = "frm_customers_a189479"
        CType(Me.grd_customers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back_mainmenu As Button
    Friend WithEvents lbl_customers As Label
    Friend WithEvents grd_customers As DataGridView
End Class
