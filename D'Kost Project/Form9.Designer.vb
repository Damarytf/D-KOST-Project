<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.AdminmenuBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(229, 228)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 26)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(473, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.PeachPuff
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "D_Kost_Project.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(159, 285)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(809, 335)
        Me.ReportViewer1.TabIndex = 3
        '
        'AdminmenuBtn
        '
        Me.AdminmenuBtn.BackColor = System.Drawing.Color.DarkBlue
        Me.AdminmenuBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AdminmenuBtn.Location = New System.Drawing.Point(931, 101)
        Me.AdminmenuBtn.Name = "AdminmenuBtn"
        Me.AdminmenuBtn.Size = New System.Drawing.Size(172, 52)
        Me.AdminmenuBtn.TabIndex = 4
        Me.AdminmenuBtn.Text = "Admin Menu"
        Me.AdminmenuBtn.UseVisualStyleBackColor = False
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.D_Kost_Project.My.Resources.Resources._6
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1115, 652)
        Me.Controls.Add(Me.AdminmenuBtn)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form9"
        Me.Text = "Report Pembayaran"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AdminmenuBtn As Button
End Class
