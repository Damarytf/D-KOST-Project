Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class Form8
    Dim conn As MySqlConnection

    ' Event yang dijalankan saat Form8 diload
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi koneksi database
        conn = New MySqlConnection("server=localhost;user id=root;port=3307;password=;database=d'kost1;")
        TampilData() ' Memanggil fungsi untuk menampilkan data
    End Sub

    ' Event yang dijalankan saat tombol kembali diklik
    Private Sub kembaliBtn_Click(sender As Object, e As EventArgs) Handles kembaliBtn.Click
        Dim form7 As New Form7()
        form7.Show()
        Me.Close()
    End Sub

    ' Fungsi menampilkan data ke DataGridView
    Private Sub TampilData()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close() ' Pastikan koneksi ditutup sebelum dibuka lagi
            End If
            conn.Open()
            Dim query As String = "SELECT * FROM listunit" ' Menggunakan nama tabel "listunit"
            Dim command As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Cek apakah data berhasil terisi
            If table.Rows.Count > 0 Then
                DataGridView1.DataSource = table
            Else
                MessageBox.Show("Tidak ada data untuk ditampilkan.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error saat menampilkan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Fungsi untuk membuat ID Unit baru
    Private Function GenerateID(prefix As String) As String
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close() ' Pastikan koneksi ditutup sebelum dibuka lagi
            End If
            conn.Open()
            Dim query As String = "SELECT MAX(ID_Unit) FROM listunit WHERE ID_Unit LIKE @Prefix" ' Menggunakan ID_Unit
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@Prefix", prefix & "%")
            Dim result = command.ExecuteScalar()

            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Dim lastID As String = result.ToString()
                Dim numberPart As Integer = CInt(lastID.Substring(3)) + 1
                Return prefix & numberPart.ToString("D3")
            Else
                Return prefix & "001"
            End If
        Catch ex As Exception
            MessageBox.Show("Error saat membuat ID: " & ex.Message)
            Return prefix & "001"
        Finally
            conn.Close()
        End Try
    End Function

    ' Event untuk menambahkan data baru
    Private Sub TambahBtn_Click(sender As Object, e As EventArgs) Handles TambahBtn.Click
        If String.IsNullOrWhiteSpace(IDTxt.Text) OrElse
           String.IsNullOrWhiteSpace(UnitTxt.Text) OrElse
           String.IsNullOrWhiteSpace(AlamatTxt.Text) OrElse
           String.IsNullOrWhiteSpace(HargaTxt.Text) OrElse
           String.IsNullOrWhiteSpace(KontakTxt.Text) Then
            MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim unitType As String = IDTxt.Text
        Dim newID As String = GenerateID("UNT")

        Try
            If conn.State = ConnectionState.Open Then
                conn.Close() ' Pastikan koneksi ditutup sebelum dibuka lagi
            End If
            conn.Open()
            Dim query As String = "INSERT INTO listunit (ID_Unit, Nama_Unit, Alamat, Harga_Sewa, Kontak) " &
                                  "VALUES (@ID_Unit, @Nama_Unit, @Alamat, @Harga_Sewa, @Kontak)"
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@ID_Unit", newID)
            command.Parameters.AddWithValue("@Nama_Unit", UnitTxt.Text)
            command.Parameters.AddWithValue("@Alamat", AlamatTxt.Text)
            command.Parameters.AddWithValue("@Harga_Sewa", HargaTxt.Text)
            command.Parameters.AddWithValue("@Kontak", KontakTxt.Text)

            If command.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Data berhasil ditambahkan!")
                TampilData() ' Memanggil TampilData untuk refresh DataGridView
                ClearInputFields() ' Mengosongkan kolom input
            Else
                MessageBox.Show("Gagal menambahkan data.")
            End If
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat menambahkan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Event untuk mengedit data
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If String.IsNullOrWhiteSpace(IDTxt.Text) Then
            MessageBox.Show("Masukkan ID Unit yang ingin diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If conn.State = ConnectionState.Open Then
                conn.Close() ' Pastikan koneksi ditutup sebelum dibuka lagi
            End If
            conn.Open()
            Dim query As String = "UPDATE listunit SET Nama_Unit=@Nama_Unit, Alamat=@Alamat, Harga_Sewa=@Harga_Sewa, Kontak=@Kontak WHERE ID_Unit=@ID_Unit"
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@ID_Unit", IDTxt.Text)
            command.Parameters.AddWithValue("@Nama_Unit", UnitTxt.Text)
            command.Parameters.AddWithValue("@Alamat", AlamatTxt.Text)
            command.Parameters.AddWithValue("@Harga_Sewa", HargaTxt.Text)
            command.Parameters.AddWithValue("@Kontak", KontakTxt.Text)

            If command.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Data berhasil diperbarui!")
                TampilData() ' Memanggil TampilData untuk refresh DataGridView
                ClearInputFields() ' Mengosongkan kolom input
            Else
                MessageBox.Show("Gagal memperbarui data.")
            End If
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat memperbarui data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Event untuk menghapus data
    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        If String.IsNullOrWhiteSpace(IDTxt.Text) Then
            MessageBox.Show("Masukkan ID Unit yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim dialogResult As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.No Then Return

        Try
            If conn.State = ConnectionState.Open Then
                conn.Close() ' Pastikan koneksi ditutup sebelum dibuka lagi
            End If
            conn.Open()
            Dim query As String = "DELETE FROM listunit WHERE ID_Unit=@ID_Unit"
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@ID_Unit", IDTxt.Text)

            If command.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Data berhasil dihapus!")
                TampilData() ' Memanggil TampilData untuk refresh DataGridView
                ClearInputFields() ' Mengosongkan kolom input
            Else
                MessageBox.Show("Gagal menghapus data.")
            End If
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat menghapus data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Event ketika data di DataGridView diklik
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Try
                ' Mengakses kolom ID dengan memastikan nama kolom sesuai
                IDTxt.Text = row.Cells("ID_Unit").Value.ToString()
                UnitTxt.Text = row.Cells("Nama_Unit").Value.ToString()
                AlamatTxt.Text = row.Cells("Alamat").Value.ToString()
                HargaTxt.Text = row.Cells("Harga_Sewa").Value.ToString()
                KontakTxt.Text = row.Cells("Kontak").Value.ToString()
            Catch ex As Exception
                MessageBox.Show("Kesalahan: " & ex.Message)
            End Try
        End If
    End Sub

    ' Fungsi untuk mengosongkan input fields
    Private Sub ClearInputFields()
        IDTxt.Clear()
        UnitTxt.Clear()
        AlamatTxt.Clear()
        HargaTxt.Clear()
        KontakTxt.Clear()
    End Sub
End Class
