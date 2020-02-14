Public Class Exercise4
    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click

        'Declare grade1 and grade2 as integers
        Dim grade1, grade2 As Integer

        'Declare avg as a Double since division could produce a decimal value
        Dim avg As Double

        'Cast input to Integers
        grade1 = CStr(txtGrade1.Text)
        grade2 = CStr(txtGrade2.Text)

        'Calculate the Average
        avg = (grade1 + grade2) / 2.0

        'Display the output to the textbox
        txtOut.Text = "The average is " & CStr(avg)

    End Sub
End Class
