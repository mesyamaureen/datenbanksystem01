Public Class frmMeinKontoMitarbeiter
    'ToDo:
    '
    Dim anzumeldenderMitarbeiter As Mitarbeiter

    Sub New(pstranzumeldenderMitarbeiter As Mitarbeiter)


        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        anzumeldenderMitarbeiter = pstranzumeldenderMitarbeiter
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        txtBenutzername.Text = anzumeldenderMitarbeiter.Benutzername
        txtboxAltesPasswort.Text = anzumeldenderMitarbeiter.Passwort
        txtboxName.Text = anzumeldenderMitarbeiter.Name
        txtboxVorname.Text = anzumeldenderMitarbeiter.Vorname
        dtpGebDatMitarbeiter.Value = anzumeldenderMitarbeiter.Geburtsdatum
        txtboxMitarbeiterID.Text = anzumeldenderMitarbeiter.MitarbeiterID

    End Sub
    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Dim msgErgebnis As MsgBoxResult

        msgErgebnis = MsgBox("Möchten Sie wirklich abbrechen? Ihre ungespeicherte Änderungen werden verwirft.", vbQuestion + vbYesNo, "Abbrechen")

        If msgErgebnis = vbNo Then
            DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        End If
    End Sub

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        anzumeldenderMitarbeiter.Passwort = Me.txtboxNeuesPasswort.Text
        anzumeldenderMitarbeiter.Name = Me.txtboxName.Text
        anzumeldenderMitarbeiter.Geburtsdatum = Me.dtpGebDatMitarbeiter.Value
    End Sub
End Class