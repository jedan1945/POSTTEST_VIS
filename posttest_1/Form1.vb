Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        totalIP = 0
        jumlahSemester = 0

        txtIPS.Text = ""
        txtIPK.Text = ""
        lblPredikat.Text = ""

    End Sub

    Private Sub btnNambah_Click_1(sender As Object, e As EventArgs) Handles btnNambah.Click
        Dim ip As Double
        Dim ipk As Double
        ip = CDbl(txtIPS.Text)

        totalIP = totalIP + ip
        jumlahSemester = jumlahSemester + 1
        ipk = totalIP / jumlahSemester

        txtIPK.Text = ipk.ToString("0.00")
        If ipk >= 2.0 And ipk <= 2.75 Then
            lblPredikat.Text = "Cukup"
        ElseIf ipk >= 2.76 And ipk <= 3.0 Then
            lblPredikat.Text = "Memuaskan"
        ElseIf ipk >= 3.01 Then
            lblPredikat.Text = "Sangat Memuaskan"
        Else
            lblPredikat.Text = "Tidak Valid"
        End If
        txtIPS.Text = ""
    End Sub
End Class