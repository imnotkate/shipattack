Imports MySql.Data.MySqlClient
'leaderboard
Public Class lbForm

    'record structure
    Structure lbData
        Dim name As String
        Dim score As Integer
    End Structure

    Dim lb(10) As lbData

    Private Sub returnBtn_Click(sender As Object, e As EventArgs) Handles returnBtn.Click

        Me.Close()
        'returns player back to main menu
        menuForm.Show()

    End Sub

    Private Sub lbForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'make database connection and read name and score 
        Dim connStr As String = "server=localhost;user=root;password=;database=shipattackdata"
        Dim conn As New MySqlConnection(connStr)
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader
        Dim length As Integer

        'leaderboard label
        Dim lblLeaderboard As New Label
        lblLeaderboard.ForeColor = Color.White
        lblLeaderboard.Font = New Font("Stencil", 50)
        lblLeaderboard.Height = 80
        lblLeaderboard.Width = 800
        lblLeaderboard.Location = New Point(170, 20)
        lblLeaderboard.Text = "Leaderboard"
        Me.Controls.Add(lblLeaderboard)

        Try
            'open connection
            conn.Open()
        Catch
            'error message
            MsgBox("Leaderboard currently unavailable")
        End Try

        Try
            'SQL query
            cmd = New MySqlCommand("USE shipattackdata; SELECT name, score FROM leaderboard;")
            cmd.Connection = conn
            reader = cmd.ExecuteReader()
            'read name and score
            Do While reader.Read()
                length += 1
                lb(length).name = reader.GetString("name")
                lb(length).score = reader.GetInt32("score")
                If length = 10 Then
                    Exit Do
                End If
            Loop

        Catch
            conn.Close()
        End Try

        'insertion sort for leaderboard
        Dim position As Integer
        Dim currentVal As Integer
        Dim currentName As String
        For number = 1 To lb.Length - 1
            position = number
            currentVal = lb(number).score
            currentName = lb(number).name
            While (position >= 1 AndAlso lb(position - 1).score < currentVal)
                lb(position).score = lb(position - 1).score
                lb(position).name = lb(position - 1).name
                position -= 1
            End While
            lb(position).score = currentVal
            lb(position).name = currentName
        Next


        'display name and score
        For number = 0 To length - 1
            RichTextBox1.AppendText(number + 1 & ". " & lb(number).name & vbNewLine)
            RichTextBox2.AppendText(lb(number).score & vbNewLine)
        Next

        'close connection
        conn.Close()
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click

        'validates clear button
        If MsgBox("Are you sure you want to clear the leaderboard?", MsgBoxStyle.YesNo) = vbYes Then
            'make database connection and clear leaderboard
            Dim connStr As String = "server=localhost;user=root;password=;database=shipattackdata"
            Dim conn As New MySqlConnection(connStr)
            Dim cmd As MySqlCommand

            Try
                'open connection
                conn.Open()
            Catch
                'error message
                MsgBox("Unable to connect")
            End Try

            Try
                'SQL query
                cmd = New MySqlCommand("USE shipattackdata; DELETE FROM leaderboard;")
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            Catch
                conn.Close()
            End Try

            'close connection
            conn.Close()
            Me.Close()
            'returns player back to main menu
            menuForm.Show()
        End If
    End Sub
End Class