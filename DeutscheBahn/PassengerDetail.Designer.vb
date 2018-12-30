<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PassengerDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PassengerDetail))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FormCounter = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.passgr_name = New System.Windows.Forms.TextBox()
        Me.passgr_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Light", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Insert Passenger Detail For Passenger #"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto Medium", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(252, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fill Passenger Detail"
        '
        'FormCounter
        '
        Me.FormCounter.AutoSize = True
        Me.FormCounter.Font = New System.Drawing.Font("Roboto Light", 14.0!)
        Me.FormCounter.ForeColor = System.Drawing.Color.Black
        Me.FormCounter.Location = New System.Drawing.Point(354, 38)
        Me.FormCounter.Name = "FormCounter"
        Me.FormCounter.Size = New System.Drawing.Size(21, 23)
        Me.FormCounter.TabIndex = 10
        Me.FormCounter.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Light", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Name"
        '
        'passgr_name
        '
        Me.passgr_name.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passgr_name.Location = New System.Drawing.Point(17, 112)
        Me.passgr_name.Name = "passgr_name"
        Me.passgr_name.Size = New System.Drawing.Size(135, 27)
        Me.passgr_name.TabIndex = 12
        '
        'passgr_id
        '
        Me.passgr_id.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passgr_id.Location = New System.Drawing.Point(17, 168)
        Me.passgr_id.Name = "passgr_id"
        Me.passgr_id.Size = New System.Drawing.Size(247, 27)
        Me.passgr_id.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Light", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Identification Number"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Roboto Light", 9.75!)
        Me.Button1.Location = New System.Drawing.Point(17, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(98, 223)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Next"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PassengerDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 258)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.passgr_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.passgr_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FormCounter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PassengerDetail"
        Me.Text = "Passenger Detail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FormCounter As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents passgr_name As TextBox
    Friend WithEvents passgr_id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
