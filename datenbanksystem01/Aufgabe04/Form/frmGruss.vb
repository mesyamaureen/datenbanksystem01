Public Class frmGruss
    Private Sub frmGruss_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Deklaration
        Dim strBegruessungKunde As String
        Dim strBegruessungMitarbeiter
        Dim strVorname As String
        Dim strNachname As String

        'Initialisierung
        'strVorname = Logic.AktuellAngemeldeterBenutzer.Vorname 'TODO: Uncomment
        'strNachname = Logic.AktuellAngemeldeterBenutzer.Nachname 'TODO: Uncomment
        'zwei verschiedene Begrüßungen werden aus Vorname und Nachname zusammengebaut
        strBegruessungKunde = "Willkommen " & strVorname & strNachname & "! " & vbCrLf &
                              "Sie sind als Kunde angemeldet."

        strBegruessungMitarbeiter = "Wilkommen " & strVorname & strNachname & "! " & vbCrLf &
                                    "Sie sind als Mitarbeiter angemeldet."

        'Ausgabe im Meldungsfenster 'TODO: Connection to the result of Login



    End Sub
End Class