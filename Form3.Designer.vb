<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        components = New ComponentModel.Container()
        Label6 = New Label()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        TextBox5 = New TextBox()
        Timer1 = New Timer(components)
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(242, 33)
        Label6.Name = "Label6"
        Label6.Size = New Size(280, 20)
        Label6.TabIndex = 25
        Label6.Text = "Vishal, Slidely Task2 - Create Submissions"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(322, 245)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(273, 27)
        TextBox4.TabIndex = 23
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(322, 181)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(273, 27)
        TextBox3.TabIndex = 22
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(322, 130)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(273, 27)
        TextBox2.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(216, 237)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 40)
        Label4.TabIndex = 18
        Label4.Text = "Github Link" & vbCrLf & " For Task2" & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(216, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 17
        Label3.Text = "Phone No"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(216, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 16
        Label2.Text = "Email"
        ' 
        ' Label1
        ' 
        Label1.AccessibleName = "txtName"
        Label1.AutoSize = True
        Label1.Location = New Point(216, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 15
        Label1.Text = "Name"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightBlue
        Button2.Location = New Point(216, 383)
        Button2.Name = "Button2"
        Button2.Size = New Size(379, 34)
        Button2.TabIndex = 14
        Button2.Text = "Submit (CTRL + S)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Khaki
        Button1.Location = New Point(216, 305)
        Button1.Name = "Button1"
        Button1.Size = New Size(223, 29)
        Button1.TabIndex = 13
        Button1.Text = "TOGGLE STOPWATCH (CTRL+T)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(461, 307)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(134, 27)
        TextBox5.TabIndex = 27
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(322, 78)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(273, 27)
        TextBox1.TabIndex = 28
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox1)
        Controls.Add(TextBox5)
        Controls.Add(Label6)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        KeyPreview = True
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
End Class
