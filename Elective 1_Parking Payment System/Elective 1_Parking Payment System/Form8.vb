Public Class Form8

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()
        con.Close()

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
            Table_Active3.DataSource = DTable1
            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Table_Active_DoubleClick(sender As Object, e As EventArgs) Handles Table_Active3.DoubleClick
        TextBox_idd.Text = Table_Active3.Item("ID", Table_Active3.CurrentRow.Index).Value
        TextBox_Named.Text = Table_Active3.Item("Name", Table_Active3.CurrentRow.Index).Value
        TextBox_Card.Text = Table_Active3.Item("Car", Table_Active3.CurrentRow.Index).Value
        TextBox_LotNumd.Text = Table_Active3.Item("LotNum", Table_Active3.CurrentRow.Index).Value
        TextBox_PlateNumd.Text = Table_Active3.Item("PlateNum", Table_Active3.CurrentRow.Index).Value
        TextBox_Dated.Text = Table_Active3.Item("Date", Table_Active3.CurrentRow.Index).Value
    End Sub

    Private Sub CheckOutDate_ValueChanged(sender As Object, e As EventArgs) Handles CheckOutDate.ValueChanged
        Dim T As TimeSpan = CheckOutDate.Value - Now
        If T.Days < 1 Then
            CheckOutDate.Text = Now.AddDays(1D)
            TextBox_Durationd.Text = "1"
        Else
            TextBox_Durationd.Text = T.Days + 1
        End If
        TextBox_Payd.Text = Val(TextBox_Durationd.Text) * Val(TextBox_Rated.Text)
    End Sub

    Private Sub PayButton_MouseHover(sender As Object, e As EventArgs) Handles PayButton.MouseHover
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE `record` SET `CheckedOut`='" & CheckOutDate.Text & "',`Payment`='" & TextBox_Payd.Text & "' WHERE ID = '" & TextBox_idd.Text & "'"

            cmd.ExecuteNonQuery()
            con.Close()

            loadTable()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub PayButton_Click(sender As Object, e As EventArgs) Handles PayButton.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM `current` WHERE ID = '" & TextBox_idd.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Transaction Completed Successfully!")
            con.Close()

            loadTable()

            TextBox_idd.Clear()
            TextBox_Named.Clear()
            TextBox_Card.Clear()
            TextBox_PlateNumd.Clear()
            TextBox_LotNumd.Clear()
            TextBox_Durationd.Clear()
            TextBox_Rated.Clear()
            TextBox_Payd.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Class