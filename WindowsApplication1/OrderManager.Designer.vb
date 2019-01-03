<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderManager))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenButton = New System.Windows.Forms.Button()
        Me.CompleteButton = New System.Windows.Forms.Button()
        Me.ReOpenButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.OrderInfoButton = New System.Windows.Forms.Button()
        Me.PendingListBox = New System.Windows.Forms.ListBox()
        Me.OpenedListBox = New System.Windows.Forms.ListBox()
        Me.ClosedListBox = New System.Windows.Forms.ListBox()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pending:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(284, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Open:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(540, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Closed:"
        '
        'OpenButton
        '
        Me.OpenButton.Location = New System.Drawing.Point(189, 435)
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.Size = New System.Drawing.Size(75, 23)
        Me.OpenButton.TabIndex = 6
        Me.OpenButton.Text = "Open Order"
        Me.OpenButton.UseVisualStyleBackColor = True
        '
        'CompleteButton
        '
        Me.CompleteButton.Location = New System.Drawing.Point(429, 435)
        Me.CompleteButton.Name = "CompleteButton"
        Me.CompleteButton.Size = New System.Drawing.Size(90, 23)
        Me.CompleteButton.TabIndex = 8
        Me.CompleteButton.Text = "Complete Order"
        Me.CompleteButton.UseVisualStyleBackColor = True
        '
        'ReOpenButton
        '
        Me.ReOpenButton.Location = New System.Drawing.Point(700, 435)
        Me.ReOpenButton.Name = "ReOpenButton"
        Me.ReOpenButton.Size = New System.Drawing.Size(75, 23)
        Me.ReOpenButton.TabIndex = 9
        Me.ReOpenButton.Text = "Re-Open:"
        Me.ReOpenButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(724, 467)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 10
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'OrderInfoButton
        '
        Me.OrderInfoButton.Location = New System.Drawing.Point(348, 435)
        Me.OrderInfoButton.Name = "OrderInfoButton"
        Me.OrderInfoButton.Size = New System.Drawing.Size(75, 23)
        Me.OrderInfoButton.TabIndex = 11
        Me.OrderInfoButton.Text = "Order Info"
        Me.OrderInfoButton.UseVisualStyleBackColor = True
        '
        'PendingListBox
        '
        Me.PendingListBox.FormattingEnabled = True
        Me.PendingListBox.Location = New System.Drawing.Point(32, 41)
        Me.PendingListBox.Name = "PendingListBox"
        Me.PendingListBox.Size = New System.Drawing.Size(232, 381)
        Me.PendingListBox.TabIndex = 12
        '
        'OpenedListBox
        '
        Me.OpenedListBox.FormattingEnabled = True
        Me.OpenedListBox.Location = New System.Drawing.Point(287, 41)
        Me.OpenedListBox.Name = "OpenedListBox"
        Me.OpenedListBox.Size = New System.Drawing.Size(232, 381)
        Me.OpenedListBox.TabIndex = 13
        '
        'ClosedListBox
        '
        Me.ClosedListBox.FormattingEnabled = True
        Me.ClosedListBox.Location = New System.Drawing.Point(543, 41)
        Me.ClosedListBox.Name = "ClosedListBox"
        Me.ClosedListBox.Size = New System.Drawing.Size(232, 381)
        Me.ClosedListBox.TabIndex = 14
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(32, 435)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton.TabIndex = 15
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'OrderManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 502)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.ClosedListBox)
        Me.Controls.Add(Me.OpenedListBox)
        Me.Controls.Add(Me.PendingListBox)
        Me.Controls.Add(Me.OrderInfoButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ReOpenButton)
        Me.Controls.Add(Me.CompleteButton)
        Me.Controls.Add(Me.OpenButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OrderManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OpenButton As System.Windows.Forms.Button
    Friend WithEvents CompleteButton As System.Windows.Forms.Button
    Friend WithEvents ReOpenButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents OrderInfoButton As System.Windows.Forms.Button
    Friend WithEvents PendingListBox As System.Windows.Forms.ListBox
    Friend WithEvents OpenedListBox As System.Windows.Forms.ListBox
    Friend WithEvents ClosedListBox As System.Windows.Forms.ListBox
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
End Class
