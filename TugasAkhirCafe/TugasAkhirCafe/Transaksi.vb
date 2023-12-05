Imports MySql.Data.MySqlClient
Imports MySqlConnector
Public Class Transaksi
    Dim cn As New MySqlConnection
    Dim ds As New DataSet
    Dim da As New MySqlDataAdapter
    Dim cmd As New MySqlCommand
    Dim tabel As New DataTable
    Dim rd As MySqlDataReader
    Dim idp As String
    Private Sub koneksinya()
        cn.ConnectionString = "server=Localhost;user=root;password=;database=tugasakhircafe;allow user variables=true"
    End Sub

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksinya()
        ButtonPesan.Enabled = False
        TextBoxHargaCari.Enabled = False
        TextBoxSisa.Enabled = False
        TextBoxtolhar.Enabled = False
        TextBoxJumBel.Enabled = False
    End Sub

    Private Sub TextBoxNamaCari_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNamaCari.TextChanged
        Dim SQL As String
        Dim total As Integer = 0
        Dim empty As Integer = 0
        ListBoxProducFind.Items.Clear()
        SQL = "SELECT * FROM produk"
        SQL += " WHERE Nama LIKE '%" + TextBoxNamaCari.Text + "%'"
        If (ComboBoxJeniscari.SelectedIndex = 0) Then
            SQL += " AND Jenis = 'Makanan'"
        ElseIf (ComboBoxJeniscari.SelectedIndex = 1) Then
            SQL += " AND Jenis = 'Minuman'"
        End If
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = SQL
        da.SelectCommand = cmd
        tabel.Clear()
        da.Fill(tabel)
        For Each row As DataRow In tabel.Rows
            Dim item(6) As String
            Dim index As Integer = 0
            For Each col As DataColumn In tabel.Columns
                item(index) = row(col).ToString()
                index += 1
            Next
            total += 1
            Dim otherItems As String() = {item(1), item(2), item(3), item(4), item(5), item(6)}
            Me.ListBoxProducFind.Items.Add(item(1))
        Next
        cn.Close()
    End Sub

    Private Sub ListBoxProducFind_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxProducFind.SelectedIndexChanged
        If ListBoxProducFind.Items.Count >= 1 Then
            Dim SQL As String
            Dim total As Integer = 0
            Dim empty As Integer = 0
            ButtonPesan.Enabled = True
            TextBoxJumBel.Enabled = True
            SQL = "SELECT * FROM produk"
            SQL += " WHERE Nama LIKE '%" + ListBoxProducFind.SelectedItem + "%'"
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = SQL
            da.SelectCommand = cmd
            tabel.Clear()
            da.Fill(tabel)
            For Each row As DataRow In tabel.Rows
                Dim item(4) As String
                Dim index As Integer = 0
                For Each col As DataColumn In tabel.Columns
                    item(index) = row(col).ToString()
                    index += 1
                Next
                total += 1
                TextBoxHargaCari.Text = item(2)
                idp = item(0)
                TextBoxSisa.Text = item(4)
            Next
            cn.Close()
        Else
            ButtonPesan.Enabled = False
        End If
    End Sub

    Private Sub TextBoxJumBel_TextChanged(sender As Object, e As EventArgs) Handles TextBoxJumBel.TextChanged
        Dim a, b As Integer
        Try
            a = Convert.ToInt32(TextBoxJumBel.Text)
            b = Convert.ToInt32(TextBoxHargaCari.Text)
            TextBoxtolhar.Text = a * b
        Catch ex As Exception
            TextBoxJumBel.Text = 0

        End Try
    End Sub

    Private Sub ButtonPesan_Click(sender As Object, e As EventArgs) Handles ButtonPesan.Click
        Dim SQL As String
        If TextBoxJumBel.Text IsNot "0" Then
            Try
                SQL = "INSERT INTO transaksi VALUES (NULL, '" + ListBoxProducFind.SelectedItem + "', 
                        '" + TextBoxJumBel.Text + "', '" + TextBoxHargaCari.Text + "', 
                        '" + TextBoxPembe.Text + "', '" + TextBoxKasir.Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + TextBoxtolhar.Text + "');"
                cn.Open()
                cmd.Connection = cn
                cmd.CommandText = SQL
                cmd.ExecuteNonQuery()
                cn.Close()
                cn.Open()
                Dim q, g, c As Integer
                q = Convert.ToInt32(TextBoxJumBel.Text)
                g = Convert.ToInt32(TextBoxSisa.Text)
                c = g - q
                SQL = "UPDATE produk SET Stock = '" + c.ToString + "' WHERE ID = '" + idp + "';"
                cmd.Connection = cn
                cmd.CommandText = SQL
                cmd.ExecuteNonQuery()
                cn.Close()
                MsgBox("Pesanan Tersimpan")
            Catch ex As Exception
                MsgBox("Data Gagal Di Tambahkan")
                cn.Close()
            End Try
        End If
    End Sub
End Class