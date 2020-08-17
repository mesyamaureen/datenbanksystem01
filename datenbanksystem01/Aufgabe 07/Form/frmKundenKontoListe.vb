Public Class frmKundenKontoListe

    Protected Sub aktivierenSchaltflächen()
        ' Abhängig von Anzahl der ausgewählten Zeilen ggf. Schaltflächen aktivieren
        If lstviewKundenKonten.SelectedItems.Count = 1 Then
            ' Wenn genau eine Zeile ausgewählt ist
            Me.btnBearbeiten.Enabled = True
        Else
            Me.btnBearbeiten.Enabled = False ' und nicht bearbeiten
        End If
    End Sub

    Private Sub btnBearbeiten_Click(sender As Object, e As EventArgs) Handles btnBearbeiten.Click

        For i = 0 To ListeKunden.Count - 1
            If ListeKunden(i).BenutzerID = Convert.ToUInt32(lstviewKundenKonten.SelectedItems(0).SubItems(0).Text) Then
                Dim dlg As frmKundeKonto
                dlg = New frmKundeKonto(ListeKunden(i))
                dlg.ShowDialog()

                anzeigen()
                Exit For
            End If
        Next

    End Sub

    ''' <remark> Als Parameter werden die einzelnen Werte der Attribute einer einzelnen Buchung übergeben </remark>
    Sub anzeigenZeile(puintBenutzerID As UInteger, pstrBenutzername As String, pstrVorname As String, pstrName As String, pdatGebDat As Date, pstrFirma As String)

        'Neue Zeile in der Liste deklarieren
        Dim zeile As ListViewItem 'Alternativ Windows.Forms.ListViewItem

        'Auf den Inhalt der Liste zugreifen und neue Zeile erzeugen, indem
        'Index als Wert in der ersten Spalte eingetragen wird
        zeile = Me.lstviewKundenKonten.Items.Add(puintBenutzerID)

        'Weitere Eigenschaften des benutzers in nachfolgenden Spalten der Zeile einfügen
        With zeile.SubItems
            .Add(pstrBenutzername)
            .Add(pstrVorname)
            .Add(pstrName)
            .Add(pdatGebDat)
            .Add(pstrFirma)
        End With

    End Sub


    ''' <summary>
    ''' Zeigt die Weiterbildung als Liste an, indem zunächst die Tabelle geleert und 
    ''' dann mit allen Einträgen aus der Liste der Kunden neu gefüllt wird.
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub anzeigen()
        'leeren der Tabelle
        leeren()

        'Für jedes Element soll eine Zeile in der Tabelle hinzugefügt werden
        For i = 0 To ListeKunden.Count - 1
            Dim anzuzeigenderKunde As Kunde = ListeKunden.Item(i)

            'Hinzufügen einer Zeile in der Tabelle mit den Werten im zuvor bestimmten Kundenobjekt
            anzeigenZeile(anzuzeigenderKunde.BenutzerID,
                          anzuzeigenderKunde.Benutzername,
                          anzuzeigenderKunde.Vorname,
                          anzuzeigenderKunde.Name,
                          anzuzeigenderKunde.Geburtsdatum,
                          anzuzeigenderKunde.Firma)
        Next

        'In der Tabelle ist keine Zeile ausgewählt, deshalb die Schaltflächen deaktivieren, die eine ausgewählte Zeile erfordern
        aktivierenSchaltflächen()

    End Sub

    Sub leeren()
        'Liste leeren
        Me.lstviewKundenKonten.Items.Clear()
        'Schaltflächen aktivieren/deaktivieren
        aktivierenSchaltflächen()

    End Sub

    Private Sub lstviewKundenKonten_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstviewKundenKonten.SelectedIndexChanged
        aktivierenSchaltflächen()
    End Sub

    Private Sub btnSchliessen_Click(sender As Object, e As EventArgs) Handles btnSchliessen.Click
        'Nichts zu tun, Standardverhalten
    End Sub

    Private Sub frmKundenKontoListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        anzeigen()
        aktivierenSchaltflächen()
    End Sub
End Class