Public Class BuchungenKunde
    Private Sub BuchungenKunde_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Protected Sub aktivierenSchaltflächen()
        ' Deklaration
        Dim intAnzahlAusgewaehlterZeilen As Integer ' Anzahl der ausgewählten Zeilen

        ' Initialisierung
        intAnzahlAusgewaehlterZeilen = Me.ListViewAktBuchungen.SelectedItems.Count ' Anzahl der Zeilen ermitteln

        ' Schatlfächen zurücksetzen
        Me.btnLoeschen.Enabled = False
        Me.btnLaden.Enabled = False
        Me.btnHinzufuegenBuchung.Enabled = True

        ' Abhängig von Anzahl der ausgewählten Zeilen ggf. Schaltflächen aktivieren
        If intAnzahlAusgewaehlterZeilen = 1 Then
            ' Wenn genau eine Zeile ausgewählt ist
            Me.btnLoeschen.Enabled = True ' kann man diese löschen oder bearbeiten
            Me.btnLaden.Enabled = True
        ElseIf intAnzahlAusgewaehlterZeilen > 1 Then
            Me.btnLoeschen.Enabled = False ' kann man sie nicht löschen 
            Me.btnLaden.Enabled = False ' und nicht bearbeiten
        End If
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        'Deklaration das Ergebnis des MsgBox
        Dim msgResult As MsgBoxResult
        'Initialisierung für das Ergebnis zwischen Ja und Nein
        msgResult = MsgBox("Möchten Sie wirklich abbrechen? Ihre ungespeicherte Änderungen werden verworfen.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        'Verzweigung des Ergebnisses
        'Ergebnis: JA
        If msgResult = vbYes Then
            Me.Close() 'Dialogfenster von BuchungenKunde schließen
            Exit Sub 'Prozedur verlassen
            frmHauptfensterKunde.Show() 'HauptfensterKunde öffnen
            'Ergebnis: NEIN
        Else
            Return 'Zurück zum Fenster BuchungenKunde
        End If
    End Sub
    Private Sub hinzufuegen(pintBuchungsID As Integer, pstrKurs As Kurs, pstrWeiterbildung As Weiterbildung)

        Dim zeile As Windows.Forms.ListViewItem
        zeile = Me.ListViewAktBuchungen.Items.Add(1)
        zeile.SubItems.Add(2)
        zeile.SubItems.Add(3)
    End Sub


    Private Sub ListViewAktBuchungen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewAktBuchungen.SelectedIndexChanged

        If ListViewAktBuchungen.SelectedItems.Count > 0 Then
            btnLaden.Enabled = True
        Else
            btnLaden.Enabled = False
        End If

    End Sub

    Private Sub btnLaden_Click(sender As Object, e As EventArgs) Handles btnLaden.Click

        Dim intBuchungsID As Integer
        Dim strKurs As String
        Dim strWeiterbildungen As String

        Dim lviZeile As ListViewItem
        lviZeile = ListViewAktBuchungen.SelectedItems(0)

        intBuchungsID = Integer.Parse(lviZeile.SubItems(0).Text)
        strKurs = lviZeile.SubItems(1).Text
        strWeiterbildungen = lviZeile.SubItems(2).Text
    End Sub

    Private Sub txtKundenID_TextChanged(sender As Object, e As EventArgs) Handles txtKundenID.TextChanged

        txtKundenID = Me.txtKundenID


    End Sub

    Private Sub btnHinzufuegenBuchung_Click(sender As Object, e As EventArgs) Handles btnHinzufuegenBuchung.Click

    End Sub

    Private Sub btnLoeschen_Click(sender As Object, e As EventArgs) Handles btnLoeschen.Click
        ' Deklaration
        ' Index des ausgewählten Eintrags der Tabelle   
        Dim intIndex As Integer
        ' Ausbaustufe1: Ergebnis der Warnmeldung, ob wirklich gelöscht werden soll
        ' Ausbaustufe2: Zu löschender Benutzer

        ' aus der ausgwählten Zeile im Dialog die ID des Urlaubsantrags auslesen
        intIndex = Me.ListViewAktBuchungen.SelectedItems(0).Text

        ' Ausbaustufe 2: Element an der Position der Liste, die der ID entspricht ermitteln


        ' Ausbaustufe 1: Rückfrage mit Warnmeldung und in Ausbaustufe 2 mit Angaben des Benutzers

        ' Benzter löschen
        Aufgabe_07.ListeMitarbeiter.RemoveAt(intIndex)
        ' aus Liste aller Benutzer entfernen

        ' Referenz auf Benutzer auf Nichts setzen, um Müllabfuhr anzufordern

        ' Fensterinhalt aktualisieren, so dass Tabelle den gelöschten Benutzer nicht mehr zeigt

        'anzeigen()
    End Sub
End Class