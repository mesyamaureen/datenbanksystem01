Public Class BuchungenKunde

    ''' <summary>
    ''' aktiviert oder deakt abhängig von der in der Tabelle Benutzer getroffenen Auswahl die Schaltflächen die zur Tabelle gehören
    ''' </summary>
    Protected Sub aktivierenSchaltflächen()
        ' Deklaration
        ' Initialisierung
        Dim intAnzahlAusgewaehlterZeilen As Integer = Me.ListViewAktBuchungen.SelectedItems.Count ' Anzahl der Zeilen ermitteln

        ' Abhängig von Anzahl der ausgewählten Zeilen ggf. Schaltflächen aktivieren
        If intAnzahlAusgewaehlterZeilen = 1 Then
            ' Wenn genau eine Zeile ausgewählt ist
            Me.btnLoeschen.Enabled = True ' kann man diese löschen

        ElseIf intAnzahlAusgewaehlterZeilen <> 1 Then
            Me.btnLoeschen.Enabled = False ' kann man sie nicht löschen
        End If

    End Sub
    Sub leeren()
        'Liste leeren
        Me.ListViewAktBuchungen.Items.Clear()
        'Schaltflächen aktivieren/deaktivieren
        aktivierenSchaltflächen()
    End Sub

    ''' <summary>
    ''' Wird aufgerufen, um die Daten einer Buchung in der Liste der buchung als Zeile anzuzeigen
    ''' </summary>
    ''' <param name="plngIndex"></param>
    ''' <param name="pstrBuchungID"></param>
    ''' <param name="pdatKurs"></param>
    ''' <param name="pstrWeiterbilName"></param>
    ''' <param name="pdecPreis"></param>
    Sub anzeigenZeile(plngIndex As Long, pstrBuchungID As String, pdatKurs As Date, pstrWeiterbilName As String, pdecPreis As Decimal) ', pstrOrt As String)

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
            '.Add(pstrOrt)
        End With
    End Sub

    ''' <summary>
    ''' Zeigt die Buchung als Liste an, indem zunächst die Tabelle geleert und
    ''' dann mit allen Einträgen aus der Liste der Buchung neu gefüllt wird.
    ''' </summary>
    Private Sub anzeigen()
        'Deklaration
        Dim buchungen As Buchung

        'Anzuzeigende Attribute
        Dim strBuchungId As String
        Dim datKurs As Date
        Dim strWeiterbilName As String
        Dim decPreis As Decimal
        'Dim strOrt As String

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
            'strOrt = buchungen.Ort
            'Hinzufügen einer Zeile in der Tabelle mit den zuvor ermittelten Werten
            anzeigenZeile(i, strBuchungId, datKurs, strWeiterbilName, decPreis)
        Next
        'In der Tabelle ist keine Zeile ausgewählt, deshalb die Schaltflächen deaktivieren, die eine ausgewählte Zeile erfordern
        aktivierenSchaltflächen()
    End Sub

    ''' <summary>
    ''' Abbrechen Schaltfläche
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Dim msgErgebnis As MsgBoxResult

        msgErgebnis = MsgBox("Möchten Sie wirklich abbrechen? Ihre ungespeicherte Änderungen werden verwirft.", vbQuestion + vbYesNo, "Abbrechen")

        If msgErgebnis = vbNo Then
            DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        End If
    End Sub

    ''' <summary>
    ''' Laden Schaltfläche
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>


    Private Sub txtKundenID_TextChanged(sender As Object, e As EventArgs) Handles txtKundenID.TextChanged

        txtKundenID = Me.txtKundenID


    End Sub

    Private Sub btnLoeschen_Click(sender As Object, e As EventArgs) Handles btnLoeschen.Click
        ' Deklaration
        ' Index des ausgewählten Eintrags der Tabelle
        Dim intIndex As Integer
        Dim buch As Buchung
        Dim msgErgebnis As MsgBoxResult

        ' Ausbaustufe1: Ergebnis der Warnmeldung, ob wirklich gelöscht werden soll
        ' Ausbaustufe2: Zu löschender Benutzer

        ' aus der ausgwählten Zeile im Dialog die ID der Buchung auslesen
        intIndex = Me.ListViewAktBuchungen.SelectedItems(0).Text

        ' Ausbaustufe 2: Element an der Position der Liste, die der ID entspricht ermitteln
        buch = mlstBuchung.Item(intIndex)

        ' Rückfrage mit Warnmeldung
        msgErgebnis = MsgBox("Möchten Sie Ihre Buchung wirklich löschen?", vbQuestion + vbYesNo, "Abbrechen")

        If msgErgebnis = vbNo Then
            DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        Else
            Me.Close()
        End If

        ' Benzter löschen
        mlstBuchung.RemoveAt(intIndex) ' aus Liste aller Benutzer entfernen
        buch = Nothing ' Referenz auf Benutzer auf Nichts setzen, um Müllabfuhr anzuforder

        ' Fensterinhalt aktualisieren, so dass Tabelle den gelöschten Benutzer nicht mehr zeigt
        anzeigen()

    End Sub

    Private Sub BuchungenKunde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Alle Buchungen laden
        ListeBuchung = Logic.ListeBuchung
        'Anzeigen der Buchungen in der Tabelle
        anzeigen()
    End Sub

    Private Sub ListViewAktBuchungen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewAktBuchungen.SelectedIndexChanged
        ' Deklaration
        ' Initialisierung
        Dim intAnzahlAusgewaehlterZeilen As Integer = Me.ListViewAktBuchungen.SelectedItems.Count ' Anzahl der Zeilen ermitteln

        ' Abhängig von Anzahl der ausgewählten Zeilen ggf. Schaltflächen aktivieren
        If intAnzahlAusgewaehlterZeilen = 1 Then
            ' Wenn genau eine Zeile ausgewählt ist
            Me.btnLoeschen.Enabled = True ' kann man diese löschen oder bearbeiten
        ElseIf intAnzahlAusgewaehlterZeilen <> 1 Then
            Me.btnLoeschen.Enabled = False ' kann man sie nicht löschen
        End If
    End Sub
End Class
