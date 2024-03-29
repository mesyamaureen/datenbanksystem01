﻿Public Class BuchungenKunde

    Private angemeldeterKunde As Kunde

    Sub New(angemeldeterKunde As Kunde)
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Me.angemeldeterKunde = angemeldeterKunde
    End Sub

    ''' <summary>
    ''' aktiviert oder deakt abhängig von der in der Tabelle Benutzer getroffenen Auswahl die Schaltflächen die zur Tabelle gehören
    ''' </summary>
    Protected Sub aktivierenSchaltflächen()
        ' Deklaration
        ' Initialisierung
        Dim intAnzahlAusgewaehlterZeilen As Integer = Me.ListViewAktBuchungen.SelectedItems.Count ' Anzahl der Zeilen ermitteln

        ' Abhängig von Anzahl der ausgewählten Zeilen ggf. Schaltflächen aktivieren
        If intAnzahlAusgewaehlterZeilen = 1 Then
            ' Wenn genau eine Zeile ausgewählt ist
            Me.btnLoeschen.Enabled = True ' kann man diese löschen

        ElseIf intAnzahlAusgewaehlterZeilen <> 1 Then
            Me.btnLoeschen.Enabled = False ' kann man sie nicht löschen
        End If

    End Sub
    ''' <summary>
    ''' Tabelle leeren
    ''' </summary>
    Sub leeren()
        Me.ListViewAktBuchungen.Items.Clear()
        'Schaltflächen aktivieren/deaktivieren
        aktivierenSchaltflächen()
    End Sub

    ''' <summary>
    ''' Wird aufgerufen, um die Daten einer Buchung in der Liste der buchung als Zeile anzuzeigen
    ''' </summary>
    ''' <param name="puintBuchungID"></param>
    ''' <param name="pdatKurs"></param>
    ''' <param name="pstrWeiterbilName"></param>
    Sub anzeigenZeile(puintBuchungID As UInteger, pdatKurs As Date, pstrWeiterbilName As String)

        'Neue Zeile in der Liste deklarieren
        Dim zeile As ListViewItem 'Alternativ Windows.Forms.ListViewItem

        'Auf den Inhalt der Liste zugreifen und neue Zeile erzeugen, indem
        'Index als Wert in der ersten Spalte eingetragen wird
        If pdatKurs > Date.Now Then
            zeile = Me.ListViewAktBuchungen.Items.Add(puintBuchungID)
        Else
            zeile = ListViewInaktBuchungen.Items.Add(puintBuchungID)
        End If
        'Weitere Eigenschaften des benutzers in nachfolgenden Spalten der Zeile einfügen
        With zeile.SubItems
            .Add(pdatKurs)
            .Add(pstrWeiterbilName)
        End With
    End Sub

    ''' <summary>
    ''' Zeigt die Buchung als Liste an, indem zunächst die Tabelle geleert und
    ''' dann mit allen Einträgen aus der Liste der Buchung neu gefüllt wird.
    ''' </summary>
    Private Sub anzeigen()
        'Anzuzeigende Attribute
        Dim uintBuchungsID As UInteger
        Dim strWeiterbilName As String
        Dim datKurs As Date

        'leeren der Tabelle
        leeren()

        'Für jedes Element soll eine Zeile in der Tabelle hinzugefügt werden
        For Each buchung As Buchung In ListeBuchung
            If buchung.Teilnehmer.BenutzerID = angemeldeterKunde.BenutzerID Then
                'Attributwerte aus der Buchung lesen
                uintBuchungsID = buchung.BuchungsID
                datKurs = buchung.gebuchterKurs.Zeitpunkt
                strWeiterbilName = buchung.gebuchterKurs.Weiterbildung.Bezeichnung

                'Hinzufügen einer Zeile in der Tabelle mit den zuvor ermittelten Werten
                anzeigenZeile(uintBuchungsID, datKurs, strWeiterbilName)
            End If
        Next
        'In der Tabelle ist keine Zeile ausgewählt, deshalb die Schaltflächen deaktivieren, die eine ausgewählte Zeile erfordern
        aktivierenSchaltflächen()
    End Sub

    ''' <summary>
    ''' Abbrechen Schaltfläche
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Dim msgErgebnis As MsgBoxResult

        msgErgebnis = MsgBox("Möchten Sie wirklich abbrechen? Ihre ungespeicherte Änderungen werden verwirft.", vbQuestion + vbYesNo, "Abbrechen")

        If msgErgebnis = vbNo Then
            DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        End If
    End Sub
    'Textbox von Kunden ID wird deklariert
    Private Sub txtKundenID_TextChanged(sender As Object, e As EventArgs) Handles txtKundenID.TextChanged
        txtKundenID = Me.txtKundenID
    End Sub

    'Beim Löschen einer Buchung
    Private Sub btnLoeschen_Click(sender As Object, e As EventArgs) Handles btnLoeschen.Click
        ' Deklaration
        ' Index des ausgewählten Eintrags der Tabelle
        Dim intIndex As Integer
        Dim msgErgebnis As MsgBoxResult

        ' aus der ausgwählten Zeile im Dialog die ID der Buchung auslesen
        intIndex = Me.ListViewAktBuchungen.SelectedItems(0).Text


        ' Ausbaustufe 1: Rückfrage mit Warnmeldung, ob es wirklich gelöscht werden soll
        msgErgebnis = MsgBox("Möchten Sie Ihre Buchung wirklich löschen?", vbQuestion + vbYesNo, "Abbrechen")

        If msgErgebnis = vbNo Then
            DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        Else
            Me.Close()
        End If

        BookingController.deleteBooking(intIndex)

        ' Fensterinhalt aktualisieren, so dass Tabelle den gelöschten Benutzer nicht mehr zeigt
        anzeigen()

    End Sub

    ''' <summary>
    ''' Laden Schaltfläche
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub BuchungenKunde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Anzeigen der Buchungen in der Tabelle
        anzeigen()
    End Sub

    Private Sub ListViewAktBuchungen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewAktBuchungen.SelectedIndexChanged
        aktivierenSchaltflächen()
    End Sub
End Class
