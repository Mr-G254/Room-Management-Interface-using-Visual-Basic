Public Class UserControl1

    Private current_room As Room
    Private base As Form1
    Public Sub New(Room_number As String, ByRef room As Room, base_class As Form1)

        ' This call is required by the designer.
        InitializeComponent()
        Label1.Text = Room_number
        current_room = room
        Label3.Text = " " + room.get_Room_Status()
        base = base_class
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub UserControl1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        base.display_room_details(current_room)

    End Sub

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
