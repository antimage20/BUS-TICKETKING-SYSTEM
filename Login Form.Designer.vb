<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.pbRed = New System.Windows.Forms.PictureBox()
        Me.pbRed2 = New System.Windows.Forms.PictureBox()
        Me.pbYellow = New System.Windows.Forms.PictureBox()
        Me.pbYellow2 = New System.Windows.Forms.PictureBox()
        Me.pbGreen = New System.Windows.Forms.PictureBox()
        Me.pbGreen2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRed2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbYellow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbYellow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGreen2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Location = New System.Drawing.Point(27, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label2.Location = New System.Drawing.Point(6, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Info
        Me.txtPassword.Location = New System.Drawing.Point(68, 100)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(178, 23)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Symbol", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Khaki
        Me.Label3.Location = New System.Drawing.Point(180, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "WELCOME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Symbol", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(225, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 32)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "to"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label5.Font = New System.Drawing.Font("Imprint MT Shadow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(155, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 28)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "E.M STATION"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Info
        Me.txtUsername.Location = New System.Drawing.Point(68, 61)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(178, 23)
        Me.txtUsername.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnLogin)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(106, 270)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 175)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.Info
        Me.CheckBox1.Location = New System.Drawing.Point(252, 102)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(38, 19)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "👁"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCancel.Location = New System.Drawing.Point(177, 129)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLogin.Location = New System.Drawing.Point(74, 129)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'pbRed
        '
        Me.pbRed.Image = CType(resources.GetObject("pbRed.Image"), System.Drawing.Image)
        Me.pbRed.Location = New System.Drawing.Point(12, 20)
        Me.pbRed.Name = "pbRed"
        Me.pbRed.Size = New System.Drawing.Size(61, 156)
        Me.pbRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRed.TabIndex = 9
        Me.pbRed.TabStop = False
        '
        'pbRed2
        '
        Me.pbRed2.Image = CType(resources.GetObject("pbRed2.Image"), System.Drawing.Image)
        Me.pbRed2.Location = New System.Drawing.Point(428, 20)
        Me.pbRed2.Name = "pbRed2"
        Me.pbRed2.Size = New System.Drawing.Size(61, 156)
        Me.pbRed2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRed2.TabIndex = 10
        Me.pbRed2.TabStop = False
        '
        'pbYellow
        '
        Me.pbYellow.Image = CType(resources.GetObject("pbYellow.Image"), System.Drawing.Image)
        Me.pbYellow.Location = New System.Drawing.Point(12, 20)
        Me.pbYellow.Name = "pbYellow"
        Me.pbYellow.Size = New System.Drawing.Size(61, 156)
        Me.pbYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbYellow.TabIndex = 11
        Me.pbYellow.TabStop = False
        '
        'pbYellow2
        '
        Me.pbYellow2.Image = CType(resources.GetObject("pbYellow2.Image"), System.Drawing.Image)
        Me.pbYellow2.Location = New System.Drawing.Point(428, 20)
        Me.pbYellow2.Name = "pbYellow2"
        Me.pbYellow2.Size = New System.Drawing.Size(61, 156)
        Me.pbYellow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbYellow2.TabIndex = 12
        Me.pbYellow2.TabStop = False
        '
        'pbGreen
        '
        Me.pbGreen.Image = CType(resources.GetObject("pbGreen.Image"), System.Drawing.Image)
        Me.pbGreen.Location = New System.Drawing.Point(12, 20)
        Me.pbGreen.Name = "pbGreen"
        Me.pbGreen.Size = New System.Drawing.Size(61, 156)
        Me.pbGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGreen.TabIndex = 13
        Me.pbGreen.TabStop = False
        '
        'pbGreen2
        '
        Me.pbGreen2.Image = CType(resources.GetObject("pbGreen2.Image"), System.Drawing.Image)
        Me.pbGreen2.Location = New System.Drawing.Point(428, 20)
        Me.pbGreen2.Name = "pbGreen2"
        Me.pbGreen2.Size = New System.Drawing.Size(61, 156)
        Me.pbGreen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGreen2.TabIndex = 14
        Me.pbGreen2.TabStop = False
        '
        'Timer1
        '
        '
        'Login_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(501, 471)
        Me.Controls.Add(Me.pbGreen2)
        Me.Controls.Add(Me.pbGreen)
        Me.Controls.Add(Me.pbYellow2)
        Me.Controls.Add(Me.pbYellow)
        Me.Controls.Add(Me.pbRed2)
        Me.Controls.Add(Me.pbRed)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Login_Form"
        Me.Text = "Login_Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRed2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbYellow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbYellow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGreen2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents pbRed As PictureBox
    Friend WithEvents pbRed2 As PictureBox
    Friend WithEvents pbYellow As PictureBox
    Friend WithEvents pbYellow2 As PictureBox
    Friend WithEvents pbGreen As PictureBox
    Friend WithEvents pbGreen2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CheckBox1 As CheckBox
End Class
