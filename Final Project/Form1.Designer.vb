<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnSalariedEmployee = New System.Windows.Forms.Button()
        Me.btnHouryEmployees = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSalariedEmployee
        '
        Me.btnSalariedEmployee.Location = New System.Drawing.Point(89, 74)
        Me.btnSalariedEmployee.Name = "btnSalariedEmployee"
        Me.btnSalariedEmployee.Size = New System.Drawing.Size(299, 111)
        Me.btnSalariedEmployee.TabIndex = 0
        Me.btnSalariedEmployee.Text = "Salaried Employee"
        Me.btnSalariedEmployee.UseVisualStyleBackColor = True
        '
        'btnHouryEmployees
        '
        Me.btnHouryEmployees.Location = New System.Drawing.Point(89, 234)
        Me.btnHouryEmployees.Name = "btnHouryEmployees"
        Me.btnHouryEmployees.Size = New System.Drawing.Size(299, 114)
        Me.btnHouryEmployees.TabIndex = 1
        Me.btnHouryEmployees.Text = "Hourly Employee"
        Me.btnHouryEmployees.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(151, 404)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(159, 49)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 528)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHouryEmployees)
        Me.Controls.Add(Me.btnSalariedEmployee)
        Me.Name = "frmMain"
        Me.Text = "Payroll Calculation"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalariedEmployee As Button
    Friend WithEvents btnHouryEmployees As Button
    Friend WithEvents btnExit As Button
End Class
