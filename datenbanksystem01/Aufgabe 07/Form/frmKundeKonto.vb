Public Class frmKundeKonto
    Dim aktuellerKunde As Kunde

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
End Class