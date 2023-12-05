Imports MySql.Data.MySqlClient
Imports MySqlConnector
Public Class Form1
    Dim cn As New MySqlConnection
    Dim ds As New DataSet
    Dim da As New MySqlDataAdapter
    Dim cmd As New MySqlCommand
    Dim tabel As New DataTable
    Dim rd As MySqlDataReader
    Private Sub koneksinya()
        cn.ConnectionString = "server=Localhost;user=root;password=;database=tugasakhircafe;allow user variables=true"
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksinya()
    End Sub
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim SQL As String
        Dim datlog As String
        Dim username, pw As String
        SQL = "SELECT * FROM user Where username=""" + TextBoxID.Text.ToString + """ And pasword=""" + TextBoxPW.Text.ToString + """ ;" '''dapetin data dari input bocx pw sma iusername nya
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = SQL
        rd = cmd.ExecuteReader
        If rd.Read Then
            MsgBox("Berhasil")
            Me.Hide()
            Form2.Show()
        Else
            MsgBox("Gagal")
        End If
            rd.Close()
        cn.Close()
    End Sub

End Class
