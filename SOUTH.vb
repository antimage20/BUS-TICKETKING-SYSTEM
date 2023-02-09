Imports System.Drawing.Printing
Public Class SOUTH
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim ops As String
    Dim price As Double
    Dim SD1 As Double
    Dim SD2 As Double
    Dim SD3 As Double
    Dim SD4 As Double
    Dim SD5 As Double

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Print button code
        Dim kita As Double
        Dim earn As Double
        If lblNeed.Text <= 0 Then
            MsgBox("Bus Full Please Depart Now", MsgBoxStyle.Information, "Notification")
            btnDepart.Enabled = True

            btnConfirm.Enabled = False

        End If
        btnGenerate.Enabled = False
        kita = lblPrice.Text
        earn = Records.lblEarn.Text
        Records.lblEarn.Text = earn + kita
        Dashboard.lblEarn.Text = earn + kita
        Dashboard.lblTotal.Text += 1
        Records.lblTotal.Text += 1
        PPD.Document = PD
        PPD.ShowDialog()
        lbPassenger.Items.RemoveAt(0)
        Passengers_View_South.lbPassenger.Items.RemoveAt(0)
        btnPrint.Enabled = False
        rbTaguig.Checked = False
        rbMuntinlupa.Checked = False
        rbCalamba.Checked = False
        rbTagaytay.Checked = False
        rbBatangas.Checked = False
        lblPrice.Text = "0.00"
        Records.DataGridView1.Rows.Add(lblAdd.Text, Passengers_View_South.lblTicket.Text, Passengers_View_South.lblOrigin.Text, Passengers_View_South.lblDestination.Text, lblBusNo.Text, lblSeatnum.Text, DateAndTime.Now, Passengers_View_South.lblPrice2.Text)

    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        'Printed paper size
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 255)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        'Fonts and margin
        Dim f6 As New Font("Calibri", 6, FontStyle.Regular)
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'font allignment
        Dim right As New StringFormat
        Dim center As New StringFormat
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "---------------------------------------------------------------------------------"
        'Receipt
        e.Graphics.DrawString("E.M Station", f14, Brushes.Red, centermargin, 5, center)
        e.Graphics.DrawString("Avocado Street Pinalad Road Pasig City", f10, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("Cell No. +6380861453", f8, Brushes.Black, centermargin, 40, center)

        e.Graphics.DrawString("Date", f10, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f10, Brushes.Black, 29, 60)
        e.Graphics.DrawString(DateAndTime.Now, f10, Brushes.Black, 35, 60)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 75)

        e.Graphics.DrawString("Ticket No:", f10, Brushes.Black, 0, 85)
        e.Graphics.DrawString(Passengers_View_South.lblTicket.Text, f10, Brushes.Black, 61, 85)

        e.Graphics.DrawString("Bus No:", f10, Brushes.Black, 0, 100)
        e.Graphics.DrawString(lblBusNo.Text, f10, Brushes.Black, 49, 100)

        e.Graphics.DrawString("Origin:", f10, Brushes.Black, 0, 115)
        e.Graphics.DrawString("Pasig City Bus Station", f10, Brushes.Black, 43, 115)

        e.Graphics.DrawString("Destination:", f10, Brushes.Black, 0, 129)
        e.Graphics.DrawString(Passengers_View_South.lblDestination.Text, f10, Brushes.Black, 71, 129)

        e.Graphics.DrawString("Price:", f10, Brushes.Black, 0, 142)
        e.Graphics.DrawString("₱", f10, Brushes.Black, 35, 142)
        e.Graphics.DrawString(Passengers_View_South.lblPrice2.Text, f10, Brushes.Black, 45, 142)

        e.Graphics.DrawString("Seat Number:", f10, Brushes.Black, 0, 157)
        e.Graphics.DrawString(lblSeatnum.Text, f10, Brushes.Black, 79, 157)

        e.Graphics.DrawString("THANK YOU!", f14, Brushes.Red, centermargin, 200, center)
        e.Graphics.DrawString("Have a Safe Trip!", f10b, Brushes.Black, centermargin, 220, center)

        e.Graphics.DrawString("Please Show This Ticket To Bus Condutor To Pay", f6, Brushes.Black, centermargin, 180, center)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 240)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Login_Form.Show()
        Passengers_View_South.Hide()

    End Sub

    Private Sub btnNorth_Click(sender As Object, e As EventArgs) Handles btnNorth.Click
        Me.Hide()
        Form1.Show()
        Passengers_view.Show()
        Passengers_View_South.Hide()

    End Sub

    Private Sub rbMakati_CheckedChanged(sender As Object, e As EventArgs) Handles rbTaguig.CheckedChanged
        ops = "Route1"
    End Sub

    Private Sub rbMuntinlupa_CheckedChanged(sender As Object, e As EventArgs) Handles rbMuntinlupa.CheckedChanged
        ops = "Route2"
    End Sub

    Private Sub rbCalamba_CheckedChanged(sender As Object, e As EventArgs) Handles rbCalamba.CheckedChanged
        ops = "Route3"
    End Sub

    Private Sub rbTagaytay_CheckedChanged(sender As Object, e As EventArgs) Handles rbTagaytay.CheckedChanged
        ops = "Route4"
    End Sub

    Private Sub rbBatangas_CheckedChanged(sender As Object, e As EventArgs) Handles rbBatangas.CheckedChanged
        ops = "Route5"
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'Confirm Button code 
        If lbPassenger.Items.Count <= 0 Then
            lblPrice.Text = "0.00"
            MsgBox("No Ones Queueing", MsgBoxStyle.Information, "Notification")

        Else
            Passengers_View_South.lblNeed.Text = lblNeed.Text
            lblBusnum.Text = lblBusNo.Text
            lblAdd.Text = lbPassenger.Items(0)
            btnGenerate.Enabled = True
            price = Double.Parse(Admin.txtPrice.Text)
            SD1 = Double.Parse(Admin.txtSDistance1.Text)
            SD2 = Double.Parse(Admin.txtSDistance2.Text)
            SD3 = Double.Parse(Admin.txtSDistance3.Text)
            SD4 = Double.Parse(Admin.txtSDistance4.Text)
            SD5 = Double.Parse(Admin.txtSDistance5.Text)
            Select Case ops

                Case "Route1"
                    lblPrice.Text = (price * SD1)

                Case "Route2"
                    lblPrice.Text = (price * SD2)
                Case "Route3"
                    lblPrice.Text = (price * SD3)
                Case "Route4"
                    lblPrice.Text = (price * SD4)
                Case "Route5"
                    lblPrice.Text = (price * SD5)
            End Select
            Passengers_View_South.lblOrigin.Text = txtOrigin.Text
            Passengers_View_South.lblPrice2.Text = lblPrice.Text
            Passengers_View_South.lblTicket.Text = lblTicketno.Text
            Passengers_View_South.lblSeatnum.Text = lblSeatnum.Text
            Passengers_View_South.lblNeed.Text = lblNeed.Text
            Passengers_View_South.lblPrice.Text = lblPrice.Text
            Passengers_View_South.txtOrigin.Text = txtOrigin.Text
            If rbTaguig.Checked = True Then
                Passengers_View_South.txtDestination.Text = rbTaguig.Text
                Passengers_View_South.lblDestination.Text = Passengers_View_South.txtDestination.Text
            ElseIf rbMuntinlupa.Checked = True Then
                Passengers_View_South.txtDestination.Text = rbMuntinlupa.Text
                Passengers_View_South.lblDestination.Text = Passengers_View_South.txtDestination.Text
            ElseIf rbCalamba.Checked = True Then
                Passengers_View_South.txtDestination.Text = rbCalamba.Text
                Passengers_View_South.lblDestination.Text = Passengers_View_South.txtDestination.Text
            ElseIf rbTagaytay.Checked = True Then
                Passengers_View_South.txtDestination.Text = rbTagaytay.Text
                Passengers_View_South.lblDestination.Text = Passengers_View_South.txtDestination.Text
            ElseIf rbBatangas.Checked = True Then
                Passengers_View_South.txtDestination.Text = rbBatangas.Text
                Passengers_View_South.lblDestination.Text = Passengers_View_South.txtDestination.Text

            End If
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        'Ticket Number Code
        Static ticket As Integer
        ticket += 1

        lblTicketno.Text = ticket.ToString("STH-0000")
        Passengers_View_South.lblTicketno.Text = lblTicketno.Text
        Passengers_View_South.lblTicket.Text = lblTicketno.Text
        btnPrint.Enabled = True
        GroupBox1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Queueing System Code
        Static addqueue1 As Integer = 0
        Static addqueue2 As Integer = 0
        addqueue1 += 1
        addqueue2 += 1
        lbPassenger.Items.Add(String.Format(addqueue1.ToString("SH-0000")))
        Passengers_View_South.lbPassenger.Items.Add(String.Format(addqueue2.ToString("SH-0000")))
    End Sub

    Private Sub seat1_CheckedChanged(sender As Object, e As EventArgs) Handles seat1.CheckedChanged
        'Bus Seat Code 1-25 seats
        If seat1.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "1"
            Passengers_View_South.seat1.Checked = True
        Else
            Passengers_View_South.seat1.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat2_CheckedChanged(sender As Object, e As EventArgs) Handles seat2.CheckedChanged
        'Bus Seat Code
        If seat2.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "2"
            Passengers_View_South.seat2.Checked = True
        Else
            Passengers_View_South.seat2.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat3_CheckedChanged(sender As Object, e As EventArgs) Handles seat3.CheckedChanged
        'Bus Seat Code
        If seat3.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "3"
            Passengers_View_South.seat3.Checked = True
        Else
            Passengers_View_South.seat3.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat4_CheckedChanged(sender As Object, e As EventArgs) Handles seat4.CheckedChanged
        If seat4.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "4"
            Passengers_View_South.seat4.Checked = True
        Else
            Passengers_View_South.seat4.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat5_CheckedChanged(sender As Object, e As EventArgs) Handles seat5.CheckedChanged
        If seat5.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "5"
            Passengers_View_South.seat5.Checked = True
        Else
            Passengers_View_South.seat5.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat6_CheckedChanged(sender As Object, e As EventArgs) Handles seat6.CheckedChanged
        If seat6.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "6"
            Passengers_View_South.seat6.Checked = True
        Else
            Passengers_View_South.seat6.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat7_CheckedChanged(sender As Object, e As EventArgs) Handles seat7.CheckedChanged
        If seat7.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "7"
            Passengers_View_South.seat7.Checked = True
        Else
            Passengers_View_South.seat7.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat8_CheckedChanged(sender As Object, e As EventArgs) Handles seat8.CheckedChanged
        If seat8.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "8"
            Passengers_View_South.seat8.Checked = True
        Else
            Passengers_View_South.seat8.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat9_CheckedChanged(sender As Object, e As EventArgs) Handles seat9.CheckedChanged
        If seat9.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "9"
            Passengers_View_South.seat9.Checked = True
        Else
            Passengers_View_South.seat9.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat10_CheckedChanged(sender As Object, e As EventArgs) Handles seat10.CheckedChanged
        If seat10.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "10"
            Passengers_View_South.seat10.Checked = True
        Else
            Passengers_View_South.seat10.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat11_CheckedChanged(sender As Object, e As EventArgs) Handles seat11.CheckedChanged
        If seat11.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "11"
            Passengers_view.seat11.Checked = True
        Else
            Passengers_view.seat11.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat12_CheckedChanged(sender As Object, e As EventArgs) Handles seat12.CheckedChanged
        If seat12.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "12"
            Passengers_View_South.seat12.Checked = True
        Else
            Passengers_View_South.seat12.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat13_CheckedChanged(sender As Object, e As EventArgs) Handles seat13.CheckedChanged
        If seat13.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "13"
            Passengers_View_South.seat13.Checked = True
        Else
            Passengers_View_South.seat13.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat14_CheckedChanged(sender As Object, e As EventArgs) Handles seat14.CheckedChanged
        If seat14.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "14"
            Passengers_View_South.seat14.Checked = True
        Else
            Passengers_View_South.seat14.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat15_CheckedChanged(sender As Object, e As EventArgs) Handles seat15.CheckedChanged
        If seat15.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "15"
            Passengers_View_South.seat15.Checked = True
        Else
            Passengers_View_South.seat15.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat16_CheckedChanged(sender As Object, e As EventArgs) Handles seat16.CheckedChanged
        If seat16.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "16"
            Passengers_View_South.seat16.Checked = True
        Else
            Passengers_View_South.seat16.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat17_CheckedChanged(sender As Object, e As EventArgs) Handles seat17.CheckedChanged
        If seat17.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "17"
            Passengers_View_South.seat17.Checked = True
        Else
            Passengers_View_South.seat17.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat18_CheckedChanged(sender As Object, e As EventArgs) Handles seat18.CheckedChanged
        If seat18.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "18"
            Passengers_View_South.seat18.Checked = True
        Else
            Passengers_View_South.seat18.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat19_CheckedChanged(sender As Object, e As EventArgs) Handles seat19.CheckedChanged
        If seat19.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "19"
            Passengers_View_South.seat19.Checked = True
        Else
            Passengers_View_South.seat19.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat20_CheckedChanged(sender As Object, e As EventArgs) Handles seat20.CheckedChanged
        If seat20.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "20"
            Passengers_View_South.seat20.Checked = True
        Else
            Passengers_View_South.seat20.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat21_CheckedChanged(sender As Object, e As EventArgs) Handles seat21.CheckedChanged
        If seat21.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "21"
            Passengers_View_South.seat21.Checked = True
        Else
            Passengers_View_South.seat21.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat22_CheckedChanged(sender As Object, e As EventArgs) Handles seat22.CheckedChanged
        If seat22.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "22"
            Passengers_View_South.seat22.Checked = True
        Else
            Passengers_View_South.seat22.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat23_CheckedChanged(sender As Object, e As EventArgs) Handles seat23.CheckedChanged
        If seat23.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "23"
            Passengers_View_South.seat23.Checked = True
        Else
            Passengers_View_South.seat23.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat24_CheckedChanged(sender As Object, e As EventArgs) Handles seat24.CheckedChanged
        If seat24.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "24"
            Passengers_View_South.seat24.Checked = True
        Else
            Passengers_View_South.seat24.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat25_CheckedChanged(sender As Object, e As EventArgs) Handles seat25.CheckedChanged
        If seat25.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "25"
            Passengers_View_South.seat25.Checked = True
        Else
            Passengers_View_South.seat25.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        'Record Button

        Records.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Admin.Show()
    End Sub

    Private Sub btnDepart_Click(sender As Object, e As EventArgs) Handles btnDepart.Click
        'Code for Depart Button 
        MsgBox("Bus Departed", MsgBoxStyle.Information, "Notification")
        Admin.lblBuscount.Text -= 1
        btnConfirm.Enabled = True
        btnDepart.Enabled = False
        lblBusNo.Text += 2
        Passengers_View_South.lblBusNo.Text += 2
        Passengers_View_South.lblNeed.Text = "25"
        lblNeed.Text = "0"
        seat1.Checked = False
        seat2.Checked = False
        seat3.Checked = False
        seat4.Checked = False
        seat5.Checked = False
        seat6.Checked = False
        seat7.Checked = False
        seat8.Checked = False
        seat9.Checked = False
        seat10.Checked = False
        seat11.Checked = False
        seat12.Checked = False
        seat13.Checked = False
        seat14.Checked = False
        seat15.Checked = False
        seat16.Checked = False
        seat17.Checked = False
        seat18.Checked = False
        seat19.Checked = False
        seat20.Checked = False
        seat21.Checked = False
        seat22.Checked = False
        seat23.Checked = False
        seat24.Checked = False
        seat25.Checked = False
        lblSeatnum.Text = "0"
        lblPrice.Text = "0.00"
        lblTicketno.Text = "STH-0000"
        Records.DataGridView2.Rows.Add(lblBusnum.Text, DateAndTime.Now)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Time Code
        Dim HH As Integer = DateTime.Now.Hour
        Dim MM As Integer = DateTime.Now.Minute
        Dim SS As Integer = DateTime.Now.Second
        Dim Time As String = ""
        'Time
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



    Private Sub SOUTH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Interval = 25
        Timer2.Start()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dashboard.Show()
        Dashboard.lblDate.Text = DateAndTime.Now
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Passengers_View_South.txtDestination.Clear()
        Passengers_View_South.lblPrice.Text = "0.00"
        rbTagaytay.Checked = False
        rbTaguig.Checked = False
        rbMuntinlupa.Checked = False
        rbCalamba.Checked = False
        rbBatangas.Checked = False
        lblPrice.Text = "0.00"
    End Sub
End Class