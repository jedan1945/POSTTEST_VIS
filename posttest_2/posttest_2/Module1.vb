Module Module1

    Public daftarJudul(100) As String
    Public daftarGenre(100) As String
    Public jumlahBuku As Integer = 0
    Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)

        If jumlahBuku < daftarJudul.Length Then
            daftarJudul(jumlahBuku) = judul
            daftarGenre(jumlahBuku) = genre
            jumlahBuku += 1
        End If

    End Sub
    Public Sub HapusBuku(ByRef judul As String)

        Dim index As Integer = CariBuku(judul)

        If index = -1 Then
            MessageBox.Show("Buku tidak ditemukan!")
            Exit Sub
        End If

        For i = index To jumlahBuku - 2
            daftarJudul(i) = daftarJudul(i + 1)
            daftarGenre(i) = daftarGenre(i + 1)
        Next

        jumlahBuku -= 1

    End Sub
    Public Function CariBuku(ByVal judul As String) As Integer

        For i = 0 To jumlahBuku - 1
            If daftarJudul(i).ToLower = judul.ToLower Then
                Return i
            End If
        Next

        Return -1

    End Function

End Module