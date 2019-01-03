Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class OrderProducts
    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader
    Dim con As MySqlConnection = jokenconn()
    Dim sql As String

    Friend OrderPrice As Double = 0

    Public Function jokenconn() As MySqlConnection
            Return New MySqlConnection("server=localhost;user id=root;database=Indomitable_Database")
    End Function

    Private Sub RemoveItemButton_Click(sender As Object, e As EventArgs) Handles RemoveItemButton.Click
        If Not ProductListBox.SelectedIndex = -1 Then
            Try
                Dim ProductSKU As String = Regex.Replace(ProductListBox.SelectedItem, "[^\d]", "")
                Dim Quantity As String = ProductSKU
                ProductSKU = ProductSKU.Substring(0, 4)
                Quantity = Quantity.Remove(0, 4)
                sql = "SELECT ProductPrice FROM Product_Table WHERE ProductSKU= '" & ProductSKU & "'"
                con.Open()
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                rd = cmd.ExecuteReader
                If rd.Read() Then
                    Dim Temp As Double = Double.Parse(rd.GetString(0))
                    Temp = Temp * Quantity
                    OrderPrice -= Temp
                Else
                    MessageBox.Show("No product found with SKU " & ProductSKUTextBox.Text & "", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Database Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
            OrderTotalTextBox.Text = OrderPrice.ToString("c")
            ProductListBox.Items.Remove(ProductListBox.SelectedItem)
        End If
    End Sub

    Private Sub ClearItemsButton_Click(sender As Object, e As EventArgs) Handles ClearItemsButton.Click
        ProductListBox.Items.Clear()
        OrderPrice = 0
        OrderTotalTextBox.Text = OrderPrice.ToString("c")
    End Sub

    Private Sub FinishButton_Click(sender As Object, e As EventArgs) Handles FinishButton.Click
        If ProductListBox.Items.Count > 0 Then
            Me.Hide()
            PaymentForm.Show()
            PaymentForm.TotalLabel.Text = OrderPrice.ToString("c")
        Else
            MessageBox.Show("No items in product list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        ' Adds item to listbox and updates total price
        If Not ProductSKUTextBox.Text.Length = 0 Then
            If IsNumeric(QuantityTextBox.Text) And QuantityTextBox.Text.Length > 0 Then
                ' Listbox stuff
                Dim ProductSKU As Integer = ProductSKUTextBox.Text.ToString()
                ProductListBox.Items.Add("Product SKU: " & ProductSKU & " Quantity: " & QuantityTextBox.Text)

                ' Total price stuff
                Try
                    sql = "SELECT ProductPrice FROM Product_Table WHERE ProductSKU= '" & ProductSKUTextBox.Text & "'"
                    con.Open()
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                    rd = cmd.ExecuteReader
                    If rd.Read() Then
                        Dim Temp As Double = Double.Parse(rd.GetString(0))
                        Temp = Temp * Double.Parse(QuantityTextBox.Text)
                        OrderPrice += Temp
                    Else
                        MessageBox.Show("No product found with SKU " & ProductSKUTextBox.Text & "", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Database Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try

                ' Reset page for next product
                OrderTotalTextBox.Text = OrderPrice.ToString("c")
                QuantityTextBox.Clear()
                ProductSKUTextBox.Clear()
                ProductNameTextBox.Clear()
                ProductSKUTextBox.Focus()
            Else
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please search a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        CreateOrder.Show()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If ProductSKUTextBox.Text.Length > 0 Then
            If IsNumeric(ProductSKUTextBox.Text) Then
                Try
                    Sql = "SELECT * FROM Product_Table WHERE ProductSKU= '" & ProductSKUTextBox.Text & "'"
                    con.Open()
                    Dim cmd As MySqlCommand = New MySqlCommand(Sql, con)
                    rd = cmd.ExecuteReader
                    If rd.Read() Then
                        ProductSKUTextBox.Text = rd.GetString(0)
                        NameLabel.Text = rd.GetString(1)
                        BOHLabel.Text = rd.GetString(2)
                        SizeLabel.Text = rd.GetString(3)
                        ReceivedDateLabel.Text = rd.GetString(4)
                        ReceivedQuantityLabel.Text = rd.GetString(5)
                        CostLabel.Text = rd.GetString(6)
                        LocationLabel.Text = rd.GetString(8)
                        DescriptionTextBox.Text = rd.GetString(9)
                        ColorLabel.Text = rd.GetString(10)
                    Else
                        MessageBox.Show("No product found with SKU " & ProductSKUTextBox.Text & "", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Database Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try
            Else
                MessageBox.Show("Please enter a number for Product SKU", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ProductSKUTextBox.Clear()
                ProductNameTextBox.Clear()
                ProductSKUTextBox.Focus()
            End If
        ElseIf ProductNameTextBox.Text.Length > 0 Then
            If IsNumeric(ProductNameTextBox.Text) = False Then
                Try
                    Sql = "SELECT * FROM Product_Table WHERE ProductName= '" & ProductNameTextBox.Text & "'"
                    con.Open()
                    Dim cmd As MySqlCommand = New MySqlCommand(Sql, con)
                    rd = cmd.ExecuteReader

                    If rd.Read() Then
                        NameLabel.Text = rd.GetString(1)
                        BOHLabel.Text = rd.GetString(2)
                        SizeLabel.Text = rd.GetString(3)
                        ReceivedDateLabel.Text = rd.GetString(4)
                        ReceivedQuantityLabel.Text = rd.GetString(5)
                        CostLabel.Text = rd.GetString(6)
                        LocationLabel.Text = rd.GetString(8)
                        DescriptionTextBox.Text = rd.GetString(9)
                        ColorLabel.Text = rd.GetString(10)
                    Else
                        MessageBox.Show("No product found with name " & ProductNameTextBox.Text & "", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Please enter a Product Name", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try
            Else
                MessageBox.Show("Please enter a Product Name", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ProductSKUTextBox.Clear()
                ProductNameTextBox.Clear()
                ProductSKUTextBox.Focus()
            End If
        Else
            MessageBox.Show("Please enter a Product SKU or Name", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class