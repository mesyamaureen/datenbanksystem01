Public Class frmStart
    ''' <summary>
    ''' Beim Anzeigen des Startfensters wird die Anmeldung durchgeführt.
    ''' Nach der Anmeldung wird das Fenster geschlossen und in die weiteren Hauptfenster verzweigt.
    ''' Wird die Anmeldung abgebrochen, endet die Anwendung.
    ''' </summary>

    Private Sub frmStart_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Initialisierung
        AngemeldeteBenutzer = Nothing 'Aktuell gibt es keinen angemeldeten Benutzer 

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
            Dim strBenutzername As String = dlgAnmeldung.txtBenutzername.Text
            Dim strPasswort As String = dlgAnmeldung.txtPasswort.Text

            'Benutzer mit der eingegebenen Kombination aus Benutzername und Passwort finden

            Dim anmeldenResult As Dictionary(Of String, String) = Logic.logIn(strBenutzername, strPasswort)
            If anmeldenResult("role") = "mitarbeiter" Then
                Dim frm = New frmHauptfensterMitarbeiter(strBenutzername)
                frm.Show()
            ElseIf anmeldenResult("role") = "kunde" Then
                Dim frm = New frmHauptfensterKunde(strBenutzername)
                frm.Show()
            Else
                MsgBox("Anmeldung fehlgeschlagen!", MsgBoxStyle.OkOnly, "Fehler")
            End If

        Loop While AngemeldeteBenutzer Is Nothing

        'Aktuelles Fenster schließen und Anwendung läuft weiter, weil zuvor ein weiteres Hauptfenster geöffnet wurde
        Me.Close()

    End Sub

    Private Sub btnBeenden_Click(sender As Object, e As EventArgs) Handles btnBeenden.Click 'Beenden Schaltfläche
        Me.Close()
    End Sub

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Wird beim Laden des Fensters aufgerufen

    End Sub
End Class
