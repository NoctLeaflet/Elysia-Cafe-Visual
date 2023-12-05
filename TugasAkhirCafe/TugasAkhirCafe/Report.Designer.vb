<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.ListViewRep = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nama = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.jumlahbeli = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Pembeli = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Kasir = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Waktu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonRef = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListViewRep
        '
        Me.ListViewRep.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Nama, Me.jumlahbeli, Me.total, Me.Pembeli, Me.Kasir, Me.Waktu})
        Me.ListViewRep.HideSelection = False
        Me.ListViewRep.Location = New System.Drawing.Point(12, 12)
        Me.ListViewRep.Name = "ListViewRep"
        Me.ListViewRep.Size = New System.Drawing.Size(810, 358)
        Me.ListViewRep.TabIndex = 0
        Me.ListViewRep.UseCompatibleStateImageBehavior = False
        Me.ListViewRep.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 28
        '
        'Nama
        '
        Me.Nama.Text = "Nama"
        Me.Nama.Width = 160
        '
        'jumlahbeli
        '
        Me.jumlahbeli.Text = "Jumlah Beli"
        Me.jumlahbeli.Width = 90
        '
        'total
        '
        Me.total.Text = "Total Harga"
        Me.total.Width = 130
        '
        'Pembeli
        '
        Me.Pembeli.Text = "Pembeli"
        Me.Pembeli.Width = 140
        '
        'Kasir
        '
        Me.Kasir.Text = "Kasir"
        Me.Kasir.Width = 140
        '
        'Waktu
        '
        Me.Waktu.Text = "Waktu"
        Me.Waktu.Width = 117
        '
        'ButtonRef
        '
        Me.ButtonRef.Location = New System.Drawing.Point(652, 376)
        Me.ButtonRef.Name = "ButtonRef"
        Me.ButtonRef.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRef.TabIndex = 1
        Me.ButtonRef.Text = "Refresh"
        Me.ButtonRef.UseVisualStyleBackColor = True
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(850, 431)
        Me.Controls.Add(Me.ButtonRef)
        Me.Controls.Add(Me.ListViewRep)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Report"
        Me.Text = "Report"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListViewRep As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Nama As ColumnHeader
    Friend WithEvents jumlahbeli As ColumnHeader
    Friend WithEvents total As ColumnHeader
    Friend WithEvents Pembeli As ColumnHeader
    Friend WithEvents Kasir As ColumnHeader
    Friend WithEvents Waktu As ColumnHeader
    Friend WithEvents ButtonRef As Button
End Class
