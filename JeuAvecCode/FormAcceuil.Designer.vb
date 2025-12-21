<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAcceuil
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
        Me.ComboBoxName = New System.Windows.Forms.ComboBox()
        Me.btnJouer = New System.Windows.Forms.Button()
        Me.btnScore = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlLvl = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rd6carte = New System.Windows.Forms.RadioButton()
        Me.rd5carte = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDiv = New System.Windows.Forms.Label()
        Me.rd4carte = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rd2carte = New System.Windows.Forms.RadioButton()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.rdDifficile = New System.Windows.Forms.RadioButton()
        Me.rdMoyen = New System.Windows.Forms.RadioButton()
        Me.rdFacile = New System.Windows.Forms.RadioButton()
        Me.btnLvl = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlTheme = New System.Windows.Forms.Panel()
        Me.rdTciel = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdTevoli = New System.Windows.Forms.RadioButton()
        Me.rdTspatial = New System.Windows.Forms.RadioButton()
        Me.pnlLvl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlTheme.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxName
        '
        Me.ComboBoxName.Font = New System.Drawing.Font("Arial Black", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxName.FormattingEnabled = True
        Me.ComboBoxName.Location = New System.Drawing.Point(56, 104)
        Me.ComboBoxName.Name = "ComboBoxName"
        Me.ComboBoxName.Size = New System.Drawing.Size(234, 40)
        Me.ComboBoxName.TabIndex = 0
        '
        'btnJouer
        '
        Me.btnJouer.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnJouer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJouer.ForeColor = System.Drawing.Color.Navy
        Me.btnJouer.Image = Global.SAE_IHM.My.Resources.Resources.evolie_fond
        Me.btnJouer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnJouer.Location = New System.Drawing.Point(99, 150)
        Me.btnJouer.Name = "btnJouer"
        Me.btnJouer.Size = New System.Drawing.Size(191, 56)
        Me.btnJouer.TabIndex = 1
        Me.btnJouer.Text = "Jouer"
        Me.btnJouer.UseVisualStyleBackColor = True
        '
        'btnScore
        '
        Me.btnScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScore.ForeColor = System.Drawing.Color.Navy
        Me.btnScore.Image = Global.SAE_IHM.My.Resources.Resources.evolie_fond
        Me.btnScore.Location = New System.Drawing.Point(99, 212)
        Me.btnScore.Name = "btnScore"
        Me.btnScore.Size = New System.Drawing.Size(191, 56)
        Me.btnScore.TabIndex = 2
        Me.btnScore.Text = "Classement"
        Me.btnScore.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitter.ForeColor = System.Drawing.SystemColors.Control
        Me.btnQuitter.Image = Global.SAE_IHM.My.Resources.Resources.fond_bleu_et_rouge
        Me.btnQuitter.Location = New System.Drawing.Point(99, 274)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(191, 55)
        Me.btnQuitter.TabIndex = 3
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(22, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 85)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PokéMémo"
        '
        'pnlLvl
        '
        Me.pnlLvl.BackColor = System.Drawing.Color.Transparent
        Me.pnlLvl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlLvl.Controls.Add(Me.Panel2)
        Me.pnlLvl.Controls.Add(Me.Panel1)
        Me.pnlLvl.Controls.Add(Me.lblInstruction)
        Me.pnlLvl.Controls.Add(Me.rdDifficile)
        Me.pnlLvl.Controls.Add(Me.rdMoyen)
        Me.pnlLvl.Controls.Add(Me.rdFacile)
        Me.pnlLvl.Location = New System.Drawing.Point(296, 224)
        Me.pnlLvl.Name = "pnlLvl"
        Me.pnlLvl.Size = New System.Drawing.Size(605, 271)
        Me.pnlLvl.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rd6carte)
        Me.Panel2.Controls.Add(Me.rd5carte)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(336, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(244, 240)
        Me.Panel2.TabIndex = 8
        '
        'rd6carte
        '
        Me.rd6carte.Appearance = System.Windows.Forms.Appearance.Button
        Me.rd6carte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd6carte.ForeColor = System.Drawing.Color.Black
        Me.rd6carte.Location = New System.Drawing.Point(146, 78)
        Me.rd6carte.Name = "rd6carte"
        Me.rd6carte.Size = New System.Drawing.Size(95, 47)
        Me.rd6carte.TabIndex = 2
        Me.rd6carte.TabStop = True
        Me.rd6carte.Text = "6 Cartes"
        Me.rd6carte.UseVisualStyleBackColor = True
        '
        'rd5carte
        '
        Me.rd5carte.Appearance = System.Windows.Forms.Appearance.Button
        Me.rd5carte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd5carte.ForeColor = System.Drawing.Color.Black
        Me.rd5carte.Location = New System.Drawing.Point(19, 78)
        Me.rd5carte.Name = "rd5carte"
        Me.rd5carte.Size = New System.Drawing.Size(95, 47)
        Me.rd5carte.TabIndex = 1
        Me.rd5carte.TabStop = True
        Me.rd5carte.Text = "5 Cartes"
        Me.rd5carte.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 85)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Combien de carte voulez vous capturer ?"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblDiv)
        Me.Panel1.Controls.Add(Me.rd4carte)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.rd2carte)
        Me.Panel1.Location = New System.Drawing.Point(23, 145)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 124)
        Me.Panel1.TabIndex = 7
        '
        'lblDiv
        '
        Me.lblDiv.BackColor = System.Drawing.Color.Transparent
        Me.lblDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiv.ForeColor = System.Drawing.Color.DarkRed
        Me.lblDiv.Location = New System.Drawing.Point(27, 78)
        Me.lblDiv.Name = "lblDiv"
        Me.lblDiv.Size = New System.Drawing.Size(221, 31)
        Me.lblDiv.TabIndex = 7
        Me.lblDiv.Text = "Le score sera divisé par 3"
        '
        'rd4carte
        '
        Me.rd4carte.Appearance = System.Windows.Forms.Appearance.Button
        Me.rd4carte.AutoSize = True
        Me.rd4carte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd4carte.ForeColor = System.Drawing.Color.Green
        Me.rd4carte.Location = New System.Drawing.Point(127, 45)
        Me.rd4carte.Name = "rd4carte"
        Me.rd4carte.Size = New System.Drawing.Size(91, 30)
        Me.rd4carte.TabIndex = 6
        Me.rd4carte.TabStop = True
        Me.rd4carte.Text = "4 Cartes"
        Me.rd4carte.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(253, 42)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Combien de cartes identiques à trouver ?"
        '
        'rd2carte
        '
        Me.rd2carte.Appearance = System.Windows.Forms.Appearance.Button
        Me.rd2carte.AutoSize = True
        Me.rd2carte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd2carte.ForeColor = System.Drawing.Color.Green
        Me.rd2carte.Location = New System.Drawing.Point(30, 45)
        Me.rd2carte.Name = "rd2carte"
        Me.rd2carte.Size = New System.Drawing.Size(91, 30)
        Me.rd2carte.TabIndex = 5
        Me.rd2carte.TabStop = True
        Me.rd2carte.Text = "2 Cartes"
        Me.rd2carte.UseVisualStyleBackColor = True
        '
        'lblInstruction
        '
        Me.lblInstruction.BackColor = System.Drawing.Color.Aqua
        Me.lblInstruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.Location = New System.Drawing.Point(17, 48)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(273, 82)
        Me.lblInstruction.TabIndex = 3
        Me.lblInstruction.Text = "Label2"
        '
        'rdDifficile
        '
        Me.rdDifficile.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdDifficile.AutoSize = True
        Me.rdDifficile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDifficile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rdDifficile.Location = New System.Drawing.Point(191, 4)
        Me.rdDifficile.Name = "rdDifficile"
        Me.rdDifficile.Size = New System.Drawing.Size(85, 30)
        Me.rdDifficile.TabIndex = 2
        Me.rdDifficile.TabStop = True
        Me.rdDifficile.Text = "Difficile" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rdDifficile.UseVisualStyleBackColor = True
        '
        'rdMoyen
        '
        Me.rdMoyen.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdMoyen.AutoSize = True
        Me.rdMoyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdMoyen.ForeColor = System.Drawing.Color.Olive
        Me.rdMoyen.Location = New System.Drawing.Point(95, 3)
        Me.rdMoyen.Name = "rdMoyen"
        Me.rdMoyen.Size = New System.Drawing.Size(79, 30)
        Me.rdMoyen.TabIndex = 1
        Me.rdMoyen.TabStop = True
        Me.rdMoyen.Text = "Moyen "
        Me.rdMoyen.UseVisualStyleBackColor = True
        '
        'rdFacile
        '
        Me.rdFacile.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdFacile.AutoSize = True
        Me.rdFacile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdFacile.ForeColor = System.Drawing.Color.Green
        Me.rdFacile.Location = New System.Drawing.Point(3, 3)
        Me.rdFacile.Name = "rdFacile"
        Me.rdFacile.Size = New System.Drawing.Size(76, 30)
        Me.rdFacile.TabIndex = 0
        Me.rdFacile.TabStop = True
        Me.rdFacile.Text = "Facile "
        Me.rdFacile.UseVisualStyleBackColor = True
        '
        'btnLvl
        '
        Me.btnLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLvl.ForeColor = System.Drawing.Color.Navy
        Me.btnLvl.Image = Global.SAE_IHM.My.Resources.Resources.evolie_fond
        Me.btnLvl.Location = New System.Drawing.Point(296, 150)
        Me.btnLvl.Name = "btnLvl"
        Me.btnLvl.Size = New System.Drawing.Size(191, 56)
        Me.btnLvl.TabIndex = 7
        Me.btnLvl.Text = "Niveau"
        Me.btnLvl.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Image = Global.SAE_IHM.My.Resources.Resources.evolie_fond
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(99, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 56)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Theme"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pnlTheme
        '
        Me.pnlTheme.BackColor = System.Drawing.Color.Transparent
        Me.pnlTheme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTheme.Controls.Add(Me.rdTciel)
        Me.pnlTheme.Controls.Add(Me.Label3)
        Me.pnlTheme.Controls.Add(Me.rdTevoli)
        Me.pnlTheme.Controls.Add(Me.rdTspatial)
        Me.pnlTheme.Location = New System.Drawing.Point(296, 224)
        Me.pnlTheme.Name = "pnlTheme"
        Me.pnlTheme.Size = New System.Drawing.Size(318, 268)
        Me.pnlTheme.TabIndex = 9
        '
        'rdTciel
        '
        Me.rdTciel.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdTciel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rdTciel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdTciel.ForeColor = System.Drawing.Color.Black
        Me.rdTciel.Location = New System.Drawing.Point(23, 174)
        Me.rdTciel.Name = "rdTciel"
        Me.rdTciel.Size = New System.Drawing.Size(256, 35)
        Me.rdTciel.TabIndex = 4
        Me.rdTciel.TabStop = True
        Me.rdTciel.Text = "Fond Ciel Rosé"
        Me.rdTciel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(38, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Choisir un Theme"
        '
        'rdTevoli
        '
        Me.rdTevoli.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdTevoli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rdTevoli.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdTevoli.ForeColor = System.Drawing.Color.Black
        Me.rdTevoli.Location = New System.Drawing.Point(23, 117)
        Me.rdTevoli.Name = "rdTevoli"
        Me.rdTevoli.Size = New System.Drawing.Size(256, 35)
        Me.rdTevoli.TabIndex = 1
        Me.rdTevoli.TabStop = True
        Me.rdTevoli.Text = "Fond Evolie Bleu"
        Me.rdTevoli.UseVisualStyleBackColor = True
        '
        'rdTspatial
        '
        Me.rdTspatial.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdTspatial.BackColor = System.Drawing.Color.Transparent
        Me.rdTspatial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdTspatial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdTspatial.ForeColor = System.Drawing.Color.Black
        Me.rdTspatial.Location = New System.Drawing.Point(23, 62)
        Me.rdTspatial.Name = "rdTspatial"
        Me.rdTspatial.Size = New System.Drawing.Size(253, 37)
        Me.rdTspatial.TabIndex = 0
        Me.rdTspatial.TabStop = True
        Me.rdTspatial.Text = "Fond Spatial Bleu/Rouge"
        Me.rdTspatial.UseVisualStyleBackColor = False
        '
        'FormAcceuil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SAE_IHM.My.Resources.Resources.evolie_fond
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1035, 529)
        Me.Controls.Add(Me.pnlTheme)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLvl)
        Me.Controls.Add(Me.pnlLvl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnScore)
        Me.Controls.Add(Me.btnJouer)
        Me.Controls.Add(Me.ComboBoxName)
        Me.Name = "FormAcceuil"
        Me.Text = "FormAcceuil"
        Me.pnlLvl.ResumeLayout(False)
        Me.pnlLvl.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlTheme.ResumeLayout(False)
        Me.pnlTheme.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBoxName As Windows.Forms.ComboBox
    Friend WithEvents btnJouer As Windows.Forms.Button
    Friend WithEvents btnScore As Windows.Forms.Button
    Friend WithEvents btnQuitter As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents pnlLvl As Windows.Forms.Panel
    Friend WithEvents rdDifficile As Windows.Forms.RadioButton
    Friend WithEvents rdMoyen As Windows.Forms.RadioButton
    Friend WithEvents rdFacile As Windows.Forms.RadioButton
    Friend WithEvents btnLvl As Windows.Forms.Button
    Friend WithEvents lblInstruction As Windows.Forms.Label
    Friend WithEvents rd4carte As Windows.Forms.RadioButton
    Friend WithEvents rd2carte As Windows.Forms.RadioButton
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents lblDiv As Windows.Forms.Label
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents pnlTheme As Windows.Forms.Panel
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents rdTevoli As Windows.Forms.RadioButton
    Friend WithEvents rdTspatial As Windows.Forms.RadioButton
    Friend WithEvents rdTciel As Windows.Forms.RadioButton
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents rd6carte As Windows.Forms.RadioButton
    Friend WithEvents rd5carte As Windows.Forms.RadioButton
    Friend WithEvents Label4 As Windows.Forms.Label
End Class
