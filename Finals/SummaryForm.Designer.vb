<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        PictureBox1 = New PictureBox()
        NumberCustomersTextBox = New TextBox()
        TotalSalesTextBox = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        CloseButton = New Button()
        TicketSoldTextBox = New TextBox()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.bocchi_real_v0_u5f72eaixs8a12
        PictureBox1.Location = New Point(0, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(221, 318)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' NumberCustomersTextBox
        ' 
        NumberCustomersTextBox.BackColor = SystemColors.ControlLightLight
        NumberCustomersTextBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        NumberCustomersTextBox.ForeColor = Color.Black
        NumberCustomersTextBox.Location = New Point(437, 155)
        NumberCustomersTextBox.Name = "NumberCustomersTextBox"
        NumberCustomersTextBox.ReadOnly = True
        NumberCustomersTextBox.Size = New Size(113, 29)
        NumberCustomersTextBox.TabIndex = 28
        ' 
        ' TotalSalesTextBox
        ' 
        TotalSalesTextBox.BackColor = SystemColors.ControlLightLight
        TotalSalesTextBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TotalSalesTextBox.ForeColor = Color.Black
        TotalSalesTextBox.Location = New Point(437, 79)
        TotalSalesTextBox.Name = "TotalSalesTextBox"
        TotalSalesTextBox.ReadOnly = True
        TotalSalesTextBox.Size = New Size(113, 29)
        TotalSalesTextBox.TabIndex = 26
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(266, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(165, 21)
        Label3.TabIndex = 25
        Label3.Text = "Number of Customers"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(349, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 21)
        Label1.TabIndex = 23
        Label1.Text = "Total Sales"
        ' 
        ' CloseButton
        ' 
        CloseButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        CloseButton.Location = New Point(461, 215)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(89, 33)
        CloseButton.TabIndex = 29
        CloseButton.Text = "Close"
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' TicketSoldTextBox
        ' 
        TicketSoldTextBox.BackColor = SystemColors.ControlLightLight
        TicketSoldTextBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TicketSoldTextBox.ForeColor = Color.Black
        TicketSoldTextBox.Location = New Point(437, 118)
        TicketSoldTextBox.Name = "TicketSoldTextBox"
        TicketSoldTextBox.ReadOnly = True
        TicketSoldTextBox.Size = New Size(113, 29)
        TicketSoldTextBox.TabIndex = 31
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(339, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 21)
        Label2.TabIndex = 30
        Label2.Text = "Tickets Sold"
        ' 
        ' SummaryForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(605, 300)
        Controls.Add(TicketSoldTextBox)
        Controls.Add(Label2)
        Controls.Add(CloseButton)
        Controls.Add(NumberCustomersTextBox)
        Controls.Add(TotalSalesTextBox)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "SummaryForm"
        Text = "Ticket Sales Summary"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NumberCustomersTextBox As TextBox
    Friend WithEvents TotalSalesTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents TicketSoldTextBox As TextBox
    Friend WithEvents Label2 As Label
End Class
