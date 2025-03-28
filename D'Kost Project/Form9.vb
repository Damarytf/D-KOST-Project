Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Form9
    Private dataSet As DataSet1
    Private dataAdapter As MySqlDataAdapter

    ' Fungsi untuk mendapatkan koneksi ke database
    Private Function GetConnection() As MySqlConnection
        ' Koneksi ke database (sesuaikan jika perlu)
        Dim connectionString As String = "Server=localhost;Port=3307;Database=d'kost1;userid=root;"
        Return New MySqlConnection(connectionString)
    End Function

    ' Event ketika form dimuat
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
    End Sub

    ' Event ketika Button1 diklik
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim transaksiID As Integer

        ' Validasi input dari TextBox1 (ID transaksi)
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Transaction ID cannot be empty. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Cek apakah input berupa angka
        If Not Integer.TryParse(TextBox1.Text, transaksiID) Then
            MessageBox.Show("Please enter a valid numeric Transaction ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ambil data untuk transaksiID yang diberikan
        Dim dt As New DataTable()
        Dim query As String = "
            SELECT 
                ID_Transaksi, 
                Pelanggan, 
                Tanggal_Order, 
                Total_Harga, 
                Metode_Bayar, 
                No_Rekening, 
                Atas_Nama, 
                ID_Unit, 
                Sewa_Per_Bulan
            FROM 
                tbltransaksi
            WHERE 
                ID_Transaksi = @transaksiID"

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@transaksiID", transaksiID)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using

            ' Cek apakah data ditemukan
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No data found for the given Transaction ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Mengikat data ke ReportViewer
            Dim rds As New ReportDataSource("DataSet1", dt)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rds)

            ' Refresh ReportViewer
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AdminmenuBtn_Click(sender As Object, e As EventArgs) Handles AdminmenuBtn.Click
        Dim form7 As New Form7()
        form7.Show()
        Me.Hide()
    End Sub
End Class
