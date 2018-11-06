Public Class Form1
    Dim tampung As String
    Dim totalsub1 As Integer
    Dim jmldewasa As Integer
    Dim jmlbayi As Integer
    Dim subharga As Integer
    Dim totalharga As Integer
    Dim totaltotal As Integer
    Dim tgl1 As DateTime
    Dim tgl2 As DateTime
    Dim bagg1 As Integer = 0
    Dim bagg2 As Integer = 0
    Dim bagg3 As Integer = 0
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtnama.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles bag1.CheckedChanged
        If (bagg1 = 0) Then
            totaltotal = totalharga + 325000
            total.Text = totaltotal.ToString
            bagg1 = 1
        Else
            totaltotal = totaltotal - 325000
            total.Text = totaltotal.ToString
            bagg1 = 0
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxpenerbangan.SelectedIndexChanged
        txtharga.Text = ""
        Bisnis.Checked = False
        Ekonomi.Checked = False
        txtharga.Text = ""
        If cbxpenerbangan.Text = "Jakarta (CGK) - Denpasar (DPS)" Then
            labelubah.Text = "No. KTP"
        ElseIf cbxpenerbangan.Text = "Denpasar (DPS) - Jakarta (CGK)" Then
            labelubah.Text = "No. KTP"
        ElseIf cbxpenerbangan.Text = "Jakarta (CGK) - Surabaya (SBY)" Then
            labelubah.Text = "No. KTP"
        ElseIf cbxpenerbangan.Text = "Surabaya (SBY) - Jakarta (CGK)" Then
            labelubah.Text = "No. KTP"
        ElseIf cbxpenerbangan.Text = "Bandung (BDG) - Surabaya (SBY)" Then
            labelubah.Text = "No. KTP"
        ElseIf cbxpenerbangan.Text = "Surabaya (SBY) - Bandung (BDG)" Then
            labelubah.Text = "No. KTP"
        ElseIf cbxpenerbangan.Text = "Bandung (BDG) - Denpasar (DPS)" Then
            labelubah.Text = "No. KTP"
        ElseIf cbxpenerbangan.Text = "Denpasar (DPS) – Bandung (BDG)" Then
            labelubah.Text = "No. KTP"
        Else
            labelubah.Text = "No. Pasport"
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Bisnis.CheckedChanged
        txtharga.Text = ""
        If cbxpenerbangan.Text = "Jakarta (CGK) - Denpasar (DPS)" Then
            txtharga.Text = "1950000"
        End If
        If cbxpenerbangan.Text = "Denpasar (DPS) - Jakarta (CGK)" Then
            txtharga.Text = "1850000"
        End If
        If cbxpenerbangan.Text = "Jakarta (CGK) - Surabaya (SBY)" Then
            txtharga.Text = "1750000"
        End If
        If cbxpenerbangan.Text = "Surabaya (SBY) - Jakarta (CGK)" Then
            txtharga.Text = "1725000"
        End If
        If cbxpenerbangan.Text = "Bandung (BDG) - Surabaya (SBY)" Then
            txtharga.Text = "1950000"
        End If
        If cbxpenerbangan.Text = "Surabaya (SBY) - Bandung (BDG)" Then
            txtharga.Text = "1925000"
        End If
        If cbxpenerbangan.Text = "Bandung (BDG) - Denpasar (DPS)" Then
            txtharga.Text = "2250000"
        End If
        If cbxpenerbangan.Text = "Denpasar (DPS) – Bandung (BDG)" Then
            txtharga.Text = "2750000"
        End If
        If cbxpenerbangan.Text = "Jakarta (CGK) - Singapur (SNG)" Then
            txtharga.Text = "2500000"
        End If
        If cbxpenerbangan.Text = "Singapur (SNG) - Jakarta (CGK)" Then
            txtharga.Text = "2525000"
        End If
        If cbxpenerbangan.Text = "Jakarta (CGK) - Kuala Lumpur (KLI)" Then
            txtharga.Text = "2600000"
        End If
        If cbxpenerbangan.Text = "Kuala Lumpur (KLI) - Jakarta (CGK)" Then
            txtharga.Text = "2625000"
        End If
        If cbxpenerbangan.Text = "Jakarta (CGK) - Bangkok (BGK)" Then
            txtharga.Text = "2700000"
        End If
        If cbxpenerbangan.Text = "Bangkok (BGK) - Jakarta (CGK)" Then
            txtharga.Text = "2725000"
        End If
        If cbxpenerbangan.Text = "Bandung (BDG) - Kuala Lumpur (KLI)" Then
            txtharga.Text = "2900000"
        End If
        If cbxpenerbangan.Text = "Kuala Lumpur (KLI) - Bandung (BDG)" Then
            txtharga.Text = "2925000"
        End If
        If cbxpenerbangan.Text = "Bandung (BDG) - Singapur (SNG)" Then
            txtharga.Text = "2800000"
        End If
        If cbxpenerbangan.Text = "Singapur (SNG) - Bandung (BDG)" Then
            txtharga.Text = "2825000"
        End If
        If cbxpenerbangan.Text = "Bandung (BDG) - Bangkok (BGK)" Then
            txtharga.Text = "3000000"
        End If
        If cbxpenerbangan.Text = "Bangkok (BGK) - Bandung (BDG)" Then
            txtharga.Text = "3525000"
        End If
        If cbxpenerbangan.Text = "Surabaya (SBY) - Singapur (SNG)" Then
            txtharga.Text = "2900000"
        End If
        If cbxpenerbangan.Text = "Singapur (SNG) - Surabaya (SBY)" Then
            txtharga.Text = "2825000"
        End If
        If cbxpenerbangan.Text = "Surabaya (SBY) - Kuala Lumpur (KLI)" Then
            txtharga.Text = "2625000"
        End If
        If cbxpenerbangan.Text = "Kuala Lumpur (KLI) - Surabaya (SBY)" Then
            txtharga.Text = "2700000"
        End If
        If cbxpenerbangan.Text = "Surabaya (SBY) - Bangkok (BGK)" Then
            txtharga.Text = "2725000"
        End If
        If cbxpenerbangan.Text = "Bangkok (BGK) - Surabaya (SBY)" Then
            txtharga.Text = "2800000"
        End If
        If cbxpenerbangan.Text = "Denpasar (DPS) - Singapur (SNG)" Then
            txtharga.Text = "2825000"
        End If
        If cbxpenerbangan.Text = "Singapur (SNG) - Denpasar (DPS)" Then
            txtharga.Text = "2900000"
        End If
        If cbxpenerbangan.Text = "Denpasar (DPS) - Kuala Lumpur (KLI)" Then
            txtharga.Text = "2925000"
        End If
        If cbxpenerbangan.Text = "Kuala Lumpur (KLI) - Denpasar (DPS)" Then
            txtharga.Text = "2625000"
        End If
        If cbxpenerbangan.Text = "Denpasar (DPS) - Bangkok (BGK)" Then
            txtharga.Text = "2700000"
        End If
        If cbxpenerbangan.Text = "Bangkok (BGK) - Denpasar (DPS)" Then
            txtharga.Text = "2725000"
        End If

    End Sub

    Private Sub Ekonomi_CheckedChanged(sender As Object, e As EventArgs) Handles Ekonomi.CheckedChanged
        txtharga.Text = ""
        If cbxpenerbangan.Text = "Jakarta (CGK) - Denpasar (DPS)" Then
            txtharga.Text = "1025000"
        End If
        If cbxpenerbangan.Text = "Denpasar (DPS) - Jakarta (CGK)" Then
            txtharga.Text = "975000"
        End If
        If cbxpenerbangan.Text = "Jakarta (CGK) - Surabaya (SBY)" Then
            txtharga.Text = "875000"
        End If
        If cbxpenerbangan.Text = "Surabaya (SBY) - Jakarta (CGK)" Then
            txtharga.Text = "825000"
        End If
        If cbxpenerbangan.Text = "Bandung (BDG) - Surabaya (SBY)" Then
            txtharga.Text = "1125000"
        End If
        If cbxpenerbangan.Text = "Surabaya (SBY) - Bandung (BDG)" Then
            txtharga.Text = "1075000"
        End If
        If cbxpenerbangan.Text = "Bandung (BDG) - Denpasar (DPS)" Then
            txtharga.Text = "1525000"
        End If
        If cbxpenerbangan.Text = "Denpasar (DPS) – Bandung (BDG)" Then
            txtharga.Text = "1750000"
        End If
        If cbxpenerbangan.Text = "Jakarta (CGK) - Singapur (SNG)" Then
            txtharga.Text = "1500000"
        End If
        If cbxpenerbangan.Text = "Singapur (SNG) - Jakarta (CGK)" Then
            txtharga.Text = "1525000"
        End If
        If cbxpenerbangan.Text = "Jakarta (CGK) - Kuala Lumpur (KLI)" Then
            txtharga.Text = "1600000"
        End If
        If cbxpenerbangan.Text = "Kuala Lumpur (KLI) - Jakarta (CGK)" Then
            txtharga.Text = "1625000"
        End If
        If cbxpenerbangan.Text = "Jakarta (CGK) - Bangkok (BGK)" Then
            txtharga.Text = "1700000"
        End If
        If cbxpenerbangan.Text = "Bangkok (BGK) - Jakarta (CGK)" Then
            txtharga.Text = "1725000"
        End If
        If cbxpenerbangan.Text = "Bandung (BDG) - Kuala Lumpur (KLI)" Then
            txtharga.Text = "1900000"
        End If
        If cbxpenerbangan.Text = "Kuala Lumpur (KLI) - Bandung (BDG)" Then
            txtharga.Text = "1925000"
        End If
        If cbxpenerbangan.Text = "Bandung (BDG) - Singapur (SNG)" Then
            txtharga.Text = "1800000"
        End If
        If cbxpenerbangan.Text = "Singapur (SNG) - Bandung (BDG)" Then
            txtharga.Text = "1825000"
        End If
        If cbxpenerbangan.Text = "Bandung (BDG) - Bangkok (BGK)" Then
            txtharga.Text = "2500000"
        End If
        If cbxpenerbangan.Text = "Bangkok (BGK) - Bandung (BDG)" Then
            txtharga.Text = "2525000"
        End If
        If cbxpenerbangan.Text = "Surabaya (SBY) - Singapur (SNG)" Then
            txtharga.Text = "2500000"
        End If
        If cbxpenerbangan.Text = "Singapur (SNG) - Surabaya (SBY)" Then
            txtharga.Text = "2525000"
        End If
        If cbxpenerbangan.Text = "Surabaya (SBY) - Kuala Lumpur (KLI)" Then
            txtharga.Text = "1625000"
        End If
        If cbxpenerbangan.Text = "Kuala Lumpur (KLI) - Surabaya (SBY)" Then
            txtharga.Text = "1700000"
        End If
        If cbxpenerbangan.Text = "Surabaya (SBY) - Bangkok (BGK)" Then
            txtharga.Text = "1725000"
        End If
        If cbxpenerbangan.Text = "Bangkok (BGK) - Surabaya (SBY)" Then
            txtharga.Text = "1800000"
        End If
        If cbxpenerbangan.Text = "Denpasar (DPS) - Singapur (SNG)" Then
            txtharga.Text = "1825000"
        End If
        If cbxpenerbangan.Text = "Singapur (SNG) - Denpasar (DPS)" Then
            txtharga.Text = "1900000"
        End If
        If cbxpenerbangan.Text = "Denpasar (DPS) - Kuala Lumpur (KLI)" Then
            txtharga.Text = "1925000"
        End If
        If cbxpenerbangan.Text = "Kuala Lumpur (KLI) - Denpasar (DPS)" Then
            txtharga.Text = "1625000"
        End If
        If cbxpenerbangan.Text = "Denpasar (DPS) - Bangkok (BGK)" Then
            txtharga.Text = "1700000"
        End If
        If cbxpenerbangan.Text = "Bangkok (BGK) - Denpasar (DPS)" Then
            txtharga.Text = "1725000"
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub TextBox5_TextChange(sender As Object, e As EventArgs) Handles txtdewasa.TextChanged
        If String.IsNullOrEmpty(txtbayi.Text) Then
            jmlbayi = 0
        Else
            jmlbayi = Val(txtbayi.Text)
        End If

        If String.IsNullOrEmpty(txtdewasa.Text) Then
            jmldewasa = 0
        Else
            jmldewasa = txtdewasa.Text
        End If

        jmlbayi = Val(jmlbayi) * Val(txtharga.Text) * 0.15
        jmldewasa = jmldewasa * Val(txtharga.Text)
        subharga = jmlbayi + jmldewasa
        totalharga = subharga
        totaltotal = totalharga
        subtotal.Text = subharga.ToString
    End Sub

    Private Sub txtbayi_TextChange(sender As Object, e As EventArgs) Handles txtbayi.TextChanged
        If String.IsNullOrEmpty(txtbayi.Text) Then
            jmlbayi = 0
        Else
            jmlbayi = Val(txtbayi.Text)
        End If

        If String.IsNullOrEmpty(txtdewasa.Text) Then
            jmldewasa = 0
        Else
            jmldewasa = txtdewasa.Text
        End If

        jmlbayi = Val(jmlbayi) * Val(txtharga.Text) * 0.15
        jmldewasa = jmldewasa * Val(txtharga.Text)
        subharga = jmlbayi + jmldewasa
        totalharga = subharga
        totaltotal = totalharga

        subtotal.Text = subharga.ToString
    End Sub

    Private Sub TextBox4_OnChange(sender As Object, e As EventArgs) Handles subtotal.TextChanged
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles bag2.CheckedChanged
        If (bagg2 = 0) Then
            totaltotal = totaltotal + 625000
            total.Text = totaltotal.ToString
            bagg2 = 1
        Else
            totaltotal = totaltotal - 625000
            total.Text = totaltotal.ToString
            bagg2 = 0
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles bag3.CheckedChanged
        If (bagg3 = 0) Then
            totaltotal = totaltotal + 925000
            total.Text = totaltotal.ToString
            bagg3 = 1
        Else
            totaltotal = totaltotal - 925000
            total.Text = totaltotal.ToString
            bagg3 = 0
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles tanggalberangkat.ValueChanged
        tgl1 = tanggalberangkat.Value.Date
    End Sub

    Private Sub tanggalpulang_ValueChanged(sender As Object, e As EventArgs) Handles tanggalpulang.ValueChanged
        tgl2 = tanggalpulang.Value.Date
        If (tgl2 < tgl1) Then
            tanggalberangkat.Value = DateTime.Now
            tanggalpulang.Value = DateTime.Now
            MessageBox.Show("Tanggal pulang lebih dari tanggal berangkat!! Masukan tanggal dengan benar", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cbxpenerbangan.Text = ""
        Bisnis.Checked = False
        Ekonomi.Checked = False
        txtharga.Text = ""
        tanggalberangkat.Value = DateTime.Now
        tanggalpulang.Value = DateTime.Now
        txtbayi.Text = ""
        txtdewasa.Text = ""
        subtotal.Text = ""
        total.Text = ""
        txtnama.Text = ""
        txtidentitas.Text = ""
        bag1.Checked = False
        bag2.Checked = False
        bag3.Checked = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
