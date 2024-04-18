<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Button1 = New Button()
        GroupBox1 = New GroupBox()
        TextBox2 = New TextBox()
        Label4 = New Label()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Panel1 = New Panel()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(352, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(359, 32)
        Label1.TabIndex = 0
        Label1.Text = "Room Management Interface"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BackColor = Color.WhiteSmoke
        FlowLayoutPanel1.Location = New Point(12, 75)
        FlowLayoutPanel1.Margin = New Padding(3, 2, 3, 2)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(870, 508)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(980, 510)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(160, 45)
        Button1.TabIndex = 2
        Button1.Text = "Add a room"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(935, 75)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(231, 411)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "New Room details"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(110, 168)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(110, 30)
        TextBox2.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(5, 171)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 22)
        Label4.TabIndex = 4
        Label4.Text = "No. of beds"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Occupied", "Vacant ", "Under maintenance"})
        ComboBox1.Location = New Point(110, 118)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(110, 30)
        ComboBox1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(5, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 22)
        Label3.TabIndex = 2
        Label3.Text = "Rm status"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(110, 67)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(110, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(5, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 22)
        Label2.TabIndex = 0
        Label2.Text = "Rm number"
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1181, 583)
        Panel1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(1178, 594)
        Controls.Add(Panel1)
        Controls.Add(GroupBox1)
        Controls.Add(Button1)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Label1)
        Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel1 As Panel

End Class
