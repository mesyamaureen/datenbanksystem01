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
        'Nichts zu tun, Standardverhalten bei Abbrechen reicht
    End Sub

    Private Sub anzeigen()
        Me.txtboxSeminartitel.Enabled = True

        Me.rtxtboxSeminarbeschreibungM.Enabled = True
        Me.rtxtboxTeilnkreisM.Enabled = True
        Me.rtxtboxSeminarinfoM.Enabled = True

        Me.lstviewKurseM.Enabled = True
        Me.btnNeuerKurs.Enabled = True
        Me.btnLeerenKurs.Enabled = True
        Me.btnLoeschen.Enabled = True

        Me.txtboxSeminartitel.Text = mBearbWeiterbildung.Bezeichnung
        Me.rtxtboxSeminarbeschreibungM.Text = mBearbWeiterbildung.Curriculum
        Me.rtxtboxTeilnkreisM.Text = mBearbWeiterbildung.Teilnehmerkreis
        Me.rtxtboxSeminarinfoM.Text = mBearbWeiterbildung.Thema
        'TODO: Me.listview.Kurs ?????
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


    Private Sub frmWeiterbildungsfensterMitarb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mKurse = Logic.initialise 'PLEASE DO DOUBLE CHECK  
        anzeigen()

    End Sub

End Class