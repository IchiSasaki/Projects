Public Class Front
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub CheckInButton_Click(sender As Object, e As EventArgs) Handles CheckInButton.Click
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form8.Close()

        With Form3
            .TopLevel = False
            Dashboard.Controls.Add(Form3)
            .BringToFront()
            .Show()
            con.Close()
        End With
    End Sub

    Private Sub ActiveButton_Click(sender As Object, e As EventArgs) Handles ActiveButton.Click

        With Form4
            .TopLevel = False
            Dashboard.Controls.Add(Form4)
            .BringToFront()
            .Show()
            con.Close()
        End With
    End Sub

    Private Sub HistoryButton_Click(sender As Object, e As EventArgs) Handles HistoryButton.Click

        With Form5
            .TopLevel = False
            Dashboard.Controls.Add(Form5)
            .BringToFront()
            .Show()
            con.Close()
        End With
    End Sub

    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click

        With Form6
            .TopLevel = False
            Dashboard.Controls.Add(Form6)
            .BringToFront()
            .Show()
            con.Close()
        End With
    End Sub

    Private Sub BillingButton_Click(sender As Object, e As EventArgs) Handles BillingButton.Click

        With Form8
            .TopLevel = False
            Dashboard.Controls.Add(Form8)
            .BringToFront()
            .Show()
            con.Close()
        End With
    End Sub
End Class