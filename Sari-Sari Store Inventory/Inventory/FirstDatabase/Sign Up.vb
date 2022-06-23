Public Class Sign_Up
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO `accounts`(`First_Name`, `Last_Name`, `Email`, `Password`) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Congratulations! You can now log-in.")
            con.Close()

            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO `admin acc`(`First Name`, `Last Name`, `Email`, `Password`) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Congratulations! You can now log-in.")
            con.Close()

            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class