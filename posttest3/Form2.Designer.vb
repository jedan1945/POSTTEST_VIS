<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblUmur = New System.Windows.Forms.Label()
        Me.lblHP = New System.Windows.Forms.Label()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblHobby = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.pbBackground = New System.Windows.Forms.PictureBox()
        Me.panelcard = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelcard.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(50, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(3, 0)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(41, 16)
        Me.lblNama.TabIndex = 1
        Me.lblNama.Text = "nama"
        '
        'lblUmur
        '
        Me.lblUmur.AutoSize = True
        Me.lblUmur.Location = New System.Drawing.Point(236, 0)
        Me.lblUmur.Name = "lblUmur"
        Me.lblUmur.Size = New System.Drawing.Size(36, 16)
        Me.lblUmur.TabIndex = 2
        Me.lblUmur.Text = "umur"
        '
        'lblHP
        '
        Me.lblHP.AutoSize = True
        Me.lblHP.Location = New System.Drawing.Point(405, 0)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(40, 16)
        Me.lblHP.TabIndex = 3
        Me.lblHP.Text = "no hp"
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Location = New System.Drawing.Point(3, 226)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(80, 16)
        Me.lblTanggal.TabIndex = 4
        Me.lblTanggal.Text = "tanggal lahir"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(451, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(85, 16)
        Me.lblGender.TabIndex = 5
        Me.lblGender.Text = "jenis kelamin"
        '
        'lblHobby
        '
        Me.lblHobby.AutoSize = True
        Me.lblHobby.Location = New System.Drawing.Point(542, 0)
        Me.lblHobby.Name = "lblHobby"
        Me.lblHobby.Size = New System.Drawing.Size(33, 16)
        Me.lblHobby.TabIndex = 6
        Me.lblHobby.Text = "hobi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(233, 349)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 16)
        Me.Label7.TabIndex = 7
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(581, 0)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(48, 16)
        Me.lblAlamat.TabIndex = 8
        Me.lblAlamat.Text = "alamat"
        '
        'pbBackground
        '
        Me.pbBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbBackground.Image = CType(resources.GetObject("pbBackground.Image"), System.Drawing.Image)
        Me.pbBackground.Location = New System.Drawing.Point(0, 0)
        Me.pbBackground.Name = "pbBackground"
        Me.pbBackground.Size = New System.Drawing.Size(782, 403)
        Me.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBackground.TabIndex = 9
        Me.pbBackground.TabStop = False
        '
        'panelcard
        '
        Me.panelcard.BackColor = System.Drawing.Color.Maroon
        Me.panelcard.Controls.Add(Me.lblNama)
        Me.panelcard.Controls.Add(Me.PictureBox1)
        Me.panelcard.Controls.Add(Me.lblUmur)
        Me.panelcard.Controls.Add(Me.lblTitle)
        Me.panelcard.Controls.Add(Me.lblHP)
        Me.panelcard.Controls.Add(Me.lblGender)
        Me.panelcard.Controls.Add(Me.lblHobby)
        Me.panelcard.Controls.Add(Me.lblAlamat)
        Me.panelcard.Controls.Add(Me.lblTanggal)
        Me.panelcard.Location = New System.Drawing.Point(42, 28)
        Me.panelcard.Name = "panelcard"
        Me.panelcard.Size = New System.Drawing.Size(700, 350)
        Me.panelcard.TabIndex = 10
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Impact", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(278, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(121, 45)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "Label1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(782, 403)
        Me.Controls.Add(Me.panelcard)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pbBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelcard.ResumeLayout(False)
        Me.panelcard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblHP As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents pbBackground As PictureBox
    Friend WithEvents panelcard As FlowLayoutPanel
    Friend WithEvents lblTitle As Label
End Class
