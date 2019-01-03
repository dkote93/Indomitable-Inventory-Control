Imports MySql.Data.MySqlClient

Public Class CreateCustomerForm
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim rd As MySqlDataReader
    Dim con As MySqlConnection = jokenconn()

    Friend CustomerID As Integer
    Friend PasswordInput As String
    Friend FirstInput As String
    Friend LastInput As String
    Friend DOBInput As String
    Friend AddressInput As String
    Friend CityInput As String
    Friend StateInput As String
    Friend ZipInput As Integer
    Friend PhoneInput As Integer
    Friend EmailInput As String

    Public Function jokenconn() As MySqlConnection
            Return New MySqlConnection("server=localhost;user id=root;database=Indomitable_Database")
    End Function

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        If Not FirstInput.Length = 0 And Not DOBInput.Length = 0 And Not AddressInput.Length = 0 And Not CityInput.Length = 0 And Not StateInput.Length = 0 And Not ZipInput = 0 And Not PhoneInput = 0 And Not EmailInput.Length = 0 Then
            Try
                Using SQLcmd As MySqlCommand = con.CreateCommand
                    con.Open()
                    SQLcmd.CommandText = "INSERT INTO Customer_Table(Password, FirstName, LastName, DOB, StreetAddress, City, State, Zip, PhoneNumber, Email) " & "VALUES (@Password, @First, @Last, @DOB, @Address, @City, @State, @Zip, @Phone, @Email)"
                    SQLcmd.Parameters.AddWithValue("@Password", "password")
                    SQLcmd.Parameters.AddWithValue("@First", FirstInput)
                    SQLcmd.Parameters.AddWithValue("@Last", LastInput)
                    SQLcmd.Parameters.AddWithValue("@DOB", DOBInput)
                    SQLcmd.Parameters.AddWithValue("@Address", AddressInput)
                    SQLcmd.Parameters.AddWithValue("@City", CityInput)
                    SQLcmd.Parameters.AddWithValue("@State", StateInput)
                    SQLcmd.Parameters.AddWithValue("@Zip", ZipInput)
                    SQLcmd.Parameters.AddWithValue("@Phone", PhoneInput)
                    SQLcmd.Parameters.AddWithValue("@Email", EmailInput)
                    SQLcmd.ExecuteNonQuery()
                    con.Clone()
                End Using
            Catch ex As Exception
                MessageBox.Show("Data Format Error: " & ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                Dim sql As String = "SELECT LAST_INSERT_ID()"
                con.Open()
                Dim cmd As MySqlCommand = New MySqlCommand(Sql, con)
                rd = cmd.ExecuteReader
                If rd.Read() Then
                    CustomerID = rd.GetString(0)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try

            MessageBox.Show("Customer Successfully Added", "Customer Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            OrderProducts.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please complete all feilds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        EmailAddressTextBox.Clear()
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        StreetTextBox.Clear()
        CityTextBox.Clear()
        ZipTextBox.Clear()
        PhoneTextBox.Clear()
        StateComboBox.SelectedIndex = -1
        DateTimePicker1.Value = Date.Now
        EmailAddressTextBox.Focus()
    End Sub

    Private Sub StateComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StateComboBox.SelectedIndexChanged
        StateInput = StateComboBox.SelectedItem
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DOBInput = DateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        ' Disables Validation so form can close
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.Close()
        TableOfContents.Show()
    End Sub

    'Email-------------------------------------------------------------------------------------------------

    Private Function ValidateEmailTextBox(ByVal EmailAddress As String, ByRef errorMessage As String) As Boolean
        If EmailAddressTextBox.Text.Length = 0 Then
            errorMessage = "Email address is required."
            Return False
        Else
            If EmailAddress.IndexOf("@") > -1 Then
                If (EmailAddress.IndexOf(".")) > EmailAddress.IndexOf("@") Then
                    errorMessage = ""
                    EmailInput = EmailAddress
                    Return True
                End If
                errorMessage = "Please Enter a Valid Email Address. Ex - someone@example.com"
                Return False
            Else
                errorMessage = "Please Enter a Valid Email Address. Ex - someone@example.com"
                Return False
            End If
        End If
    End Function

    Private Sub EmailTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles EmailAddressTextBox.Validating
        Dim errorMsg As String
        If Not ValidateEmailTextBox(EmailAddressTextBox.Text, errorMsg) Then
            e.Cancel = True
            EmailAddressTextBox.Select(0, EmailAddressTextBox.Text.Length)
            Me.ErrorProvider1.SetError(EmailAddressTextBox, errorMsg)
        End If
    End Sub

    Private Sub EmailTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles EmailAddressTextBox.Validated
        ErrorProvider1.SetError(EmailAddressTextBox, "")
    End Sub

    'FirstName-------------------------------------------------------------------------------------------------

    Private Function ValidateFirstNameTextBox(ByVal First As String, ByRef errorMessage As String) As Boolean
        If FirstNameTextBox.Text.Length = 0 Then
            errorMessage = "First name is required."
            Return False
        Else
            If Not IsNumeric(First) Then
                errorMessage = ""
                FirstInput = First
                Return True
            Else
                errorMessage = "Please enter a valid first name. Ex - John"
                Return False
            End If
        End If
    End Function

    Private Sub FirstNameTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles FirstNameTextBox.Validating
        Dim errorMsg As String
        If Not ValidateFirstNameTextBox(FirstNameTextBox.Text, errorMsg) Then
            e.Cancel = True
            FirstNameTextBox.Select(0, FirstNameTextBox.Text.Length)
            Me.ErrorProvider1.SetError(FirstNameTextBox, errorMsg)
        End If
    End Sub

    Private Sub FirstNameTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FirstNameTextBox.Validated
        ErrorProvider1.SetError(FirstNameTextBox, "")
    End Sub

    'LastName-------------------------------------------------------------------------------------------------

    Private Function ValidateLastNameTextBox(ByVal Last As String, ByRef errorMessage As String) As Boolean
        If LastNameTextBox.Text.Length = 0 Then
            errorMessage = "Last name is required."
            Return False
        Else
            If Not IsNumeric(Last) Then
                errorMessage = ""
                LastInput = Last
                Return True
            Else
                errorMessage = "Please enter a valid last name. Ex - Smith"
                Return False
            End If
        End If
    End Function

    Private Sub LastNameTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LastNameTextBox.Validating
        Dim errorMsg As String
        If Not ValidateLastNameTextBox(LastNameTextBox.Text, errorMsg) Then
            e.Cancel = True
            LastNameTextBox.Select(0, LastNameTextBox.Text.Length)
            Me.ErrorProvider1.SetError(LastNameTextBox, errorMsg)
        End If
    End Sub

    Private Sub LastNameTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles LastNameTextBox.Validated
        ErrorProvider1.SetError(LastNameTextBox, "")
    End Sub

    'StreetAddress-------------------------------------------------------------------------------------------------

    Private Function ValidateStreetTextBox(ByVal Address As String, ByRef errorMessage As String) As Boolean
        If StreetTextBox.Text.Length = 0 Then
            errorMessage = "Street address is required."
            Return False
        Else
            errorMessage = ""
            AddressInput = Address
            Return True
        End If
    End Function

    Private Sub StreetTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles StreetTextBox.Validating
        Dim errorMsg As String
        If Not ValidateStreetTextBox(StreetTextBox.Text, errorMsg) Then
            e.Cancel = True
            StreetTextBox.Select(0, StreetTextBox.Text.Length)
            Me.ErrorProvider1.SetError(StreetTextBox, errorMsg)
        End If
    End Sub

    Private Sub StreetTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles StreetTextBox.Validated
        ErrorProvider1.SetError(StreetTextBox, "")
    End Sub

    'City-------------------------------------------------------------------------------------------------

    Private Function ValidateCityTextBox(ByVal CityVal As String, ByRef errorMessage As String) As Boolean
        If CityTextBox.Text.Length = 0 Then
            errorMessage = "City is required."
            Return False
        Else
            If Not IsNumeric(CityVal) Then
                errorMessage = ""
                CityInput = CityVal
                Return True
            Else
                errorMessage = "Please enter a valid city. Ex - New York"
                Return False
            End If
        End If
    End Function

    Private Sub CityTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CityTextBox.Validating
        Dim errorMsg As String
        If Not ValidateCityTextBox(CityTextBox.Text, errorMsg) Then
            e.Cancel = True
            CityTextBox.Select(0, CityTextBox.Text.Length)
            Me.ErrorProvider1.SetError(CityTextBox, errorMsg)
        End If
    End Sub

    Private Sub CityTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CityTextBox.Validated
        ErrorProvider1.SetError(CityTextBox, "")
    End Sub

    'Zip-------------------------------------------------------------------------------------------------

    Private Function ValidateZipTextBox(ByVal Zip As String, ByRef errorMessage As String) As Boolean
        If ZipTextBox.Text.Length = 0 Then
            errorMessage = "Zip code is required."
            Return False
        ElseIf ZipTextBox.Text.Length = 5 Then
            If IsNumeric(Zip) Then
                errorMessage = ""
                ZipInput = Zip
                Return True
            Else
                errorMessage = "Please enter a valid zip code. Ex - 43065"
                Return False
            End If
        Else
            errorMessage = "Please enter a valid zip code. Ex - 43065"
            Return False
        End If
    End Function

    Private Sub ZipTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ZipTextBox.Validating
        Dim errorMsg As String
        If Not ValidateZipTextBox(ZipTextBox.Text, errorMsg) Then
            e.Cancel = True
            ZipTextBox.Select(0, ZipTextBox.Text.Length)
            Me.ErrorProvider1.SetError(ZipTextBox, errorMsg)
        End If
    End Sub

    Private Sub ZipTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ZipTextBox.Validated
        ErrorProvider1.SetError(ZipTextBox, "")
    End Sub

    'Phone-------------------------------------------------------------------------------------------------

    Private Function ValidatePhoneTextBox(ByVal PhoneNum As String, ByRef errorMessage As String) As Boolean
        If PhoneTextBox.Text.Length = 0 Then
            errorMessage = "Phone number is required."
            Return False
        ElseIf PhoneTextBox.Text.Length = 10 Then
            If IsNumeric(PhoneNum) Then
                errorMessage = ""
                PhoneInput = PhoneNum
                Return True
            Else
                errorMessage = "Please enter a valid phone number. Ex - 1112223333"
                Return False
            End If
        Else
            errorMessage = "Please enter a valid phone number. Ex - 1112223333"
            Return False
        End If
    End Function

    Private Sub PhoneTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim errorMsg As String
        If Not ValidatePhoneTextBox(PhoneTextBox.Text, errorMsg) Then
            e.Cancel = True
            PhoneTextBox.Select(0, PhoneTextBox.Text.Length)
            Me.ErrorProvider1.SetError(PhoneTextBox, errorMsg)
        End If
    End Sub

    Private Sub PhoneTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        ErrorProvider1.SetError(PhoneTextBox, "")
    End Sub
End Class