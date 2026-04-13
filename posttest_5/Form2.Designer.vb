<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        tabMain = New TabControl()
        tabTambah = New TabPage()
        btnTambah = New Button()
        cmbGradeTambah = New ComboBox()
        txtHargaTambah = New TextBox()
        txtNamaTambah = New TextBox()
        txtKodeTambah = New TextBox()
        tabUpdate = New TabPage()
        btnUpdate = New Button()
        cmbGradeUpdate = New ComboBox()
        txtHargaUpdate = New TextBox()
        txtNamaUpdate = New TextBox()
        txtKodeUpdate = New TextBox()
        tabHapus = New TabPage()
        btnDelete = New Button()
        txtKodeHapus = New TextBox()
        tabData = New TabPage()
        dgvGundam = New DataGridView()
        KodeGundam = New DataGridViewTextBoxColumn()
        namaGundam = New DataGridViewTextBoxColumn()
        grade = New DataGridViewTextBoxColumn()
        harga = New DataGridViewTextBoxColumn()
        txtSearch = New TextBox()
        Panel1 = New Panel()
        Label1 = New Label()
        tabMain.SuspendLayout()
        tabTambah.SuspendLayout()
        tabUpdate.SuspendLayout()
        tabHapus.SuspendLayout()
        tabData.SuspendLayout()
        CType(dgvGundam, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tabMain
        ' 
        tabMain.Appearance = TabAppearance.Buttons
        tabMain.Controls.Add(tabTambah)
        tabMain.Controls.Add(tabUpdate)
        tabMain.Controls.Add(tabHapus)
        tabMain.Controls.Add(tabData)
        tabMain.Location = New Point(0, 59)
        tabMain.Name = "tabMain"
        tabMain.SelectedIndex = 0
        tabMain.Size = New Size(798, 392)
        tabMain.TabIndex = 0
        ' 
        ' tabTambah
        ' 
        tabTambah.BackColor = Color.Turquoise
        tabTambah.Controls.Add(btnTambah)
        tabTambah.Controls.Add(cmbGradeTambah)
        tabTambah.Controls.Add(txtHargaTambah)
        tabTambah.Controls.Add(txtNamaTambah)
        tabTambah.Controls.Add(txtKodeTambah)
        tabTambah.Location = New Point(4, 32)
        tabTambah.Name = "tabTambah"
        tabTambah.Padding = New Padding(3)
        tabTambah.Size = New Size(790, 356)
        tabTambah.TabIndex = 0
        tabTambah.Text = "tambah"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.SeaGreen
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Location = New Point(133, 164)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 4
        btnTambah.Text = "tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' cmbGradeTambah
        ' 
        cmbGradeTambah.FormattingEnabled = True
        cmbGradeTambah.Items.AddRange(New Object() {"SD", "EG", "HG", "RG", "MG", "PG", "NG"})
        cmbGradeTambah.Location = New Point(36, 97)
        cmbGradeTambah.Name = "cmbGradeTambah"
        cmbGradeTambah.Size = New Size(191, 28)
        cmbGradeTambah.TabIndex = 3
        cmbGradeTambah.Text = "grade"
        ' 
        ' txtHargaTambah
        ' 
        txtHargaTambah.Location = New Point(36, 131)
        txtHargaTambah.Name = "txtHargaTambah"
        txtHargaTambah.PlaceholderText = "Harga"
        txtHargaTambah.Size = New Size(191, 27)
        txtHargaTambah.TabIndex = 2
        ' 
        ' txtNamaTambah
        ' 
        txtNamaTambah.Location = New Point(36, 64)
        txtNamaTambah.Name = "txtNamaTambah"
        txtNamaTambah.PlaceholderText = "Nama"
        txtNamaTambah.Size = New Size(191, 27)
        txtNamaTambah.TabIndex = 1
        ' 
        ' txtKodeTambah
        ' 
        txtKodeTambah.Location = New Point(36, 31)
        txtKodeTambah.Name = "txtKodeTambah"
        txtKodeTambah.PlaceholderText = "kode"
        txtKodeTambah.Size = New Size(191, 27)
        txtKodeTambah.TabIndex = 0
        ' 
        ' tabUpdate
        ' 
        tabUpdate.BackColor = Color.Turquoise
        tabUpdate.Controls.Add(btnUpdate)
        tabUpdate.Controls.Add(cmbGradeUpdate)
        tabUpdate.Controls.Add(txtHargaUpdate)
        tabUpdate.Controls.Add(txtNamaUpdate)
        tabUpdate.Controls.Add(txtKodeUpdate)
        tabUpdate.Location = New Point(4, 32)
        tabUpdate.Name = "tabUpdate"
        tabUpdate.Padding = New Padding(3)
        tabUpdate.Size = New Size(790, 356)
        tabUpdate.TabIndex = 1
        tabUpdate.Text = "Update"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(102, 164)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 4
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' cmbGradeUpdate
        ' 
        cmbGradeUpdate.FormattingEnabled = True
        cmbGradeUpdate.Items.AddRange(New Object() {"SD", "EG", "HG", "RG", "MG", "PG", "NG"})
        cmbGradeUpdate.Location = New Point(40, 97)
        cmbGradeUpdate.Name = "cmbGradeUpdate"
        cmbGradeUpdate.Size = New Size(151, 28)
        cmbGradeUpdate.TabIndex = 3
        cmbGradeUpdate.Text = "Grade"
        ' 
        ' txtHargaUpdate
        ' 
        txtHargaUpdate.Location = New Point(40, 131)
        txtHargaUpdate.Name = "txtHargaUpdate"
        txtHargaUpdate.PlaceholderText = "Harga"
        txtHargaUpdate.Size = New Size(151, 27)
        txtHargaUpdate.TabIndex = 2
        ' 
        ' txtNamaUpdate
        ' 
        txtNamaUpdate.Location = New Point(40, 64)
        txtNamaUpdate.Name = "txtNamaUpdate"
        txtNamaUpdate.PlaceholderText = "Nama"
        txtNamaUpdate.Size = New Size(151, 27)
        txtNamaUpdate.TabIndex = 1
        ' 
        ' txtKodeUpdate
        ' 
        txtKodeUpdate.Location = New Point(40, 31)
        txtKodeUpdate.Name = "txtKodeUpdate"
        txtKodeUpdate.PlaceholderText = "kode"
        txtKodeUpdate.Size = New Size(151, 27)
        txtKodeUpdate.TabIndex = 0
        ' 
        ' tabHapus
        ' 
        tabHapus.BackColor = Color.Turquoise
        tabHapus.Controls.Add(btnDelete)
        tabHapus.Controls.Add(txtKodeHapus)
        tabHapus.Location = New Point(4, 32)
        tabHapus.Name = "tabHapus"
        tabHapus.Padding = New Padding(3)
        tabHapus.Size = New Size(790, 356)
        tabHapus.TabIndex = 2
        tabHapus.Text = "hapus"
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(79, 86)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Hpaus"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' txtKodeHapus
        ' 
        txtKodeHapus.Location = New Point(48, 53)
        txtKodeHapus.Name = "txtKodeHapus"
        txtKodeHapus.PlaceholderText = "kode"
        txtKodeHapus.Size = New Size(125, 27)
        txtKodeHapus.TabIndex = 0
        ' 
        ' tabData
        ' 
        tabData.BackColor = Color.Turquoise
        tabData.Controls.Add(dgvGundam)
        tabData.Controls.Add(txtSearch)
        tabData.Location = New Point(4, 32)
        tabData.Name = "tabData"
        tabData.Padding = New Padding(3)
        tabData.Size = New Size(790, 356)
        tabData.TabIndex = 3
        tabData.Text = "Data"
        ' 
        ' dgvGundam
        ' 
        dgvGundam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGundam.Columns.AddRange(New DataGridViewColumn() {KodeGundam, namaGundam, grade, harga})
        dgvGundam.Location = New Point(20, 117)
        dgvGundam.Name = "dgvGundam"
        dgvGundam.RowHeadersWidth = 51
        dgvGundam.Size = New Size(559, 188)
        dgvGundam.TabIndex = 1
        ' 
        ' KodeGundam
        ' 
        KodeGundam.HeaderText = "Kode"
        KodeGundam.MinimumWidth = 6
        KodeGundam.Name = "KodeGundam"
        KodeGundam.Width = 125
        ' 
        ' namaGundam
        ' 
        namaGundam.HeaderText = "nama"
        namaGundam.MinimumWidth = 6
        namaGundam.Name = "namaGundam"
        namaGundam.Width = 125
        ' 
        ' grade
        ' 
        grade.HeaderText = "grade"
        grade.MinimumWidth = 6
        grade.Name = "grade"
        grade.Width = 125
        ' 
        ' harga
        ' 
        harga.HeaderText = "harga"
        harga.MinimumWidth = 6
        harga.Name = "harga"
        harga.Width = 125
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(20, 67)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari"
        txtSearch.Size = New Size(125, 27)
        txtSearch.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 55)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Cyan
        Label1.Location = New Point(4, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 20)
        Label1.TabIndex = 0
        Label1.Text = "GUNDAM HANGAR SYSTEM"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(tabMain)
        Name = "Form2"
        Text = "Form2"
        tabMain.ResumeLayout(False)
        tabTambah.ResumeLayout(False)
        tabTambah.PerformLayout()
        tabUpdate.ResumeLayout(False)
        tabUpdate.PerformLayout()
        tabHapus.ResumeLayout(False)
        tabHapus.PerformLayout()
        tabData.ResumeLayout(False)
        tabData.PerformLayout()
        CType(dgvGundam, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabTambah As TabPage
    Friend WithEvents tabUpdate As TabPage
    Friend WithEvents tabHapus As TabPage
    Friend WithEvents tabData As TabPage
    Friend WithEvents btnTambah As Button
    Friend WithEvents cmbGradeTambah As ComboBox
    Friend WithEvents txtHargaTambah As TextBox
    Friend WithEvents txtNamaTambah As TextBox
    Friend WithEvents txtKodeTambah As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cmbGradeUpdate As ComboBox
    Friend WithEvents txtHargaUpdate As TextBox
    Friend WithEvents txtNamaUpdate As TextBox
    Friend WithEvents txtKodeUpdate As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtKodeHapus As TextBox
    Friend WithEvents dgvGundam As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents KodeGundam As DataGridViewTextBoxColumn
    Friend WithEvents namaGundam As DataGridViewTextBoxColumn
    Friend WithEvents grade As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
