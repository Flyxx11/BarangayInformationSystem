
Imports MySql.Data.MySqlClient

Module Connection
    Public string_connection As String = "server=localhost;port=3306;Database=barangayinformationsystem;username=root;password="
    Public con As New MySqlConnection(string_connection)
    Public command As MySqlCommand
    Public newRecordID As Integer

    Public Sub connect(mysql As String)
        con.Open()
        command = New MySqlCommand(mysql, con)
        MessageBox.Show("Success")
        con.Close()
    End Sub
    Public Sub recordID()
        Dim reader As MySqlDataReader
        con.Open()
        Dim retrieveID As String = " Select MAX(idRecord) from tblrecord"

        Try
            command = New MySqlCommand(retrieveID, con)
            reader = command.ExecuteReader()

            While reader.Read
                newRecordID = reader.GetInt32("idRecord")
            End While
            con.Close()
            con.Dispose()
        Catch ex As Exception
            MessageBox.Show("Something went wrong ")
        End Try

    End Sub

End Module
