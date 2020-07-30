﻿Public Class frmWeiterbildungsfensterKunde
    'Attribute
    Public mWeiterbil As Weiterbildung 'die zu öffene Weiterbildung
    Public mKurse As List(Of Kurs) 'eine Liste von Kursen der Weiterbildung
    Public mBookingControl As BookingController
    Private kunde As Kunde

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        mWeiterbil = New Weiterbildung
        mKurse = New List(Of Kurs)
        kunde = New Kunde
    End Sub

    Public Sub New(pWeiterbildung As Weiterbildung, kunde As Kunde)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        mWeiterbil = pWeiterbildung
        mKurse = New List(Of Kurs)
        Me.kunde = kunde
    End Sub

    ''' <summary>
    ''' Beim Klick auf Abbrechen folgt das Standardverhalten
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Die Schaltfläche Abbrechen ist als Cancel-Button eingestellt und liefert das DialogResult Cancel.</remarks>
    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        'Nichts zu tun, Standardverhalten
    End Sub

    Private Sub anzeigen()
        Me.txtboxSeminartitel.Enabled = False

        Me.rtxtboxSeminarbeschreibung.Enabled = False
        Me.rtxtboxTeilnkreis.Enabled = False
        Me.rtxtboxSeminarinfo.Enabled = False

        Me.lstviewKurse.Enabled = True

        'TODO: Me.listview.Kurs ?????
    End Sub

    Function gibWeiterbildung() As Weiterbildung
        'Eigenschaften der Weiterbildung aus den Feldern der Oberfläche lesen
        mWeiterbil.Bezeichnung = Me.txtboxSeminartitel.Text
        mWeiterbil.Curriculum = Me.rtxtboxSeminarbeschreibung.Text
        mWeiterbil.Teilnehmerkreis = Me.rtxtboxTeilnkreis.Text
        mWeiterbil.Thema = Me.rtxtboxSeminarinfo.Text
        'mWeiterbil.LstKurs.Add(Me.lstviewKurse.Items)
        ' TODO: m... = Me.listview.Kurs ????

        'Bearbeitete Weiterbildung als Ergebnis zurückgeben
        Return mWeiterbil
    End Function

    'Long Index deklarieren
    Public lngIndex As Long ' Index des ausgewählten Eintrags der Tabelle
    ''' <summary>
    ''' Ausgewählter Kurs buchen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnBuchen_Click(sender As Object, e As EventArgs) Handles btnBuchen.Click
        'Deklaration
        Dim buchenderKurs = New Kurs()

        'Kurs Objekt aus Liste suchen
        For Each kurs As Kurs In Logic.ListeKurse
            If kurs.KursID = Convert.ToUInt32(Me.lstviewKurse.SelectedItems(0).SubItems(1).Text) Then
                buchenderKurs = kurs
                Exit For
            End If
        Next

        'Buchen Funktion aufrufen mit mWeiterbil als Parameter für Weiterbildung
        'und zur Liste aller Buchungen hinzufügen
        Logic.ListeBuchung.Add(mBookingControl.createBooking(buchenderKurs, kunde)) 'Rückgabewert Als Neue Buchung von Bookingcontroller

        'Meldungsfenster vorbereiten
        MsgBox("Sie haben eine neue Buchung hinzugefügt.", MsgBoxStyle.OkOnly, "Neue Buchung")

    End Sub

    Protected Sub aktivierenSchaltflächenKurs()
        'Schaltfläche zurücksetzen
        'Me.btnBuchen.Enabled = False
        'braucht nicht zurückgesetzt werden, da default

        'Abhängig von Anzahl der ausgewählten Zeilen ggf. Schaltflächen aktivieren
        If Me.lstviewKurse.SelectedItems.Count = 1 Then
            Me.btnBuchen.Enabled = True
        Else
            Me.btnBuchen.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Liste von Kurse anzeigen
    ''' </summary>
    ''' <param name="plngIndex"></param>
    ''' <param name="puintKursID"></param>
    ''' <param name="pdatKursDatum"></param>
    ''' <param name="pbolVerfuegbarkeit"></param>
    ''' <param name="pdecKursPreis"></param>
    Sub anzeigenZeileKurs(plngIndex As Long, puintKursID As String, pdatKursDatum As Date, pbolVerfuegbarkeit As Boolean, pdecKursPreis As Decimal)
        'Neue Zeile in der Liste deklarieren
        Dim zeile As ListViewItem 'Alternativ Windows.Forms.ListViewItem

        'Auf den Inhalt der Liste zugreifen und neue Zeile erzeugen, indem
        'Index als Wert in der ersten Spalte eingetragen wird
        zeile = Me.lstviewKurse.Items.Add(plngIndex)

        'Weitere Eigenschaften des benutzers in nachfolgenden Spalten der Zeile einfügen
        With zeile.SubItems
            .Add(puintKursID)
            .Add(pdatKursDatum)
            .Add(pbolVerfuegbarkeit)
            .Add(pdecKursPreis)
        End With
    End Sub

    ''' <summary>
    ''' Tabelle mit der Liste von Kurs in Datenbank verknüpfen
    ''' </summary>
    Private Sub anzeigenKurs()
        'Deklaration
        Dim Kurs As Kurs 'Kurs

        'Anzuzeigende Attribute
        Dim uintKursID As String
        Dim datKursDatum As Date
        Dim bolVerfuegbarkeit As Boolean
        Dim decKursPreis As Decimal

        'leeren der Tabelle
        Me.lstviewKurse.Items.Clear()

        'Für jedes Element soll eine Zeile in der Tabelle hinzugefügt werden
        For i = 0 To ListeKurse.Count - 1
            Kurs = ListeKurse.Item(i)

            'Attributwerte aus der Weiterbildung lesen
            uintKursID = Kurs.KursID
            datKursDatum = Kurs.Zeitpunkt
            bolVerfuegbarkeit = Kurs.Verfuegbar
            decKursPreis = Kurs.Preis

            'Hinzufügen einer Zeile in der Tabelle mit den zuvor ermittelten Werten
            anzeigenZeileKurs(i, uintKursID, datKursDatum, bolVerfuegbarkeit, decKursPreis)

        Next
        ' In der Tabelle ist keine Zeile ausgewählt, deshalb die Schaltflächen deaktivieren, die eine ausgewählte Zeile erfordern
        aktivierenSchaltflächenKurs()
    End Sub

    Private Sub frmWeiterbildungsfensterKunde_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Deklaration für jede Oberflächenelemente
        'Dim titel As String
        'Dim curriculum As String
        'Dim teilnkreis As String
        'Dim thema As String

        For i = 0 To frmHauptfensterKunde.intIndex
            Me.txtboxSeminartitel.Text = Logic.mlstWeiterbildungen.Item(i).Bezeichnung
            Me.rtxtboxSeminarbeschreibung.Text = Logic.mlstWeiterbildungen.Item(i).Curriculum
            Me.rtxtboxTeilnkreis.Text = Logic.mlstWeiterbildungen.Item(i).Teilnehmerkreis
            Me.rtxtboxSeminarinfo.Text = Logic.mlstWeiterbildungen.Item(i).Thema

        Next

        'alle anzeigen Funktion aufrufen
        anzeigen()
        anzeigenKurs()
        aktivierenSchaltflächenKurs()
    End Sub

    Private Sub lstviewKurse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstviewKurse.SelectedIndexChanged
        aktivierenSchaltflächenKurs()
    End Sub

    'Function gibBuchung() As Buchung
    'Eigenschaften des Kurses aus den Feldern der Oberfläche lesen
    'Neue Buchung als Ergebnis zurückgeben
    'End Function


End Class

