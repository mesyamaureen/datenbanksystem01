Public Class frmHauptfensterMitarbeiter

    Private Sub frmHauptfensterMitarbeiter_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Deklaration
        Dim strBegruessungMitarbeiter As String
        Dim strVorname As String
        Dim strNachname As String

        'Initialisierung
        strVorname = Logic.AktuellAngemeldeterBenutzer.strVorname
        strNachname = Logic.AktuellAngemeldeterBenutzer.strName

        'eine Begrüßung wird aus Vorname und Nachname zusammengebaut
        strBegruessungMitarbeiter = "Willkommen " & strVorname & " " & strNachname & "! " & vbCrLf &
                                    "Sie sind als Mitarbeiter angemeldet."

        'Anzeige der Begrüßung in einem Meldungsfenster
        MsgBox(strBegruessungMitarbeiter, MsgBoxStyle.OkOnly, "Willkommen")
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles grpboxWeiterbildung.Enter

    End Sub

    Private Sub btnBeenden_Click(sender As Object, e As EventArgs) Handles btnBeenden.Click
        Me.Close()
    End Sub
End Class