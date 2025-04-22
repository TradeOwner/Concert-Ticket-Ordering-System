<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MainForm))
        SummaryButton = New Button()
        PrintButton = New Button()
        LogoutButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TicketPriceTextBox = New TextBox()
        QuantityTextBox = New TextBox()
        CashAmountTextBox = New TextBox()
        ChangeTextBox = New TextBox()
        TotalTextBox = New TextBox()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        SequenceTextBox = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        ExitButton = New Button()
        TicketTypeComboBox = New ComboBox()
        TicketTypeButton = New Button()
        Button1 = New Button()
        Button2 = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SummaryButton
        ' 
        SummaryButton.BackColor = Color.Goldenrod
        SummaryButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SummaryButton.ForeColor = Color.White
        SummaryButton.Location = New Point(33, 402)
        SummaryButton.Name = "SummaryButton"
        SummaryButton.Size = New Size(149, 50)
        SummaryButton.TabIndex = 0
        SummaryButton.Text = "Summary"
        SummaryButton.UseVisualStyleBackColor = False
        ' 
        ' PrintButton
        ' 
        PrintButton.BackColor = Color.Firebrick
        PrintButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PrintButton.ForeColor = Color.White
        PrintButton.Location = New Point(209, 402)
        PrintButton.Name = "PrintButton"
        PrintButton.Size = New Size(163, 50)
        PrintButton.TabIndex = 1
        PrintButton.Text = "Print"
        PrintButton.UseVisualStyleBackColor = False
        ' 
        ' LogoutButton
        ' 
        LogoutButton.BackColor = Color.Peru
        LogoutButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LogoutButton.ForeColor = Color.White
        LogoutButton.Location = New Point(2, 1)
        LogoutButton.Name = "LogoutButton"
        LogoutButton.Size = New Size(147, 50)
        LogoutButton.TabIndex = 3
        LogoutButton.Text = "Logout"
        LogoutButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(341, 174)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 21)
        Label1.TabIndex = 4
        Label1.Text = "Ticket Price"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(341, 210)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 21)
        Label2.TabIndex = 5
        Label2.Text = "Quantity"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(341, 261)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 21)
        Label3.TabIndex = 6
        Label3.Text = "Total Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(341, 296)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 21)
        Label4.TabIndex = 7
        Label4.Text = "Cash Amount"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(341, 335)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 21)
        Label5.TabIndex = 8
        Label5.Text = "Change"
        ' 
        ' TicketPriceTextBox
        ' 
        TicketPriceTextBox.BorderStyle = BorderStyle.FixedSingle
        TicketPriceTextBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TicketPriceTextBox.Location = New Point(475, 174)
        TicketPriceTextBox.Name = "TicketPriceTextBox"
        TicketPriceTextBox.ReadOnly = True
        TicketPriceTextBox.Size = New Size(256, 29)
        TicketPriceTextBox.TabIndex = 11
        ' 
        ' QuantityTextBox
        ' 
        QuantityTextBox.BorderStyle = BorderStyle.FixedSingle
        QuantityTextBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        QuantityTextBox.Location = New Point(475, 213)
        QuantityTextBox.Name = "QuantityTextBox"
        QuantityTextBox.Size = New Size(256, 29)
        QuantityTextBox.TabIndex = 12
        ' 
        ' CashAmountTextBox
        ' 
        CashAmountTextBox.BorderStyle = BorderStyle.FixedSingle
        CashAmountTextBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CashAmountTextBox.Location = New Point(475, 296)
        CashAmountTextBox.Name = "CashAmountTextBox"
        CashAmountTextBox.Size = New Size(256, 29)
        CashAmountTextBox.TabIndex = 13
        ' 
        ' ChangeTextBox
        ' 
        ChangeTextBox.BorderStyle = BorderStyle.FixedSingle
        ChangeTextBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChangeTextBox.Location = New Point(475, 332)
        ChangeTextBox.Name = "ChangeTextBox"
        ChangeTextBox.ReadOnly = True
        ChangeTextBox.Size = New Size(256, 29)
        ChangeTextBox.TabIndex = 14
        ' 
        ' TotalTextBox
        ' 
        TotalTextBox.BorderStyle = BorderStyle.FixedSingle
        TotalTextBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TotalTextBox.Location = New Point(475, 261)
        TotalTextBox.Name = "TotalTextBox"
        TotalTextBox.ReadOnly = True
        TotalTextBox.Size = New Size(256, 29)
        TotalTextBox.TabIndex = 15
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(33, 77)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(223, 284)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(341, 77)
        Label6.Name = "Label6"
        Label6.Size = New Size(105, 21)
        Label6.TabIndex = 18
        Label6.Text = "Sequence No."
        ' 
        ' SequenceTextBox
        ' 
        SequenceTextBox.BorderStyle = BorderStyle.None
        SequenceTextBox.Font = New Font("Verdana", 33.75F, FontStyle.Regular, GraphicsUnit.Point)
        SequenceTextBox.Location = New Point(475, 61)
        SequenceTextBox.Name = "SequenceTextBox"
        SequenceTextBox.Size = New Size(203, 55)
        SequenceTextBox.TabIndex = 19
        SequenceTextBox.Text = "0"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(341, 125)
        Label7.Name = "Label7"
        Label7.Size = New Size(86, 21)
        Label7.TabIndex = 21
        Label7.Text = "Ticket Type"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Sitka Banner", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(240, 7)
        Label8.Name = "Label8"
        Label8.Size = New Size(333, 47)
        Label8.TabIndex = 23
        Label8.Text = "Ticket Purchasing System"
        ' 
        ' ExitButton
        ' 
        ExitButton.BackColor = Color.OliveDrab
        ExitButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ExitButton.ForeColor = Color.White
        ExitButton.Location = New Point(702, -1)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(96, 55)
        ExitButton.TabIndex = 24
        ExitButton.Text = "E&xit"
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' TicketTypeComboBox
        ' 
        TicketTypeComboBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TicketTypeComboBox.FormattingEnabled = True
        TicketTypeComboBox.Items.AddRange(New Object() {"VIP 7000yen", "1st Standing 4000yen", "1st with seat 2500yen", "2nd with seat 1500yen", "General seat 1000yen"})
        TicketTypeComboBox.Location = New Point(475, 125)
        TicketTypeComboBox.Name = "TicketTypeComboBox"
        TicketTypeComboBox.Size = New Size(203, 29)
        TicketTypeComboBox.TabIndex = 20
        ' 
        ' TicketTypeButton
        ' 
        TicketTypeButton.BackColor = Color.DarkGray
        TicketTypeButton.Location = New Point(684, 121)
        TicketTypeButton.Name = "TicketTypeButton"
        TicketTypeButton.Size = New Size(47, 39)
        TicketTypeButton.TabIndex = 25
        TicketTypeButton.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.PaleVioletRed
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(407, 402)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 50)
        Button1.TabIndex = 26
        Button1.Text = "Total Price"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SteelBlue
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(597, 402)
        Button2.Name = "Button2"
        Button2.Size = New Size(166, 50)
        Button2.TabIndex = 27
        Button2.Text = "Change"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(798, 481)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TicketTypeButton)
        Controls.Add(ExitButton)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(TicketTypeComboBox)
        Controls.Add(SequenceTextBox)
        Controls.Add(Label6)
        Controls.Add(PictureBox1)
        Controls.Add(TotalTextBox)
        Controls.Add(ChangeTextBox)
        Controls.Add(CashAmountTextBox)
        Controls.Add(QuantityTextBox)
        Controls.Add(TicketPriceTextBox)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LogoutButton)
        Controls.Add(PrintButton)
        Controls.Add(SummaryButton)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.None
        Name = "MainForm"
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SummaryButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents LogoutButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TicketPriceTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents CashAmountTextBox As TextBox
    Friend WithEvents ChangeTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SequenceTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents TicketTypeComboBox As ComboBox
    Friend WithEvents TicketTypeButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
