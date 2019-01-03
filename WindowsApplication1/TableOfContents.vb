Public Class TableOfContents

    Private Sub TableOfContents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SearchProductButton_Click(sender As Object, e As EventArgs) Handles SearchProductButton.Click
        Me.Hide()
        ProductSearch.Show()
    End Sub

    Private Sub OrderManagerButton_Click(sender As Object, e As EventArgs) Handles OrderManagerButton.Click
        Me.Hide()
        OrderManager.Show()
    End Sub

    Private Sub AccountingButton_Click(sender As Object, e As EventArgs) Handles AccountingButton.Click
        Process.Start("EXCEL.EXE", "C:\Users\Dakota\Documents\CSCC\Capstone\Accounting.xlsx")
    End Sub

    Private Sub SupervisorFunctionsButton_Click(sender As Object, e As EventArgs)
        Me.Hide()
        SupervisorFunctions.Show()
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub CreateOrderButton_Click(sender As Object, e As EventArgs) Handles CreateOrderButton.Click
        Me.Hide()
        CreateOrder.Show()
    End Sub
End Class