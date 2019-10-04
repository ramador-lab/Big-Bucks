Public Class Form1
    Private Sub Compute_Click(sender As Object, e As EventArgs) Handles Compute.Click

        Dim Month As String = CStr(TextBox1.Text)




        Dim aNumber As Double = (TextBox7.Text)
        Dim bNumber As Double = (TextBox2.Text)
        Dim Total As Double = (MultiplyNumbers(aNumber, bNumber))
        Dim stringTotal As String
        stringTotal = CStr(Total)

        stringTotal = (TextBox5.Text)


        ' Val(Total)
        'Me.Income.Series("Income").Points.AddXY(Month, Total)



    End Sub
    Function MultiplyNumbers(ByVal N1 As Double, ByVal N2 As Double) _
 As Integer
        Return N1 * N2
    End Function

    Private Sub Income_Click(sender As Object, e As EventArgs) Handles Income.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class

////////// Separte Code ///////////////////////////////////////////////////////////////////////////////////////

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Month As String = TextBox1.Text
        Dim Income As Integer = TextBox2.Text



        Me.Chart1.Series("Income").Points.AddXY(Month, Income)




    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox1 Then

                Control.Text = String.Empty

            End If



        Next
    End Sub




