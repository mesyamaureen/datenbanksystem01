''' <summary>
''' Detailsdialog zur Anzeige und Bearbeitung eines Benutzers
''' </summary>
''' <remarks></remarks>
Public Class frmWeiterbildungsfensterMitarb

    'Attribute
    Private mBearbWeiterbildung As Weiterbildung 'der zu bearbeitende Weiterbildung

    'Parameterloser Konstruktor
    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        mBearbWeiterbildung = New Weiterbildung

    End Sub

    'Konstruktor mit Parameter
    Public Sub New(pWeiterbil As Weiterbildung)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        mBearbWeiterbildung = pWeiterbil
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

    'Alle Oberflächenelemente beim Anzeigen der Weiterbildung
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

    ''' <summary>
    '''  Beim Klick auf Speichern bzw. OK müssen nur die Pflichtangaben geprüft werden, der Rest ist Standardverhalten von OK
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Die Schaltfläche Speichern bzw. OK ist als Accept-Button eingestellt und liefert das DialogResult OK.</remarks>
    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        Dim titel As String = Me.txtboxSeminartitel.Text
        Dim curri As String = Me.rtxtboxSeminarbeschreibungM.Text
        Dim thema As String = Me.rtxtboxSeminarinfoM.Text
        Dim teilkreis As String = Me.rtxtboxTeilnkreisM.Text

        'Aufrufen changeWeiterbildung() in Weiterbildungscontroller
        mBearbWeiterbildung = WeiterbildungsController.changeWeiterbildung(titel, thema, curri, teilkreis, mBearbWeiterbildung)

        'Passende bearbeitende Weiterbildung in Datenbank
        For i = 0 To ListeWeiterbildung.Count - 1
            If ListeWeiterbildung.Item(i).WeiterbildungsID = mBearbWeiterbildung.WeiterbildungsID Then
                ListeWeiterbildung.Item(i) = mBearbWeiterbildung
                Kurs__und_WeiterbildungsDAO.speichernWeiterbildung(ListeWeiterbildung)
                Exit For
            End If
        Next
    End Sub


    ''' <summary>
    ''' Listview Kurse
    ''' </summary>
    Protected Sub aktivierenSchaltflächenKurs()
        'Schaltfläche zurücksetzen
        Me.btnNeuerKurs.Enabled = True
        Me.btnLeerenKurs.Enabled = True

        'Abhängig von Anzahl der ausgewählten Zeilen ggf. Schaltflächen aktivieren
        If lstviewKurseM.SelectedItems.Count = 1 Then
            Me.btnLoeschen.Enabled = True
        Else
            Me.btnLoeschen.Enabled = False 'kann nicht geöffnet oder gelöscht
        End If
    End Sub

    ''' <summary>
    ''' Wird aufgerufen, um die Daten der Kurse aus der Liste als Zeile anzuzeigen
    ''' </summary>
    ''' <param name="puintKursID"></param>
    ''' <param name="pdatKursDatum"></param>
    ''' <param name="pbolVerfuegbarkeit"></param>
    ''' <param name="pdecKursPreis"></param>
    Sub anzeigenZeileKurs(puintKursID As UInteger, pdatKursDatum As Date, pstrOrt As String, pbolVerfuegbarkeit As Boolean, pdecKursPreis As Decimal)
        'Neue Zeile in der Liste deklarieren
        Dim zeile As ListViewItem 'Alternativ Windows.Forms.ListViewItem

        'Auf den Inhalt der Liste zugreifen und neue Zeile erzeugen, indem
        'Index als Wert in der ersten Spalte eingetragen wird
        zeile = Me.lstviewKurseM.Items.Add(puintKursID)

        'Weitere Eigenschaften des benutzers in nachfolgenden Spalten der Zeile einfügen
        With zeile.SubItems
            .Add(pdatKursDatum)
            .Add(pstrOrt)
            .Add(pbolVerfuegbarkeit)
            .Add(pdecKursPreis)
        End With
    End Sub

    Private Sub anzeigenKurs()
        'leeren der Tabelle
        Me.lstviewKurseM.Items.Clear()

        'Für jedes Element soll eine Zeile in der Tabelle hinzugefügt werden
        For Each kurs As Kurs In ListeKurse
            If kurs.Weiterbildung.WeiterbildungsID = mBearbWeiterbildung.WeiterbildungsID Then
                'Hinzufügen einer Zeile in der Tabelle mit den zuvor ermittelten Werten
                anzeigenZeileKurs(kurs.KursID, kurs.Zeitpunkt, kurs.Ort, kurs.Verfuegbar, kurs.Preis)
            End If
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
        'Detaildialog zum Anzeigen des neuen Kurses
        Dim dlg As dlgNeuerKurs = New dlgNeuerKurs(mBearbWeiterbildung)
        dlg.ShowDialog()

        'Auswertung des Dialogergebnisses
        If dlg.DialogResult = Windows.Forms.DialogResult.OK Then
            ' Dialog mit positivem Ergebnis geschlossen
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
    'Public intIndex As Integer ' Index des ausgewählten Eintrags der Tabelle

    Private Sub btnLoeschen_Click(sender As Object, e As EventArgs) Handles btnLoeschen.Click
        ' aus der ausgewählten Zeile im Dialog die ID der Weiterbildung auslesen
        Dim intIndex As UInteger = Me.lstviewKurseM.SelectedItems(0).Text

        'Messagebox beim Löschen
        Dim mbrResult As MsgBoxResult
        'Verzweigung des Msgbox
        If Me.DialogResult = Windows.Forms.DialogResult.None Then
            mbrResult = MsgBox("Möchten Sie diesen Kurs wirklich permanent löschen?",
                                MsgBoxStyle.Question + vbYesNo, "Abbrechen")
            If mbrResult = vbNo Then
                Return
            End If
        End If

        WeiterbildungsController.deleteKurs(intIndex)

        'Fensterinhalt aktualisieren, so dass Tabelle den gelöschten Kurs nicht mehr zeigt
        anzeigenKurs()
    End Sub

    Private Sub frmWeiterbildungsfensterMitarb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        anzeigenWeiterbildung()
        anzeigenKurs()
    End Sub

    Private Sub lstviewKurseM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstviewKurseM.SelectedIndexChanged
        aktivierenSchaltflächenKurs()
    End Sub
End Class