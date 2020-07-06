Public Class frmKundenKontoListe

    Protected Sub aktivierenSchaltflächen()
        ' Deklaration
        Dim intAnzahlAusgewaehlterZeilen As Integer ' Anzahl der ausgewählten Zeilen

        ' Initialisierung
        intAnzahlAusgewaehlterZeilen = Me.lstviewKundenKonten.SelectedItems.Count ' Anzahl der Zeilen ermitteln

        ' Schatlfächen zurücksetzen

        Me.btnLaden.Enabled = False
        Me.btnSchliessen.Enabled = True

        ' Abhängig von Anzahl der ausgewählten Zeilen ggf. Schaltflächen aktivieren
        If intAnzahlAusgewaehlterZeilen = 1 Then
            ' Wenn genau eine Zeile ausgewählt ist
            Me.btnSchliessen.Enabled = True ' kann man die Anwendung schließen
            Me.btnLaden.Enabled = True
        ElseIf intAnzahlAusgewaehlterZeilen > 1 Then
            Me.btnSchliessen.Enabled = True ' kann man sie schliessen
            Me.btnLaden.Enabled = False ' und nicht bearbeiten
        End If
    End Sub

    Private Sub btnLaden_Click(sender As Object, e As EventArgs) Handles btnLaden.Click

        Dim strKundenID As String
        Dim strBenutzername As String
        Dim strVorname As String
        Dim strName As String


        Dim lviZeile As ListViewItem
        lviZeile = lstviewKundenKonten.SelectedItems(0)

        strKundenID = lviZeile.SubItems(0).Text
        strBenutzername = lviZeile.SubItems(1).Text
        strVorname = lviZeile.SubItems(2).Text
        strName = lviZeile.SubItems(3).Text

    End Sub

    Private Sub lstviewKundenKonten_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstviewKundenKonten.SelectedIndexChanged

        'Muss Kunden aus mlstKunden laden



    End Sub
End Class