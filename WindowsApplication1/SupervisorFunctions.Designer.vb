<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupervisorFunctions
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
        Me.AddEmployeeButton = New System.Windows.Forms.Button()
        Me.ManageEmployeeButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddEmployeeButton
        '
        Me.AddEmployeeButton.Location = New System.Drawing.Point(192, 223)
        Me.AddEmployeeButton.Name = "AddEmployeeButton"
        Me.AddEmployeeButton.Size = New System.Drawing.Size(127, 77)
        Me.AddEmployeeButton.TabIndex = 1
        Me.AddEmployeeButton.Text = "Add Employee"
        Me.AddEmployeeButton.UseVisualStyleBackColor = True
        '
        'ManageEmployeeButton
        '
        Me.ManageEmployeeButton.Location = New System.Drawing.Point(360, 223)
        Me.ManageEmployeeButton.Name = "ManageEmployeeButton"
        Me.ManageEmployeeButton.Size = New System.Drawing.Size(127, 77)
        Me.ManageEmployeeButton.TabIndex = 2
        Me.ManageEmployeeButton.Text = "Manage Employee"
        Me.ManageEmployeeButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(568, 474)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 37)
        Me.BackButton.TabIndex = 3
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'SupervisorFunctions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 523)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ManageEmployeeButton)
        Me.Controls.Add(Me.AddEmployeeButton)
        Me.Name = "SupervisorFunctions"
        Me.Text = "SupervisorFunctions"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AddEmployeeButton As System.Windows.Forms.Button
    Friend WithEvents ManageEmployeeButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
End Class
