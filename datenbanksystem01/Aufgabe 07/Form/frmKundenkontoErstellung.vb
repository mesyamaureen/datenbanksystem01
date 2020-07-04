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


        Dim neuerKunde As Kunde = New Kunde(Me.txtBenutzername.Text,
                                            Me.txtPasswort.Text,
                                            Me.txtNachname.Text,
                                            Me.txtVorname.Text,
                                            Me.datboxGebDat.Value,
                                            Me.txtFirma.Text)

        mlstKunde.Add(neuerKunde)

        BenutzerDAO.speichernKunde(mlstKunde)

        Me.Close()

    End Sub

    Private Sub frmKundenkontoerstellung_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class