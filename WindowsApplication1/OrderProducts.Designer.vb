<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderProducts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderProducts))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProductSKUTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SizeLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CostLabel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ReceivedQuantityLabel = New System.Windows.Forms.Label()
        Me.ReceivedDateLabel = New System.Windows.Forms.Label()
        Me.BOHLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ProductListBox = New System.Windows.Forms.ListBox()
        Me.ClearItemsButton = New System.Windows.Forms.Button()
        Me.RemoveItemButton = New System.Windows.Forms.Button()
        Me.AddProductButton = New System.Windows.Forms.Button()
        Me.FinishButton = New System.Windows.Forms.Button()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.OrderTotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ColorLabel = New System.Windows.Forms.Label()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.SearchButton)
        Me.GroupBox2.Controls.Add(Me.ProductNameTextBox)
        Me.GroupBox2.Controls.Add(Me.ProductSKUTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(638, 121)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(276, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Or"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Product Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Product SKU:"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(522, 80)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 3
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.Location = New System.Drawing.Point(172, 82)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(332, 20)
        Me.ProductNameTextBox.TabIndex = 2
        '
        'ProductSKUTextBox
        '
        Me.ProductSKUTextBox.Location = New System.Drawing.Point(172, 26)
        Me.ProductSKUTextBox.Name = "ProductSKUTextBox"
        Me.ProductSKUTextBox.Size = New System.Drawing.Size(228, 20)
        Me.ProductSKUTextBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DescriptionTextBox)
        Me.GroupBox1.Controls.Add(Me.ColorLabel)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.SizeLabel)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.LocationLabel)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.CostLabel)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.ReceivedQuantityLabel)
        Me.GroupBox1.Controls.Add(Me.ReceivedDateLabel)
        Me.GroupBox1.Controls.Add(Me.BOHLabel)
        Me.GroupBox1.Controls.Add(Me.NameLabel)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 254)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Info"
        '
        'SizeLabel
        '
        Me.SizeLabel.AutoSize = True
        Me.SizeLabel.Location = New System.Drawing.Point(442, 119)
        Me.SizeLabel.Name = "SizeLabel"
        Me.SizeLabel.Size = New System.Drawing.Size(32, 13)
        Me.SizeLabel.TabIndex = 22
        Me.SizeLabel.Text = "Small"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(401, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Size:"
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Location = New System.Drawing.Point(442, 160)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(62, 13)
        Me.LocationLabel.TabIndex = 20
        Me.LocationLabel.Text = "Warehouse"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(372, 160)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Location:"
        '
        'CostLabel
        '
        Me.CostLabel.AutoSize = True
        Me.CostLabel.Location = New System.Drawing.Point(131, 119)
        Me.CostLabel.Name = "CostLabel"
        Me.CostLabel.Size = New System.Drawing.Size(40, 13)
        Me.CostLabel.TabIndex = 18
        Me.CostLabel.Text = "$99.99"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(89, 119)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Cost:"
        '
        'ReceivedQuantityLabel
        '
        Me.ReceivedQuantityLabel.AutoSize = True
        Me.ReceivedQuantityLabel.Location = New System.Drawing.Point(442, 79)
        Me.ReceivedQuantityLabel.Name = "ReceivedQuantityLabel"
        Me.ReceivedQuantityLabel.Size = New System.Drawing.Size(13, 13)
        Me.ReceivedQuantityLabel.TabIndex = 16
        Me.ReceivedQuantityLabel.Text = "0"
        '
        'ReceivedDateLabel
        '
        Me.ReceivedDateLabel.AutoSize = True
        Me.ReceivedDateLabel.Location = New System.Drawing.Point(442, 38)
        Me.ReceivedDateLabel.Name = "ReceivedDateLabel"
        Me.ReceivedDateLabel.Size = New System.Drawing.Size(27, 13)
        Me.ReceivedDateLabel.TabIndex = 15
        Me.ReceivedDateLabel.Text = "N/A"
        '
        'BOHLabel
        '
        Me.BOHLabel.AutoSize = True
        Me.BOHLabel.Location = New System.Drawing.Point(131, 79)
        Me.BOHLabel.Name = "BOHLabel"
        Me.BOHLabel.Size = New System.Drawing.Size(13, 13)
        Me.BOHLabel.TabIndex = 13
        Me.BOHLabel.Text = "0"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(131, 38)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(27, 13)
        Me.NameLabel.TabIndex = 12
        Me.NameLabel.Text = "N/A"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(292, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Last Received Quantity:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(312, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Last Received Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "BOH:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(82, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Name:"
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(769, 452)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(86, 32)
        Me.BackButton.TabIndex = 15
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ProductListBox
        '
        Me.ProductListBox.FormattingEnabled = True
        Me.ProductListBox.Location = New System.Drawing.Point(658, 26)
        Me.ProductListBox.Name = "ProductListBox"
        Me.ProductListBox.Size = New System.Drawing.Size(197, 381)
        Me.ProductListBox.TabIndex = 20
        '
        'ClearItemsButton
        '
        Me.ClearItemsButton.Location = New System.Drawing.Point(769, 414)
        Me.ClearItemsButton.Name = "ClearItemsButton"
        Me.ClearItemsButton.Size = New System.Drawing.Size(86, 32)
        Me.ClearItemsButton.TabIndex = 21
        Me.ClearItemsButton.Text = "Clear Items"
        Me.ClearItemsButton.UseVisualStyleBackColor = True
        '
        'RemoveItemButton
        '
        Me.RemoveItemButton.Location = New System.Drawing.Point(664, 414)
        Me.RemoveItemButton.Name = "RemoveItemButton"
        Me.RemoveItemButton.Size = New System.Drawing.Size(86, 32)
        Me.RemoveItemButton.TabIndex = 22
        Me.RemoveItemButton.Text = "Remove Item"
        Me.RemoveItemButton.UseVisualStyleBackColor = True
        '
        'AddProductButton
        '
        Me.AddProductButton.Location = New System.Drawing.Point(571, 414)
        Me.AddProductButton.Name = "AddProductButton"
        Me.AddProductButton.Size = New System.Drawing.Size(79, 33)
        Me.AddProductButton.TabIndex = 23
        Me.AddProductButton.Text = "Add Product"
        Me.AddProductButton.UseVisualStyleBackColor = True
        '
        'FinishButton
        '
        Me.FinishButton.Location = New System.Drawing.Point(664, 452)
        Me.FinishButton.Name = "FinishButton"
        Me.FinishButton.Size = New System.Drawing.Size(86, 32)
        Me.FinishButton.TabIndex = 24
        Me.FinishButton.Text = "Finish Order"
        Me.FinishButton.UseVisualStyleBackColor = True
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(457, 421)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantityTextBox.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(393, 424)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Quantity:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(376, 452)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Order Total:"
        '
        'OrderTotalTextBox
        '
        Me.OrderTotalTextBox.Location = New System.Drawing.Point(457, 449)
        Me.OrderTotalTextBox.Name = "OrderTotalTextBox"
        Me.OrderTotalTextBox.ReadOnly = True
        Me.OrderTotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OrderTotalTextBox.TabIndex = 28
        Me.OrderTotalTextBox.Text = "$0.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(392, 199)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Color:"
        '
        'ColorLabel
        '
        Me.ColorLabel.AutoSize = True
        Me.ColorLabel.Location = New System.Drawing.Point(442, 199)
        Me.ColorLabel.Name = "ColorLabel"
        Me.ColorLabel.Size = New System.Drawing.Size(27, 13)
        Me.ColorLabel.TabIndex = 24
        Me.ColorLabel.Text = "N/A"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(131, 157)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(235, 81)
        Me.DescriptionTextBox.TabIndex = 25
        '
        'OrderProducts
        '
        Me.AcceptButton = Me.SearchButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 491)
        Me.Controls.Add(Me.OrderTotalTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.FinishButton)
        Me.Controls.Add(Me.AddProductButton)
        Me.Controls.Add(Me.RemoveItemButton)
        Me.Controls.Add(Me.ClearItemsButton)
        Me.Controls.Add(Me.ProductListBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BackButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OrderProducts"
        Me.Text = "Order Products"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents ProductNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductSKUTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SizeLabel As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LocationLabel As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CostLabel As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ReceivedQuantityLabel As System.Windows.Forms.Label
    Friend WithEvents ReceivedDateLabel As System.Windows.Forms.Label
    Friend WithEvents BOHLabel As System.Windows.Forms.Label
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents ProductListBox As System.Windows.Forms.ListBox
    Friend WithEvents ClearItemsButton As System.Windows.Forms.Button
    Friend WithEvents RemoveItemButton As System.Windows.Forms.Button
    Friend WithEvents AddProductButton As System.Windows.Forms.Button
    Friend WithEvents FinishButton As System.Windows.Forms.Button
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents OrderTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColorLabel As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
