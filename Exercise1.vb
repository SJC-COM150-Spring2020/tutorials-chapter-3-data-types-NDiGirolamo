Public Class Exercise1
    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click

        'Declare side and area as Integers
        Dim side, area As Integer

        'Cast value in TextBox to an Integer
        side = CInt(txtIn.Text)


        'Calculate the Area
        area = side ^ 2

        'Display the Results in a Textbox
        txtOut.Text = "The area of square with a length of " & CStr(side) & " feet is " & CStr(area) & " square feet."

    End Sub
End Class
