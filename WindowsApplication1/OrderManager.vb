Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class OrderManager
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim rd As MySqlDataReader
    Dim con As MySqlConnection = jokenconn()
    Dim sql As String

    Public Function jokenconn() As MySqlConnection
            Return New MySqlConnection("server=localhost;user id=root;database=Indomitable_Database")
    End Function

    Public Function refreshOrders()
        PendingListBox.Items.Clear()
        OpenedListBox.Items.Clear()
        ClosedListBox.Items.Clear()
        Try
            con.Open()
            ' Selects just the orderID where the orderStatus is 0
            sql = "SELECT OrderID FROM Order_Table WHERE OrderStatus=0"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
            rd = cmd.ExecuteReader
            ' While loop adds items to list
            While rd.Read()
                PendingListBox.Items.Add("Order ID: " + rd.GetString(0))
            End While
        Catch ex As Exception
            MessageBox.Show("Database Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        Try
            con.Open()
            sql = "SELECT OrderID FROM Order_Table WHERE OrderStatus=1"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
            rd = cmd.ExecuteReader
            While rd.Read()
                OpenedListBox.Items.Add("Order ID: " + rd.GetString(0))
            End While
        Catch ex As Exception
            MessageBox.Show("Database Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        Try
            con.Open()
            sql = "SELECT OrderID FROM Order_Table WHERE OrderStatus=2"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
            rd = cmd.ExecuteReader
            While rd.Read()
                ClosedListBox.Items.Add("Order ID: " + rd.GetString(0))
            End While
        Catch ex As Exception
            MessageBox.Show("Database Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Function

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        refreshOrders()
        Me.Hide()
        TableOfContents.Show()
    End Sub

    Private Sub OrderManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshOrders()
    End Sub

    Private Sub OpenButton_Click(sender As Object, e As EventArgs) Handles OpenButton.Click
        If Not PendingListBox.SelectedIndex = -1 Then
            Dim orderString As String = PendingListBox.SelectedItems(0)
            Dim orderID As Integer = Integer.Parse(Regex.Replace(orderString, "[^\d]", ""))

            Try
                con.Open()
                sql = "UPDATE Order_Table SET OrderStatus = 1 WHERE OrderID = " & orderID & ""
                cmd.Connection = con
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Database Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
            refreshOrders()
        Else
            'MessageBox.Show("Please select a pending order...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub OrderInfoButton_Click(sender As Object, e As EventArgs) Handles OrderInfoButton.Click
        Try
            Dim orderString As String = OpenedListBox.SelectedItems(0)
            Dim orderID As Integer = Integer.Parse(Regex.Replace(orderString, "[^\d]", ""))
            OrderInfo.OrderID = orderID
            OrderInfo.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CompleteButton_Click(sender As Object, e As EventArgs) Handles CompleteButton.Click
        If Not OpenedListBox.SelectedIndex = -1 Then
            Dim orderString As String = OpenedListBox.SelectedItems(0)
            Dim orderID As Integer = Integer.Parse(Regex.Replace(orderString, "[^\d]", ""))

            Try
                con.Open()
                sql = "UPDATE Order_Table SET OrderStatus = 2 WHERE OrderID = " & orderID & ""
                cmd.Connection = con
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Database Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
            refreshOrders()
        Else
            'MessageBox.Show("Please select an open order...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ReOpenButton_Click(sender As Object, e As EventArgs) Handles ReOpenButton.Click
        If Not ClosedListBox.SelectedIndex = -1 Then
            Dim orderString As String = ClosedListBox.SelectedItems(0)
            Dim orderID As Integer = Integer.Parse(Regex.Replace(orderString, "[^\d]", ""))

            Try
                con.Open()
                sql = "UPDATE Order_Table SET OrderStatus = 1 WHERE OrderID = " & orderID & ""
                cmd.Connection = con
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Database Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
            refreshOrders()
        Else
            'MessageBox.Show("Please select a completed order...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        refreshOrders()
    End Sub
End Class