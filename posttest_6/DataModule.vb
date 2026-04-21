Imports MySqlConnector
Imports System.Data

Module DataModule
    Public Function GetAllGundam() As DataTable
        Dim dt As New DataTable()

        Dim query As String =
            "SELECT g.kodeGundam, k.namaKategori, g.namaGundam, g.harga " &
            "FROM tbgundam g " &
            "INNER JOIN tbkategori k ON g.kodeKategori = k.kodeKategori"

        Using conn = GetConnection()
            Using da As New MySqlDataAdapter(query, conn)
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function
    Public Function GetAllKategori() As DataTable
        Dim dt As New DataTable()

        Using conn = GetConnection()
            Using da As New MySqlDataAdapter("SELECT * FROM tbkategori", conn)
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function
    Public Function InsertGundam(kode As String, kategori As String, nama As String, harga As Integer) As Boolean
        Dim query As String =
            "INSERT INTO tbgundam VALUES (@kode,@kategori,@nama,@harga)"

        Using conn = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.Parameters.AddWithValue("@kategori", kategori)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@harga", harga)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        Return True
    End Function
    Public Function UpdateGundam(kode As String, kategori As String, nama As String, harga As Integer) As Boolean
        Dim query As String =
            "UPDATE tbgundam SET kodeKategori=@kategori, namaGundam=@nama, harga=@harga WHERE kodeGundam=@kode"

        Using conn = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.Parameters.AddWithValue("@kategori", kategori)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@harga", harga)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function
    Public Function DeleteGundam(kode As String) As Boolean
        Dim query As String = "DELETE FROM tbgundam WHERE kodeGundam=@kode"

        Using conn = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kode", kode)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function
    Public Function SearchGundam(keyword As String) As DataTable
        Dim dt As New DataTable()

        Dim query As String =
            "SELECT g.kodeGundam, k.namaKategori, g.namaGundam, g.harga " &
            "FROM tbgundam g " &
            "INNER JOIN tbkategori k ON g.kodeKategori = k.kodeKategori " &
            "WHERE g.namaGundam LIKE @key"

        Using conn = GetConnection()
            Using da As New MySqlDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function

End Module