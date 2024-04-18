Public Class Occupants_template
    Public Sub New(person As Occupants)

        ' This call is required by the designer.
        InitializeComponent()
        TextBox1.Text = person.get_name()
        TextBox2.Text = person.get_id()
        TextBox3.Text = person.get_number()
        TextBox4.Text = person.get_mail()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
