Public Class frmHauptfensterMitarbeiter

    Private Sub frmHauptfensterMitarbeiter_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Deklaration
        Dim strBegruessungMitarbeiter As String
        Dim strVorname As String
        Dim strNachname As String

        'Initialisierung
        strVorname = Logic.AngemeldeteBenutzer.Item(0).Vorname
        strNachname = Logic.AngemeldeteBenutzer.Item(0).Name

        'eine Begrüßung wird aus Vorname und Nachname zusammengebaut
        strBegruessungMitarbeiter = "Willkommen " & strVorname & " " & strNachname & "! " & vbCrLf &
                                    "Sie sind als Mitarbeiter angemeldet."

        'Anzeige der Begrüßung in einem Meldungsfenster
        MsgBox(strBegruessungMitarbeiter, MsgBoxStyle.OkOnly, "Willkommen")
    End Sub

    ''' <summary>
    ''' aktiviert oder deakt abhängig von der in der Tabelle Benutzer getroffenen Auswahl die Schaltflächen die zur Tabelle gehören
    ''' </summary>
    ''' <remarks> Tabelle = momentan nur Einfachauswahl </remarks>
    Protected Sub aktivierenSchaltflächen()
        'Deklaration
        Dim intAnzahlAusgewaehlterZeilen As Integer

        'Initialisierung
        intAnzahlAusgewaehlterZeilen = Me.lstviewWeiterbildungenM.SelectedItems.Count

        'Schaltfläche zurücksetzen
        Me.btnOeffnenM.Enabled = False
        Me.btnHinzufuegen.Enabled = True
        Me.btnLoeschen.Enabled = False

        'Abhängig von Anzahl der ausgewählten Zeilen ggf. Schaltflächen aktivieren
        If intAnzahlAusgewaehlterZeilen = 1 Then
            Me.btnOeffnenM.Enabled = True 'kann geöffnet oder löschen
            Me.btnLoeschen.Enabled = True
        ElseIf intAnzahlAusgewaehlterZeilen > 1 Then
            Me.btnOeffnenM.Enabled = False 'kann nicht geöffnet oder gelöscht
            Me.btnLoeschen.Enabled = False
        End If

    End Sub

    ''' <summary>
    ''' Leert die Liste mit den Urlaubsanträgen komplett. Weil nach dem leeren keine Auswahl in der Liste mehr getroffen ist,
    ''' setzt den Status des Formulars zurük, z.B. deaktiviert sie die Schaltflächen Bearbeiten und Löschen
    ''' </summary>
    Sub leeren()
        'Liste leeren
        Me.lstviewWeiterbildungenM.Items.Clear()
        'Schaltflächen aktivieren/deaktivieren
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
        zeile = Me.lstviewWeiterbildungenM.Items.Add(plngIndex)

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

    ''' <summary>
    ''' Laden allen Weiterbildungen mit und füllen die Oberfläche mit den geladenen Daten
    ''' </summary>
    Private Sub frmHauptfensterMitarbeiter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Alle Weiterbildungen laden
        mlstWeiterbildungen = Logic.mlstWeiterbildungen

        'Anzeigen der Weiterbildungen in der Tabelle
        anzeigen()

    End Sub

    ''' <summary>
    ''' Verlassen des Hauptfensters
    ''' </summary>

    Private Sub btnBeendenProgramm_Click(sender As Object, e As EventArgs) Handles btnBeendenProgramm.Click
        Me.Close()
    End Sub

    Private Sub MenuStripBuchungen_Click(sender As Object, e As EventArgs)
        Me.Close() 'Hauptfenster Mitarbeiter schließen

        BuchungenMitarbeiter.ShowDialog() 'Dialogfenster BuchungenMitarbeiter öffnen
    End Sub

    Private Sub lstviewWeiterbildungenM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstviewWeiterbildungenM.SelectedIndexChanged

    End Sub

    Private Sub btnBuchungenM_Click(sender As Object, e As EventArgs) Handles btnBuchungenM.Click

    End Sub

    ''' <summary>
    ''' Klick auf Öffnen bzw. Bearbeiten öffnet den aktuell in der Tabelle ausgewählten Benutzer in einem Detaildialog.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOeffnenM_Click(sender As Object, e As EventArgs) Handles btnOeffnenM.Click
        'Deklaration
        ' Index des ausgewählten Eintrags der Tabelle
        Dim intIndex As Integer
        ' Zu bearbeitener Weiterbildung
        Dim weiterbil As Weiterbildung
        ' Detaildialog zum Anzeigen der Weiterbildung
        Dim dlg As frmWeiterbildungsfensterMitarb


        'aus der ausgewählten Zeile im Dialog die ID des Urlaubsantrags auslesen
        intIndex = Me.lstviewWeiterbildungenM.SelectedItems(0).Text

        'Element an der Position der Liste, die der ID entspricht ermitteln
        weiterbil = erzeugeBeispieldaten.erzeugeBeispieldaten.Item(intIndex)

        'Fenster vorbereiten
        dlg = New frmWeiterbildungsfensterMitarb(weiterbil)
        dlg.ShowDialog()

        'Auswertung des Dialogergebnisses
        If dlg.DialogResult = Windows.Forms.DialogResult.OK Then

            ' Dialog mit positivem Ergebnis geschlossen
            weiterbil = dlg.gibWeiterbildung

            ' Neuen Benutzer aus dem Formular geben lassen

            'Hinweis: WEIL OBJEKTE REFERENZTYPEN SIND; IST DIE LISTE DER URLAUBSANTRÄGE
            'BEREITS JETZT AKTUALISIERT: ES MUSS NICHTS HINZUGEFÜGT WERDEN!

            'Fensterinhalt aktualisieren, so dass Tabelle auch die Änderungen des Benutzers zeigt
            anzeigen()
        End If
    End Sub

    ''' <summary>
    ''' Klick auf Hinzufügen öffnet einen neuen Benutzer in einem Detaildialog.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnHinzufuegen_Click(sender As Object, e As EventArgs) Handles btnHinzufuegen.Click
        'Deklaration
        Dim weiterbil As Weiterbildung 'Zu bearbeitener Weiterbildung
        Dim dlg As frmWeiterbildungsfensterMitarb 'Detaildialog zum Anzeigen der Weiterbildung

        'neue Weiterbildung erzeugen

        'Fenster vorbereiten

        'Auswertung des Dialogergebnisses
        ' Dialog mit positivem Ergebnis geschlossen
        ' Neue Weiterbildung aus dem Formular geben lassen und zur Liste der Benutzer hinzufügen
        ' Fensterinhalt aktualisieren, so dass Tabelle auch die Änderungen des Benutzers zeigt

    End Sub

    'Idee TODO für btnHinzufügen
    'Dim weiterbil As Weiterbildung
    'Dim dlg As dlgNeueWeiterbildung
    'Dim weiterbilcon As WeiterbildungsController
    'dlg = New dlgNeueWeiterbildung(weiterbil.mstrBezeichnung, weiterbil.mstrThema, weiterbil.mstrCurriculum, weiterbil.mstrTeilnehmerkreis)
    'dlg.ShowDialog()
    'If dlg.DialogResult = Windows.Form.DialogResult.OK Then
    'weiterbil = dlg.
End Class