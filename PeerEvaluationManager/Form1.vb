Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlConnection
Public Class PeerEvaluationManager



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles peer_data.CellContentClick

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles goBtnIndex.Click
        peer_data.DataSource() = getPeerListByIndex(indexNoText.Text)


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim addUser As AddUser
        addUser = New AddUser()
        addUser.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        peer_data.DataSource = getPeerList()




    End Sub

    Private Function getPeerList() As DataTable
        Dim dtPeers As New DataTable
        Dim connectionString As String
        connectionString = "server=localhost; user id=root; password=root; database=peer_evaluation_manager"
        Dim connection As New MySqlConnection
        Dim command As New MySqlCommand
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

    Private Function getPeerListByIndex(indexNo As String) As DataTable
        Dim dtPeers As New DataTable
        Dim connectionString As String
        connectionString = "server=localhost; user id=root; password=root; database=peer_evaluation_manager"
        Dim connection As New MySqlConnection
        Dim command As New MySqlCommand
        connection.ConnectionString = connectionString
        Try

            connection.Open()
            command.CommandText = "SELECT * FROM peer_data where Index_Number = @index;"
            command.Parameters.AddWithValue("@index", indexNo)
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



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        peer_data.DataSource = getPeerList()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        peer_data.DataSource() = getPeerListByDate(datePicker.Text)
    End Sub

    Private Function getPeerListByDate(peerDate As String) As DataTable
        Dim dtPeers As New DataTable
        Dim connectionString As String
        connectionString = "server=localhost; user id=root; password=root; database=peer_evaluation_manager"
        Dim connection As New MySqlConnection
        Dim command As New MySqlCommand
        connection.ConnectionString = connectionString
        Try

            connection.Open()
            command.CommandText = "SELECT * FROM peer_data where Date = @date;"
            command.Parameters.AddWithValue("@date", peerDate)
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

End Class
