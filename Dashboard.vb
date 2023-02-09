Public Class Dashboard
    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles lblDate.Click
        lblDate.Text = DateAndTime.Now
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class