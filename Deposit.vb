Public Class Deposit




    Dim current_month As Double
    Dim HrPay As Double
    Dim Weekly_Hrs As Double


    Dim pay_style As Double
    Dim pay_style2 As String

    Dim extra_income As Double
    Dim month2 As String

    Dim Total_Pay As Double
    Dim Final_Pay As Double
    Private Sub Enable_Click(sender As Object, e As EventArgs) Handles Enable.Click
        Month.Enabled = True

    End Sub

    Private Sub Input1_Click(sender As Object, e As EventArgs) Handles Input1.Click
        ' Dim month As String = CStr(Me.Month.Text)
        month2 = Month.Text
        If Month.Text = "January" Or Month.Text = "january" Then
            current_month = 31
            Hr_Pay.Enabled = True

        ElseIf Month.Text = "February" Or Month.Text = "february" Then
            current_month = 28
            Hr_Pay.Enabled = True

        ElseIf Month.Text = "March" Or Month.Text = "march" Then
            current_month = 31
            Hr_Pay.Enabled = True

        ElseIf Month.Text = "April" Or Month.Text = "april" Then
            current_month = 30
            Hr_Pay.Enabled = True

        ElseIf Month.Text = "May" Or Month.Text = "may" Then
            current_month = 31
            Hr_Pay.Enabled = True

        ElseIf Month.Text = "June" Or Month.Text = "june" Then
            current_month = 30
            Hr_Pay.Enabled = True

        ElseIf Month.Text = "July" Or Month.Text = "july" Then
            current_month = 31
            Hr_Pay.Enabled = True

        ElseIf Month.Text = "August" Or Month.Text = "august" Then
            current_month = 31
            Hr_Pay.Enabled = True

        ElseIf Month.Text = "September" Or Month.Text = "september" Then
            current_month = 30
            Hr_Pay.Enabled = True

        ElseIf Month.Text = "October" Or Month.Text = "october" Then
            current_month = 31
            Hr_Pay.Enabled = True

        ElseIf Month.Text = "November" Or Month.Text = "november" Then
            current_month = 30
            Hr_Pay.Enabled = True

        ElseIf Month.Text = "December" Or Month.Text = "decemer" Then
            current_month = 31
            Hr_Pay.Enabled = True

        Else MsgBox("Not a valid Month")


        End If

    End Sub
    Private Sub Input2_Click(sender As Object, e As EventArgs) Handles Input2.Click

        Ttl_Hrs.Enabled = True


    End Sub
    Private Sub Input3_Click(sender As Object, e As EventArgs) Handles Input3.Click

        Type_Pay.Enabled = True

    End Sub

    Private Sub Input4_Click(sender As Object, e As EventArgs) Handles Input4.Click

        Extra.Enabled = True

    End Sub
    Private Sub Input5_Click(sender As Object, e As EventArgs) Handles Input5.Click
        Compute.Enabled = True

    End Sub

    Private Sub Compute_Click(sender As Object, e As EventArgs) Handles Compute.Click


        HrPay = Hr_Pay.Text
        Weekly_Hrs = Ttl_Hrs.Text
        extra_income = Extra.Text



        pay_style2 = Type_Pay.Text

        If Type_Pay.Text = "Weekly" Then
            pay_style = current_month / 7
            'Else MsgBox("Not a valid Month")
        End If

        If Type_Pay.Text = "Biweekly" Then
            pay_style = current_month / 14
        End If



        Total_Pay = (pay_style) * (Weekly_Hrs) * (HrPay) + (extra_income)

        Final_Count.Text = CStr(Math.Round(Total_Pay, 2))




    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Month_TextChanged(sender As Object, e As EventArgs) Handles Month.TextChanged

    End Sub

    Private Sub Hr_Pay_TextChanged(sender As Object, e As EventArgs) Handles Hr_Pay.TextChanged

    End Sub

    Private Sub Ttl_Hrs_TextChanged(sender As Object, e As EventArgs) Handles Ttl_Hrs.TextChanged


    End Sub

    Private Sub Type_Pay_TextChanged(sender As Object, e As EventArgs) Handles Type_Pay.TextChanged

    End Sub

    Private Sub Extra_TextChanged(sender As Object, e As EventArgs) Handles Extra.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Final_Count_TextChanged(sender As Object, e As EventArgs) Handles Final_Count.TextChanged

    End Sub


End Class
