﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staffs_a189479
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
        Me.lbl_staffs = New System.Windows.Forms.Label()
        Me.grd_staffs = New System.Windows.Forms.DataGridView()
        CType(Me.grd_staffs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back_mainmenu
        '
        Me.btn_back_mainmenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_back_mainmenu.Location = New System.Drawing.Point(612, 412)
        Me.btn_back_mainmenu.Name = "btn_back_mainmenu"
        Me.btn_back_mainmenu.Size = New System.Drawing.Size(151, 23)
        Me.btn_back_mainmenu.TabIndex = 8
        Me.btn_back_mainmenu.Text = "Back to Main Menu"
        Me.btn_back_mainmenu.UseVisualStyleBackColor = True
        '
        'lbl_staffs
        '
        Me.lbl_staffs.AutoSize = True
        Me.lbl_staffs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffs.Location = New System.Drawing.Point(26, 16)
        Me.lbl_staffs.Name = "lbl_staffs"
        Me.lbl_staffs.Size = New System.Drawing.Size(68, 25)
        Me.lbl_staffs.TabIndex = 7
        Me.lbl_staffs.Text = "Staffs"
        '
        'grd_staffs
        '
        Me.grd_staffs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grd_staffs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grd_staffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staffs.Location = New System.Drawing.Point(12, 52)
        Me.grd_staffs.Name = "grd_staffs"
        Me.grd_staffs.RowHeadersWidth = 51
        Me.grd_staffs.RowTemplate.Height = 24
        Me.grd_staffs.Size = New System.Drawing.Size(776, 341)
        Me.grd_staffs.TabIndex = 6
        '
        'frm_staffs_a189479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_back_mainmenu)
        Me.Controls.Add(Me.lbl_staffs)
        Me.Controls.Add(Me.grd_staffs)
        Me.Name = "frm_staffs_a189479"
        Me.Text = "frm_staffs_a189479"
        CType(Me.grd_staffs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back_mainmenu As Button
    Friend WithEvents lbl_staffs As Label
    Friend WithEvents grd_staffs As DataGridView
End Class
