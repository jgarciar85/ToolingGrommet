Public Class Keyboard

    Dim qtyLab As String = ""

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        qtyLab = qtyLab.ToString + btn1.Text
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        qtyLab = qtyLab.ToString + btn2.Text
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        qtyLab = qtyLab.ToString + btn3.Text
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        qtyLab = qtyLab.ToString + btn4.Text
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        qtyLab = qtyLab.ToString + btn5.Text
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        qtyLab = qtyLab.ToString + btn6.Text
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        qtyLab = qtyLab.ToString + btn7.Text
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        qtyLab = qtyLab.ToString + btn8.Text
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        qtyLab = qtyLab.ToString + btn9.Text
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        qtyLab = qtyLab.ToString + btn0.Text
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If lblFlag.Text = "txtLabDob" Then
            Reparar.txtLabDob.Text = qtyLab
        End If
        If lblFlag.Text = "txtPinesDob" Then
            Reparar.txtPinesDob.Text = qtyLab
        End If
        If lblFlag.Text = "txtPinesQueb" Then
            Reparar.txtPinesQueb.Text = qtyLab
        End If

        Me.Close()
    End Sub



    Private Sub Keyboard_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Close()

    End Sub
End Class