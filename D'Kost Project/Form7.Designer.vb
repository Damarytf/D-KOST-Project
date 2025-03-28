<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.ListBtn = New System.Windows.Forms.Button()
        Me.ReportBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LogoutBtn
        '
        Me.LogoutBtn.BackColor = System.Drawing.Color.Red
        Me.LogoutBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LogoutBtn.Location = New System.Drawing.Point(924, 104)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(179, 43)
        Me.LogoutBtn.TabIndex = 0
        Me.LogoutBtn.Text = "Log Out"
        Me.LogoutBtn.UseVisualStyleBackColor = False
        '
        'ListBtn
        '
        Me.ListBtn.BackColor = System.Drawing.Color.DarkBlue
        Me.ListBtn.ForeColor = System.Drawing.Color.AliceBlue
        Me.ListBtn.Location = New System.Drawing.Point(276, 371)
        Me.ListBtn.Name = "ListBtn"
        Me.ListBtn.Size = New System.Drawing.Size(240, 62)
        Me.ListBtn.TabIndex = 1
        Me.ListBtn.Text = "List Kost/Apartemen"
        Me.ListBtn.UseVisualStyleBackColor = False
        '
        'ReportBtn
        '
        Me.ReportBtn.BackColor = System.Drawing.Color.DarkBlue
        Me.ReportBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReportBtn.Location = New System.Drawing.Point(696, 371)
        Me.ReportBtn.Name = "ReportBtn"
        Me.ReportBtn.Size = New System.Drawing.Size(256, 62)
        Me.ReportBtn.TabIndex = 2
        Me.ReportBtn.Text = "Report Transaksi"
        Me.ReportBtn.UseVisualStyleBackColor = False
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.D_Kost_Project.My.Resources.Resources.Admin_Page
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1115, 652)
        Me.Controls.Add(Me.ReportBtn)
        Me.Controls.Add(Me.ListBtn)
        Me.Controls.Add(Me.LogoutBtn)
        Me.Name = "Form7"
        Me.Text = "Admin Page"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogoutBtn As Button
    Friend WithEvents ListBtn As Button
    Friend WithEvents ReportBtn As Button
End Class
