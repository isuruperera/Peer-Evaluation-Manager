<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Me.peerIndexNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.peerName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.peerSubject = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.peerLesson = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.peerStatus = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.peerDate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Index No"
        '
        'peerIndexNo
        '
        Me.peerIndexNo.Location = New System.Drawing.Point(69, 10)
        Me.peerIndexNo.Name = "peerIndexNo"
        Me.peerIndexNo.Size = New System.Drawing.Size(202, 20)
        Me.peerIndexNo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'peerName
        '
        Me.peerName.Location = New System.Drawing.Point(70, 37)
        Me.peerName.Name = "peerName"
        Me.peerName.Size = New System.Drawing.Size(202, 20)
        Me.peerName.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(196, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'peerSubject
        '
        Me.peerSubject.Location = New System.Drawing.Point(70, 63)
        Me.peerSubject.Name = "peerSubject"
        Me.peerSubject.Size = New System.Drawing.Size(202, 20)
        Me.peerSubject.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Subject"
        '
        'peerLesson
        '
        Me.peerLesson.Location = New System.Drawing.Point(70, 89)
        Me.peerLesson.Name = "peerLesson"
        Me.peerLesson.Size = New System.Drawing.Size(202, 20)
        Me.peerLesson.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Lesson"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Status"
        '
        'peerStatus
        '
        Me.peerStatus.FormattingEnabled = True
        Me.peerStatus.Items.AddRange(New Object() {"Incomplete", "Complete"})
        Me.peerStatus.Location = New System.Drawing.Point(67, 141)
        Me.peerStatus.Name = "peerStatus"
        Me.peerStatus.Size = New System.Drawing.Size(202, 21)
        Me.peerStatus.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Date"
        '
        'peerDate
        '
        Me.peerDate.Location = New System.Drawing.Point(69, 115)
        Me.peerDate.Name = "peerDate"
        Me.peerDate.Size = New System.Drawing.Size(200, 20)
        Me.peerDate.TabIndex = 14
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(284, 215)
        Me.Controls.Add(Me.peerDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.peerStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.peerLesson)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.peerSubject)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.peerName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.peerIndexNo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "AddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents peerIndexNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents peerName As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents peerSubject As TextBox
    Friend WithEvents peerLesson As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents peerStatus As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents peerDate As DateTimePicker
End Class
