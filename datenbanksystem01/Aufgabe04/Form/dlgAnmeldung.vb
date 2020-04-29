Imports System.Windows.Forms

Public Class dlgAnmeldung

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'Nichts zu tun
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Dim msgErgebnis As MsgBoxResult

        msgErgebnis = MsgBox("Möchten Sie wirklich abbrechen?", vbQuestion + vbYesNo, "Abbrechen")

        If msgErgebnis = vbNo Then
            DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        End If
    End Sub
End Class
