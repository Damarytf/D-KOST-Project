<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.BtnPsn1 = New System.Windows.Forms.Button()
        Me.BtnBck1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnPsn1
        '
        Me.BtnPsn1.BackColor = System.Drawing.Color.Green
        Me.BtnPsn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPsn1.Location = New System.Drawing.Point(525, 564)
        Me.BtnPsn1.Name = "BtnPsn1"
        Me.BtnPsn1.Size = New System.Drawing.Size(281, 49)
        Me.BtnPsn1.TabIndex = 0
        Me.BtnPsn1.Text = "Pesan"
        Me.BtnPsn1.UseVisualStyleBackColor = False
        '
        'BtnBck1
        '
        Me.BtnBck1.BackColor = System.Drawing.Color.Red
        Me.BtnBck1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnBck1.Location = New System.Drawing.Point(868, 569)
        Me.BtnBck1.Name = "BtnBck1"
        Me.BtnBck1.Size = New System.Drawing.Size(103, 39)
        Me.BtnBck1.TabIndex = 1
        Me.BtnBck1.Text = "Kembali"
        Me.BtnBck1.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.D_Kost_Project.My.Resources.Resources.Gambar_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1115, 652)
        Me.Controls.Add(Me.BtnBck1)
        Me.Controls.Add(Me.BtnPsn1)
        Me.Name = "Form3"
        Me.Text = "Kost Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnPsn1 As Button
    Friend WithEvents BtnBck1 As Button
End Class
