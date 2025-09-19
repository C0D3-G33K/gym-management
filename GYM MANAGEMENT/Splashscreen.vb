Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Splashscreen

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If prgLoad.Value < prgLoad.Maximum Then
            prgLoad.Value += 25
            lblPercentage.Text = prgLoad.Value.ToString() & "%"
        Else
            ' Timer1.Stop()
            Timer1.Enabled = False ' Stop the timer

            ' Show your login form
            Login.Show()
            ' Hide the splash screen
            Me.Hide()
        End If


    End Sub

    Private Sub Splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 3000 '3 seconds
        Timer1.Start()
    End Sub
End Class