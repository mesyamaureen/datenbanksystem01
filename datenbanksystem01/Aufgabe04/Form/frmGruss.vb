Public Class frmGruss
    Private Sub frmGruss_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Deklaration
        Dim strBegruessungKunde As String
        Dim strVorname As String
        Dim strNachname As String

        'Initialisierung
        strVorname = Logic.AktuellAngemeldeterBenutzer.strVorname
        strNachname = Logic.AktuellAngemeldeterBenutzer.strName

        'zwei verschiedene Begrüßungen werden aus Vorname und Nachname zusammengebaut
        strBegruessungKunde = "Willkommen " & strVorname & strNachname & "! " & vbCrLf &
                              "Sie sind als Kunde angemeldet."

        'Ausgabe im Meldungsfenster 'TODO: Connection to the result of Login
        MsgBox(strBegruessungKunde, MsgBoxStyle.OkOnly, "Wilkommen")



    End Sub
End Class