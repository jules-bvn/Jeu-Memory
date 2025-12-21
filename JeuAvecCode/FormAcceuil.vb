Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Public Class FormAcceuil
    Private Sub FormAcceuil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnJouer.Enabled = False
        ChargerJoueurs()
        rdFacile.Checked = True
        rdMoyen.Checked = False
        rdDifficile.Checked = False
        pnlLvl.Visible = False
        rd4carte.Checked = True
        pnlTheme.Visible = False
        rdTspatial.Checked = True
        rd5carte.Checked = True
    End Sub


    Private Sub quitterAcceuil(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Dim resultat As DialogResult = MessageBox.Show("Voulez vous vraiment quitter l'application ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultat = DialogResult.Yes Then
            SauvegarderJoueurs()
            Application.Exit()
        End If
    End Sub

    Private Sub verifierNomJoueur(sender As Object, e As EventArgs) Handles ComboBoxName.TextChanged
        If ComboBoxName.Text.Length < 3 Then
            btnJouer.Enabled = False
        Else
            btnJouer.Enabled = True
        End If
    End Sub

    Private Sub LancerPartie(sender As Object, e As EventArgs) Handles btnJouer.Click
        Dim NewPartie As New FormJeu
        NewPartie.NomJoueur = ComboBoxName.Text
        NewPartie.FormAcceuilInstance = Me
        If rdFacile.Checked Then
            NewPartie.niveau = 1
        ElseIf rdMoyen.Checked Then
            NewPartie.niveau = 2
        ElseIf rdDifficile.Checked Then
            NewPartie.niveau = 3
        End If
        If rd2carte.Checked Then
            NewPartie.nbCarteAtrv = 2
        ElseIf rd4carte.Checked Then
            NewPartie.nbCarteAtrv = 4
        End If

        If rdTspatial.Checked Then
            NewPartie.Theme = "BleuRouge"
        ElseIf rdTevoli.Checked Then
            NewPartie.Theme = "Evoli"
        ElseIf rdTciel.Checked Then
            NewPartie.Theme = "Ciel"
        End If

        If rd5carte.Checked Then
            NewPartie.nbCartePaire = 5
        ElseIf rd6carte.Checked Then
            NewPartie.nbCartePaire = 6
        End If

        NewPartie.Show()
        Me.Hide()
    End Sub

    Private Sub formStat(sender As Object, e As EventArgs) Handles btnScore.Click
        Dim formStats As New FormStatistique
        formStats.ShowDialog()
    End Sub


    Private Sub FormAcceuil_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SauvegarderJoueurs()
    End Sub


    Private Sub SauvegarderJoueurs()
        Try
            Dim cheminDossier As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SAE_IHM")
            Dim cheminFichier As String = Path.Combine(cheminDossier, "joueurs.txt")
            Directory.CreateDirectory(cheminDossier)
            Using writer As New StreamWriter(cheminFichier, False)
                For Each joueur In ListeJoueurs
                    writer.WriteLine($"{joueur.Nom};{joueur.MeilleurScore};{joueur.TempsMinimum};{joueur.NombreParties};{joueur.TempsTotal}")
                Next
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ChargerJoueurs()
        Try
            Dim cheminDossier As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SAE_IHM")
            Dim cheminFichier As String = Path.Combine(cheminDossier, "joueurs.txt")
            If File.Exists(cheminFichier) Then
                Dim lignes As String() = File.ReadAllLines(cheminFichier)
                If lignes.Length > 0 Then
                    ListeJoueurs.Clear()
                    For Each ligne In lignes
                        If String.IsNullOrWhiteSpace(ligne) Then Continue For
                        Dim champs As String() = ligne.Split(";"c)
                        If champs.Length = 5 Then
                            Try
                                Dim joueur As Joueur
                                joueur.Nom = champs(0).Trim()
                                joueur.MeilleurScore = Integer.Parse(champs(1))
                                joueur.TempsMinimum = Integer.Parse(champs(2))
                                joueur.NombreParties = Integer.Parse(champs(3))
                                joueur.TempsTotal = Integer.Parse(champs(4))
                                ListeJoueurs.Add(joueur)
                            Catch ex As FormatException
                            End Try
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub afficheLevel(sender As Object, e As EventArgs) Handles btnLvl.Click
        If pnlLvl.Visible Then
            pnlLvl.Visible = False
            pnlTheme.Visible = False
        Else
            pnlLvl.Visible = True
            pnlTheme.Visible = False
        End If
    End Sub

    Private Sub rdFacile_CheckedChanged(sender As Object, e As EventArgs) Handles rdFacile.CheckedChanged
        If rdFacile.Checked Then
            lblInstruction.Text = "60 seconde pour trouver le plus de carte identique (4 carte), chaque carte augmente le score de 1"
        End If
    End Sub

    Private Sub niveauMoyenInstruction(sender As Object, e As EventArgs) Handles rdMoyen.CheckedChanged
        If rdMoyen.Checked Then
            lblInstruction.Text = "30 seconde pour trouver le plus de carte identique (4 carte), chaque carte augmente le score de 2"
        End If
    End Sub

    Private Sub niveauDiffInstruction(sender As Object, e As EventArgs) Handles rdDifficile.CheckedChanged
        If rdDifficile.Checked Then
            lblInstruction.Text = "Vous avez 20 seconde pour trouver le plus de carte identique (4 carte) à chaque carte, le temps augmente de 10 seconde et le score de 5"
        End If
    End Sub

    Private Sub rd2carte_CheckedChanged(sender As Object, e As EventArgs) Handles rd2carte.CheckedChanged
        If rd2carte.Checked Then
            lblDiv.Visible = True
        End If
    End Sub

    Private Sub rd4carte_CheckedChanged(sender As Object, e As EventArgs) Handles rd4carte.CheckedChanged
        If rd4carte.Checked Then
            lblDiv.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If pnlTheme.Visible Then
            pnlTheme.Visible = False
            pnlLvl.Visible = False
        Else
            pnlTheme.Visible = True
            pnlLvl.Visible = False
        End If
    End Sub


End Class