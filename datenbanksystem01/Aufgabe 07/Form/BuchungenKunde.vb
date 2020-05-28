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
    Private Sub hinzufuegen(pintBuchungsID As Integer, pstrKurs As Kurs, pstrWeiterbildung As Weiterbildung)

        Dim zeile As Windows.Forms.ListViewItem
        zeile = Me.ListViewAktBuchungen.Items.Add(1)
        zeile.SubItems.Add(2)
        zeile.SubItems.Add(3)
    End Sub


    Private Sub ListViewAktBuchungen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewAktBuchungen.SelectedIndexChanged

        If ListViewAktBuchungen.SelectedItems.Count > 0 Then
            btnLaden.Enabled = True
        Else
            btnLaden.Enabled = False
        End If

    End Sub

    Private Sub btnLaden_Click(sender As Object, e As EventArgs) Handles btnLaden.Click

        Dim intBuchungsID As Integer
        Dim strKurs As String
        Dim strWeiterbildungen As String

        Dim lviZeile As ListViewItem
        lviZeile = ListViewAktBuchungen.SelectedItems(0)

        intBuchungsID = Integer.Parse(lviZeile.SubItems(0).Text)
        strKurs = lviZeile.SubItems(1).Text
        strWeiterbildungen = lviZeile.SubItems(2).Text
    End Sub

End Class