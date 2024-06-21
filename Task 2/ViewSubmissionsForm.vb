Public Class ViewSubmissionsForm
    Private Submissions As New List(Of Submission)()
    Private currentIndex As Integer = 0

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaySubmission(currentIndex)
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If Submissions.Count > 0 AndAlso index >= 0 AndAlso index < Submissions.Count Then
            ' Display submission details
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < Submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub
End Class
