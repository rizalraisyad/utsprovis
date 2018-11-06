<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cbxpenerbangan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Bisnis = New System.Windows.Forms.RadioButton()
        Me.Ekonomi = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtidentitas = New System.Windows.Forms.TextBox()
        Me.labelubah = New System.Windows.Forms.Label()
        Me.subtotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tanggalberangkat = New System.Windows.Forms.DateTimePicker()
        Me.tanggalpulang = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bag3 = New System.Windows.Forms.CheckBox()
        Me.bag2 = New System.Windows.Forms.CheckBox()
        Me.bag1 = New System.Windows.Forms.CheckBox()
        Me.txtdewasa = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbayi = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxpenerbangan
        '
        Me.cbxpenerbangan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxpenerbangan.FormattingEnabled = True
        Me.cbxpenerbangan.Items.AddRange(New Object() {"Jakarta (CGK) - Denpasar (DPS)", "Denpasar (DPS) - Jakarta (CGK)", "Jakarta (CGK) - Surabaya (SBY)", "Surabaya (SBY) - Jakarta (CGK)", "Bandung (BDG) - Surabaya (SBY)", "Surabaya (SBY) - Bandung (BDG)", "Bandung (BDG) - Denpasar (DPS)", "Denpasar (DPS) – Bandung (BDG)", "Jakarta (CGK) - Singapur (SNG)", "Singapur (SNG) - Jakarta (CGK)", "Jakarta (CGK) - Kuala Lumpur (KLI)", "Kuala Lumpur (KLI) - Jakarta (CGK)", "Jakarta (CGK) - Bangkok (BGK)", "Bangkok (BGK) - Jakarta (CGK)", "Bandung (BDG) - Singapur (SNG)", "Singapur (SNG) - Bandung (BDG)", "Bandung (BDG) - Kuala Lumpur (KLI)", "Kuala Lumpur (KLI) - Bandung (BDG)", "Bandung (BDG) - Bangkok (BGK)", "Bangkok (BGK) - Bandung (BDG)", "Surabaya (SBY) - Singapur (SNG)", "Singapur (SNG) - Surabaya (SBY)", "Surabaya (SBY) - Kuala Lumpur (KLI)", "Kuala Lumpur (KLI) - Surabaya (SBY)", "Surabaya (SBY) - Bangkok (BGK)", "Bangkok (BGK) - Surabaya (SBY)", "Denpasar (DPS) - Singapur (SNG)", "Singapur (SNG) - Denpasar (DPS)", "Denpasar (DPS) - Kuala Lumpur (KLI)", "Kuala Lumpur (KLI) - Denpasar (DPS)", "Denpasar (DPS) - Bangkok (BGK)", "Bangkok (BGK) - Denpasar (DPS)"})
        Me.cbxpenerbangan.Location = New System.Drawing.Point(111, 23)
        Me.cbxpenerbangan.Name = "cbxpenerbangan"
        Me.cbxpenerbangan.Size = New System.Drawing.Size(200, 21)
        Me.cbxpenerbangan.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pilih Penerbangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kelas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Harga"
        '
        'Bisnis
        '
        Me.Bisnis.AutoSize = True
        Me.Bisnis.Location = New System.Drawing.Point(112, 52)
        Me.Bisnis.Name = "Bisnis"
        Me.Bisnis.Size = New System.Drawing.Size(52, 17)
        Me.Bisnis.TabIndex = 4
        Me.Bisnis.TabStop = True
        Me.Bisnis.Text = "Bisnis"
        Me.Bisnis.UseVisualStyleBackColor = True
        '
        'Ekonomi
        '
        Me.Ekonomi.AutoSize = True
        Me.Ekonomi.Location = New System.Drawing.Point(201, 52)
        Me.Ekonomi.Name = "Ekonomi"
        Me.Ekonomi.Size = New System.Drawing.Size(66, 17)
        Me.Ekonomi.TabIndex = 5
        Me.Ekonomi.TabStop = True
        Me.Ekonomi.Text = "Ekonomi"
        Me.Ekonomi.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "tgl berangkat"
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(111, 78)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.ReadOnly = True
        Me.txtharga.Size = New System.Drawing.Size(200, 20)
        Me.txtharga.TabIndex = 7
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(111, 104)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(200, 20)
        Me.txtnama.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nama"
        '
        'txtidentitas
        '
        Me.txtidentitas.Location = New System.Drawing.Point(111, 130)
        Me.txtidentitas.Name = "txtidentitas"
        Me.txtidentitas.Size = New System.Drawing.Size(200, 20)
        Me.txtidentitas.TabIndex = 11
        '
        'labelubah
        '
        Me.labelubah.AutoSize = True
        Me.labelubah.Location = New System.Drawing.Point(12, 133)
        Me.labelubah.Name = "labelubah"
        Me.labelubah.Size = New System.Drawing.Size(48, 13)
        Me.labelubah.TabIndex = 10
        Me.labelubah.Text = "No. KTP"
        '
        'subtotal
        '
        Me.subtotal.Location = New System.Drawing.Point(111, 214)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        Me.subtotal.Size = New System.Drawing.Size(200, 20)
        Me.subtotal.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Sub. Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "tgl kembali"
        '
        'tanggalberangkat
        '
        Me.tanggalberangkat.Location = New System.Drawing.Point(111, 159)
        Me.tanggalberangkat.Name = "tanggalberangkat"
        Me.tanggalberangkat.Size = New System.Drawing.Size(200, 20)
        Me.tanggalberangkat.TabIndex = 15
        '
        'tanggalpulang
        '
        Me.tanggalpulang.Location = New System.Drawing.Point(111, 188)
        Me.tanggalpulang.Name = "tanggalpulang"
        Me.tanggalpulang.Size = New System.Drawing.Size(200, 20)
        Me.tanggalpulang.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bag3)
        Me.GroupBox1.Controls.Add(Me.bag2)
        Me.GroupBox1.Controls.Add(Me.bag1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 240)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 35)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bagasi"
        '
        'bag3
        '
        Me.bag3.AutoSize = True
        Me.bag3.Location = New System.Drawing.Point(329, 12)
        Me.bag3.Name = "bag3"
        Me.bag3.Size = New System.Drawing.Size(68, 17)
        Me.bag3.TabIndex = 2
        Me.bag3.Text = "31-50 kg"
        Me.bag3.UseVisualStyleBackColor = True
        '
        'bag2
        '
        Me.bag2.AutoSize = True
        Me.bag2.Location = New System.Drawing.Point(147, 12)
        Me.bag2.Name = "bag2"
        Me.bag2.Size = New System.Drawing.Size(68, 17)
        Me.bag2.TabIndex = 1
        Me.bag2.Text = "16-30 kg"
        Me.bag2.UseVisualStyleBackColor = True
        '
        'bag1
        '
        Me.bag1.AutoSize = True
        Me.bag1.Location = New System.Drawing.Point(6, 12)
        Me.bag1.Name = "bag1"
        Me.bag1.Size = New System.Drawing.Size(62, 17)
        Me.bag1.TabIndex = 0
        Me.bag1.Text = "0-15 kg"
        Me.bag1.UseVisualStyleBackColor = True
        '
        'txtdewasa
        '
        Me.txtdewasa.Location = New System.Drawing.Point(415, 162)
        Me.txtdewasa.Name = "txtdewasa"
        Me.txtdewasa.Size = New System.Drawing.Size(68, 20)
        Me.txtdewasa.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(351, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Dewasa"
        '
        'txtbayi
        '
        Me.txtbayi.Location = New System.Drawing.Point(415, 194)
        Me.txtbayi.Name = "txtbayi"
        Me.txtbayi.Size = New System.Drawing.Size(68, 20)
        Me.txtbayi.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(351, 198)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Bayi"
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(111, 300)
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Size = New System.Drawing.Size(200, 20)
        Me.total.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 307)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Total (Rp.)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(341, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(422, 302)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(504, 339)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtbayi)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtdewasa)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tanggalpulang)
        Me.Controls.Add(Me.tanggalberangkat)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.subtotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtidentitas)
        Me.Controls.Add(Me.labelubah)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Ekonomi)
        Me.Controls.Add(Me.Bisnis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxpenerbangan)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "Burung bangau anti jatuh"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxpenerbangan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Bisnis As RadioButton
    Friend WithEvents Ekonomi As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtidentitas As TextBox
    Friend WithEvents labelubah As Label
    Friend WithEvents subtotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tanggalberangkat As DateTimePicker
    Friend WithEvents tanggalpulang As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bag1 As CheckBox
    Friend WithEvents bag3 As CheckBox
    Friend WithEvents bag2 As CheckBox
    Friend WithEvents txtdewasa As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbayi As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents total As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
