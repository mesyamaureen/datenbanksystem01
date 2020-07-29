Imports System.Windows.Forms

Public Class dlgAnmeldung
    ''' <summary>
    ''' Beim Klick auf OK folgt das Standardverhalten des Dialogs
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Die Schaltfläche OK ist als Accept-Button eingestellt und liefert das DialogResult OK.</remarks>
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

    Private Sub lblNeuesKonto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblNeuesKonto.LinkClicked
        frmKundenkontoerstellung.ShowDialog()
    End Sub
End Class
