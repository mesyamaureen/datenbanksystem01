Public Class frmHauptfensterKunde

    Private Sub frmHauptfensterKunde_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Deklaration
        Dim strBegruessungKunde As String
        Dim strVorname As String
        Dim strNachname As String

        'Initialisierung
        strVorname = Logic.AngemeldeteBenutzer.Item(0).Vorname
        strNachname = Logic.AngemeldeteBenutzer.Item(0).Name

        'eine Begrüßung wird aus Vorname und Nachname zusammengebaut
        strBegruessungKunde = "Willkommen " & strVorname & " " & strNachname & "! " & vbCrLf &
                              "Sie sind als Kunde angemeldet."

        'Ausgabe im Meldungsfenster
        MsgBox(strBegruessungKunde, MsgBoxStyle.OkOnly, "Willkommen")
    End Sub


    ''' <summary>
    ''' aktiviert oder deakt abhängig von der in der Tabelle Benutzer getroffenen Auswahl die Schaltflächen die zur Tabelle gehören
    ''' </summary>
    ''' <remarks> Tabelle = momentan nur Einfachauswahl </remarks>
    Protected Sub aktivierenSchaltflächen()
        'Deklaration
        Dim intAnzahlAusgewaehlterZeilen As Integer

        'Initialisierung
        intAnzahlAusgewaehlterZeilen = Me.lstviewWeiterbildungKunde.SelectedItems.Count

        'Schaltfläche zurücksetzen
        Me.btnOeffnen.Enabled = True

        'Abhängig von Anzahl der ausgewählten Zeilen ggf. Schaltflächen aktivieren
        If intAnzahlAusgewaehlterZeilen = 1 Then
            Me.btnOeffnen.Enabled = True 'kann geöffnet
        ElseIf intAnzahlAusgewaehlterZeilen > 1 Then
            Me.btnOeffnen.Enabled = False 'kann nicht geöffnet
        End If

    End Sub

    Sub leeren()
        'Liste leeren
        Me.lstviewWeiterbildungKunde.Items.Clear()
        'Schaltflächen aktivieren
        aktivierenSchaltflächen()
    End Sub

    ''' <summary>
    ''' Wird aufgerufen, um die Daten einer Weiterbldung in der Liste der Weiterbildung als Zeile anzuzeigen
    ''' </summary>
    ''' <remark> Als Parameter werden die einzelnen Werte der Attribute einer einzelnen Weiterbildung übergeben </remark>
    Sub anzeigenZeile(plngIndex As Long, pstrWeiterbilID As String, pstrWeiterbilName As String, pstrWeiterbilThema As String)

        'Neue Zeile in der Liste deklarieren
        Dim zeile As ListViewItem 'Alternativ Windows.Forms.ListViewItem

        'Auf den Inhalt der Liste zugreifen und neue Zeile erzeugen, indem
        'Index als Wert in der ersten Spalte eingetragen wird
        zeile = Me.lstviewWeiterbildungKunde.Items.Add(plngIndex)

        'Weitere Eigenschaften des benutzers in nachfolgenden Spalten der Zeile einfügen
        With zeile.SubItems
            .Add(pstrWeiterbilID)
            .Add(pstrWeiterbilName)
            .Add(pstrWeiterbilThema)
        End With

    End Sub

    ''' <summary>
    ''' Zeigt die Weiterbildung als Liste an, indem zunächst die Tabelle geleert und 
    ''' dann mit allen Einträgen aus der Liste der Weiterbildung neu gefüllt wird.
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub anzeigen()
        'Deklaration
        Dim weiterbil As Weiterbildung 'Weiterbildung

        'Anzuzeigende Attribute
        Dim strWeiterbilID As String
        Dim strWeiterbilName As String
        Dim strWeiterbilThema As String

        'leeren der Tabelle
        leeren()

        'Für jedes Element soll eine Zeile in der Tabelle hinzugefügt werden
        For i = 0 To mlstWeiterbildungen.Count - 1
            weiterbil = mlstWeiterbildungen.Item(i)

            'Attributwerte aus der Weiterbildung lesen
            strWeiterbilID = weiterbil.WeiterbildungsID
            strWeiterbilName = weiterbil.Bezeichnung
            strWeiterbilThema = weiterbil.Thema

            'Hinzufügen einer Zeile in der Tabelle mit den zuvor ermittelten Werten
            anzeigenZeile(i, strWeiterbilID, strWeiterbilName, strWeiterbilThema)

        Next
        ' In der Tabelle ist keine Zeile ausgewählt, deshalb die Schaltflächen deaktivieren, die eine ausgewählte Zeile erfordern
        aktivierenSchaltflächen()

    End Sub

    'Index deklarieren
    Public intIndex As Integer ' Index des ausgewählten Eintrags der Tabelle

    ''' <summary>
    ''' Schaltfläche Öffnen, um die ausgewählte Weiterbildung zu zeigen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOeffnen_Click(sender As Object, e As EventArgs) Handles btnOeffnen.Click
        'Deklaration
        Dim weiterbil As Weiterbildung  ' Zu bearbeitener Weiterbildung
        Dim dlg As frmWeiterbildungsfensterKunde  ' Detaildialog zum Anzeigen der Weiterbildung

        'aus der ausgewählten Zeile im Dialog die ID des Urlaubsantrags auslesen
        intIndex = Me.lstviewWeiterbildungKunde.SelectedItems(0).Text

        'Element an der Position der Liste, die der ID entspricht ermitteln
        weiterbil = Logic.mlstWeiterbildungen.Item(intIndex)

        'Fenster vorbereiten
        dlg = New frmWeiterbildungsfensterKunde(weiterbil)
        dlg.ShowDialog()

    End Sub

    ''' <summary>
    ''' Laden allen Weiterbildungen und füllen die Oberfläche mit den geladenen Daten
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub frmHauptfensterKunde_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Alle Weiterbildungen laden
        mlstWeiterbildungen = Logic.ListeWeiterbildung

        'Anzeigen der Weiterbildungen in der Tabelle
        anzeigen()

    End Sub

    ''' <summary>
    ''' Verlassen des Hauptfensters
    ''' </summary>
    Private Sub btnBeenden_Click(sender As Object, e As EventArgs) Handles btnBeenden.Click
        Me.Close()
    End Sub

    Private Sub btnBuchungen_Click(sender As Object, e As EventArgs) Handles btnBuchungen.Click
        Dim dlg As BuchungenKunde
        dlg = New BuchungenKunde()
        dlg.ShowDialog()
    End Sub



    Private Sub btnKonto_Click(sender As Object, e As EventArgs) Handles btnKonto.Click
        Dim dlg As frmKundeKonto
        dlg = New frmKundeKonto()
        dlg.ShowDialog()
    End Sub
End Class