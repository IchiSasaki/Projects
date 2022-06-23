<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Back = New System.Windows.Forms.Label()
        Me.AddLabel = New System.Windows.Forms.Label()
        Me.Divider = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Table_Active1 = New System.Windows.Forms.DataGridView()
        Me.Txt_id = New System.Windows.Forms.TextBox()
        Me.Txt_Name = New System.Windows.Forms.TextBox()
        Me.Txt_Car = New System.Windows.Forms.TextBox()
        Me.Txt_PlateNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Car = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_PlateNum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_LotNum = New System.Windows.Forms.TextBox()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Txt_Date = New System.Windows.Forms.TextBox()
        Me.Txt_Time = New System.Windows.Forms.TextBox()
        Me.Txt_LotNum = New System.Windows.Forms.TextBox()
        Me.TextBox_Date = New System.Windows.Forms.DateTimePicker()
        Me.ID = New System.Windows.Forms.Label()
        Me.TextBox_id = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6.SuspendLayout()
        CType(Me.Table_Active1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.AutoSize = True
        Me.Back.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(46, 19)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(48, 21)
        Me.Back.TabIndex = 79
        Me.Back.Text = "Back"
        '
        'AddLabel
        '
        Me.AddLabel.AutoSize = True
        Me.AddLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddLabel.Location = New System.Drawing.Point(128, 19)
        Me.AddLabel.Name = "AddLabel"
        Me.AddLabel.Size = New System.Drawing.Size(150, 21)
        Me.AddLabel.TabIndex = 80
        Me.AddLabel.Text = "Active Transaction"
        '
        'Divider
        '
        Me.Divider.AutoSize = True
        Me.Divider.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider.Location = New System.Drawing.Point(100, 19)
        Me.Divider.Name = "Divider"
        Me.Divider.Size = New System.Drawing.Size(13, 21)
        Me.Divider.TabIndex = 81
        Me.Divider.Text = "|"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(6, 524)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(732, 2)
        Me.Panel1.TabIndex = 83
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(6, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(732, 2)
        Me.Panel2.TabIndex = 84
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel6.Controls.Add(Me.Panel3)
        Me.Panel6.Location = New System.Drawing.Point(736, 62)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(2, 464)
        Me.Panel6.TabIndex = 85
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(-727, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 464)
        Me.Panel3.TabIndex = 86
        '
        'Table_Active1
        '
        Me.Table_Active1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table_Active1.Location = New System.Drawing.Point(15, 134)
        Me.Table_Active1.Name = "Table_Active1"
        Me.Table_Active1.Size = New System.Drawing.Size(714, 189)
        Me.Table_Active1.TabIndex = 86
        '
        'Txt_id
        '
        Me.Txt_id.Location = New System.Drawing.Point(15, 103)
        Me.Txt_id.Name = "Txt_id"
        Me.Txt_id.Size = New System.Drawing.Size(96, 20)
        Me.Txt_id.TabIndex = 87
        '
        'Txt_Name
        '
        Me.Txt_Name.Location = New System.Drawing.Point(118, 104)
        Me.Txt_Name.Name = "Txt_Name"
        Me.Txt_Name.Size = New System.Drawing.Size(96, 20)
        Me.Txt_Name.TabIndex = 88
        '
        'Txt_Car
        '
        Me.Txt_Car.Location = New System.Drawing.Point(221, 103)
        Me.Txt_Car.Name = "Txt_Car"
        Me.Txt_Car.Size = New System.Drawing.Size(96, 20)
        Me.Txt_Car.TabIndex = 89
        '
        'Txt_PlateNum
        '
        Me.Txt_PlateNum.Location = New System.Drawing.Point(324, 103)
        Me.Txt_PlateNum.Name = "Txt_PlateNum"
        Me.Txt_PlateNum.Size = New System.Drawing.Size(96, 20)
        Me.Txt_PlateNum.TabIndex = 90
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 21)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 373)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 21)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Customer Name :"
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Name.Location = New System.Drawing.Point(190, 370)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(186, 29)
        Me.TextBox_Name.TabIndex = 93
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 407)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 21)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Car Model :"
        '
        'TextBox_Car
        '
        Me.TextBox_Car.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Car.Location = New System.Drawing.Point(190, 404)
        Me.TextBox_Car.Name = "TextBox_Car"
        Me.TextBox_Car.Size = New System.Drawing.Size(186, 29)
        Me.TextBox_Car.TabIndex = 95
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(421, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 21)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Plate Number :"
        '
        'TextBox_PlateNum
        '
        Me.TextBox_PlateNum.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_PlateNum.Location = New System.Drawing.Point(579, 337)
        Me.TextBox_PlateNum.Name = "TextBox_PlateNum"
        Me.TextBox_PlateNum.Size = New System.Drawing.Size(127, 29)
        Me.TextBox_PlateNum.TabIndex = 97
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(421, 374)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 21)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Check In Date :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(421, 407)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 21)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Lot Number :"
        '
        'TextBox_LotNum
        '
        Me.TextBox_LotNum.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_LotNum.Location = New System.Drawing.Point(580, 404)
        Me.TextBox_LotNum.Name = "TextBox_LotNum"
        Me.TextBox_LotNum.Size = New System.Drawing.Size(127, 29)
        Me.TextBox_LotNum.TabIndex = 101
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.Orange
        Me.DeleteButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(119, 453)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(195, 45)
        Me.DeleteButton.TabIndex = 102
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.Orange
        Me.UpdateButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.Location = New System.Drawing.Point(425, 453)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(195, 45)
        Me.UpdateButton.TabIndex = 103
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 104
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(6, 62)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 464)
        Me.Panel4.TabIndex = 87
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel5.Location = New System.Drawing.Point(-727, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(2, 464)
        Me.Panel5.TabIndex = 86
        '
        'Txt_Date
        '
        Me.Txt_Date.Location = New System.Drawing.Point(427, 104)
        Me.Txt_Date.Name = "Txt_Date"
        Me.Txt_Date.Size = New System.Drawing.Size(96, 20)
        Me.Txt_Date.TabIndex = 105
        '
        'Txt_Time
        '
        Me.Txt_Time.Location = New System.Drawing.Point(530, 104)
        Me.Txt_Time.Name = "Txt_Time"
        Me.Txt_Time.Size = New System.Drawing.Size(96, 20)
        Me.Txt_Time.TabIndex = 106
        '
        'Txt_LotNum
        '
        Me.Txt_LotNum.Location = New System.Drawing.Point(633, 104)
        Me.Txt_LotNum.Name = "Txt_LotNum"
        Me.Txt_LotNum.Size = New System.Drawing.Size(96, 20)
        Me.Txt_LotNum.TabIndex = 107
        '
        'TextBox_Date
        '
        Me.TextBox_Date.CustomFormat = "yyyy-MM-dd"
        Me.TextBox_Date.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TextBox_Date.Location = New System.Drawing.Point(579, 370)
        Me.TextBox_Date.Name = "TextBox_Date"
        Me.TextBox_Date.Size = New System.Drawing.Size(127, 29)
        Me.TextBox_Date.TabIndex = 108
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(31, 340)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(38, 21)
        Me.ID.TabIndex = 109
        Me.ID.Text = "ID :"
        '
        'TextBox_id
        '
        Me.TextBox_id.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_id.Location = New System.Drawing.Point(190, 337)
        Me.TextBox_id.Name = "TextBox_id"
        Me.TextBox_id.Size = New System.Drawing.Size(127, 29)
        Me.TextBox_id.TabIndex = 110
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.TextBox_id)
        Me.Panel7.Controls.Add(Me.ID)
        Me.Panel7.Controls.Add(Me.TextBox_Date)
        Me.Panel7.Controls.Add(Me.Txt_LotNum)
        Me.Panel7.Controls.Add(Me.Txt_Time)
        Me.Panel7.Controls.Add(Me.Txt_Date)
        Me.Panel7.Controls.Add(Me.Panel4)
        Me.Panel7.Controls.Add(Me.PictureBox1)
        Me.Panel7.Controls.Add(Me.UpdateButton)
        Me.Panel7.Controls.Add(Me.DeleteButton)
        Me.Panel7.Controls.Add(Me.TextBox_LotNum)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.TextBox_PlateNum)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.TextBox_Car)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.TextBox_Name)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.Txt_PlateNum)
        Me.Panel7.Controls.Add(Me.Txt_Car)
        Me.Panel7.Controls.Add(Me.Txt_Name)
        Me.Panel7.Controls.Add(Me.Txt_id)
        Me.Panel7.Controls.Add(Me.Table_Active1)
        Me.Panel7.Controls.Add(Me.Panel6)
        Me.Panel7.Controls.Add(Me.Panel2)
        Me.Panel7.Controls.Add(Me.Panel1)
        Me.Panel7.Controls.Add(Me.Divider)
        Me.Panel7.Controls.Add(Me.AddLabel)
        Me.Panel7.Controls.Add(Me.Back)
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(745, 540)
        Me.Panel7.TabIndex = 112
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 540)
        Me.Controls.Add(Me.Panel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.Panel6.ResumeLayout(False)
        CType(Me.Table_Active1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Back As Label
    Friend WithEvents AddLabel As Label
    Friend WithEvents Divider As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Table_Active1 As DataGridView
    Friend WithEvents Txt_id As TextBox
    Friend WithEvents Txt_Name As TextBox
    Friend WithEvents Txt_Car As TextBox
    Friend WithEvents Txt_PlateNum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Car As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_PlateNum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_LotNum As TextBox
    Friend WithEvents DeleteButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Txt_Date As TextBox
    Friend WithEvents Txt_Time As TextBox
    Friend WithEvents Txt_LotNum As TextBox
    Friend WithEvents TextBox_Date As DateTimePicker
    Friend WithEvents ID As Label
    Friend WithEvents TextBox_id As TextBox
    Friend WithEvents Panel7 As Panel
End Class
