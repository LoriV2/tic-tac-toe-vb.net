<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.X_O_1 = New System.Windows.Forms.Button()
        Me.X_O_2 = New System.Windows.Forms.Button()
        Me.X_O_3 = New System.Windows.Forms.Button()
        Me.X_O_5 = New System.Windows.Forms.Button()
        Me.X_O_6 = New System.Windows.Forms.Button()
        Me.X_O_4 = New System.Windows.Forms.Button()
        Me.X_O_7 = New System.Windows.Forms.Button()
        Me.X_O_8 = New System.Windows.Forms.Button()
        Me.X_O_9 = New System.Windows.Forms.Button()
        Me.Player_turn_label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Start_btn = New System.Windows.Forms.Button()
        Me.O_wis = New System.Windows.Forms.Label()
        Me.X_win = New System.Windows.Forms.Label()
        Me.O_wins = New System.Windows.Forms.Label()
        Me.X_wins = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'X_O_1
        '
        Me.X_O_1.FlatAppearance.BorderSize = 0
        Me.X_O_1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.X_O_1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.X_O_1.Location = New System.Drawing.Point(37, 30)
        Me.X_O_1.Name = "X_O_1"
        Me.X_O_1.Size = New System.Drawing.Size(73, 62)
        Me.X_O_1.TabIndex = 0
        Me.X_O_1.UseVisualStyleBackColor = True
        '
        'X_O_2
        '
        Me.X_O_2.FlatAppearance.BorderSize = 0
        Me.X_O_2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.X_O_2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.X_O_2.Location = New System.Drawing.Point(116, 30)
        Me.X_O_2.Name = "X_O_2"
        Me.X_O_2.Size = New System.Drawing.Size(73, 62)
        Me.X_O_2.TabIndex = 1
        Me.X_O_2.UseVisualStyleBackColor = True
        '
        'X_O_3
        '
        Me.X_O_3.FlatAppearance.BorderSize = 0
        Me.X_O_3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.X_O_3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.X_O_3.Location = New System.Drawing.Point(195, 30)
        Me.X_O_3.Name = "X_O_3"
        Me.X_O_3.Size = New System.Drawing.Size(73, 62)
        Me.X_O_3.TabIndex = 2
        Me.X_O_3.UseVisualStyleBackColor = True
        '
        'X_O_5
        '
        Me.X_O_5.FlatAppearance.BorderSize = 0
        Me.X_O_5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.X_O_5.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.X_O_5.Location = New System.Drawing.Point(116, 98)
        Me.X_O_5.Name = "X_O_5"
        Me.X_O_5.Size = New System.Drawing.Size(73, 62)
        Me.X_O_5.TabIndex = 3
        Me.X_O_5.UseVisualStyleBackColor = True
        '
        'X_O_6
        '
        Me.X_O_6.FlatAppearance.BorderSize = 0
        Me.X_O_6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.X_O_6.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.X_O_6.Location = New System.Drawing.Point(195, 98)
        Me.X_O_6.Name = "X_O_6"
        Me.X_O_6.Size = New System.Drawing.Size(73, 62)
        Me.X_O_6.TabIndex = 4
        Me.X_O_6.UseVisualStyleBackColor = True
        '
        'X_O_4
        '
        Me.X_O_4.FlatAppearance.BorderSize = 0
        Me.X_O_4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.X_O_4.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.X_O_4.Location = New System.Drawing.Point(37, 98)
        Me.X_O_4.Name = "X_O_4"
        Me.X_O_4.Size = New System.Drawing.Size(73, 62)
        Me.X_O_4.TabIndex = 5
        Me.X_O_4.UseVisualStyleBackColor = True
        '
        'X_O_7
        '
        Me.X_O_7.FlatAppearance.BorderSize = 0
        Me.X_O_7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.X_O_7.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.X_O_7.Location = New System.Drawing.Point(37, 166)
        Me.X_O_7.Name = "X_O_7"
        Me.X_O_7.Size = New System.Drawing.Size(73, 62)
        Me.X_O_7.TabIndex = 6
        Me.X_O_7.UseVisualStyleBackColor = True
        '
        'X_O_8
        '
        Me.X_O_8.FlatAppearance.BorderSize = 0
        Me.X_O_8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.X_O_8.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.X_O_8.Location = New System.Drawing.Point(116, 166)
        Me.X_O_8.Name = "X_O_8"
        Me.X_O_8.Size = New System.Drawing.Size(73, 62)
        Me.X_O_8.TabIndex = 7
        Me.X_O_8.UseVisualStyleBackColor = True
        '
        'X_O_9
        '
        Me.X_O_9.FlatAppearance.BorderSize = 0
        Me.X_O_9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.X_O_9.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.X_O_9.Location = New System.Drawing.Point(195, 166)
        Me.X_O_9.Name = "X_O_9"
        Me.X_O_9.Size = New System.Drawing.Size(73, 62)
        Me.X_O_9.TabIndex = 8
        Me.X_O_9.UseVisualStyleBackColor = True
        '
        'Player_turn_label
        '
        Me.Player_turn_label.AutoSize = True
        Me.Player_turn_label.Location = New System.Drawing.Point(141, 9)
        Me.Player_turn_label.Name = "Player_turn_label"
        Me.Player_turn_label.Size = New System.Drawing.Size(16, 15)
        Me.Player_turn_label.TabIndex = 9
        Me.Player_turn_label.Text = "..."
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Start_btn
        '
        Me.Start_btn.Location = New System.Drawing.Point(307, 30)
        Me.Start_btn.Name = "Start_btn"
        Me.Start_btn.Size = New System.Drawing.Size(73, 23)
        Me.Start_btn.TabIndex = 10
        Me.Start_btn.Text = "Start"
        Me.Start_btn.UseVisualStyleBackColor = True
        '
        'O_wis
        '
        Me.O_wis.AutoSize = True
        Me.O_wis.Location = New System.Drawing.Point(274, 77)
        Me.O_wis.Name = "O_wis"
        Me.O_wis.Size = New System.Drawing.Size(46, 15)
        Me.O_wis.TabIndex = 11
        Me.O_wis.Text = "O wins:"
        '
        'X_win
        '
        Me.X_win.AutoSize = True
        Me.X_win.Location = New System.Drawing.Point(274, 98)
        Me.X_win.Name = "X_win"
        Me.X_win.Size = New System.Drawing.Size(44, 15)
        Me.X_win.TabIndex = 12
        Me.X_win.Text = "X wins:"
        '
        'O_wins
        '
        Me.O_wins.AutoSize = True
        Me.O_wins.Location = New System.Drawing.Point(324, 77)
        Me.O_wins.Name = "O_wins"
        Me.O_wins.Size = New System.Drawing.Size(13, 15)
        Me.O_wins.TabIndex = 13
        Me.O_wins.Text = "0"
        '
        'X_wins
        '
        Me.X_wins.AutoSize = True
        Me.X_wins.Location = New System.Drawing.Point(324, 98)
        Me.X_wins.Name = "X_wins"
        Me.X_wins.Size = New System.Drawing.Size(13, 15)
        Me.X_wins.TabIndex = 14
        Me.X_wins.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 252)
        Me.Controls.Add(Me.X_wins)
        Me.Controls.Add(Me.O_wins)
        Me.Controls.Add(Me.X_win)
        Me.Controls.Add(Me.O_wis)
        Me.Controls.Add(Me.Start_btn)
        Me.Controls.Add(Me.Player_turn_label)
        Me.Controls.Add(Me.X_O_9)
        Me.Controls.Add(Me.X_O_8)
        Me.Controls.Add(Me.X_O_7)
        Me.Controls.Add(Me.X_O_4)
        Me.Controls.Add(Me.X_O_6)
        Me.Controls.Add(Me.X_O_5)
        Me.Controls.Add(Me.X_O_3)
        Me.Controls.Add(Me.X_O_2)
        Me.Controls.Add(Me.X_O_1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents X_O_1 As Button
    Friend WithEvents X_O_2 As Button
    Friend WithEvents X_O_3 As Button
    Friend WithEvents X_O_5 As Button
    Friend WithEvents X_O_6 As Button
    Friend WithEvents X_O_4 As Button
    Friend WithEvents X_O_7 As Button
    Friend WithEvents X_O_8 As Button
    Friend WithEvents X_O_9 As Button
    Friend WithEvents Player_turn_label As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Start_btn As Button
    Friend WithEvents O_wis As Label
    Friend WithEvents X_win As Label
    Friend WithEvents O_wins As Label
    Friend WithEvents X_wins As Label
End Class
