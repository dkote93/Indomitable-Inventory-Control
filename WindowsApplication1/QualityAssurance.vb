'Program: Quality Assurance
'Programmer: Floyd Shaw
'Description
' Dakota, I am working on an invoice form that would be paired with this one.Figured the top icons can link to database, for example = Addresses will
' pull up stored customers and auto fill address fields. Tracking, Create new order and so on.
' I am thinking that the Order invoice items will be sent to the open orders qeue
' & the TabletScanner can pick available orders, confirm them out or backorder if not in stock. A link between the invoice # and Customer Id #
' will allow the program to compare item sku's, customer shipping information etc... The tablet is just a temporary link for you to see the form for now.  Will continue you on it and flesh everything out before Tuesday.




Public Class QualityAssurance

    Private Sub CustomerIdTextBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerIdTextBox.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Clear previous amounts from the form

        CustomerNameTextBox.Clear()
        AttentionNameTextBox.Clear()
        AddressOneTextBox.Clear()
        AddressTwoTextBox.Clear()
        TownTextBox.Clear()
        TelephoneTextBox.Clear()
        PostalCodeTextBox.Clear()
        ShippingAccountNumberTextBox.Clear()
        WidthTextBox.Clear()
        InchTextBox.Clear()
        ValueTextBox.Clear()
        RefOneTextBox.Clear()
        RefTwoTextBox.Clear()
        PackageTextBox.Clear()
        With CustomerIdTextBox
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Exit the project.
        Me.Hide()
        TableOfContents.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ScannerLinkButton.Click
        ' Open TabletScanner form
        TabletScanner.ShowDialog()
    End Sub
End Class
