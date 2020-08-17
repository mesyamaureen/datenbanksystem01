Public Class dlgNeuerKurs
    'Attribute
    Private mneuerKurs As Kurs
    Private mWeiterbildung As Weiterbildung

    'Parameterloser Konstruktor
    Public Sub New(pKurs As Kurs)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        mneuerKurs = pKurs

    End Sub
    'Konstruktor mit Parameter
    Public Sub New(weiterbildung As Weiterbildung)
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        mneuerKurs = New Kurs
        mWeiterbildung = weiterbildung
    End Sub

    ''' <summary>
    ''' Beim Klick auf Abbrechen folgt das Standardverhalten
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Dim msgErgebnis As MsgBoxResult

        msgErgebnis = MsgBox("Möchten Sie wirklich abbrechen? Ihre ungespeicherte Änderungen werden verwirft.", vbQuestion + vbYesNo, "Abbrechen")

        If msgErgebnis = vbNo Then
            DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        End If
    End Sub
    ''' <summary>
    ''' Alle Oberflächenelemente beim Anzeigen des Fensters
    ''' </summary>
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
        Me.chkVerfuegbarYes.Checked = mneuerKurs.Verfuegbar
        Me.txtPreis.Text = mneuerKurs.Preis
        Me.chkAbgesagtNein.Checked = mneuerKurs.Verfuegbar
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

        'Kurs erstellen
        Dim neuerKurs As Kurs = WeiterbildungsController.createKurs(ort, datum, verfuegbarkeit, preis, mWeiterbildung)

        'Kurs der Kursliste hinzufügen
        ListeKurse.Add(neuerKurs)
        Kurs__und_WeiterbildungsDAO.speichernKurs(ListeKurse)

        DialogResult = Windows.Forms.DialogResult.OK


    End Sub

    Private Sub dlgNeuerKurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        anzeigenNeuerKurs()
    End Sub
End Class
