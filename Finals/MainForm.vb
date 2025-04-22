Imports System.Diagnostics.Eventing.Reader

Public Class MainForm
    Dim TicketPrice, Quantity, TotalPrice, CashAmount, CashChange As Integer
    Friend GrandTotal, GrandCustomerCount, GrandTicketSold As Integer
    Dim SequenceNumber = 0
    Dim CustomerCount = 0





    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        Me.Hide()
        SummaryForm.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TicketPriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles TicketPriceTextBox.TextChanged


    End Sub
    Private Sub TicketTypeButton_Click(sender As Object, e As EventArgs) Handles TicketTypeButton.Click

        With TicketTypeComboBox
            If .SelectedIndex <> -1 Then

                If TicketTypeComboBox.SelectedItem = "VIP 7000yen" Then
                    TicketPrice = 7000

                ElseIf TicketTypeComboBox.SelectedItem = "1st Standing 4000yen" Then
                    TicketPrice = 4000

                ElseIf TicketTypeComboBox.SelectedItem = "1st with seat 2500yen" Then
                    TicketPrice = 2500

                ElseIf TicketTypeComboBox.SelectedItem = "2nd with seat 1500yen" Then
                    TicketPrice = 1500

                ElseIf TicketTypeComboBox.SelectedItem = "General seat 1000yen" Then
                    TicketPrice = 1000
                End If

                TicketPriceTextBox.Text = TicketPrice

            Else
                MessageBox.Show("First Select The Ticket Type to show the Ticket Price", "No selection made", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If



        End With

    End Sub


    Private Sub TicketTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TicketTypeComboBox.SelectedIndexChanged

    End Sub



    Private Sub QuantityTextBox_TextChanged(sender As Object, e As EventArgs) Handles QuantityTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Quantity = Integer.Parse(QuantityTextBox.Text)
            TotalPrice = Quantity * TicketPrice
            TotalTextBox.Text = TotalPrice

        Catch ex As FormatException
            MessageBox.Show("First add a Quantity", "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With QuantityTextBox
                .Focus()
                .SelectAll()
            End With
        End Try


    End Sub

    Private Sub TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalTextBox.TextChanged

    End Sub

    Private Sub CashAmountTextBox_TextChanged(sender As Object, e As EventArgs) Handles CashAmountTextBox.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try

            CashAmount = Integer.Parse(CashAmountTextBox.Text)
            CashChange = CashAmount - TotalPrice
            ChangeTextBox.Text = CashChange

            If CashChange < 0 Then
                MessageBox.Show("Cash Amount is not Sufficient", "Cash Amount Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                CashAmountTextBox.Clear()
                ChangeTextBox.Clear()

            End If


        Catch ex As FormatException
            MessageBox.Show("First add a Cash Amount", "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With QuantityTextBox
                .Focus()
                .SelectAll()
            End With
        End Try


    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub



    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click

        If ChangeTextBox.Text = "" Or QuantityTextBox.Text = "" Or TicketPriceTextBox.Text = "" Then
            MessageBox.Show("Some Values are Blank Pls Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            SequenceNumber += 1
            CustomerCount += 1
            GrandCustomerCount += 1
            GrandTicketSold += Quantity
            SequenceTextBox.Text = SequenceNumber
            GrandTotal += TotalPrice

            CashAmountTextBox.Clear()
            TotalTextBox.Clear()
            QuantityTextBox.Clear()
            TicketPriceTextBox.Clear()
            ChangeTextBox.Clear()
            TicketTypeComboBox.SelectedIndex = -1

            PrintDocument1.Print()
        End If

    End Sub

    Private Sub SequenceTextBox_TextChanged(sender As Object, e As EventArgs) Handles SequenceTextBox.TextChanged

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim PrintFont As New Font("Arial", 12)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintCustomerNumber, PrintTotalPrice, PrintCashAmount, PrintCashChange As String
        Dim TotalCostWord, CustomerNumberWord, CashAmountWord, CashChangeWord As String

        TotalCostWord = "Total Cost: "
        CustomerNumberWord = "Customer Number: "
        CashAmountWord = "Cash Amount: "
        CashChangeWord = "Cash Change: "

        Using HeadingHeadingFont As New Font("Times New Roman", 20, FontStyle.Bold)
            e.Graphics.DrawString("BOCCHI THE ROCK FIRST LIVE", HeadingHeadingFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        End Using
        VerticalPrintLocationSingle += LineHeightSingle
        VerticalPrintLocationSingle += LineHeightSingle

        Using HeadingFont As New Font("Arial", 14, FontStyle.Bold)
            e.Graphics.DrawString("Receipt", HeadingFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        End Using
        VerticalPrintLocationSingle += LineHeightSingle

        PrintTotalPrice = TotalPrice
        PrintCustomerNumber = CustomerCount
        PrintCashAmount = CashAmount
        PrintCashChange = CashChange

        e.Graphics.DrawString(CustomerNumberWord & PrintCustomerNumber, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle

        e.Graphics.DrawString(TotalCostWord & PrintTotalPrice, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle

        e.Graphics.DrawString(CashAmountWord & PrintCashAmount, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString(CashChangeWord & PrintCashChange, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

    End Sub
End Class
