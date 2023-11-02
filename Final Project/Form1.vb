' **************************************************************************************
' Anastasiia Efimova
' Final Project
' 04/27/2021
' **************************************************************************************

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'closes program
        Close()

    End Sub

    Private Sub btnSalariedEmployee_Click(sender As Object, e As EventArgs) Handles btnSalariedEmployee.Click

        'create new instance of frmSalariedEmlpoyeed
        Dim SalariedEmployee As New frmSalariedEmployee

        'show the Salaried Employeed Form
        SalariedEmployee.ShowDialog()

    End Sub

    Private Sub btnHouryEmployees_Click(sender As Object, e As EventArgs) Handles btnHouryEmployees.Click

        'create new instance of frmHourlyEmlpoyeed
        Dim HourlyEmployee As New frmHourlyEmployee

        'show the Hourly Employeed Form
        HourlyEmployee.ShowDialog()

    End Sub
End Class
