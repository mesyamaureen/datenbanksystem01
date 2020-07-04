Public Class frmKundenkontoerstellung

    Private Sub frmKundenkontoerstellung_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Deklaration
        Dim neuerKunde As Kunde
        Dim strVorname As String
        Dim strNachname As String
        Dim strBenutzername As String
        Dim strPasswort As String
        Dim strPasswortWdrhln As String
        Dim datGebDat As Date
        Dim strFirma As String

        'Variable mit dem Dialogfenster verbinden
        strVorname = Me.txtVorname.Text
        strNachname = Me.txtNachname.Text
        strBenutzername = Me.txtBenutzername.Text
        strPasswort = Me.txtPasswort.Text
        strPasswortWdrhln = Me.txtPasswortWdrhln.Text
        datGebDat = Me.datboxGebDat.Value
        strFirma = Me.txtFirma.Text



    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim msgErgebnis As MsgBoxResult

        msgErgebnis = MsgBox("Möchten Sie wirklich abbrechen?", vbQuestion + vbYesNo, "Abbrechen")

        If msgErgebnis = vbNo Then
            DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnNeu_Click(sender As Object, e As EventArgs) Handles btnNeu.Click
        BenutzerDAO.speichernKunde(plstKunde:=mlstKunde)
        Me.Close()


    End Sub

    Private Sub frmKundenkontoerstellung_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class