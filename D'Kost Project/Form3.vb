Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Kode yang ingin dijalankan saat Form3 diload
    End Sub

    Private Sub BtnBck1_Click(sender As Object, e As EventArgs) Handles BtnBck1.Click
        ' Membuat instance dari Form2
        Dim form2 As New Form2()

        ' Menampilkan Form2
        form2.Show()

        ' Menyembunyikan Form3
        Me.Hide()
    End Sub

    Private Sub BtnPsn1_Click(sender As Object, e As EventArgs) Handles BtnPsn1.Click
        ' Membuat instance dari Form5
        Dim form5 As New Form5()

        ' Menampilkan Form5
        form5.Show()

        ' Menyembunyikan Form3
        Me.Hide()
    End Sub
End Class
