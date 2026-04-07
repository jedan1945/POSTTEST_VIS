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
        picKartu = New PictureBox()
        lblNama = New Label()
        lblID = New Label()
        lblKomunitas = New Label()
        lblKontak = New Label()
        lblHobby = New Label()
        panelHeader = New Panel()
        btnClose = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        CType(picKartu, ComponentModel.ISupportInitialize).BeginInit()
        panelHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' picKartu
        ' 
        picKartu.BorderStyle = BorderStyle.FixedSingle
        picKartu.Location = New Point(12, 69)
        picKartu.Name = "picKartu"
        picKartu.Size = New Size(125, 158)
        picKartu.SizeMode = PictureBoxSizeMode.StretchImage
        picKartu.TabIndex = 0
        picKartu.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.ForeColor = Color.White
        lblNama.Location = New Point(146, 105)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(84, 31)
        lblNama.TabIndex = 1
        lblNama.Text = "Label1"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.ForeColor = Color.White
        lblID.Location = New Point(176, 136)
        lblID.Name = "lblID"
        lblID.Size = New Size(53, 20)
        lblID.TabIndex = 2
        lblID.Text = "Label2"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.ForeColor = Color.White
        lblKomunitas.Location = New Point(343, 89)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(53, 20)
        lblKomunitas.TabIndex = 3
        lblKomunitas.Text = "Label3"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.ForeColor = Color.White
        lblKontak.Location = New Point(202, 183)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(53, 20)
        lblKontak.TabIndex = 4
        lblKontak.Text = "Label4"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.ForeColor = Color.White
        lblHobby.Location = New Point(202, 207)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(53, 20)
        lblHobby.TabIndex = 5
        lblHobby.Text = "Label5"
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = Color.DarkRed
        panelHeader.Controls.Add(btnClose)
        panelHeader.Controls.Add(Label1)
        panelHeader.Dock = DockStyle.Top
        panelHeader.Location = New Point(0, 0)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(482, 50)
        panelHeader.TabIndex = 6
        ' 
        ' btnClose
        ' 
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Location = New Point(442, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(40, 30)
        btnClose.TabIndex = 12
        btnClose.Text = "x"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(197, 28)
        Label1.TabIndex = 0
        Label1.Text = "COMMUNITY CARD"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(144, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 31)
        Label2.TabIndex = 7
        Label2.Text = "NAMA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(146, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(24, 20)
        Label3.TabIndex = 8
        Label3.Text = "ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(343, 69)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 20)
        Label4.TabIndex = 9
        Label4.Text = "komunitas"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.Location = New Point(143, 183)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 20)
        Label5.TabIndex = 10
        Label5.Text = "kontak"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.White
        Label6.Location = New Point(146, 207)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 20)
        Label6.TabIndex = 11
        Label6.Text = "hobi"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(482, 253)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(panelHeader)
        Controls.Add(lblHobby)
        Controls.Add(lblKontak)
        Controls.Add(lblKomunitas)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(picKartu)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        CType(picKartu, ComponentModel.ISupportInitialize).EndInit()
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picKartu As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents panelHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnClose As Button
End Class
