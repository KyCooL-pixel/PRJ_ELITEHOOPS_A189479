<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_products_a189479
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
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.lbl_products = New System.Windows.Forms.Label()
        Me.btn_back_mainmenu = New System.Windows.Forms.Button()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_products
        '
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(12, 45)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.RowHeadersWidth = 51
        Me.grd_products.RowTemplate.Height = 24
        Me.grd_products.Size = New System.Drawing.Size(776, 341)
        Me.grd_products.TabIndex = 0
        '
        'lbl_products
        '
        Me.lbl_products.AutoSize = True
        Me.lbl_products.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_products.Location = New System.Drawing.Point(26, 9)
        Me.lbl_products.Name = "lbl_products"
        Me.lbl_products.Size = New System.Drawing.Size(97, 25)
        Me.lbl_products.TabIndex = 1
        Me.lbl_products.Text = "Products"
        '
        'btn_back_mainmenu
        '
        Me.btn_back_mainmenu.Location = New System.Drawing.Point(612, 405)
        Me.btn_back_mainmenu.Name = "btn_back_mainmenu"
        Me.btn_back_mainmenu.Size = New System.Drawing.Size(151, 23)
        Me.btn_back_mainmenu.TabIndex = 2
        Me.btn_back_mainmenu.Text = "Back to Main Menu"
        Me.btn_back_mainmenu.UseVisualStyleBackColor = True
        '
        'frm_products_a189479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_back_mainmenu)
        Me.Controls.Add(Me.lbl_products)
        Me.Controls.Add(Me.grd_products)
        Me.Name = "frm_products_a189479"
        Me.Text = "frm_products_a189479"
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_products As DataGridView
    Friend WithEvents lbl_products As Label
    Friend WithEvents btn_back_mainmenu As Button
End Class
