<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.BtnApart = New System.Windows.Forms.Button()
        Me.BtnKost = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnApart
        '
        Me.BtnApart.BackColor = System.Drawing.Color.Green
        Me.BtnApart.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnApart.Location = New System.Drawing.Point(301, 285)
        Me.BtnApart.Name = "BtnApart"
        Me.BtnApart.Size = New System.Drawing.Size(229, 43)
        Me.BtnApart.TabIndex = 0
        Me.BtnApart.Text = "Apartment"
        Me.BtnApart.UseVisualStyleBackColor = False
        '
        'BtnKost
        '
        Me.BtnKost.BackColor = System.Drawing.Color.Green
        Me.BtnKost.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnKost.Location = New System.Drawing.Point(650, 285)
        Me.BtnKost.Name = "BtnKost"
        Me.BtnKost.Size = New System.Drawing.Size(229, 43)
        Me.BtnKost.TabIndex = 1
        Me.BtnKost.Text = "Kost"
        Me.BtnKost.UseVisualStyleBackColor = False
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.Red
        Me.BtnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLogout.Location = New System.Drawing.Point(927, 103)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(176, 38)
        Me.BtnLogout.TabIndex = 2
        Me.BtnLogout.Text = "Log Out"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.D_Kost_Project.My.Resources.Resources.Gambar_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1115, 652)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnKost)
        Me.Controls.Add(Me.BtnApart)
        Me.Name = "Form2"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnApart As Button
    Friend WithEvents BtnKost As Button
    Friend WithEvents BtnLogout As Button
End Class
