<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BusMove = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblBus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNeed = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTicketno = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbPassenger = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblBusNo = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.btnNorth = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnDepart = New System.Windows.Forms.Button()
        Me.seat15 = New System.Windows.Forms.CheckBox()
        Me.seat17 = New System.Windows.Forms.CheckBox()
        Me.seat11 = New System.Windows.Forms.CheckBox()
        Me.seat19 = New System.Windows.Forms.CheckBox()
        Me.seat10 = New System.Windows.Forms.CheckBox()
        Me.seat12 = New System.Windows.Forms.CheckBox()
        Me.seat8 = New System.Windows.Forms.CheckBox()
        Me.seat14 = New System.Windows.Forms.CheckBox()
        Me.seat6 = New System.Windows.Forms.CheckBox()
        Me.seat16 = New System.Windows.Forms.CheckBox()
        Me.seat4 = New System.Windows.Forms.CheckBox()
        Me.seat18 = New System.Windows.Forms.CheckBox()
        Me.seat2 = New System.Windows.Forms.CheckBox()
        Me.seat20 = New System.Windows.Forms.CheckBox()
        Me.seat9 = New System.Windows.Forms.CheckBox()
        Me.seat23 = New System.Windows.Forms.CheckBox()
        Me.seat7 = New System.Windows.Forms.CheckBox()
        Me.seat24 = New System.Windows.Forms.CheckBox()
        Me.seat5 = New System.Windows.Forms.CheckBox()
        Me.seat22 = New System.Windows.Forms.CheckBox()
        Me.seat3 = New System.Windows.Forms.CheckBox()
        Me.seat25 = New System.Windows.Forms.CheckBox()
        Me.seat1 = New System.Windows.Forms.CheckBox()
        Me.seat21 = New System.Windows.Forms.CheckBox()
        Me.seat13 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtOrigin = New System.Windows.Forms.TextBox()
        Me.rbMakati = New System.Windows.Forms.RadioButton()
        Me.rbManila = New System.Windows.Forms.RadioButton()
        Me.rbQuezon = New System.Windows.Forms.RadioButton()
        Me.rbCaloocan = New System.Windows.Forms.RadioButton()
        Me.rbBulacan = New System.Windows.Forms.RadioButton()
        Me.btnSouth = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSeatnum = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblBusnum = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblPrice2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'BusMove
        '
        '
        'btnPrint
        '
        Me.btnPrint.Enabled = False
        Me.btnPrint.Location = New System.Drawing.Point(590, 379)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(288, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "E.M STATION"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(509, 379)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblBus
        '
        Me.lblBus.AutoSize = True
        Me.lblBus.BackColor = System.Drawing.Color.Transparent
        Me.lblBus.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBus.ForeColor = System.Drawing.Color.Maroon
        Me.lblBus.Location = New System.Drawing.Point(347, 62)
        Me.lblBus.Name = "lblBus"
        Me.lblBus.Size = New System.Drawing.Size(36, 17)
        Me.lblBus.TabIndex = 4
        Me.lblBus.Text = "Bus"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Coral
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(5, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "SEATS AVAILABLE"
        '
        'lblNeed
        '
        Me.lblNeed.AutoSize = True
        Me.lblNeed.BackColor = System.Drawing.Color.Coral
        Me.lblNeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNeed.Location = New System.Drawing.Point(127, 390)
        Me.lblNeed.Name = "lblNeed"
        Me.lblNeed.Size = New System.Drawing.Size(19, 15)
        Me.lblNeed.TabIndex = 6
        Me.lblNeed.Text = "25"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Coral
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(259, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Destination"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Coral
        Me.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPrice.Location = New System.Drawing.Point(46, 228)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(28, 15)
        Me.lblPrice.TabIndex = 8
        Me.lblPrice.Text = "0.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Coral
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(33, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Origin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Coral
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(5, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Price"
        '
        'lblTicketno
        '
        Me.lblTicketno.AutoSize = True
        Me.lblTicketno.BackColor = System.Drawing.Color.Coral
        Me.lblTicketno.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTicketno.Location = New System.Drawing.Point(492, 99)
        Me.lblTicketno.Name = "lblTicketno"
        Me.lblTicketno.Size = New System.Drawing.Size(60, 15)
        Me.lblTicketno.TabIndex = 11
        Me.lblTicketno.Text = "NTH-0000"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Coral
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(472, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 15)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Ticket Number"
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.LightSalmon
        Me.btnGenerate.Enabled = False
        Me.btnGenerate.ForeColor = System.Drawing.Color.Brown
        Me.btnGenerate.Location = New System.Drawing.Point(472, 117)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(91, 23)
        Me.btnGenerate.TabIndex = 18
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Coral
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTime.Location = New System.Drawing.Point(673, 45)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(72, 18)
        Me.lblTime.TabIndex = 19
        Me.lblTime.Text = "00:00:00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Coral
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(693, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 15)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Time"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(669, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Passenger"
        '
        'lbPassenger
        '
        Me.lbPassenger.BackColor = System.Drawing.Color.LightSalmon
        Me.lbPassenger.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbPassenger.ForeColor = System.Drawing.Color.Brown
        Me.lbPassenger.FormattingEnabled = True
        Me.lbPassenger.Location = New System.Drawing.Point(669, 99)
        Me.lbPassenger.Name = "lbPassenger"
        Me.lbPassenger.Size = New System.Drawing.Size(76, 186)
        Me.lbPassenger.TabIndex = 22
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(669, 291)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Add Queue"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.LightSalmon
        Me.btnConfirm.ForeColor = System.Drawing.Color.Brown
        Me.btnConfirm.Location = New System.Drawing.Point(260, 333)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(69, 23)
        Me.btnConfirm.TabIndex = 25
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'lblBusNo
        '
        Me.lblBusNo.AutoSize = True
        Me.lblBusNo.BackColor = System.Drawing.Color.Transparent
        Me.lblBusNo.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBusNo.ForeColor = System.Drawing.Color.Maroon
        Me.lblBusNo.Location = New System.Drawing.Point(380, 63)
        Me.lblBusNo.Name = "lblBusNo"
        Me.lblBusNo.Size = New System.Drawing.Size(13, 16)
        Me.lblBusNo.TabIndex = 34
        Me.lblBusNo.Text = "1"
        '
        'lblAdd
        '
        Me.lblAdd.AllowDrop = True
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Location = New System.Drawing.Point(732, 18)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(13, 15)
        Me.lblAdd.TabIndex = 36
        Me.lblAdd.Text = "0"
        Me.lblAdd.Visible = False
        '
        'btnLog
        '
        Me.btnLog.BackColor = System.Drawing.Color.LightSalmon
        Me.btnLog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLog.ForeColor = System.Drawing.Color.Brown
        Me.btnLog.Location = New System.Drawing.Point(5, 362)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(75, 23)
        Me.btnLog.TabIndex = 37
        Me.btnLog.Text = "Record"
        Me.btnLog.UseVisualStyleBackColor = False
        '
        'btnNorth
        '
        Me.btnNorth.BackColor = System.Drawing.Color.LightSalmon
        Me.btnNorth.Enabled = False
        Me.btnNorth.ForeColor = System.Drawing.Color.Brown
        Me.btnNorth.Location = New System.Drawing.Point(5, 249)
        Me.btnNorth.Name = "btnNorth"
        Me.btnNorth.Size = New System.Drawing.Size(89, 23)
        Me.btnNorth.TabIndex = 40
        Me.btnNorth.Text = "NORTH"
        Me.btnNorth.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightSalmon
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button6.ForeColor = System.Drawing.Color.Brown
        Me.Button6.Location = New System.Drawing.Point(5, 333)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 67
        Me.Button6.Text = "Admin"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btnDepart
        '
        Me.btnDepart.Enabled = False
        Me.btnDepart.Location = New System.Drawing.Point(673, 380)
        Me.btnDepart.Name = "btnDepart"
        Me.btnDepart.Size = New System.Drawing.Size(75, 23)
        Me.btnDepart.TabIndex = 42
        Me.btnDepart.Text = "DEPART"
        Me.btnDepart.UseVisualStyleBackColor = False
        '
        'seat15
        '
        Me.seat15.AutoSize = True
        Me.seat15.Location = New System.Drawing.Point(136, 76)
        Me.seat15.Name = "seat15"
        Me.seat15.Size = New System.Drawing.Size(38, 19)
        Me.seat15.TabIndex = 40
        Me.seat15.Text = "💺"
        Me.seat15.UseVisualStyleBackColor = True
        '
        'seat17
        '
        Me.seat17.AutoSize = True
        Me.seat17.Location = New System.Drawing.Point(136, 101)
        Me.seat17.Name = "seat17"
        Me.seat17.Size = New System.Drawing.Size(38, 19)
        Me.seat17.TabIndex = 41
        Me.seat17.Text = "💺"
        Me.seat17.UseVisualStyleBackColor = True
        '
        'seat11
        '
        Me.seat11.AutoSize = True
        Me.seat11.Location = New System.Drawing.Point(136, 26)
        Me.seat11.Name = "seat11"
        Me.seat11.Size = New System.Drawing.Size(38, 19)
        Me.seat11.TabIndex = 38
        Me.seat11.Text = "💺"
        Me.seat11.UseVisualStyleBackColor = True
        '
        'seat19
        '
        Me.seat19.AutoSize = True
        Me.seat19.Location = New System.Drawing.Point(136, 126)
        Me.seat19.Name = "seat19"
        Me.seat19.Size = New System.Drawing.Size(38, 19)
        Me.seat19.TabIndex = 42
        Me.seat19.Text = "💺"
        Me.seat19.UseVisualStyleBackColor = True
        '
        'seat10
        '
        Me.seat10.AutoSize = True
        Me.seat10.Location = New System.Drawing.Point(55, 126)
        Me.seat10.Name = "seat10"
        Me.seat10.Size = New System.Drawing.Size(38, 19)
        Me.seat10.TabIndex = 37
        Me.seat10.Text = "💺"
        Me.seat10.UseVisualStyleBackColor = True
        '
        'seat12
        '
        Me.seat12.AutoSize = True
        Me.seat12.Location = New System.Drawing.Point(175, 26)
        Me.seat12.Name = "seat12"
        Me.seat12.Size = New System.Drawing.Size(38, 19)
        Me.seat12.TabIndex = 43
        Me.seat12.Text = "💺"
        Me.seat12.UseVisualStyleBackColor = True
        '
        'seat8
        '
        Me.seat8.AutoSize = True
        Me.seat8.Location = New System.Drawing.Point(55, 101)
        Me.seat8.Name = "seat8"
        Me.seat8.Size = New System.Drawing.Size(38, 19)
        Me.seat8.TabIndex = 36
        Me.seat8.Text = "💺"
        Me.seat8.UseVisualStyleBackColor = True
        '
        'seat14
        '
        Me.seat14.AutoSize = True
        Me.seat14.Location = New System.Drawing.Point(175, 51)
        Me.seat14.Name = "seat14"
        Me.seat14.Size = New System.Drawing.Size(38, 19)
        Me.seat14.TabIndex = 44
        Me.seat14.Text = "💺"
        Me.seat14.UseVisualStyleBackColor = True
        '
        'seat6
        '
        Me.seat6.AutoSize = True
        Me.seat6.Location = New System.Drawing.Point(55, 76)
        Me.seat6.Name = "seat6"
        Me.seat6.Size = New System.Drawing.Size(38, 19)
        Me.seat6.TabIndex = 35
        Me.seat6.Text = "💺"
        Me.seat6.UseVisualStyleBackColor = True
        '
        'seat16
        '
        Me.seat16.AutoSize = True
        Me.seat16.Location = New System.Drawing.Point(175, 76)
        Me.seat16.Name = "seat16"
        Me.seat16.Size = New System.Drawing.Size(38, 19)
        Me.seat16.TabIndex = 45
        Me.seat16.Text = "💺"
        Me.seat16.UseVisualStyleBackColor = True
        '
        'seat4
        '
        Me.seat4.AutoSize = True
        Me.seat4.Location = New System.Drawing.Point(55, 51)
        Me.seat4.Name = "seat4"
        Me.seat4.Size = New System.Drawing.Size(38, 19)
        Me.seat4.TabIndex = 34
        Me.seat4.Text = "💺"
        Me.seat4.UseVisualStyleBackColor = True
        '
        'seat18
        '
        Me.seat18.AutoSize = True
        Me.seat18.Location = New System.Drawing.Point(175, 101)
        Me.seat18.Name = "seat18"
        Me.seat18.Size = New System.Drawing.Size(38, 19)
        Me.seat18.TabIndex = 46
        Me.seat18.Text = "💺"
        Me.seat18.UseVisualStyleBackColor = True
        '
        'seat2
        '
        Me.seat2.AutoSize = True
        Me.seat2.Location = New System.Drawing.Point(55, 26)
        Me.seat2.Name = "seat2"
        Me.seat2.Size = New System.Drawing.Size(38, 19)
        Me.seat2.TabIndex = 33
        Me.seat2.Text = "💺"
        Me.seat2.UseVisualStyleBackColor = True
        '
        'seat20
        '
        Me.seat20.AutoSize = True
        Me.seat20.Location = New System.Drawing.Point(175, 126)
        Me.seat20.Name = "seat20"
        Me.seat20.Size = New System.Drawing.Size(38, 19)
        Me.seat20.TabIndex = 47
        Me.seat20.Text = "💺"
        Me.seat20.UseVisualStyleBackColor = True
        '
        'seat9
        '
        Me.seat9.AutoSize = True
        Me.seat9.Location = New System.Drawing.Point(11, 126)
        Me.seat9.Name = "seat9"
        Me.seat9.Size = New System.Drawing.Size(38, 19)
        Me.seat9.TabIndex = 32
        Me.seat9.Text = "💺"
        Me.seat9.UseVisualStyleBackColor = True
        '
        'seat23
        '
        Me.seat23.AutoSize = True
        Me.seat23.Location = New System.Drawing.Point(99, 151)
        Me.seat23.Name = "seat23"
        Me.seat23.Size = New System.Drawing.Size(38, 19)
        Me.seat23.TabIndex = 48
        Me.seat23.Text = "💺"
        Me.seat23.UseVisualStyleBackColor = True
        '
        'seat7
        '
        Me.seat7.AutoSize = True
        Me.seat7.Location = New System.Drawing.Point(11, 101)
        Me.seat7.Name = "seat7"
        Me.seat7.Size = New System.Drawing.Size(38, 19)
        Me.seat7.TabIndex = 31
        Me.seat7.Text = "💺"
        Me.seat7.UseVisualStyleBackColor = True
        '
        'seat24
        '
        Me.seat24.AutoSize = True
        Me.seat24.Location = New System.Drawing.Point(136, 151)
        Me.seat24.Name = "seat24"
        Me.seat24.Size = New System.Drawing.Size(38, 19)
        Me.seat24.TabIndex = 49
        Me.seat24.Text = "💺"
        Me.seat24.UseVisualStyleBackColor = True
        '
        'seat5
        '
        Me.seat5.AutoSize = True
        Me.seat5.Location = New System.Drawing.Point(11, 76)
        Me.seat5.Name = "seat5"
        Me.seat5.Size = New System.Drawing.Size(38, 19)
        Me.seat5.TabIndex = 30
        Me.seat5.Text = "💺"
        Me.seat5.UseVisualStyleBackColor = True
        '
        'seat22
        '
        Me.seat22.AutoSize = True
        Me.seat22.Location = New System.Drawing.Point(55, 151)
        Me.seat22.Name = "seat22"
        Me.seat22.Size = New System.Drawing.Size(38, 19)
        Me.seat22.TabIndex = 50
        Me.seat22.Text = "💺"
        Me.seat22.UseVisualStyleBackColor = True
        '
        'seat3
        '
        Me.seat3.AutoSize = True
        Me.seat3.Location = New System.Drawing.Point(11, 51)
        Me.seat3.Name = "seat3"
        Me.seat3.Size = New System.Drawing.Size(38, 19)
        Me.seat3.TabIndex = 29
        Me.seat3.Text = "💺"
        Me.seat3.UseVisualStyleBackColor = True
        '
        'seat25
        '
        Me.seat25.AutoSize = True
        Me.seat25.Location = New System.Drawing.Point(175, 151)
        Me.seat25.Name = "seat25"
        Me.seat25.Size = New System.Drawing.Size(38, 19)
        Me.seat25.TabIndex = 51
        Me.seat25.Text = "💺"
        Me.seat25.UseVisualStyleBackColor = True
        '
        'seat1
        '
        Me.seat1.AutoSize = True
        Me.seat1.Location = New System.Drawing.Point(11, 26)
        Me.seat1.Name = "seat1"
        Me.seat1.Size = New System.Drawing.Size(38, 19)
        Me.seat1.TabIndex = 28
        Me.seat1.Text = "💺"
        Me.seat1.UseVisualStyleBackColor = True
        '
        'seat21
        '
        Me.seat21.AutoSize = True
        Me.seat21.Location = New System.Drawing.Point(11, 151)
        Me.seat21.Name = "seat21"
        Me.seat21.Size = New System.Drawing.Size(38, 19)
        Me.seat21.TabIndex = 52
        Me.seat21.Text = "💺"
        Me.seat21.UseVisualStyleBackColor = True
        '
        'seat13
        '
        Me.seat13.AutoSize = True
        Me.seat13.Location = New System.Drawing.Point(136, 51)
        Me.seat13.Name = "seat13"
        Me.seat13.Size = New System.Drawing.Size(38, 19)
        Me.seat13.TabIndex = 39
        Me.seat13.Text = "💺"
        Me.seat13.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.seat13)
        Me.GroupBox1.Controls.Add(Me.seat21)
        Me.GroupBox1.Controls.Add(Me.seat1)
        Me.GroupBox1.Controls.Add(Me.seat25)
        Me.GroupBox1.Controls.Add(Me.seat3)
        Me.GroupBox1.Controls.Add(Me.seat22)
        Me.GroupBox1.Controls.Add(Me.seat5)
        Me.GroupBox1.Controls.Add(Me.seat24)
        Me.GroupBox1.Controls.Add(Me.seat7)
        Me.GroupBox1.Controls.Add(Me.seat23)
        Me.GroupBox1.Controls.Add(Me.seat9)
        Me.GroupBox1.Controls.Add(Me.seat20)
        Me.GroupBox1.Controls.Add(Me.seat2)
        Me.GroupBox1.Controls.Add(Me.seat18)
        Me.GroupBox1.Controls.Add(Me.seat4)
        Me.GroupBox1.Controls.Add(Me.seat16)
        Me.GroupBox1.Controls.Add(Me.seat6)
        Me.GroupBox1.Controls.Add(Me.seat14)
        Me.GroupBox1.Controls.Add(Me.seat8)
        Me.GroupBox1.Controls.Add(Me.seat12)
        Me.GroupBox1.Controls.Add(Me.seat10)
        Me.GroupBox1.Controls.Add(Me.seat19)
        Me.GroupBox1.Controls.Add(Me.seat11)
        Me.GroupBox1.Controls.Add(Me.seat17)
        Me.GroupBox1.Controls.Add(Me.seat15)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(406, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 193)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        '
        'txtOrigin
        '
        Me.txtOrigin.BackColor = System.Drawing.Color.Coral
        Me.txtOrigin.Enabled = False
        Me.txtOrigin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtOrigin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOrigin.Location = New System.Drawing.Point(5, 132)
        Me.txtOrigin.Name = "txtOrigin"
        Me.txtOrigin.Size = New System.Drawing.Size(126, 23)
        Me.txtOrigin.TabIndex = 68
        Me.txtOrigin.Text = "PASIG CITY STATION"
        '
        'rbMakati
        '
        Me.rbMakati.AutoSize = True
        Me.rbMakati.Location = New System.Drawing.Point(260, 199)
        Me.rbMakati.Name = "rbMakati"
        Me.rbMakati.Size = New System.Drawing.Size(61, 19)
        Me.rbMakati.TabIndex = 69
        Me.rbMakati.TabStop = True
        Me.rbMakati.Text = "Makati"
        Me.rbMakati.UseVisualStyleBackColor = True
        '
        'rbManila
        '
        Me.rbManila.AutoSize = True
        Me.rbManila.Location = New System.Drawing.Point(260, 224)
        Me.rbManila.Name = "rbManila"
        Me.rbManila.Size = New System.Drawing.Size(61, 19)
        Me.rbManila.TabIndex = 70
        Me.rbManila.TabStop = True
        Me.rbManila.Text = "Manila"
        Me.rbManila.UseVisualStyleBackColor = True
        '
        'rbQuezon
        '
        Me.rbQuezon.AutoSize = True
        Me.rbQuezon.Location = New System.Drawing.Point(260, 249)
        Me.rbQuezon.Name = "rbQuezon"
        Me.rbQuezon.Size = New System.Drawing.Size(66, 19)
        Me.rbQuezon.TabIndex = 71
        Me.rbQuezon.TabStop = True
        Me.rbQuezon.Text = "Quezon"
        Me.rbQuezon.UseVisualStyleBackColor = True
        '
        'rbCaloocan
        '
        Me.rbCaloocan.AutoSize = True
        Me.rbCaloocan.Location = New System.Drawing.Point(259, 277)
        Me.rbCaloocan.Name = "rbCaloocan"
        Me.rbCaloocan.Size = New System.Drawing.Size(75, 19)
        Me.rbCaloocan.TabIndex = 72
        Me.rbCaloocan.TabStop = True
        Me.rbCaloocan.Text = "Caloocan"
        Me.rbCaloocan.UseVisualStyleBackColor = True
        '
        'rbBulacan
        '
        Me.rbBulacan.AutoSize = True
        Me.rbBulacan.Location = New System.Drawing.Point(259, 306)
        Me.rbBulacan.Name = "rbBulacan"
        Me.rbBulacan.Size = New System.Drawing.Size(67, 19)
        Me.rbBulacan.TabIndex = 73
        Me.rbBulacan.TabStop = True
        Me.rbBulacan.Text = "Bulacan"
        Me.rbBulacan.UseVisualStyleBackColor = True
        '
        'btnSouth
        '
        Me.btnSouth.BackColor = System.Drawing.Color.LightSalmon
        Me.btnSouth.ForeColor = System.Drawing.Color.Brown
        Me.btnSouth.Location = New System.Drawing.Point(5, 278)
        Me.btnSouth.Name = "btnSouth"
        Me.btnSouth.Size = New System.Drawing.Size(89, 23)
        Me.btnSouth.TabIndex = 74
        Me.btnSouth.Text = "SOUTH"
        Me.btnSouth.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(342, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "NORTH"
        '
        'lblSeatnum
        '
        Me.lblSeatnum.AutoSize = True
        Me.lblSeatnum.BackColor = System.Drawing.Color.Coral
        Me.lblSeatnum.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSeatnum.Location = New System.Drawing.Point(502, 145)
        Me.lblSeatnum.Name = "lblSeatnum"
        Me.lblSeatnum.Size = New System.Drawing.Size(13, 15)
        Me.lblSeatnum.TabIndex = 121
        Me.lblSeatnum.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Coral
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(406, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "SEAT NUMBER:"
        '
        'lblBusnum
        '
        Me.lblBusnum.AutoSize = True
        Me.lblBusnum.Location = New System.Drawing.Point(347, 83)
        Me.lblBusnum.Name = "lblBusnum"
        Me.lblBusnum.Size = New System.Drawing.Size(64, 15)
        Me.lblBusnum.TabIndex = 122
        Me.lblBusnum.Text = "lblbusnum"
        Me.lblBusnum.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSalmon
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Brown
        Me.Button1.Location = New System.Drawing.Point(5, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 123
        Me.Button1.Text = "Dashboard"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightSalmon
        Me.btnBack.Location = New System.Drawing.Point(428, 379)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 124
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblPrice2
        '
        Me.lblPrice2.AutoSize = True
        Me.lblPrice2.BackColor = System.Drawing.Color.Coral
        Me.lblPrice2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPrice2.Location = New System.Drawing.Point(80, 228)
        Me.lblPrice2.Name = "lblPrice2"
        Me.lblPrice2.Size = New System.Drawing.Size(28, 15)
        Me.lblPrice2.TabIndex = 125
        Me.lblPrice2.Text = "0.00"
        Me.lblPrice2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 126
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(757, 414)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPrice2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblBusnum)
        Me.Controls.Add(Me.lblSeatnum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSouth)
        Me.Controls.Add(Me.rbBulacan)
        Me.Controls.Add(Me.rbCaloocan)
        Me.Controls.Add(Me.rbQuezon)
        Me.Controls.Add(Me.rbManila)
        Me.Controls.Add(Me.rbMakati)
        Me.Controls.Add(Me.txtOrigin)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDepart)
        Me.Controls.Add(Me.btnNorth)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.lblBusNo)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lbPassenger)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTicketno)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblNeed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblBus)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrint)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "Ticketing System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BusMove As Timer
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblBus As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNeed As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTicketno As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbPassenger As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblBusNo As Label
    Friend WithEvents lblAdd As Label
    Friend WithEvents btnLog As Button
    Friend WithEvents btnNorth As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents btnDepart As Button
    Friend WithEvents seat15 As CheckBox
    Friend WithEvents seat17 As CheckBox
    Friend WithEvents seat11 As CheckBox
    Friend WithEvents seat19 As CheckBox
    Friend WithEvents seat10 As CheckBox
    Friend WithEvents seat12 As CheckBox
    Friend WithEvents seat8 As CheckBox
    Friend WithEvents seat14 As CheckBox
    Friend WithEvents seat6 As CheckBox
    Friend WithEvents seat16 As CheckBox
    Friend WithEvents seat4 As CheckBox
    Friend WithEvents seat18 As CheckBox
    Friend WithEvents seat2 As CheckBox
    Friend WithEvents seat20 As CheckBox
    Friend WithEvents seat9 As CheckBox
    Friend WithEvents seat23 As CheckBox
    Friend WithEvents seat7 As CheckBox
    Friend WithEvents seat24 As CheckBox
    Friend WithEvents seat5 As CheckBox
    Friend WithEvents seat22 As CheckBox
    Friend WithEvents seat3 As CheckBox
    Friend WithEvents seat25 As CheckBox
    Friend WithEvents seat1 As CheckBox
    Friend WithEvents seat21 As CheckBox
    Friend WithEvents seat13 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtOrigin As TextBox
    Friend WithEvents rbMakati As RadioButton
    Friend WithEvents rbManila As RadioButton
    Friend WithEvents rbQuezon As RadioButton
    Friend WithEvents rbCaloocan As RadioButton
    Friend WithEvents rbBulacan As RadioButton
    Friend WithEvents btnSouth As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSeatnum As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblBusnum As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblPrice2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
