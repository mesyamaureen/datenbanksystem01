Public Class Weiterbildungsfenster_Kunde
    'Attribute
    Public mBuchenderKurs As Buchung 'der zu buchendem Kurs
    Public mKurse As List(Of Kurs) 'eine Liste von Kursen der Weiterbildung
    Public mBuchungContr As BookingController 'Bookingscontroller aufrufen

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        mBuchenderKurs = New Buchung
    End Sub

    Public Sub New(pBuchung As Buchung)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        mBuchenderKurs = pBuchung
    End Sub

    ''' <summary>
    ''' Beim Klick auf Abbrechen folgt das Standardverhalten
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Die Schaltfläche Abbrechen ist als Cancel-Button eingestellt und liefert das DialogResult Cancel.</remarks>
    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        'Nichts zu tun, Standardverhalten bei Abbrechen reicht
    End Sub

    Private Sub anzeigen()
        Me.txtboxSeminartitel.Enabled = False

        Me.rtxtboxSeminarbeschreibung.Enabled = False
        Me.rtxtboxTeilnkreis.Enabled = False
        Me.rtxtboxSeminarinfo.Enabled = False

        Me.lstviewKurse.Enabled = True
        Me.btnBuchen.Enabled = True

        'TODO: Me.listview.Kurs ?????
    End Sub

    'Long Index deklarieren
    Public lngIndex As Long ' Index des ausgewählten Eintrags der Tabelle
    ''' <summary>
    ''' Ausgewählter Kurs buchen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnBuchen_Click(sender As Object, e As EventArgs) Handles btnBuchen.Click
        'Deklaration
        Dim buchenderKurs As Kurs
        Dim frm As BuchungenKunde

        'aus der ausgewählten Zeile im Dialog die ID des Kurses auslesen
        lngIndex = Me.lstviewKurse.SelectedItems(0).Text

        'Element an der Position der Liste, die der ID entspricht ermitteln
        buchenderKurs = Logic.mlstKurs.Item(lngIndex)

        'Fenster vorbereiten
        'frm = New BuchungenKunde(buchenderKurs)
        'frm.Show()
        'Rückgabewert Als Neue Buchung von Weiterbildungscontroller
    End Sub

    'Function gibBuchung() As Buchung
    'Eigenschaften des Kurses aus den Feldern der Oberfläche lesen
    'Neue Buchung als Ergebnis zurückgeben
    'End Function


End Class