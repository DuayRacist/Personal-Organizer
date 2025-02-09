<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Insight
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
        Button1 = New Button()
        btnLogout = New Button()
        txtInsight = New Label()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(69, 61)
        Button2.Name = "Button2"
        Button2.Size = New Size(146, 46)
        Button2.TabIndex = 10
        Button2.Text = "Profile"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(255, 61)
        Button4.Name = "Button4"
        Button4.Size = New Size(146, 46)
        Button4.TabIndex = 12
        Button4.Text = "Media"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(425, 61)
        Button1.Name = "Button1"
        Button1.Size = New Size(146, 46)
        Button1.TabIndex = 13
        Button1.Text = "Games"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(611, 396)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(112, 42)
        btnLogout.TabIndex = 15
        btnLogout.Text = "Log Out"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' txtInsight
        ' 
        txtInsight.AutoSize = True
        txtInsight.Location = New Point(45, 152)
        txtInsight.Name = "txtInsight"
        txtInsight.Size = New Size(66, 25)
        txtInsight.TabIndex = 16
        txtInsight.Text = "Insight"
        ' 
        ' Insight
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtInsight)
        Controls.Add(btnLogout)
        Controls.Add(Button1)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Name = "Insight"
        Text = "Insight"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents txtInsight As Label
End Class
