<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modip
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
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ListBoxProducModif = New System.Windows.Forms.ListBox()
        Me.TextBoxNamamodip = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxJenisModp = New System.Windows.Forms.ComboBox()
        Me.TextBoxStockModip = New System.Windows.Forms.TextBox()
        Me.TextBoxHargaModip = New System.Windows.Forms.TextBox()
        Me.ButtonModip = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxSisaSTk = New System.Windows.Forms.TextBox()
        Me.TextBoxHargaAs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(112, 192)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 23
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ListBoxProducModif
        '
        Me.ListBoxProducModif.FormattingEnabled = True
        Me.ListBoxProducModif.Location = New System.Drawing.Point(12, 254)
        Me.ListBoxProducModif.Name = "ListBoxProducModif"
        Me.ListBoxProducModif.Size = New System.Drawing.Size(215, 82)
        Me.ListBoxProducModif.TabIndex = 22
        '
        'TextBoxNamamodip
        '
        Me.TextBoxNamamodip.Location = New System.Drawing.Point(112, 44)
        Me.TextBoxNamamodip.Name = "TextBoxNamamodip"
        Me.TextBoxNamamodip.Size = New System.Drawing.Size(169, 20)
        Me.TextBoxNamamodip.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Cari"
        '
        'ComboBoxJenisModp
        '
        Me.ComboBoxJenisModp.FormattingEnabled = True
        Me.ComboBoxJenisModp.ItemHeight = 13
        Me.ComboBoxJenisModp.Items.AddRange(New Object() {"Makanan", "Minuman"})
        Me.ComboBoxJenisModp.Location = New System.Drawing.Point(28, 44)
        Me.ComboBoxJenisModp.Name = "ComboBoxJenisModp"
        Me.ComboBoxJenisModp.Size = New System.Drawing.Size(78, 21)
        Me.ComboBoxJenisModp.TabIndex = 13
        '
        'TextBoxStockModip
        '
        Me.TextBoxStockModip.Location = New System.Drawing.Point(28, 123)
        Me.TextBoxStockModip.Name = "TextBoxStockModip"
        Me.TextBoxStockModip.Size = New System.Drawing.Size(71, 20)
        Me.TextBoxStockModip.TabIndex = 29
        '
        'TextBoxHargaModip
        '
        Me.TextBoxHargaModip.Location = New System.Drawing.Point(28, 83)
        Me.TextBoxHargaModip.Name = "TextBoxHargaModip"
        Me.TextBoxHargaModip.Size = New System.Drawing.Size(109, 20)
        Me.TextBoxHargaModip.TabIndex = 28
        '
        'ButtonModip
        '
        Me.ButtonModip.Location = New System.Drawing.Point(207, 192)
        Me.ButtonModip.Name = "ButtonModip"
        Me.ButtonModip.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModip.TabIndex = 27
        Me.ButtonModip.Text = "Modify"
        Me.ButtonModip.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Stock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Rubah Harga"
        '
        'TextBoxSisaSTk
        '
        Me.TextBoxSisaSTk.Location = New System.Drawing.Point(172, 123)
        Me.TextBoxSisaSTk.Name = "TextBoxSisaSTk"
        Me.TextBoxSisaSTk.Size = New System.Drawing.Size(71, 20)
        Me.TextBoxSisaSTk.TabIndex = 30
        '
        'TextBoxHargaAs
        '
        Me.TextBoxHargaAs.Location = New System.Drawing.Point(172, 83)
        Me.TextBoxHargaAs.Name = "TextBoxHargaAs"
        Me.TextBoxHargaAs.Size = New System.Drawing.Size(109, 20)
        Me.TextBoxHargaAs.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Harga Asli"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(169, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Stock Sekarang"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(14, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 238)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modify Product"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.TugasAkhirCafe.My.Resources.Resources.ell
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(299, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(647, 691)
        Me.Panel1.TabIndex = 35
        '
        'Modip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(952, 611)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxHargaAs)
        Me.Controls.Add(Me.TextBoxSisaSTk)
        Me.Controls.Add(Me.TextBoxStockModip)
        Me.Controls.Add(Me.TextBoxHargaModip)
        Me.Controls.Add(Me.ButtonModip)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ListBoxProducModif)
        Me.Controls.Add(Me.TextBoxNamamodip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxJenisModp)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Modip"
        Me.Text = "Modip"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents ListBoxProducModif As ListBox
    Friend WithEvents TextBoxNamamodip As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxJenisModp As ComboBox
    Friend WithEvents TextBoxStockModip As TextBox
    Friend WithEvents TextBoxHargaModip As TextBox
    Friend WithEvents ButtonModip As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxSisaSTk As TextBox
    Friend WithEvents TextBoxHargaAs As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
End Class
