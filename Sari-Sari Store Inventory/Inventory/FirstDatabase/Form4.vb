Public Class Form4
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()

        con.Close()
        TextBox1.Text = "First Name"
        TextBox2.Text = "Last Name"
        TextBox3.Text = "Email"
        TextBox4.Text = "ID"
        TextBox5.Text = "User ID"
        TextBox6.Text = "First Name"
        TextBox7.Text = "Last Name"
        TextBox8.Text = "Email"
        TextBox9.Text = "Password"
        TextBox10.Text = "Password"
        loadTable()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO `accounts`(`First_Name`, `Last_Name`, `Email`, `Password`) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Success")
            con.Close()

            loadTable()

            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox9.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `accounts` WHERE User_ID = '" & TextBox4.Text & "'"
            adapter.SelectCommand = cmd
            dataB.Clear()
            adapter.Fill(dataB, "List")

            TextBox1.DataBindings.Add("Text", dataB, "List.First_Name")
            TextBox1.DataBindings.Clear()

            TextBox2.DataBindings.Add("Text", dataB, "List.Last_Name")
            TextBox2.DataBindings.Clear()

            TextBox3.DataBindings.Add("Text", dataB, "List.Email")
            TextBox3.DataBindings.Clear()

            TextBox9.DataBindings.Add("Text", dataB, "List.Password")
            TextBox9.DataBindings.Clear()

            If TextBox4.TextLength > 0 Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If

            If TextBox4.Text = "" Then
                TextBox1.Text = "Insert First Name"
                TextBox2.Text = "Insert Last Name"
                TextBox3.Text = "Insert Middle Name"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Sub loadTable()
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `accounts`"
            adapter.SelectCommand = cmd
            DTable2.Clear()
            adapter.Fill(DTable2)
            DataGridView1.DataSource = DTable2
            con.Close()


        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        TextBox1.Text = DataGridView1.Item("First_Name", DataGridView1.CurrentRow.Index).Value
        TextBox2.Text = DataGridView1.Item("Last_Name", DataGridView1.CurrentRow.Index).Value
        TextBox3.Text = DataGridView1.Item("Email", DataGridView1.CurrentRow.Index).Value
        TextBox4.Text = DataGridView1.Item("User_ID", DataGridView1.CurrentRow.Index).Value
        TextBox9.Text = DataGridView1.Item("Password", DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE `accounts` SET `First_Name`='" & TextBox1.Text & "',`Last_Name`='" & TextBox2.Text & "',`Email`='" & TextBox3.Text & "',`Password`='" & TextBox9.Text & "' WHERE User_ID = '" & TextBox4.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Updated")
            con.Close()

            loadTable()

            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox9.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM `accounts` WHERE User_ID = '" & TextBox4.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Deleted")
            con.Close()

            loadTable()

            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox9.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `accounts` WHERE User_ID LIKE '%" & TextBox5.Text & "%'"
            adapter.SelectCommand = cmd
            DTable2.Clear()
            adapter.Fill(DTable2)
            DataGridView1.DataSource = DTable2
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()

        End Try
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `accounts` WHERE First_Name LIKE '%" & TextBox6.Text & "%'"
            adapter.SelectCommand = cmd
            DTable2.Clear()
            adapter.Fill(DTable2)
            DataGridView1.DataSource = DTable2
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()

        End Try
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `accounts` WHERE Last_Name LIKE '%" & TextBox7.Text & "%'"
            adapter.SelectCommand = cmd
            DTable2.Clear()
            adapter.Fill(DTable2)
            DataGridView1.DataSource = DTable2
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()

        End Try
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `accounts` WHERE Email LIKE '%" & TextBox8.Text & "%'"
            adapter.SelectCommand = cmd
            DTable2.Clear()
            adapter.Fill(DTable2)
            DataGridView1.DataSource = DTable2
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()

        End Try
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `accounts` WHERE Password LIKE '%" & TextBox10.Text & "%'"
            adapter.SelectCommand = cmd
            DTable2.Clear()
            adapter.Fill(DTable2)
            DataGridView1.DataSource = DTable2
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()

        End Try
    End Sub
End Class
