Public Class frmStart
    ''' <summary>
    ''' Beim Anzeigen des Startfensters wird die Anmeldung durchgeführt.
    ''' Nach der Anmeldung wird das Fenster geschlossen und in die weiteren Hauptfenster verzweigt.
    ''' Wird die Anmeldung abgebrochen, endet die Anwendung.
    ''' </summary>

    Private Sub frmStart_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Deklaration
        Dim strBenutzername As String 'im Anmeldedialog übergegeben werden
        Dim strPasswort As String 'im Anmeldedialog übergegeben werden

        'Initialisierung
        Logic.mlstAktuellAngemeldeterBenutzer = Nothing 'Aktuell gibt es keinen angemeldeten Benutzer 

        'Aufrufen anderer Funktion
        Logic.initialise()


        'Nachprüfende Schleife 
        Do
            dlgAnmeldung.ShowDialog() 'Anmeldedialog anzeigen 

            '    'Prüfen, ob der Dialog mit OK geschlossen wurde
            If Not dlgAnmeldung.DialogResult = Windows.Forms.DialogResult.OK Then
                '        'wenn nicht, dann Fenster schliessen und damit endet die Anwendung
                Me.Close()
                Exit Sub 'Prozedur verlassen, damit die Anwendung hier endet
            End If

            'Benutzername und Passwort von dem Dialogfenster ermitteln
            strBenutzername = dlgAnmeldung.txtBenutzername.Text
            strPasswort = dlgAnmeldung.txtPasswort.Text

            'Benutzer mit der eingegebenen Kombination aus Benutzername und Passwort finden
            Dim anmeldenResult As Dictionary(Of String, String) = Logic.logIn(strBenutzername, strPasswort)
            If anmeldenResult("role") = "mitarbeiter" Then
                frmHauptfensterMitarbeiter.Show()
            ElseIf anmeldenResult("role") = "kunde" Then
                frmHauptfensterKunde.Show()
            Else
                MsgBox("Anmeldung fehlgeschlagen!", MsgBoxStyle.OkOnly, "Fehler")
            End If

        Loop While Logic.mlstAktuellAngemeldeterBenutzer Is Nothing

        'Aktuelles Fenster schließen und Anwendung läuft weiter, weil zuvor ein weiteres Hauptfenster geöffnet wurde
        Me.Close()

    End Sub
    Private Sub btnBeenden_Click(sender As Object, e As EventArgs) Handles btnBeenden.Click
        Me.Close()
    End Sub


End Class
