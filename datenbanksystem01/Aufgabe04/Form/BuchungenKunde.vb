Public Class BuchungenKunde
    Private Sub BuchungenKunde_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        'Deklaration das Ergebnis des MsgBox
        Dim msgResult As MsgBoxResult
        'Initialisierung für das Ergebnis zwischen Ja und Nein
        msgResult = MsgBox("Möchten Sie wirklich abbrechen? Ihre ungespeicherte Änderungen werden verwirft.", MsgBoxStyle.Question, MsgBoxStyle.YesNo)
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

End Class