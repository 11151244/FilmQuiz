Public Class frmQuestion1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer1.CheckedChanged

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If btnAnswer1.Checked Then
            PlayerScore = PlayerScore + 1

        End If

        frmQuestion2.Show()

        Me.Hide()
    End Sub
End Class