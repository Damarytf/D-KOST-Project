<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form8
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
        Me.UnitTxt = New System.Windows.Forms.TextBox()
        Me.AlamatTxt = New System.Windows.Forms.TextBox()
        Me.HargaTxt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kembaliBtn = New System.Windows.Forms.Button()
        Me.KontakTxt = New System.Windows.Forms.TextBox()
        Me.TambahBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.IDTxt = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UnitTxt
        '
        Me.UnitTxt.Location = New System.Drawing.Point(190, 214)
        Me.UnitTxt.Name = "UnitTxt"
        Me.UnitTxt.Size = New System.Drawing.Size(313, 26)
        Me.UnitTxt.TabIndex = 4
        '
        'AlamatTxt
        '
        Me.AlamatTxt.Location = New System.Drawing.Point(190, 246)
        Me.AlamatTxt.Name = "AlamatTxt"
        Me.AlamatTxt.Size = New System.Drawing.Size(327, 26)
        Me.AlamatTxt.TabIndex = 5
        '
        'HargaTxt
        '
        Me.HargaTxt.Location = New System.Drawing.Point(822, 182)
        Me.HargaTxt.Name = "HargaTxt"
        Me.HargaTxt.Size = New System.Drawing.Size(243, 26)
        Me.HargaTxt.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(127, 326)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(905, 309)
        Me.DataGridView1.TabIndex = 8
        '
        'kembaliBtn
        '
        Me.kembaliBtn.BackColor = System.Drawing.Color.DarkBlue
        Me.kembaliBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.kembaliBtn.Location = New System.Drawing.Point(925, 104)
        Me.kembaliBtn.Name = "kembaliBtn"
        Me.kembaliBtn.Size = New System.Drawing.Size(178, 46)
        Me.kembaliBtn.TabIndex = 10
        Me.kembaliBtn.Text = "Admin Menu"
        Me.kembaliBtn.UseVisualStyleBackColor = False
        '
        'KontakTxt
        '
        Me.KontakTxt.Location = New System.Drawing.Point(822, 214)
        Me.KontakTxt.Name = "KontakTxt"
        Me.KontakTxt.Size = New System.Drawing.Size(243, 26)
        Me.KontakTxt.TabIndex = 12
        '
        'TambahBtn
        '
        Me.TambahBtn.BackColor = System.Drawing.Color.DarkGreen
        Me.TambahBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TambahBtn.Location = New System.Drawing.Point(530, 246)
        Me.TambahBtn.Name = "TambahBtn"
        Me.TambahBtn.Size = New System.Drawing.Size(138, 48)
        Me.TambahBtn.TabIndex = 13
        Me.TambahBtn.Text = "Tambah"
        Me.TambahBtn.UseVisualStyleBackColor = False
        '
        'EditBtn
        '
        Me.EditBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.EditBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EditBtn.Location = New System.Drawing.Point(693, 246)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(138, 48)
        Me.EditBtn.TabIndex = 14
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'HapusBtn
        '
        Me.HapusBtn.BackColor = System.Drawing.Color.Red
        Me.HapusBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.HapusBtn.Location = New System.Drawing.Point(860, 246)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(138, 48)
        Me.HapusBtn.TabIndex = 15
        Me.HapusBtn.Text = "Hapus"
        Me.HapusBtn.UseVisualStyleBackColor = False
        '
        'IDTxt
        '
        Me.IDTxt.Location = New System.Drawing.Point(190, 182)
        Me.IDTxt.Name = "IDTxt"
        Me.IDTxt.Size = New System.Drawing.Size(222, 26)
        Me.IDTxt.TabIndex = 16
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.D_Kost_Project.My.Resources.Resources.List_Unit
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1115, 652)
        Me.Controls.Add(Me.IDTxt)
        Me.Controls.Add(Me.HapusBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.TambahBtn)
        Me.Controls.Add(Me.KontakTxt)
        Me.Controls.Add(Me.kembaliBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.HargaTxt)
        Me.Controls.Add(Me.AlamatTxt)
        Me.Controls.Add(Me.UnitTxt)
        Me.Name = "Form8"
        Me.Text = "List Unit"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UnitTxt As TextBox
    Friend WithEvents AlamatTxt As TextBox
    Friend WithEvents HargaTxt As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents kembaliBtn As Button
    Friend WithEvents KontakTxt As TextBox
    Friend WithEvents TambahBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents HapusBtn As Button
    Friend WithEvents IDTxt As TextBox
End Class
