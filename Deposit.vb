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


    Private Sub Compute_Click(sender As Object, e As EventArgs) Handles Compute.Click

        ' Dim month As String = CStr(Me.Month.Text)
        month2 = Month.Text
        If Month.Text = "January" Then
            current_month = 31


        ElseIf Month.Text = "February" Then
            current_month = 28

        ElseIf Month.Text = "March" Then
            current_month = 31

        ElseIf Month.Text = "April" Then
            current_month = 30

        ElseIf Month.Text = "May" Then
            current_month = 31

        ElseIf Month.Text = "June" Then
            current_month = 30

        ElseIf Month.Text = "July" Then
            current_month = 31

        ElseIf Month.Text = "August" Then
            current_month = 31

        ElseIf Month.Text = "September" Then
            current_month = 30

        ElseIf Month.Text = "October" Then
            current_month = 31

        ElseIf Month.Text = "November" Then
            current_month = 30

        ElseIf Month.Text = "December" Then
            current_month = 31

        Else MsgBox("Not a valid Month")


        End If


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
        Final_Pay = Math.Round(Total_Pay, 3, MidpointRounding.AwayFromZero)

        Final_Count.Text = CStr(Final_Pay)




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
