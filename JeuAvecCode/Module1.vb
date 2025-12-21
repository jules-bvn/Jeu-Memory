Module ModuleJoueurs
    Public Structure Joueur
        Public Nom As String
        Public MeilleurScore As Integer
        Public TempsMinimum As Integer
        Public NombreParties As Integer
        Public TempsTotal As Integer
    End Structure

    Public ListeJoueurs As New List(Of Joueur)
End Module
