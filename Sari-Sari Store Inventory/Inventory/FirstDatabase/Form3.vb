Public Class Form3
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()
        MsgBox("Connected")
        con.Close()
        TextBox5.Text = "Product Number"
        TextBox6.Text = "Brand Name"
        TextBox7.Text = "Product Name"
        TextBox8.Text = "Price"
        loadTable()

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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
        Me.Hide()
    End Sub
End Class