<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentForm))
        Me.VisaRadioButton = New System.Windows.Forms.RadioButton()
        Me.MasterCardRadioButton = New System.Windows.Forms.RadioButton()
        Me.AmericanExpressRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.YearComboBox = New System.Windows.Forms.ComboBox()
        Me.MonthComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SecurityCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CardNumberTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlaceOrderButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.EditOrderButton = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VisaRadioButton
        '
        Me.VisaRadioButton.AutoSize = True
        Me.VisaRadioButton.CausesValidation = False
        Me.VisaRadioButton.Location = New System.Drawing.Point(31, 25)
        Me.VisaRadioButton.Name = "VisaRadioButton"
        Me.VisaRadioButton.Size = New System.Drawing.Size(45, 17)
        Me.VisaRadioButton.TabIndex = 0
        Me.VisaRadioButton.TabStop = True
        Me.VisaRadioButton.Text = "Visa"
        Me.VisaRadioButton.UseVisualStyleBackColor = True
        '
        'MasterCardRadioButton
        '
        Me.MasterCardRadioButton.AutoSize = True
        Me.MasterCardRadioButton.CausesValidation = False
        Me.MasterCardRadioButton.Location = New System.Drawing.Point(31, 48)
        Me.MasterCardRadioButton.Name = "MasterCardRadioButton"
        Me.MasterCardRadioButton.Size = New System.Drawing.Size(82, 17)
        Me.MasterCardRadioButton.TabIndex = 1
        Me.MasterCardRadioButton.TabStop = True
        Me.MasterCardRadioButton.Text = "Master Card"
        Me.MasterCardRadioButton.UseVisualStyleBackColor = True
        '
        'AmericanExpressRadioButton
        '
        Me.AmericanExpressRadioButton.AutoSize = True
        Me.AmericanExpressRadioButton.CausesValidation = False
        Me.AmericanExpressRadioButton.Location = New System.Drawing.Point(31, 71)
        Me.AmericanExpressRadioButton.Name = "AmericanExpressRadioButton"
        Me.AmericanExpressRadioButton.Size = New System.Drawing.Size(109, 17)
        Me.AmericanExpressRadioButton.TabIndex = 2
        Me.AmericanExpressRadioButton.TabStop = True
        Me.AmericanExpressRadioButton.Text = "American Express"
        Me.AmericanExpressRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AmericanExpressRadioButton)
        Me.GroupBox1.Controls.Add(Me.MasterCardRadioButton)
        Me.GroupBox1.Controls.Add(Me.VisaRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(156, 108)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Card Type"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.YearComboBox)
        Me.GroupBox2.Controls.Add(Me.MonthComboBox)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.SecurityCodeTextBox)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.CardNumberTextBox)
        Me.GroupBox2.Controls.Add(Me.NameTextBox)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(226, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 178)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment Info"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(246, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Year:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(120, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Month:"
        '
        'YearComboBox
        '
        Me.YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearComboBox.FormattingEnabled = True
        Me.YearComboBox.Items.AddRange(New Object() {"17", "18", "19", "20", "21", "22", "23", "24"})
        Me.YearComboBox.Location = New System.Drawing.Point(284, 96)
        Me.YearComboBox.Name = "YearComboBox"
        Me.YearComboBox.Size = New System.Drawing.Size(74, 21)
        Me.YearComboBox.TabIndex = 10
        '
        'MonthComboBox
        '
        Me.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MonthComboBox.FormattingEnabled = True
        Me.MonthComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.MonthComboBox.Location = New System.Drawing.Point(166, 96)
        Me.MonthComboBox.Name = "MonthComboBox"
        Me.MonthComboBox.Size = New System.Drawing.Size(74, 21)
        Me.MonthComboBox.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Experation Date:"
        '
        'SecurityCodeTextBox
        '
        Me.SecurityCodeTextBox.Location = New System.Drawing.Point(117, 127)
        Me.SecurityCodeTextBox.Name = "SecurityCodeTextBox"
        Me.SecurityCodeTextBox.Size = New System.Drawing.Size(74, 20)
        Me.SecurityCodeTextBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Security Code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Card Number:"
        '
        'CardNumberTextBox
        '
        Me.CardNumberTextBox.Location = New System.Drawing.Point(117, 59)
        Me.CardNumberTextBox.Name = "CardNumberTextBox"
        Me.CardNumberTextBox.Size = New System.Drawing.Size(274, 20)
        Me.CardNumberTextBox.TabIndex = 3
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(117, 24)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(274, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name on card:"
        '
        'PlaceOrderButton
        '
        Me.PlaceOrderButton.Location = New System.Drawing.Point(559, 217)
        Me.PlaceOrderButton.Name = "PlaceOrderButton"
        Me.PlaceOrderButton.Size = New System.Drawing.Size(91, 36)
        Me.PlaceOrderButton.TabIndex = 5
        Me.PlaceOrderButton.Text = "Place Order"
        Me.PlaceOrderButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Order Total:"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(111, 57)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(40, 13)
        Me.TotalLabel.TabIndex = 14
        Me.TotalLabel.Text = "$99.99"
        '
        'EditOrderButton
        '
        Me.EditOrderButton.CausesValidation = False
        Me.EditOrderButton.Location = New System.Drawing.Point(38, 217)
        Me.EditOrderButton.Name = "EditOrderButton"
        Me.EditOrderButton.Size = New System.Drawing.Size(91, 36)
        Me.EditOrderButton.TabIndex = 15
        Me.EditOrderButton.Text = "Edit Order"
        Me.EditOrderButton.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 267)
        Me.Controls.Add(Me.EditOrderButton)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PlaceOrderButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PaymentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment and Shipping"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VisaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MasterCardRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents AmericanExpressRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SecurityCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CardNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents YearComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MonthComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PlaceOrderButton As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents EditOrderButton As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
