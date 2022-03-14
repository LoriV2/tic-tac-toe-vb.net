
Public Class Form1
    Public turns As Integer = 0
    Public player1 As Boolean = True
    Public who_wins As String
    Public wins As Boolean = False
    Public count_win_O As Integer = 0
    Public count_win_X As Integer = 0

    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
    Public Sub Winning()
        'all posibilities to win for O
        If (X_O_1.Text = "O" And X_O_2.Text = "O" And X_O_3.Text = "O") Or
            (X_O_4.Text = "O" And X_O_5.Text = "O" And X_O_6.Text = "O") Or
            (X_O_7.Text = "O" And X_O_8.Text = "O" And X_O_9.Text = "O") Or
            (X_O_1.Text = "O" And X_O_4.Text = "O" And X_O_7.Text = "O") Or
            (X_O_2.Text = "O" And X_O_5.Text = "O" And X_O_8.Text = "O") Or
            (X_O_3.Text = "O" And X_O_6.Text = "O" And X_O_9.Text = "O") Or
            (X_O_1.Text = "O" And X_O_5.Text = "O" And X_O_9.Text = "O") Or
           (X_O_3.Text = "O" And X_O_5.Text = "O" And X_O_7.Text = "O") Then

            count_win_O += 1
            O_wins.Text = count_win_O
            Timer1.Enabled = False
            who_wins = "player 1 wins"
            Player_turn_label.Text = who_wins
            wins = True

            'all posibilities to win for X
        ElseIf (X_O_1.Text = "X" And X_O_2.Text = "X" And X_O_3.Text = "X") Or
            (X_O_4.Text = "X" And X_O_5.Text = "X" And X_O_6.Text = "X") Or
            (X_O_7.Text = "X" And X_O_8.Text = "X" And X_O_9.Text = "X") Or
            (X_O_1.Text = "X" And X_O_4.Text = "X" And X_O_7.Text = "X") Or
            (X_O_2.Text = "X" And X_O_5.Text = "X" And X_O_8.Text = "X") Or
            (X_O_3.Text = "X" And X_O_6.Text = "X" And X_O_9.Text = "X") Or
            (X_O_1.Text = "X" And X_O_5.Text = "X" And X_O_9.Text = "X") Or
           (X_O_3.Text = "X" And X_O_5.Text = "X" And X_O_7.Text = "X") Then

            count_win_X += 1
            X_wins.Text = count_win_X
            Timer1.Enabled = False
            who_wins = "player 2 wins"
            Player_turn_label.Text = who_wins
            wins = True

            'if draw
        ElseIf turns = 8 Then
            Timer1.Enabled = False
            who_wins = "draw"
            Player_turn_label.Text = who_wins
            wins = True

        Else
            who_wins = "...."

        End If

    End Sub

    Public Sub X_O_5_Click(sender As Object, e As EventArgs) Handles X_O_5.Click
        'if it is O turn
        If player1 = True And Timer1.Enabled = True Then
            X_O_5.Text = "O"
            Player_turn_label.Text = "Player 2 turn"
            player1 = False
            X_O_5.Enabled = False
            Winning()
            'if it is X turn
        ElseIf Timer1.Enabled = True Then
            X_O_5.Text = "X"
            Player_turn_label.Text = "Player 1 turn"
            player1 = True
            X_O_5.Enabled = False
            Winning()
        End If
        turns += 1

    End Sub

    Public Sub X_O_1_Click(sender As Object, e As EventArgs) Handles X_O_1.Click
        If player1 = True And Timer1.Enabled = True Then
            X_O_1.Text = "O"
            Player_turn_label.Text = "Player 2 turn"
            player1 = False
            X_O_1.Enabled = False
            Winning()
        ElseIf Timer1.Enabled = True Then
            X_O_1.Text = "X"
            Player_turn_label.Text = "Player 1 turn"
            player1 = True
            X_O_1.Enabled = False
            Winning()
        End If

        turns += 1
    End Sub

    Public Sub X_O_2_Click(sender As Object, e As EventArgs) Handles X_O_2.Click
        If player1 = True And Timer1.Enabled = True Then
            X_O_2.Text = "O"
            Player_turn_label.Text = "Player 2 turn"
            player1 = False
            X_O_2.Enabled = False
            Winning()
        ElseIf Timer1.Enabled = True Then
            X_O_2.Text = "X"
            Player_turn_label.Text = "Player 1 turn"
            player1 = True
            X_O_2.Enabled = False
            Winning()
        End If

        turns += 1
    End Sub

    Public Sub X_O_3_Click(sender As Object, e As EventArgs) Handles X_O_3.Click
        If player1 = True And Timer1.Enabled = True Then
            X_O_3.Text = "O"
            Player_turn_label.Text = "Player 2 turn"
            player1 = False
            X_O_3.Enabled = False
            Winning()
        ElseIf Timer1.Enabled = True Then
            X_O_3.Text = "X"
            Player_turn_label.Text = "Player 1 turn"
            player1 = True
            X_O_3.Enabled = False
            Winning()
        End If
        turns += 1

    End Sub

    Public Sub X_O_4_Click(sender As Object, e As EventArgs) Handles X_O_4.Click
        If player1 = True And Timer1.Enabled = True Then
            X_O_4.Text = "O"
            Player_turn_label.Text = "Player 2 turn"
            player1 = False
            X_O_4.Enabled = False
            Winning()
        ElseIf Timer1.Enabled = True Then
            X_O_4.Text = "X"
            Player_turn_label.Text = "Player 1 turn"
            player1 = True
            X_O_4.Enabled = False
            Winning()
        End If

        turns += 1
    End Sub

    Public Sub X_O_6_Click(sender As Object, e As EventArgs) Handles X_O_6.Click
        If player1 = True And Timer1.Enabled = True Then
            X_O_6.Text = "O"
            Player_turn_label.Text = "Player 2 turn"
            player1 = False
            X_O_6.Enabled = False
            Winning()
        ElseIf Timer1.Enabled = True Then
            X_O_6.Text = "X"
            Player_turn_label.Text = "Player 1 turn"
            player1 = True
            X_O_6.Enabled = False
            Winning()
        End If

        turns += 1
    End Sub

    Public Sub X_O_7_Click(sender As Object, e As EventArgs) Handles X_O_7.Click
        If player1 = True And Timer1.Enabled = True Then
            X_O_7.Text = "O"
            Player_turn_label.Text = "Player 2 turn"
            player1 = False
            X_O_7.Enabled = False
            Winning()
        ElseIf Timer1.Enabled = True Then
            X_O_7.Text = "X"
            Player_turn_label.Text = "Player 1 turn"
            X_O_7.Enabled = False
            player1 = True
            Winning()
        End If

        turns += 1
    End Sub

    Public Sub X_O_8_Click(sender As Object, e As EventArgs) Handles X_O_8.Click
        If player1 = True And Timer1.Enabled = True Then
            X_O_8.Text = "O"
            Player_turn_label.Text = "Player 2 turn"
            player1 = False
            X_O_8.Enabled = False
            Winning()
        ElseIf Timer1.Enabled = True Then
            X_O_8.Text = "X"
            Player_turn_label.Text = "Player 1 turn"
            player1 = True
            X_O_8.Enabled = False
            Winning()
        End If

        turns += 1
    End Sub

    Public Sub X_O_9_Click(sender As Object, e As EventArgs) Handles X_O_9.Click
        If player1 = True And Timer1.Enabled = True Then
            X_O_9.Text = "O"
            Player_turn_label.Text = "Player 2 turn"
            player1 = False
            X_O_9.Enabled = False
            Winning()
        ElseIf Timer1.Enabled = True Then
            X_O_9.Text = "X"
            Player_turn_label.Text = "Player 1 turn"
            player1 = True
            X_O_9.Enabled = False
            Winning()
        End If

        turns += 1
    End Sub

    Public Sub Start_btn_Click(sender As Object, e As EventArgs) Handles Start_btn.Click
        'if there was no win or draw yet
        If wins = False Then
            Player_turn_label.Text = "Player 1 turn"
            Timer1.Enabled = True
            'if you want to restart after played game
        ElseIf wins = True And (who_wins = "player 1 wins" Or who_wins = "player 2 wins" Or who_wins = "draw") Then

            X_O_1.Text = ""
            X_O_2.Text = ""
            X_O_3.Text = ""
            X_O_4.Text = ""
            X_O_5.Text = ""
            X_O_6.Text = ""
            X_O_7.Text = ""
            X_O_8.Text = ""
            X_O_9.Text = ""
            X_O_1.Enabled = True
            X_O_2.Enabled = True
            X_O_3.Enabled = True
            X_O_4.Enabled = True
            X_O_5.Enabled = True
            X_O_6.Enabled = True
            X_O_7.Enabled = True
            X_O_8.Enabled = True
            X_O_9.Enabled = True
            player1 = True
            Player_turn_label.Text = "Player 1 turn"
            who_wins = "....."
            turns = 0
            Timer1.Enabled = True

        End If
    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
