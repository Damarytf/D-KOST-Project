Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Kode yang ingin dijalankan saat Form2 diload (jika ada)
    End Sub

    Private Sub BtnKost_Click(sender As Object, e As EventArgs) Handles BtnKost.Click
        Try
            Dim form3 As New Form3() ' Membuat instance dari Form3
            form3.Show() ' Menampilkan Form3
            Me.Hide() ' Menyembunyikan Form2
        Catch ex As Exception
            MessageBox.Show("Error saat membuka Form3: " & ex.Message) ' Pesan kesalahan
        End Try
    End Sub

    Private Sub BtnApart_Click(sender As Object, e As EventArgs) Handles BtnApart.Click
        Try
            Dim form4 As New Form4() ' Membuat instance dari Form4
            form4.Show() ' Menampilkan Form4
            Me.Hide() ' Menyembunyikan Form2
        Catch ex As Exception
            MessageBox.Show("Error saat membuka Form4: " & ex.Message) ' Pesan kesalahan
        End Try
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        ' Membuat instance dari Form1
        Dim form1 As New Form1()

        ' Menampilkan Form1
        form1.Show()

        ' Menyembunyikan Form2 (logout dan kembali ke form login)
        Me.Hide()
    End Sub
End Class
