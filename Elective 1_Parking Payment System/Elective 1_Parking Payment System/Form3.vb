Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
    End Sub

    Private Sub CheckInButton_Click(sender As Object, e As EventArgs) Handles CheckInButton.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO `current`(`Name`, `Car`, `PlateNum`, `Date`, `Time`, `LotNum`) VALUES ('" & TxtBox_Name.Text & "','" & TxtBox_CarModel.Text & "','" & TxtBox_PlateNumber.Text & "','" & TxtBox_Date.Text & "','" & TxtBox_Time.Text & "','" & TxtBox_LotNumber.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("The Transaction Has Been Successfully Added!")
            con.Close()

            TxtBox_Name.Clear()
            TxtBox_CarModel.Clear()
            TxtBox_PlateNumber.Clear()
            TxtBox_LotNumber.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CheckInButton_MouseHover(sender As Object, e As EventArgs) Handles CheckInButton.MouseHover
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO `record`(`Name`, `Car`, `PlateNum`, `Date`, `Time`, `LotNum`) VALUES ('" & TxtBox_Name.Text & "','" & TxtBox_CarModel.Text & "','" & TxtBox_PlateNumber.Text & "','" & TxtBox_Date.Text & "','" & TxtBox_Time.Text & "','" & TxtBox_LotNumber.Text & "')"
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class