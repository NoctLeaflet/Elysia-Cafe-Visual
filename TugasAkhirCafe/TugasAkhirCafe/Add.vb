Imports MySql.Data.MySqlClient
Imports MySqlConnector
Public Class Add
    Dim cn As New MySqlConnection
    Dim ds As New DataSet
    Dim da As New MySqlDataAdapter
    Dim cmd As New MySqlCommand
    Dim tabel As New DataTable
    Dim rd As MySqlDataReader
    Private Sub koneksinya()
        cn.ConnectionString = "server=Localhost;user=root;password=;database=tugasakhircafe;allow user variables=true"
    End Sub
    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Dim SQL As String
        If TextBoxNama.Text IsNot "" Then
            Try
                SQL = "INSERT INTO produk VALUES (NULL, '" + TextBoxNama.Text + "', '" + TextBoxHarga.Text + "', '" + ComboBoxAdd.SelectedItem + "', '" + TextBoxStock.Text + "');"

                cn.Open()
                cmd.Connection = cn
                cmd.CommandText = SQL
                cmd.ExecuteNonQuery()
                cn.Close()
                MsgBox("Data Sudah Di Tambahkan")
            Catch ex As Exception
                MsgBox("Data Gagal Di Tambahkan")
                cn.Close()
            End Try
        End If
    End Sub

    Private Sub Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksinya()
    End Sub
End Class