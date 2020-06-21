Public Class frmBenutzerAlle

    Public mlstMitarbeiter As List(Of Mitarbeiter)
    Public mlstAktuellAngemeldeteBenutzer As List(Of Benutzer)
    Public mlstBenutzerAlle As List(Of Benutzer)
    Public lsvBenutzerAlle As ListView

    Dim intAusgewaehlteZeilen As Integer

    Public ReadOnly Property AlleMitarbeiter As List(Of Mitarbeiter)
        Get
            Return mlstMitarbeiter
        End Get
    End Property


    Protected Sub aktivierenSchaltflächen()
        ' Deklaration
        Dim intAnzahlAusgewaehlterZeilen As Integer ' Anzahl der ausgewählten Zeilen

        ' Initialisierung
        intAnzahlAusgewaehlterZeilen = Me.lsvBenutzerAlle.SelectedItems.Count ' Anzahl der Zeilen ermitteln

        ' Schatlfächen zurücksetzen
        Me.btnLoeschen.Enabled = False
        Me.btnBearbeiten.Enabled = False
        Me.btnHinzufuegen.Enabled = True

        ' Abhängig von Anzahl der ausgewählten Zeilen ggf. Schaltflächen aktivieren
        If intAnzahlAusgewaehlterZeilen = 1 Then
            ' Wenn genau eine Zeile ausgewählt ist
            Me.btnLoeschen.Enabled = True ' kann man diese löschen oder bearbeiten
            Me.btnBearbeiten.Enabled = True
        ElseIf intAnzahlAusgewaehlterZeilen > 1 Then
            Me.btnLoeschen.Enabled = False ' kann man sie nicht löschen 
            Me.btnBearbeiten.Enabled = False ' und nicht bearbeiten
        End If
    End Sub


    Private Sub btnHinzufuegen_Click(sender As Object, e As EventArgs) Handles btnHinzufuegen.Click
        ' Deklaration
        ' Zu bearbeitener Benutzer
        Dim ErstellterBenutzer As Benutzer
        ' Detaildialog zum Anzeigen des Benutzers


        ' neuen Benutzer erzeugen

        ' Fenster vorbereiten

        ' Auswertung des Dialogergebnisses
        '   Dialog mit positivem Ergebnis geschlossen

        '   Neuen Benutzer aus dem Formular geben lassen und zur Liste der Benutzer hinzufügen

        ' Fensterinhalt aktualisieren, so dass Tabelle auch die Änderungen des Benutzers zeigt
    End Sub

    Private Sub btnBearbeiten_Click(sender As Object, e As EventArgs) Handles btnBearbeiten.Click
        ' Deklaration
        '   Index des ausgewählten Eintrags der Tabelle
        Dim intIndex As Integer
        '   Zu bearbeitener Benutzer
        Dim mit As Mitarbeiter
        '   Detaildialog zum Anzeigen des Benutzers
        Dim dlgBenutzerEinzeln As frmBenutzerEinzeln

        ' aus der ausgwählten Zeile im Dialog die ID des Urlaubsantrags auslesen
        intIndex = Me.lsvBenutzerAlle.Items(0).Text

        ' Element an der Position der Liste, die der ID entspricht ermitteln
        mit = Aufgabe_07.mlstBenutzerAlle(intIndex)
        ' Fenster vorbereiten
        dlgAnmeldung = New dlgBenutzerEinzeln
        ' Auswertung des Dialogergebnisses
        '   Dialog mit positivem Ergebnis geschlossen

        '   Neuen Benutzer aus dem Formular geben lassen 


        ' Hinweis: WEIL OBJKETE REFERENZTYPEN SIND, IST DIE LISTE DER URLAUBSANTRÄGE
        ' BEREITS JETZT AKTUALISIERT. ES MUSS NICHTS HINZUGEFÜGT WERDEN!

        ' Fensterinhalt aktualisieren, so dass Tabelle auch die Änderungen des Benutzers zeigt

    End Sub

    Private Sub btnLoeschen_Click(sender As Object, e As EventArgs) Handles btnLoeschen.Click
        ' Deklaration
        ' Index des ausgewählten Eintrags der Tabelle   
        Dim intIndex As Integer
        ' Ausbaustufe1: Ergebnis der Warnmeldung, ob wirklich gelöscht werden soll
        ' Ausbaustufe2: Zu löschender Benutzer

        ' aus der ausgwählten Zeile im Dialog die ID des Urlaubsantrags auslesen
        intIndex = Me.lsvBenutzerAlle.SelectedItems(0).Text

        ' Ausbaustufe 2: Element an der Position der Liste, die der ID entspricht ermitteln


        ' Ausbaustufe 1: Rückfrage mit Warnmeldung und in Ausbaustufe 2 mit Angaben des Benutzers

        ' Benzter löschen
        Aufgabe_07.ListeMitarbeiter.RemoveAt(intIndex)
        ' aus Liste aller Benutzer entfernen

        ' Referenz auf Benutzer auf Nichts setzen, um Müllabfuhr anzufordern

        ' Fensterinhalt aktualisieren, so dass Tabelle den gelöschten Benutzer nicht mehr zeigt
        anzeigen()
    End Sub


    Private Sub btnBeenden_Click(sender As Object, e As EventArgs) Handles btnBeenden.Click
        ' Einfach das Fenster zumachen, damit endet auch die Anwendung
        Me.Close()
    End Sub



    Sub leeren()
        ' Liste leeren; ACHTUNG: Items.Clear() nicht einfach nur Clear() sonst sind auch die Spalten weg!
        Me.lsvBenutzerAlle.Items.Clear()
        ' Schaltflächen aktivieren/deaktivieren
        aktivierenSchaltflächen()
    End Sub

    Sub anzeigenZeile(plngIndex As Long, pstrBenutzername As String, pstrName As String, pstrVorname As String, pstrRolle As String)

        ' Neue Zeile in der Liste deklarieren
        Dim zeile As ListViewItem ' Alternativ Windows.Forms.ListViewItem

        ' Auf den Inhalt der Liste zugreifen und neue Zeile erzeugen, indem 
        ' Index als Wert in der ersten Spalte eingetragen wird
        zeile = Me.lsvBenutzerAlle.Items.Add(plngIndex)

        ' Weitere Eigenschaften des Benutzers in nachfolgenden Spalten 
        ' der Zeile einfügen
        With zeile.SubItems
            .Add(pstrBenutzername)
            .Add(pstrName)
            .Add(pstrVorname)
            .Add(pstrRolle)
        End With

    End Sub
    Private Sub anzeigen()
        ' Deklaration
        Dim mit As Mitarbeiter
        Dim knd As Kunde
        Dim intAnzahlAusgewaehlterZeilen As Integer
        ' Benutzer
        ' Anzuzeigende Attribute
        Dim strBenutzername As String
        Dim strName As String
        Dim strVorname As String
        Dim strRolle As String

        ' Leeren der Tabelle
        leeren()

        ' Für jedes Element soll eine Zeile in der Tabelle hinzugefügt werden
        ' Element aus der Liste ermitteln

        ' Attributwerte aus dem Benutzer lesen

        ' restliche Attribute mit leeren Werten initialisieren

        ' Hinzufügen einer Zeile in der Tabelle mit den zuvor ermittelten Werten

        ' In der Tabelle ist keine Zeile ausgewählt, deshalb die Schaltflächen deaktivieren, die
        ' eine ausgewählte Zeile erfordern
        If intAnzahlAusgewaehlterZeilen = 0 Then
            btnLoeschen.Enabled = False
            btnBearbeiten.Enabled = False
            btnHinzufuegen.Enabled = True
        End If

    End Sub

    ''' <summary>
    ''' Sobald sich die getroffene Auswahl in der Liste/Tabelle der Benutzer ändert, müssen die zur Tabelle
    ''' gehörigen Schaltflächen aktiviert oder deaktiviert werden.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub lsvBenutzerAlle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvMitarbeiterAlle.SelectedIndexChanged
        ' Schaltlfächen aktivieren oder dekativieren abhängig von der getroffenen Auswahl
        aktivierenSchaltflächen()
    End Sub

    Private Sub frmMitarbeiter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Alle Benutzer laden
        mlstMitarbeiter = Logic.mlstMitarbeiter

        ' Abhängig von der Rolle die Schaltfläche des Fensters aktivieren

        ' Anzeigen der Benutzer in der Tabelle
        anzeigen()

    End Sub


    Private Sub frmMitarbeiter_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        ' Klassenoperation zum aktualiseren der gepeicherten der Daten aufrufen
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

End Class