Public Class Form1

    Dim hours As Integer
    Dim minutes As Integer
    Dim seconds As Integer
    Dim time As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        hours = Int(TextBox1.Text)
        minutes = Int(TextBox2.Text)
        seconds = Int(TextBox3.Text)
        Label1.Text = CStr(hours) + ":" + CStr(minutes) + ":" + CStr(seconds)

        time = (hours * 3600) + (minutes * 60) + seconds
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time = time - 1
        If (time <= 0) Then
            Timer1.Stop()
            My.Computer.Audio.Play("C:\Users\Arya\Desktop\Timer App\aesthetic.wav")
            MsgBox("TIMER FINISHED")
        End If



        seconds = seconds - 1
        If seconds = -1 Then
            seconds = 59
            minutes = minutes - 1
        End If

        If minutes = -1 Then
            minutes = 59
            hours = hours - 1
        End If

        Label1.Text = CStr(hours) + ":" + CStr(minutes) + ":" + CStr(seconds)
    End Sub
End Class
