Public Class frmNeueMitarbeiter

    Private Sub frmKundenkontoerstellung_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Deklaration
        Dim neuerMitarbeiter As Mitarbeiter
        Dim strVorname As String
        Dim strNachname As String
        Dim strBenutzername As String
        Dim strPasswort As String
        Dim strPasswortWdrhln As String
        Dim datGebDat As Date

        'Variable mit dem Dialogfenster verbinden
        strVorname = Me.txtboxVorname.Text
        strNachname = Me.txtboxName.Text
        strBenutzername = Me.txtboxBenutzername.Text
        strPasswort = Me.txtboxPasswort.Text
        strPasswortWdrhln = Me.txtboxPasswortW.Text
        datGebDat = Me.datboxGebDatM.Value

    End Sub

    Private Sub btnErstellen_Click(sender As Object, e As EventArgs) Handles btnErstellen.Click

        Dim neuerMitarbeiter As Mitarbeiter = New Mitarbeiter(Me.txtboxBenutzername.Text,
                                            Me.txtboxPasswort.Text,
                                            Me.txtboxName.Text,
                                            Me.txtboxVorname.Text,
                                            Me.datboxGebDatM.Value)

        mlstMitarbeiter.Add(neuerMitarbeiter)

        BenutzerDAO.speichernMitarbeiter(mlstMitarbeiter)

        Me.Close()

    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Dim msgErgebnis As MsgBoxResult

        msgErgebnis = MsgBox("Möchten Sie wirklich abbrechen?", vbQuestion + vbYesNo, "Abbrechen")

        If msgErgebnis = vbNo Then
            DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        Else
            Me.Close()
        End If
    End Sub


End Class