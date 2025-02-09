Public Class Games
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Media.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Insight.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Close()
    End Sub
    Dim board(8) As Button
    Dim currentPlayer As String = "X"
    Dim rnd As New Random()

    Private Sub GamesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Tic Tac Toe"
        board = {btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9}
        ResetGame()
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim clickedButton As Button = CType(sender, Button)
        If clickedButton.Text = "" Then
            clickedButton.Text = "X"
            If CheckWin("X") Then
                lblStatus.Text = "You win!"
                DisableBoard()
                Return
            End If
            BotMove()
        End If
    End Sub

    Private Sub BotMove()
        Dim availableMoves = board.Where(Function(b) b.Text = "").ToArray()
        If availableMoves.Length > 0 Then
            Dim botMove = availableMoves(rnd.Next(availableMoves.Length))
            botMove.Text = "O"
            If CheckWin("O") Then
                lblStatus.Text = "Bot wins!"
                DisableBoard()
            ElseIf board.All(Function(b) b.Text <> "") Then
                lblStatus.Text = "It's a draw!"
            End If
        End If
    End Sub

    Private Function CheckWin(player As String) As Boolean
        Dim winPatterns As Integer(,) = {
        {0, 1, 2}, {3, 4, 5}, {6, 7, 8},  ' Rows
        {0, 3, 6}, {1, 4, 7}, {2, 5, 8},  ' Columns
        {0, 4, 8}, {2, 4, 6}              ' Diagonals
    }
        For i As Integer = 0 To winPatterns.GetLength(0) - 1
            If board(winPatterns(i, 0)).Text = player AndAlso board(winPatterns(i, 1)).Text = player AndAlso board(winPatterns(i, 2)).Text = player Then
                Return True
            End If
        Next
        Return False
    End Function


    Private Sub DisableBoard()
        For Each btn In board
            btn.Enabled = False
        Next
    End Sub

    Private Sub ResetGame()
        For Each btn In board
            btn.Text = ""
            btn.Enabled = True
        Next
        lblStatus.Text = "Your turn!"
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        ResetGame()
    End Sub
End Class