Public Class Splashscreen

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 3000 '3 seconds
        Timer1.Start()
    End Sub
End Class