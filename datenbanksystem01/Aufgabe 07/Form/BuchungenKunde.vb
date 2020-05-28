Public Class BuchungenKunde
    Private Sub BuchungenKunde_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        'Deklaration das Ergebnis des MsgBox
        Dim msgResult As MsgBoxResult
        'Initialisierung für das Ergebnis zwischen Ja und Nein
        msgResult = MsgBox("Möchten Sie wirklich abbrechen? Ihre ungespeicherte Änderungen werden verworfen.", MsgBoxStyle.Question, MsgBoxStyle.YesNo)
        'Verzweigung des Ergebnisses
        'Ergebnis: JA
        If msgResult = vbYes Then
            Me.Close() 'Dialogfenster von BuchungenKunde schließen
            Exit Sub 'Prozedur verlassen
            frmHauptfensterKunde.Show() 'HauptfensterKunde öffnen
            'Ergebnis: NEIN
        Else
            Return 'Zurück zum Fenster BuchungenKunde
        End If
    End Sub
    Private Sub hinzufuegen(pstrKurs As Kurs, pstrWeiterbildung As Weiterbildung)

        Dim zeile As Windows.Forms.ListViewItem
        With Me.ListViewAktBuchungen.Items

            zeile = .Add(pintBuchungsId)

            zeile.SubItems.Add(pstrKurs)
            zeile.SubItems.Add(pstrWeiterbildung)

        End With

        btnLoeschen.Enabled = False

    End Sub

    Private Sub ListViewAktBuchungen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewAktBuchungen.SelectedIndexChanged

    End Sub
End Class