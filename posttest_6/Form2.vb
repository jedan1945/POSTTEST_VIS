Public Class Form2
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            If txtKodeTambah.Text = "" Or txtNamaTambah.Text = "" Then
                MessageBox.Show("Data tidak boleh kosong!")
                Exit Sub
            End If

            InsertGundam(txtKodeTambah.Text,
                         txtNamaTambah.Text,
                         cmbGradeTambah.SelectedValue.ToString(),
                         CInt(txtHargaTambah.Text))

            MessageBox.Show("Data berhasil ditambah")
            TampilData()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If UpdateGundam(txtKodeUpdate.Text,
                            txtNamaUpdate.Text,
                            cmbGradeUpdate.SelectedValue.ToString(),
                            CInt(txtHargaUpdate.Text)) Then
                MessageBox.Show("Data berhasil diupdate")
                TampilData()
            Else
                MessageBox.Show("Data tidak ditemukan")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Yakin hapus?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If DeleteGundam(txtKodeHapus.Text) Then
                    MessageBox.Show("Data berhasil dihapus")
                    TampilData()
                Else
                    MessageBox.Show("Data tidak ditemukan")
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Sub TampilData()
        dgvGundam.DataSource = GetAllGundam()
    End Sub
    Sub SetupButtonEffect(btn As Button, normalColor As Color, hoverColor As Color, clickColor As Color)
        btn.BackColor = normalColor
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.ForeColor = Color.White

        AddHandler btn.MouseEnter, Sub(sender, e)
                                       btn.BackColor = hoverColor
                                   End Sub

        AddHandler btn.MouseLeave, Sub(sender, e)
                                       btn.BackColor = normalColor
                                   End Sub
        AddHandler btn.MouseDown, Sub(sender, e)
                                      btn.BackColor = clickColor
                                  End Sub

        AddHandler btn.MouseUp, Sub(sender, e)
                                    btn.BackColor = hoverColor
                                End Sub
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()

        Dim dtKategori As DataTable = GetAllKategori()

        cmbGradeTambah.DataSource = dtKategori
        cmbGradeTambah.DisplayMember = "namaKategori"
        cmbGradeTambah.ValueMember = "kodeKategori"

        cmbGradeUpdate.DataSource = dtKategori.Copy()
        cmbGradeUpdate.DisplayMember = "namaKategori"
        cmbGradeUpdate.ValueMember = "kodeKategori"

        SetupButtonEffect(btnTambah,
                      Color.FromArgb(0, 191, 255),
                      Color.FromArgb(0, 220, 255),
                      Color.FromArgb(0, 150, 200))

        SetupButtonEffect(btnUpdate,
                      Color.FromArgb(255, 215, 0),
                      Color.FromArgb(255, 235, 100),
                      Color.FromArgb(200, 180, 0))

        SetupButtonEffect(btnDelete,
                      Color.FromArgb(255, 76, 76),
                      Color.FromArgb(255, 120, 120),
                      Color.FromArgb(200, 50, 50))
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtSearch.Text = "" Then
                TampilData()
            Else
                dgvGundam.DataSource = SearchGundam(txtSearch.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvGundam_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGundam.CellContentClick

    End Sub
End Class