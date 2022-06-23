Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `accounts` WHERE Email Like '" & TextBox1.Text & "' AND Password LIKE '" & TextBox2.Text & "'"
            DReader = cmd.ExecuteReader()
            DReader.Read()

            If DReader.HasRows Then

                Console.WriteLine(DReader(0).ToString)
                Console.WriteLine(DReader(1).ToString)
                Console.WriteLine(DReader(2).ToString)
                Console.WriteLine(DReader(3).ToString)
                Console.WriteLine(DReader(4).ToString)
                If TextBox1.Text.Equals(DReader(2).ToString) And TextBox2.Text.Equals(DReader(3).ToString) Then
                    MsgBox("Logged In Successfully")

                    TextBox1.Clear()
                    TextBox2.Clear()

                    con.Close()
                    Form3.Show()
                    Me.Hide()
                End If
                DReader.Close()

            Else
                MsgBox("Error! Please Try Again")
                TextBox1.Clear()
                TextBox2.Clear()
                con.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Sign_Up.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `admin acc` WHERE Email Like '" & TextBox1.Text & "' AND Password LIKE '" & TextBox2.Text & "'"
            DReader = cmd.ExecuteReader()
            DReader.Read()

            If DReader.HasRows Then

                Console.WriteLine(DReader(0).ToString)
                Console.WriteLine(DReader(1).ToString)
                Console.WriteLine(DReader(2).ToString)
                Console.WriteLine(DReader(3).ToString)
                Console.WriteLine(DReader(4).ToString)
                If TextBox1.Text.Equals(DReader(2).ToString) And TextBox2.Text.Equals(DReader(3).ToString) Then
                    MsgBox("Logged In Successfully")

                    TextBox1.Clear()
                    TextBox2.Clear()

                    con.Close()
                    Form1.Show()
                    Me.Hide()
                End If
                DReader.Close()

            Else
                MsgBox("Error! Please Try Again")
                TextBox1.Clear()
                TextBox2.Clear()
                con.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class