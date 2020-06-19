Public Class frmAlleBenutzer

    Private mlstBenutzerAlle As List(Of Benutzer)
    Dim intAusgewaehlteZeilen As Integer


    ''' <summary>
    ''' Aktiviert oder deaktiviert abhängig von der in der Tabelle Benutzer getroffenen Auswahl die Schaltlächen
    ''' die zur Tabelle gehören.
    ''' </summary>
    ''' <remarks>Tabelle unterstützt momentan nur Einfachauswahl, wenn Mehrfachauswahl möglich ist, dann ggf.
    ''' das Löschen so anpassen, dass auch mehrere markierte Zeilen gelöscht werden können</remarks>
    Protected Sub aktivierenSchaltflächen()
        ' Deklaration
        Dim intAnzahlAusgewaehlterZeilen As Integer ' Anzahl der ausgewählten Zeilen

        ' Initialisierung
        intAnzahlAusgewaehlterZeilen = Me.lsvBenutzerAlle.SelectedItems.Count ' Anzahl der Zeilen ermitteln

        ' Schatlfächen zurücksetzen
        Me.btnLoeschen.Enabled = False
        Me.btnDetails.Enabled = False
        Me.btnNeu.Enabled = True

        ' Abhängig von Anzahl der ausgewählten Zeilen ggf. Schaltflächen aktivieren
        If intAnzahlAusgewaehlterZeilen = 1 Then
            ' Wenn genau eine Zeile ausgewählt ist
            Me.btnLoeschen.Enabled = True ' kann man diese löschen oder bearbeiten
            Me.btnDetails.Enabled = True
        ElseIf intAnzahlAusgewaehlterZeilen > 1 Then
            Me.btnLoeschen.Enabled = False ' kann man sie nicht löschen 
            Me.btnDetails.Enabled = False ' und nicht bearbeiten
        End If
    End Sub



    Private Sub frmAlleBenutzer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    ''' <summary>
    ''' Leert die Liste mit den Urlaubsanträgen komplett. Weil nach dem Leeren keine Auswahl in der Liste mehr getroffen ist,  
    ''' setzt den Status des Formulars zurück, z.B. deaktiviert sie die Schaltflächen Bearbeiten und Löschen.
    ''' </summary>
    Sub leeren()
            ' Liste leeren; ACHTUNG: Items.Clear() nicht einfach nur Clear() sonst sind auch die Spalten weg!
            Me.lsvBenutzerAlle.Items.Clear()
            ' Schaltflächen aktivieren/deaktivieren
            aktivierenSchaltflächen()
        End Sub

    ''' <summary>
    ''' Wird aufgerufen, um die Daten eines Benutzers in der Liste der 
    ''' Benutzer als Zeile anzuzeigen.
    ''' </summary>
    ''' <remarks>Als Parameter werden die einzelnen Werte der Attribute eines 
    ''' einzelnen Benutzers übergeben.</remarks>
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

    ''' <summary>
    ''' Zeigt die Benutzer als Liste an, indem zunächst die Tabelle geleert und dann mit allen
    ''' Einträgen aus der Liste der Benutzer neu gefüllt wird.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub anzeigen()
        ' Deklaration
        Dim BenutzerAnzeigen As Benutzer
        Dim intAnzahlAusgewaehlterZeilen As Integer
        ' Benutzer
        ' Anzuzeigende Attribute

        ' Leeren der Tabelle

        ' Für jedes Element soll eine Zeile in der Tabelle hinzugefügt werden
        ' Element aus der Liste ermitteln

        ' Attributwerte aus dem Benutzer lesen

        ' restliche Attribute mit leeren Werten initialisieren

        ' Hinzufügen einer Zeile in der Tabelle mit den zuvor ermittelten Werten

        ' In der Tabelle ist keine Zeile ausgewählt, deshalb die Schaltflächen deaktivieren, die
        ' eine ausgewählte Zeile erfordern
        If IntAnzahlAusgewaehlterZeilen = 0 Then
            btnLoeschen.Enabled = False
            btnDetails.Enabled = False
            btnNeu.Enabled = True
        End If

    End Sub

        ''' <summary>
        ''' Sobald sich die getroffene Auswahl in der Liste/Tabelle der Benutzer ändert, müssen die zur Tabelle
        ''' gehörigen Schaltflächen aktiviert oder deaktiviert werden.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub lsvBenutzerAlle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvBenutzerAlle.SelectedIndexChanged
            ' Schaltlfächen aktivieren oder dekativieren abhängig von der getroffenen Auswahl
            aktivierenSchaltflächen()
        End Sub



    ''' <summary>
    ''' Beim Klick auf Beenden soll das Fenster geschlossen und die Anwendung beendet werden.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Die Warnmeldung wird durch die Closing()-Ereignisprozedur angezeigt.</remarks>
    Private Sub btnBeenden_Click(sender As Object, e As EventArgs) Handles btnBeenden.Click
            ' Einfach das Fenster zumachen, damit endet auch die Anwendung
            Me.Close()
        End Sub

        ''' <summary>
        ''' Klick auf Löschen in der Sekundärnavigation löscht den Benutzer, der zur ausgewählten Zeile der Tabelle gehört nach
        ''' vorheriger Warnmeldung.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>Löschen unterstützt momentan nur die Einfachauswahl in der Tabelle der Benutzer.</remarks>
        Private Sub btnLoeschen_Click(sender As Object, e As EventArgs) Handles btnLoeschen.Click

            ' Deklaration
            ' Index des ausgewählten Eintrags der Tabelle        
            ' Ausbaustufe1: Ergebnis der Warnmeldung, ob wirklich gelöscht werden soll
            ' Ausbaustufe2: Zu löschender Benutzer

            ' aus der ausgwählten Zeile im Dialog die ID des Urlaubsantrags auslesen


            ' Ausbaustufe 2: Element an der Position der Liste, die der ID entspricht ermitteln

            ' Ausbaustufe 1: Rückfrage mit Warnmeldung und in Ausbaustufe 2 mit Angaben des Benutzers

            ' Benzter löschen
            ' aus Liste aller Benutzer entfernen
            ' Referenz auf Benutzer auf Nichts setzen, um Müllabfuhr anzufordern

            ' Fensterinhalt aktualisieren, so dass Tabelle den gelöschten Benutzer nicht mehr zeigt
            anzeigen()

        End Sub

        ''' <summary>
        ''' Klick auf Bearbeiten öffnet den aktuell in der Tabelle ausgewählten Benutzer in einem Detaildialog.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnBearbeiten_Click(sender As Object, e As EventArgs) Handles btnBearbeiten.Click

            ' Deklaration
            '   Index des ausgewählten Eintrags der Tabelle
            '   Zu bearbeitener Benutzer
            '   Detaildialog zum Anzeigen des Benutzers

            ' aus der ausgwählten Zeile im Dialog die ID des Urlaubsantrags auslesen

            ' Element an der Position der Liste, die der ID entspricht ermitteln

            ' Fenster vorbereiten

            ' Auswertung des Dialogergebnisses
            '   Dialog mit positivem Ergebnis geschlossen

            '   Neuen Benutzer aus dem Formular geben lassen 

            ' Hinweis: WEIL OBJKETE REFERENZTYPEN SIND, IST DIE LISTE DER URLAUBSANTRÄGE
            ' BEREITS JETZT AKTUALISIERT. ES MUSS NICHTS HINZUGEFÜGT WERDEN!

            ' Fensterinhalt aktualisieren, so dass Tabelle auch die Änderungen des Benutzers zeigt


        End Sub

    ''' <summary>
    ''' Klick auf Hinzufügen öffnet einen neuen Benutzer in einem Detaildialog.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnNeu_Click(sender As Object, e As EventArgs) Handles btnNeu.Click

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

    ''' <summary>
    ''' Laden aller Benutzer und füllen der Oberfläche mit den geladenen Daten
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub frmBenutzerAlle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            ' Alle Benutzer laden

            ' Abhängig von der Rolle die Schaltfläche des Fensters aktivieren

            ' Anzeigen der Benutzer in der Tabelle

        End Sub

        ''' <summary>
        ''' Speichern der Daten, sobald das Fenster geschlossen wurde
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub frmBenutzerAlle_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

            ' Klassenoperation zum aktualiseren der gepeicherten der Daten aufrufen
        End Sub

        Private Sub lblBenutzerAlle_Click(sender As Object, e As EventArgs) Handles lblBenutzerAlle.Click

        End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class