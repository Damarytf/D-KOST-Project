Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Kode lainnya jika diperlukan
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        ' Cek apakah Form1 sudah ada di background, jika tidak, buat instance baru
        If Application.OpenForms.OfType(Of Form1)().Any() Then
            Application.OpenForms.OfType(Of Form1)().First().Show()
        Else
            Dim form1 As New Form1()
            form1.Show()
        End If

        ' Menutup Form7 setelah logout
        Me.Close()
    End Sub

    Private Sub ListBtn_Click(sender As Object, e As EventArgs) Handles ListBtn.Click
        ' Membuat instance baru dari Form8
        Dim form8 As New Form8()

        ' Menampilkan Form8
        form8.Show()

        ' Menutup Form7
        Me.Hide()
    End Sub

    Private Sub ReportBtn_Click(sender As Object, e As EventArgs) Handles ReportBtn.Click
        ' Membuat instance baru dari Form8
        Dim form8 As New Form9()

        ' Menampilkan Form8
        Form9.Show()

        ' Menutup Form7
        Me.Hide()
    End Sub
End Class
