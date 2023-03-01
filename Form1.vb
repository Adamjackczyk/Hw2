Public Class Form1
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub BtnComputeTaxes_Click(sender As Object, e As EventArgs) Handles BtnComputeTaxes.Click
        Dim strIncome As String
        Dim decIncome As Decimal
        Dim decFica As Decimal
        Dim decFederal As Decimal
        Dim decState As Decimal
        Dim decNet As Decimal

        Const _cdecFica = 0.0765D
        Const _cdecFed = 0.22D
        Const _cdecState = 0.04D

        strIncome = TxtGrossPay.Text

        If IsNumeric(TxtGrossPay.Text) Then
            decIncome = CDec(strIncome.ToString)
            If decIncome > 0 Then
                decNet = (decIncome * _cdecFica) + (decIncome * _cdecFed) + (decIncome * _cdecState)
                decNet -= decIncome
                decNet *= -1
                LblNetPayShow.Text = decNet.ToString("C")
            Else
                MsgBox("Enter a possative number.")
            End If

        Else
            MsgBox("Enter a number.")
        End If

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtGrossPay.Clear()
        LblNetPayShow.Text = " "
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
    End Sub
End Class
