Public Class Insight
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Media.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Games.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Insight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Insight Form"
        txtInsight.Text = "My journey in programming has been exciting! I've learned a lot about coding in Visual Studio, building forms, and even creating games like Tic Tac Toe."
    End Sub
End Class