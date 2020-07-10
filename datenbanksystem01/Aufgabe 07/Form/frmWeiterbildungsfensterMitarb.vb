''' <summary>
''' Detailsdialog zur Anzeige und Bearbeitung eines Benutzers
''' </summary>
''' <remarks></remarks>
Public Class frmWeiterbildungsfensterMitarb

    'Attribute
    Public mBearbWeiterbildung As Weiterbildung 'der zu bearbeitende Weiterbildung
    Public mKurse As List(Of Kurs) 'eine Liste von Kursen der Weiterbildung
    Public mWeiterbControlle As WeiterbildungsController 'Weiterbildungscontrolle aufrufen

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        mBearbWeiterbildung = New Weiterbildung
        mWeiterbControlle = New WeiterbildungsController
    End Sub

    Public Sub New(pWeiterbil As Weiterbildung)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        mBearbWeiterbildung = pWeiterbil
        mWeiterbControlle = New WeiterbildungsController
    End Sub

    ''' <summary>
    ''' Beim Klick auf Abbrechen folgt das Standardverhalten
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Die Schaltfläche Abbrechen ist als Cancel-Button eingestellt und liefert das DialogResult Cancel.</remarks>
    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Dim msgErgebnis As MsgBoxResult

        msgErgebnis = MsgBox("Möchten Sie wirklich abbrechen? Ihre ungespeicherte Änderungen werden verwirft.", vbQuestion + vbYesNo, "Abbrechen")

        If msgErgebnis = vbNo Then
            DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        End If
    End Sub

    Private Sub anzeigenWeiterbildung()
        Me.txtboxSeminartitel.Enabled = True

        Me.rtxtboxSeminarbeschreibungM.Enabled = True
        Me.rtxtboxTeilnkreisM.Enabled = True
        Me.rtxtboxSeminarinfoM.Enabled = True
        Me.lstviewKurseM.Enabled = True

        Me.txtboxSeminartitel.Text = mBearbWeiterbildung.Bezeichnung
        Me.rtxtboxSeminarbeschreibungM.Text = mBearbWeiterbildung.Curriculum
        Me.rtxtboxTeilnkreisM.Text = mBearbWeiterbildung.Teilnehmerkreis
        Me.rtxtboxSeminarinfoM.Text = mBearbWeiterbildung.Thema
    End Sub

    Function gibWeiterbildung() As Weiterbildung
        'Eigenschaften der Weiterbildung aus den Feldern der Oberfläche lesen
        mBearbWeiterbildung.Bezeichnung = Me.txtboxSeminartitel.Text
        mBearbWeiterbildung.Curriculum = Me.rtxtboxSeminarbeschreibungM.Text
        mBearbWeiterbildung.Teilnehmerkreis = Me.rtxtboxTeilnkreisM.Text
        mBearbWeiterbildung.Thema = Me.rtxtboxSeminarinfoM.Text
        ' TODO: m... = Me.listview.Kurs ????

        'Bearbeitete Weiterbildung als Ergebnis zurückgeben
        Return mBearbWeiterbildung

    End Function

    ''' <summary>
    '''  Beim Klick auf Speichern bzw. OK müssen nur die Pflichtangaben geprüft werden, der Rest ist Standardverhalten von OK
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Die Schaltfläche Speichern bzw. OK ist als Accept-Button eingestellt und liefert das DialogResult OK.</remarks>
    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        Dim titel As String = Me.txtboxSeminartitel.Text
        Dim curri As String = Me.rtxtboxSeminarbeschreibungM.Text
        Dim theme As String = Me.rtxtboxSeminarinfoM.Text
        Dim teilkreis As String = Me.rtxtboxTeilnkreisM.Text
        'Aufrufen changeWeiterbildung() in Weiterbildungscontroller
        mWeiterbControlle.changeWeiterbildung(titel, theme, curri, teilkreis, mBearbWeiterbildung)
        'Passende bearbeitende Weiterbildung in Datenbank
        Logic.mlstWeiterbildungen.Item(frmHauptfensterMitarbeiter.intIndex) = mBearbWeiterbildung
    End Sub


    ''' <summary>
    ''' Listview Kurse
    ''' </summary>
    Protected Sub aktivierenSchaltflächenKurs()
        'Deklaration
        Dim intAnzahlAusgewaehlterZeilen As Integer

        'Initialisierung
        intAnzahlAusgewaehlterZeilen = Me.lstviewKurseM.SelectedItems.Count

        'Schaltfläche zurücksetzen
        Me.btnNeuerKurs.Enabled = True
        Me.btnLeerenKurs.Enabled = True
        Me.btnLoeschen.Enabled = False

        'Abhängig von Anzahl der ausgewählten Zeilen ggf. Schaltflächen aktivieren
        If intAnzahlAusgewaehlterZeilen = 1 Then
            Me.btnLoeschen.Enabled = True
        Else
            Me.btnLoeschen.Enabled = False 'kann nicht geöffnet oder gelöscht
        End If

        'Me.lstviewKurs.SelectedItems = mBearbWeiterbildung.Kurs
        'Me.lstviewKurseM.SelectedItems = mKurse.

    End Sub

    ''' <summary>
    ''' Wird aufgerufen, um die Daten der Kurse aus der Liste als Zeile anzuzeigen
    ''' </summary>
    ''' <param name="plngIndex"></param>
    ''' <param name="pstrKursID"></param>
    ''' <param name="pdatKursDatum"></param>
    ''' <param name="pbolVerfuegbarkeit"></param>
    ''' <param name="pdecKursPreis"></param>
    Sub anzeigenZeileKurs(plngIndex As Long, pstrKursID As String, pdatKursDatum As Date, pbolVerfuegbarkeit As Boolean, pdecKursPreis As Decimal)
        'Neue Zeile in der Liste deklarieren
        Dim zeile As ListViewItem 'Alternativ Windows.Forms.ListViewItem

        'Auf den Inhalt der Liste zugreifen und neue Zeile erzeugen, indem
        'Index als Wert in der ersten Spalte eingetragen wird
        zeile = Me.lstviewKurseM.Items.Add(plngIndex)

        'Weitere Eigenschaften des benutzers in nachfolgenden Spalten der Zeile einfügen
        With zeile.SubItems
            .Add(pstrKursID)
            .Add(pdatKursDatum)
            .Add(pbolVerfuegbarkeit)
            .Add(pdecKursPreis)
        End With
    End Sub

    Private Sub anzeigenKurs()
        'Deklaration
        Dim Kurs As Kurs 'Kurs

        'Anzuzeigende Attribute
        Dim strKursID As String
        Dim datKursDatum As Date
        Dim bolVerfuegbarkeit As Boolean
        Dim decKursPreis As Decimal

        'leeren der Tabelle
        Me.lstviewKurseM.Items.Clear()

        'Für jedes Element soll eine Zeile in der Tabelle hinzugefügt werden
        For i = 0 To ListeKurse.Count - 1
            Kurs = ListeKurse.Item(i)

            'Attributwerte aus der Weiterbildung lesen
            strKursID = Kurs.KursID
            datKursDatum = Kurs.Zeitpunkt
            bolVerfuegbarkeit = Kurs.Verfuegbar
            decKursPreis = Kurs.Preis

            'Hinzufügen einer Zeile in der Tabelle mit den zuvor ermittelten Werten
            anzeigenZeileKurs(i, strKursID, datKursDatum, bolVerfuegbarkeit, decKursPreis)

        Next
        ' In der Tabelle ist keine Zeile ausgewählt, deshalb die Schaltflächen deaktivieren, die eine ausgewählte Zeile erfordern
        aktivierenSchaltflächenKurs()
    End Sub

    ''' <summary>
    ''' Neuer Kurs erstellen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNeuerKurs_Click(sender As Object, e As EventArgs) Handles btnNeuerKurs.Click
        'Deklaration
        Dim neuerKurs As Kurs 'Hinzufügen neuer Kurs
        Dim dlg As dlgNeuerKurs 'Detaildialog zum Anzeigen des neuen Kurses

        'Fenster vorbereiten
        dlg = New dlgNeuerKurs()
        dlg.ShowDialog()

        'Auswertung des Dialogergebnisses
        If dlg.DialogResult = Windows.Forms.DialogResult.OK Then
            ' Dialog mit positivem Ergebnis geschlossen
            neuerKurs = dlg.mneuerKurs
            'Neue Weiterbildung zur Liste der Weiterbildung hinzufügen
            Logic.mlstKurs.Add(neuerKurs)
            ' Fensterinhalt aktualisieren, so dass Tabelle auch die Änderungen des Benutzers zeigt
            anzeigenKurs()
        End If
    End Sub

    Private Sub btnLeerenKurs_Click(sender As Object, e As EventArgs) Handles btnLeerenKurs.Click
        Me.lstviewKurseM.Items.Clear()
        'Schaltfläche aktivieren/deaktivieren
        aktivierenSchaltflächenKurs()
    End Sub

    'Integer Index deklarieren
    Public intIndex As Integer ' Index des ausgewählten Eintrags der Tabelle

    Private Sub btnLoeschen_Click(sender As Object, e As EventArgs) Handles btnLoeschen.Click
        Dim kurs As Kurs 'Deklaration der zu löschenem Kurs und Index, die außer der Funktion deklariert wird.
        Dim weiterbilController As WeiterbildungsController

        ' aus der ausgewählten Zeile im Dialog die ID der Weiterbildung auslesen
        intIndex = Me.lstviewKurseM.SelectedItems(0).Text

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

        'Kurs löschen
        'aus Liste aller Kurse entfernen
        Logic.mlstKurs.RemoveAt(intIndex)

        'Fensterinhalt aktualisieren, so dass Tabelle den gelöschten Kurs nicht mehr zeigt
        anzeigenKurs()

    End Sub

    Private Sub frmWeiterbildungsfensterMitarb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mKurse = Logic.initialise 'PLEASE DO DOUBLE CHECK  
        anzeigenWeiterbildung()
        anzeigenKurs()

    End Sub
End Class