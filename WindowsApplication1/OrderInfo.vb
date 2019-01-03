Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class OrderInfo
    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader
    Dim con As MySqlConnection = jokenconn()
    Dim sql As String

    Public OrderID As Integer

    Public Function jokenconn() As MySqlConnection
            Return New MySqlConnection("server=localhost;user id=root;database=Indomitable_Database")
    End Function

    Private Sub OrderInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Set up sql command string
            sql = "SELECT * FROM Order_Table WHERE OrderID= '" & OrderID & "'"
            ' Open connection to database
            con.Open()
            ' Creates MySqlCommand using sql string
            Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
            ' Executes cmd and reads output
            rd = cmd.ExecuteReader
            ' Checks to see if there is output
            If rd.Read() Then
                ' Fills product info TextBoxes
                OrderIDLabel.Text = rd.GetString(0)
                DateLabel.Text = rd.GetString(1)
                Select Case Integer.Parse(rd.GetString(4))
                    Case 0
                        StatusLabel.Text = "Pending"
                    Case 1
                        StatusLabel.Text = "Open"
                    Case 2
                        StatusLabel.Text = "Closed"
                End Select
                AddressLabel.Text = rd.GetString(5) + " " + rd.GetString(6) + ", " + rd.GetString(7) + " " + rd.GetString(8)
            End If
            con.Close()

            sql = "SELECT CustomerID FROM Customer_Order_Link_Table WHERE OrderID= '" & OrderID & "'"
            con.Open()
            Dim cmd2 As MySqlCommand = New MySqlCommand(sql, con)
            rd = cmd2.ExecuteReader
            Dim CustomerID As Integer = 0
            If rd.Read() Then
                CustomerID = Integer.Parse(rd.GetString(0))
                'MessageBox.Show(CustomerID, "Stuff", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()

            sql = "SELECT CONCAT_WS(' ', FirstName, LastName) FROM Customer_Table WHERE CustomerID= '" & CustomerID & "'"
            con.Open()
            Dim cmd3 As MySqlCommand = New MySqlCommand(sql, con)
            rd = cmd3.ExecuteReader
            If rd.Read() Then
                CustomerLabel.Text = rd.GetString(0)
            End If
        Catch ex As Exception
            ' If there is and error connection to the database
            MessageBox.Show("Error 1: " & ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Closes connection to databse
            con.Close()
        End Try

        Try
            con.Open()
            sql = "SELECT ProductSKU FROM Order_Product_Link_Table WHERE OrderID= '" & OrderID & "'"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
            rd = cmd.ExecuteReader
            Dim ProductSKUArray As New ArrayList
            While rd.Read()
                ProductSKUArray.Add(Integer.Parse(rd.GetString(0)))
            End While
            con.Close()

            Dim OrderQuantityArray As New ArrayList
            Dim counter As Integer = 0
            For i As Integer = 0 To ProductSKUArray.Count - 1
                con.Open()
                sql = "SELECT Quantity FROM Order_Product_Link_Table WHERE ProductSKU= '" & ProductSKUArray(counter) & "' AND OrderID ='" & OrderID & "'"
                Dim cmd2 As MySqlCommand = New MySqlCommand(sql, con)
                rd = cmd2.ExecuteReader
                If rd.Read() Then
                    OrderQuantityArray.Add(Integer.Parse(rd.GetString(0)))
                End If
                con.Close()
                ProductListBox.Items.Add("Product SKU: " & ProductSKUArray(counter) & " Quantity: " & OrderQuantityArray(counter))
                counter += 1
            Next

        Catch ex As Exception
            MessageBox.Show("Error 2: " & ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub ProductButton_Click(sender As Object, e As EventArgs) Handles ProductButton.Click
        If Not ProductListBox.SelectedIndex = -1 Then
            Dim ProductString As String = ProductListBox.SelectedItems(0)
            Dim ProductSKU As Integer = Integer.Parse(Regex.Replace(ProductString, "[^\d]", ""))
            ProductSKU = ProductSKU.ToString().Substring(0, 4)
            Try
                sql = "SELECT * FROM Product_Table WHERE ProductSKU= '" & ProductSKU & "'"
                con.Open()
                Dim cmd2 As MySqlCommand = New MySqlCommand(sql, con)
                rd = cmd2.ExecuteReader
                Dim productName As String = ""
                Dim productBOH As Integer = 0
                Dim productSize As String = ""
                Dim productDate As String = ""
                Dim productQuantity As Integer = 0
                Dim productLocation As String = ""
                Dim productDescription As String = 0
                If rd.Read() Then
                    productName = rd.GetString(1)
                    productBOH = Integer.Parse(rd.GetString(2))
                    productSize = rd.GetString(3)
                    productDate = rd.GetString(4)
                    productQuantity = Integer.Parse(rd.GetString(5))
                    productLocation = rd.GetString(8)
                    productDescription = rd.GetString(9)
                End If
                MessageBox.Show("Product SKU:  " & ProductSKU & "" & vbCrLf &
                                "Product Name:  " & productName & "" & vbCrLf &
                                "BOH:  " & productBOH & "" & vbCrLf &
                                "Size:  " & productSize & "" & vbCrLf &
                                "Last Received Date:  " & productDate & "" & vbCrLf &
                                "Last Received Quantity:  " & productBOH & "" & vbCrLf &
                                "Location:  " & productLocation & "" & vbCrLf &
                                "Description:  " & productDescription & "",
                                "Product Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                ' If there is and error connection to the database
                MessageBox.Show("Error 3: " & ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Closes connection to databse
                con.Close()
            End Try
        End If
    End Sub
End Class