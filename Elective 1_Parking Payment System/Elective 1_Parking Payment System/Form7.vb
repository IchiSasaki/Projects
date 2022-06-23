Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            cmd.CommandText = "SELECT * FROM `active`"
            adapter.SelectCommand = cmd
            DTable1.Clear()
            adapter.Fill(DTable1)
            Table_Active.DataSource = DTable1
            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Table_Active_DoubleClick(sender As Object, e As EventArgs) Handles Table_Active.DoubleClick
        TextBox_idd.Text = Table_Active.Item("ID", Table_Active.CurrentRow.Index).Value
        TextBox_Named.Text = Table_Active.Item("Name", Table_Active.CurrentRow.Index).Value
        TextBox_Card.Text = Table_Active.Item("Car", Table_Active.CurrentRow.Index).Value
        TextBox_LotNumd.Text = Table_Active.Item("LotNum", Table_Active.CurrentRow.Index).Value
        TextBox_PlateNumd.Text = Table_Active.Item("PlateNum", Table_Active.CurrentRow.Index).Value
        TextBox_Dated.Text = Table_Active.Item("Date", Table_Active.CurrentRow.Index).Value
    End Sub

    Private Sub PayButton_Click(sender As Object, e As EventArgs) Handles PayButton.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM `active` WHERE ID = '" & TextBox_idd.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Thank You!")
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
End Class