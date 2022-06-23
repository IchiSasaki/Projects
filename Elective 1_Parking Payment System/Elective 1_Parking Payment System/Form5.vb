Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()

        con.Close()

        Txt_id1.Text = "ID"
        Txt_Name1.Text = "Customer Name"
        Txt_Car1.Text = "Car Model"
        Txt_PlateNum1.Text = "Plate Number"
        Txt_Date1.Text = "Date"
        Txt_Time1.Text = "Time"
        Txt_LotNum1.Text = "Lot Number"
        loadTable1()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
    End Sub

    Sub loadTable1()
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `record`"
            adapter.SelectCommand = cmd
            DTable2.Clear()
            adapter.Fill(DTable2)
            Table_History.DataSource = DTable2
            con.Close()

        Catch ex As Exception

        End Try
    End Sub


    Private Sub Txt_id1_TextChanged(sender As Object, e As EventArgs) Handles Txt_id1.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `record` WHERE ID LIKE '%" & Txt_id1.Text & "%'"
            adapter.SelectCommand = cmd
            DTable2.Clear()
            adapter.Fill(DTable2)
            Table_History.DataSource = DTable2
            con.Close()

        Catch ex As Exception

            con.Close()


        End Try
    End Sub

    Private Sub Txt_id1_Click(sender As Object, e As EventArgs) Handles Txt_id1.Click
        Txt_id1.Clear()
    End Sub

    Private Sub Txt_Name1_TextChanged(sender As Object, e As EventArgs) Handles Txt_Name1.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `record` WHERE Name LIKE '%" & Txt_Name1.Text & "%'"
            adapter.SelectCommand = cmd
            DTable2.Clear()
            adapter.Fill(DTable2)
            Table_History.DataSource = DTable2
            con.Close()

        Catch ex As Exception

            con.Close()

        End Try
    End Sub

    Private Sub Txt_Name1_Click(sender As Object, e As EventArgs) Handles Txt_Name1.Click
        Txt_Name1.Clear()
    End Sub

    Private Sub Txt_Car1_TextChanged(sender As Object, e As EventArgs) Handles Txt_Car1.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `record` WHERE Car LIKE '%" & Txt_Car1.Text & "%'"
            adapter.SelectCommand = cmd
            DTable2.Clear()
            adapter.Fill(DTable2)
            Table_History.DataSource = DTable2
            con.Close()

        Catch ex As Exception

            con.Close()

        End Try
    End Sub

    Private Sub Txt_Car1_Click(sender As Object, e As EventArgs) Handles Txt_Car1.Click
        Txt_Car1.Clear()
    End Sub

    Private Sub Txt_PlateNum1_TextChanged(sender As Object, e As EventArgs) Handles Txt_PlateNum1.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `record` WHERE PlateNum LIKE '%" & Txt_PlateNum1.Text & "%'"
            adapter.SelectCommand = cmd
            DTable2.Clear()
            adapter.Fill(DTable2)
            Table_History.DataSource = DTable2
            con.Close()

        Catch ex As Exception

            con.Close()

        End Try
    End Sub

    Private Sub Txt_PlateNum1_Click(sender As Object, e As EventArgs) Handles Txt_PlateNum1.Click
        Txt_PlateNum1.Clear()
    End Sub

    Private Sub Txt_Date1_TextChanged(sender As Object, e As EventArgs) Handles Txt_Date1.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `record` WHERE Date LIKE '%" & Txt_Date1.Text & "%'"
            adapter.SelectCommand = cmd
            DTable2.Clear()
            adapter.Fill(DTable2)
            Table_History.DataSource = DTable2
            con.Close()

        Catch ex As Exception

            con.Close()

        End Try
    End Sub

    Private Sub Txt_Date1_Click(sender As Object, e As EventArgs) Handles Txt_Date1.Click
        Txt_Date1.Clear()
    End Sub

    Private Sub Txt_Time1_TextChanged(sender As Object, e As EventArgs) Handles Txt_Time1.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `record` WHERE Time LIKE '%" & Txt_Time1.Text & "%'"
            adapter.SelectCommand = cmd
            DTable2.Clear()
            adapter.Fill(DTable2)
            Table_History.DataSource = DTable2
            con.Close()

        Catch ex As Exception

            con.Close()

        End Try
    End Sub

    Private Sub Txt_Time1_Click(sender As Object, e As EventArgs) Handles Txt_Time1.Click
        Txt_Time1.Clear()
    End Sub

    Private Sub Txt_LotNum1_TextChanged(sender As Object, e As EventArgs) Handles Txt_LotNum1.TextChanged
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `record` WHERE LotNum LIKE '%" & Txt_LotNum1.Text & "%'"
            adapter.SelectCommand = cmd
            DTable2.Clear()
            adapter.Fill(DTable2)
            Table_History.DataSource = DTable2
            con.Close()

        Catch ex As Exception

            con.Close()

        End Try
    End Sub

    Private Sub Txt_LotNum1_Click(sender As Object, e As EventArgs) Handles Txt_LotNum1.Click
        Txt_LotNum1.Clear()
    End Sub



End Class