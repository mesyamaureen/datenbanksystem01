Public Class frmHauptfensterMitarbeiter

    Dim anzumeldenderMitarbeiter As Mitarbeiter

    Sub New(pstranzumeldenderMitarbeiter As String)


        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        setUserContext(pstranzumeldenderMitarbeiter)
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

    End Sub

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

    Public Sub setUserContext(strBenutzername As String)
        For Each mitarbeiter As Mitarbeiter In Logic.ListeMitarbeiter
            If strBenutzername.Equals(mitarbeiter.Benutzername) Then
                anzumeldenderMitarbeiter = mitarbeiter
            End If
        Next
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
    Sub anzeigenZeile(puintWeiterbilID As UInteger, pstrWeiterbilName As String, pstrWeiterbilThema As String)

        'Neue Zeile in der Liste deklarieren
        Dim zeile As ListViewItem 'Alternativ Windows.Forms.ListViewItem

        'Auf den Inhalt der Liste zugreifen und neue Zeile erzeugen, indem
        'Index als Wert in der ersten Spalte eingetragen wird
        zeile = Me.lstviewWeiterbildungenM.Items.Add(puintWeiterbilID)

        'Weitere Eigenschaften des benutzers in nachfolgenden Spalten der Zeile einfügen
        With zeile.SubItems
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
        Dim uintWeiterbilID As UInteger
        Dim strWeiterbilName As String
        Dim strWeiterbilThema As String

        'leeren der Tabelle
        leeren()

        'Für jedes Element soll eine Zeile in der Tabelle hinzugefügt werden
        For i = 0 To ListeWeiterbildung.Count - 1
            weiterbil = ListeWeiterbildung.Item(i)

            'Attributwerte aus der Weiterbildung lesen
            uintWeiterbilID = weiterbil.WeiterbildungsID
            strWeiterbilName = weiterbil.Bezeichnung
            strWeiterbilThema = weiterbil.Thema

            'Hinzufügen einer Zeile in der Tabelle mit den zuvor ermittelten Werten
            anzeigenZeile(uintWeiterbilID, strWeiterbilName, strWeiterbilThema)

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

    Private lastIndex As Integer
    Public Function GetListViewIndex() As Integer
        If lstviewWeiterbildungenM.SelectedIndices.Count <> 0 Then
            lastIndex = lstviewWeiterbildungenM.SelectedItems(0).Text
        End If

        Return lastIndex
    End Function

    ''' <summary>
    ''' Klick auf Öffnen bzw. Bearbeiten öffnet den aktuell in der Tabelle ausgewählten Benutzer in einem Detaildialog.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOeffnenM_Click(sender As Object, e As EventArgs) Handles btnOeffnenM.Click
        'Deklaration
        Dim weiterbil As Weiterbildung  ' Zu bearbeitener Weiterbildung
        Dim dlg As frmWeiterbildungsfensterMitarb  ' Detaildialog zum Anzeigen der Weiterbildung

        'Element an der Position der Liste, die der ID entspricht ermitteln
        For Each weiterbildung As Weiterbildung In ListeWeiterbildung
            If weiterbildung.WeiterbildungsID = lstviewWeiterbildungenM.SelectedItems(0).Text Then
                weiterbil = weiterbildung
                Exit For
            End If
        Next
        'weiterbil = Logic.ListeWeiterbildung.Item(GetListViewIndex())

        'Fenster vorbereiten
        dlg = New frmWeiterbildungsfensterMitarb(weiterbil, GetListViewIndex())
        dlg.ShowDialog()

        'Auswertung des Dialogergebnisses
        If dlg.DialogResult = Windows.Forms.DialogResult.OK Then

            ' Dialog mit positivem Ergebnis geschlossen
            weiterbil = dlg.gibWeiterbildung

            'Fensterinhalt aktualisieren, so dass Tabelle auch die Änderungen des Benutzers zeigt
            anzeigen()
        End If
    End Sub

    ''' <summary>
    ''' Klick auf Hinzufügen öffnet eine Weiterbildung in der Tabelle.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnHinzufuegen_Click(sender As Object, e As EventArgs) Handles btnHinzufuegen.Click
        'Deklaration
        Dim neueWeiterbil As Weiterbildung 'Zu bearbeitener Weiterbildung
        Dim dlg As frmNeueWeiterbildung 'Detaildialog zum Anzeigen der Weiterbildung

        'Fenster vorbereiten
        dlg = New frmNeueWeiterbildung()
        dlg.ShowDialog()

        'Auswertung des Dialogergebnisses
        If dlg.DialogResult = Windows.Forms.DialogResult.OK Then
            ' Dialog mit positivem Ergebnis geschlossen
            neueWeiterbil = dlg.mneueWeiterbildung
            'Neue Weiterbildung zur Liste der Weiterbildung hinzufügen
            Logic.mlstWeiterbildungen.Add(neueWeiterbil)
            ' Fensterinhalt aktualisieren, so dass Tabelle auch die Änderungen des Benutzers zeigt
            anzeigen()
        End If
    End Sub

    ''' <summary>
    ''' Klick auf Löschen löscht eine Weiterbildung in der Tabelle.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnLoeschen_Click(sender As Object, e As EventArgs) Handles btnLoeschen.Click
        'Messagebox beim Löschen
        Dim mbrResult As MsgBoxResult
        'Verzweigung des Msgbox
        If Me.DialogResult = Windows.Forms.DialogResult.None Then
            mbrResult = MsgBox("Möchten Sie diese Weiterbildung permanent löschen?",
                                MsgBoxStyle.Question + vbYesNo, "Abbrechen")
            If mbrResult = vbNo Then
                Me.Close()
            End If
        End If

        'Weiterbildung löschen
        'aus Liste aller Weiterbildungen entfernen
        For Each weiterbildung As Weiterbildung In mlstWeiterbildungen
            If weiterbildung.WeiterbildungsID = Convert.ToInt32(lstviewWeiterbildungenM.SelectedItems(0).SubItems(1).Text) Then
                Logic.mlstWeiterbildungen.Remove(weiterbildung)
                Kurs__und_WeiterbildungsDAO.speichernWeiterbildung(mlstWeiterbildungen)
                Exit For
            End If
        Next


        'Fensterinhalt aktualisieren, so dass Tabelle die gelöschte Weiterbildung nicht mehr zeigt
        anzeigen()

    End Sub

    Private Sub btnBuchungenM_Click(sender As Object, e As EventArgs) Handles btnBuchungenM.Click
        Dim dlg As BuchungenMitarbeiter
        dlg = New BuchungenMitarbeiter()
        dlg.ShowDialog()
    End Sub

    Private Sub btnKundenkonto_Click(sender As Object, e As EventArgs) Handles btnKundenkonto.Click
        Dim dlg As frmKundenKontoListe
        dlg = New frmKundenKontoListe()
        dlg.ShowDialog()

    End Sub

    Private Sub btnMeinKonto_Click(sender As Object, e As EventArgs) Handles btnMeinKonto.Click
        Dim dlg As frmMeinKontoMitarbeiter
        dlg = New frmMeinKontoMitarbeiter(anzumeldenderMitarbeiter)
        dlg.ShowDialog()
    End Sub

    Private Sub lstviewWeiterbildungenM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstviewWeiterbildungenM.SelectedIndexChanged
        If lstviewWeiterbildungenM.SelectedItems.Count = 0 Then
            btnLoeschen.Enabled = False
            btnOeffnenM.Enabled = False

        Else
            btnLoeschen.Enabled = True
            btnOeffnenM.Enabled = True
        End If
    End Sub
End Class