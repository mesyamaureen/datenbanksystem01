Public Class frmWeiterbildungsfensterKunde
    'Attribute
    Public mWeiterbil As Weiterbildung 'die zu öffene Weiterbildung
    Public mKurse As List(Of Kurs) 'eine Liste von Kursen der Weiterbildung
    Public mWeiterbilController As WeiterbildungsController 'Bookingscontroller aufrufen

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        mWeiterbil = New Weiterbildung
        mKurse = New List(Of Kurs)
        mWeiterbilController = New WeiterbildungsController
    End Sub

    Public Sub New(pWeiterbildung As Weiterbildung)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        mWeiterbil = pWeiterbildung
        mKurse = New List(Of Kurs)
        mWeiterbilController = New WeiterbildungsController
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

    Function gibWeiterbildung() As Weiterbildung
        'Eigenschaften der Weiterbildung aus den Feldern der Oberfläche lesen
        mWeiterbil.Bezeichnung = Me.txtboxSeminartitel.Text
        mWeiterbil.Curriculum = Me.rtxtboxSeminarbeschreibung.Text
        mWeiterbil.Teilnehmerkreis = Me.rtxtboxTeilnkreis.Text
        mWeiterbil.Thema = Me.rtxtboxSeminarinfo.Text
        ' TODO: m... = Me.listview.Kurs ????

        'Bearbeitete Weiterbildung als Ergebnis zurückgeben
        Return mWeiterbil
    End Function

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

    Private Sub frmWeiterbildungsfensterKunde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Logic.initialise()

        'Deklaration für jede Oberflächenelemente
        Dim weiterbilID As String
        Dim titel As String
        Dim curriculum As String
        Dim teilnkreis As String
        Dim thema As String

        For i = 0 To ListeWeiterbildung.Count - 1
            mWeiterbil = ListeWeiterbildung.Item(i)

            'Attributwere aus der Weiterbildung lesen
            weiterbilID = mWeiterbil.WeiterbildungsID
            titel = mWeiterbil.Bezeichnung
            curriculum = mWeiterbil.Curriculum
            teilnkreis = mWeiterbil.Teilnehmerkreis
            thema = mWeiterbil.Thema

            'In die Oberflächenelemente zuweisen
            Me.txtboxSeminartitel.Text = titel
            Me.rtxtboxSeminarbeschreibung.Text = curriculum
            Me.rtxtboxTeilnkreis.Text = teilnkreis
            Me.rtxtboxSeminarinfo.Text = thema
        Next
        'Me.txtboxSeminartitel.Text = Logic.ListeWeiterbildung.Item(i).Bezeichnung

        'Aufrufen viewWeiterbildung in Weiterbildungscontroller
        mWeiterbilController.viewWeiterbildung(weiterbilID)
        'Passende ausgewählte Weiterbildung im Datenbank
        Logic.mlstWeiterbildungen.Item(frmHauptfensterKunde.intIndex) = mWeiterbil

    End Sub

    'Function gibBuchung() As Buchung
    'Eigenschaften des Kurses aus den Feldern der Oberfläche lesen
    'Neue Buchung als Ergebnis zurückgeben
    'End Function


End Class

