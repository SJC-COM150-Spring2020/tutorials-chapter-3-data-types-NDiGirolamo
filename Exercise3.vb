Public Class Exercise3
    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click

        'Declare the Radius as Integer
        Dim radius As Integer

        'Declare PI as a Contstant
        Const PI As Double = 3.14159

        'Declare area as a double since division could produce a decimal value
        Dim area As Double

        'Cast value in Textbox to Integer
        radius = CStr(txtRadius.Text)

        'Calculate the area
        area = PI * radius ^ 2

        'Display the results in a textbox
        txtOut.Text = "The area of a circle with a radius of " & CStr(radius) & " inches is " & CStr(area) & " inches."

    End Sub

    Private Sub txtOut_TextChanged(sender As Object, e As EventArgs) Handles txtOut.TextChanged

    End Sub
End Class
