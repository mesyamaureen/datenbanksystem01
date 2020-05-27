Public Class frmKundenkontoerstellung

    Private Sub frmKundenkontoerstellung_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Deklaration
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



    End Sub
End Class