Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()

        con.Close()
        Txt_id.Text = "ID"
        Txt_Name.Text = "Customer Name"
        Txt_Car.Text = "Car Model"
        Txt_PlateNum.Text = "Plate Number"
        Txt_Date.Text = "Date"
        Txt_Time.Text = "Time"
        Txt_LotNum.Text = "Lot Number"
        loadTable()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
    End Sub


    Sub loadTable()
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `current`"
            adapter.SelectCommand = cmd
            DTable1.Clear()
            adapter.Fill(DTable1)
            Table_Active1.DataSource = DTable1
            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Table_Active_DoubleClick(sender As Object, e As EventArgs) Handles Table_Active1.DoubleClick
        TextBox_id.Text = Table_Active1.Item("ID", Table_Active1.CurrentRow.Index).Value
        TextBox_Name.Text = Table_Active1.Item("Name", Table_Active1.CurrentRow.Index).Value
        TextBox_Car.Text = Table_Active1.Item("Car", Table_Active1.CurrentRow.Index).Value
        TextBox_LotNum.Text = Table_Active1.Item("LotNum", Table_Active1.CurrentRow.Index).Value
        TextBox_PlateNum.Text = Table_Active1.Item("PlateNum", Table_Active1.CurrentRow.Index).Value
        TextBox_Date.Text = Table_Active1.Item("Date", Table_Active1.CurrentRow.Index).Value
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM `current` WHERE ID = '" & TextBox_id.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Deleted")
            con.Close()

            loadTable()

            TextBox_id.Clear()
            TextBox_Name.Clear()
            TextBox_Car.Clear()
            TextBox_PlateNum.Clear()
            TextBox_LotNum.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE `current` SET `Name`='" & TextBox_Name.Text & "',`Car`='" & TextBox_Car.Text & "',`PlateNum`='" & TextBox_PlateNum.Text & "' WHERE ID = '" & TextBox_id.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Updated")
            con.Close()

            loadTable()

            TextBox_id.Clear()
            TextBox_Name.Clear()
            TextBox_Car.Clear()
            TextBox_PlateNum.Clear()
            TextBox_LotNum.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Txt_id_TextChanged(sender As Object, e As EventArgs) Handles Txt_id.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `current` WHERE ID LIKE '%" & Txt_id.Text & "%'"
            adapter.SelectCommand = cmd
            DTable1.Clear()
            adapter.Fill(DTable1)
            Table_Active1.DataSource = DTable1
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()

        End Try
    End Sub

    Private Sub Txt_id_Click(sender As Object, e As EventArgs) Handles Txt_id.Click
        Txt_id.Clear()
    End Sub

    Private Sub Txt_Name_TextChanged(sender As Object, e As EventArgs) Handles Txt_Name.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `current` WHERE Name LIKE '%" & Txt_Name.Text & "%'"
            adapter.SelectCommand = cmd
            DTable1.Clear()
            adapter.Fill(DTable1)
            Table_Active1.DataSource = DTable1
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()

        End Try
    End Sub

    Private Sub Txt_Name_Click(sender As Object, e As EventArgs) Handles Txt_Name.Click
        Txt_Name.Clear()
    End Sub

    Private Sub Txt_Car_TextChanged(sender As Object, e As EventArgs) Handles Txt_Car.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `current` WHERE Car LIKE '%" & Txt_Car.Text & "%'"
            adapter.SelectCommand = cmd
            DTable1.Clear()
            adapter.Fill(DTable1)
            Table_Active1.DataSource = DTable1
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()

        End Try
    End Sub

    Private Sub Txt_Car_Click(sender As Object, e As EventArgs) Handles Txt_Car.Click
        Txt_Car.Clear()
    End Sub

    Private Sub Txt_PlateNum_TextChanged(sender As Object, e As EventArgs) Handles Txt_PlateNum.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `current` WHERE PlateNum LIKE '%" & Txt_PlateNum.Text & "%'"
            adapter.SelectCommand = cmd
            DTable1.Clear()
            adapter.Fill(DTable1)
            Table_Active1.DataSource = DTable1
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()

        End Try
    End Sub

    Private Sub Txt_PlateNum_Click(sender As Object, e As EventArgs) Handles Txt_PlateNum.Click
        Txt_PlateNum.Clear()
    End Sub

    Private Sub Txt_Date_TextChanged(sender As Object, e As EventArgs) Handles Txt_Date.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `current` WHERE Date LIKE '%" & Txt_Date.Text & "%'"
            adapter.SelectCommand = cmd
            DTable1.Clear()
            adapter.Fill(DTable1)
            Table_Active1.DataSource = DTable1
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()

        End Try
    End Sub

    Private Sub Txt_Date_Click(sender As Object, e As EventArgs) Handles Txt_Date.Click
        Txt_Date.Clear()
    End Sub

    Private Sub Txt_Time_TextChanged(sender As Object, e As EventArgs) Handles Txt_Time.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `current` WHERE Time LIKE '%" & Txt_Time.Text & "%'"
            adapter.SelectCommand = cmd
            DTable1.Clear()
            adapter.Fill(DTable1)
            Table_Active1.DataSource = DTable1
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()

        End Try
    End Sub

    Private Sub Txt_Time_Click(sender As Object, e As EventArgs) Handles Txt_Time.Click
        Txt_Time.Clear()
    End Sub

    Private Sub Txt_LotNum_TextChanged(sender As Object, e As EventArgs) Handles Txt_LotNum.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `current` WHERE LotNum LIKE '%" & Txt_LotNum.Text & "%'"
            adapter.SelectCommand = cmd
            DTable1.Clear()
            adapter.Fill(DTable1)
            Table_Active1.DataSource = DTable1
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()

        End Try
    End Sub

    Private Sub Txt_LotNum_Click(sender As Object, e As EventArgs) Handles Txt_LotNum.Click
        Txt_LotNum.Clear()
    End Sub


End Class