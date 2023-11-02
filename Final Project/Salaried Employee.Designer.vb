<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalariedEmployee
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtYearlySalary = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radIndiana = New System.Windows.Forms.RadioButton()
        Me.radKentucky = New System.Windows.Forms.RadioButton()
        Me.radOhio = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubmitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Yearly Salary"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 25
        Me.lstOutput.Location = New System.Drawing.Point(411, 51)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(411, 404)
        Me.lstOutput.TabIndex = 9
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(29, 270)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(170, 48)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(29, 338)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(168, 48)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(29, 408)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(170, 48)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(176, 38)
        Me.txtFirstName.Multiline = True
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(170, 39)
        Me.txtFirstName.TabIndex = 14
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(176, 96)
        Me.txtLastName.Multiline = True
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(170, 39)
        Me.txtLastName.TabIndex = 15
        '
        'txtYearlySalary
        '
        Me.txtYearlySalary.Location = New System.Drawing.Point(176, 149)
        Me.txtYearlySalary.Multiline = True
        Me.txtYearlySalary.Name = "txtYearlySalary"
        Me.txtYearlySalary.Size = New System.Drawing.Size(170, 39)
        Me.txtYearlySalary.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtYearlySalary)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 208)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radIndiana)
        Me.GroupBox2.Controls.Add(Me.radKentucky)
        Me.GroupBox2.Controls.Add(Me.radOhio)
        Me.GroupBox2.Location = New System.Drawing.Point(217, 270)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(178, 186)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select State"
        '
        'radIndiana
        '
        Me.radIndiana.AutoSize = True
        Me.radIndiana.Location = New System.Drawing.Point(20, 144)
        Me.radIndiana.Name = "radIndiana"
        Me.radIndiana.Size = New System.Drawing.Size(113, 29)
        Me.radIndiana.TabIndex = 2
        Me.radIndiana.TabStop = True
        Me.radIndiana.Text = "Indiana"
        Me.radIndiana.UseVisualStyleBackColor = True
        '
        'radKentucky
        '
        Me.radKentucky.AutoSize = True
        Me.radKentucky.Location = New System.Drawing.Point(20, 98)
        Me.radKentucky.Name = "radKentucky"
        Me.radKentucky.Size = New System.Drawing.Size(132, 29)
        Me.radKentucky.TabIndex = 1
        Me.radKentucky.Text = "Kentucky"
        Me.radKentucky.UseVisualStyleBackColor = True
        '
        'radOhio
        '
        Me.radOhio.AutoSize = True
        Me.radOhio.Checked = True
        Me.radOhio.Location = New System.Drawing.Point(20, 46)
        Me.radOhio.Name = "radOhio"
        Me.radOhio.Size = New System.Drawing.Size(88, 29)
        Me.radOhio.TabIndex = 0
        Me.radOhio.TabStop = True
        Me.radOhio.Text = "Ohio"
        Me.radOhio.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProjectToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(844, 40)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(72, 38)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ProjectToolStripMenuItem
        '
        Me.ProjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubmitToolStripMenuItem})
        Me.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem"
        Me.ProjectToolStripMenuItem.Size = New System.Drawing.Size(108, 38)
        Me.ProjectToolStripMenuItem.Text = "Project"
        '
        'SubmitToolStripMenuItem
        '
        Me.SubmitToolStripMenuItem.Name = "SubmitToolStripMenuItem"
        Me.SubmitToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.SubmitToolStripMenuItem.Text = "Submit"
        '
        'frmSalariedEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 486)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lstOutput)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSalariedEmployee"
        Me.Text = "Salaried Employee"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtYearlySalary As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radIndiana As RadioButton
    Friend WithEvents radKentucky As RadioButton
    Friend WithEvents radOhio As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubmitToolStripMenuItem As ToolStripMenuItem
End Class
