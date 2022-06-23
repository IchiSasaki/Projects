Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()
        con.Close()
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub Loginbutton_Click(sender As Object, e As EventArgs) Handles Loginbutton.Click
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "Select * FROM `users` WHERE Username Like '" & TextBox_username.Text & "' AND Password Like '" & TextBox_Password.Text & "'"
            DReader = cmd.ExecuteReader()
            DReader.Read()

            If DReader.HasRows Then

                Console.WriteLine(DReader(0).ToString)
                Console.WriteLine(DReader(1).ToString)
                Console.WriteLine(DReader(2).ToString)
                If TextBox_username.Text.Equals(DReader(1).ToString) And TextBox_Password.Text.Equals(DReader(2).ToString) Then

                    TextBox_username.Clear()
                    TextBox_Password.Clear()

                    con.Close()
                    Front.Show()
                    Me.Hide()
                End If
                DReader.Close()

            Else
                MsgBox("Error! Please Try Again")
                TextBox_username.Clear()
                TextBox_Password.Clear()
                con.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CreateAcc_Click(sender As Object, e As EventArgs) Handles CreateAcc.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO `users`(`Username`, `Password`) VALUES ('" & TextBox_username.Text & "','" & TextBox_Password.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Congratulations! You can now log-in.")
            con.Close()

            TextBox_username.Clear()
            TextBox_Password.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
