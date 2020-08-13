Public Class frmKundenkontoerstellung

    Private Sub frmKundenkontoerstellung_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim msgErgebnis As MsgBoxResult

        msgErgebnis = MsgBox("Möchten Sie wirklich abbrechen?", vbQuestion + vbYesNo, "Abbrechen")

        If msgErgebnis = vbNo Then
            DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnNeu_Click(sender As Object, e As EventArgs) Handles btnNeu.Click
        Dim neuerKunde As Kunde = UserController.createKunde(txtBenutzername.Text,
                                                             txtNachname.Text,
                                                             txtVorname.Text,
                                                             txtPasswort.Text,
                                                             datboxGebDat.Value,
                                                             txtFirma.Text)

        ListeKunden.Add(neuerKunde)

        BenutzerDAO.speichernKunde(ListeKunden)

        Me.Close()

    End Sub

    Private Sub frmKundenkontoerstellung_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class