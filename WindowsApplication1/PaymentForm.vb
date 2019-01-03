Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class PaymentForm

    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader
    Dim con As MySqlConnection = jokenconn()
    Dim sql As String

    Dim OrderID As Integer
    Dim CustomerID As Integer
    Dim Address As String
    Dim City As String
    Dim State As String
    Dim Zip As Integer

    Dim CardType As String
    Dim CardNum As String
    Dim ExperationDate As Integer
    Dim SecurityCode As Integer
    Dim BillingZip As Integer
    Dim CodeLength As Integer = 3
    Dim CardLength As Integer = 12
    Dim SelectedCard As Boolean = False

    Public Function jokenconn() As MySqlConnection
            Return New MySqlConnection("server=localhost;user id=root;database=Indomitable_Database")
    End Function

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CreateOrder.CustomerType = 1 Then
            CustomerID = CustomerLookup.CustomerID
            CustomerLookup.Close()
        ElseIf CreateOrder.CustomerType = 2 Then
            CustomerID = CreateCustomerForm.CustomerID
            CreateCustomerForm.Close()
        End If
    End Sub

    Private Sub EditOrderButton_Click(sender As Object, e As EventArgs) Handles EditOrderButton.Click
        Me.Hide()
        OrderProducts.Show()
    End Sub

    Private Sub PlaceOrderButton_Click(sender As Object, e As EventArgs) Handles PlaceOrderButton.Click
        'Get Customer Info
        If SelectedCard Then
            Try
                sql = "SELECT * FROM Customer_Table WHERE CustomerID= '" & CustomerID & "'"
                con.Open()
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                rd = cmd.ExecuteReader

                If rd.Read() Then
                    Address = rd.GetString(5)
                    City = rd.GetString(6)
                    State = rd.GetString(7)
                    Zip = Integer.Parse(rd.GetString(8))
                Else
                    MessageBox.Show("No cusomter found with customer ID: " & CustomerID & "", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try

            'Create new order
            Try
                Using SQLcmd As MySqlCommand = con.CreateCommand
                    con.Open()
                    SQLcmd.CommandText = "INSERT INTO Order_Table(OrderDate, OrderCost, OrderPrice, OrderStatus, StreetAddress, City, State, Zip) " & "VALUES (@Date, @Cost, @Price, @Status, @Address, @City, @State, @Zip)"
                    SQLcmd.Parameters.AddWithValue("@Date", Date.Now)
                    SQLcmd.Parameters.AddWithValue("@Cost", 99.99)
                    SQLcmd.Parameters.AddWithValue("@Price", OrderProducts.OrderPrice)
                    SQLcmd.Parameters.AddWithValue("@Status", 0)
                    SQLcmd.Parameters.AddWithValue("@Address", Address)
                    SQLcmd.Parameters.AddWithValue("@City", City)
                    SQLcmd.Parameters.AddWithValue("@State", State)
                    SQLcmd.Parameters.AddWithValue("@Zip", Zip)
                    SQLcmd.ExecuteNonQuery()
                    con.Clone()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try

            'Get OrderID from last order created
            Try
                sql = "SELECT LAST_INSERT_ID()"
                con.Open()
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                rd = cmd.ExecuteReader
                If rd.Read() Then
                    OrderID = rd.GetString(0)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try

            'Create customer order link
            Try
                Using SQLcmd As MySqlCommand = con.CreateCommand
                    con.Open()
                    SQLcmd.CommandText = "INSERT INTO Customer_Order_Link_Table(CustomerID, OrderID) " & "VALUES (@Customer, @Order)"
                    SQLcmd.Parameters.AddWithValue("@Customer", CustomerID)
                    SQLcmd.Parameters.AddWithValue("@Order", OrderID)
                    SQLcmd.ExecuteNonQuery()
                    con.Clone()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try

            'Add products into order
            For Each item In OrderProducts.ProductListBox.Items
                Dim ProductSKU As String = Regex.Replace(item, "[^\d]", "")
                Dim Quantity As String = ProductSKU
                ProductSKU = ProductSKU.Substring(0, 4)
                Quantity = Quantity.Remove(0, 4)
                Try
                    Using SQLcmd As MySqlCommand = con.CreateCommand
                        con.Open()
                        SQLcmd.CommandText = "INSERT INTO Order_Product_Link_Table(OrderID, ProductSKU, Quantity) " & "VALUES (@Order, @Product, @Quantity)"
                        SQLcmd.Parameters.AddWithValue("@Order", OrderID)
                        SQLcmd.Parameters.AddWithValue("@Product", Integer.Parse(ProductSKU))
                        SQLcmd.Parameters.AddWithValue("@Quantity", Integer.Parse(Quantity))
                        SQLcmd.ExecuteNonQuery()
                        con.Clone()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try
            Next

            'Add payment info
            Try
                ExperationDate = MonthComboBox.SelectedItem.ToString + YearComboBox.SelectedItem.ToString
                Using SQLcmd As MySqlCommand = con.CreateCommand
                    con.Open()
                    SQLcmd.CommandText = "INSERT INTO Payment_Table(CustomerID, OrderID, CardType, CardNumber, ExperationDate, SecurityCode, Zip) " & "VALUES (@Customer, @Order, @Type, @Number, @Date, @Code, @Zip)"
                    SQLcmd.Parameters.AddWithValue("@Customer", CustomerID)
                    SQLcmd.Parameters.AddWithValue("@Order", OrderID)
                    SQLcmd.Parameters.AddWithValue("@Type", CardType)
                    SQLcmd.Parameters.AddWithValue("@Number", CardNum)
                    SQLcmd.Parameters.AddWithValue("@Date", Integer.Parse(ExperationDate))
                    SQLcmd.Parameters.AddWithValue("@Code", SecurityCode)
                    SQLcmd.Parameters.AddWithValue("@Zip", BillingZip)
                    SQLcmd.ExecuteNonQuery()
                    con.Clone()
                End Using
                MessageBox.Show("Order Created" & vbCrLf &
                    "OrderID:  " & OrderID & "" & vbCrLf &
                    "Customer Name:  " & NameTextBox.Text & "" & vbCrLf &
                    "Date:  " & Date.Now & "" & vbCrLf &
                    "Order Cost: " & OrderProducts.OrderPrice.ToString("c") & "",
                    "Product Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TableOfContents.Show()
                If CreateOrder.CustomerType = 1 Then
                    CustomerLookup.Close()
                ElseIf CreateOrder.CustomerType = 2 Then
                    CreateCustomerForm.Close()
                End If
                CreateOrder.Close()
                OrderProducts.Close()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        Else
            MessageBox.Show("Card Type Error", "Please select a card type.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub VisaRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles VisaRadioButton.CheckedChanged
        CardType = "Visa"
        CodeLength = 3
        CardLength = 16
        SelectedCard = True
    End Sub

    Private Sub MasterCardRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MasterCardRadioButton.CheckedChanged
        CardType = "MasterCard"
        CodeLength = 3
        CardLength = 16
        SelectedCard = True
    End Sub

    Private Sub AmericanExpressRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AmericanExpressRadioButton.CheckedChanged
        CardType = "AmericanExpress"
        CodeLength = 4
        CardLength = 15
        SelectedCard = True
    End Sub

    'Name-------------------------------------------------------------------------------------------------

    Private Function ValidateNameTextBox(ByVal Name As String, ByRef errorMessage As String) As Boolean
        If NameTextBox.Text.Length = 0 Then
            errorMessage = "Name is required."
            Return False
        Else
            If Not IsNumeric(NameTextBox.Text) Then
                Return True
            Else
                errorMessage = "Please Enter a Valid Name"
                Return False
            End If
        End If
    End Function

    Private Sub NameTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NameTextBox.Validating
        Dim errorMsg As String
        If Not ValidateNameTextBox(NameTextBox.Text, errorMsg) Then
            e.Cancel = True
            NameTextBox.Select(0, NameTextBox.Text.Length)
            Me.ErrorProvider1.SetError(NameTextBox, errorMsg)
        End If
    End Sub

    Private Sub NameTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles NameTextBox.Validated
        ErrorProvider1.SetError(NameTextBox, "")
    End Sub

    'Card Number-------------------------------------------------------------------------------------------------

    Private Function ValidateCardNumberTextBox(ByVal Num As String, ByRef errorMessage As String) As Boolean
        If CardNumberTextBox.Text.Length = 0 Then
            errorMessage = "Card Number is required."
            Return False
        Else
            If IsNumeric(CardNumberTextBox.Text) And CardNumberTextBox.Text.Length >= CardLength Then
                CardNum = Num
                Return True
            Else
                errorMessage = "Please Enter a Valid Card Number"
                Return False
            End If
        End If
    End Function

    Private Sub CardNumberTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CardNumberTextBox.Validating
        Dim errorMsg As String
        If Not ValidateCardNumberTextBox(CardNumberTextBox.Text, errorMsg) Then
            e.Cancel = True
            CardNumberTextBox.Select(0, CardNumberTextBox.Text.Length)
            Me.ErrorProvider1.SetError(CardNumberTextBox, errorMsg)
        End If
    End Sub

    Private Sub CardNumberTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CardNumberTextBox.Validated
        ErrorProvider1.SetError(CardNumberTextBox, "")
    End Sub

    'Security Code-------------------------------------------------------------------------------------------------

    Private Function ValidateSecurityCodeTextBox(ByVal Security As String, ByRef errorMessage As String) As Boolean
        If SecurityCodeTextBox.Text.Length = 0 Then
            errorMessage = "Security Code is required."
            Return False
        Else
            If IsNumeric(SecurityCodeTextBox.Text) And SecurityCodeTextBox.Text.Length = CodeLength Then
                SecurityCode = Security
                Return True
            Else
                errorMessage = "Please Enter a Valid Security Code"
                Return False
            End If
        End If
    End Function

    Private Sub SecurityCodeTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SecurityCodeTextBox.Validating
        Dim errorMsg As String
        If Not ValidateSecurityCodeTextBox(SecurityCodeTextBox.Text, errorMsg) Then
            e.Cancel = True
            SecurityCodeTextBox.Select(0, SecurityCodeTextBox.Text.Length)
            Me.ErrorProvider1.SetError(SecurityCodeTextBox, errorMsg)
        End If
    End Sub

    Private Sub SecurityCodeTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles SecurityCodeTextBox.Validated
        ErrorProvider1.SetError(SecurityCodeTextBox, "")
    End Sub
End Class