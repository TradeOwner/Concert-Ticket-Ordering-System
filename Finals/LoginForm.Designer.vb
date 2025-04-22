<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        LoginButton = New Button()
        ExitButton = New Button()
        UserTextBox = New TextBox()
        PassTextBox = New TextBox()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LoginButton
        ' 
        LoginButton.BackColor = Color.CornflowerBlue
        LoginButton.ForeColor = SystemColors.ButtonFace
        LoginButton.Location = New Point(29, 111)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(255, 23)
        LoginButton.TabIndex = 0
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' ExitButton
        ' 
        ExitButton.BackColor = Color.Goldenrod
        ExitButton.ForeColor = SystemColors.ButtonFace
        ExitButton.Location = New Point(29, 140)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(255, 23)
        ExitButton.TabIndex = 1
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' UserTextBox
        ' 
        UserTextBox.Location = New Point(29, 52)
        UserTextBox.Name = "UserTextBox"
        UserTextBox.Size = New Size(255, 23)
        UserTextBox.TabIndex = 2
        ' 
        ' PassTextBox
        ' 
        PassTextBox.Location = New Point(29, 81)
        PassTextBox.Name = "PassTextBox"
        PassTextBox.PasswordChar = "*"c
        PassTextBox.Size = New Size(255, 23)
        PassTextBox.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(PassTextBox)
        GroupBox1.Controls.Add(LoginButton)
        GroupBox1.Controls.Add(ExitButton)
        GroupBox1.Controls.Add(UserTextBox)
        GroupBox1.Location = New Point(-10, 192)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(333, 179)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(44, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(228, 17)
        Label1.TabIndex = 4
        Label1.Text = "Enter a valid username and password"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(64, 42)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(176, 104)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(293, 369)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LoginButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents PassTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
