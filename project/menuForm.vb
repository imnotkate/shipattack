'main menu 
Public Class menuForm
    Private Sub startBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click

        Me.Hide()
        'shows game form
      gameForm.show

    End Sub

    Private Sub leaderboardBtn_Click(sender As Object, e As EventArgs) Handles leaderboardBtn.Click

        Me.Hide()
        'shows leaderboard form
        lbForm.Show()

    End Sub

    Private Sub instructionsBtn_Click(sender As Object, e As EventArgs) Handles instructionsBtn.Click

        Me.Hide()
        'shows instructions form
        instrForm.Show()

    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        'validates exit button
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo) = vbYes Then
            'closes program
            Application.Exit()
        End If

    End Sub
End Class


