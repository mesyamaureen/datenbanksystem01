Public Class frmMeinKontoMitarbeiter
    Dim strBenutzername As String
    Dim strPasswort As String
    Dim strNeuesPasswort As String
    Dim strName As String
    Dim strVorname As String
    Dim datGebDat As Date

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Dim msgErgebnis As MsgBoxResult

        msgErgebnis = MsgBox("Möchten Sie wirklich abbrechen? Ihre ungespeicherte Änderungen werden verwirft.", vbQuestion + vbYesNo, "Abbrechen")

        If msgErgebnis = vbNo Then
            DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        End If
    End Sub

    Private Sub txtBoxAuslesen()




    End Sub



    Private Sub textBoxNeuenWertSpeichern()


        strBenutzername = Me.txtBenutzername.Text
        strNeuesPasswort = Me.txtboxNeuesPasswort.Text
        strName = Me.txtboxName.Text
        strVorname = Me.txtboxVorname.Text
        datGebDat = Me.dtpGebDatMitarbeiter.Value




    End Sub





    Private Sub txtBenutzername_TextChanged(sender As Object, e As EventArgs) Handles txtBenutzername.TextChanged

    End Sub
End Class