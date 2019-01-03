Imports MySql.Data.MySqlClient

Public Class LoginForm
    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader
    Dim con As MySqlConnection = jokenconn()
    Dim sql As String

    Public Function jokenconn() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;database=Indomitable_Database")
    End Function

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmployeeIDTextBox.Focus()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Try
            Dim sql As String = "SELECT * FROM Employee_Table WHERE EmployeeID= '" & EmployeeIDTextBox.Text & "' and Password= '" & PasswordTextBox.Text & "'"
            con.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
            rd = cmd.ExecuteReader
            If rd.Read() Then
                EmployeeIDTextBox.Clear()
                PasswordTextBox.Clear()
                EmployeeIDTextBox.Focus()
                Me.Hide()
                TableOfContents.Show()
            Else
                MessageBox.Show("Incorrect ID or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        EmployeeIDTextBox.Text = ""
        PasswordTextBox.Text = ""
        EmployeeIDTextBox.Focus()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    'Employee ID-------------------------------------------------------------------------------------------------

    Private Function ValidateEmployeeIDTextBox(ByVal ID As String, ByRef errorMessage As String) As Boolean
        If EmployeeIDTextBox.Text.Length = 0 Then
            errorMessage = "Employee ID is required."
            Return False
        Else
            If IsNumeric(ID) And ID.Length = 4 Then
                errorMessage = ""
                Return True
            Else
                errorMessage = "Please enter a valid employee ID."
                Return False
            End If
        End If
    End Function

    Private Sub EmployeeIDTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles EmployeeIDTextBox.Validating
        Dim errorMsg As String
        If Not ValidateEmployeeIDTextBox(EmployeeIDTextBox.Text, errorMsg) Then
            e.Cancel = True
            EmployeeIDTextBox.Select(0, EmployeeIDTextBox.Text.Length)
            Me.ErrorProvider1.SetError(EmployeeIDTextBox, errorMsg)
        End If
    End Sub

    Private Sub EmployeeIDTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles EmployeeIDTextBox.Validated
        ErrorProvider1.SetError(EmployeeIDTextBox, "")
    End Sub

    'Password-------------------------------------------------------------------------------------------------

    Private Function ValidatePasswordTextBox(ByVal Password As String, ByRef errorMessage As String) As Boolean
        If PasswordTextBox.Text.Length = 0 Then
            errorMessage = "Password is required."
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub PasswordTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PasswordTextBox.Validating
        Dim errorMsg As String
        If Not ValidatePasswordTextBox(PasswordTextBox.Text, errorMsg) Then
            e.Cancel = True
            PasswordTextBox.Select(0, PasswordTextBox.Text.Length)
            Me.ErrorProvider1.SetError(PasswordTextBox, errorMsg)
        End If
    End Sub

    Private Sub PasswordTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles PasswordTextBox.Validated
        ErrorProvider1.SetError(PasswordTextBox, "")
    End Sub
End Class