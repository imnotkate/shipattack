Imports MySql.Data.MySqlClient
'game
Public Class gameForm

    'Grids
    Dim computerGrid(10, 10) As Button
    Dim userGrid(10, 10) As Button

    'Player boats
    Dim uBoat1(4) As PictureBox
    Dim uBoat2(3) As PictureBox
    Dim uBoat3(2) As PictureBox
    Dim uBoat4(2) As PictureBox
    Dim uBoat5(1) As PictureBox

    'Computer boats
    Dim cBoat1(4) As Button
    Dim cBoat2(3) As Button
    Dim cBoat3(2) As Button
    Dim cBoat4(2) As Button
    Dim cBoat5(1) As Button

    Dim playerName As String
    Dim scoreLbl As New Label
    Dim uScore As Integer
    Dim cScore As Integer

    Private Sub returnBtn_Click(sender As Object, e As EventArgs) Handles returnBtn.Click
        'return button validation
        If MsgBox("Return to main menu?", MsgBoxStyle.YesNo) = vbYes Then
            Me.Close()
            'returns player back to main menu
            menuForm.Show()
        End If

    End Sub

    Private Sub enterBtn_Click(sender As Object, e As EventArgs) Handles enterBtn.Click
        'enter button validation
        If MsgBox("Start game?", MsgBoxStyle.YesNo) = vbYes Then
            'player enters name
            playerName = txtbox.Text

            'Validation of player name
            If Len(playerName) > 10 Then
                'error message if name is more than 10 characters
                MsgBox("Please enter a name under 11 characters")

            ElseIf playerName = "" Then
                'error message if a name hasn't been entered
                MsgBox("Please enter a name")

            Else
                playerName = txtbox.Text
                'hide panel
                namePnl.Hide()
                'name label
                Dim nameLbl As New Label
                nameLbl.ForeColor = Color.Gray
                nameLbl.Font = New Font("Stencil", 20)
                nameLbl.Height = 32
                nameLbl.Width = 500
                nameLbl.Location = New Point(6, 4)
                nameLbl.Text = "NAME: " & playerName
                Me.Controls.Add(nameLbl)

                'if name is valid start game 
                startgame(scoreLbl, uScore)
            End If
        End If

    End Sub

    Sub startgame(ByRef scoreLbl As Label, ByRef uScore As Integer)

        Dim row As Integer
        Dim col As Integer

        Dim available As Boolean
        Dim occgrid(10, 10) As Boolean

        Dim compavailable As Boolean
        Dim compoccgrid(10, 10) As Boolean

        'score label
        scoreLbl.ForeColor = Color.Gray
        scoreLbl.Font = New Font("Stencil", 20)
        scoreLbl.Height = 32
        scoreLbl.Width = 200
        scoreLbl.Location = New Point(670, 4)
        scoreLbl.Text = "SCORE: " & uScore
        Me.Controls.Add(scoreLbl)

        'Player boats and validation
        Do
            'choose random row and column
            row = Int((10 * Rnd()) + 1)
            col = Int((7 * Rnd()) + 1)
            For number = 0 To 3
                If occgrid(row, number + col) = False Then
                    'make grid occupied
                    occgrid(row, number + col) = True
                    'if last part of ship can be placed
                    If occgrid(row, 3 + col) = True Then
                        'ship can be placed 
                        available = True
                    End If
                Else
                    'ship can't be placed
                    available = False
                    'make grid unoccupied
                    For i = 0 To 3
                        occgrid(row, i + col) = False
                    Next
                    Exit For
                End If
            Next
            'loop until ship can be placed
        Loop Until available = True
        'place ship
        If available = True Then
            For number = 0 To 3
                uBoat2(number) = New PictureBox
                uBoat2(number).Size = New Size(33, 33)
                uBoat2(number).BackColor = Color.Black
                Me.Controls.Add(uBoat2(number))
                uBoat2(number).Location = New Point(15 + (33 * row), 40 + (33 * (number + col)))
            Next
        End If

        Do
            'choose random row and column
            row = Int((10 * Rnd()) + 1)
            col = Int((8 * Rnd()) + 1)
            For number = 0 To 2
                If occgrid(row, number + col) = False Then
                    'make grid occupied
                    occgrid(row, number + col) = True
                    'if last part of ship can be placed
                    If occgrid(row, 2 + col) = True Then
                        'ship can be placed
                        available = True
                    End If
                Else
                    'ship cant be placed
                    available = False
                    'make grid unoccupied
                    For i = 0 To 2
                        occgrid(row, i + col) = False
                    Next
                    Exit For
                End If
            Next
            'loop until ship can be placed
        Loop Until available = True
        'place ship
        If available = True Then
            For number = 0 To 2
                uBoat4(number) = New PictureBox
                uBoat4(number).Size = New Size(33, 33)
                uBoat4(number).BackColor = Color.Black
                Me.Controls.Add(uBoat4(number))
                uBoat4(number).Location = New Point(15 + (33 * row), 40 + (33 * (number + col)))
            Next
        End If

        Do
            'choose random row and column
            row = Int((6 * Rnd()) + 1)
            col = Int((10 * Rnd()) + 1)
            For number = 0 To 4
                If occgrid(number + row, col) = False Then
                    'make grid occupied
                    occgrid(number + row, col) = True
                    'if last part of ship can be placed
                    If occgrid(4 + row, col) = True Then
                        'ship can be placed
                        available = True
                    End If
                Else
                    'ship cant be placed
                    available = False
                    'make grid unoccupied
                    For i = 0 To 4
                        occgrid(i + row, col) = False
                    Next
                    Exit For
                End If
            Next
            'loop until ship can be placed
        Loop Until available = True
        'place ship
        If available = True Then
            For number = 0 To 4
                uBoat1(number) = New PictureBox
                uBoat1(number).Size = New Size(33, 33)
                uBoat1(number).BackColor = Color.Black
                Me.Controls.Add(uBoat1(number))
                uBoat1(number).Location = New Point(15 + (33 * (number + row)), 40 + (33 * col))
            Next
        End If

        Do
            'choose random row and column
            row = Int((8 * Rnd()) + 1)
            col = Int((10 * Rnd()) + 1)
            For number = 0 To 2
                If occgrid(number + row, col) = False Then
                    'make grid occupied
                    occgrid(number + row, col) = True
                    'if last part of ship can be placed 
                    If occgrid(2 + row, col) = True Then
                        'ship can be placed
                        available = True
                    End If
                Else
                    'ship cant be placed
                    available = False
                    'make grid unoccupied 
                    For i = 0 To 2
                        occgrid(i + row, col) = False
                    Next
                    Exit For
                End If
            Next
            'loop until ship can be placed
        Loop Until available = True
        'place ship 
        If available = True Then
            For number = 0 To 2
                uBoat3(number) = New PictureBox
                uBoat3(number).Size = New Size(33, 33)
                uBoat3(number).BackColor = Color.Black
                Me.Controls.Add(uBoat3(number))
                uBoat3(number).Location = New Point(15 + (33 * (number + row)), 40 + (33 * col))
            Next
        End If

        Do
            'choose random row and column
            row = Int((9 * Rnd()) + 1)
            col = Int((10 * Rnd()) + 1)
            For number = 0 To 1
                If occgrid(number + row, col) = False Then
                    'make grid occupied
                    occgrid(number + row, col) = True
                    'if last part of ship can be placed
                    If occgrid(1 + row, col) = True Then
                        'ship can be placed 
                        available = True
                    End If
                Else
                    'ship cant be placed
                    available = False
                    'make grid unoccupied
                    For i = 0 To 1
                        occgrid(i + row, col) = False
                    Next
                    Exit For
                End If
            Next
            'loop until ship can be placed
        Loop Until available = True
        'place ship 
        If available = True Then
            For number = 0 To 1
                uBoat5(number) = New PictureBox
                uBoat5(number).Size = New Size(33, 33)
                uBoat5(number).BackColor = Color.Black
                Me.Controls.Add(uBoat5(number))
                uBoat5(number).Location = New Point(15 + (33 * (number + row)), 40 + (33 * col))
            Next
        End If

        'user grid
        For outer = 1 To 10
            For inner = 1 To 10
                userGrid(inner, outer) = New Button
                userGrid(inner, outer).Size = New Size(33, 33)
                userGrid(inner, outer).Location = New Point(15 + (inner * 33), 40 + (outer * 33))
                userGrid(inner, outer).FlatStyle = FlatStyle.Flat
                userGrid(inner, outer).BackColor = Color.White
                Me.Controls.Add(userGrid(inner, outer))
                Controls.Add(New PictureBox())
            Next
        Next

        'Y labels
        Dim userY As Integer = 75
        Dim lbluserY(10) As Label
        For y = 1 To 10
            lbluserY(y) = New Label
            lbluserY(y).ForeColor = Color.Silver
            lbluserY(y).Font = New Font("Stencil", 16)
            lbluserY(y).Height = 30
            lbluserY(y).Width = 40
            lbluserY(y).Location = New Point(10, userY)
            lbluserY(y).TextAlign = ContentAlignment.MiddleCenter
            lbluserY(y).Text = y
            userY += 33
            Me.Controls.Add(lbluserY(y))
        Next

        'X labels
        Dim userX As Integer = 50
        Dim lbluserx(10) As Label
        For x = 1 To 10
            lbluserx(x) = New Label
            lbluserx(x).ForeColor = Color.Silver
            lbluserx(x).Font = New Font("Stencil", 16)
            lbluserx(x).Height = 30
            lbluserx(x).Width = 30
            lbluserx(x).Location = New Point(userX, 45)
            lbluserx(x).TextAlign = ContentAlignment.MiddleCenter
            lbluserx(x).Text = Chr(65 + x - 1)
            userX += 33
            Me.Controls.Add(lbluserx(x))
        Next

        'user grid label
        Dim userLbl As New Label
        userLbl.ForeColor = Color.Gray
        userLbl.Font = New Font("Stencil", 14)
        userLbl.Height = 32
        userLbl.Width = 200
        userLbl.Location = New Point(160, 410)
        userLbl.Text = "Your Grid"
        Me.Controls.Add(userLbl)

        'Computer boats and validation
        Do
            'choose random row and column
            row = Int((10 * Rnd()) + 1)
            col = Int((7 * Rnd()) + 1)
            For number = 0 To 3
                If compoccgrid(row, number + col) = False Then
                    'make grid occupied 
                    compoccgrid(row, number + col) = True
                    'if last part of ship can be placed
                    If compoccgrid(row, 3 + col) = True Then
                        'ship can be placed
                        compavailable = True
                    End If
                Else
                    'ship cant be placed
                    compavailable = False
                    'make grid unoccupied
                    For i = 0 To 3
                        compoccgrid(row, i + col) = False
                    Next
                    Exit For
                End If
            Next
            'loop until ship can be placed 
        Loop Until compavailable = True
        'place ship
        If compavailable = True Then
            For number = 0 To 3
                cBoat2(number) = New Button
                cBoat2(number).Size = New Size(33, 33)
                cBoat2(number).BackColor = Color.White
                cBoat2(number).FlatStyle = FlatStyle.Flat
                Me.Controls.Add(cBoat2(number))
                cBoat2(number).Location = New Point(470 + (33 * row), 40 + (33 * (number + col)))
                AddHandler cBoat2(number).Click, AddressOf cBoat_Click
            Next
        End If

        Do
            'chose random row and column
            row = Int((10 * Rnd()) + 1)
            col = Int((8 * Rnd()) + 1)
            For number = 0 To 2
                If compoccgrid(row, number + col) = False Then
                    'make grid occupied
                    compoccgrid(row, number + col) = True
                    'if last part of ship can be placed
                    If compoccgrid(row, 2 + col) = True Then
                        'ship can be placed
                        compavailable = True
                    End If
                Else
                    'ship cant be placed
                    compavailable = False
                    'make grid unoccupied
                    For i = 0 To 2
                        compoccgrid(row, i + col) = False
                    Next
                    Exit For
                End If
            Next
            'loop until ship can be placed
        Loop Until compavailable = True
        'place ship
        If compavailable = True Then
            For number = 0 To 2
                cBoat4(number) = New Button
                cBoat4(number).Size = New Size(33, 33)
                cBoat4(number).BackColor = Color.White
                cBoat4(number).FlatStyle = FlatStyle.Flat
                Me.Controls.Add(cBoat4(number))
                cBoat4(number).Location = New Point(470 + (33 * row), 40 + (33 * (number + col)))
                AddHandler cBoat4(number).Click, AddressOf cBoat_Click
            Next
        End If

        Do
            'chose random row and col
            row = Int((6 * Rnd()) + 1)
            col = Int((10 * Rnd()) + 1)
            For number = 0 To 4
                If compoccgrid(number + row, col) = False Then
                    'make grid occupied 
                    compoccgrid(number + row, col) = True
                    'if last part of ship can be placed
                    If compoccgrid(4 + row, col) = True Then
                        'ship can be placed
                        compavailable = True
                    End If
                Else
                    'ship cant be placed
                    compavailable = False
                    'make grid unoccupied
                    For i = 0 To 4
                        compoccgrid(i + row, col) = False
                    Next
                    Exit For
                End If
            Next
            'loop until ship can be placed
        Loop Until compavailable = True
        'place ship
        If compavailable = True Then
            For number = 0 To 4
                cBoat1(number) = New Button
                cBoat1(number).Size = New Size(33, 33)
                cBoat1(number).BackColor = Color.White
                cBoat1(number).FlatStyle = FlatStyle.Flat
                Me.Controls.Add(cBoat1(number))
                cBoat1(number).Location = New Point(470 + (33 * (number + row)), 40 + (33 * col))
                AddHandler cBoat1(number).Click, AddressOf cBoat_Click
            Next
        End If

        Do
            'chose random row and col
            row = Int((8 * Rnd()) + 1)
            col = Int((10 * Rnd()) + 1)
            For number = 0 To 2
                If compoccgrid(number + row, col) = False Then
                    'make grid occupied
                    compoccgrid(number + row, col) = True
                    'if last part of ship can be placed
                    If compoccgrid(2 + row, col) = True Then
                        'ship can be placed
                        compavailable = True
                    End If
                Else
                    'ship cant be placed
                    compavailable = False
                    'make grid unoccupied
                    For i = 0 To 2
                        compoccgrid(i + row, col) = False
                    Next
                    Exit For
                End If
            Next
            'loop until ship can be placed
        Loop Until compavailable = True
        'place ship
        If compavailable = True Then
            For number = 0 To 2
                cBoat3(number) = New Button
                cBoat3(number).Size = New Size(33, 33)
                cBoat3(number).BackColor = Color.White
                cBoat3(number).FlatStyle = FlatStyle.Flat
                Me.Controls.Add(cBoat3(number))
                cBoat3(number).Location = New Point(470 + (33 * (number + row)), 40 + (33 * col))
                AddHandler cBoat3(number).Click, AddressOf cBoat_Click
            Next
        End If

        Do
            'chose random row and col
            row = Int((9 * Rnd()) + 1)
            col = Int((10 * Rnd()) + 1)
            For number = 0 To 1
                If compoccgrid(number + row, col) = False Then
                    'make grid occupied
                    compoccgrid(number + row, col) = True
                    'if last part of ship can be placed
                    If compoccgrid(1 + row, col) = True Then
                        'ship can be placed
                        compavailable = True
                    End If
                Else
                    'ship cant be placed
                    compavailable = False
                    'make grid unoccupied
                    For i = 0 To 1
                        compoccgrid(i + row, col) = False
                    Next
                    Exit For
                End If
            Next
            'loop until ship can be placed
        Loop Until compavailable = True
        'place ship
        If compavailable = True Then
            For number = 0 To 1
                cBoat5(number) = New Button
                cBoat5(number).Size = New Size(33, 33)
                cBoat5(number).BackColor = Color.White
                cBoat5(number).FlatStyle = FlatStyle.Flat
                Me.Controls.Add(cBoat5(number))
                cBoat5(number).Location = New Point(470 + (33 * (number + row)), 40 + (33 * col))
                AddHandler cBoat5(number).Click, AddressOf cBoat_Click
            Next
        End If

        'computer's grid
        For outer = 1 To 10
            For inner = 1 To 10
                computerGrid(inner, outer) = New Button
                computerGrid(inner, outer).Size = New Size(33, 33)
                computerGrid(inner, outer).Location = New Point(470 + (inner * 33), 40 + (outer * 33))
                computerGrid(inner, outer).FlatStyle = FlatStyle.Flat
                computerGrid(inner, outer).BackColor = Color.White
                Me.Controls.Add(computerGrid(inner, outer))
                AddHandler computerGrid(inner, outer).Click, AddressOf computergridBtn_Click
                AddHandler computerGrid(inner, outer).Click, AddressOf cPick
            Next
        Next

        'Y labels
        Dim compY As Integer = 75
        Dim lblcompY(10) As Label
        For y = 1 To 10
            lblcompY(y) = New Label
            lblcompY(y).ForeColor = Color.Silver
            lblcompY(y).Font = New Font("Stencil", 16)
            lblcompY(y).Height = 30
            lblcompY(y).Width = 40
            lblcompY(y).Location = New Point(465, compY)
            lblcompY(y).TextAlign = ContentAlignment.MiddleCenter
            lblcompY(y).Text = y
            compY += 33
            Me.Controls.Add(lblcompY(y))
        Next

        'X labels
        Dim compX As Integer = 505
        Dim lblcompx(10) As Label
        For x = 1 To 10
            lblcompx(x) = New Label
            lblcompx(x).ForeColor = Color.Silver
            lblcompx(x).Font = New Font("Stencil", 16)
            lblcompx(x).Height = 30
            lblcompx(x).Width = 30
            lblcompx(x).Location = New Point(compX, 45)
            lblcompx(x).TextAlign = ContentAlignment.MiddleCenter
            lblcompx(x).Text = Chr(65 + x - 1)
            compX += 33
            Me.Controls.Add(lblcompx(x))
        Next

        'computer grid label
        Dim compLbl As New Label
        compLbl.ForeColor = Color.Gray
        compLbl.Font = New Font("Stencil", 14)
        compLbl.Height = 32
        compLbl.Width = 200
        compLbl.Location = New Point(585, 410)
        compLbl.Text = "Opponent's Grid"
        Me.Controls.Add(compLbl)

    End Sub

    Sub computergridBtn_Click(sender As Object, e As EventArgs)
        'if miss change background
        sender.BackgroundImage = project.My.Resources.Resources.miss

        'unable to choose that position again
        sender.Enabled = False
    End Sub

    Sub cBoat_Click(sender As Object, e As EventArgs)
        'if hit change background
        sender.Backcolor = Color.Red

        'add to user score
        uScore += 50

        'show updated score
        scoreLbl.Text = "SCORE: " & uScore

        'unable to choose that position again
        sender.Enabled = False

        'check user score
        If uScore = 850 Then
            uWins(uScore, playerName)
        End If
    End Sub

    Sub uWins(ByRef uScore As Integer, ByVal playerName As String)
        'winner message and player score
        MsgBox("Player " & playerName & " wins!" & vbNewLine & "Player score : " & uScore)

        'make database connection and insert name and score
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
            cmd = New MySqlCommand("USE shipattackdata; INSERT INTO leaderboard (name, score) VALUES('" & playerName & "', '" & uScore & "')")
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
            'tell user name and score are saved
            MsgBox("Name and score saved")
        Catch
            conn.Close()
        End Try

        'close connection
        conn.Close()
        Me.Close()
        'return player to menu
        menuForm.Show()
    End Sub

    Sub cWins(ByRef uScore As Integer, ByVal playerName As String)
        'winner message and player score
        MsgBox("Computer wins!" & vbNewLine & "Player score : " & uScore)

        'make leaderboard conncetion and insert name and score
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
            cmd = New MySqlCommand("USE shipattackdata; INSERT INTO leaderboard (name, score) VALUES('" & playerName & "', '" & uScore & "')")
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
            'tell user name and score are saved
            MsgBox("Name and score saved")
        Catch
            conn.Close()
        End Try

        'close connection
        conn.Close()
        Me.Close()
        'return player to menu
        menuForm.Show()
    End Sub

    Sub cPick(sender As Object, e As EventArgs)

        Dim x As Integer
        Dim y As Integer

        'delay before choosing a point
        Threading.Thread.Sleep(700)

        'computer choses random point
        Do
            x = Int((10 * Rnd()) + 1)
            y = Int((10 * Rnd()) + 1)
            sender = New Point(15 + (33 * (x)), 40 + (33 * y))
        Loop Until userGrid(x, y).Enabled = True

        'checks if computer has hit boat
        For number = 0 To 1
            If uBoat5(number).BackColor = Color.Black And sender = uBoat5(number).Location Then
                'change colour
                uBoat5(number).BackColor = Color.Red
                'add to computer score
                cScore += 50
                'unable to choose that position again
                userGrid(x, y).Enabled = False
                'check computer score
                If cScore = 850 Then
                    cWins(uScore, playerName)
                    Exit For
                End If
                'if boat hit computer gets another turn
                cPick(sender, e)
            Else
                'if miss change background image
                userGrid(x, y).BackgroundImage = project.My.Resources.Resources.miss
                'unable to choose that position again
                userGrid(x, y).Enabled = False
            End If
        Next
        For number = 0 To 4
            If uBoat1(number).BackColor = Color.Black And sender = uBoat1(number).Location Then
                'change colour
                uBoat1(number).BackColor = Color.Red
                'add to computer score
                cScore += 50
                'unable to choose that position again
                userGrid(x, y).Enabled = False
                'check computer score
                If cScore = 850 Then
                    cWins(uScore, playerName)
                    Exit For
                End If
                'if boat hit computer gets another turn
                cPick(sender, e)
            Else
                'if miss change background image
                userGrid(x, y).BackgroundImage = project.My.Resources.Resources.miss
                'unable to choose that position again
                userGrid(x, y).Enabled = False
            End If
        Next
        For number = 0 To 3
            If uBoat2(number).BackColor = Color.Black And sender = uBoat2(number).Location Then
                'change colour
                uBoat2(number).BackColor = Color.Red
                'add to computer score
                cScore += 50
                'unable to choose that position again
                userGrid(x, y).Enabled = False
                'check computer score
                If cScore = 850 Then
                    cWins(uScore, playerName)
                    Exit For
                End If
                'if boat hit computer gets another turn
                cPick(sender, e)
            Else
                'if miss change background image
                userGrid(x, y).BackgroundImage = project.My.Resources.Resources.miss
                'unable to choose that position again
                userGrid(x, y).Enabled = False
            End If
        Next
        For number = 0 To 2
            If uBoat3(number).BackColor = Color.Black And sender = uBoat3(number).Location Then
                'change colour
                uBoat3(number).BackColor = Color.Red
                'add to computer score
                cScore += 50
                'unable to choose that position again
                userGrid(x, y).Enabled = False
                'check computer score
                If cScore = 850 Then
                    cWins(uScore, playerName)
                    Exit For
                End If
                'if boat hit computer gets another turn
                cPick(sender, e)
            Else
                'if miss change background image
                userGrid(x, y).BackgroundImage = project.My.Resources.Resources.miss
                'unable to choose that position again
                userGrid(x, y).Enabled = False
            End If
        Next
        For number = 0 To 2
            If uBoat4(number).BackColor = Color.Black And sender = uBoat4(number).Location Then
                'change colour
                uBoat4(number).BackColor = Color.Red
                'add to computer score
                cScore += 50
                'unable to choose that position again
                userGrid(x, y).Enabled = False
                'check computer score
                If cScore = 850 Then
                    cWins(uScore, playerName)
                    Exit For
                End If
                'if boat hit computer gets another turn
                cPick(sender, e)
            Else
                'if miss change background image
                userGrid(x, y).BackgroundImage = project.My.Resources.Resources.miss
                'unable to chooose that position again
                userGrid(x, y).Enabled = False
            End If
        Next

    End Sub
End Class
