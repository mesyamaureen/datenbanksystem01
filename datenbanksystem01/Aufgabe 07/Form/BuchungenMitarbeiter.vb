Public Class BuchungenMitarbeiter
    ''' <summary>
    ''' Tabelle leeren
    ''' </summary>
    Sub leeren()
        'Liste leeren
        Me.LstViewAlleBuchungen.Items.Clear()
    End Sub

    ''' <summary>
    ''' Wird aufgerufen, um die Daten aller Buchungen in der Liste der Buchungen als Zeile anzuzeigen
    ''' </summary>
    ''' <param name="uintBuchungIDM"></param>
    ''' <param name="pdatKursM"></param>
    ''' <param name="pstrWeiterbilNameM"></param>
    ''' <param name="uintBenutzerIDM"></param>
    ''' <param name="pstrKundenBenutzername"></param>
    Sub anzeigenZeile(uintBuchungIDM As UInteger, pstrKundenBenutzername As String, uintBenutzerIDM As UInteger, pstrWeiterbilNameM As String, pdatKursM As Date, puintKursID As UInteger)

        'Neue Zeile in der Liste deklarieren
        Dim zeile As ListViewItem 'Alternativ Windows.Forms.ListViewItem

        'Auf den Inhalt der Liste zugreifen und neue Zeile erzeugen, indem
        'Index als Wert in der ersten Spalte eingetragen wird
        zeile = Me.LstViewAlleBuchungen.Items.Add(uintBuchungIDM)

        'Weitere Eigenschaften des benutzers in nachfolgenden Spalten der Zeile einfügen
        With zeile.SubItems
            .Add(pstrKundenBenutzername)
            .Add(uintBenutzerIDM)
            .Add(pstrWeiterbilNameM)
            .Add(pdatKursM)
            .Add(puintKursID)
        End With

    End Sub

    ''' <remark> Als Parameter werden die einzelnen Werte der Attribute einer einzelnen Weiterbildung übergeben </remark>
    ''' <summary>
    ''' Zeigt die Weiterbildung als Liste an, indem zunächst die Tabelle geleert und 
    ''' dann mit allen Einträgen aus der Liste der Kunden neu gefüllt wird.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub anzeigen()
        'leeren der Tabelle
        leeren()

        'Für jedes Element soll eine Zeile in der Tabelle hinzugefügt werden
        For i = 0 To ListeBuchung.Count - 1
            Dim lviBuchung As Buchung = ListeBuchung.Item(i)

            'Attributwerte aus der Weiterbildung lesen
            Dim uintBuchungsID As UInteger = lviBuchung.BuchungsID
            Dim strWeiterbildung As String = lviBuchung.gebuchterKurs.Weiterbildung.Bezeichnung
            Dim uintBenutzerID As UInteger = lviBuchung.Teilnehmer.BenutzerID
            Dim datKurs As Date = lviBuchung.gebuchterKurs.Zeitpunkt
            Dim strKndBenutzername As String = lviBuchung.Teilnehmer.Benutzername
            Dim uintKursID As UInteger = lviBuchung.gebuchterKurs.KursID

            'Hinzufügen einer Zeile in der Tabelle mit den zuvor ermittelten Werten
            anzeigenZeile(uintBuchungsID, strKndBenutzername, uintBenutzerID, strWeiterbildung, datKurs, uintKursID)
        Next
    End Sub
    'Schließen Schaltfläche zum Verlassen des Fensters
    Private Sub btnSchließen_Click(sender As Object, e As EventArgs) Handles btnSchließen.Click
        'Nichts zu tun, Standardverhalten
    End Sub

    ''' <summary>
    ''' Beim Laden des Dialogfensters
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BuchungenMitarbeiter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'anzeigen der Buchungen in der Tabelle
        anzeigen()
    End Sub

End Class