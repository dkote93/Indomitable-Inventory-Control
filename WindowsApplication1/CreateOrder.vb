
Public Class CreateOrder

    Friend CustomerType As Integer = 0

    Private Sub LookupButton_Click(sender As Object, e As EventArgs) Handles LookupButton.Click
        CustomerType = 1
        Me.Hide()
        CustomerLookup.Show()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        TableOfContents.Show()
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        CustomerType = 2
        Me.Hide()
        CreateCustomerForm.Show()
    End Sub
End Class