Imports MySql.Data.MySqlClient

Public Class Form1
    Private WithEvents errorProvider As New ErrorProvider()

    ' Event yang dijalankan saat Form1 diload
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cek koneksi saat form pertama kali dibuka
        Dim conn As MySqlConnection = GetConnection()
        Try
            conn.Open()
            Console.WriteLine("Koneksi berhasil!")
        Catch ex As MySqlException
            MessageBox.Show("Koneksi gagal: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Fungsi untuk login
    Private Function AuthenticateUser(username As String, password As String) As Boolean
        ' Query SQL untuk mengecek apakah user dengan username dan password tersebut ada di database
        Dim query As String = "SELECT COUNT(*) FROM users WHERE username=@username AND password=SHA2(@password, 256)"
        Dim conn As MySqlConnection = GetConnection()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)
                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return result > 0
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error saat login: " & ex.Message)
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    ' Event yang dijalankan saat tombol login diklik
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String = TxtUser.Text.Trim()
        Dim password As String = TxtPassword.Text.Trim()

        ' Menghapus error sebelumnya
        errorProvider.SetError(TxtUser, "")
        errorProvider.SetError(TxtPassword, "")

        ' Validasi input
        If String.IsNullOrEmpty(username) Then
            errorProvider.SetError(TxtUser, "Username tidak boleh kosong.")
        End If

        If password.Length < 8 Then
            errorProvider.SetError(TxtPassword, "Password harus terdiri dari minimal 8 karakter.")
        End If

        ' Jika ada error, tidak lanjutkan ke autentikasi
        If String.IsNullOrEmpty(username) OrElse password.Length < 8 Then
            MessageBox.Show("Periksa username dan password Anda.")
            Return
        End If

        ' Pengecekan login untuk admin
        If username = "admin" AndAlso password = "87654321" Then
            MessageBox.Show("Login sebagai Admin berhasil!")
            Dim form7 As New Form7()
            form7.Show() ' Tampilkan Form7
            Me.Hide() ' Sembunyikan Form1
            Return ' Hentikan eksekusi lebih lanjut
        End If

        ' Panggil fungsi AuthenticateUser untuk mengecek username dan password
        If AuthenticateUser(username, password) Then
            MessageBox.Show("Login berhasil!")
            Dim form2 As New Form2()
            form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Login gagal! Username atau password salah.")
        End If
    End Sub

    ' Event yang dijalankan saat tombol buat akun diklik
    Private Sub Btnbuatakun_Click(sender As Object, e As EventArgs) Handles Btnbuatakun.Click
        ' Membuat instance dari Form6
        Dim form6 As New Form6()
        form6.Show()
        Me.Hide()
    End Sub

    ' Fungsi untuk mendapatkan koneksi ke database
    Private Function GetConnection() As MySqlConnection
        ' Pastikan Anda mengubah string koneksi sesuai dengan pengaturan database Anda
        Dim connectionString As String = "server=localhost;user id=root;port=3307;password=;database=d'kost1;"
        Return New MySqlConnection(connectionString)
    End Function
End Class
