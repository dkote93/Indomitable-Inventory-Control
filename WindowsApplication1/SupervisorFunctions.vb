Public Class SupervisorFunctions

    Private Sub AddEmployeeButton_Click(sender As Object, e As EventArgs) Handles AddEmployeeButton.Click
        Me.Hide()
        AddEmployee.Show()
    End Sub

    Private Sub ManageEmployeeButton_Click(sender As Object, e As EventArgs) Handles ManageEmployeeButton.Click

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        TableOfContents.Show()
    End Sub
End Class