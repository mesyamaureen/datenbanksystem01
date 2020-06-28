Public Class frmNeueWeiterbildung
    'Deklaration
    Public mneueWeiterbildung As Weiterbildung

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        mneueWeiterbildung = New Weiterbildung
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        'Messagebox
        Dim mbrResult As MsgBoxResult
        'Verzweigung
        If Me.DialogResult = Windows.Forms.DialogResult.None Then
            mbrResult = MsgBox("Möchten Sie wirklich abbrechen? Ihre ungespeicherte Änderungen werden verwirft.",
                                MsgBoxStyle.Question + vbYesNo, "Abbrechen")
            If mbrResult = vbNo Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub anzeigen()
        Me.txtSeminartitel.Enabled = True
        Me.rtxtboxSeminarbeschreibung.Enabled = True
        Me.rtxtboxSeminarinfo.Enabled = True
        Me.rtxtboxTeilnehmerkreis.Enabled = True
        Me.lstviewKurse.Enabled = True
        Me.btnLeeren.Enabled = True
        Me.btnLoeschen.Enabled = True
        Me.btnNeuerKurs.Enabled = True

        Me.txtSeminartitel.Text = 

    End Sub
End Class