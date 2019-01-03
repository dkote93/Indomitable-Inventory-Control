Imports MySql.Data.MySqlClient

Public Class CustomerLookup
    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader
    Dim con As MySqlConnection = jokenconn()
    Dim sql As String

    Dim OrderID As Integer
    Friend CustomerID As Integer

    Public Function jokenconn() As MySqlConnection
            Return New MySqlConnection("server=localhost;user id=root;database=Indomitable_Database")
    End Function

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If CustomerTextBox.Text.Length > 0 Then
            If IsNumeric(CustomerTextBox.Text) Then
                Try
                    sql = "SELECT * FROM Customer_Table WHERE CustomerID= '" & CustomerTextBox.Text & "'"
                    con.Open()
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                    rd = cmd.ExecuteReader
                    If rd.Read() Then
                        CustomerID = rd.GetString(0)
                        NameLabel.Text = rd.GetString(2)
                        DOBLabel.Text = FormatDateTime(rd.GetString(4), DateFormat.ShortDate)
                        EmailLabel.Text = rd.GetString(10)
                    Else
                        ' If there was no output
                        MessageBox.Show("No customer found with ID: " & CustomerTextBox.Text & "", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    ' If there is and error connection to the database
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' Closes connection to databse
                    con.Close()
                End Try
            Else
                ' If text was entered but not numeric
                MessageBox.Show("Please enter a valid customer ID", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf EmailTextBox.Text.Length > 0 Then
            If IsNumeric(EmailTextBox.Text) = False Then
                Try
                    sql = "SELECT * FROM Customer_Table WHERE Email= '" & EmailTextBox.Text & "'"
                    con.Open()
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                    rd = cmd.ExecuteReader

                    If rd.Read() Then
                        CustomerID = rd.GetString(0)
                        NameLabel.Text = rd.GetString(2)
                        DOBLabel.Text = rd.GetString(4)
                        EmailLabel.Text = rd.GetString(10)
                    Else
                        MessageBox.Show("No cusomter found with email: " & EmailTextBox.Text & "", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try
            Else
                MessageBox.Show("Please enter a valid email.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please enter a customer ID or email.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        CustomerTextBox.Clear()
        EmailTextBox.Clear()
        CustomerTextBox.Focus()
    End Sub

    Private Sub UseButton_Click(sender As Object, e As EventArgs) Handles UseButton.Click
        Me.Hide()
        OrderProducts.Show()
    End Sub
End Class