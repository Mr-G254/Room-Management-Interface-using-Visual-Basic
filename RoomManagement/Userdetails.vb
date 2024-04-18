Public Class Userdetails
    Private current_room As Room
    Private app_panel As Panel
    Private all_occupants(5) As Occupants
    Private index As Integer
    Public Sub New(room As Room, panel As Panel)

        ' This call is required by the designer.
        InitializeComponent()
        current_room = room
        Label2.Text = "Room number: " + Convert.ToString(room.get_Room_Number)
        ComboBox1.SelectedItem = room.get_Room_Status()
        TextBox1.Text = Convert.ToString(room.get_Number_of_Beds)
        app_panel = panel

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        app_panel.Hide()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim name As String = TextBox2.Text
        Dim id As String = TextBox3.Text
        Dim number As String = TextBox4.Text
        Dim email As String = TextBox5.Text

        If name.Length = 0 Or id.Length = 0 Or email.Length = 0 Or number.Length = 0 Then
            MessageBox.Show("Ensure no field is blank")

        ElseIf index = 5 Then
            MessageBox.Show("Maximum occupants")

        Else
            Dim person As Occupants = New Occupants(name, id, email, number)
            all_occupants(index) = person
            index = index + 1
            Dim details As Occupants_template = New Occupants_template(person)
            FlowLayoutPanel1.Controls.Add(details)

        End If

    End Sub


End Class