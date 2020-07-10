Public Class BuchungenKunde

    Protected Sub aktivierenSchaltflächen()
        ' Deklaration
        Dim intAnzahlAusgewaehlterZeilen As Integer ' Anzahl der ausgewählten Zeilen

        ' Initialisierung
        intAnzahlAusgewaehlterZeilen = Me.ListViewAktBuchungen.SelectedItems.Count ' Anzahl der Zeilen ermitteln

        ' Schatlfächen zurücksetzen
        Me.btnLoeschen.Enabled = False
        Me.btnLaden.Enabled = False

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

    Sub leeren()
        'Liste leeren
        Me.ListViewAktBuchungen.Items.Clear()
        'Schaltflächen aktivieren/deaktivieren
        aktivierenSchaltflächen()
    End Sub

    Sub anzeigenZeile(plngIndex As Long, pstrBuchungID As String, pdatKurs As Date, pstrWeiterbilName As String, pdecPreis As Decimal)

        'Neue Zeile in der Liste deklarieren
        Dim zeile As ListViewItem 'Alternativ Windows.Forms.ListViewItem

        'Auf den Inhalt der Liste zugreifen und neue Zeile erzeugen, indem
        'Index als Wert in der ersten Spalte eingetragen wird
        zeile = Me.ListViewAktBuchungen.Items.Add(plngIndex)

        'Weitere Eigenschaften des benutzers in nachfolgenden Spalten der Zeile einfügen
        With zeile.SubItems
            .Add(pstrBuchungID)
            .Add(pdatKurs)
            .Add(pstrWeiterbilName)
            .Add(pdecPreis)
        End With
    End Sub

    Private Sub anzeigen()
        'Deklaration
        Dim buchungen As Buchung

        'Anzuzeigende Attribute
        Dim strBuchungId As String
        Dim datKurs As Date
        Dim strWeiterbilName As String
        Dim decPreis As Decimal

        'leeren der Tabelle
        leeren()

        'Für jedes Element soll eine Zeile in der Tabelle hinzugefügt werden
        For i = 0 To ListeBuchung.Count - 1
            buchungen = ListeBuchung.Item(i)
            'Attributwerte aus der Buchung lesen
            strBuchungId = buchungen.BuchungsID
            datKurs = buchungen.BuchungsDatum 'Buchungsdatum als Kursdatum und Kursdatum von Attribute des Kurses, which has to be connected in Klasse Kurs
            strWeiterbilName = buchungen.Weiterbildung 'needs to be proved; is it possible to just connect the Weiterbildung with this Windows form?
            decPreis = buchungen.Preis
            'Hinzufügen einer Zeile in der Tabelle mit den zuvor ermittelten Werten
            anzeigenZeile(i, strBuchungId, datKurs, strWeiterbilName, decPreis)
        Next
        'In der Tabelle ist keine Zeile ausgewählt, deshalb die Schaltflächen deaktivieren, die eine ausgewählte Zeile erfordern
        aktivierenSchaltflächen()
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Dim msgErgebnis As MsgBoxResult

        msgErgebnis = MsgBox("Möchten Sie wirklich abbrechen? Ihre ungespeicherte Änderungen werden verwirft.", vbQuestion + vbYesNo, "Abbrechen")

        If msgErgebnis = vbNo Then
            DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
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
        'Deklaration
        'Zu bearbeitener Weiterbildung
        'Detaildialog zum Anzeigen der Weiterbildung
        'aus der ausgewählten Zeile im Dialog die ID des Urlaubsantrags auslesen
        'Element an der Position der Liste, die der ID entspricht ermitteln
        'Fenster vorbereiten
        'Auswertung des Dialogergebnisses
        'Dialog mit positivem Ergebnis geschlossen
        'Fensterinhalt aktualisieren, so dass Tabelle auch die Änderungen des Benutzers zeigt
    End Sub

    Private Sub txtKundenID_TextChanged(sender As Object, e As EventArgs) Handles txtKundenID.TextChanged

        txtKundenID = Me.txtKundenID


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

    Private Sub BuchungenKunde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Alle Buchungen laden
        mlstBuchung = Logic.mlstBuchung
        'Anzeigen der Buchungen in der Tabelle
        anzeigen()
    End Sub


End Class