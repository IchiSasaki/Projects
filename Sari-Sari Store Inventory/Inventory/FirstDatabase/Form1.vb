Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()

        con.Close()
        TextBox1.Text = "Brand Name"
        TextBox2.Text = "Product Name"
        TextBox3.Text = "Price"
        TextBox5.Text = "Product Number"
        TextBox6.Text = "Brand Name"
        TextBox7.Text = "Product Name"
        TextBox8.Text = "Price"
        loadTable()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO `inventory`(`Brand`, `Product_Name`, `Price`) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Success")
            con.Close()

            loadTable()

            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `inventory` WHERE Product_Number = '" & TextBox4.Text & "'"
            adapter.SelectCommand = cmd
            dataB.Clear()
            adapter.Fill(dataB, "List")

            TextBox1.DataBindings.Add("Text", dataB, "List.Brand")
            TextBox1.DataBindings.Clear()

            TextBox2.DataBindings.Add("Text", dataB, "List.Product_Name")
            TextBox2.DataBindings.Clear()

            TextBox3.DataBindings.Add("Text", dataB, "List.Price")
            TextBox3.DataBindings.Clear()

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
            cmd.CommandText = "SELECT * FROM `inventory`"
            adapter.SelectCommand = cmd
            DTable.Clear()
            adapter.Fill(DTable)
            DataGridView1.DataSource = DTable
            con.Close()


        Catch ex As Exception

        End Try
    End Sub


    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        TextBox1.Text = DataGridView1.Item("Brand", DataGridView1.CurrentRow.Index).Value
        TextBox2.Text = DataGridView1.Item("Product_Name", DataGridView1.CurrentRow.Index).Value
        TextBox3.Text = DataGridView1.Item("Price", DataGridView1.CurrentRow.Index).Value
        TextBox4.Text = DataGridView1.Item("Product_Number", DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE `inventory` SET `Brand`='" & TextBox1.Text & "',`Product_Name`='" & TextBox2.Text & "',`Price`='" & TextBox3.Text & "' WHERE Product_Number = '" & TextBox4.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Updated")
            con.Close()

            loadTable()

            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM `inventory` WHERE Product_Number = '" & TextBox4.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Deleted")
            con.Close()

            loadTable()

            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `inventory` WHERE Product_Number LIKE '%" & TextBox5.Text & "%'"
            adapter.SelectCommand = cmd
            DTable.Clear()
            adapter.Fill(DTable)
            DataGridView1.DataSource = DTable
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()

        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `inventory` WHERE Brand LIKE '%" & TextBox6.Text & "%'"
            adapter.SelectCommand = cmd
            DTable.Clear()
            adapter.Fill(DTable)
            DataGridView1.DataSource = DTable
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
            cmd.CommandText = "SELECT * FROM `inventory` WHERE Product_Name LIKE '%" & TextBox7.Text & "%'"
            adapter.SelectCommand = cmd
            DTable.Clear()
            adapter.Fill(DTable)
            DataGridView1.DataSource = DTable
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
            cmd.CommandText = "SELECT * FROM `inventory` WHERE Price LIKE '%" & TextBox8.Text & "%'"
            adapter.SelectCommand = cmd
            DTable.Clear()
            adapter.Fill(DTable)
            DataGridView1.DataSource = DTable
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()

        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form4.Show()
        Me.Hide()
    End Sub
End Class
