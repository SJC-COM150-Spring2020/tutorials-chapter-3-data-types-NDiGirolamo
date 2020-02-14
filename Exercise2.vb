Public Class Exercise2
    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click

        'Declare base and height as Integers
        Dim base, height As Integer

        'Declare area as Double since division could produce a decimal value
        Dim area As Double

        'Cast value in both Textboxes to Integers
        base = CInt(txtBase.Text)
        height = CInt(txtHeight.Text)

        'Calculate the area
        area = (base * height) / 2

        'Display results in a Textbox
        txtOut.Text = "The area of a triangle with base of " & CStr(base) & " inches and a height of " & CStr(height) & " inches is " & CStr(area)


    End Sub
End Class