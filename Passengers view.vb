Public Class Passengers_view
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Passengers View
        Dim HH As Integer = DateTime.Now.Hour
        Dim MM As Integer = DateTime.Now.Minute
        Dim SS As Integer = DateTime.Now.Second
        Dim Time As String = ""

        If (HH < 10) Then
            Time &= "0" + HH
        Else
            Time &= HH
        End If
        Time &= ":"

        If (MM < 10) Then
            Time &= "0" + MM
        Else
            Time &= MM
        End If
        Time &= ":"

        If (SS < 10) Then
            Time &= "0" + SS
        Else
            Time &= SS
        End If

        lblTime.Text = Time
    End Sub

    Private Sub Passengers_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub






End Class