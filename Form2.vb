Imports System.Net.Http
Imports Newtonsoft.Json
Public Class Form2
    Private ReadOnly httpClient As HttpClient = New HttpClient()
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0
    Private Async Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Await LoadSubmissions()
        DisplayCurrentSubmission()
    End Sub

    Private Async Function LoadSubmissions() As Task
        Dim response = Await httpClient.GetAsync("http://localhost:3000/read")
        If response.IsSuccessStatusCode Then
            Dim result = Await response.Content.ReadAsStringAsync()
            submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(result)
        Else
            MessageBox.Show("Error fetching submissions: " & response.ReasonPhrase)
        End If
    End Function

    Private Sub DisplayCurrentSubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim currentSubmission = submissions(currentIndex)
            TextBox1.Text = currentSubmission.name
            TextBox2.Text = currentSubmission.email
            TextBox3.Text = currentSubmission.phone
            TextBox4.Text = currentSubmission.github_link
            TextBox5.Text = currentSubmission.stopwatch_time
        Else
            clearTextBoxes()
        End If
    End Sub
    Private Sub ClearTextBoxes()
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty
    End Sub
    Private Async Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
                currentIndex -= 1
                If currentIndex < 0 Then
                    currentIndex = submissions.Count - 1
                End If
                DisplayCurrentSubmission()
            End If

        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
                currentIndex += 1
                If currentIndex >= submissions.Count Then
                    currentIndex = 0
                End If
                DisplayCurrentSubmission()
            End If
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            Dim emailToDelete As String = submissions(currentIndex).email
            Await httpClient.DeleteAsync($"http://localhost:3000/delete/{emailToDelete}")
            Await LoadSubmissions()
            If currentIndex < submissions.Count - 1 Then
                currentIndex += 1
            Else
                currentIndex = 0
            End If
            Await LoadSubmissions()
            DisplayCurrentSubmission()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            currentIndex -= 1
            If currentIndex < 0 Then
                currentIndex = submissions.Count - 1
            End If
            DisplayCurrentSubmission()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            currentIndex += 1
            If currentIndex >= submissions.Count Then
                currentIndex = 0
            End If
            DisplayCurrentSubmission()
        End If
    End Sub


    Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim emailToDelete As String = submissions(currentIndex).email
        Await httpClient.DeleteAsync($"http://localhost:3000/delete/{emailToDelete}")
        Await LoadSubmissions()
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1

        Else
            currentIndex = 0
        End If
        Await LoadSubmissions()
        DisplayCurrentSubmission()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.LoadSubmission(submissions(currentIndex))
        Form3.Show()
    End Sub

    Private Async Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim emailToSearch As String = TextBox6.Text
        Dim response As HttpResponseMessage = Await httpClient.GetAsync($"http://localhost:3000/submission/{emailToSearch}")
        If response.IsSuccessStatusCode Then
            Dim responseData As String = Await response.Content.ReadAsStringAsync()
            Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(responseData)
            TextBox1.Text = submission.name
            TextBox2.Text = submission.email
            TextBox3.Text = submission.phone
            TextBox4.Text = submission.github_link
            TextBox5.Text = submission.stopwatch_time
        Else
            MessageBox.Show("Submission not found.")
        End If
    End Sub
End Class