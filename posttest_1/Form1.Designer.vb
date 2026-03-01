<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblIPS = New System.Windows.Forms.Label()
        Me.lblIPK = New System.Windows.Forms.Label()
        Me.lblPredikat = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnNambah = New System.Windows.Forms.Button()
        Me.txtIPS = New System.Windows.Forms.TextBox()
        Me.txtIPK = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblIPS
        '
        Me.lblIPS.AutoSize = True
        Me.lblIPS.Location = New System.Drawing.Point(246, 151)
        Me.lblIPS.Name = "lblIPS"
        Me.lblIPS.Size = New System.Drawing.Size(28, 16)
        Me.lblIPS.TabIndex = 0
        Me.lblIPS.Text = "IPS"
        '
        'lblIPK
        '
        Me.lblIPK.AutoSize = True
        Me.lblIPK.Location = New System.Drawing.Point(246, 211)
        Me.lblIPK.Name = "lblIPK"
        Me.lblIPK.Size = New System.Drawing.Size(27, 16)
        Me.lblIPK.TabIndex = 1
        Me.lblIPK.Text = "IPK"
        '
        'lblPredikat
        '
        Me.lblPredikat.AutoSize = True
        Me.lblPredikat.Location = New System.Drawing.Point(330, 233)
        Me.lblPredikat.Name = "lblPredikat"
        Me.lblPredikat.Size = New System.Drawing.Size(121, 16)
        Me.lblPredikat.TabIndex = 2
        Me.lblPredikat.Text = "LAH?!KOSONG???"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Red
        Me.btnReset.Location = New System.Drawing.Point(280, 176)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(106, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Resetkeun"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnNambah
        '
        Me.btnNambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNambah.Location = New System.Drawing.Point(392, 176)
        Me.btnNambah.Name = "btnNambah"
        Me.btnNambah.Size = New System.Drawing.Size(106, 23)
        Me.btnNambah.TabIndex = 4
        Me.btnNambah.Text = "Tambahkeun"
        Me.btnNambah.UseVisualStyleBackColor = False
        '
        'txtIPS
        '
        Me.txtIPS.Location = New System.Drawing.Point(280, 148)
        Me.txtIPS.Name = "txtIPS"
        Me.txtIPS.Size = New System.Drawing.Size(218, 22)
        Me.txtIPS.TabIndex = 5
        Me.txtIPS.Text = "masukkan nilai ip "
        Me.txtIPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIPK
        '
        Me.txtIPK.Location = New System.Drawing.Point(280, 208)
        Me.txtIPK.Name = "txtIPK"
        Me.txtIPK.Size = New System.Drawing.Size(218, 22)
        Me.txtIPK.TabIndex = 6
        Me.txtIPK.Text = "hasil "
        Me.txtIPK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtIPK)
        Me.Controls.Add(Me.txtIPS)
        Me.Controls.Add(Me.btnNambah)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblPredikat)
        Me.Controls.Add(Me.lblIPK)
        Me.Controls.Add(Me.lblIPS)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIPS As Label
    Friend WithEvents lblIPK As Label
    Friend WithEvents lblPredikat As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnNambah As Button
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents txtIPK As TextBox

End Class
