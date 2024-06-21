Imports System.Net.Http
Imports System.Net.Http.Json
Imports System.Text
Imports Newtonsoft.Json
Public Class Form3

    Private ReadOnly httpClient As HttpClient = New HttpClient()
    Private Stopwatch As New Stopwatch()
    Private editingSubmission As Submission
    Private Flag As Boolean = True

    Private Sub UpdateStopwatchDisplay()
        TextBox5.Text = String.Format("{0:hh\:mm\:ss}", Stopwatch.Elapsed)
    End Sub
    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim submission = New With {
        .name = TextBox1.Text,
        .email = TextBox2.Text,
        .phone = TextBox3.Text,
        .github_link = TextBox4.Text,
        .stopwatch_time = TextBox5.Text
        }
        Dim json = JsonConvert.SerializeObject(submission)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        Dim response = Await httpClient.PostAsync("http://localhost:3000/submit", content)
        If response.IsSuccessStatusCode Then
            MessageBox.Show("Submission Saved Successfully")
        Else
            MessageBox.Show("Error: " & response.ReasonPhrase)
        End If

        If Stopwatch.IsRunning Then
            Stopwatch.Stop()
            UpdateStopwatchDisplay()
        End If

        If Flag = False Then
            Dim UpdatedSubmission As New Submission With {
            .name = TextBox1.Text,
            .email = TextBox2.Text,
            .phone = TextBox3.Text,
            .github_link = TextBox4.Text,
            .stopwatch_time = TextBox5.Text
            }
            Await httpClient.PutAsJsonAsync($"http://localhost:3000/update/{editingSubmission.email}", UpdatedSubmission)
        End If
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Stopwatch.IsRunning Then
            Stopwatch.Stop()
            UpdateStopwatchDisplay()
        Else
            Stopwatch.Start()
        End If
    End Sub

    Private Async Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then

            If Stopwatch.IsRunning Then
                Stopwatch.Stop()
            Else
                Stopwatch.Start()
            End If
            UpdateStopwatchDisplay()

        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            Dim submission = New With {
            .name = TextBox1.Text,
            .email = TextBox2.Text,
            .phone = TextBox3.Text,
            .github_link = TextBox4.Text,
            .stopwatch_time = TextBox5.Text
            }

            Dim json = JsonConvert.SerializeObject(submission)
            Dim content = New StringContent(json, Encoding.UTF8, "application/json")

            Dim response = Await httpClient.PostAsync("http://localhost:3000/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission Saved Successfully")
            Else
                MessageBox.Show("Error: " & response.ReasonPhrase)
            End If

            If Stopwatch.IsRunning Then
                Stopwatch.Stop()
                UpdateStopwatchDisplay()
            End If
            If Flag = False Then
                Dim UpdatedSubmission As New Submission With {
                .name = TextBox1.Text,
                .email = TextBox2.Text,
                .phone = TextBox3.Text,
                .github_link = TextBox4.Text,
                .stopwatch_time = TextBox5.Text
                }
                Await httpClient.PutAsJsonAsync($"http://localhost:3000/update/{editingSubmission.email}", UpdatedSubmission)
            End If
            Me.Close()
        End If
    End Sub
    Public Sub LoadSubmission(submission As Submission)
        editingSubmission = submission
        TextBox1.Text = submission.name
        TextBox2.Text = submission.email
        TextBox3.Text = submission.phone
        TextBox4.Text = submission.github_link
        TextBox5.Text = submission.stopwatch_time
        Flag = False
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateStopwatchDisplay()
    End Sub
End Class

Public Class Submission
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github_link As String
    Public Property stopwatch_time As String
End Class