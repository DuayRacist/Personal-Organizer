<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Media
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
        Button3 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        btnLogout = New Button()
        Button1 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(432, 37)
        Button3.Name = "Button3"
        Button3.Size = New Size(146, 46)
        Button3.TabIndex = 7
        Button3.Text = "Insight"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(273, 37)
        Button4.Name = "Button4"
        Button4.Size = New Size(146, 46)
        Button4.TabIndex = 8
        Button4.Text = "Games"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(112, 37)
        Button2.Name = "Button2"
        Button2.Size = New Size(146, 46)
        Button2.TabIndex = 9
        Button2.Text = "Profile"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(619, 396)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(112, 42)
        btnLogout.TabIndex = 13
        btnLogout.Text = "Log Out"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(80, 205)
        Button1.Name = "Button1"
        Button1.Size = New Size(206, 58)
        Button1.TabIndex = 14
        Button1.Text = "Music"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(292, 205)
        Button5.Name = "Button5"
        Button5.Size = New Size(206, 58)
        Button5.TabIndex = 15
        Button5.Text = "Photos"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(504, 205)
        Button6.Name = "Button6"
        Button6.Size = New Size(206, 58)
        Button6.TabIndex = 16
        Button6.Text = "Video"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Media
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button1)
        Controls.Add(btnLogout)
        Controls.Add(Button2)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Name = "Media"
        Text = "Media"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
