Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlConnection
Public Class AddUser
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PeerEvaluationManager.peer_data.DataSource = addPeer()

    End Sub

    Private Function addPeer() As DataTable


        Dim dtPeers As New DataTable
        Dim connectionString As String
        connectionString = "server=localhost; user id=root; password=root; database=peer_evaluation_manager"
        Dim connection As New MySqlConnection
        Dim command As New MySqlCommand

        Dim index As String
        Dim name As String
        Dim subject As String
        Dim lesson As String
        Dim status As String
        Dim strDate As String


        index = peerIndexNo.Text
        name = peerName.Text
        subject = peerSubject.Text
        lesson = peerLesson.Text
        status = peerStatus.Text
        strDate = peerDate.Text



        connection.ConnectionString = connectionString

        Try
            connection.Open()
            command.CommandText = "insert into peer_evaluation_manager.peer_data values(@date, @index_no,@name,@subject,@lesson,@status);"
            command.Parameters.AddWithValue("@index_no", index)
            command.Parameters.AddWithValue("@name", name)
            command.Parameters.AddWithValue("@subject", subject)
            command.Parameters.AddWithValue("@lesson", lesson)
            command.Parameters.AddWithValue("@status", status)
            command.Parameters.AddWithValue("@date", strDate)

            command.Connection = connection
            command.ExecuteNonQuery()
            connection.Close()

        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            connection.Dispose()
        End Try

        peerIndexNo.Text = ""
        peerName.Text = ""
        peerSubject.Text = ""
        peerLesson.Text = ""
        peerStatus.Text = ""

        connection = New MySqlConnection
        command = New MySqlCommand

        connection.ConnectionString = connectionString
        Try

            connection.Open()
            command.CommandText = "SELECT * FROM peer_data"
            command.Connection = connection
            Dim dataReader As MySqlDataReader
            dataReader = command.ExecuteReader()

            dtPeers.Load(dataReader)
            connection.Close()

        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            connection.Dispose()
        End Try


        Return dtPeers

    End Function

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles peerDate.ValueChanged

    End Sub
End Class