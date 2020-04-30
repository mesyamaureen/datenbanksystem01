Public Class frmGruss
    Private Sub frmGruss_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Deklaration
        Dim strBegruessungKunde As String
        Dim strVorname As String
        Dim strNachname As String

        'Initialisierung
        strVorname = Logic.AktuellAngemeldeterBenutzer.strVorname
        strNachname = Logic.AktuellAngemeldeterBenutzer.strName

        'eine Begrüßung wird aus Vorname und Nachname zusammengebaut
        strBegruessungKunde = "Willkommen " & strVorname & " " & strNachname & "! " & vbCrLf &
                              "Sie sind als Kunde angemeldet."

        'Ausgabe im Meldungsfenster
        MsgBox(strBegruessungKunde, MsgBoxStyle.OkOnly, "Willkommen")



    End Sub

    Private Sub btnBeenden_Click(sender As Object, e As EventArgs) Handles btnBeenden.Click
        Me.Close()
    End Sub
End Class