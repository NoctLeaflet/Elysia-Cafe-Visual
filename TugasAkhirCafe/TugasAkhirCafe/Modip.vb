Imports MySql.Data.MySqlClient
Imports MySqlConnector
Public Class Modip
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
    Private Sub Modip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksinya()
        TextBoxHargaAs.Enabled = False
        TextBoxSisaSTk.Enabled = False
        ButtonHapus.Enabled = False
        ButtonModip.Enabled = False
    End Sub

    Private Sub TextBoxNamamodip_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNamamodip.TextChanged
        Dim SQL As String
        Dim total As Integer = 0
        Dim empty As Integer = 0
        ListBoxProducModif.Items.Clear()
        SQL = "SELECT * FROM produk"
        SQL += " WHERE Nama LIKE '%" + TextBoxNamamodip.Text + "%'"
        If (ComboBoxJenisModp.SelectedIndex = 0) Then
            SQL += " AND Jenis = 'Makanan'"
        ElseIf (ComboBoxJenisModp.SelectedIndex = 1) Then
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
            Me.ListBoxProducModif.Items.Add(item(1))
        Next
        cn.Close()
    End Sub

    Private Sub ListBoxProducModif_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxProducModif.SelectedIndexChanged
        If ListBoxProducModif.Items.Count >= 1 Then
            Dim SQL As String
            Dim total As Integer = 0
            Dim empty As Integer = 0
            ButtonHapus.Enabled = True
            ButtonModip.Enabled = True
            SQL = "SELECT * FROM produk"
            SQL += " WHERE Nama LIKE '%" + ListBoxProducModif.SelectedItem + "%'"
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
                TextBoxHargaAs.Text = item(2)
                idp = item(0)
                TextBoxSisaSTk.Text = item(4)
                TextBoxHargaModip.Text = item(2)
                TextBoxStockModip.Text = item(4)
            Next
            cn.Close()
        Else
            ButtonHapus.Enabled = False
            ButtonModip.Enabled = False
        End If
    End Sub

    Private Sub ButtonModip_Click(sender As Object, e As EventArgs) Handles ButtonModip.Click
        Dim SQL As String
        If TextBoxHargaModip.Text IsNot "" And TextBoxStockModip.Text IsNot "" Then
            Try
                cn.Open()
                SQL = "UPDATE produk SET Stock = '" + TextBoxStockModip.Text + "',Harga = '" + TextBoxHargaModip.Text + "' WHERE ID = '" + idp + "';"
                cmd.Connection = cn
                cmd.CommandText = SQL
                cmd.ExecuteNonQuery()
                cn.Close()
                MsgBox("Data Sudah Di Ganti")
            Catch ex As Exception
                MsgBox("Data Gagal Di Ganti")
                cn.Close()
            End Try
        End If
    End Sub
    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Dim SQL As String
        If TextBoxHargaModip.Text IsNot "" And TextBoxStockModip.Text IsNot "" Then
            Try
                cn.Open()
                SQL = "DELETE From produk WHERE ID = '" + idp + "';"
                cmd.Connection = cn
                cmd.CommandText = SQL
                cmd.ExecuteNonQuery()
                cn.Close()
                MsgBox("Produk Sudah Di Hapus")
            Catch ex As Exception
                MsgBox("Produk Gagal Di Hapus")
                cn.Close()
            End Try
        End If
    End Sub

    Private Sub TextBoxStockModip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxStockModip.KeyPress
        Dim Ch As Char = e.KeyChar
        If Not Char.IsDigit(Ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxHargaModip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxHargaModip.KeyPress
        Dim Ch As Char = e.KeyChar
        If Not Char.IsDigit(Ch) Then
            e.Handled = True
        End If
    End Sub

End Class