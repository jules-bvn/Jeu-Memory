<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormJeu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNomUser = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAbandon = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.tmrJeu = New System.Windows.Forms.Timer(Me.components)
        Me.pnlLabels = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.pnlLabel2 = New System.Windows.Forms.Panel()
        Me.pnlLabels.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlLabel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(52, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Joueur :"
        '
        'lblNomUser
        '
        Me.lblNomUser.BackColor = System.Drawing.Color.Transparent
        Me.lblNomUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomUser.ForeColor = System.Drawing.Color.White
        Me.lblNomUser.Location = New System.Drawing.Point(128, 22)
        Me.lblNomUser.Name = "lblNomUser"
        Me.lblNomUser.Size = New System.Drawing.Size(78, 19)
        Me.lblNomUser.TabIndex = 3
        Me.lblNomUser.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(265, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Temps Restant : "
        '
        'btnAbandon
        '
        Me.btnAbandon.BackColor = System.Drawing.Color.White
        Me.btnAbandon.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbandon.ForeColor = System.Drawing.Color.DarkRed
        Me.btnAbandon.Location = New System.Drawing.Point(741, 16)
        Me.btnAbandon.Name = "btnAbandon"
        Me.btnAbandon.Size = New System.Drawing.Size(182, 29)
        Me.btnAbandon.TabIndex = 5
        Me.btnAbandon.Text = "Abandon"
        Me.btnAbandon.UseVisualStyleBackColor = False
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.Color.Transparent
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.White
        Me.lblTimer.Location = New System.Drawing.Point(407, 22)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(65, 20)
        Me.lblTimer.TabIndex = 6
        Me.lblTimer.Text = "Label2"
        '
        'tmrJeu
        '
        Me.tmrJeu.Interval = 1000
        '
        'pnlLabels
        '
        Me.pnlLabels.BackColor = System.Drawing.Color.Transparent
        Me.pnlLabels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlLabels.Controls.Add(Me.Label18)
        Me.pnlLabels.Controls.Add(Me.Label19)
        Me.pnlLabels.Controls.Add(Me.Label20)
        Me.pnlLabels.Controls.Add(Me.Label21)
        Me.pnlLabels.Controls.Add(Me.Label22)
        Me.pnlLabels.Controls.Add(Me.Label13)
        Me.pnlLabels.Controls.Add(Me.Label14)
        Me.pnlLabels.Controls.Add(Me.Label15)
        Me.pnlLabels.Controls.Add(Me.Label16)
        Me.pnlLabels.Controls.Add(Me.Label17)
        Me.pnlLabels.Controls.Add(Me.Label8)
        Me.pnlLabels.Controls.Add(Me.Label9)
        Me.pnlLabels.Controls.Add(Me.Label10)
        Me.pnlLabels.Controls.Add(Me.Label11)
        Me.pnlLabels.Controls.Add(Me.Label12)
        Me.pnlLabels.Controls.Add(Me.Label7)
        Me.pnlLabels.Controls.Add(Me.Label6)
        Me.pnlLabels.Controls.Add(Me.Label5)
        Me.pnlLabels.Controls.Add(Me.Label4)
        Me.pnlLabels.Controls.Add(Me.Label2)
        Me.pnlLabels.Location = New System.Drawing.Point(48, 87)
        Me.pnlLabels.Name = "pnlLabels"
        Me.pnlLabels.Size = New System.Drawing.Size(1060, 731)
        Me.pnlLabels.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(850, 544)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(189, 178)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Label18"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(666, 544)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(189, 178)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Label19"
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(486, 544)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(189, 178)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Label20"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(282, 544)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(189, 178)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Label21"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(74, 544)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(189, 178)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Label22"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(850, 366)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(189, 178)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Label13"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(666, 366)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(189, 178)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Label14"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(486, 366)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(189, 178)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Label15"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(282, 366)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(189, 178)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Label16"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(74, 366)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(189, 178)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Label17"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(850, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(189, 178)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(666, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(189, 178)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(486, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(189, 178)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(282, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(189, 178)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Label11"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(74, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(189, 178)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Label12"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(850, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 178)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Label7"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(666, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 178)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(486, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 178)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(282, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 178)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Label4"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(74, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 178)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "labelx"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(554, 22)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(65, 20)
        Me.lblScore.TabIndex = 8
        Me.lblScore.Text = "Label2"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblScore)
        Me.Panel1.Controls.Add(Me.lblTimer)
        Me.Panel1.Controls.Add(Me.btnAbandon)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblNomUser)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(117, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 69)
        Me.Panel1.TabIndex = 9
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(74, 188)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(189, 178)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "labelx"
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(282, 188)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(189, 178)
        Me.Label41.TabIndex = 1
        Me.Label41.Text = "Label41"
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(486, 188)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(189, 178)
        Me.Label40.TabIndex = 2
        Me.Label40.Text = "Label40"
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(666, 188)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(189, 178)
        Me.Label39.TabIndex = 3
        Me.Label39.Text = "Label39"
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(850, 188)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(189, 178)
        Me.Label38.TabIndex = 4
        Me.Label38.Text = "Label38"
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(74, 10)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(189, 178)
        Me.Label37.TabIndex = 5
        Me.Label37.Text = "Label37"
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(282, 10)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(189, 178)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "Label36"
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(486, 10)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(189, 178)
        Me.Label35.TabIndex = 7
        Me.Label35.Text = "Label35"
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(666, 10)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(189, 178)
        Me.Label34.TabIndex = 8
        Me.Label34.Text = "Label34"
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(850, 10)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(189, 178)
        Me.Label33.TabIndex = 9
        Me.Label33.Text = "Label33"
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(74, 366)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(189, 178)
        Me.Label32.TabIndex = 10
        Me.Label32.Text = "Label32"
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(282, 366)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(189, 178)
        Me.Label31.TabIndex = 11
        Me.Label31.Text = "Label31"
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(486, 366)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(189, 178)
        Me.Label30.TabIndex = 12
        Me.Label30.Text = "Label30"
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(666, 366)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(189, 178)
        Me.Label29.TabIndex = 13
        Me.Label29.Text = "Label29"
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(850, 366)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(189, 178)
        Me.Label28.TabIndex = 14
        Me.Label28.Text = "Label28"
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(74, 544)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(189, 178)
        Me.Label27.TabIndex = 15
        Me.Label27.Text = "Label27"
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(282, 544)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(189, 178)
        Me.Label26.TabIndex = 16
        Me.Label26.Text = "Label26"
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(486, 544)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(189, 178)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "Label25"
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(666, 544)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(189, 178)
        Me.Label24.TabIndex = 18
        Me.Label24.Text = "Label24"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(850, 544)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(189, 178)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "Label23"
        '
        'Label46
        '
        Me.Label46.Location = New System.Drawing.Point(1029, 190)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(189, 178)
        Me.Label46.TabIndex = 20
        Me.Label46.Text = "Label46"
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(1029, 12)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(189, 178)
        Me.Label45.TabIndex = 21
        Me.Label45.Text = "Label45"
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(1029, 368)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(189, 178)
        Me.Label44.TabIndex = 22
        Me.Label44.Text = "Label44"
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(1029, 546)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(189, 178)
        Me.Label43.TabIndex = 23
        Me.Label43.Text = "Label43"
        '
        'pnlLabel2
        '
        Me.pnlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.pnlLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlLabel2.Controls.Add(Me.Label43)
        Me.pnlLabel2.Controls.Add(Me.Label44)
        Me.pnlLabel2.Controls.Add(Me.Label45)
        Me.pnlLabel2.Controls.Add(Me.Label46)
        Me.pnlLabel2.Controls.Add(Me.Label23)
        Me.pnlLabel2.Controls.Add(Me.Label24)
        Me.pnlLabel2.Controls.Add(Me.Label25)
        Me.pnlLabel2.Controls.Add(Me.Label26)
        Me.pnlLabel2.Controls.Add(Me.Label27)
        Me.pnlLabel2.Controls.Add(Me.Label28)
        Me.pnlLabel2.Controls.Add(Me.Label29)
        Me.pnlLabel2.Controls.Add(Me.Label30)
        Me.pnlLabel2.Controls.Add(Me.Label31)
        Me.pnlLabel2.Controls.Add(Me.Label32)
        Me.pnlLabel2.Controls.Add(Me.Label33)
        Me.pnlLabel2.Controls.Add(Me.Label34)
        Me.pnlLabel2.Controls.Add(Me.Label35)
        Me.pnlLabel2.Controls.Add(Me.Label36)
        Me.pnlLabel2.Controls.Add(Me.Label37)
        Me.pnlLabel2.Controls.Add(Me.Label38)
        Me.pnlLabel2.Controls.Add(Me.Label39)
        Me.pnlLabel2.Controls.Add(Me.Label40)
        Me.pnlLabel2.Controls.Add(Me.Label41)
        Me.pnlLabel2.Controls.Add(Me.Label42)
        Me.pnlLabel2.Location = New System.Drawing.Point(12, 85)
        Me.pnlLabel2.Name = "pnlLabel2"
        Me.pnlLabel2.Size = New System.Drawing.Size(1321, 731)
        Me.pnlLabel2.TabIndex = 10
        '
        'FormJeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1417, 864)
        Me.Controls.Add(Me.pnlLabel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlLabels)
        Me.Name = "FormJeu"
        Me.Text = "FormJeu"
        Me.pnlLabels.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlLabel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As Windows.Forms.ContextMenuStrip
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents lblNomUser As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents btnAbandon As Windows.Forms.Button
    Friend WithEvents lblTimer As Windows.Forms.Label
    Friend WithEvents tmrJeu As Windows.Forms.Timer
    Friend WithEvents pnlLabels As Windows.Forms.Panel
    Friend WithEvents Label18 As Windows.Forms.Label
    Friend WithEvents Label19 As Windows.Forms.Label
    Friend WithEvents Label20 As Windows.Forms.Label
    Friend WithEvents Label21 As Windows.Forms.Label
    Friend WithEvents Label22 As Windows.Forms.Label
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents lblScore As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Label42 As Windows.Forms.Label
    Friend WithEvents Label41 As Windows.Forms.Label
    Friend WithEvents Label40 As Windows.Forms.Label
    Friend WithEvents Label39 As Windows.Forms.Label
    Friend WithEvents Label38 As Windows.Forms.Label
    Friend WithEvents Label37 As Windows.Forms.Label
    Friend WithEvents Label36 As Windows.Forms.Label
    Friend WithEvents Label35 As Windows.Forms.Label
    Friend WithEvents Label34 As Windows.Forms.Label
    Friend WithEvents Label33 As Windows.Forms.Label
    Friend WithEvents Label32 As Windows.Forms.Label
    Friend WithEvents Label31 As Windows.Forms.Label
    Friend WithEvents Label30 As Windows.Forms.Label
    Friend WithEvents Label29 As Windows.Forms.Label
    Friend WithEvents Label28 As Windows.Forms.Label
    Friend WithEvents Label27 As Windows.Forms.Label
    Friend WithEvents Label26 As Windows.Forms.Label
    Friend WithEvents Label25 As Windows.Forms.Label
    Friend WithEvents Label24 As Windows.Forms.Label
    Friend WithEvents Label23 As Windows.Forms.Label
    Friend WithEvents Label46 As Windows.Forms.Label
    Friend WithEvents Label45 As Windows.Forms.Label
    Friend WithEvents Label44 As Windows.Forms.Label
    Friend WithEvents Label43 As Windows.Forms.Label
    Friend WithEvents pnlLabel2 As Windows.Forms.Panel
End Class
