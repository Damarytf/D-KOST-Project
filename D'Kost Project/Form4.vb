Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Kode yang ingin dijalankan saat Form4 diload
    End Sub

    Private Sub BtnBck2_Click(sender As Object, e As EventArgs) Handles BtnBck2.Click
        ' Membuat instance dari Form2
        Dim form2 As New Form2()

        ' Menampilkan Form2
        form2.Show()

        ' Menyembunyikan Form4
        Me.Hide()
    End Sub

    Private Sub BtnPsn2_Click(sender As Object, e As EventArgs) Handles BtnPsn2.Click
        ' Membuat instance dari Form5
        Dim form5 As New Form5()

        ' Menampilkan Form5
        form5.Show()

        ' Menyembunyikan Form4
        Me.Hide()
    End Sub
End Class
