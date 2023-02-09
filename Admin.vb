Public Class Admin




    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnNup2.Click
        Form1.rbManila.Text = txtNRoute2.Text
        Passengers_view.lblManila.Text = txtNRoute2.Text
        Passengers_View_South.lblManila.Text = txtSRoute2.Text
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnNupd.Click
        Form1.rbMakati.Text = txtNRoute1.Text
        Passengers_view.lblMakati.Text = txtNRoute1.Text
        Passengers_View_South.lblMakati.Text = txtNRoute1.Text

    End Sub

    Private Sub btnNup3_Click(sender As Object, e As EventArgs) Handles btnNup3.Click
        Form1.rbQuezon.Text = txtNRoute3.Text
        Passengers_view.lblQuezon.Text = txtNRoute3.Text
        Passengers_View_South.lblQuezon.Text = txtNRoute3.Text
    End Sub

    Private Sub btnNup4_Click(sender As Object, e As EventArgs) Handles btnNup4.Click
        Form1.rbCaloocan.Text = txtNRoute4.Text
        Passengers_view.lblCaloocan.Text = txtNRoute4.Text
        Passengers_View_South.lblCaloocan.Text = txtNRoute4.Text
    End Sub

    Private Sub btnNup5_Click(sender As Object, e As EventArgs) Handles btnNup5.Click
        Form1.rbBulacan.Text = txtNroute5.Text
        Passengers_view.lblBulacan.Text = txtNroute5.Text
        Passengers_View_South.lblBulacan.Text = txtNroute5.Text
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
    End Sub

    Private Sub btnUpd6_Click(sender As Object, e As EventArgs) Handles btnUpd6.Click
        SOUTH.rbTaguig.Text = txtSRoute1.Text
        Passengers_View_South.lblTaguig.Text = txtSRoute1.Text
        Passengers_view.lblTAguig.Text = txtSRoute1.Text
    End Sub

    Private Sub btnUpd7_Click(sender As Object, e As EventArgs) Handles btnUpd7.Click
        SOUTH.rbMuntinlupa.Text = txtSRoute2.Text
        Passengers_View_South.lblMuntinlupa.Text = txtSRoute2.Text
        Passengers_view.lblMuntinlupa.Text = txtSRoute2.Text
    End Sub

    Private Sub btnUpd8_Click(sender As Object, e As EventArgs) Handles btnUpd8.Click
        SOUTH.rbCalamba.Text = txtSRoute3.Text
        Passengers_View_South.lblCalamba.Text = txtSRoute3.Text
        Passengers_view.lblCalamba.Text = txtSRoute3.Text
    End Sub

    Private Sub btnUpd9_Click(sender As Object, e As EventArgs) Handles btnUpd9.Click
        SOUTH.rbTagaytay.Text = txtSRoute4.Text
        Passengers_View_South.lbltagaytay.Text = txtSRoute4.Text
        Passengers_view.lblTagaytay.Text = txtSRoute4.Text
    End Sub

    Private Sub btnUpd10_Click(sender As Object, e As EventArgs) Handles btnUpd10.Click
        SOUTH.rbBatangas.Text = txtSRoute5.Text
        Passengers_View_South.lblBatangas.Text = txtSRoute5.Text
        Passengers_view.lblBatangas.Text = txtSRoute5.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dashboard.lblBusnum.Text += 1
        lblBuscount.Text += 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lblBuscount.Text -= 1
        Dashboard.lblBusnum.Text -= 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.txtOrigin.Text = txtStation.Text
        SOUTH.txtOrigin.Text = txtStation.Text
        Passengers_view.txtOrigin.Text = txtStation.Text
        Passengers_View_South.txtOrigin.Text = txtStation.Text
    End Sub



    Private Sub txtDistance1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDistance1.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            Else
                e.Handled = True
                MsgBox("Numbers Only")
            End If
        End If

    End Sub



    Private Sub txtDistance2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDistance2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            Else
                e.Handled = True
                MsgBox("Numbers Only")
            End If
        End If
    End Sub



    Private Sub txtDistance3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDistance3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            Else
                e.Handled = True
                MsgBox("Numbers Only")
            End If
        End If
    End Sub



    Private Sub txtDistance4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDistance4.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            Else
                e.Handled = True
                MsgBox("Numbers Only")
            End If
        End If
    End Sub



    Private Sub txtDistance5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDistance5.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            Else
                e.Handled = True
                MsgBox("Numbers Only")
            End If
        End If
    End Sub



    Private Sub txtSDistance1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSDistance1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            Else
                e.Handled = True
                MsgBox("Numbers Only")
            End If
        End If
    End Sub



    Private Sub txtSDistance2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSDistance2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            Else
                e.Handled = True
                MsgBox("Numbers Only")
            End If
        End If
    End Sub



    Private Sub txtSDistance3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSDistance3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            Else
                e.Handled = True
                MsgBox("Numbers Only")
            End If
        End If
    End Sub



    Private Sub txtSDistance4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSDistance4.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            Else
                e.Handled = True
                MsgBox("Numbers Only")
            End If
        End If
    End Sub



    Private Sub txtSDistance5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSDistance5.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            Else
                e.Handled = True
                MsgBox("Numbers Only")
            End If
        End If
    End Sub



    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            Else
                e.Handled = True
                MsgBox("Numbers Only")
            End If
        End If
    End Sub


End Class