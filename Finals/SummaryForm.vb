Public Class SummaryForm

    Private Sub SummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TotalSalesTextBox.Text = MainForm.GrandTotal.ToString("C")
        NumberCustomersTextBox.Text = MainForm.GrandCustomerCount.ToString()
        TicketSoldTextBox.Text = MainForm.GrandTicketSold
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        TotalSalesTextBox.Clear()
        NumberCustomersTextBox.Clear()
        TicketSoldTextBox.Clear()

        Me.Close()
        MainForm.Show()

    End Sub

    Private Sub TicketSoldTextBox_TextChanged(sender As Object, e As EventArgs) Handles TicketSoldTextBox.TextChanged

    End Sub
End Class