<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderInfo))
        Me.ProductListBox = New System.Windows.Forms.ListBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ProductButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderIDLabel = New System.Windows.Forms.Label()
        Me.CustomerLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'ProductListBox
        '
        Me.ProductListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ProductListBox.FormattingEnabled = true
        Me.ProductListBox.ItemHeight = 16
        Me.ProductListBox.Location = New System.Drawing.Point(470, 28)
        Me.ProductListBox.MultiColumn = true
        Me.ProductListBox.Name = "ProductListBox"
        Me.ProductListBox.Size = New System.Drawing.Size(209, 324)
        Me.ProductListBox.TabIndex = 0
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(604, 358)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 39)
        Me.BackButton.TabIndex = 16
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = true
        '
        'ProductButton
        '
        Me.ProductButton.Location = New System.Drawing.Point(470, 358)
        Me.ProductButton.Name = "ProductButton"
        Me.ProductButton.Size = New System.Drawing.Size(75, 39)
        Me.ProductButton.TabIndex = 17
        Me.ProductButton.Text = "Product Info"
        Me.ProductButton.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order ID:"
        '
        'OrderIDLabel
        '
        Me.OrderIDLabel.AutoSize = true
        Me.OrderIDLabel.Location = New System.Drawing.Point(121, 35)
        Me.OrderIDLabel.Name = "OrderIDLabel"
        Me.OrderIDLabel.Size = New System.Drawing.Size(31, 13)
        Me.OrderIDLabel.TabIndex = 2
        Me.OrderIDLabel.Text = "9999"
        '
        'CustomerLabel
        '
        Me.CustomerLabel.AutoSize = true
        Me.CustomerLabel.Location = New System.Drawing.Point(121, 113)
        Me.CustomerLabel.Name = "CustomerLabel"
        Me.CustomerLabel.Size = New System.Drawing.Size(27, 13)
        Me.CustomerLabel.TabIndex = 3
        Me.CustomerLabel.Text = "N/A"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Customer Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Shipping Address:"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Order Status:"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = true
        Me.AddressLabel.Location = New System.Drawing.Point(121, 157)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(27, 13)
        Me.AddressLabel.TabIndex = 10
        Me.AddressLabel.Text = "N/A"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = true
        Me.StatusLabel.Location = New System.Drawing.Point(121, 198)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(46, 13)
        Me.StatusLabel.TabIndex = 13
        Me.StatusLabel.Text = "Pending"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateLabel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.StatusLabel)
        Me.GroupBox1.Controls.Add(Me.AddressLabel)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CustomerLabel)
        Me.GroupBox1.Controls.Add(Me.OrderIDLabel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 340)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Order Information"
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = true
        Me.DateLabel.Location = New System.Drawing.Point(121, 72)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(61, 13)
        Me.DateLabel.TabIndex = 15
        Me.DateLabel.Text = "9999-31-12"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Order Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(471, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Product List:"
        '
        'OrderInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 413)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ProductButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ProductListBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "OrderInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Info"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ProductListBox As System.Windows.Forms.ListBox
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents ProductButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OrderIDLabel As System.Windows.Forms.Label
    Friend WithEvents CustomerLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents AddressLabel As System.Windows.Forms.Label
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
