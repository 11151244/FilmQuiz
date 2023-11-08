Public Class frmQuestion3
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If btnAnswer1.Checked Then
            PlayerScore = PlayerScore + 1
        End If

        frmHighScore.Show()
        frmHighScore.doScore()


    End Sub
End Class