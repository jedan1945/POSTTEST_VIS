Public Class Form1
    Inherits System.Windows.Forms.Form ' <--- PASTIKAN BARIS INI ADA

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim open As New OpenFileDialog
        open.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If open.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(open.FileName)
        End If
    End Sub
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If txtNama.Text = "" Or txtUmur.Text = "" Or txtNoHP.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        Dim formHasil As New Form2

        formHasil.lblNama.Text = txtNama.Text
        formHasil.lblUmur.Text = txtUmur.Text
        formHasil.lblHP.Text = txtNoHP.Text
        formHasil.lblAlamat.Text = txtAlamat.Text
        formHasil.lblTanggal.Text = dtpTanggalLahir.Value.ToShortDateString()

        If rbLaki.Checked Then
            formHasil.lblGender.Text = "Laki-laki"
        ElseIf rbPerempuan.Checked Then
            formHasil.lblGender.Text = "Perempuan"
        End If
        Dim hobbyDipilih As Boolean = False

        For Each ctrl As Control In grpHobby.Controls
            If TypeOf ctrl Is CheckBox AndAlso CType(ctrl, CheckBox).Checked Then
                hobbyDipilih = True
            End If
        Next

        If hobbyDipilih = False Then
            MessageBox.Show("Pilih minimal satu hobby")
            Exit Sub
        End If
        formHasil.PictureBox1.Image = PictureBox1.Image

        formHasil.Show()

    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtNoHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoHP.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
