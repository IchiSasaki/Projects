<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Txt_LotNum1 = New System.Windows.Forms.TextBox()
        Me.Txt_Time1 = New System.Windows.Forms.TextBox()
        Me.Txt_Date1 = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_PlateNum1 = New System.Windows.Forms.TextBox()
        Me.Txt_Car1 = New System.Windows.Forms.TextBox()
        Me.Txt_Name1 = New System.Windows.Forms.TextBox()
        Me.Txt_id1 = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Divider = New System.Windows.Forms.Label()
        Me.AddLabel = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Label()
        Me.Table_History = New System.Windows.Forms.DataGridView()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.Table_History, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_LotNum1
        '
        Me.Txt_LotNum1.Location = New System.Drawing.Point(633, 104)
        Me.Txt_LotNum1.Name = "Txt_LotNum1"
        Me.Txt_LotNum1.Size = New System.Drawing.Size(96, 20)
        Me.Txt_LotNum1.TabIndex = 138
        '
        'Txt_Time1
        '
        Me.Txt_Time1.Location = New System.Drawing.Point(530, 104)
        Me.Txt_Time1.Name = "Txt_Time1"
        Me.Txt_Time1.Size = New System.Drawing.Size(96, 20)
        Me.Txt_Time1.TabIndex = 137
        '
        'Txt_Date1
        '
        Me.Txt_Date1.Location = New System.Drawing.Point(427, 104)
        Me.Txt_Date1.Name = "Txt_Date1"
        Me.Txt_Date1.Size = New System.Drawing.Size(96, 20)
        Me.Txt_Date1.TabIndex = 136
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel5.Location = New System.Drawing.Point(-727, -1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(2, 464)
        Me.Panel5.TabIndex = 86
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(6, 62)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 464)
        Me.Panel4.TabIndex = 118
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 135
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(-727, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 464)
        Me.Panel3.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 21)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Search"
        '
        'Txt_PlateNum1
        '
        Me.Txt_PlateNum1.Location = New System.Drawing.Point(324, 103)
        Me.Txt_PlateNum1.Name = "Txt_PlateNum1"
        Me.Txt_PlateNum1.Size = New System.Drawing.Size(96, 20)
        Me.Txt_PlateNum1.TabIndex = 122
        '
        'Txt_Car1
        '
        Me.Txt_Car1.Location = New System.Drawing.Point(221, 103)
        Me.Txt_Car1.Name = "Txt_Car1"
        Me.Txt_Car1.Size = New System.Drawing.Size(96, 20)
        Me.Txt_Car1.TabIndex = 121
        '
        'Txt_Name1
        '
        Me.Txt_Name1.Location = New System.Drawing.Point(118, 104)
        Me.Txt_Name1.Name = "Txt_Name1"
        Me.Txt_Name1.Size = New System.Drawing.Size(96, 20)
        Me.Txt_Name1.TabIndex = 120
        '
        'Txt_id1
        '
        Me.Txt_id1.Location = New System.Drawing.Point(15, 103)
        Me.Txt_id1.Name = "Txt_id1"
        Me.Txt_id1.Size = New System.Drawing.Size(96, 20)
        Me.Txt_id1.TabIndex = 119
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel6.Controls.Add(Me.Panel3)
        Me.Panel6.Location = New System.Drawing.Point(736, 62)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(2, 464)
        Me.Panel6.TabIndex = 116
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(6, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(732, 2)
        Me.Panel2.TabIndex = 115
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(6, 524)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(732, 2)
        Me.Panel1.TabIndex = 114
        '
        'Divider
        '
        Me.Divider.AutoSize = True
        Me.Divider.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider.Location = New System.Drawing.Point(100, 19)
        Me.Divider.Name = "Divider"
        Me.Divider.Size = New System.Drawing.Size(13, 21)
        Me.Divider.TabIndex = 113
        Me.Divider.Text = "|"
        '
        'AddLabel
        '
        Me.AddLabel.AutoSize = True
        Me.AddLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddLabel.Location = New System.Drawing.Point(128, 19)
        Me.AddLabel.Name = "AddLabel"
        Me.AddLabel.Size = New System.Drawing.Size(157, 21)
        Me.AddLabel.TabIndex = 112
        Me.AddLabel.Text = "Transaction History"
        '
        'Back
        '
        Me.Back.AutoSize = True
        Me.Back.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(46, 19)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(48, 21)
        Me.Back.TabIndex = 111
        Me.Back.Text = "Back"
        '
        'Table_History
        '
        Me.Table_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table_History.Location = New System.Drawing.Point(15, 130)
        Me.Table_History.Name = "Table_History"
        Me.Table_History.Size = New System.Drawing.Size(714, 388)
        Me.Table_History.TabIndex = 139
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 540)
        Me.Controls.Add(Me.Table_History)
        Me.Controls.Add(Me.Txt_LotNum1)
        Me.Controls.Add(Me.Txt_Time1)
        Me.Controls.Add(Me.Txt_Date1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txt_PlateNum1)
        Me.Controls.Add(Me.Txt_Car1)
        Me.Controls.Add(Me.Txt_Name1)
        Me.Controls.Add(Me.Txt_id1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Divider)
        Me.Controls.Add(Me.AddLabel)
        Me.Controls.Add(Me.Back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form5"
        Me.Text = " "
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.Table_History, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_LotNum1 As TextBox
    Friend WithEvents Txt_Time1 As TextBox
    Friend WithEvents Txt_Date1 As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_PlateNum1 As TextBox
    Friend WithEvents Txt_Car1 As TextBox
    Friend WithEvents Txt_Name1 As TextBox
    Friend WithEvents Txt_id1 As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Divider As Label
    Friend WithEvents AddLabel As Label
    Friend WithEvents Back As Label
    Friend WithEvents Table_History As DataGridView
End Class
