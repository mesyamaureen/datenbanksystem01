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
        ElseIf intAnzahlAusgewaehlterZeilen <> 1 Then
            Me.btnSchliessen.Enabled = True ' kann man sie schliessen
            Me.btnLaden.Enabled = False ' und nicht bearbeiten
        End If
    End Sub

    Private Sub btnLaden_Click(sender As Object, e As EventArgs) Handles btnLaden.Click

        Dim uintBenutzerID As UInteger
        Dim strBenutzername As String
        Dim strVorname As String
        Dim strName As String


        Dim lviZeile As ListViewItem
        lviZeile = lstviewKundenKonten.SelectedItems(0)

        uintBenutzerID = lviZeile.SubItems(0).Text
        strBenutzername = lviZeile.SubItems(1).Text
        strVorname = lviZeile.SubItems(2).Text
        strName = lviZeile.SubItems(3).Text

    End Sub

    ''' <remark> Als Parameter werden die einzelnen Werte der Attribute einer einzelnen Buchung übergeben </remark>
    Sub anzeigenZeile(plngIndex As Long, puintBenutzerID As UInteger, pstrBenutzername As String, pstrVorname As String, pstrName As String)

        'Neue Zeile in der Liste deklarieren
        Dim zeile As ListViewItem 'Alternativ Windows.Forms.ListViewItem

        'Auf den Inhalt der Liste zugreifen und neue Zeile erzeugen, indem
        'Index als Wert in der ersten Spalte eingetragen wird
        zeile = Me.lstviewKundenKonten.Items.Add(plngIndex)

        'Weitere Eigenschaften des benutzers in nachfolgenden Spalten der Zeile einfügen
        With zeile.SubItems
            .Add(puintBenutzerID)
            .Add(pstrBenutzername)
            .Add(pstrVorname)
            .Add(pstrName)
        End With

    End Sub


    ''' <summary>
    ''' Zeigt die Weiterbildung als Liste an, indem zunächst die Tabelle geleert und 
    ''' dann mit allen Einträgen aus der Liste der Kunden neu gefüllt wird.
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub anzeigen()
        'Deklaration
        Dim anzuzeigenderKunde As Kunde 'Kunden

        'Anzuzeigende Attribute
        Dim uintKundenID As UInteger
        Dim strBenutzername As String
        Dim strName As String
        Dim strVorname As String

        'leeren der Tabelle
        leeren()

        'Für jedes Element soll eine Zeile in der Tabelle hinzugefügt werden
        For i = 0 To mlstKunde.Count - 1
            anzuzeigenderKunde = mlstKunde.Item(i)

            'Attributwerte aus der Weiterbildung lesen
            uintKundenID = anzuzeigenderKunde.BenutzerID
            strBenutzername = anzuzeigenderKunde.Benutzername
            strVorname = anzuzeigenderKunde.Vorname
            strName = anzuzeigenderKunde.Name

            'Hinzufügen einer Zeile in der Tabelle mit den zuvor ermittelten Werten
            anzeigenZeile(i, uintKundenID, strBenutzername, strName, strVorname)

        Next
        ' In der Tabelle ist keine Zeile ausgewählt, deshalb die Schaltflächen deaktivieren, die eine ausgewählte Zeile erfordern
        aktivierenSchaltflächen()

    End Sub

    Sub leeren()
        'Liste leeren
        Me.lstviewKundenKonten.Items.Clear()
        'Schaltflächen aktivieren/deaktivieren
        aktivierenSchaltflächen()

    End Sub

    Private Sub lstviewKundenKonten_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstviewKundenKonten.SelectedIndexChanged

        'Muss Kunden aus mlstKunden laden
        ' Deklaration
        ' Initialisierung
        Dim intAnzahlAusgewaehlterZeilen As Integer = Me.lstviewKundenKonten.SelectedItems.Count ' Anzahl der Zeilen ermitteln

        ' Abhängig von Anzahl der ausgewählten Zeilen ggf. Schaltflächen aktivieren
        If intAnzahlAusgewaehlterZeilen = 1 Then
            ' Wenn genau eine Zeile ausgewählt ist
            Me.btnLaden.Enabled = True ' kann man diesen einsehen

        ElseIf intAnzahlAusgewaehlterZeilen <> 1 Then
            Me.btnLaden.Enabled = False 'nicht bearbeiten
        End If
        anzeigen()


    End Sub

    Private Sub btnSchliessen_Click(sender As Object, e As EventArgs) Handles btnSchliessen.Click
        'Nichts zu tun, Standardverhalten
    End Sub

    Private Sub frmKundenKontoListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mlstKunde = Logic.mlstKunde
        anzeigen()
        aktivierenSchaltflächen()
    End Sub
End Class