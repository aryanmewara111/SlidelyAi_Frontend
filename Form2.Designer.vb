﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label6 = New Label()
        Button3 = New Button()
        TextBox6 = New TextBox()
        Button4 = New Button()
        Button5 = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Khaki
        Button1.Location = New Point(278, 397)
        Button1.Name = "Button1"
        Button1.Size = New Size(164, 41)
        Button1.TabIndex = 0
        Button1.Text = "Previous (CTRL+P)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightBlue
        Button2.Location = New Point(483, 397)
        Button2.Name = "Button2"
        Button2.Size = New Size(174, 41)
        Button2.TabIndex = 1
        Button2.Text = "Next (CTRL+N)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(278, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 2
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(278, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 3
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(278, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 4
        Label3.Text = "Phone No"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(278, 237)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 40)
        Label4.TabIndex = 5
        Label4.Text = "Github Link" & vbCrLf & " For Task2" & vbCrLf
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(278, 305)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 40)
        Label5.TabIndex = 6
        Label5.Text = "Stopwatch" & vbCrLf & " time"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(384, 130)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(273, 27)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(384, 181)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(273, 27)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(384, 245)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(273, 27)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(384, 310)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(273, 27)
        TextBox5.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(304, 33)
        Label6.Name = "Label6"
        Label6.Size = New Size(269, 20)
        Label6.TabIndex = 12
        Label6.Text = "Vishal, Slidely Task2 - View Submissions"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.RosyBrown
        Button3.Location = New Point(345, 456)
        Button3.Name = "Button3"
        Button3.Size = New Size(228, 43)
        Button3.TabIndex = 13
        Button3.Text = "Delete Submission (CTRL + D)"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TextBox6
        ' 
        TextBox6.BorderStyle = BorderStyle.FixedSingle
        TextBox6.Location = New Point(662, 26)
        TextBox6.Name = "TextBox6"
        TextBox6.PlaceholderText = "Search by email"
        TextBox6.Size = New Size(177, 27)
        TextBox6.TabIndex = 14
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.LightGreen
        Button4.Location = New Point(345, 348)
        Button4.Name = "Button4"
        Button4.Size = New Size(228, 38)
        Button4.TabIndex = 15
        Button4.Text = "Edit Submission"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(849, 24)
        Button5.Name = "Button5"
        Button5.Size = New Size(64, 29)
        Button5.TabIndex = 16
        Button5.Text = "Search"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(384, 81)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(273, 27)
        TextBox1.TabIndex = 17
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(925, 511)
        Controls.Add(TextBox1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(TextBox6)
        Controls.Add(Button3)
        Controls.Add(Label6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        ForeColor = SystemColors.ActiveCaptionText
        KeyPreview = True
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
