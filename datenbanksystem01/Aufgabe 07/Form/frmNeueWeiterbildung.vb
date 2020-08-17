Public Class frmNeueWeiterbildung
    'Deklaration

    Public mneueWeiterbildung As Weiterbildung

    'Parameter Konstruktor
    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        mneueWeiterbildung = New Weiterbildung
    End Sub

    'Kontstruktor mit Parameter
    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Dim msgErgebnis As MsgBoxResult

        msgErgebnis = MsgBox("Möchten Sie wirklich abbrechen? Ihre ungespeicherte Änderungen werden verwirft.", vbQuestion + vbYesNo, "Abbrechen")

        If msgErgebnis = vbNo Then
            DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        End If
    End Sub

    'Alle Oberflächenelemente beim Anzeigen der Weiterbildung
    Private Sub anzeigen()
        Me.txtSeminartitel.Enabled = True
        Me.rtxtboxSeminarbeschreibung.Enabled = True
        Me.rtxtboxSeminarinfo.Enabled = True
        Me.rtxtboxTeilnehmerkreis.Enabled = True
        Me.lstviewKurse.Enabled = True
        Me.btnLeeren.Enabled = True
        Me.btnLoeschen.Enabled = True
        Me.btnNeuerKurs.Enabled = True

        Me.txtSeminartitel.Text = mneueWeiterbildung.Bezeichnung
        Me.rtxtboxSeminarbeschreibung.Text = mneueWeiterbildung.Curriculum
        Me.rtxtboxSeminarinfo.Text = mneueWeiterbildung.Thema
        Me.rtxtboxTeilnehmerkreis.Text = mneueWeiterbildung.Teilnehmerkreis
    End Sub

    Private Sub btnErstellen_Click(sender As Object, e As EventArgs) Handles btnErstellen.Click 'Erstellen Schaltfläche
        Dim titel As String = Me.txtSeminartitel.Text
        Dim curri As String = Me.rtxtboxSeminarbeschreibung.Text
        Dim theme As String = Me.rtxtboxSeminarinfo.Text
        Dim teilkreis As String = Me.rtxtboxTeilnehmerkreis.Text
        'Aufrufen createWeiterbildung() in Weiterbildungscontroller
        'Zuweisen Oberflächenelemente in Parameter von createWeiterbildung
        ListeWeiterbildung.Add(WeiterbildungsController.createWeiterbildung(titel, curri, teilkreis, theme))
        Kurs__und_WeiterbildungsDAO.speichernWeiterbildung(ListeWeiterbildung)
    End Sub

    Private Sub frmNeueWeiterbildung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        anzeigen()
    End Sub
End Class