<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStatistique
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAfficherStats = New System.Windows.Forms.Button()
        Me.cboJoueurs = New System.Windows.Forms.ComboBox()
        Me.btnTrier = New System.Windows.Forms.Button()
        Me.lstNoms = New System.Windows.Forms.ListBox()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.lstTempsMin = New System.Windows.Forms.ListBox()
        Me.lstParties = New System.Windows.Forms.ListBox()
        Me.lstTempsTotal = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAfficherStats
        '
        Me.btnAfficherStats.Location = New System.Drawing.Point(432, 166)
        Me.btnAfficherStats.Name = "btnAfficherStats"
        Me.btnAfficherStats.Size = New System.Drawing.Size(176, 48)
        Me.btnAfficherStats.TabIndex = 1
        Me.btnAfficherStats.Text = "Rechercher " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stats du Joueur"
        Me.btnAfficherStats.UseVisualStyleBackColor = True
        '
        'cboJoueurs
        '
        Me.cboJoueurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboJoueurs.FormattingEnabled = True
        Me.cboJoueurs.Location = New System.Drawing.Point(411, 131)
        Me.cboJoueurs.Name = "cboJoueurs"
        Me.cboJoueurs.Size = New System.Drawing.Size(218, 28)
        Me.cboJoueurs.TabIndex = 2
        '
        'btnTrier
        '
        Me.btnTrier.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnTrier.Location = New System.Drawing.Point(374, 132)
        Me.btnTrier.Name = "btnTrier"
        Me.btnTrier.Size = New System.Drawing.Size(176, 46)
        Me.btnTrier.TabIndex = 3
        Me.btnTrier.Text = "Trier par Pire Joueur"
        Me.btnTrier.UseVisualStyleBackColor = False
        '
        'lstNoms
        '
        Me.lstNoms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNoms.FormattingEnabled = True
        Me.lstNoms.ItemHeight = 18
        Me.lstNoms.Location = New System.Drawing.Point(17, 32)
        Me.lstNoms.Name = "lstNoms"
        Me.lstNoms.Size = New System.Drawing.Size(157, 94)
        Me.lstNoms.TabIndex = 0
        '
        'lstScores
        '
        Me.lstScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.ItemHeight = 18
        Me.lstScores.Location = New System.Drawing.Point(204, 32)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(157, 94)
        Me.lstScores.TabIndex = 4
        '
        'lstTempsMin
        '
        Me.lstTempsMin.BackColor = System.Drawing.SystemColors.Window
        Me.lstTempsMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTempsMin.FormattingEnabled = True
        Me.lstTempsMin.ItemHeight = 18
        Me.lstTempsMin.Location = New System.Drawing.Point(383, 32)
        Me.lstTempsMin.Name = "lstTempsMin"
        Me.lstTempsMin.Size = New System.Drawing.Size(157, 94)
        Me.lstTempsMin.TabIndex = 5
        '
        'lstParties
        '
        Me.lstParties.BackColor = System.Drawing.SystemColors.Window
        Me.lstParties.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstParties.FormattingEnabled = True
        Me.lstParties.ItemHeight = 18
        Me.lstParties.Location = New System.Drawing.Point(576, 32)
        Me.lstParties.Name = "lstParties"
        Me.lstParties.Size = New System.Drawing.Size(157, 94)
        Me.lstParties.TabIndex = 6
        '
        'lstTempsTotal
        '
        Me.lstTempsTotal.BackColor = System.Drawing.SystemColors.Window
        Me.lstTempsTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTempsTotal.FormattingEnabled = True
        Me.lstTempsTotal.ItemHeight = 18
        Me.lstTempsTotal.Location = New System.Drawing.Point(767, 32)
        Me.lstTempsTotal.Name = "lstTempsTotal"
        Me.lstTempsTotal.Size = New System.Drawing.Size(157, 94)
        Me.lstTempsTotal.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Pseudo "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(218, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Meilleur Score"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(396, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Meilleur temps"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(572, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nombre de Parties"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(755, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Temps de Jeu Total"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnTrier)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lstTempsTotal)
        Me.Panel1.Controls.Add(Me.lstParties)
        Me.Panel1.Controls.Add(Me.lstTempsMin)
        Me.Panel1.Controls.Add(Me.lstScores)
        Me.Panel1.Controls.Add(Me.lstNoms)
        Me.Panel1.Location = New System.Drawing.Point(49, 280)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(994, 205)
        Me.Panel1.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("MV Boli", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(389, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(254, 55)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Classement"
        '
        'FormStatistique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImage = Global.SAE_IHM.My.Resources.Resources.ciel_étoile
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1075, 497)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cboJoueurs)
        Me.Controls.Add(Me.btnAfficherStats)
        Me.Name = "FormStatistique"
        Me.Text = "FormStatistique"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAfficherStats As Windows.Forms.Button
    Friend WithEvents cboJoueurs As Windows.Forms.ComboBox
    Friend WithEvents btnTrier As Windows.Forms.Button
    Friend WithEvents lstNoms As Windows.Forms.ListBox
    Friend WithEvents lstScores As Windows.Forms.ListBox
    Friend WithEvents lstTempsMin As Windows.Forms.ListBox
    Friend WithEvents lstParties As Windows.Forms.ListBox
    Friend WithEvents lstTempsTotal As Windows.Forms.ListBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Label6 As Windows.Forms.Label
End Class
