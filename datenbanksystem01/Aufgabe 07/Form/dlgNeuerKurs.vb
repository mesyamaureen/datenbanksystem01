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
        Me.dtpKursDatum.Enabled = True
        Me.txtOrt.Enabled = True
        Me.chkVerfuegbarYes.Enabled = True
        Me.chkVerfuegbarNein.Enabled = True
        Me.txtPreis.Enabled = True
        Me.chkVerfuegbarYes.Enabled = True
        Me.chkVerfuegbarNein.Enabled = True


        Me.dtpKursDatum.Text = mneuerKurs.Zeitpunkt
        Me.txtOrt.Text = mneuerKurs.Ort
        Me.chkVerfuegbarYes.Text = mneuerKurs.Verfuegbar
        Me.txtPreis.Text = mneuerKurs.Preis
        Me.chkAbgesagtNein.Text = mneuerKurs.Verfuegbar
    End Sub

    Function gibKurs() As Kurs
        'Eigenschaften der Weiterbildung aus den Feldern der Oberfläche lesen
        mneuerKurs.Zeitpunkt = Me.dtpKursDatum.Text
        mneuerKurs.Ort = Me.txtOrt.Text
        mneuerKurs.Verfuegbar = Me.chkVerfuegbarYes.Checked
        mneuerKurs.Preis = Me.txtPreis.Text
        mneuerKurs.Abgesagt = Me.chkAbgesagtNein.Checked

        'Bearbeitete Weiterbildung als Ergebnis zurückgeben
        Return mneuerKurs

    End Function

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        Dim datum As Date = Me.dtpKursDatum.Text
        Dim ort As String = Me.txtOrt.Text
        Dim verfuegbarkeit As Boolean = Me.chkVerfuegbarYes.Checked
        Dim preis As Decimal = Me.txtPreis.Text
        Dim abgesagt As Boolean = Me.chkAbgesagtNein.Checked

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