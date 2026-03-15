<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtUmur = New System.Windows.Forms.TextBox()
        Me.txtNoHP = New System.Windows.Forms.TextBox()
        Me.dtpTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.grpGender = New System.Windows.Forms.GroupBox()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.grpHobby = New System.Windows.Forms.GroupBox()
        Me.cbCooking = New System.Windows.Forms.CheckBox()
        Me.cbDrawwing = New System.Windows.Forms.CheckBox()
        Me.cbMovie = New System.Windows.Forms.CheckBox()
        Me.cbTravel = New System.Windows.Forms.CheckBox()
        Me.cbSport = New System.Windows.Forms.CheckBox()
        Me.cbReading = New System.Windows.Forms.CheckBox()
        Me.cbCoding = New System.Windows.Forms.CheckBox()
        Me.cbMusic = New System.Windows.Forms.CheckBox()
        Me.cbAnime = New System.Windows.Forms.CheckBox()
        Me.cbGame = New System.Windows.Forms.CheckBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblUmur = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.lblYou = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGender.SuspendLayout()
        Me.grpHobby.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(25, 104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 259)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(25, 369)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(316, 70)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(200, 22)
        Me.txtNama.TabIndex = 2
        Me.txtNama.Tag = ""
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(316, 182)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(200, 22)
        Me.txtAlamat.TabIndex = 3
        '
        'txtUmur
        '
        Me.txtUmur.Location = New System.Drawing.Point(316, 98)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(200, 22)
        Me.txtUmur.TabIndex = 4
        '
        'txtNoHP
        '
        Me.txtNoHP.Location = New System.Drawing.Point(316, 154)
        Me.txtNoHP.Name = "txtNoHP"
        Me.txtNoHP.Size = New System.Drawing.Size(200, 22)
        Me.txtNoHP.TabIndex = 5
        '
        'dtpTanggalLahir
        '
        Me.dtpTanggalLahir.Location = New System.Drawing.Point(316, 126)
        Me.dtpTanggalLahir.Name = "dtpTanggalLahir"
        Me.dtpTanggalLahir.Size = New System.Drawing.Size(200, 22)
        Me.dtpTanggalLahir.TabIndex = 6
        '
        'grpGender
        '
        Me.grpGender.Controls.Add(Me.rbPerempuan)
        Me.grpGender.Controls.Add(Me.rbLaki)
        Me.grpGender.Location = New System.Drawing.Point(316, 231)
        Me.grpGender.Name = "grpGender"
        Me.grpGender.Size = New System.Drawing.Size(200, 161)
        Me.grpGender.TabIndex = 7
        Me.grpGender.TabStop = False
        Me.grpGender.Text = "Gender"
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Location = New System.Drawing.Point(7, 51)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(97, 20)
        Me.rbPerempuan.TabIndex = 1
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.Location = New System.Drawing.Point(7, 22)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(74, 20)
        Me.rbLaki.TabIndex = 0
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "laki-laki"
        Me.rbLaki.UseVisualStyleBackColor = True
        '
        'grpHobby
        '
        Me.grpHobby.Controls.Add(Me.cbCooking)
        Me.grpHobby.Controls.Add(Me.cbDrawwing)
        Me.grpHobby.Controls.Add(Me.cbMovie)
        Me.grpHobby.Controls.Add(Me.cbTravel)
        Me.grpHobby.Controls.Add(Me.cbSport)
        Me.grpHobby.Controls.Add(Me.cbReading)
        Me.grpHobby.Controls.Add(Me.cbCoding)
        Me.grpHobby.Controls.Add(Me.cbMusic)
        Me.grpHobby.Controls.Add(Me.cbAnime)
        Me.grpHobby.Controls.Add(Me.cbGame)
        Me.grpHobby.Location = New System.Drawing.Point(556, 70)
        Me.grpHobby.Name = "grpHobby"
        Me.grpHobby.Size = New System.Drawing.Size(223, 261)
        Me.grpHobby.TabIndex = 8
        Me.grpHobby.TabStop = False
        Me.grpHobby.Text = "hobi"
        '
        'cbCooking
        '
        Me.cbCooking.AutoSize = True
        Me.cbCooking.Location = New System.Drawing.Point(134, 134)
        Me.cbCooking.Name = "cbCooking"
        Me.cbCooking.Size = New System.Drawing.Size(70, 20)
        Me.cbCooking.TabIndex = 9
        Me.cbCooking.Text = "masak"
        Me.cbCooking.UseVisualStyleBackColor = True
        '
        'cbDrawwing
        '
        Me.cbDrawwing.AutoSize = True
        Me.cbDrawwing.Location = New System.Drawing.Point(134, 108)
        Me.cbDrawwing.Name = "cbDrawwing"
        Me.cbDrawwing.Size = New System.Drawing.Size(76, 20)
        Me.cbDrawwing.TabIndex = 8
        Me.cbDrawwing.Text = "gambar"
        Me.cbDrawwing.UseVisualStyleBackColor = True
        '
        'cbMovie
        '
        Me.cbMovie.AutoSize = True
        Me.cbMovie.Location = New System.Drawing.Point(134, 82)
        Me.cbMovie.Name = "cbMovie"
        Me.cbMovie.Size = New System.Drawing.Size(49, 20)
        Me.cbMovie.TabIndex = 7
        Me.cbMovie.Text = "film"
        Me.cbMovie.UseVisualStyleBackColor = True
        '
        'cbTravel
        '
        Me.cbTravel.AutoSize = True
        Me.cbTravel.Location = New System.Drawing.Point(134, 56)
        Me.cbTravel.Name = "cbTravel"
        Me.cbTravel.Size = New System.Drawing.Size(68, 20)
        Me.cbTravel.TabIndex = 6
        Me.cbTravel.Text = "Travel"
        Me.cbTravel.UseVisualStyleBackColor = True
        '
        'cbSport
        '
        Me.cbSport.AutoSize = True
        Me.cbSport.Location = New System.Drawing.Point(134, 30)
        Me.cbSport.Name = "cbSport"
        Me.cbSport.Size = New System.Drawing.Size(83, 20)
        Me.cbSport.TabIndex = 5
        Me.cbSport.Text = "olahraga"
        Me.cbSport.UseVisualStyleBackColor = True
        '
        'cbReading
        '
        Me.cbReading.AutoSize = True
        Me.cbReading.Location = New System.Drawing.Point(6, 134)
        Me.cbReading.Name = "cbReading"
        Me.cbReading.Size = New System.Drawing.Size(90, 20)
        Me.cbReading.TabIndex = 4
        Me.cbReading.Text = "membaca"
        Me.cbReading.UseVisualStyleBackColor = True
        '
        'cbCoding
        '
        Me.cbCoding.AutoSize = True
        Me.cbCoding.Location = New System.Drawing.Point(6, 108)
        Me.cbCoding.Name = "cbCoding"
        Me.cbCoding.Size = New System.Drawing.Size(70, 20)
        Me.cbCoding.TabIndex = 3
        Me.cbCoding.Text = "coding"
        Me.cbCoding.UseVisualStyleBackColor = True
        '
        'cbMusic
        '
        Me.cbMusic.AutoSize = True
        Me.cbMusic.Location = New System.Drawing.Point(7, 82)
        Me.cbMusic.Name = "cbMusic"
        Me.cbMusic.Size = New System.Drawing.Size(64, 20)
        Me.cbMusic.TabIndex = 2
        Me.cbMusic.Text = "music"
        Me.cbMusic.UseVisualStyleBackColor = True
        '
        'cbAnime
        '
        Me.cbAnime.AutoSize = True
        Me.cbAnime.Location = New System.Drawing.Point(6, 56)
        Me.cbAnime.Name = "cbAnime"
        Me.cbAnime.Size = New System.Drawing.Size(66, 20)
        Me.cbAnime.TabIndex = 1
        Me.cbAnime.Text = "anime"
        Me.cbAnime.UseVisualStyleBackColor = True
        '
        'cbGame
        '
        Me.cbGame.AutoSize = True
        Me.cbGame.Location = New System.Drawing.Point(6, 30)
        Me.cbGame.Name = "cbGame"
        Me.cbGame.Size = New System.Drawing.Size(64, 20)
        Me.cbGame.TabIndex = 0
        Me.cbGame.Text = "game"
        Me.cbGame.UseVisualStyleBackColor = True
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(216, 76)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(41, 16)
        Me.lblNama.TabIndex = 9
        Me.lblNama.Text = "nama"
        '
        'lblUmur
        '
        Me.lblUmur.AutoSize = True
        Me.lblUmur.Location = New System.Drawing.Point(216, 104)
        Me.lblUmur.Name = "lblUmur"
        Me.lblUmur.Size = New System.Drawing.Size(36, 16)
        Me.lblUmur.TabIndex = 10
        Me.lblUmur.Text = "umur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "tanggal lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "no telepon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(216, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "alamat"
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(556, 347)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(216, 45)
        Me.btnCetak.TabIndex = 14
        Me.btnCetak.Text = "cetak"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'lblYou
        '
        Me.lblYou.AutoSize = True
        Me.lblYou.Location = New System.Drawing.Point(22, 76)
        Me.lblYou.Name = "lblYou"
        Me.lblYou.Size = New System.Drawing.Size(116, 16)
        Me.lblYou.TabIndex = 15
        Me.lblYou.Text = "Change your heart"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblYou)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblUmur)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.grpHobby)
        Me.Controls.Add(Me.grpGender)
        Me.Controls.Add(Me.dtpTanggalLahir)
        Me.Controls.Add(Me.txtNoHP)
        Me.Controls.Add(Me.txtUmur)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGender.ResumeLayout(False)
        Me.grpGender.PerformLayout()
        Me.grpHobby.ResumeLayout(False)
        Me.grpHobby.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNoHP As TextBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents grpGender As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents grpHobby As GroupBox
    Friend WithEvents cbCooking As CheckBox
    Friend WithEvents cbDrawwing As CheckBox
    Friend WithEvents cbMovie As CheckBox
    Friend WithEvents cbTravel As CheckBox
    Friend WithEvents cbSport As CheckBox
    Friend WithEvents cbReading As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbMusic As CheckBox
    Friend WithEvents cbAnime As CheckBox
    Friend WithEvents cbGame As CheckBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCetak As Button
    Friend WithEvents lblYou As Label
End Class
