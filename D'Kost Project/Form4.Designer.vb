<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.BtnPsn2 = New System.Windows.Forms.Button()
        Me.BtnBck2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnPsn2
        '
        Me.BtnPsn2.BackColor = System.Drawing.Color.Green
        Me.BtnPsn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPsn2.Location = New System.Drawing.Point(526, 579)
        Me.BtnPsn2.Name = "BtnPsn2"
        Me.BtnPsn2.Size = New System.Drawing.Size(269, 45)
        Me.BtnPsn2.TabIndex = 0
        Me.BtnPsn2.Text = "Pesan"
        Me.BtnPsn2.UseVisualStyleBackColor = False
        '
        'BtnBck2
        '
        Me.BtnBck2.BackColor = System.Drawing.Color.Red
        Me.BtnBck2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnBck2.Location = New System.Drawing.Point(857, 581)
        Me.BtnBck2.Name = "BtnBck2"
        Me.BtnBck2.Size = New System.Drawing.Size(102, 40)
        Me.BtnBck2.TabIndex = 1
        Me.BtnBck2.Text = "Kembali"
        Me.BtnBck2.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.D_Kost_Project.My.Resources.Resources.Gambar_4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1115, 652)
        Me.Controls.Add(Me.BtnBck2)
        Me.Controls.Add(Me.BtnPsn2)
        Me.Name = "Form4"
        Me.Text = "Apartment Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnPsn2 As Button
    Friend WithEvents BtnBck2 As Button
End Class
