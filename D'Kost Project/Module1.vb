Imports MySql.Data.MySqlClient

Module modKoneksi
    ' Deklarasi variabel koneksi string untuk digunakan dalam seluruh aplikasi
    Private connectionString As String = "server=localhost;user id=root;port=3307;" &
                                         "password=;database=d'kost1;"

    ' Fungsi untuk mendapatkan objek MySqlConnection
    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connectionString)
        Try
            ' Buka koneksi
            conn.Open()
        Catch ex As MySqlException
            ' Jika gagal koneksi, tampilkan pesan error
            MessageBox.Show("Error saat mencoba menghubungkan ke database: " & ex.Message)
        End Try
        ' Kembalikan objek koneksi yang sudah dibuka
        Return conn
    End Function
End Module
