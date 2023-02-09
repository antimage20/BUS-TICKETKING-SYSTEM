Imports System.Windows

Public Class Login_Form
    'Login Form
    Dim attempt As Integer = 0
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        GroupBox1.BackColor = Color.FromArgb(100, 0, 0, 0)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "Admin" And txtPassword.Text = "@Admin12" Then
            MsgBox("Login Successfully", MsgBoxStyle.Information, "Admin Login")
            Form1.Show()
            Passengers_view.Show()
            Me.Hide()

        Else
            txtPassword.Text = ""
            txtUsername.Clear()
            txtUsername.Focus()
            attempt += 1
            MsgBox("Incorrect Please Try Again", MsgBoxStyle.Information, "WARNING")
            If attempt = 3 Then
                txtUsername.Enabled = False
                txtPassword.Enabled = False
                btnLogin.Enabled = False
                btnCancel.Enabled = False
                MsgBox("You already have 3 attempts, Please Restart The System And Try Again", MsgBoxStyle.Information, "ERROR")
            End If
                End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If pbRed.Visible Then
            pbRed.Visible = False
            pbYellow.Visible = True
            pbGreen.Visible = False

        ElseIf pbYellow.Visible Then
            pbRed.Visible = False
            pbYellow.Visible = False
            pbGreen.Visible = True

        ElseIf pbGreen.Visible Then
            pbRed.Visible = True
            pbYellow.Visible = False
            pbGreen.Visible = False

        End If

        If pbRed2.Visible Then
            pbRed2.Visible = False
            pbYellow2.Visible = True
            pbGreen2.Visible = False

        ElseIf pbYellow2.Visible Then
            pbRed2.Visible = False
            pbYellow2.Visible = False
            pbGreen2.Visible = True

        ElseIf pbGreen2.Visible Then
            pbRed2.Visible = True
            pbYellow2.Visible = False
            pbGreen2.Visible = False

        End If
    End Sub

    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer1.Interval = 800
        pbRed.Visible = True
        pbYellow.Visible = False
        pbGreen.Visible = False

        pbRed2.Visible = True
        pbYellow2.Visible = False
        pbGreen2.Visible = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub



    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If txtPassword.Text.Length >= 8 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MsgBox("Password Should Not Be More Than 8 Characters", MsgBoxStyle.Information, "Notification")
            End If
        End If
    End Sub


End Class