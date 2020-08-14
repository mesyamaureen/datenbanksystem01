Public Class frmHauptfensterKunde

    Dim angemeldeterKunde As Kunde
    'Parameterloser Konstruktor
    Sub New()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
    End Sub

    'Konstruktor mit Parameter
    Sub New(pstrangemeldeterKunde As String)
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        setKundenContext(pstrangemeldeterKunde)
    End Sub

    'Wird beim Laden des Fenster aufgerufen
    Private Sub frmHauptfensterKunde_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Deklaration
        Dim strBegruessungKunde As String
        Dim strVorname As String
        Dim strNachname As String

        'Initialisierung
        strVorname = Logic.AngemeldeteBenutzer.Item(0).Vorname
        strNachname = Logic.AngemeldeteBenutzer.Item(0).Name

        'eine Begrüßung wird aus Vorname und Nachname zusammengebaut
        strBegruessungKunde = "Willkommen " & strVorname & " " & strNachname & "! " & vbCrLf &
                              "Sie sind als Kunde angemeldet."

        'Ausgabe im Meldungsfenster
        MsgBox(strBegruessungKunde, MsgBoxStyle.OkOnly, "Willkommen")
    End Sub

    ''' <summary>
    ''' aktiviert oder deakt abhängig von der in der Tabelle Benutzer getroffenen Auswahl die Schaltflächen die zur Tabelle gehören
    ''' </summary>
    ''' <remarks> Tabelle = momentan nur Einfachauswahl </remarks>
    Public Sub setKundenContext(strBenutzername As String)
        For Each kndKunde As Kunde In Logic.ListeKunden
            If strBenutzername.Equals(kndKunde.Benutzername) Then
                angemeldeterKunde = kndKunde
            End If
        Next
    End Sub

    ''' <summary>
    ''' aktiviert oder deakt abhängig von der in der Tabelle Benutzer getroffenen Auswahl die Schaltflächen die zur Tabelle gehören
    ''' </summary>
    ''' <remarks> Tabelle = momentan nur Einfachauswahl </remarks>
    Protected Sub aktivierenSchaltflächen()
        'Abhängig von Anzahl der ausgewählten Zeilen ggf. Schaltflächen aktivieren
        If lstviewWeiterbildungKunde.SelectedItems.Count = 1 Then
            Me.btnOeffnen.Enabled = True 'kann geöffnet
        Else
            Me.btnOeffnen.Enabled = False 'kann nicht geöffnet
        End If
    End Sub

    Sub leeren()
        'Liste leeren
        Me.lstviewWeiterbildungKunde.Items.Clear()
        'Schaltflächen aktivieren
        aktivierenSchaltflächen()
    End Sub

    ''' <summary>
    ''' Wird aufgerufen, um die Daten einer Weiterbldung in der Liste der Weiterbildung als Zeile anzuzeigen
    ''' </summary>
    ''' <remark> Als Parameter werden die einzelnen Werte der Attribute einer einzelnen Weiterbildung übergeben </remark>
    Sub anzeigenZeile(puintWeiterbilId As UInteger, pstrWeiterbilName As String, pstrWeiterbilThema As String)

        'Neue Zeile in der Liste deklarieren
        Dim zeile As ListViewItem 'Alternativ Windows.Forms.ListViewItem

        'Auf den Inhalt der Liste zugreifen und neue Zeile erzeugen, indem
        'Index als Wert in der ersten Spalte eingetragen wird
        zeile = Me.lstviewWeiterbildungKunde.Items.Add(puintWeiterbilId)

        'Weitere Eigenschaften des benutzers in nachfolgenden Spalten der Zeile einfügen
        With zeile.SubItems
            .Add(pstrWeiterbilName)
            .Add(pstrWeiterbilThema)
        End With

    End Sub

    ''' <summary>
    ''' Zeigt die Weiterbildung als Liste an, indem zunächst die Tabelle geleert und 
    ''' dann mit allen Einträgen aus der Liste der Weiterbildung neu gefüllt wird.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub anzeigen()
        'leeren der Tabelle
        leeren()

        'Für jedes Element soll eine Zeile in der Tabelle hinzugefügt werden
        For i = 0 To ListeWeiterbildung.Count - 1
            Dim weiterbil As Weiterbildung = ListeWeiterbildung.Item(i)

            'Attributwerte aus der Weiterbildung lesen
            Dim uintWeiterbilId As UInteger = weiterbil.WeiterbildungsID
            Dim strWeiterbilName As String = weiterbil.Bezeichnung
            Dim strWeiterbilThema As String = weiterbil.Thema

            'Hinzufügen einer Zeile in der Tabelle mit den zuvor ermittelten Werten
            anzeigenZeile(uintWeiterbilId, strWeiterbilName, strWeiterbilThema)
        Next
        ' In der Tabelle ist keine Zeile ausgewählt, deshalb die Schaltflächen deaktivieren, die eine ausgewählte Zeile erfordern
        aktivierenSchaltflächen()
    End Sub

    ''' <summary>
    ''' Schaltfläche Öffnen, um die ausgewählte Weiterbildung zu zeigen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOeffnen_Click(sender As Object, e As EventArgs) Handles btnOeffnen.Click
        'Deklaration
        Dim weiterbil = New Weiterbildung()  ' Zu bearbeitener Weiterbildung
        Dim dlg As frmWeiterbildungsfensterKunde  ' Detaildialog zum Anzeigen der Weiterbildung

        'Weiterbildung aus Liste suchen
        For Each weiterbildung In ListeWeiterbildung
            If weiterbildung.WeiterbildungsID = Convert.ToInt32(lstviewWeiterbildungKunde.SelectedItems(0).SubItems(0).Text) Then
                weiterbil = weiterbildung
                Exit For
            End If
        Next

        'Fenster vorbereiten
        dlg = New frmWeiterbildungsfensterKunde(weiterbil, angemeldeterKunde)
        dlg.ShowDialog()

    End Sub

    ''' <summary>
    ''' Laden allen Weiterbildungen und füllen die Oberfläche mit den geladenen Daten
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub frmHauptfensterKunde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Anzeigen der Weiterbildungen in der Tabelle
        anzeigen()
    End Sub

    ''' <summary>
    ''' Verlassen des Hauptfensters
    ''' </summary>
    Private Sub btnBeenden_Click(sender As Object, e As EventArgs) Handles btnBeenden.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Schaltfläche im Menü GroupBox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnBuchungen_Click(sender As Object, e As EventArgs) Handles btnBuchungen.Click
        Dim dlg As BuchungenKunde = New BuchungenKunde(angemeldeterKunde)
        dlg.ShowDialog()
    End Sub



    Private Sub btnKonto_Click(sender As Object, e As EventArgs) Handles btnKonto.Click
        Dim dlg As frmKundeKonto = New frmKundeKonto(angemeldeterKunde)
        dlg.ShowDialog()
    End Sub

    Private Sub lstviewWeiterbildungKunde_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstviewWeiterbildungKunde.SelectedIndexChanged
        aktivierenSchaltflächen()
    End Sub
End Class