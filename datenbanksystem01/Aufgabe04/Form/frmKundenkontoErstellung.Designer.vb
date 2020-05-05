<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKundenkontoerstellung
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblVorname = New System.Windows.Forms.Label()
        Me.lblNachname = New System.Windows.Forms.Label()
        Me.lblBenutzername = New System.Windows.Forms.Label()
        Me.lblPasswort = New System.Windows.Forms.Label()
        Me.lblPasswortWdrhln = New System.Windows.Forms.Label()
        Me.lblGebDat = New System.Windows.Forms.Label()
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.lblFirma = New System.Windows.Forms.Label()
        Me.txtVorname = New System.Windows.Forms.TextBox()
        Me.txtNachname = New System.Windows.Forms.TextBox()
        Me.txtBenutzername = New System.Windows.Forms.TextBox()
        Me.txtPasswort = New System.Windows.Forms.TextBox()
        Me.txtPasswortWdrhln = New System.Windows.Forms.TextBox()
        Me.txtFirma = New System.Windows.Forms.TextBox()
        Me.datboxGebDat = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lblVorname
        '
        Me.lblVorname.AutoSize = True
        Me.lblVorname.Location = New System.Drawing.Point(64, 79)
        Me.lblVorname.Name = "lblVorname"
        Me.lblVorname.Size = New System.Drawing.Size(74, 20)
        Me.lblVorname.TabIndex = 0
        Me.lblVorname.Text = "Vorname"
        '
        'lblNachname
        '
        Me.lblNachname.AutoSize = True
        Me.lblNachname.Location = New System.Drawing.Point(64, 169)
        Me.lblNachname.Name = "lblNachname"
        Me.lblNachname.Size = New System.Drawing.Size(86, 20)
        Me.lblNachname.TabIndex = 1
        Me.lblNachname.Text = "Nachname"
        '
        'lblBenutzername
        '
        Me.lblBenutzername.AutoSize = True
        Me.lblBenutzername.Location = New System.Drawing.Point(64, 259)
        Me.lblBenutzername.Name = "lblBenutzername"
        Me.lblBenutzername.Size = New System.Drawing.Size(114, 20)
        Me.lblBenutzername.TabIndex = 2
        Me.lblBenutzername.Text = "Benutzername"
        '
        'lblPasswort
        '
        Me.lblPasswort.AutoSize = True
        Me.lblPasswort.Location = New System.Drawing.Point(64, 354)
        Me.lblPasswort.Name = "lblPasswort"
        Me.lblPasswort.Size = New System.Drawing.Size(74, 20)
        Me.lblPasswort.TabIndex = 3
        Me.lblPasswort.Text = "Passwort"
        '
        'lblPasswortWdrhln
        '
        Me.lblPasswortWdrhln.AutoSize = True
        Me.lblPasswortWdrhln.Location = New System.Drawing.Point(64, 446)
        Me.lblPasswortWdrhln.Name = "lblPasswortWdrhln"
        Me.lblPasswortWdrhln.Size = New System.Drawing.Size(163, 20)
        Me.lblPasswortWdrhln.TabIndex = 4
        Me.lblPasswortWdrhln.Text = "Passwort wiederholen"
        '
        'lblGebDat
        '
        Me.lblGebDat.AutoSize = True
        Me.lblGebDat.Location = New System.Drawing.Point(64, 523)
        Me.lblGebDat.Name = "lblGebDat"
        Me.lblGebDat.Size = New System.Drawing.Size(112, 20)
        Me.lblGebDat.TabIndex = 5
        Me.lblGebDat.Text = "Geburtsdatum"
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Location = New System.Drawing.Point(853, 880)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(103, 39)
        Me.btnSpeichern.TabIndex = 6
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(985, 880)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(103, 39)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(1111, 880)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(103, 39)
        Me.btnAbbrechen.TabIndex = 8
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'lblFirma
        '
        Me.lblFirma.AutoSize = True
        Me.lblFirma.Location = New System.Drawing.Point(64, 603)
        Me.lblFirma.Name = "lblFirma"
        Me.lblFirma.Size = New System.Drawing.Size(49, 20)
        Me.lblFirma.TabIndex = 9
        Me.lblFirma.Text = "Firma"
        '
        'txtVorname
        '
        Me.txtVorname.Location = New System.Drawing.Point(260, 66)
        Me.txtVorname.Multiline = True
        Me.txtVorname.Name = "txtVorname"
        Me.txtVorname.Size = New System.Drawing.Size(954, 48)
        Me.txtVorname.TabIndex = 10
        '
        'txtNachname
        '
        Me.txtNachname.Location = New System.Drawing.Point(260, 152)
        Me.txtNachname.Multiline = True
        Me.txtNachname.Name = "txtNachname"
        Me.txtNachname.Size = New System.Drawing.Size(954, 48)
        Me.txtNachname.TabIndex = 11
        '
        'txtBenutzername
        '
        Me.txtBenutzername.Location = New System.Drawing.Point(260, 247)
        Me.txtBenutzername.Multiline = True
        Me.txtBenutzername.Name = "txtBenutzername"
        Me.txtBenutzername.Size = New System.Drawing.Size(954, 48)
        Me.txtBenutzername.TabIndex = 12
        '
        'txtPasswort
        '
        Me.txtPasswort.Location = New System.Drawing.Point(260, 336)
        Me.txtPasswort.Multiline = True
        Me.txtPasswort.Name = "txtPasswort"
        Me.txtPasswort.Size = New System.Drawing.Size(954, 48)
        Me.txtPasswort.TabIndex = 13
        '
        'txtPasswortWdrhln
        '
        Me.txtPasswortWdrhln.Location = New System.Drawing.Point(260, 431)
        Me.txtPasswortWdrhln.Multiline = True
        Me.txtPasswortWdrhln.Name = "txtPasswortWdrhln"
        Me.txtPasswortWdrhln.Size = New System.Drawing.Size(954, 48)
        Me.txtPasswortWdrhln.TabIndex = 14
        '
        'txtFirma
        '
        Me.txtFirma.Location = New System.Drawing.Point(260, 584)
        Me.txtFirma.Multiline = True
        Me.txtFirma.Name = "txtFirma"
        Me.txtFirma.Size = New System.Drawing.Size(954, 48)
        Me.txtFirma.TabIndex = 16
        '
        'datboxGebDat
        '
        Me.datboxGebDat.Location = New System.Drawing.Point(260, 518)
        Me.datboxGebDat.Name = "datboxGebDat"
        Me.datboxGebDat.Size = New System.Drawing.Size(275, 26)
        Me.datboxGebDat.TabIndex = 17
        '
        'frmKundenkontoerstellung
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(1258, 968)
        Me.Controls.Add(Me.datboxGebDat)
        Me.Controls.Add(Me.txtFirma)
        Me.Controls.Add(Me.txtPasswortWdrhln)
        Me.Controls.Add(Me.txtPasswort)
        Me.Controls.Add(Me.txtBenutzername)
        Me.Controls.Add(Me.txtNachname)
        Me.Controls.Add(Me.txtVorname)
        Me.Controls.Add(Me.lblFirma)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.lblGebDat)
        Me.Controls.Add(Me.lblPasswortWdrhln)
        Me.Controls.Add(Me.lblPasswort)
        Me.Controls.Add(Me.lblBenutzername)
        Me.Controls.Add(Me.lblNachname)
        Me.Controls.Add(Me.lblVorname)
        Me.Name = "frmKundenkontoerstellung"
        Me.Text = "Kundenkontoerstellung"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVorname As Label
    Friend WithEvents lblNachname As Label
    Friend WithEvents lblBenutzername As Label
    Friend WithEvents lblPasswort As Label
    Friend WithEvents lblPasswortWdrhln As Label
    Friend WithEvents lblGebDat As Label
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents lblFirma As Label
    Friend WithEvents txtVorname As TextBox
    Friend WithEvents txtNachname As TextBox
    Friend WithEvents txtBenutzername As TextBox
    Friend WithEvents txtPasswort As TextBox
    Friend WithEvents txtPasswortWdrhln As TextBox
    Friend WithEvents txtFirma As TextBox
    Friend WithEvents datboxGebDat As DateTimePicker
End Class
