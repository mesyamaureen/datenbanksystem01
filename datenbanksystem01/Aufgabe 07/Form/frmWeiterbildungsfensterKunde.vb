Public Class frmWeiterbildungsfensterKunde
    'Attribute
    Private mWeiterbil As Weiterbildung 'die zu öffene Weiterbildung
    Private kunde As Kunde

    'Parameterloser Konstruktor
    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        mWeiterbil = New Weiterbildung
        kunde = New Kunde
    End Sub

    'Konstruktor mit Parameter
    Public Sub New(pWeiterbildung As Weiterbildung, kunde As Kunde)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        mWeiterbil = pWeiterbildung
        Me.kunde = kunde
    End Sub

    ''' <summary>
    ''' Beim Klick auf Abbrechen folgt das Standardverhalten
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Die Schaltfläche Abbrechen ist als Cancel-Button eingestellt und liefert das DialogResult Cancel.</remarks>
    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        'Nichts zu tun, Standardverhalten
    End Sub

    'Alle Oberflächenelemente beim Anzeigen der Weiterbildung
    Private Sub anzeigen()
        Me.txtboxSeminartitel.Enabled = False
        Me.rtxtboxSeminarbeschreibung.Enabled = False
        Me.rtxtboxTeilnkreis.Enabled = False
        Me.rtxtboxSeminarinfo.Enabled = False
        Me.lstviewKurse.Enabled = True

        Me.txtboxSeminartitel.Text = mWeiterbil.Bezeichnung
        Me.rtxtboxSeminarbeschreibung.Text = mWeiterbil.Curriculum
        Me.rtxtboxTeilnkreis.Text = mWeiterbil.Teilnehmerkreis
        Me.rtxtboxSeminarinfo.Text = mWeiterbil.Thema
    End Sub

    ''' <summary>
    ''' Ausgewählter Kurs buchen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnBuchen_Click(sender As Object, e As EventArgs) Handles btnBuchen.Click
        'Deklaration
        Dim buchenderKurs = New Kurs()

        'Kurs Objekt aus Liste suchen
        For Each kurs As Kurs In ListeKurse
            If kurs.KursID = Convert.ToUInt32(Me.lstviewKurse.SelectedItems(0).SubItems(0).Text) Then
                buchenderKurs = kurs
                Exit For
            End If
        Next

        'Buchen Funktion aufrufen mit mWeiterbil als Parameter für Weiterbildung
        'und zur Liste aller Buchungen hinzufügen
        ListeBuchung.Add(BookingController.createBooking(buchenderKurs, kunde)) 'Rückgabewert Als Neue Buchung von Bookingcontroller
        BuchungsDAO.speichernBuchung(ListeBuchung)

        'Meldungsfenster vorbereiten
        MsgBox("Sie haben eine neue Buchung hinzugefügt.", MsgBoxStyle.OkOnly, "Neue Buchung")

    End Sub

    Protected Sub aktivierenSchaltflächenKurs()
        'Abhängig von Anzahl der ausgewählten Zeilen ggf. Schaltflächen aktivieren
        If Me.lstviewKurse.SelectedItems.Count = 1 Then
            Me.btnBuchen.Enabled = True
        Else
            Me.btnBuchen.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Liste von Kurse anzeigen
    ''' </summary>
    ''' <param name="puintKursID"></param>
    ''' <param name="pdatKursDatum"></param>
    ''' <param name="pbolVerfuegbarkeit"></param>
    ''' <param name="pdecKursPreis"></param>
    Sub anzeigenZeileKurs(puintKursID As String, pdatKursDatum As Date, pstrOrt As String, pbolVerfuegbarkeit As Boolean, pdecKursPreis As Decimal)
        'Neue Zeile in der Liste deklarieren
        Dim zeile As ListViewItem 'Alternativ Windows.Forms.ListViewItem

        'Auf den Inhalt der Liste zugreifen und neue Zeile erzeugen, indem
        'Index als Wert in der ersten Spalte eingetragen wird
        zeile = Me.lstviewKurse.Items.Add(puintKursID)

        'Weitere Eigenschaften des benutzers in nachfolgenden Spalten der Zeile einfügen
        With zeile.SubItems
            .Add(pdatKursDatum)
            .Add(pstrOrt)
            .Add(pbolVerfuegbarkeit)
            .Add(pdecKursPreis)
        End With
    End Sub

    ''' <summary>
    ''' Tabelle mit der Liste von Kurs in Datenbank verknüpfen
    ''' </summary>
    Private Sub anzeigenKurs()
        'leeren der Tabelle
        Me.lstviewKurse.Items.Clear()

        'Für jedes Element soll eine Zeile in der Tabelle hinzugefügt werden
        For Each kurs As Kurs In ListeKurse
            If kurs.Weiterbildung.WeiterbildungsID = mWeiterbil.WeiterbildungsID Then
                'Hinzufügen einer Zeile in der Tabelle mit den zuvor ermittelten Werten
                anzeigenZeileKurs(kurs.KursID, kurs.Zeitpunkt, kurs.Ort, kurs.Verfuegbar, kurs.Preis)
            End If
        Next
        ' In der Tabelle ist keine Zeile ausgewählt, deshalb die Schaltflächen deaktivieren, die eine ausgewählte Zeile erfordern
        aktivierenSchaltflächenKurs()
    End Sub

    Private Sub frmWeiterbildungsfensterKunde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'alle anzeigen Funktion aufrufen
        anzeigen()
        anzeigenKurs()
        aktivierenSchaltflächenKurs()
    End Sub

    Private Sub lstviewKurse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstviewKurse.SelectedIndexChanged
        aktivierenSchaltflächenKurs()
    End Sub

End Class