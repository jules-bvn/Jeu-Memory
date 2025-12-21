Imports System.Drawing
Imports System.Windows.Forms

Public Class FormStatistique
    Private triDecroissant As Boolean = True

    Private Sub FormStatistiques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemplirListes()
        RemplirComboBox()
        lstScores.Enabled = False
        lstTempsMin.Enabled = False
        lstParties.Enabled = False
        lstTempsTotal.Enabled = False

        lstNoms.DrawMode = DrawMode.OwnerDrawFixed
        lstScores.DrawMode = DrawMode.OwnerDrawFixed
        lstTempsMin.DrawMode = DrawMode.OwnerDrawFixed
        lstParties.DrawMode = DrawMode.OwnerDrawFixed
        lstTempsTotal.DrawMode = DrawMode.OwnerDrawFixed
    End Sub
    Private Sub lstNoms_DrawItem(sender As Object, e As DrawItemEventArgs) Handles lstNoms.DrawItem, lstScores.DrawItem, lstTempsMin.DrawItem, lstParties.DrawItem, lstTempsTotal.DrawItem
        If e.Index < 0 Then Exit Sub
        Dim lb As ListBox = DirectCast(sender, ListBox)
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e.Graphics.FillRectangle(Brushes.Cyan, e.Bounds)
        Else
            e.Graphics.FillRectangle(Brushes.White, e.Bounds)
        End If
        e.Graphics.DrawString(lb.Items(e.Index).ToString(), e.Font, Brushes.Black, e.Bounds)
        e.DrawFocusRectangle()
    End Sub

    Private Sub RemplirListes()
        lstNoms.Items.Clear()
        lstScores.Items.Clear()
        lstTempsMin.Items.Clear()
        lstParties.Items.Clear()
        lstTempsTotal.Items.Clear()

        Dim joueursTries = If(triDecroissant,
            ListeJoueurs.OrderByDescending(Function(j) j.MeilleurScore).ThenBy(Function(j) j.TempsMinimum).ToList(),
            ListeJoueurs.OrderBy(Function(j) j.MeilleurScore).ThenByDescending(Function(j) j.TempsMinimum).ToList())

        For Each joueur In joueursTries
            lstNoms.Items.Add(joueur.Nom)
            lstScores.Items.Add(joueur.MeilleurScore)
            lstTempsMin.Items.Add(joueur.TempsMinimum & " s")
            lstParties.Items.Add(joueur.NombreParties)
            lstTempsTotal.Items.Add(joueur.TempsTotal & " s")
        Next
    End Sub

    Private Sub RemplirComboBox()
        cboJoueurs.Items.Clear()
        For Each joueur In ListeJoueurs
            cboJoueurs.Items.Add(joueur.Nom)
        Next
    End Sub

    Private Sub btnTrier_Click(sender As Object, e As EventArgs) Handles btnTrier.Click
        triDecroissant = Not triDecroissant
        btnTrier.Text = If(triDecroissant, "Trier par les Pire joueur ", "Trier par Meilleur joueur")
        RemplirListes()
    End Sub

    Private Sub lstNoms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNoms.SelectedIndexChanged
        SynchroniserListes(lstNoms.SelectedIndex)
        If lstNoms.SelectedIndex >= 0 Then
            cboJoueurs.SelectedItem = lstNoms.SelectedItem
        End If
    End Sub

    Private Sub lstScores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstScores.SelectedIndexChanged
        SynchroniserListes(lstScores.SelectedIndex)
    End Sub

    Private Sub lstTempsMin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTempsMin.SelectedIndexChanged
        SynchroniserListes(lstTempsMin.SelectedIndex)
    End Sub

    Private Sub lstParties_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstParties.SelectedIndexChanged
        SynchroniserListes(lstParties.SelectedIndex)
    End Sub

    Private Sub lstTempsTotal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTempsTotal.SelectedIndexChanged
        SynchroniserListes(lstTempsTotal.SelectedIndex)
    End Sub

    Private Sub SynchroniserListes(index As Integer)
        lstNoms.SelectedIndex = index
        lstScores.SelectedIndex = index
        lstTempsMin.SelectedIndex = index
        lstParties.SelectedIndex = index
        lstTempsTotal.SelectedIndex = index
    End Sub

    Private Sub btnAfficherStats_Click(sender As Object, e As EventArgs) Handles btnAfficherStats.Click
        If cboJoueurs.SelectedIndex >= 0 Then
            Dim nom As String = cboJoueurs.SelectedItem.ToString()
            Dim joueur = ListeJoueurs.Find(Function(j) j.Nom = nom)
            Dim message As String = $"Statistiques du joueur {joueur.Nom} :" & vbCrLf &
                                $"Meilleur Score : {joueur.MeilleurScore}" & vbCrLf &
                                $"Temps Minimum : {joueur.TempsMinimum} s" & vbCrLf &
                                $"Nombre de Parties : {joueur.NombreParties}" & vbCrLf &
                                $"Temps Total : {joueur.TempsTotal} s"
            Dim statForm As New Stat1Player
            statForm.Message = message
            statForm.ShowDialog()
        Else
            Dim statForm As New Stat1Player
            statForm.Message = "Veuillez sélectionner un joueur."
            statForm.ShowDialog()
        End If
    End Sub


End Class