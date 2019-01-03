' Program TabletScanner
' Programmer: Floyd Shaw
' Description: So the idea here is that the scanner will allow for orders to be picked, confirmed or backordered. Thinking 
' we could add the autonomous invoice order numbers and customer ID #. Will throw in exception handling and check for duplicate orders and discrephancies 
' in quantity pulled if it doesnt match the invoice. Will keep plugging away. Lost some time and work with the save error. Sorry for the delay.



Public Class TabletScanner

    Private Sub OrderListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OrderListBox.SelectedIndexChanged

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        ' Add a new item to Order List

        With ItemComboBox
            ' Test for blank input
            If .Text <> "" Then
                '
                Dim ItemFoundBoolean As Boolean
                Dim ItemIndexInteger As Integer
                Do Until ItemFoundBoolean Or ItemIndexInteger = .Items.Count
                    If .Text = .Items(ItemIndexInteger).ToString() Then
                        ItemFoundBoolean = True
                        Exit Do
                    Else
                        ItemIndexInteger += 1
                    End If
                Loop
                If ItemFoundBoolean Then
                    MessageBox.Show("Duplicate item.", "Add Failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    ' If its not in the order, add it.
                    .Items.Add(.Text)
                    .Text = ""
                End If
            Else
                MessageBox.Show("enter a coffee flavor to add",
                                "Missing Data", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
            End If
            .Focus()
        End With
    End Sub


    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        ' Remove the selected order item from list.

        With ItemComboBox
            If .SelectedIndex <> -1 Then
                .Items.RemoveAt(.SelectedIndex)
            Else
                MessageBox.Show("First select order item to remove",
                                "No selection made", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Print to order list items to invoice

        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationsingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String

        ' Set up and display heading lines.
        PrintLineString = "Print Selected Item"
        e.Graphics.DrawString(PrintLineString, HeadingFont,
                              Brushes.Black, HorizontalPrintLocationsingle, VerticalPrintLocationSingle)
        ' Leave a blank line between the heading and detail line.
        VerticalPrintLocationSingle += LineHeightSingle
        ' Set up the selected line.
        PrintLineString = "Order Items: " & ItemComboBox.Text &
            "    Order:  " & OrderListBox.Text
        ' Send the line to the graphics page object
        e.Graphics.DrawString(PrintLineString, PrintFont,
                              Brushes.Black, HorizontalPrintLocationsingle, VerticalPrintLocationSingle)
    End Sub

    Private Sub ClearListButton_Click(sender As Object, e As EventArgs) Handles ClearListButton.Click
        ' Clear the order list.
        Dim ResponseDialogResult As DialogResult

        If ResponseDialogResult = Windows.Forms.DialogResult.Yes Then
            ItemComboBox.Items.Clear()
        End If

    End Sub

    Private Sub PreviewButton_Click(sender As Object, e As EventArgs) Handles PreviewButton.Click
        ' 

        PrintDialog1.Document = PrintDocument1
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        ' Begin the print process to print items

        PrintDocument1.Print()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ' Clear all fields

        ItemSkuTextBox.Clear()
        CustomerNameTextBox.Clear()
        ItemTextBox.Clear()
        QuantityTextBox.Clear()
    End Sub
End Class