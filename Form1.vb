Imports System.Security.Cryptography
Imports System.Drawing.Printing
Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    'Ticketing System
    Dim ops As String
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim price As Double
    Dim ND1 As Double
    Dim ND2 As Double
    Dim ND3 As Double
    Dim ND4 As Double
    Dim ND5 As Double

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Passengers_view.Show()
        Timer1.Start()
        BusMove.Interval = 25
        BusMove.Start()

    End Sub



    Private Sub BusMove_Tick(sender As Object, e As EventArgs) Handles BusMove.Tick

    End Sub



    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Print button
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
        lbPassenger.Items.RemoveAt(0)
        Passengers_view.lbPassenger.Items.RemoveAt(0)
        btnPrint.Enabled = False
        PPD.Document = PD
        PPD.ShowDialog()
        rbMakati.Checked = False
        rbManila.Checked = False
        rbQuezon.Checked = False
        rbCaloocan.Checked = False
        rbBulacan.Checked = False
        GroupBox1.Enabled = False
        Passengers_view.lblPrice.Text = "0.00"
        lblPrice.Text = "0.00"
        Passengers_view.txtDestination.Clear()
        Passengers_view.txtOrigin.Clear()
        Records.DataGridView1.Rows.Add(lblAdd.Text, Passengers_view.lblTicket.Text, Passengers_view.lblOrigin.Text, Passengers_view.lblDestination.Text, lblBusNo.Text, lblSeatnum.Text, DateAndTime.Now, Passengers_view.lblPrice2.Text)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Queueing System
        Static addqueue1 As Integer = 0
        Static addqueue2 As Integer = 0
        addqueue1 += 1
        addqueue2 += 1
        lbPassenger.Items.Add(String.Format(addqueue1.ToString("NH-0000")))
        Passengers_view.lbPassenger.Items.Add(String.Format(addqueue2.ToString("NH-0000")))


    End Sub


    Private Sub btnNxt_Click(sender As Object, e As EventArgs)
        'Next Bus Button
        Passengers_view.lblNeed.Text = "30"
        Passengers_view.lblBusNo.Text = lblBusNo.Text
        lblBusNo.Text += 1
        lblNeed.Text = "30"


        If lblBusNo.Text = 10 Then
            MsgBox("Maximum Bus Has Been Reach", MsgBoxStyle.Information, "Notification")

        End If
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
        e.Graphics.DrawString(Passengers_view.lblTicket.Text, f10, Brushes.Black, 61, 85)

        e.Graphics.DrawString("Bus No:", f10, Brushes.Black, 0, 100)
        e.Graphics.DrawString(lblBusNo.Text, f10, Brushes.Black, 49, 100)

        e.Graphics.DrawString("Origin:", f10, Brushes.Black, 0, 115)
        e.Graphics.DrawString(Passengers_view.lblOrigin.Text, f10, Brushes.Black, 43, 115)

        e.Graphics.DrawString("Destination:", f10, Brushes.Black, 0, 129)
        e.Graphics.DrawString(Passengers_view.lblDestination.Text, f10, Brushes.Black, 71, 129)

        e.Graphics.DrawString("Price:", f10, Brushes.Black, 0, 142)
        e.Graphics.DrawString("₱", f10, Brushes.Black, 35, 142)
        e.Graphics.DrawString(Passengers_view.lblPrice2.Text, f10, Brushes.Black, 45, 142)

        e.Graphics.DrawString("Seat Number:", f10, Brushes.Black, 0, 157)
        e.Graphics.DrawString(lblSeatnum.Text, f10, Brushes.Black, 79, 157)

        e.Graphics.DrawString("THANK YOU!", f14, Brushes.Red, centermargin, 200, center)
        e.Graphics.DrawString("Have a Safe Trip!", f10b, Brushes.Black, centermargin, 220, center)

        e.Graphics.DrawString("Please Show This Ticket To Bus Condutor To Pay", f6, Brushes.Black, centermargin, 180, center)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 240)

    End Sub



    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        'Back Button
        Me.Hide()
        Passengers_view.Hide()
        Login_Form.Show()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        'Record Button
        Records.Show()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbMakati.CheckedChanged
        'Routes from 1-5
        ops = "Route1"
    End Sub

    Private Sub rbManila_CheckedChanged(sender As Object, e As EventArgs) Handles rbManila.CheckedChanged
        ops = "Route2"
    End Sub

    Private Sub rbQuezon_CheckedChanged(sender As Object, e As EventArgs) Handles rbQuezon.CheckedChanged
        ops = "Route3"
    End Sub

    Private Sub rbCaloocan_CheckedChanged(sender As Object, e As EventArgs) Handles rbCaloocan.CheckedChanged
        ops = "Route4"
    End Sub

    Private Sub rbBulacan_CheckedChanged(sender As Object, e As EventArgs) Handles rbBulacan.CheckedChanged
        ops = "Route5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Admin.Show()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'Confrim Button
        If lbPassenger.Items.Count <= 0 Then
            lblPrice.Text = "0.00"
            MsgBox("No Ones Queueing", MsgBoxStyle.Information, "Notification")

        Else
            lblPrice2.Text = lblPrice.Text
            lblBusnum.Text = lblBusNo.Text
            lblAdd.Text = lbPassenger.Items(0)
            btnGenerate.Enabled = True
            price = Double.Parse(Admin.txtPrice.Text)
            ND1 = Double.Parse(Admin.txtDistance1.Text)
            ND2 = Double.Parse(Admin.txtDistance2.Text)
            ND3 = Double.Parse(Admin.txtDistance3.Text)
            ND4 = Double.Parse(Admin.txtDistance4.Text)
            ND5 = Double.Parse(Admin.txtDistance5.Text)
            Select Case ops
                Case "Route1"
                    lblPrice.Text = (price * ND1)

                Case "Route2"
                    lblPrice.Text = (price * ND2)
                Case "Route3"
                    lblPrice.Text = (price * ND3)
                Case "Route4"
                    lblPrice.Text = (price * ND4)
                Case "Route5"
                    lblPrice.Text = (price * ND5)
            End Select
            Passengers_view.lblOrigin.Text = txtOrigin.Text
            Passengers_view.lblPrice2.Text = lblPrice.Text
            Passengers_view.lblTicket.Text = lblTicketno.Text
            Passengers_view.lblSeatnum.Text = lblSeatnum.Text
            Passengers_view.lblNeed.Text = lblNeed.Text
            Passengers_view.lblPrice.Text = lblPrice.Text
            Passengers_view.txtOrigin.Text = txtOrigin.Text
            If rbMakati.Checked = True Then
                Passengers_view.txtDestination.Text = rbMakati.Text
                Passengers_view.lblDestination.Text = Passengers_view.txtDestination.Text
            ElseIf rbManila.Checked = True Then
                Passengers_view.txtDestination.Text = rbManila.Text
                Passengers_view.lblDestination.Text = Passengers_view.txtDestination.Text
            ElseIf rbQuezon.Checked = True Then
                Passengers_view.txtDestination.Text = rbQuezon.Text
                Passengers_view.lblDestination.Text = Passengers_view.txtDestination.Text
            ElseIf rbCaloocan.Checked = True Then
                Passengers_view.txtDestination.Text = rbCaloocan.Text
                Passengers_view.lblDestination.Text = Passengers_view.txtDestination.Text
            ElseIf rbBulacan.Checked = True Then
                Passengers_view.txtDestination.Text = rbBulacan.Text
                Passengers_view.lblDestination.Text = Passengers_view.txtDestination.Text


            End If
            End If










    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSouth.Click
        'South button
        SOUTH.Show()
        Passengers_View_South.Show()
        Me.Hide()
        Passengers_view.Hide()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        'Ticket Number
        Static ticket As Integer
        ticket += 1
        lblTicketno.Text = ticket.ToString("NTH-0000")
        Passengers_view.lblTicketno.Text = lblTicketno.Text
        Passengers_view.lblTicket.Text = lblTicketno.Text
        btnPrint.Enabled = True
        btnGenerate.Enabled = False
        GroupBox1.Enabled = True
    End Sub

    Private Sub seat1_CheckedChanged(sender As Object, e As EventArgs) Handles seat1.CheckedChanged
        'Seat Code from 1-25
        If seat1.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "1"
            Passengers_view.seat1.Checked = True
        Else
            Passengers_view.seat1.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat2_CheckedChanged(sender As Object, e As EventArgs) Handles seat2.CheckedChanged
        If seat2.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "2"
            Passengers_view.seat2.Checked = True
        Else
            Passengers_view.seat2.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat3_CheckedChanged(sender As Object, e As EventArgs) Handles seat3.CheckedChanged
        If seat3.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "3"
            Passengers_view.seat3.Checked = True
        Else
            Passengers_view.seat3.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat4_CheckedChanged(sender As Object, e As EventArgs) Handles seat4.CheckedChanged
        If seat4.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "4"
            Passengers_view.seat4.Checked = True
        Else
            Passengers_view.seat4.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat5_CheckedChanged(sender As Object, e As EventArgs) Handles seat5.CheckedChanged
        If seat5.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "5"
            Passengers_view.seat5.Checked = True
        Else
            Passengers_view.seat5.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat6_CheckedChanged(sender As Object, e As EventArgs) Handles seat6.CheckedChanged
        If seat6.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "6"
            Passengers_view.seat6.Checked = True
        Else
            Passengers_view.seat6.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat7_CheckedChanged(sender As Object, e As EventArgs) Handles seat7.CheckedChanged
        If seat7.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "7"
            Passengers_view.seat7.Checked = True
        Else
            Passengers_view.seat7.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat8_CheckedChanged(sender As Object, e As EventArgs) Handles seat8.CheckedChanged
        If seat8.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "8"
            Passengers_view.seat8.Checked = True
        Else
            Passengers_view.seat8.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat9_CheckedChanged(sender As Object, e As EventArgs) Handles seat9.CheckedChanged
        If seat9.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "9"
            Passengers_view.seat9.Checked = True
        Else
            Passengers_view.seat9.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat10_CheckedChanged(sender As Object, e As EventArgs) Handles seat10.CheckedChanged
        If seat10.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "10"
            Passengers_view.seat10.Checked = True
        Else
            Passengers_view.seat10.Checked = False
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
            Passengers_view.seat12.Checked = True
        Else
            Passengers_view.seat12.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat13_CheckedChanged(sender As Object, e As EventArgs) Handles seat13.CheckedChanged
        If seat13.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "13"
            Passengers_view.seat13.Checked = True
        Else
            Passengers_view.seat13.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat14_CheckedChanged(sender As Object, e As EventArgs) Handles seat14.CheckedChanged
        If seat14.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "14"
            Passengers_view.seat14.Checked = True
        Else
            Passengers_view.seat14.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat15_CheckedChanged(sender As Object, e As EventArgs) Handles seat15.CheckedChanged
        If seat15.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "15"
            Passengers_view.seat15.Checked = True
        Else
            Passengers_view.seat15.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat16_CheckedChanged(sender As Object, e As EventArgs) Handles seat16.CheckedChanged
        If seat16.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "16"
            Passengers_view.seat16.Checked = True
        Else
            Passengers_view.seat16.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat17_CheckedChanged(sender As Object, e As EventArgs) Handles seat17.CheckedChanged
        If seat17.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "17"
            Passengers_view.seat17.Checked = True
        Else
            Passengers_view.seat17.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat18_CheckedChanged(sender As Object, e As EventArgs) Handles seat18.CheckedChanged
        If seat18.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "18"
            Passengers_view.seat18.Checked = True
        Else
            Passengers_view.seat18.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat19_CheckedChanged(sender As Object, e As EventArgs) Handles seat19.CheckedChanged
        If seat19.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "19"
            Passengers_view.seat19.Checked = True
        Else
            Passengers_view.seat19.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat20_CheckedChanged(sender As Object, e As EventArgs) Handles seat20.CheckedChanged
        If seat20.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "20"
            Passengers_view.seat20.Checked = True
        Else
            Passengers_view.seat20.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat21_CheckedChanged(sender As Object, e As EventArgs) Handles seat21.CheckedChanged
        If seat21.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "21"
            Passengers_view.seat21.Checked = True
        Else
            Passengers_view.seat21.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat22_CheckedChanged(sender As Object, e As EventArgs) Handles seat22.CheckedChanged
        If seat22.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "22"
            Passengers_view.seat22.Checked = True
        Else
            Passengers_view.seat22.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat23_CheckedChanged(sender As Object, e As EventArgs) Handles seat23.CheckedChanged
        If seat23.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "23"
            Passengers_view.seat23.Checked = True
        Else
            Passengers_view.seat23.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat24_CheckedChanged(sender As Object, e As EventArgs) Handles seat24.CheckedChanged
        If seat24.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "24"
            Passengers_view.seat24.Checked = True
        Else
            Passengers_view.seat24.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub seat25_CheckedChanged(sender As Object, e As EventArgs) Handles seat25.CheckedChanged
        If seat25.Checked = True Then
            lblNeed.Text -= 1
            lblSeatnum.Text = "25"
            Passengers_view.seat25.Checked = True
        Else
            Passengers_view.seat25.Checked = False
            lblNeed.Text += 1
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Cancel button
        Passengers_view.txtDestination.Clear()
        Passengers_view.lblPrice.Text = "0.00"
        rbMakati.Checked = False
        rbManila.Checked = False
        rbQuezon.Checked = False
        rbCaloocan.Checked = False
        rbBulacan.Checked = False
        lblPrice.Text = "0.00"
    End Sub

    Private Sub btnDepart_Click(sender As Object, e As EventArgs) Handles btnDepart.Click
        'Depart Button
        MsgBox("Bus Departed", MsgBoxStyle.Information, "Notification")
        Admin.lblBuscount.Text -= 1
        btnConfirm.Enabled = True
        btnDepart.Enabled = False
        lblBusNo.Text += 2
        Passengers_view.lblBusNo.Text += 2
        lblNeed.Text = "0"
        Passengers_view.lblNeed.Text = "25"
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
        lblTicketno.Text = "NTH-0000"
        Records.DataGridView2.Rows.Add(lblBusnum.Text, DateAndTime.Now)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dashboard.Show()
        Dashboard.lblDate.Text = DateAndTime.Now
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Passengers_view.Hide()
        Login_Form.Show()
    End Sub
End Class
