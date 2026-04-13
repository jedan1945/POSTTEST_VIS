Imports MySqlConnector
Imports System.Data

Module DataModule

    Public Function GetAllGundam() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM tbgundam"

        Using conn = GetConnection()
            Using da As New MySqlDataAdapter(query, conn)
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function

    Public Function InsertGundam(kode As String, nama As String, grade As String, harga As Integer) As Boolean
        Dim query As String = "INSERT INTO tbgundam VALUES (@kode,@nama,@grade,@harga)"

        Using conn = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@grade", grade)
                cmd.Parameters.AddWithValue("@harga", harga)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        Return True
    End Function

    Public Function UpdateGundam(kode As String, nama As String, grade As String, harga As Integer) As Boolean
        Dim query As String = "UPDATE tbgundam SET namaGundam=@nama, grade=@grade, harga=@harga WHERE kodeGundam=@kode"

        Using conn = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@grade", grade)
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
        Dim query As String = "SELECT * FROM tbgundam WHERE namaGundam LIKE @key"

        Using conn = GetConnection()
            Using da As New MySqlDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function

End Module