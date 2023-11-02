' **************************************************************************************
' Anastasiia Efimova
' Final Project
' 04/27/2021
' **************************************************************************************

Public Class frmSalariedEmployee
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'closes the program
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear out the controlls
        txtLastName.Clear()
        txtYearlySalary.Clear()
        txtFirstName.Clear()

        'put focus on First Name text box
        txtFirstName.Focus()

        'set the radOhio button back to default
        radOhio.Checked = True

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'create a local variables
        Dim dblNetPay As Double
        Dim dblFICA As Double
        Dim dblStateTax As Double
        Dim dblFederalTax As Double
        Dim dblGrossPay As Double
        Dim dblYearlySalary As Double

        'set text box back to white in case they are yellow
        txtLastName.BackColor = Color.White
        txtFirstName.BackColor = Color.White
        txtYearlySalary.BackColor = Color.White

        'validation for First and Last Name as we don't need to return the value, use Sub
        If txtFirstName.Text = String.Empty Then
            MessageBox.Show("Please enter First Name")
            txtFirstName.BackColor = Color.Yellow
            txtFirstName.Focus()
            Exit Sub
        End If

        If txtLastName.Text = String.Empty Then
            MessageBox.Show("Please enter Last Name")
            txtLastName.BackColor = Color.Yellow
            txtLastName.Focus()
            Exit Sub
        End If

        'call main validation and only proceed if true
        If ValidInput(dblYearlySalary) = True Then

            'do calculation
            'calculate Gross Pay
            dblGrossPay = CalculateGrossPay(dblYearlySalary)

            'calculate FICA
            dblFICA = CalculateFICA(dblGrossPay)

            'calculate State Taxes
            dblStateTax = CalculateStateTax(dblGrossPay)

            'calculate Federal Tax
            dblFederalTax = CalculateFederalTax(dblGrossPay)

            'calculate Net Pay
            dblNetPay = CalculateNetPay(dblGrossPay, dblFICA, dblStateTax, dblFederalTax)

            'display outputs
            Display(dblNetPay, dblFICA, dblStateTax, dblFederalTax, dblGrossPay)
        End If

    End Sub

    Function ValidInput(ByRef YearlySalary As Double) As Boolean

        If ValidYearlySalary(YearlySalary) = True Then
            If ValidRangYearlySalary(YearlySalary) = True Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function

    Function ValidYearlySalary(ByRef YearlySalary As Double) As Boolean

        'validation for Yearly Salary
        If IsNumeric(txtYearlySalary.Text) Then
            YearlySalary = txtYearlySalary.Text
            Return True
        Else
            MessageBox.Show("Please enter Yearly Salary")
            txtYearlySalary.BackColor = Color.Yellow
            txtYearlySalary.Focus()
            Return False
        End If

    End Function

    Function ValidRangYearlySalary(ByRef YearlySalary As Double) As Boolean

        'range validation for Yearly Salary
        If YearlySalary < 0 Then
            MessageBox.Show("Please enter posetive numbers only for Yearly Salary")
            txtYearlySalary.BackColor = Color.Yellow
            txtYearlySalary.Focus()
            Return False
        End If

        Return YearlySalary

    End Function

    Function CalculateGrossPay(ByVal YearlySalary As Double) As Double

        'ceate Const for Payrolls per Year
        Const dblPayrollsPerYear As Double = 52

        'create variable for Gross Pay
        Dim dblGrossPay As Double

        'calculate Gross Pay
        dblGrossPay = YearlySalary / dblPayrollsPerYear

        'return Gross Pay
        Return dblGrossPay

    End Function

    Function CalculateFICA(ByVal GrossPay As Double) As Double

        'create constant for Social Security Tax
        Const dblSocialSecurityTax As Double = 0.062

        'create variables for FICA
        Dim dblFICA As Double

        'do calculation
        If GrossPay < 125000 Then
            dblFICA = GrossPay * dblSocialSecurityTax
        Else
            dblFICA = 0
        End If

        'return FICA value
        Return dblFICA

    End Function

    Function CalculateStateTax(ByVal GrossPay As Double) As Double

        'create State Tax Const for each state
        Const dblOhio As Double = 0.065
        Const dblKentucky As Double = 0.06
        Const dblIndiana As Double = 0.055

        'create variables for StateTax
        Dim dblStateTax As Double

        'calculate State Tax
        If radOhio.Checked = True Then
            dblStateTax = GrossPay * dblOhio
        Else
            If radKentucky.Checked = True Then
                dblStateTax = GrossPay * dblKentucky
            Else
                If radIndiana.Checked = True Then
                    dblStateTax = GrossPay * dblIndiana
                End If
            End If
        End If

        'return State Tax valur
        Return dblStateTax

    End Function

    Private Sub Display(ByVal NetPay As Double, ByVal FICA As Double,
                     ByVal StateTax As Double, ByVal FederalTax As Double, ByVal GrossPay As Double)

        'display the amounts formatted with headers and separaters
        lstOutput.Items.Add("Net Pay:" & vbTab & vbTab & NetPay.ToString("c"))
        lstOutput.Items.Add("FICA:" & vbTab & vbTab & FICA.ToString("c"))
        lstOutput.Items.Add("State Tax:" & vbTab & StateTax.ToString("c"))
        lstOutput.Items.Add("Federal Tax:" & vbTab & FederalTax.ToString("c"))
        lstOutput.Items.Add("Gross Pay:" & vbTab & GrossPay.ToString("c"))
        lstOutput.Items.Add("")

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click

        'clear out the controlls
        txtLastName.Clear()
        txtYearlySalary.Clear()
        txtFirstName.Clear()

        'put focus on First Name text box
        txtFirstName.Focus()

        'set the radOhio button back to default
        radOhio.Checked = True

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        'closesthe program
        Close()
    End Sub

    Private Sub SubmitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubmitToolStripMenuItem.Click

        'create a local variables
        Dim dblNetPay As Double
        Dim dblFICA As Double
        Dim dblStateTax As Double
        Dim dblFederalTax As Double
        Dim dblGrossPay As Double
        Dim dblYearlySalary As Double

        'set text box back to white in case they are yellow
        txtLastName.BackColor = Color.White
        txtFirstName.BackColor = Color.White
        txtYearlySalary.BackColor = Color.White

        'validation for First and Last Name as we don't need to return the value, use Sub
        If txtFirstName.Text = String.Empty Then
            MessageBox.Show("Please enter First Name")
            txtFirstName.BackColor = Color.Yellow
            txtFirstName.Focus()
            Exit Sub
        End If

        If txtLastName.Text = String.Empty Then
            MessageBox.Show("Please enter Last Name")
            txtLastName.BackColor = Color.Yellow
            txtLastName.Focus()
            Exit Sub
        End If

        'call main validation and only proceed if true
        If ValidInput(dblYearlySalary) = True Then

            'do calculation
            'calculate Gross Pay
            dblGrossPay = CalculateGrossPay(dblYearlySalary)

            'calculate FICA
            dblFICA = CalculateFICA(dblGrossPay)

            'calculate State Taxes
            dblStateTax = CalculateStateTax(dblGrossPay)

            'calculate Federal Tax
            dblFederalTax = CalculateFederalTax(dblGrossPay)

            'calculate Net Pay
            dblNetPay = CalculateNetPay(dblGrossPay, dblFICA, dblStateTax, dblFederalTax)

            'display outputs
            Display(dblNetPay, dblFICA, dblStateTax, dblFederalTax, dblGrossPay)
        End If

    End Sub
End Class