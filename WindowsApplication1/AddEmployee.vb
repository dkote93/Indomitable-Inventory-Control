Imports MySql.Data.MySqlClient

Public Class AddEmployee
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim con As MySqlConnection = jokenconn()

    Public Function jokenconn() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;database=Indomitable_Database")
    End Function

    Private Sub AddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim sql As String
        Dim publictable As New DataTable

        Try

            If EmployeeIDTextBox.Text = "" Or PasswordTextBox.Text = "" Or FirstNameTextBox.Text = "" Or LastNameTextBox.Text = "" Or StreetAddressTextBox.Text = "" Or
                ZipTextBox.Text = "" Or DOBTextBox.Text = "" Or TitleTextBox.Text = "" Or PayRateTextBox.Text = "" Or HomePhoneTextBox.Text = "" Or CellPhoneTextBox.Text = "" Or EmailTextBox.Text = "" Then
                MessageBox.Show("Please complete the required fields...", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ' Textbox validation
                If EmployeeIDTextBox.Text.Length > 50 Or IsNumeric(EmployeeIDTextBox.Text) = False Then
                    MessageBox.Show("EmployeeID Incorrect Data", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf PasswordTextBox.Text.Length > 50 Then
                    MessageBox.Show("Password Incorrect Data", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf FirstNameTextBox.Text.Length > 50 Or IsNumeric(FirstNameTextBox.Text) Then
                    MessageBox.Show("First Name Incorrect Data", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf LastNameTextBox.Text.Length > 50 Or IsNumeric(LastNameTextBox.Text) Then
                    MessageBox.Show("Last Name Incorrect Data", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf StreetAddressTextBox.Text.Length > 50 Then
                    MessageBox.Show("Street Address Incorrect Data", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf ZipTextBox.Text.Length <> 5 Or IsNumeric(ZipTextBox.Text) = False Then
                    MessageBox.Show("Zip Incorrect Data", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf DOBTextBox.Text.Length > 50 Then
                    MessageBox.Show("Date of Birth Incorrect Data", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf TitleTextBox.Text.Length > 50 Then
                    MessageBox.Show("Title Incorrect Data", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf IsNumeric(PayRateTextBox.Text) = False Then
                    MessageBox.Show("Pay Rate Incorrect Data", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf HomePhoneTextBox.Text.Length > 10 Or IsNumeric(HomePhoneTextBox.Text) = False Then
                    MessageBox.Show("Home Phone Incorrect Data", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf CellPhoneTextBox.Text.Length > 10 Or IsNumeric(CellPhoneTextBox.Text) = False Then
                    MessageBox.Show("Cell Phone Incorrect Data", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf EmailTextBox.Text.Length > 50 Then
                    MessageBox.Show("Email Incorrect Data", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Try
                        'sql = "INSERT INTO Employee_Table(EmployeeID, Password, FirstName, LastName, StreetAddress, Zip, DOB, Title, PayRate, HomePhone, CellPhone, Email) VALUES(" & EmployeeIDTextBox.Text & ", '" & PasswordTextBox.Text & "', '" & FirstNameTextBox.Text & "', '" & LastNameTextBox.Text & "', '" & StreetAddressTextBox.Text & "', " & ZipTextBox.Text & ", '" & DOBTextBox.Text & "', '" & TitleTextBox.Text & "', " & PayRateTextBox.Text & ", '" & HomePhoneTextBox.Text & "', '" & CellPhoneTextBox.Text & "', '" & EmailTextBox.Text & "');"
                        ' Data integrety check

                        Using SQLcmd As MySqlCommand = con.CreateCommand
                            con.Open()
                            SQLcmd.CommandText = "INSERT INTO Employee_Table(EmployeeID, Password, FirstName, LastName, StreetAddress, Zip, DOB, Title, PayRate, HomePhone, CellPhone, Email) " & "VALUES (@ID, @Password, @First, @Last, @Address, @Zip, @DOB, @Title, @Pay, @Home, @Cell, @Email)"
                            SQLcmd.Parameters.AddWithValue("@ID", Convert.ToInt32(EmployeeIDTextBox.Text))
                            SQLcmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text)
                            SQLcmd.Parameters.AddWithValue("@First", FirstNameTextBox.Text)
                            SQLcmd.Parameters.AddWithValue("@Last", LastNameTextBox.Text)
                            SQLcmd.Parameters.AddWithValue("@Address", StreetAddressTextBox.Text)
                            SQLcmd.Parameters.AddWithValue("@Zip", Convert.ToInt32(ZipTextBox.Text))
                            SQLcmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(DOBTextBox.Text))
                            SQLcmd.Parameters.AddWithValue("@Title", TitleTextBox.Text)
                            SQLcmd.Parameters.AddWithValue("@Pay", Convert.ToDecimal(PayRateTextBox.Text))
                            SQLcmd.Parameters.AddWithValue("@Home", HomePhoneTextBox.Text)
                            SQLcmd.Parameters.AddWithValue("@Cell", CellPhoneTextBox.Text)
                            SQLcmd.Parameters.AddWithValue("@Email", EmailTextBox.Text)
                            SQLcmd.ExecuteNonQuery()
                            con.Clone()
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Data Format Error: " & ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    MessageBox.Show("Employee Successfully Added", "Employee Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to Database.. System Error Message:  " & ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        EmployeeIDTextBox.Clear()
        PasswordTextBox.Clear()
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        StreetAddressTextBox.Clear()
        ZipTextBox.Clear()
        DOBTextBox.Clear()
        TitleTextBox.Clear()
        PayRateTextBox.Clear()
        HomePhoneTextBox.Clear()
        CellPhoneTextBox.Clear()
        EmailTextBox.Clear()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        SupervisorFunctions.Show()
    End Sub
End Class