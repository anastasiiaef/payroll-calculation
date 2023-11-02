' **************************************************************************************
' Anastasiia Efimova
' Final Project
' 04/27/2021
' **************************************************************************************

Public Class frmHourlyEmployee

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'close the program
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear out the controlls
        txtLastName.Clear()
        txtFirstName.Clear()
        txtHourlyWage.Clear()
        txtHoursWorked.Clear()

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
        Dim dblHourlyWage As Double
        Dim dblHoursWorked As Double

        'set text box back to white in case they are yellow
        txtLastName.BackColor = Color.White
        txtFirstName.BackColor = Color.White
        txtHourlyWage.BackColor = Color.White
        txtHoursWorked.BackColor = Color.White


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
        If ValidInput(dblHourlyWage, dblHoursWorked) = True Then

            'do calculation
            'calculate Gross Pay
            dblGrossPay = CalculateGrossPay(dblHourlyWage, dblHoursWorked)

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

    Function ValidInput(ByRef HourlyWage As Double, ByRef HoursWorked As Double) As Boolean

        If ValidHourlyWage(HourlyWage) = True Then
            If ValidRangHourlyWage(HourlyWage) = True Then
                If ValidHoursWorked(HoursWorked) = True Then
                    If ValidRangHoursWorked(HoursWorked) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function

    Function ValidHourlyWage(ByRef HourlyWage As Double) As Boolean

        'validation for Yearly Salary
        If IsNumeric(txtHourlyWage.Text) Then
            HourlyWage = txtHourlyWage.Text
            Return True
        Else
            MessageBox.Show("Please enter Hourly Wage")
            txtHourlyWage.BackColor = Color.Yellow
            txtHourlyWage.Focus()
            Return False
        End If

    End Function

    Function ValidRangHourlyWage(ByRef HourlyWage As Double) As Boolean

        'range validation for Yearly Salary
        If HourlyWage < 0 Then
            MessageBox.Show("Please enter posetive numbers only for Hourly Wage")
            txtHourlyWage.BackColor = Color.Yellow
            txtHourlyWage.Focus()
            Return False
        End If

        Return HourlyWage

    End Function

    Function ValidHoursWorked(ByRef HoursWorked As Double) As Boolean

        'validation for Yearly Salary
        If IsNumeric(txtHoursWorked.Text) Then
            HoursWorked = txtHoursWorked.Text
            Return True
        Else
            MessageBox.Show("Please enter Hours Worked")
            txtHoursWorked.BackColor = Color.Yellow
            txtHoursWorked.Focus()
            Return False
        End If

    End Function

    Function ValidRangHoursWorked(ByRef HoursWorked As Double) As Boolean

        'range validation for Yearly Salary
        If HoursWorked < 0 Then
            MessageBox.Show("Please enter posetive numbers only for Hours Worked")
            txtHoursWorked.BackColor = Color.Yellow
            txtHoursWorked.Focus()
            Return False
        End If

        Return HoursWorked

    End Function

    Function CalculateGrossPay(ByRef HourlyWage As Double, ByRef HoursWorked As Double) As Double

        'create variable for GrossPay
        Dim dblGrossPay As Double

        'calculate Gross pay
        If HoursWorked > 40 Then
            dblGrossPay = HourlyWage * 40 + HourlyWage * 1.5 * (HoursWorked - 40)
        Else
            dblGrossPay = HourlyWage * HoursWorked
        End If

        'return Gross Pay value
        Return dblGrossPay

    End Function

    Function CalculateFICA(ByVal GrossPay As Double) As Double

        'create const for FICA rate
        Const dblFICARate As Double = 0.0145

        'create variable for FICA
        Dim dblFICA As Double

        'do calculation
        dblFICA = GrossPay * dblFICARate

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

        'return State Tax value
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
        txtFirstName.Clear()
        txtHourlyWage.Clear()
        txtHoursWorked.Clear()

        'put focus on First Name text box
        txtFirstName.Focus()

        'set the radOhio button back to default
        radOhio.Checked = True

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        'closes program
        Close()

    End Sub

    Private Sub SubmitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubmitToolStripMenuItem.Click

        'create a local variables
        Dim dblNetPay As Double
        Dim dblFICA As Double
        Dim dblStateTax As Double
        Dim dblFederalTax As Double
        Dim dblGrossPay As Double
        Dim dblHourlyWage As Double
        Dim dblHoursWorked As Double

        'set text box back to white in case they are yellow
        txtLastName.BackColor = Color.White
        txtFirstName.BackColor = Color.White
        txtHourlyWage.BackColor = Color.White
        txtHoursWorked.BackColor = Color.White


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
        If ValidInput(dblHourlyWage, dblHoursWorked) = True Then

            'do calculation
            'calculate Gross Pay
            dblGrossPay = CalculateGrossPay(dblHourlyWage, dblHoursWorked)

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