Public Class FormTimer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelName.Click

    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        If ButtonStart.Text = "START" Then
            ButtonStart.Text = "STOP"
            ButtonStart.BackColor = Color.Firebrick
            Timer.Enabled = True
        ElseIf ButtonStart.Text = "STOP" Then
            ButtonStart.Text = "START"
            ButtonStart.BackColor = Color.SpringGreen
            Timer.Enabled = False
            LabelNumber.Text = 0
            ButtonA.BackColor = Color.Crimson
            ButtonB.BackColor = Color.Crimson
            ButtonC.BackColor = Color.Crimson
            ButtonD.BackColor = Color.Crimson
            ButtonE.BackColor = Color.Crimson
            ButtonF.BackColor = Color.Crimson
            ButtonG.BackColor = Color.LightGray

        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If LabelNumber.Text < 9 Then
            LabelNumber.Text = Val(LabelNumber.Text) + 1
        ElseIf LabelNumber.Text = 9 Then
            LabelNumber.Text = 0
            Timer.Enabled = False
            ButtonStart.Text = "START"
            ButtonStart.BackColor = Color.SpringGreen
        End If

        Select Case Val(LabelNumber.Text)
            Case 0
                ButtonA.BackColor = Color.Crimson
                ButtonB.BackColor = Color.Crimson
                ButtonC.BackColor = Color.Crimson
                ButtonD.BackColor = Color.Crimson
                ButtonE.BackColor = Color.Crimson
                ButtonF.BackColor = Color.Crimson
                ButtonG.BackColor = Color.LightGray
            Case 1
                ButtonA.BackColor = Color.Crimson
                ButtonB.BackColor = Color.Crimson
                ButtonC.BackColor = Color.LightGray
                ButtonD.BackColor = Color.LightGray
                ButtonE.BackColor = Color.LightGray
                ButtonF.BackColor = Color.LightGray
                ButtonG.BackColor = Color.LightGray
            Case 2
                ButtonA.BackColor = Color.Crimson
                ButtonB.BackColor = Color.LightGray
                ButtonC.BackColor = Color.Crimson
                ButtonD.BackColor = Color.Crimson
                ButtonE.BackColor = Color.LightGray
                ButtonF.BackColor = Color.Crimson
                ButtonG.BackColor = Color.Crimson
            Case 3
                ButtonA.BackColor = Color.Crimson
                ButtonB.BackColor = Color.Crimson
                ButtonC.BackColor = Color.Crimson
                ButtonD.BackColor = Color.LightGray
                ButtonE.BackColor = Color.LightGray
                ButtonF.BackColor = Color.Crimson
                ButtonG.BackColor = Color.Crimson
            Case 4
                ButtonA.BackColor = Color.Crimson
                ButtonB.BackColor = Color.Crimson
                ButtonC.BackColor = Color.LightGray
                ButtonD.BackColor = Color.LightGray
                ButtonE.BackColor = Color.Crimson
                ButtonF.BackColor = Color.LightGray
                ButtonG.BackColor = Color.Crimson
            Case 5
                ButtonA.BackColor = Color.LightGray
                ButtonB.BackColor = Color.Crimson
                ButtonC.BackColor = Color.Crimson
                ButtonD.BackColor = Color.LightGray
                ButtonE.BackColor = Color.Crimson
                ButtonF.BackColor = Color.Crimson
                ButtonG.BackColor = Color.Crimson
            Case 6
                ButtonA.BackColor = Color.LightGray
                ButtonB.BackColor = Color.Crimson
                ButtonC.BackColor = Color.Crimson
                ButtonD.BackColor = Color.Crimson
                ButtonE.BackColor = Color.Crimson
                ButtonF.BackColor = Color.Crimson
                ButtonG.BackColor = Color.Crimson
            Case 7
                ButtonA.BackColor = Color.Crimson
                ButtonB.BackColor = Color.Crimson
                ButtonC.BackColor = Color.LightGray
                ButtonD.BackColor = Color.LightGray
                ButtonE.BackColor = Color.Crimson
                ButtonF.BackColor = Color.Crimson
                ButtonG.BackColor = Color.LightGray
            Case 8
                ButtonA.BackColor = Color.Crimson
                ButtonB.BackColor = Color.Crimson
                ButtonC.BackColor = Color.Crimson
                ButtonD.BackColor = Color.Crimson
                ButtonE.BackColor = Color.Crimson
                ButtonF.BackColor = Color.Crimson
                ButtonG.BackColor = Color.Crimson
            Case 9
                ButtonA.BackColor = Color.Crimson
                ButtonB.BackColor = Color.Crimson
                ButtonC.BackColor = Color.Crimson
                ButtonD.BackColor = Color.LightGray
                ButtonE.BackColor = Color.Crimson
                ButtonF.BackColor = Color.Crimson
                ButtonG.BackColor = Color.Crimson

        End Select

    End Sub

    Private Sub LabelNumber_Click(sender As Object, e As EventArgs) Handles LabelNumber.Click

    End Sub
End Class
