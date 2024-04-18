Imports System.Data.OleDb
Public Class Form1
    Private room_count As Int32 = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim room As Room = New Room(room_count, ComboBox1.Text, Convert.ToInt32(TextBox2.Text))
            Dim room_widget As UserControl1 = New UserControl1(Convert.ToString(room_count), room, Me)


            FlowLayoutPanel1.Controls.Add(room_widget)

            room_count = room_count + 1
            TextBox1.Text = Convert.ToString(room_count)
            ComboBox1.SelectedIndex = 1
            TextBox2.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Hide()
        room_count = room_count + 1
        TextBox1.Text = Convert.ToString(room_count)
        ComboBox1.SelectedIndex = 1
    End Sub

    Public Sub display_room_details(room As Room)
        Panel1.Controls.Clear()
        Dim room_details As Userdetails = New Userdetails(room, Panel1)
        room_details.TopLevel = False
        room_details.FormBorderStyle = FormBorderStyle.None
        room_details.Dock = DockStyle.Fill
        Panel1.Controls.Add(room_details)
        room_details.Show()
        Panel1.Show()

    End Sub

    Public Sub load_rooms_from_DB()
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gikuh\Downloads\Projects\Visual Basic\RoomManagement\RoomManagement\Db\RoomManagement DataBase.accdb;"
        Dim connection As New OleDbConnection(connectionString)

        Try
            connection.Open()

            ' Execute a SQL query to select data from the table
            Dim query As String = "SELECT * FROM RoomManagement"
            Dim command As New OleDbCommand(query, connection)

            Dim reader As OleDbDataReader = command.ExecuteReader()

            ' Check if there are rows in the result set
            If reader.HasRows Then
                ' Iterate through the rows and retrieve data
                While reader.Read()
                    ' Access data using column names or indices
                    Dim cap As String = reader("Capacity").ToString()
                    Dim stat As Integer = Convert.ToInt32(reader("Status"))
                    ' ... access other columns as needed

                    Try
                        Dim room As Room = New Room(room_count, ComboBox1.Text, Convert.ToInt32(TextBox2.Text))
                        Dim room_widget As UserControl1 = New UserControl1(Convert.ToString(room_count), room, Me)


                        FlowLayoutPanel1.Controls.Add(room_widget)

                        room_count = room_count + 1
                        TextBox1.Text = Convert.ToString(room_count)
                        ComboBox1.SelectedIndex = 1
                        TextBox2.Text = ""

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                End While
            Else
                MessageBox.Show("No data found in the table.")
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        Finally
            connection.Close()
        End Try
    End Sub
End Class
