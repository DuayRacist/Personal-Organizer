<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        btnLogout = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        lblName = New Label()
        lblStrand = New Label()
        lblAge = New Label()
        SuspendLayout()
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(676, 396)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(112, 42)
        btnLogout.TabIndex = 3
        btnLogout.Text = "Log Out"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(97, 35)
        Button2.Name = "Button2"
        Button2.Size = New Size(146, 46)
        Button2.TabIndex = 5
        Button2.Text = "Media"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(430, 35)
        Button3.Name = "Button3"
        Button3.Size = New Size(146, 46)
        Button3.TabIndex = 6
        Button3.Text = "Insight"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(263, 35)
        Button4.Name = "Button4"
        Button4.Size = New Size(146, 46)
        Button4.TabIndex = 7
        Button4.Text = "Games"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(80, 127)
        lblName.Name = "lblName"
        lblName.Size = New Size(59, 25)
        lblName.TabIndex = 8
        lblName.Text = "Name"
        ' 
        ' lblStrand
        ' 
        lblStrand.AutoSize = True
        lblStrand.Location = New Point(80, 177)
        lblStrand.Name = "lblStrand"
        lblStrand.Size = New Size(63, 25)
        lblStrand.TabIndex = 10
        lblStrand.Text = "Strand"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Location = New Point(80, 152)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(44, 25)
        lblAge.TabIndex = 11
        lblAge.Text = "Age"
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblAge)
        Controls.Add(lblStrand)
        Controls.Add(lblName)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(btnLogout)
        Name = "Main"
        Text = "Main"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnLogout As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblStrand As Label
    Friend WithEvents lblAge As Label
End Class
