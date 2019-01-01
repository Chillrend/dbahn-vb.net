<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class success_page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(success_page))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.passenger_counter = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.inv_code = New System.Windows.Forms.Label()
        Me.passgr_name = New System.Windows.Forms.Label()
        Me.tr_seat_name = New System.Windows.Forms.Label()
        Me.dep_date_time = New System.Windows.Forms.Label()
        Me.station = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.next_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.print_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Light", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Ticket Succesfuly Booked !"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto Medium", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Success!"
        '
        'passenger_counter
        '
        Me.passenger_counter.AutoSize = True
        Me.passenger_counter.Font = New System.Drawing.Font("Roboto Light", 14.0!)
        Me.passenger_counter.ForeColor = System.Drawing.Color.Black
        Me.passenger_counter.Location = New System.Drawing.Point(13, 80)
        Me.passenger_counter.Name = "passenger_counter"
        Me.passenger_counter.Size = New System.Drawing.Size(187, 23)
        Me.passenger_counter.TabIndex = 12
        Me.passenger_counter.Text = "Passenger #1 Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Booking ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(13, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Train and Seat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(13, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Departure Date/Time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(13, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Station From - To"
        '
        'inv_code
        '
        Me.inv_code.AutoSize = True
        Me.inv_code.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inv_code.ForeColor = System.Drawing.Color.Black
        Me.inv_code.Location = New System.Drawing.Point(238, 118)
        Me.inv_code.Name = "inv_code"
        Me.inv_code.Size = New System.Drawing.Size(265, 18)
        Me.inv_code.TabIndex = 18
        Me.inv_code.Text = "ff6de1f5-c2ff-413b-aed8-aec058e3a307"
        '
        'passgr_name
        '
        Me.passgr_name.AutoSize = True
        Me.passgr_name.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passgr_name.ForeColor = System.Drawing.Color.Black
        Me.passgr_name.Location = New System.Drawing.Point(238, 154)
        Me.passgr_name.Name = "passgr_name"
        Me.passgr_name.Size = New System.Drawing.Size(76, 18)
        Me.passgr_name.TabIndex = 19
        Me.passgr_name.Text = "Ello There"
        '
        'tr_seat_name
        '
        Me.tr_seat_name.AutoSize = True
        Me.tr_seat_name.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tr_seat_name.ForeColor = System.Drawing.Color.Black
        Me.tr_seat_name.Location = New System.Drawing.Point(238, 193)
        Me.tr_seat_name.Name = "tr_seat_name"
        Me.tr_seat_name.Size = New System.Drawing.Size(61, 18)
        Me.tr_seat_name.TabIndex = 20
        Me.tr_seat_name.Text = "Kolnzug"
        '
        'dep_date_time
        '
        Me.dep_date_time.AutoSize = True
        Me.dep_date_time.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dep_date_time.ForeColor = System.Drawing.Color.Black
        Me.dep_date_time.Location = New System.Drawing.Point(238, 229)
        Me.dep_date_time.Name = "dep_date_time"
        Me.dep_date_time.Size = New System.Drawing.Size(88, 18)
        Me.dep_date_time.TabIndex = 21
        Me.dep_date_time.Text = "19 -01 -2019"
        '
        'station
        '
        Me.station.AutoSize = True
        Me.station.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.station.ForeColor = System.Drawing.Color.Black
        Me.station.Location = New System.Drawing.Point(238, 267)
        Me.station.Name = "station"
        Me.station.Size = New System.Drawing.Size(167, 18)
        Me.station.TabIndex = 22
        Me.station.Text = "Koln Hbf - Hamburg Hbf"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(12, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(438, 15)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Please Write-down the Booking ID if you want to print the tickets at the station"
        '
        'next_btn
        '
        Me.next_btn.Location = New System.Drawing.Point(479, 319)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(75, 23)
        Me.next_btn.TabIndex = 24
        Me.next_btn.Text = "Next"
        Me.next_btn.UseVisualStyleBackColor = True
        '
        'exit_btn
        '
        Me.exit_btn.Location = New System.Drawing.Point(398, 319)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(75, 23)
        Me.exit_btn.TabIndex = 25
        Me.exit_btn.Text = "Done"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'print_btn
        '
        Me.print_btn.Location = New System.Drawing.Point(317, 319)
        Me.print_btn.Name = "print_btn"
        Me.print_btn.Size = New System.Drawing.Size(75, 23)
        Me.print_btn.TabIndex = 26
        Me.print_btn.Text = "Print"
        Me.print_btn.UseVisualStyleBackColor = True
        '
        'success_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 354)
        Me.Controls.Add(Me.print_btn)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.next_btn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.station)
        Me.Controls.Add(Me.dep_date_time)
        Me.Controls.Add(Me.tr_seat_name)
        Me.Controls.Add(Me.passgr_name)
        Me.Controls.Add(Me.inv_code)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.passenger_counter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Roboto Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.name = "success_page"
        Me.Text = "Success!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents passenger_counter As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents inv_code As Label
    Friend WithEvents passgr_name As Label
    Friend WithEvents tr_seat_name As Label
    Friend WithEvents dep_date_time As Label
    Friend WithEvents station As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents next_btn As Button
    Friend WithEvents exit_btn As Button
    Friend WithEvents print_btn As Button
End Class
