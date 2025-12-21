Imports System.Drawing

Public Class Stat1Player
    Public Property Message As String

    Private Sub Stat1Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMessage.Text = Message
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.ControlBox = False
        Me.BackColor = Color.FromArgb(173, 216, 230)
        btnOK.BackColor = Color.FromArgb(173, 216, 230)
        lblMessage.ForeColor = Color.Black
        lblMessage.Font = New Font("Segoe UI", 12, FontStyle.Regular)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub
End Class