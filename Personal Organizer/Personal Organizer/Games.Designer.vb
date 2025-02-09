<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Games
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
        Button2 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        btnLogout = New Button()
        btn1 = New Button()
        btn3 = New Button()
        btn2 = New Button()
        btn6 = New Button()
        btn5 = New Button()
        btn4 = New Button()
        btn9 = New Button()
        btn8 = New Button()
        btn7 = New Button()
        btnRestart = New Button()
        lblStatus = New Label()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(70, 43)
        Button2.Name = "Button2"
        Button2.Size = New Size(146, 46)
        Button2.TabIndex = 10
        Button2.Text = "Profile"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(249, 43)
        Button4.Name = "Button4"
        Button4.Size = New Size(146, 46)
        Button4.TabIndex = 11
        Button4.Text = "Media"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(420, 43)
        Button3.Name = "Button3"
        Button3.Size = New Size(146, 46)
        Button3.TabIndex = 12
        Button3.Text = "Insight"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(647, 396)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(112, 42)
        btnLogout.TabIndex = 14
        btnLogout.Text = "Log Out"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(108, 131)
        btn1.Name = "btn1"
        btn1.Size = New Size(114, 84)
        btn1.TabIndex = 15
        btn1.Text = "Button1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Location = New Point(387, 134)
        btn3.Name = "btn3"
        btn3.Size = New Size(114, 84)
        btn3.TabIndex = 16
        btn3.Text = "btn3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Location = New Point(249, 132)
        btn2.Name = "btn2"
        btn2.Size = New Size(114, 84)
        btn2.TabIndex = 17
        btn2.Text = "Button6"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Location = New Point(387, 239)
        btn6.Name = "btn6"
        btn6.Size = New Size(114, 84)
        btn6.TabIndex = 18
        btn6.Text = "btn6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Location = New Point(249, 239)
        btn5.Name = "btn5"
        btn5.Size = New Size(114, 84)
        btn5.TabIndex = 19
        btn5.Text = "btn5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Location = New Point(108, 239)
        btn4.Name = "btn4"
        btn4.Size = New Size(114, 84)
        btn4.TabIndex = 20
        btn4.Text = "btn4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Location = New Point(387, 339)
        btn9.Name = "btn9"
        btn9.Size = New Size(114, 84)
        btn9.TabIndex = 21
        btn9.Text = "btn9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Location = New Point(249, 339)
        btn8.Name = "btn8"
        btn8.Size = New Size(114, 84)
        btn8.TabIndex = 22
        btn8.Text = "btn7"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Location = New Point(108, 339)
        btn7.Name = "btn7"
        btn7.Size = New Size(114, 84)
        btn7.TabIndex = 23
        btn7.Text = "btn7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btnRestart
        ' 
        btnRestart.Location = New Point(603, 228)
        btnRestart.Name = "btnRestart"
        btnRestart.Size = New Size(156, 48)
        btnRestart.TabIndex = 24
        btnRestart.Text = "Reset"
        btnRestart.UseVisualStyleBackColor = True
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(647, 177)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(60, 25)
        lblStatus.TabIndex = 25
        lblStatus.Text = "Status"
        ' 
        ' Games
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblStatus)
        Controls.Add(btnRestart)
        Controls.Add(btn7)
        Controls.Add(btn8)
        Controls.Add(btn9)
        Controls.Add(btn4)
        Controls.Add(btn5)
        Controls.Add(btn6)
        Controls.Add(btn2)
        Controls.Add(btn3)
        Controls.Add(btn1)
        Controls.Add(btnLogout)
        Controls.Add(Button3)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Name = "Games"
        Text = "Games"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents lblStatus As Label
End Class
