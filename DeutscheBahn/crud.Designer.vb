<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crud
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.addtodbBtn = New System.Windows.Forms.Button()
        Me.deletefromtblBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.routeidBox = New System.Windows.Forms.TextBox()
        Me.locidBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.idBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.stationTable = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.seat_id = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.identification = New System.Windows.Forms.TextBox()
        Me.passgr_name = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tickets = New System.Windows.Forms.TextBox()
        Me.tkt_id = New System.Windows.Forms.Label()
        Me.invo_id = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.inv_table = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.name_box = New System.Windows.Forms.TextBox()
        Me.Train = New System.Windows.Forms.Label()
        Me.train_id_box = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbl_train = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.stationTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.inv_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.tbl_train, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Medium", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Deutsche Bahn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Database Operation"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(33, 76)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(687, 417)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.addtodbBtn)
        Me.TabPage1.Controls.Add(Me.deletefromtblBtn)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.routeidBox)
        Me.TabPage1.Controls.Add(Me.locidBox)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.nameBox)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.idBox)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.stationTable)
        Me.TabPage1.Font = New System.Drawing.Font("Roboto Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(679, 391)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Station"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'addtodbBtn
        '
        Me.addtodbBtn.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addtodbBtn.Location = New System.Drawing.Point(560, 267)
        Me.addtodbBtn.Name = "addtodbBtn"
        Me.addtodbBtn.Size = New System.Drawing.Size(75, 57)
        Me.addtodbBtn.TabIndex = 11
        Me.addtodbBtn.Text = "ADD"
        Me.addtodbBtn.UseVisualStyleBackColor = True
        '
        'deletefromtblBtn
        '
        Me.deletefromtblBtn.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletefromtblBtn.Location = New System.Drawing.Point(560, 204)
        Me.deletefromtblBtn.Name = "deletefromtblBtn"
        Me.deletefromtblBtn.Size = New System.Drawing.Size(75, 57)
        Me.deletefromtblBtn.TabIndex = 10
        Me.deletefromtblBtn.Text = "DELETE"
        Me.deletefromtblBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(560, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 57)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "EDIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(289, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Route_ID"
        '
        'routeidBox
        '
        Me.routeidBox.Location = New System.Drawing.Point(354, 49)
        Me.routeidBox.Name = "routeidBox"
        Me.routeidBox.Size = New System.Drawing.Size(111, 30)
        Me.routeidBox.TabIndex = 7
        '
        'locidBox
        '
        Me.locidBox.Location = New System.Drawing.Point(354, 6)
        Me.locidBox.Name = "locidBox"
        Me.locidBox.Size = New System.Drawing.Size(111, 30)
        Me.locidBox.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(289, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Loc_ID"
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(112, 49)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(111, 30)
        Me.nameBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Name"
        '
        'idBox
        '
        Me.idBox.Location = New System.Drawing.Point(112, 6)
        Me.idBox.Name = "idBox"
        Me.idBox.Size = New System.Drawing.Size(111, 30)
        Me.idBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ID"
        '
        'stationTable
        '
        Me.stationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.stationTable.Location = New System.Drawing.Point(51, 117)
        Me.stationTable.Name = "stationTable"
        Me.stationTable.Size = New System.Drawing.Size(464, 239)
        Me.stationTable.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.seat_id)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.identification)
        Me.TabPage2.Controls.Add(Me.passgr_name)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.tickets)
        Me.TabPage2.Controls.Add(Me.tkt_id)
        Me.TabPage2.Controls.Add(Me.invo_id)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.inv_table)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(679, 391)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Invoice"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(450, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 15)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Seat ID"
        '
        'seat_id
        '
        Me.seat_id.Location = New System.Drawing.Point(535, 20)
        Me.seat_id.Name = "seat_id"
        Me.seat_id.Size = New System.Drawing.Size(111, 20)
        Me.seat_id.TabIndex = 24
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(558, 281)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 57)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(558, 218)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 57)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(558, 155)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 57)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "EDIT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(235, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 15)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Identification"
        '
        'identification
        '
        Me.identification.Location = New System.Drawing.Point(320, 66)
        Me.identification.Name = "identification"
        Me.identification.Size = New System.Drawing.Size(111, 20)
        Me.identification.TabIndex = 19
        '
        'passgr_name
        '
        Me.passgr_name.Location = New System.Drawing.Point(320, 20)
        Me.passgr_name.Name = "passgr_name"
        Me.passgr_name.Size = New System.Drawing.Size(111, 20)
        Me.passgr_name.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(251, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Name"
        '
        'tickets
        '
        Me.tickets.Location = New System.Drawing.Point(110, 67)
        Me.tickets.Name = "tickets"
        Me.tickets.Size = New System.Drawing.Size(111, 20)
        Me.tickets.TabIndex = 16
        '
        'tkt_id
        '
        Me.tkt_id.AutoSize = True
        Me.tkt_id.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tkt_id.Location = New System.Drawing.Point(46, 68)
        Me.tkt_id.Name = "tkt_id"
        Me.tkt_id.Size = New System.Drawing.Size(57, 15)
        Me.tkt_id.TabIndex = 15
        Me.tkt_id.Text = "Ticket ID"
        '
        'invo_id
        '
        Me.invo_id.Location = New System.Drawing.Point(110, 20)
        Me.invo_id.Name = "invo_id"
        Me.invo_id.Size = New System.Drawing.Size(111, 20)
        Me.invo_id.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(46, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 15)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "ID"
        '
        'inv_table
        '
        Me.inv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.inv_table.Location = New System.Drawing.Point(49, 131)
        Me.inv_table.Name = "inv_table"
        Me.inv_table.Size = New System.Drawing.Size(464, 239)
        Me.inv_table.TabIndex = 12
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btn_add)
        Me.TabPage3.Controls.Add(Me.btn_delete)
        Me.TabPage3.Controls.Add(Me.btn_edit)
        Me.TabPage3.Controls.Add(Me.name_box)
        Me.TabPage3.Controls.Add(Me.Train)
        Me.TabPage3.Controls.Add(Me.train_id_box)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.tbl_train)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(679, 391)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Train"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(551, 281)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 57)
        Me.btn_add.TabIndex = 37
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(551, 218)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 57)
        Me.btn_delete.TabIndex = 36
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(551, 155)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 57)
        Me.btn_edit.TabIndex = 35
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'name_box
        '
        Me.name_box.Location = New System.Drawing.Point(131, 67)
        Me.name_box.Name = "name_box"
        Me.name_box.Size = New System.Drawing.Size(111, 20)
        Me.name_box.TabIndex = 30
        '
        'Train
        '
        Me.Train.AutoSize = True
        Me.Train.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Train.Location = New System.Drawing.Point(39, 68)
        Me.Train.Name = "Train"
        Me.Train.Size = New System.Drawing.Size(74, 15)
        Me.Train.TabIndex = 29
        Me.Train.Text = "Train Name"
        '
        'train_id_box
        '
        Me.train_id_box.Location = New System.Drawing.Point(131, 20)
        Me.train_id_box.Name = "train_id_box"
        Me.train_id_box.Size = New System.Drawing.Size(111, 20)
        Me.train_id_box.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(39, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 15)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Train ID"
        '
        'tbl_train
        '
        Me.tbl_train.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tbl_train.Location = New System.Drawing.Point(42, 131)
        Me.tbl_train.Name = "tbl_train"
        Me.tbl_train.Size = New System.Drawing.Size(464, 239)
        Me.tbl_train.TabIndex = 26
        '
        'crud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 566)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "crud"
        Me.Text = "Form2"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.stationTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.inv_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.tbl_train, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents stationTable As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents addtodbBtn As Button
    Friend WithEvents deletefromtblBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents routeidBox As TextBox
    Friend WithEvents locidBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nameBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents idBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents seat_id As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents identification As TextBox
    Friend WithEvents passgr_name As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tickets As TextBox
    Friend WithEvents tkt_id As Label
    Friend WithEvents invo_id As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents inv_table As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents name_box As TextBox
    Friend WithEvents Train As Label
    Friend WithEvents train_id_box As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tbl_train As DataGridView
End Class
