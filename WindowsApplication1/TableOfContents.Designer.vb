<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableOfContents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TableOfContents))
        Me.SearchProductButton = New System.Windows.Forms.Button()
        Me.OrderManagerButton = New System.Windows.Forms.Button()
        Me.AccountingButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CreateOrderButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchProductButton
        '
        Me.SearchProductButton.Location = New System.Drawing.Point(93, 231)
        Me.SearchProductButton.Name = "SearchProductButton"
        Me.SearchProductButton.Size = New System.Drawing.Size(127, 77)
        Me.SearchProductButton.TabIndex = 0
        Me.SearchProductButton.Text = "Search Product"
        Me.SearchProductButton.UseVisualStyleBackColor = True
        '
        'OrderManagerButton
        '
        Me.OrderManagerButton.Location = New System.Drawing.Point(266, 231)
        Me.OrderManagerButton.Name = "OrderManagerButton"
        Me.OrderManagerButton.Size = New System.Drawing.Size(127, 77)
        Me.OrderManagerButton.TabIndex = 1
        Me.OrderManagerButton.Text = "Order Manager"
        Me.OrderManagerButton.UseVisualStyleBackColor = True
        '
        'AccountingButton
        '
        Me.AccountingButton.Location = New System.Drawing.Point(266, 326)
        Me.AccountingButton.Name = "AccountingButton"
        Me.AccountingButton.Size = New System.Drawing.Size(127, 77)
        Me.AccountingButton.TabIndex = 2
        Me.AccountingButton.Text = "Generate Accounting Excel Document"
        Me.AccountingButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(318, 434)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(75, 45)
        Me.LogoutButton.TabIndex = 3
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(107, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(268, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Inventory and Order Manager"
        '
        'CreateOrderButton
        '
        Me.CreateOrderButton.Location = New System.Drawing.Point(93, 326)
        Me.CreateOrderButton.Name = "CreateOrderButton"
        Me.CreateOrderButton.Size = New System.Drawing.Size(127, 77)
        Me.CreateOrderButton.TabIndex = 11
        Me.CreateOrderButton.Text = "Create Order"
        Me.CreateOrderButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.indomitabletext
        Me.PictureBox1.Location = New System.Drawing.Point(63, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(356, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'TableOfContents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 505)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CreateOrderButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.AccountingButton)
        Me.Controls.Add(Me.OrderManagerButton)
        Me.Controls.Add(Me.SearchProductButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TableOfContents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Table Of Contents"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchProductButton As System.Windows.Forms.Button
    Friend WithEvents OrderManagerButton As System.Windows.Forms.Button
    Friend WithEvents AccountingButton As System.Windows.Forms.Button
    Friend WithEvents LogoutButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CreateOrderButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
