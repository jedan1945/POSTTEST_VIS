Public Class Form1
    Sub TampilBuku()
        lblJumlah.Text = "Jumlah Buku : " & jumlahBuku
        ListBox1.Items.Clear()

        For i = 0 To jumlahBuku - 1
            ListBox1.Items.Add((i + 1) & "." & daftarJudul(i) & " | Genre : " & daftarGenre(i))
        Next

    End Sub

    Private Sub txtJudul_TextChanged(sender As Object, e As EventArgs) Handles txtJudul.TextChanged

    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        'VALIDASI INPUT (nilai plus)
        If txtJudul.Text = "" Or txtGenre.Text = "" Then
            MessageBox.Show("Judul dan Genre tidak boleh kosong!", "Peringatan")
            Exit Sub
        End If

        TambahBuku(txtJudul.Text, txtGenre.Text)

        txtJudul.Clear()
        txtGenre.Clear()

        TampilBuku()

    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtHapus.Text = "" Then
            MessageBox.Show("Masukkan judul buku yang ingin dihapus!", "Peringatan")
            Exit Sub
        End If
        Dim judul As String = txtHapus.Text

        HapusBuku(judul)

        txtHapus.Clear()

        TampilBuku()

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TambahBuku("si anak pintar", "slice of life")
        TambahBuku("the conjuring of light", "fantasi")

        TampilBuku()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
