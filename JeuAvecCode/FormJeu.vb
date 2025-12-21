Imports System.Drawing
Imports System.Windows.Forms

Public Class FormJeu
    Public Property Theme As String
    Public Property niveau As Integer
    Public Property NomJoueur As String
    Public Property nbCarteAtrv As Integer
    Public Property nbCartePaire As Integer
    Public Property FormAcceuilInstance As FormAcceuil
    Private tempsRestant As Integer
    Private TempsDepart As Integer = 60
    Private isTimerStarted As Boolean = False
    Private carteImages As List(Of String)
    Private score As Integer = 0
    Private cartesRetournees As New List(Of Label)
    Private counte As Integer = 0
    Private scoreFinal As Integer
    Private tempsJeu As Integer
    Private Sub FormJeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tempsJeu = 0

        If Theme = "Evoli" Then
            Me.BackgroundImage = My.Resources.evolie_fond

        ElseIf Theme = "BleuRouge" Then
            Me.BackgroundImage = My.Resources.fond_bleu_et_rouge
        ElseIf Theme = "Ciel" Then
            Me.BackgroundImage = My.Resources.FondCielRosé
        End If
        Me.BackgroundImageLayout = ImageLayout.Stretch

        lblNomUser.Text = NomJoueur

        If niveau = 1 Then
            tempsRestant = 60
            If nbCarteAtrv = 2 Then
                If nbCartePaire = 5 Then
                    scoreFinal = 10
                ElseIf nbCartePaire = 6 Then
                    scoreFinal = 12
                End If
            ElseIf nbCarteAtrv = 4 Then
                If nbCartePaire = 5 Then
                    scoreFinal = 5
                ElseIf nbCartePaire = 6 Then
                    scoreFinal = 6
                End If
            End If

        ElseIf niveau = 2 Then
            tempsRestant = 40
            If nbCarteAtrv = 2 Then
                If nbCartePaire = 5 Then
                    scoreFinal = 20
                ElseIf nbCartePaire = 6 Then
                    scoreFinal = 24
                End If
            ElseIf nbCarteAtrv = 4 Then
                If nbCartePaire = 5 Then
                    scoreFinal = 10
                ElseIf nbCartePaire = 6 Then
                    scoreFinal = 12
                End If
            End If


        ElseIf niveau = 3 Then
            tempsRestant = 20
            If nbCarteAtrv = 2 Then
                If nbCartePaire = 5 Then
                    scoreFinal = 40
                ElseIf nbCartePaire = 6 Then
                    scoreFinal = 48
                End If
            ElseIf nbCarteAtrv = 4 Then
                If nbCartePaire = 5 Then
                    scoreFinal = 20
                ElseIf nbCartePaire = 6 Then
                    scoreFinal = 24
                End If
            End If
        End If


        lblTimer.Text = ""
        tmrJeu.Enabled = False
        Dim minutes As Integer = tempsRestant \ 60
        Dim secondes As Integer = tempsRestant Mod 60
        lblTimer.Text = String.Format("{0:D2}:{1:D2}", minutes, secondes)

        lblScore.Text = "Score : " & score
        carteImages = New List(Of String)()

        For i As Integer = 1 To nbCartePaire
            For j As Integer = 1 To 4
                carteImages.Add("carte" & i.ToString())
            Next
        Next

        If nbCartePaire = 5 Then
            pnlLabels.Visible = True
            pnlLabel2.Visible = False
        ElseIf nbCartePaire = 6 Then
            pnlLabel2.Visible = True
            pnlLabels.Visible = False
        End If

        Dim rand As New Random()
        carteImages = carteImages.OrderBy(Function(x) rand.Next()).ToList()

        If nbCartePaire = 5 Then
            Dim labels = pnlLabels.Controls.OfType(Of Label).ToList()
            For i As Integer = 0 To labels.Count - 1
                labels(i).BackgroundImage = My.Resources.DosCarte
                labels(i).BackgroundImageLayout = ImageLayout.Stretch
                labels(i).Text = ""
                labels(i).Tag = carteImages(i)
                AddHandler labels(i).Click, AddressOf Label_Click
            Next
        ElseIf nbCartePaire = 6 Then
            Dim labels = pnlLabel2.Controls.OfType(Of Label).ToList()
            For i As Integer = 0 To labels.Count - 1
                labels(i).BackgroundImage = My.Resources.DosCarte
                labels(i).BackgroundImageLayout = ImageLayout.Stretch
                labels(i).Text = ""
                labels(i).Tag = carteImages(i)
                AddHandler labels(i).Click, AddressOf Label_Click
            Next
        End If

    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs)

        If isTimerStarted = False Then
            tmrJeu.Enabled = True
            isTimerStarted = True
        End If

        Dim clickedLabel As Label = DirectCast(sender, Label)
        If cartesRetournees.Contains(clickedLabel) Then Exit Sub
        clickedLabel.BackgroundImage = My.Resources.ResourceManager.GetObject(clickedLabel.Tag.ToString())
        cartesRetournees.Add(clickedLabel)

        verfCarte()
        If score = scoreFinal Then
            tmrJeu.Enabled = False
            If nbCarteAtrv = 2 Then
                score = score / 3
            End If
            Dim dialog = MessageBox.Show("Bien jouer, partie finie en " & tempsJeu & "s et score = " & score, "fin de partie", MessageBoxButtons.OK)
            If dialog.OK Then
                enregistrerStat()
                quitterForm()
            End If
        End If
    End Sub

    Private Sub verfCarte()
        If cartesRetournees.Count = 0 Then
            Exit Sub
        End If
        Dim premCarte = cartesRetournees(0)
        If cartesRetournees.Count = 1 Then
            Exit Sub
        End If

        For Each carte As Label In cartesRetournees
            If Not (carte.Tag.ToString = premCarte.Tag.ToString) Then
                For Each test As Label In cartesRetournees
                    Dim t As New Timer()
                    t.Interval = 600
                    AddHandler t.Tick, Sub()
                                           t.Stop()
                                           t.Dispose()
                                           For Each lbl In cartesRetournees
                                               lbl.BackgroundImage = My.Resources.DosCarte
                                           Next
                                           cartesRetournees.Clear()
                                       End Sub
                    t.Start()
                    counte = 0
                Next
                Exit Sub
            End If
        Next
        counte = cartesRetournees.Count
        If cartesRetournees.Count = nbCarteAtrv AndAlso cartesRetournees.All(Function(c) c.Tag.ToString() = premCarte.Tag.ToString()) Then
            If niveau = 1 Then
                score += 1
            ElseIf niveau = 2 Then
                score += 2
            ElseIf niveau = 3 Then
                score += 4
                If nbCarteAtrv = 4 Then
                    tempsRestant += 10
                ElseIf nbCarteAtrv = 2 Then
                    tempsRestant += 5
                End If
            End If



            lblScore.Text = "Score : " & score
            cartesRetournees.Clear()
            counte = 0
        End If

    End Sub
    Private Sub tmrJeu_Tick(sender As Object, e As EventArgs) Handles tmrJeu.Tick
        tempsRestant -= 1
        tempsJeu += 1
        Dim minutes As Integer = tempsRestant \ 60
        Dim secondes As Integer = tempsRestant Mod 60

        lblTimer.Text = String.Format("{0:D2}:{1:D2}", minutes, secondes)
        If tempsRestant < 20 Then
            lblTimer.ForeColor = Color.Red
        End If
        If tempsRestant <= 0 Then
            tmrJeu.Enabled = False
            isTimerStarted = False
            If nbCarteAtrv = 2 Then
                score = score / 3
            End If
            Dim final = MessageBox.Show("Temps écoulé ! Scorer = " & score, "Fin du minuteur", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If final.OK Then
                enregistrerStat()
                quitterForm()
            End If
        End If
    End Sub

    Private Sub btnAbandon_Click(sender As Object, e As EventArgs) Handles btnAbandon.Click
        Dim result As DialogResult = MessageBox.Show("Voulez vous vraiment abandonnée ?", "abandon", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            tmrJeu.Enabled = False
            isTimerStarted = False
            If nbCarteAtrv = 2 Then
                score = score / 3
            End If
            enregistrerStat()
            quitterForm()
        End If
    End Sub

    Private Sub quitterForm()
        FormAcceuilInstance.Show()
        Me.Close()
    End Sub

    Private Sub enregistrerStat()
        ' Dim tempsJeu As Integer = Math.Max(0, TempsDepart - tempsRestant)
        Dim playerConnu As Boolean = False

        For i As Integer = 0 To ListeJoueurs.Count - 1
            If NomJoueur = ListeJoueurs(i).Nom Then
                Dim joueur = ListeJoueurs(i)
                joueur.NombreParties += 1
                joueur.TempsTotal += tempsJeu

                If score > joueur.MeilleurScore Then
                    joueur.MeilleurScore = score
                    joueur.TempsMinimum = tempsJeu
                ElseIf score = joueur.MeilleurScore AndAlso tempsJeu < joueur.TempsMinimum Then
                    joueur.TempsMinimum = tempsJeu
                End If
                ListeJoueurs(i) = joueur
                playerConnu = True
            End If
        Next

        If playerConnu = False Then
            Dim newJoueur As Joueur
            newJoueur.Nom = NomJoueur
            newJoueur.MeilleurScore = score
            newJoueur.TempsMinimum = tempsJeu
            newJoueur.NombreParties = 1
            newJoueur.TempsTotal = tempsJeu
            ListeJoueurs.Add(newJoueur)
        End If
    End Sub
End Class