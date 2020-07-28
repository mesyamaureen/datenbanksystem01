Public Class frmKundeKonto
    Dim aktuellerKunde As Kunde

    Sub New(pstrangemeldeterKunde As Kunde)


        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        aktuellerKunde = pstrangemeldeterKunde
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        tbBenutzername.Text = aktuellerKunde.Benutzername
        txtboxAltesPasswort.Text = aktuellerKunde.Passwort
        txtboxName.Text = aktuellerKunde.Name
        txtboxVorname.Text = aktuellerKunde.Vorname
        dtpGebDatKunde.Value = aktuellerKunde.Geburtsdatum
        txtboxFirma.Text = aktuellerKunde.Firma
        txtboxKundenID.Text = aktuellerKunde.KundenID

    End Sub

    Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
    End Sub


    Private Sub btnKontoLoeschen_Click(sender As Object, e As EventArgs) Handles btnKontoLoeschen.Click

        aktuellerKunde = Me.aktuellerKunde
        Dim msgErgebnis As MsgBoxResult

        msgErgebnis = MsgBox("Möchten Sie Ihr Kundenkonto wirklich löschen?", vbQuestion + vbYesNo, "Abbrechen")

        If msgErgebnis = vbNo Then
            DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        Else
            Me.Close()
            msgErgebnis = MsgBox("Ihr Kundenkonto wurde erfolgreich gelöscht. Danke, dass Sie unsere Services genutzt haben.")
            aktuellerKunde = Nothing

        End If
        End
    End Sub

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click

        aktuellerKunde.Passwort = Me.txtboxNeuesPasswort.Text
        aktuellerKunde.Name = Me.txtboxName.Text
        aktuellerKunde.Geburtsdatum = Me.dtpGebDatKunde.Value
    End Sub

    Private Sub frmKundeKonto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class