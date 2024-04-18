<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Userdetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        GroupBox1 = New GroupBox()
        Button2 = New Button()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label9 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label10 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(542, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 26)
        Label1.TabIndex = 0
        Label1.Text = "Room Details"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Location = New Point(22, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 22)
        Label2.TabIndex = 1
        Label2.Text = "Room number: 1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 22)
        Label3.TabIndex = 2
        Label3.Text = "Room Status"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Occupied", "Vacant ", "Under maintenance"})
        ComboBox1.Location = New Point(139, 107)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(150, 30)
        ComboBox1.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 22)
        Label4.TabIndex = 7
        Label4.Text = "Capacity"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(139, 151)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 30)
        TextBox1.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1054, 11)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 9
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Location = New Point(570, 47)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(596, 217)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add Occupants"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(455, 167)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 8
        Button2.Text = "Add"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(190, 176)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(150, 30)
        TextBox5.TabIndex = 7
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(190, 135)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(150, 30)
        TextBox4.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(190, 95)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(150, 30)
        TextBox3.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(190, 52)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 30)
        TextBox2.TabIndex = 4
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(19, 179)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 22)
        Label8.TabIndex = 3
        Label8.Text = "Emails"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(19, 138)
        Label7.Name = "Label7"
        Label7.Size = New Size(121, 22)
        Label7.TabIndex = 2
        Label7.Text = "Phone number"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(19, 96)
        Label6.Name = "Label6"
        Label6.Size = New Size(26, 22)
        Label6.TabIndex = 1
        Label6.Text = "Id"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(19, 55)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 22)
        Label5.TabIndex = 0
        Label5.Text = "Name"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(295, 153)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 22)
        Label9.TabIndex = 11
        Label9.Text = "Max(5)"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Location = New Point(3, 320)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1163, 272)
        FlowLayoutPanel1.TabIndex = 12
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.White
        Label10.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(22, 242)
        Label10.Name = "Label10"
        Label10.Size = New Size(160, 25)
        Label10.TabIndex = 13
        Label10.Text = "Occupant details"
        ' 
        ' Userdetails
        ' 
        AutoScaleDimensions = New SizeF(11F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(1178, 594)
        Controls.Add(Label10)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Label9)
        Controls.Add(GroupBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Userdetails"
        Text = "Userdetails"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label10 As Label
End Class
