Public Class frmNeueMitarbeiter

    Private Sub frmKundenkontoerstellung_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub

    Private Sub btnErstellen_Click(sender As Object, e As EventArgs) Handles btnErstellen.Click

        Dim neuerMitarbeiter As Mitarbeiter = UserController.createMitarbeiter(txtboxBenutzername.Text,
                                                                               txtboxName.Text,
                                                                               txtboxVorname.Text,
                                                                               txtboxPasswort.Text,
                                                                               datboxGebDatM.Value)

        ListeMitarbeiter.Add(neuerMitarbeiter)

        BenutzerDAO.speichernMitarbeiter(ListeMitarbeiter)

        Me.Close()

    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Dim msgErgebnis As MsgBoxResult

        msgErgebnis = MsgBox("Möchten Sie wirklich abbrechen?", vbQuestion + vbYesNo, "Abbrechen")

        If msgErgebnis = vbNo Then
            DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        Else
            Me.Close()
        End If
    End Sub


End Class