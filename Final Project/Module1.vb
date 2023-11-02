Module Module1
    Function CalculateFederalTax(ByVal GrossPay As Double) As Double

        'cretae variable for Federal Tax
        Dim dblFederalTax As Double

        'create Const for Federal Taxes
        Const dblIncomeTax1 As Double = 0.1
        Const dblIncomeTax15 As Double = 0.15
        Const dblIncomeTax20 As Double = 0.2
        Const dblIncomeTax25 As Double = 0.25

        'do calculations
        If GrossPay < 50 Then
            dblFederalTax = 0
        ElseIf GrossPay < 500 Then
            dblFederalTax = GrossPay * dblIncomeTax1
        ElseIf GrossPay < 2500 Then
            dblFederalTax = GrossPay * dblIncomeTax15 + 45
        ElseIf GrossPay < 5000 Then
            dblFederalTax = GrossPay * dblIncomeTax20 + 345
        Else
            dblFederalTax = GrossPay * dblIncomeTax25 + 845
        End If

        'return Federal Tax value
        Return dblFederalTax

    End Function

    Function CalculateNetPay(ByVal GrossPay As Double, ByVal FICA As Double, ByVal StateTax As Double, ByVal FederalTax As Double) As Double

        'create validation for Net Pay
        Dim dblNetPay As Double

        'do calculation
        dblNetPay = GrossPay - FICA - StateTax - FederalTax

        'return Net Pay value
        Return dblNetPay

    End Function

End Module
