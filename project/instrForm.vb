'how to play 
Public Class instrForm
    Private Sub returnBtn_Click(sender As Object, e As EventArgs) Handles returnBtn.Click

        Me.Close()
        'returns player back to main menu
        menuForm.Show()

    End Sub
End Class