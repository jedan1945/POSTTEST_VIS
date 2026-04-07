Public Class Form1
    Private Function ValidasiInput() As Boolean

        ErrorProvider1.Clear()
        Dim valid As Boolean = True

        If txtNama.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtNama, "Nama tidak boleh kosong")
            valid = False
        End If

        For Each c As Char In txtNama.Text
            If Not Char.IsLetter(c) And Not Char.IsWhiteSpace(c) Then
                ErrorProvider1.SetError(txtNama, "Nama hanya huruf")
                valid = False
                Exit For
            End If
        Next

        If txtID.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtID, "ID tidak boleh kosong")
            valid = False
        End If

        If Not IsNumeric(txtID.Text) Then
            ErrorProvider1.SetError(txtID, "ID harus angka")
            valid = False
        End If

        If Not mtbHP.MaskFull Then
            ErrorProvider1.SetError(mtbHP, "Nomor HP harus lengkap")
            valid = False
        End If

        If Not rbLaki.Checked And Not rbPerempuan.Checked Then
            MessageBox.Show("Pilih jenis kelamin")
            valid = False
        End If

        If cmbKomunitas.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cmbKomunitas, "Pilih komunitas")
            valid = False
        End If

        If Not (cb1.Checked Or cb2.Checked Or cb3.Checked Or cb4.Checked Or cb5.Checked Or cb6.Checked Or cb7.Checked Or cb8.Checked) Then
            MessageBox.Show("Pilih minimal 1 aktivitas")
            valid = False
        End If

        Return valid
    End Function
    Function AmbilHobby() As String
        Dim h As String = ""

        If cb1.Checked Then h &= "Gaming, "
        If cb2.Checked Then h &= "Coding, "
        If cb3.Checked Then h &= "Design, "
        If cb4.Checked Then h &= "Editing, "
        If cb5.Checked Then h &= "Musik, "
        If cb6.Checked Then h &= "Olahraga, "
        If cb7.Checked Then h &= "Membaca, "
        If cb8.Checked Then h &= "Traveling, "

        Return h.TrimEnd(","c)
    End Function

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png"
        OpenFileDialog1.Title = "Pilih Foto"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click

        If Not ValidasiInput() Then Exit Sub

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Cetak kartu?", "Konfirmasi", MessageBoxButtons.YesNo)

        If hasil = DialogResult.Yes Then
            Form2.lblNama.Text = txtNama.Text
            Form2.lblID.Text = txtID.Text
            Form2.lblKomunitas.Text = cmbKomunitas.Text
            Form2.lblKontak.Text = mtbHP.Text
            Form2.lblHobby.Text = AmbilHobby()
            Form2.picKartu.Image = picFoto.Image
            Form2.Show()
        Else
            MessageBox.Show("Dibatalkan")
        End If

    End Sub
    Private Sub menuLihat_Click(sender As Object, e As EventArgs) Handles menuLihat.Click
        If txtNama.Text = "" Then
            MessageBox.Show("Isi data dulu!")
            Exit Sub
        End If

        Form2.Show()
    End Sub
    Private Sub menuKeluar_Click(sender As Object, e As EventArgs) Handles menuKeluar.Click

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Yakin keluar?", "Konfirmasi", MessageBoxButtons.YesNo)

        If hasil = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub
    Private Sub menuSimpan_Click(sender As Object, e As EventArgs) Handles menuSimpan.Click

        If Not ValidasiInput() Then Exit Sub

        SaveFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
        SaveFileDialog1.Title = "Simpan Data"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            Dim data As String =
                txtNama.Text & "|" &
                txtID.Text & "|" &
                cmbKomunitas.Text & "|" &
                mtbHP.Text & "|" &
                txtEmail.Text & "|" &
                txtAlamat.Text & "|" &
                AmbilHobby()

            IO.File.WriteAllText(SaveFileDialog1.FileName, data)

            MessageBox.Show("Data berhasil disimpan")
        End If

    End Sub
    Private Sub menuBuka_Click(sender As Object, e As EventArgs) Handles menuBuka.Click

        OpenFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
        OpenFileDialog1.Title = "Pilih File"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Dim data As String = IO.File.ReadAllText(OpenFileDialog1.FileName)
                Dim arr() As String = data.Split("|")

                txtNama.Text = arr(0)
                txtID.Text = arr(1)
                cmbKomunitas.Text = arr(2)
                mtbHP.Text = arr(3)
                txtEmail.Text = arr(4)
                txtAlamat.Text = arr(5)

            Catch
                MessageBox.Show("File tidak valid")
            End Try
        End If

    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSimpanCetak_MouseEnter(sender As Object, e As EventArgs) Handles btnSimpanCetak.MouseEnter
        btnSimpanCetak.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnSimpanCetak_MouseLeave(sender As Object, e As EventArgs) Handles btnSimpanCetak.MouseLeave
        btnSimpanCetak.BackColor = Color.DodgerBlue
    End Sub

    Private Sub panelHeader_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class