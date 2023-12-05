Public Class Form2
    Private Sub ButtonReport_Click(sender As Object, e As EventArgs) Handles ButtonReport.Click
        switchpanel(Report)
        'Report.Show()
    End Sub

    Private Sub ButtonTransaksi_Click(sender As Object, e As EventArgs) Handles ButtonTransaksi.Click
        switchpanel(Transaksi)
        'Transaksi.Show()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        switchpanel(Add)
        'Add.Show()
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        switchpanel(Modip)
        'Modip.Show()
    End Sub

    Private Sub ButtonStock_Click(sender As Object, e As EventArgs) Handles ButtonStock.Click
        switchpanel(Stock)
        'Stock.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub
    Sub switchpanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchpanel(Ingfo)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        switchpanel(Ingfo)
    End Sub
End Class