Public Class BuchungenMitarbeiter
    Private Sub BuchungenMitarbeiter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strBuchungsID As String
        Dim strKurs As String
        Dim strWeiterbildung As String
        Dim strKundenID As String


        Dim lviZeile As ListViewItem
        lviZeile = LstViewAlleBuchungen.SelectedItems(0)

        strBuchungsID = lviZeile.SubItems(0).Text
        strKurs = lviZeile.SubItems(1).Text
        strWeiterbildung = lviZeile.SubItems(2).Text
        strKundenID = lviZeile.SubItems(3).Text

    End Sub

    ''' <remark> Als Parameter werden die einzelnen Werte der Attribute einer einzelnen Weiterbildung übergeben </remark>
    Sub anzeigenZeile(plngIndex As Long, pstrBuchgungsID As String, pstrKurs As String, pstrWeiterbildung As String, pstrKundenID As String)

        'Neue Zeile in der Liste deklarieren
        Dim zeile As ListViewItem 'Alternativ Windows.Forms.ListViewItem

        'Auf den Inhalt der Liste zugreifen und neue Zeile erzeugen, indem
        'Index als Wert in der ersten Spalte eingetragen wird
        zeile = Me.LstViewAlleBuchungen.Items.Add(plngIndex)

        'Weitere Eigenschaften des benutzers in nachfolgenden Spalten der Zeile einfügen
        With zeile.SubItems
            .Add(pstrBuchgungsID)
            .Add(pstrKurs)
            .Add(pstrWeiterbildung)
            .Add(pstrKundenID)
        End With

    End Sub


    ''' <summary>
    ''' Zeigt die Weiterbildung als Liste an, indem zunächst die Tabelle geleert und 
    ''' dann mit allen Einträgen aus der Liste der Kunden neu gefüllt wird.
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub anzeigen()
        'Deklaration
        Dim lviBuchung As Buchung 'Buchung

        'Anzuzeigende Attribute
        Dim strBuchungsID As String
        Dim strKurs As String
        Dim strWeiterbildung As String
        Dim strKundenID As String

        'leeren der Tabelle
        leeren()

        'Für jedes Element soll eine Zeile in der Tabelle hinzugefügt werden
        For i = 0 To mlstBuchung.Count - 1
            lviBuchung = mlstBuchung.Item(i)

            'Attributwerte aus der Weiterbildung lesen
            strBuchungsID = lviBuchung.BuchungsID
            strKurs = lviBuchung.mstrKursID
            strWeiterbildung = lviBuchung.mstrKursID
            strKundenID = lviBuchung.KundenID

            'Hinzufügen einer Zeile in der Tabelle mit den zuvor ermittelten Werten
            anzeigenZeile(i, strBuchungsID, strKurs, strWeiterbildung, strKundenID)

        Next
        ' In der Tabelle ist keine Zeile ausgewählt, deshalb die Schaltflächen deaktivieren, die eine ausgewählte Zeile erfordern


    End Sub

    Sub leeren()
        'Liste leeren
        Me.LstViewAlleBuchungen.Items.Clear()

    End Sub

    Private Sub lstviewKundenKonten_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstViewAlleBuchungen.SelectedIndexChanged

        'Muss Kunden aus mlstKunden laden
        anzeigen()


    End Sub


    Private Sub btnSchließen_Click(sender As Object, e As EventArgs) Handles btnSchließen.Click
        Me.Close() 'Dieses Dialogfenster schließen
        Exit Sub 'Prozedur verlassen damit die Anwendung hier endet
        frmHauptfensterMitarbeiter.Show() 'Zurück zum Hauptfenster des Mitarbeiters
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstViewAlleBuchungen.SelectedIndexChanged

    End Sub
End Class