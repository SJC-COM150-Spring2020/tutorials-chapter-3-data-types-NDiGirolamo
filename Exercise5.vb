Public Class Exercise5
    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click

        'Declare side and area as Integers
        Dim side, area As Integer

        'Create Input box and cast to an Integer
        side = CInt(InputBox("Enter the side of a square"))


        'Calculate the Area
        area = side ^ 2

        'Display the result to a textbox
        txtOut.Text = "The area of this square is " & CStr(area)

    End Sub
End Class
