Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Calculator
    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
    Private Sub Calculator_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Select Case e.KeyChar
            Case "0"c : btn0.PerformClick()
            Case "1"c : btn1.PerformClick()
            Case "2"c : btn2.PerformClick()
            Case "3"c : btn3.PerformClick()
            Case "4"c : btn4.PerformClick()
            Case "5"c : btn5.PerformClick()
            Case "6"c : btn6.PerformClick()
            Case "7"c : btn7.PerformClick()
            Case "8"c : btn8.PerformClick()
            Case "9"c : btn9.PerformClick()
            Case "+"c : btnplus.PerformClick()
            Case "-"c : btnminus.PerformClick()
            Case "*"c, "x"c : btnmultiply_Click(btnmultiply, EventArgs.Empty)
                e.Handled = True
            Case "/"c, "÷"c : btndivide_Click(btndivide, EventArgs.Empty)
                e.Handled = True
            Case "."c : btnpt.PerformClick()
            Case "="c, ChrW(13) : btnequal.PerformClick()
            Case "c"c : btnclear.PerformClick()
        End Select
        e.Handled = True
    End Sub
    Private Sub Calculator_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnequal.PerformClick()
                e.Handled = True
            Case Keys.Delete
                btnclear.PerformClick()
                e.Handled = True
            Case Keys.Back
                btndelete.PerformClick()
                e.Handled = True
        End Select
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        result.Text = result.Text + "1"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        result.Text = result.Text + "0"
    End Sub

    Private Sub btn00_Click(sender As Object, e As EventArgs) Handles btn00.Click
        result.Text = result.Text + "00"
    End Sub

    Private Sub btnpt_Click(sender As Object, e As EventArgs) Handles btnpt.Click
        result.Text = result.Text + "."
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        result.Text = result.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        result.Text = result.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        result.Text = result.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        result.Text = result.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        result.Text = result.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        result.Text = result.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        result.Text = result.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        result.Text = result.Text + "9"
    End Sub

    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        If result.Text.EndsWith(" ") Then
            result.Text = result.Text.Substring(0, result.Text.Length - 3)
        End If
        result.Text = result.Text + " + "
    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        If result.Text.EndsWith(" ") Then
            result.Text = result.Text.Substring(0, result.Text.Length - 3)
        End If
        result.Text = result.Text + " - "
    End Sub

    Private Sub btnmultiply_Click(sender As Object, e As EventArgs) Handles btnmultiply.Click
        If result.Text.EndsWith(" ") Then
            result.Text = result.Text.Substring(0, result.Text.Length - 3)
        End If
        result.Text = result.Text + " x "
    End Sub

    Private Sub btndivide_Click(sender As Object, e As EventArgs) Handles btndivide.Click
        If result.Text.EndsWith(" ") Then
            result.Text = result.Text.Substring(0, result.Text.Length - 3)
        End If
        result.Text = result.Text + " ÷ "
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        result.Text = ""
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If result.Text.Length = 0 Then Return
        If result.Text.Contains(Environment.NewLine) Then
            result.Text = ""
        Else
            If result.Text.EndsWith(" ") Then
            result.Text = result.Text.Substring(0, result.Text.Length - 3)
        Else
            result.Text = result.Text.Substring(0, result.Text.Length - 1)
        End If
        End If
    End Sub

    Private Sub btnequal_Click(sender As Object, e As EventArgs) Handles btnequal.Click
        If String.IsNullOrEmpty(result.Text) Then
            MessageBox.Show("Please enter a calculation")
            result.Text = ""
            Return
        End If
        If result.Text.EndsWith(" ") Then
            MessageBox.Show("Error")
            result.Text = ""
            Return
        End If
        Try
            Dim eqtvis As String = result.Text
            Dim eqtcal As String = result.Text
            eqtcal = eqtcal.Replace(" x ", " * ").Replace(" ÷ ", " / ")

            Dim dt As New DataTable()
            Dim answer As Object = dt.Compute(eqtcal, "")
            result.Text = eqtvis & Environment.NewLine & "= " & answer.ToString()
        Catch ex As Exception
            MessageBox.Show("Error")
            result.Text = ""
        End Try
    End Sub
End Class