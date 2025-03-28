Imports System.Data.Common
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form5
    Private unitList As New List(Of Tuple(Of String, String))()
    Private dataAdapter As MySqlDataAdapter
    Private dataSet As DataSet

    ' Fungsi untuk mendapatkan koneksi ke database
    Private Function GetConnection() As MySqlConnection
        Dim connString As String = "server=localhost;user id=root;port=3307;password=;database=d'kost1;"
        Return New MySqlConnection(connString)
    End Function

    Public Sub InsertTransaction()
        Dim pelanggan As String = PelangganTxt.Text
        Dim idUnit As String = IDUnitTxt.Text
        Dim sewaPerBulan As Integer = sewa.Value
        Dim totalHarga As Decimal = GetHargaUnit(idUnit) * sewaPerBulan
        Dim tanggalOrder As DateTime = dpTanggal.Value

        ' Validasi nama pelanggan
        If String.IsNullOrWhiteSpace(pelanggan) Then
            MessageBox.Show("Nama pelanggan harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi unit harus dipilih
        If cbUnit.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih unit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi Sewa Per Bulan
        If sewaPerBulan <= 0 Then
            MessageBox.Show("Sewa per bulan harus > 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Membuka koneksi database
        Dim conn As MySqlConnection = GetConnection()
        Dim query As String = "INSERT INTO tbltransaksi (Pelanggan, ID_Unit, Sewa_Per_Bulan, Total_Harga, Tanggal_Order, Metode_Bayar, No_Rekening, Atas_Nama) " &
                              "VALUES (@Pelanggan, @ID_Unit, @Sewa_Per_Bulan, @Total_Harga, @Tanggal_Order, @Metode_Bayar, @No_Rekening, @Atas_Nama)"

        Using cmd As New MySqlCommand(query, conn)
            Try
                cmd.Parameters.AddWithValue("@Pelanggan", pelanggan)
                cmd.Parameters.AddWithValue("@ID_Unit", idUnit)
                cmd.Parameters.AddWithValue("@Sewa_Per_Bulan", sewaPerBulan)
                cmd.Parameters.AddWithValue("@Total_Harga", totalHarga)
                cmd.Parameters.AddWithValue("@Tanggal_Order", tanggalOrder)
                cmd.Parameters.AddWithValue("@Metode_Bayar", MetodeTxt.Text)
                cmd.Parameters.AddWithValue("@No_Rekening", RekTxt.Text)
                cmd.Parameters.AddWithValue("@Atas_Nama", AtasnmTxt.Text)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()

                MessageBox.Show("Transaksi berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshForm()
            Catch ex As Exception
                MessageBox.Show("Error saving transaction: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub RefreshForm()
        PelangganTxt.Clear()
        IDUnitTxt.Clear()
        TotalTxt.Clear()
        sewa.Value = 0
        LoadData()
    End Sub

    Private Sub PesanBtn_Click(sender As Object, e As EventArgs) Handles PesanBtn.Click
        InsertTransaction()
    End Sub

    Sub LoadData()
        Dim selectQuery As String = "SELECT ID_Transaksi, Pelanggan, ID_Unit AS 'ID Unit', Sewa_Per_Bulan AS 'Sewa Per Bulan', Total_Harga AS 'Total Harga', Tanggal_Order AS 'Tanggal Order', Metode_Bayar AS 'Metode Bayar', No_Rekening AS 'No Rekening', Atas_Nama AS 'Atas Nama' FROM tbltransaksi"
        Dim conn As MySqlConnection = GetConnection()
        dataAdapter = New MySqlDataAdapter(selectQuery, conn)
        dataSet = New DataSet()
        Try
            conn.Open()
            dataAdapter.Fill(dataSet, "tbltransaksi")
            DataGridView1.DataSource = dataSet.Tables("tbltransaksi")
        Catch ex As MySqlException
            MessageBox.Show("Error : " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadUnitList()
        Dim query As String = "SELECT ID_Unit, Nama_Unit FROM listunit"
        Dim conn As MySqlConnection = GetConnection()
        cbUnit.Items.Clear()
        unitList.Clear()

        Using command As New MySqlCommand(query, conn)
            Try
                conn.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.HasRows = False Then
                    MessageBox.Show("Data unit tidak tersedia!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                While reader.Read()
                    Dim namaUnit As String = reader("Nama_Unit").ToString()
                    Dim idUnit As String = reader("ID_Unit").ToString()

                    If Not String.IsNullOrEmpty(namaUnit) And Not String.IsNullOrEmpty(idUnit) Then
                        cbUnit.Items.Add(namaUnit)
                        unitList.Add(Tuple.Create(namaUnit, idUnit))
                    End If
                End While
            Catch ex As Exception
                MessageBox.Show("Error loading unit list: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub cbUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUnit.SelectedIndexChanged
        Dim selectedUnit As String = cbUnit.SelectedItem.ToString()
        For Each unit In unitList
            If unit.Item1 = selectedUnit Then
                IDUnitTxt.Text = unit.Item2
                Exit For
            End If
        Next
    End Sub

    Private Sub sewa_ValueChanged(sender As Object, e As EventArgs) Handles sewa.ValueChanged
        Dim hargaUnit As Decimal = GetHargaUnit(IDUnitTxt.Text)
        Dim totalHarga As Decimal = hargaUnit * sewa.Value
        TotalTxt.Text = totalHarga.ToString("N2")
    End Sub

    Private Function GetHargaUnit(idUnit As String) As Decimal
        Dim harga As Decimal = 0
        If String.IsNullOrWhiteSpace(idUnit) Then
            MessageBox.Show("ID Unit tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End If

        Dim query As String = "SELECT Harga_Sewa FROM listunit WHERE ID_Unit = @ID_Unit"
        Dim conn As MySqlConnection = GetConnection()
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@ID_Unit", idUnit)
            Try
                conn.Open()
                Dim result = command.ExecuteScalar()
                If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                    harga = Convert.ToDecimal(result)
                Else
                    MessageBox.Show("Harga untuk ID Unit " & idUnit & " tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Error retrieving harga: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
        Return harga
    End Function

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDUnitTxt.ReadOnly = True
        TotalTxt.ReadOnly = True
        LoadUnitList()
        LoadData()
    End Sub

    Private Sub BtnMain_Click(sender As Object, e As EventArgs) Handles BtnMain.Click
        Me.Hide()
        Dim form2 As New Form2()
        form2.Show()
    End Sub

    Private Sub MetodeTxt_TextChanged(sender As Object, e As EventArgs) Handles MetodeTxt.TextChanged

    End Sub

    Private Sub RekTxt_TextChanged(sender As Object, e As EventArgs) Handles RekTxt.TextChanged

    End Sub

    Private Sub AtasnmTxt_TextChanged(sender As Object, e As EventArgs) Handles AtasnmTxt.TextChanged

    End Sub
End Class
