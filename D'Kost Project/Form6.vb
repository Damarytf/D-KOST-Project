Imports MySql.Data.MySqlClient

Public Class Form6
    ' Event ketika Form6 dimuat
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Kode yang ingin dijalankan saat Form6 diload (jika ada)
    End Sub

    ' Event ketika tombol kembali diklik
    Private Sub Btnkembali_Click(sender As Object, e As EventArgs) Handles Btnkembali.Click
        ' Membuat instance dari Form1
        Dim form1 As New Form1()

        ' Menampilkan Form1
        form1.Show()

        ' Menyembunyikan Form6
        Me.Hide()
    End Sub

    ' Event ketika ada perubahan pada teks di UserTxt
    Private Sub UserTxt_TextChanged(sender As Object, e As EventArgs) Handles UserTxt.TextChanged
    End Sub

    ' Event ketika ada perubahan pada teks di PwTxt
    Private Sub PwTxt_TextChanged(sender As Object, e As EventArgs) Handles PwTxt.TextChanged
    End Sub

    ' Event ketika tombol Buat Akun diklik
    Private Sub BuatBtn_Click(sender As Object, e As EventArgs) Handles BuatBtn.Click
        ' Ambil nilai dari TextBox Username dan Password
        Dim username As String = UserTxt.Text.Trim()
        Dim password As String = PwTxt.Text.Trim()

        ' Validasi input
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Username dan password tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Pastikan password memiliki minimal 8 karakter
        If password.Length < 8 Then
            MessageBox.Show("Password harus memiliki minimal 8 karakter.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Panggil fungsi untuk membuat akun
        BuatAkun(username, password)
    End Sub

    ' Fungsi untuk membuat akun baru dan memasukkannya ke dalam database
    Private Sub BuatAkun(username As String, password As String)
        ' Enkripsi password (opsional) 
        Dim encryptedPassword As String = GetMD5Hash(password) ' Hash password

        ' Panggil koneksi dari modul modKoneksi
        Dim conn As MySqlConnection = GetConnection()

        ' Query untuk memasukkan akun baru ke dalam database
        Dim query As String = "INSERT INTO users (username, password) VALUES (@username, @password)"

        Try
            ' Buka koneksi jika belum dibuka
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Buat MySQL Command
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", encryptedPassword) ' Simpan password yang sudah di-hash

            ' Eksekusi query
            cmd.ExecuteNonQuery()

            ' Beri pesan sukses
            MessageBox.Show("Akun berhasil dibuat!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Kosongkan TextBox setelah sukses
            UserTxt.Text = ""
            PwTxt.Text = ""

        Catch ex As MySqlException
            ' Tangkap kesalahan MySQL, misal duplikasi username
            If ex.Number = 1062 Then ' Error kode 1062 artinya duplikasi entry
                MessageBox.Show("Username sudah digunakan. Silakan gunakan username lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Terjadi kesalahan MySQL: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            ' Tangkap kesalahan umum
            MessageBox.Show("Terjadi kesalahan tak terduga: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Tutup koneksi jika masih terbuka
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Fungsi untuk mengenkripsi password menggunakan MD5
    Private Function GetMD5Hash(input As String) As String
        ' Buat objek MD5
        Dim md5 As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bytes() As Byte = System.Text.Encoding.UTF8.GetBytes(input)
        bytes = md5.ComputeHash(bytes)

        Dim sb As New System.Text.StringBuilder()
        For Each b As Byte In bytes
            sb.Append(b.ToString("x2"))
        Next

        Return sb.ToString()
    End Function

    ' Fungsi untuk mendapatkan koneksi ke database
    Private Function GetConnection() As MySqlConnection
        ' Pastikan Anda mengubah string koneksi sesuai dengan pengaturan database Anda
        Dim connectionString As String = "server=localhost;user id=root;port=3307;password=;database=d'kost1;"
        Return New MySqlConnection(connectionString)
    End Function
End Class
