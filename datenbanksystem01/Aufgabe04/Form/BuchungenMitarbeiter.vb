Public Class BuchungenMitarbeiter
    Private Sub BuchungenMitarbeiter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSchließen_Click(sender As Object, e As EventArgs) Handles btnSchließen.Click
        Me.Close() 'Dieses Dialogfenster schließen
        Exit Sub 'Prozedur verlassen damit die Anwendung hier endet
        frmHauptfensterMitarbeiter.Show() 'Zurück zum Hauptfenster des Mitarbeiters
    End Sub
End Class