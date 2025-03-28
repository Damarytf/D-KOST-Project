<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Me.BtnMain = New System.Windows.Forms.Button()
        Me.PelangganTxt = New System.Windows.Forms.TextBox()
        Me.IDUnitTxt = New System.Windows.Forms.TextBox()
        Me.sewa = New System.Windows.Forms.NumericUpDown()
        Me.TotalTxt = New System.Windows.Forms.TextBox()
        Me.dpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cbUnit = New System.Windows.Forms.ComboBox()
        Me.PesanBtn = New System.Windows.Forms.Button()
        Me.MetodeTxt = New System.Windows.Forms.TextBox()
        Me.RekTxt = New System.Windows.Forms.TextBox()
        Me.AtasnmTxt = New System.Windows.Forms.TextBox()
        CType(Me.sewa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnMain
        '
        Me.BtnMain.BackColor = System.Drawing.Color.Red
        Me.BtnMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnMain.Location = New System.Drawing.Point(950, 113)
        Me.BtnMain.Name = "BtnMain"
        Me.BtnMain.Size = New System.Drawing.Size(136, 35)
        Me.BtnMain.TabIndex = 7
        Me.BtnMain.Text = "Menu Utama"
        Me.BtnMain.UseVisualStyleBackColor = False
        '
        'PelangganTxt
        '
        Me.PelangganTxt.Location = New System.Drawing.Point(282, 196)
        Me.PelangganTxt.Name = "PelangganTxt"
        Me.PelangganTxt.Size = New System.Drawing.Size(276, 26)
        Me.PelangganTxt.TabIndex = 14
        '
        'IDUnitTxt
        '
        Me.IDUnitTxt.Location = New System.Drawing.Point(282, 290)
        Me.IDUnitTxt.Name = "IDUnitTxt"
        Me.IDUnitTxt.ReadOnly = True
        Me.IDUnitTxt.Size = New System.Drawing.Size(208, 26)
        Me.IDUnitTxt.TabIndex = 15
        '
        'sewa
        '
        Me.sewa.Location = New System.Drawing.Point(282, 343)
        Me.sewa.Name = "sewa"
        Me.sewa.Size = New System.Drawing.Size(64, 26)
        Me.sewa.TabIndex = 16
        '
        'TotalTxt
        '
        Me.TotalTxt.Location = New System.Drawing.Point(282, 386)
        Me.TotalTxt.Name = "TotalTxt"
        Me.TotalTxt.Size = New System.Drawing.Size(276, 26)
        Me.TotalTxt.TabIndex = 17
        '
        'dpTanggal
        '
        Me.dpTanggal.Location = New System.Drawing.Point(282, 434)
        Me.dpTanggal.Name = "dpTanggal"
        Me.dpTanggal.Size = New System.Drawing.Size(185, 26)
        Me.dpTanggal.TabIndex = 18
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(597, 187)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(506, 453)
        Me.DataGridView1.TabIndex = 19
        '
        'cbUnit
        '
        Me.cbUnit.FormattingEnabled = True
        Me.cbUnit.Location = New System.Drawing.Point(282, 243)
        Me.cbUnit.Name = "cbUnit"
        Me.cbUnit.Size = New System.Drawing.Size(185, 28)
        Me.cbUnit.TabIndex = 20
        '
        'PesanBtn
        '
        Me.PesanBtn.BackColor = System.Drawing.Color.ForestGreen
        Me.PesanBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PesanBtn.Location = New System.Drawing.Point(324, 608)
        Me.PesanBtn.Name = "PesanBtn"
        Me.PesanBtn.Size = New System.Drawing.Size(166, 32)
        Me.PesanBtn.TabIndex = 21
        Me.PesanBtn.Text = "Pesan"
        Me.PesanBtn.UseVisualStyleBackColor = False
        '
        'MetodeTxt
        '
        Me.MetodeTxt.Location = New System.Drawing.Point(282, 487)
        Me.MetodeTxt.Name = "MetodeTxt"
        Me.MetodeTxt.Size = New System.Drawing.Size(257, 26)
        Me.MetodeTxt.TabIndex = 25
        '
        'RekTxt
        '
        Me.RekTxt.Location = New System.Drawing.Point(282, 534)
        Me.RekTxt.Name = "RekTxt"
        Me.RekTxt.Size = New System.Drawing.Size(257, 26)
        Me.RekTxt.TabIndex = 26
        '
        'AtasnmTxt
        '
        Me.AtasnmTxt.Location = New System.Drawing.Point(282, 577)
        Me.AtasnmTxt.Name = "AtasnmTxt"
        Me.AtasnmTxt.Size = New System.Drawing.Size(257, 26)
        Me.AtasnmTxt.TabIndex = 27
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.D_Kost_Project.My.Resources.Resources.Form_Transaksi
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1115, 652)
        Me.Controls.Add(Me.AtasnmTxt)
        Me.Controls.Add(Me.RekTxt)
        Me.Controls.Add(Me.MetodeTxt)
        Me.Controls.Add(Me.PesanBtn)
        Me.Controls.Add(Me.cbUnit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dpTanggal)
        Me.Controls.Add(Me.TotalTxt)
        Me.Controls.Add(Me.sewa)
        Me.Controls.Add(Me.IDUnitTxt)
        Me.Controls.Add(Me.PelangganTxt)
        Me.Controls.Add(Me.BtnMain)
        Me.Name = "Form5"
        Me.Text = "Pemesanan"
        CType(Me.sewa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnMain As Button
    Friend WithEvents PelangganTxt As TextBox
    Friend WithEvents IDUnitTxt As TextBox
    Friend WithEvents sewa As NumericUpDown
    Friend WithEvents TotalTxt As TextBox
    Friend WithEvents dpTanggal As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cbUnit As ComboBox
    Friend WithEvents PesanBtn As Button
    Friend WithEvents MetodeTxt As TextBox
    Friend WithEvents RekTxt As TextBox
    Friend WithEvents AtasnmTxt As TextBox
End Class
