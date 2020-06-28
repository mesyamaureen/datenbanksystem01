Public Class frmNeueWeiterbildung
    'Deklaration

    Public mneueWeiterbildung As Weiterbildung
    Public mWeiterbControl As WeiterbildungsController

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        mneueWeiterbildung = New Weiterbildung
        mWeiterbControl = New WeiterbildungsController
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        'Messagebox
        Dim mbrResult As MsgBoxResult
        'Verzweigung
        If Me.DialogResult = Windows.Forms.DialogResult.None Then
            mbrResult = MsgBox("Möchten Sie wirklich abbrechen? Ihre ungespeicherte Änderungen werden verwirft.",
                                MsgBoxStyle.Question + vbYesNo, "Abbrechen")
            If mbrResult = vbNo Then
                Me.Close()
            End If
        End If
    End Sub

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
        'TODO: list Kurse?
    End Sub

    Private Sub btnErstellen_Click(sender As Object, e As EventArgs) Handles btnErstellen.Click
        Dim titel As String = Me.txtSeminartitel.Text
        Dim curri As String = Me.rtxtboxSeminarbeschreibung.Text
        Dim theme As String = Me.rtxtboxSeminarinfo.Text
        Dim teilkreis As String = Me.rtxtboxTeilnehmerkreis.Text
        'Aufrufen createWeiterbildung() in Weiterbildungscontroller
        'Zuweisen Oberflächenelemente in Parameter von createWeiterbildung
        'Zuweisen mneueWeiterbildung in Rückgabewert createWeiterbildung
        mneueWeiterbildung = mWeiterbControl.createWeiterbildung(titel, curri, teilkreis, theme)

        'Dialogfenster schließen
        'Me.Close()
    End Sub

    Private Sub frmNeueWeiterbildung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        anzeigen()
    End Sub
End Class