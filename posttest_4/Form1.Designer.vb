<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        menuInput = New ToolStripMenuItem()
        menuLihat = New ToolStripMenuItem()
        menuSimpan = New ToolStripMenuItem()
        menuBuka = New ToolStripMenuItem()
        menuKeluar = New ToolStripMenuItem()
        TabControl = New TabControl()
        tabData = New TabPage()
        cmbKomunitas = New ComboBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        dtpLahir = New DateTimePicker()
        txtID = New TextBox()
        txtNama = New TextBox()
        tabKontak = New TabPage()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mtbHP = New MaskedTextBox()
        tabProfil = New TabPage()
        btnSimpanCetak = New Button()
        grpPeran = New GroupBox()
        cb8 = New CheckBox()
        cb7 = New CheckBox()
        cb6 = New CheckBox()
        cb5 = New CheckBox()
        cb4 = New CheckBox()
        cb3 = New CheckBox()
        cb2 = New CheckBox()
        cb1 = New CheckBox()
        rbAnggota = New RadioButton()
        rbAdmin = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        picFoto = New PictureBox()
        ErrorProvider1 = New ErrorProvider(components)
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        Panel1 = New Panel()
        panelHeader = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        MenuStrip1.SuspendLayout()
        TabControl.SuspendLayout()
        tabData.SuspendLayout()
        tabKontak.SuspendLayout()
        tabProfil.SuspendLayout()
        grpPeran.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        panelHeader.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        MenuStrip1.Dock = DockStyle.Bottom
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {menuInput, menuLihat, menuSimpan, menuBuka, menuKeluar})
        MenuStrip1.Location = New Point(0, 525)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(982, 28)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' menuInput
        ' 
        menuInput.ForeColor = Color.White
        menuInput.Name = "menuInput"
        menuInput.Size = New Size(93, 24)
        menuInput.Text = "Input Data"
        ' 
        ' menuLihat
        ' 
        menuLihat.ForeColor = Color.White
        menuLihat.Name = "menuLihat"
        menuLihat.Size = New Size(94, 24)
        menuLihat.Text = "Lihat Kartu"
        ' 
        ' menuSimpan
        ' 
        menuSimpan.ForeColor = Color.White
        menuSimpan.Name = "menuSimpan"
        menuSimpan.Size = New Size(109, 24)
        menuSimpan.Text = "Simpan Data"
        ' 
        ' menuBuka
        ' 
        menuBuka.ForeColor = Color.White
        menuBuka.Name = "menuBuka"
        menuBuka.Size = New Size(91, 24)
        menuBuka.Text = "Buka Data"
        ' 
        ' menuKeluar
        ' 
        menuKeluar.ForeColor = Color.White
        menuKeluar.Name = "menuKeluar"
        menuKeluar.Size = New Size(65, 24)
        menuKeluar.Text = "Keluar"
        ' 
        ' TabControl
        ' 
        TabControl.Controls.Add(tabData)
        TabControl.Controls.Add(tabKontak)
        TabControl.Controls.Add(tabProfil)
        TabControl.Dock = DockStyle.Fill
        TabControl.Location = New Point(0, 0)
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(980, 452)
        TabControl.TabIndex = 5
        ' 
        ' tabData
        ' 
        tabData.Controls.Add(Label9)
        tabData.Controls.Add(Label8)
        tabData.Controls.Add(Label7)
        tabData.Controls.Add(Label6)
        tabData.Controls.Add(Label5)
        tabData.Controls.Add(cmbKomunitas)
        tabData.Controls.Add(rbPerempuan)
        tabData.Controls.Add(rbLaki)
        tabData.Controls.Add(dtpLahir)
        tabData.Controls.Add(txtID)
        tabData.Controls.Add(txtNama)
        tabData.Location = New Point(4, 29)
        tabData.Name = "tabData"
        tabData.Padding = New Padding(3)
        tabData.Size = New Size(972, 419)
        tabData.TabIndex = 0
        tabData.Text = "Data Utama"
        tabData.UseVisualStyleBackColor = True
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Items.AddRange(New Object() {"Gaming", "Anime", "Progamming"})
        cmbKomunitas.Location = New Point(346, 177)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(208, 28)
        cmbKomunitas.TabIndex = 5
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(448, 146)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(106, 24)
        rbPerempuan.TabIndex = 4
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(346, 147)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(82, 24)
        rbLaki.TabIndex = 3
        rbLaki.TabStop = True
        rbLaki.Text = "laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Format = DateTimePickerFormat.Short
        dtpLahir.Location = New Point(346, 111)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(208, 27)
        dtpLahir.TabIndex = 2
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(346, 81)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "masukkan ID"
        txtID.Size = New Size(208, 27)
        txtID.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(346, 45)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "masukkan nama"
        txtNama.Size = New Size(208, 27)
        txtNama.TabIndex = 0
        ' 
        ' tabKontak
        ' 
        tabKontak.Controls.Add(Label4)
        tabKontak.Controls.Add(Label3)
        tabKontak.Controls.Add(Label2)
        tabKontak.Controls.Add(txtAlamat)
        tabKontak.Controls.Add(txtEmail)
        tabKontak.Controls.Add(mtbHP)
        tabKontak.Location = New Point(4, 29)
        tabKontak.Name = "tabKontak"
        tabKontak.Padding = New Padding(3)
        tabKontak.Size = New Size(972, 419)
        tabKontak.TabIndex = 1
        tabKontak.Text = "Kontak&Info"
        tabKontak.UseVisualStyleBackColor = True
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(242, 42)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(400, 198)
        txtAlamat.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(79, 135)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "E-Mail"
        txtEmail.Size = New Size(125, 27)
        txtEmail.TabIndex = 1
        ' 
        ' mtbHP
        ' 
        mtbHP.Location = New Point(79, 68)
        mtbHP.Mask = "0000-0000-0000"
        mtbHP.Name = "mtbHP"
        mtbHP.Size = New Size(125, 27)
        mtbHP.TabIndex = 0
        ' 
        ' tabProfil
        ' 
        tabProfil.Controls.Add(btnSimpanCetak)
        tabProfil.Controls.Add(grpPeran)
        tabProfil.Controls.Add(btnBrowse)
        tabProfil.Controls.Add(picFoto)
        tabProfil.Location = New Point(4, 29)
        tabProfil.Name = "tabProfil"
        tabProfil.Padding = New Padding(3)
        tabProfil.Size = New Size(972, 419)
        tabProfil.TabIndex = 2
        tabProfil.Text = "Profil&Aktivitas"
        tabProfil.UseVisualStyleBackColor = True
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.Location = New Point(397, 246)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(191, 29)
        btnSimpanCetak.TabIndex = 3
        btnSimpanCetak.Text = "Simpan & cetak"
        btnSimpanCetak.UseVisualStyleBackColor = True
        ' 
        ' grpPeran
        ' 
        grpPeran.Controls.Add(cb8)
        grpPeran.Controls.Add(cb7)
        grpPeran.Controls.Add(cb6)
        grpPeran.Controls.Add(cb5)
        grpPeran.Controls.Add(cb4)
        grpPeran.Controls.Add(cb3)
        grpPeran.Controls.Add(cb2)
        grpPeran.Controls.Add(cb1)
        grpPeran.Controls.Add(rbAnggota)
        grpPeran.Controls.Add(rbAdmin)
        grpPeran.Controls.Add(rbKetua)
        grpPeran.Location = New Point(189, 82)
        grpPeran.Name = "grpPeran"
        grpPeran.Size = New Size(399, 158)
        grpPeran.TabIndex = 2
        grpPeran.TabStop = False
        grpPeran.Text = "Role"
        ' 
        ' cb8
        ' 
        cb8.AutoSize = True
        cb8.Location = New Point(242, 116)
        cb8.Name = "cb8"
        cb8.Size = New Size(91, 24)
        cb8.TabIndex = 10
        cb8.Text = "Traveling"
        cb8.UseVisualStyleBackColor = True
        ' 
        ' cb7
        ' 
        cb7.AutoSize = True
        cb7.Location = New Point(242, 86)
        cb7.Name = "cb7"
        cb7.Size = New Size(97, 24)
        cb7.TabIndex = 9
        cb7.Text = "Membaca"
        cb7.UseVisualStyleBackColor = True
        ' 
        ' cb6
        ' 
        cb6.AutoSize = True
        cb6.Location = New Point(242, 57)
        cb6.Name = "cb6"
        cb6.Size = New Size(92, 24)
        cb6.TabIndex = 8
        cb6.Text = "Olahraga"
        cb6.UseVisualStyleBackColor = True
        ' 
        ' cb5
        ' 
        cb5.AutoSize = True
        cb5.Location = New Point(242, 27)
        cb5.Name = "cb5"
        cb5.Size = New Size(69, 24)
        cb5.TabIndex = 7
        cb5.Text = "Musik"
        cb5.UseVisualStyleBackColor = True
        ' 
        ' cb4
        ' 
        cb4.AutoSize = True
        cb4.Location = New Point(133, 116)
        cb4.Name = "cb4"
        cb4.Size = New Size(78, 24)
        cb4.TabIndex = 6
        cb4.Text = "Editing"
        cb4.UseVisualStyleBackColor = True
        ' 
        ' cb3
        ' 
        cb3.AutoSize = True
        cb3.Location = New Point(133, 86)
        cb3.Name = "cb3"
        cb3.Size = New Size(77, 24)
        cb3.TabIndex = 5
        cb3.Text = "Design"
        cb3.UseVisualStyleBackColor = True
        ' 
        ' cb2
        ' 
        cb2.AutoSize = True
        cb2.Location = New Point(133, 56)
        cb2.Name = "cb2"
        cb2.Size = New Size(79, 24)
        cb2.TabIndex = 4
        cb2.Text = "Coding"
        cb2.UseVisualStyleBackColor = True
        ' 
        ' cb1
        ' 
        cb1.AutoSize = True
        cb1.Location = New Point(133, 26)
        cb1.Name = "cb1"
        cb1.Size = New Size(74, 24)
        cb1.TabIndex = 3
        cb1.Text = "Gamin"
        cb1.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(6, 86)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(88, 24)
        rbAnggota.TabIndex = 2
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(6, 56)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(74, 24)
        rbAdmin.TabIndex = 1
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(6, 26)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(68, 24)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(56, 246)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "brwose"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' picFoto
        ' 
        picFoto.Location = New Point(25, 82)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(125, 158)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(TabControl)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 71)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 454)
        Panel1.TabIndex = 6
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        panelHeader.Controls.Add(PictureBox1)
        panelHeader.Controls.Add(Label1)
        panelHeader.Dock = DockStyle.Top
        panelHeader.Location = New Point(0, 0)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(982, 67)
        panelHeader.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._09bbab48276c16b0be2378af2759c236
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(75, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(84, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(250, 41)
        Label1.TabIndex = 0
        Label1.Text = "kartu komunitas"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(242, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 20)
        Label2.TabIndex = 3
        Label2.Text = "alamat"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(79, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 4
        Label3.Text = "no HP"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(79, 112)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 20)
        Label4.TabIndex = 5
        Label4.Text = "E-mail"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(245, 52)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 20)
        Label5.TabIndex = 6
        Label5.Text = "nama"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(245, 88)
        Label6.Name = "Label6"
        Label6.Size = New Size(22, 20)
        Label6.TabIndex = 7
        Label6.Text = "id"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(245, 116)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 20)
        Label7.TabIndex = 8
        Label7.Text = "tanggal lahir"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(245, 151)
        Label8.Name = "Label8"
        Label8.Size = New Size(95, 20)
        Label8.TabIndex = 9
        Label8.Text = "jenis kelamin"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(245, 185)
        Label9.Name = "Label9"
        Label9.Size = New Size(73, 20)
        Label9.TabIndex = 10
        Label9.Text = "kominitas"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 553)
        Controls.Add(panelHeader)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl.ResumeLayout(False)
        tabData.ResumeLayout(False)
        tabData.PerformLayout()
        tabKontak.ResumeLayout(False)
        tabKontak.PerformLayout()
        tabProfil.ResumeLayout(False)
        grpPeran.ResumeLayout(False)
        grpPeran.PerformLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuInput As ToolStripMenuItem
    Friend WithEvents menuLihat As ToolStripMenuItem
    Friend WithEvents menuSimpan As ToolStripMenuItem
    Friend WithEvents menuBuka As ToolStripMenuItem
    Friend WithEvents menuKeluar As ToolStripMenuItem
    Friend WithEvents TabControl As TabControl
    Friend WithEvents tabData As TabPage
    Friend WithEvents tabKontak As TabPage
    Friend WithEvents tabProfil As TabPage
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtbHP As MaskedTextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents grpPeran As GroupBox
    Friend WithEvents cb8 As CheckBox
    Friend WithEvents cb7 As CheckBox
    Friend WithEvents cb6 As CheckBox
    Friend WithEvents cb5 As CheckBox
    Friend WithEvents cb4 As CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelHeader As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label

End Class
