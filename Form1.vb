
Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim viewForm As New Form3()
        viewForm.ShowDialog()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.Control AndAlso e.KeyCode = Keys.V Then

            Dim viewForm As New Form2()
            viewForm.ShowDialog()

        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then

            Dim viewForm As New Form3()
            viewForm.ShowDialog()

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim viewForm As New Form2()
        viewForm.ShowDialog()

    End Sub

End Class
