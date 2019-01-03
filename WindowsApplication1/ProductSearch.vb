Imports MySql.Data.MySqlClient

Public Class ProductSearch
    ' Set up MySQL Variables
    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader
    Dim con As MySqlConnection = jokenconn()
    Dim sql As String

    ' This function runs when con is used and has the connection string in it
    Public Function jokenconn() As MySqlConnection
            Return New MySqlConnection("server=localhost;user id=root;database=Indomitable_Database")
    End Function

    ' Back Button
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        TableOfContents.Show()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        ' Checking to see if there is text in the ProductSKUTextBox
        If ProductSKUTextBox.Text.Length > 0 Then
            ' If there is text it checks to see if it numeric
            If IsNumeric(ProductSKUTextBox.Text) Then
                Try
                    ' Set up sql command string
                    sql = "SELECT * FROM Product_Table WHERE ProductSKU= '" & ProductSKUTextBox.Text & "'"
                    ' Open connection to database
                    con.Open()
                    ' Creates MySqlCommand using sql string
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                    ' Executes cmd and reads output
                    rd = cmd.ExecuteReader

                    ' Checks to see if there is output
                    If rd.Read() Then
                        ' Fills product info TextBoxes
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
                        ' If there was no output
                        MessageBox.Show("No product found with SKU " & ProductSKUTextBox.Text & "", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    ProductNameTextBox.Clear()
                    ProductSKUTextBox.Focus()
                Catch ex As Exception
                    ' If there is and error connection to the database
                    MessageBox.Show("Database Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' Closes connection to databse
                    con.Close()
                End Try
            Else
                ' If text was entered but not numeric
                MessageBox.Show("Please enter a number for Product SKU", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ProductSKUTextBox.Clear()
                ProductNameTextBox.Clear()
                ProductSKUTextBox.Focus()
            End If
        ElseIf ProductNameTextBox.Text.Length > 0 Then
            If IsNumeric(ProductNameTextBox.Text) = False Then
                Try
                    sql = "SELECT * FROM Product_Table WHERE ProductName= '" & ProductNameTextBox.Text & "'"
                    con.Open()
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
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
                        MessageBox.Show("No product found with name " & ProductNameTextBox.Text & "", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    ProductSKUTextBox.Clear()
                    ProductSKUTextBox.Focus()
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

    Private Sub ProductSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductSKUTextBox.Focus()
    End Sub
End Class