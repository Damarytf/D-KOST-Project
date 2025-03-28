<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.BuatBtn = New System.Windows.Forms.Button()
        Me.UserTxt = New System.Windows.Forms.TextBox()
        Me.PwTxt = New System.Windows.Forms.TextBox()
        Me.Btnkembali = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BuatBtn
        '
        Me.BuatBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BuatBtn.Location = New System.Drawing.Point(433, 418)
        Me.BuatBtn.Name = "BuatBtn"
        Me.BuatBtn.Size = New System.Drawing.Size(203, 42)
        Me.BuatBtn.TabIndex = 5
        Me.BuatBtn.Text = "Buat Akun"
        Me.BuatBtn.UseVisualStyleBackColor = False
        '
        'UserTxt
        '
        Me.UserTxt.Location = New System.Drawing.Point(262, 291)
        Me.UserTxt.Name = "UserTxt"
        Me.UserTxt.Size = New System.Drawing.Size(543, 26)
        Me.UserTxt.TabIndex = 6
        '
        'PwTxt
        '
        Me.PwTxt.Location = New System.Drawing.Point(262, 383)
        Me.PwTxt.Name = "PwTxt"
        Me.PwTxt.Size = New System.Drawing.Size(543, 26)
        Me.PwTxt.TabIndex = 7
        '
        'Btnkembali
        '
        Me.Btnkembali.BackColor = System.Drawing.Color.Red
        Me.Btnkembali.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Btnkembali.Location = New System.Drawing.Point(900, 12)
        Me.Btnkembali.Name = "Btnkembali"
        Me.Btnkembali.Size = New System.Drawing.Size(203, 41)
        Me.Btnkembali.TabIndex = 8
        Me.Btnkembali.Text = "Kembali"
        Me.Btnkembali.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.D_Kost_Project.My.Resources.Resources.Gambar_6
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1115, 652)
        Me.Controls.Add(Me.Btnkembali)
        Me.Controls.Add(Me.PwTxt)
        Me.Controls.Add(Me.UserTxt)
        Me.Controls.Add(Me.BuatBtn)
        Me.Name = "Form6"
        Me.Text = "Buat Akun"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BuatBtn As Button
    Friend WithEvents UserTxt As TextBox
    Friend WithEvents PwTxt As TextBox
    Friend WithEvents Btnkembali As Button
End Class
