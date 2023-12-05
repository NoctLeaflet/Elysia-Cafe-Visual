<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBoxJeniscari = New System.Windows.Forms.ComboBox()
        Me.TextBoxtolhar = New System.Windows.Forms.TextBox()
        Me.TextBoxJumBel = New System.Windows.Forms.TextBox()
        Me.TextBoxHargaCari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxNamaCari = New System.Windows.Forms.TextBox()
        Me.ListBoxProducFind = New System.Windows.Forms.ListBox()
        Me.ButtonPesan = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxSisa = New System.Windows.Forms.TextBox()
        Me.TextBoxPembe = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxKasir = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'ComboBoxJeniscari
        '
        Me.ComboBoxJeniscari.FormattingEnabled = True
        Me.ComboBoxJeniscari.ItemHeight = 13
        Me.ComboBoxJeniscari.Items.AddRange(New Object() {"Makanan", "Minuman"})
        Me.ComboBoxJeniscari.Location = New System.Drawing.Point(54, 73)
        Me.ComboBoxJeniscari.Name = "ComboBoxJeniscari"
        Me.ComboBoxJeniscari.Size = New System.Drawing.Size(78, 21)
        Me.ComboBoxJeniscari.TabIndex = 0
        '
        'TextBoxtolhar
        '
        Me.TextBoxtolhar.Location = New System.Drawing.Point(54, 189)
        Me.TextBoxtolhar.Name = "TextBoxtolhar"
        Me.TextBoxtolhar.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxtolhar.TabIndex = 1
        '
        'TextBoxJumBel
        '
        Me.TextBoxJumBel.Location = New System.Drawing.Point(54, 154)
        Me.TextBoxJumBel.Name = "TextBoxJumBel"
        Me.TextBoxJumBel.Size = New System.Drawing.Size(78, 20)
        Me.TextBoxJumBel.TabIndex = 2
        '
        'TextBoxHargaCari
        '
        Me.TextBoxHargaCari.Location = New System.Drawing.Point(54, 115)
        Me.TextBoxHargaCari.Name = "TextBoxHargaCari"
        Me.TextBoxHargaCari.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHargaCari.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cari"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Harga Satuan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Jumlah Beli"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total harga"
        '
        'TextBoxNamaCari
        '
        Me.TextBoxNamaCari.Location = New System.Drawing.Point(138, 74)
        Me.TextBoxNamaCari.Name = "TextBoxNamaCari"
        Me.TextBoxNamaCari.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxNamaCari.TabIndex = 8
        '
        'ListBoxProducFind
        '
        Me.ListBoxProducFind.FormattingEnabled = True
        Me.ListBoxProducFind.Location = New System.Drawing.Point(54, 257)
        Me.ListBoxProducFind.Name = "ListBoxProducFind"
        Me.ListBoxProducFind.Size = New System.Drawing.Size(305, 134)
        Me.ListBoxProducFind.TabIndex = 9
        '
        'ButtonPesan
        '
        Me.ButtonPesan.Location = New System.Drawing.Point(202, 228)
        Me.ButtonPesan.Name = "ButtonPesan"
        Me.ButtonPesan.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPesan.TabIndex = 10
        Me.ButtonPesan.Text = "Pesan"
        Me.ButtonPesan.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Sisa Stock"
        '
        'TextBoxSisa
        '
        Me.TextBoxSisa.Location = New System.Drawing.Point(54, 228)
        Me.TextBoxSisa.Name = "TextBoxSisa"
        Me.TextBoxSisa.Size = New System.Drawing.Size(68, 20)
        Me.TextBoxSisa.TabIndex = 12
        '
        'TextBoxPembe
        '
        Me.TextBoxPembe.Location = New System.Drawing.Point(173, 115)
        Me.TextBoxPembe.Name = "TextBoxPembe"
        Me.TextBoxPembe.Size = New System.Drawing.Size(104, 20)
        Me.TextBoxPembe.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(170, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Pembeli"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(170, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Kasir"
        '
        'TextBoxKasir
        '
        Me.TextBoxKasir.Location = New System.Drawing.Point(173, 193)
        Me.TextBoxKasir.Name = "TextBoxKasir"
        Me.TextBoxKasir.Size = New System.Drawing.Size(104, 20)
        Me.TextBoxKasir.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.TugasAkhirCafe.My.Resources.Resources.elys1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(301, -26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 752)
        Me.Panel1.TabIndex = 1
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(1087, 725)
        Me.Controls.Add(Me.ButtonPesan)
        Me.Controls.Add(Me.TextBoxKasir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBoxJeniscari)
        Me.Controls.Add(Me.ListBoxProducFind)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxtolhar)
        Me.Controls.Add(Me.TextBoxNamaCari)
        Me.Controls.Add(Me.TextBoxPembe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxJumBel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxSisa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxHargaCari)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transaksi"
        Me.Text = "Transaksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBoxJeniscari As ComboBox
    Friend WithEvents TextBoxtolhar As TextBox
    Friend WithEvents TextBoxJumBel As TextBox
    Friend WithEvents TextBoxHargaCari As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxNamaCari As TextBox
    Friend WithEvents ListBoxProducFind As ListBox
    Friend WithEvents ButtonPesan As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxSisa As TextBox
    Friend WithEvents TextBoxPembe As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxKasir As TextBox
End Class
