Public Class frmMeinKontoMitarbeiter

    Dim anzumeldenderMitarbeiter As Mitarbeiter

    Sub New(pstranzumeldenderMitarbeiter As Mitarbeiter)
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        anzumeldenderMitarbeiter = pstranzumeldenderMitarbeiter

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        txtBenutzername.Text = anzumeldenderMitarbeiter.Benutzername
        txtboxNeuesPasswort.Text = anzumeldenderMitarbeiter.Passwort
        txtboxName.Text = anzumeldenderMitarbeiter.Name
        txtboxVorname.Text = anzumeldenderMitarbeiter.Vorname
        dtpGebDatMitarbeiter.Value = anzumeldenderMitarbeiter.Geburtsdatum
        txtboxMitarbeiterID.Text = anzumeldenderMitarbeiter.BenutzerID
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Dim msgErgebnis As MsgBoxResult

        msgErgebnis = MsgBox("Möchten Sie wirklich abbrechen? Ihre ungespeicherten Änderungen werden verworfen.", vbQuestion + vbYesNo, "Abbrechen")

        If msgErgebnis = vbNo Then
            DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        End If
    End Sub

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        UserController.changeMitarbeiter(anzumeldenderMitarbeiter.BenutzerID,
                                         anzumeldenderMitarbeiter.Benutzername,
                                         txtboxNeuesPasswort.Text,
                                         txtboxVorname.Text,
                                         txtboxName.Text,
                                         dtpGebDatMitarbeiter.Value)
    End Sub

    Private Sub BtnLoeschen_Click(sender As Object, e As EventArgs) Handles btnLoeschen.Click
        Dim msgErgebnis As MsgBoxResult

        msgErgebnis = MsgBox("Möchten Sie Ihr Mitarbeiterkonto wirklich löschen?", vbQuestion + vbYesNo, "Abbrechen")

        If msgErgebnis = vbNo Then
            DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        Else
            UserController.deleteMitarbeiter(anzumeldenderMitarbeiter.BenutzerID)
            MsgBox("Ihr Mitarbeiterkonto wurde erfolgreich gelöscht. Danke, dass Sie unsere Services genutzt haben.")
            Application.Exit()
        End If
    End Sub
End Class