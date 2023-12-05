Imports MySql.Data.MySqlClient
Imports MySqlConnector
Public Class Report
    Dim cn As New MySqlConnection
    Dim ds As New DataSet
    Dim da As New MySqlDataAdapter
    Dim cmd As New MySqlCommand
    Dim tabel As New DataTable
    Dim rd As MySqlDataReader
    Private Sub koneksinya()
        cn.ConnectionString = "server=Localhost;user=root;password=;database=tugasakhircafe;allow user variables=true"
    End Sub
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksinya()
    End Sub

    Private Sub ButtonRef_Click(sender As Object, e As EventArgs) Handles ButtonRef.Click
        ListViewRep.Items.Clear()
        Dim SQL As String
        Dim total As Integer = 0
        Dim empty As Integer = 0
        SQL = "SELECT * FROM transaksi"
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = SQL
        da.SelectCommand = cmd
        tabel.Clear()
        da.Fill(tabel)
        For Each row As DataRow In tabel.Rows
            Dim item(7) As String
            Dim index As Integer = 0
            For Each col As DataColumn In tabel.Columns
                item(index) = row(col).ToString()
                index += 1
            Next
            total += 1
            Dim otherItems As String() = {item(1), item(2), item(7), item(4), item(5), item(6)}

            Me.ListViewRep.Items.Add(item(0)).SubItems.AddRange(otherItems)
        Next
        cn.Close()
    End Sub
End Class