Public Class dlgNeuerKurs
    'Attribute
    Public mneuerKurs As Kurs
    Public mweiterbilController As WeiterbildungsController

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        mneuerKurs = New Kurs
        mweiterbilController = New WeiterbildungsController
    End Sub

    Public Sub New(pKurs As Kurs)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        mneuerKurs = pKurs
        mweiterbilController = New WeiterbildungsController
    End Sub

    ''' <summary>
    ''' Beim Klick auf Abbrechen folgt das Standardverhalten
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        'Nichts zu tun, Standardverhalten bei Abbrechen reicht
    End Sub

    Private Sub anzeigenNeuerKurs()
        Me.txtDatum.Enabled = True
        Me.txtOrt.Enabled = True
        Me.txtVerfuegbarkeit.Enabled = True
        Me.txtPreis.Enabled = True

        Me.txtDatum.Text = mneuerKurs.Zeitpunkt
        Me.txtOrt.Text = mneuerKurs.Ort
        Me.txtVerfuegbarkeit.Text = mneuerKurs.Verfuegbar
        Me.txtPreis.Text = mneuerKurs.Preis
    End Sub

    Function gibKurs() As Kurs
        'Eigenschaften der Weiterbildung aus den Feldern der Oberfläche lesen
        mneuerKurs.Zeitpunkt = Me.txtDatum.Text
        mneuerKurs.Ort = Me.txtOrt.Text
        mneuerKurs.Verfuegbar = Me.txtVerfuegbarkeit.Text
        mneuerKurs.Preis = Me.txtPreis.Text

        'Bearbeitete Weiterbildung als Ergebnis zurückgeben
        Return mneuerKurs

    End Function

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        Dim datum As Date = Me.txtDatum.Text
        Dim ort As String = Me.txtOrt.Text
        Dim verfuegbarkeit As Boolean = Me.txtVerfuegbarkeit.Text
        Dim preis As Decimal = Me.txtPreis.Text
        'Aufrufen changeWeiterbildung() in Weiterbildungscontroller
        mweiterbilController.createKurs(ort, datum, verfuegbarkeit, preis)
        'Passende bearbeitende Weiterbildung in Datenbank
        Logic.mlstKurs.Item(frmWeiterbildungsfensterMitarb.intIndex) = mneuerKurs
    End Sub

    Private Sub dlgNeuerKurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Logic.initialise()
        anzeigenNeuerKurs()
    End Sub
End Class