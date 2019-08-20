Public Class Form1
    Dim number1 As Integer
    Dim number2 As Integer
    Dim multiplier As Integer

    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        lbxList.Items.Clear()

        number1 = Val(txtNumOne.Text)
        number2 = Val(txtNumTwo.Text)
        multiplier = Val(txtMultiplier.Text)

        For n = number1 To number2
            lbxList.Items.Add(n & " x " & multiplier & " = " & n * multiplier)
        Next
    End Sub
End Class
