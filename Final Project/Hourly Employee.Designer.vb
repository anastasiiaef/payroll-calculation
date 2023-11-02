<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHourlyEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radIndiana = New System.Windows.Forms.RadioButton()
        Me.radKentucky = New System.Windows.Forms.RadioButton()
        Me.radOhio = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtHoursWorked = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHourlyWage = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubmitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radIndiana)
        Me.GroupBox2.Controls.Add(Me.radKentucky)
        Me.GroupBox2.Controls.Add(Me.radOhio)
        Me.GroupBox2.Location = New System.Drawing.Point(200, 332)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(178, 186)
        Me.GroupBox2.TabIndex = 25
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHoursWorked)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtHourlyWage)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 264)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Location = New System.Drawing.Point(176, 207)
        Me.txtHoursWorked.Multiline = True
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(170, 39)
        Me.txtHoursWorked.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 25)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Hours Worked"
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
        'txtHourlyWage
        '
        Me.txtHourlyWage.Location = New System.Drawing.Point(176, 149)
        Me.txtHourlyWage.Multiline = True
        Me.txtHourlyWage.Name = "txtHourlyWage"
        Me.txtHourlyWage.Size = New System.Drawing.Size(170, 39)
        Me.txtHourlyWage.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hourly Wage"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(176, 96)
        Me.txtLastName.Multiline = True
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(170, 39)
        Me.txtLastName.TabIndex = 15
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(176, 38)
        Me.txtFirstName.Multiline = True
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(170, 39)
        Me.txtFirstName.TabIndex = 14
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 470)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(170, 48)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 400)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(168, 48)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(12, 332)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(170, 48)
        Me.btnSubmit.TabIndex = 21
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 25
        Me.lstOutput.Location = New System.Drawing.Point(394, 51)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(411, 454)
        Me.lstOutput.TabIndex = 20
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 40)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(820, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProjectToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(820, 40)
        Me.MenuStrip2.TabIndex = 27
        Me.MenuStrip2.Text = "MenuStrip2"
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
        'frmHourlyEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 532)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmHourlyEmployee"
        Me.Text = "Hourly Employee"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radIndiana As RadioButton
    Friend WithEvents radKentucky As RadioButton
    Friend WithEvents radOhio As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtHoursWorked As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHourlyWage As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubmitToolStripMenuItem As ToolStripMenuItem
End Class
