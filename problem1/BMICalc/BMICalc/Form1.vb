Option Strict On

Public Class Form1

    Private Sub btnCalcBMI_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcBMI.Click
        Dim a, b As String
        a = txtWeight.Text
        b = txtHeight.Text

        Dim c, d As Double

        c = CDbl(a)
        d = CDbl(b)

        Dim BMI As Double

        BMI = (c * 703) / (d ^ 2)

        TextBox1.Text = CStr(BMI)
    End Sub
End Class
