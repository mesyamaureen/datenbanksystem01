<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKundeKonto
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKundeKonto))
        Me.txtboxBenutzername = New System.Windows.Forms.TextBox()
        Me.txtboxAltesPasswort = New System.Windows.Forms.TextBox()
        Me.txtboxNeuesPasswort = New System.Windows.Forms.TextBox()
        Me.txtboxName = New System.Windows.Forms.TextBox()
        Me.txtboxVorname = New System.Windows.Forms.TextBox()
        Me.txtboxGebDat = New System.Windows.Forms.TextBox()
        Me.txtboxFirma = New System.Windows.Forms.TextBox()
        Me.txtboxKundenID = New System.Windows.Forms.TextBox()
        Me.lblBenutzername = New System.Windows.Forms.Label()
        Me.lblAltesPasswort = New System.Windows.Forms.Label()
        Me.lblNeuesPasswort = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblVorname = New System.Windows.Forms.Label()
        Me.lblGebDat = New System.Windows.Forms.Label()
        Me.lblFirma = New System.Windows.Forms.Label()
        Me.lblKundenID = New System.Windows.Forms.Label()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.btnKontoLoeschen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtboxBenutzername
        '
        Me.txtboxBenutzername.Location = New System.Drawing.Point(161, 10)
        Me.txtboxBenutzername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxBenutzername.Multiline = True
        Me.txtboxBenutzername.Name = "txtboxBenutzername"
        Me.txtboxBenutzername.Size = New System.Drawing.Size(668, 31)
        Me.txtboxBenutzername.TabIndex = 0
        '
        'txtboxAltesPasswort
        '
        Me.txtboxAltesPasswort.Location = New System.Drawing.Point(161, 51)
        Me.txtboxAltesPasswort.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxAltesPasswort.Multiline = True
        Me.txtboxAltesPasswort.Name = "txtboxAltesPasswort"
        Me.txtboxAltesPasswort.Size = New System.Drawing.Size(668, 33)
        Me.txtboxAltesPasswort.TabIndex = 1
        Me.txtboxAltesPasswort.UseSystemPasswordChar = True
        '
        'txtboxNeuesPasswort
        '
        Me.txtboxNeuesPasswort.Location = New System.Drawing.Point(161, 98)
        Me.txtboxNeuesPasswort.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxNeuesPasswort.Multiline = True
        Me.txtboxNeuesPasswort.Name = "txtboxNeuesPasswort"
        Me.txtboxNeuesPasswort.Size = New System.Drawing.Size(668, 33)
        Me.txtboxNeuesPasswort.TabIndex = 2
        Me.txtboxNeuesPasswort.UseSystemPasswordChar = True
        '
        'txtboxName
        '
        Me.txtboxName.Location = New System.Drawing.Point(161, 141)
        Me.txtboxName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxName.Multiline = True
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.Size = New System.Drawing.Size(668, 33)
        Me.txtboxName.TabIndex = 3
        '
        'txtboxVorname
        '
        Me.txtboxVorname.Location = New System.Drawing.Point(161, 189)
        Me.txtboxVorname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxVorname.Multiline = True
        Me.txtboxVorname.Name = "txtboxVorname"
        Me.txtboxVorname.Size = New System.Drawing.Size(668, 33)
        Me.txtboxVorname.TabIndex = 4
        '
        'txtboxGebDat
        '
        Me.txtboxGebDat.Location = New System.Drawing.Point(161, 234)
        Me.txtboxGebDat.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxGebDat.Multiline = True
        Me.txtboxGebDat.Name = "txtboxGebDat"
        Me.txtboxGebDat.Size = New System.Drawing.Size(668, 33)
        Me.txtboxGebDat.TabIndex = 5
        '
        'txtboxFirma
        '
        Me.txtboxFirma.Location = New System.Drawing.Point(161, 284)
        Me.txtboxFirma.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxFirma.Multiline = True
        Me.txtboxFirma.Name = "txtboxFirma"
        Me.txtboxFirma.Size = New System.Drawing.Size(668, 33)
        Me.txtboxFirma.TabIndex = 6
        '
        'txtboxKundenID
        '
        Me.txtboxKundenID.Location = New System.Drawing.Point(161, 332)
        Me.txtboxKundenID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxKundenID.Multiline = True
        Me.txtboxKundenID.Name = "txtboxKundenID"
        Me.txtboxKundenID.ReadOnly = True
        Me.txtboxKundenID.Size = New System.Drawing.Size(668, 33)
        Me.txtboxKundenID.TabIndex = 7
        '
        'lblBenutzername
        '
        Me.lblBenutzername.AutoSize = True
        Me.lblBenutzername.Location = New System.Drawing.Point(19, 12)
        Me.lblBenutzername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBenutzername.Name = "lblBenutzername"
        Me.lblBenutzername.Size = New System.Drawing.Size(100, 17)
        Me.lblBenutzername.TabIndex = 8
        Me.lblBenutzername.Text = "Benutzername"
        '
        'lblAltesPasswort
        '
        Me.lblAltesPasswort.AutoSize = True
        Me.lblAltesPasswort.Location = New System.Drawing.Point(19, 53)
        Me.lblAltesPasswort.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAltesPasswort.Name = "lblAltesPasswort"
        Me.lblAltesPasswort.Size = New System.Drawing.Size(100, 17)
        Me.lblAltesPasswort.TabIndex = 9
        Me.lblAltesPasswort.Text = "Altes Passwort"
        '
        'lblNeuesPasswort
        '
        Me.lblNeuesPasswort.AutoSize = True
        Me.lblNeuesPasswort.Location = New System.Drawing.Point(19, 100)
        Me.lblNeuesPasswort.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNeuesPasswort.Name = "lblNeuesPasswort"
        Me.lblNeuesPasswort.Size = New System.Drawing.Size(110, 17)
        Me.lblNeuesPasswort.TabIndex = 10
        Me.lblNeuesPasswort.Text = "Neues Passwort"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(19, 143)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 11
        Me.lblName.Text = "Name"
        '
        'lblVorname
        '
        Me.lblVorname.AutoSize = True
        Me.lblVorname.Location = New System.Drawing.Point(19, 191)
        Me.lblVorname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVorname.Name = "lblVorname"
        Me.lblVorname.Size = New System.Drawing.Size(65, 17)
        Me.lblVorname.TabIndex = 12
        Me.lblVorname.Text = "Vorname"
        '
        'lblGebDat
        '
        Me.lblGebDat.AutoSize = True
        Me.lblGebDat.Location = New System.Drawing.Point(19, 236)
        Me.lblGebDat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGebDat.Name = "lblGebDat"
        Me.lblGebDat.Size = New System.Drawing.Size(98, 17)
        Me.lblGebDat.TabIndex = 13
        Me.lblGebDat.Text = "Geburtsdatum"
        '
        'lblFirma
        '
        Me.lblFirma.AutoSize = True
        Me.lblFirma.Location = New System.Drawing.Point(19, 285)
        Me.lblFirma.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirma.Name = "lblFirma"
        Me.lblFirma.Size = New System.Drawing.Size(43, 17)
        Me.lblFirma.TabIndex = 14
        Me.lblFirma.Text = "Firma"
        '
        'lblKundenID
        '
        Me.lblKundenID.AutoSize = True
        Me.lblKundenID.Location = New System.Drawing.Point(19, 334)
        Me.lblKundenID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKundenID.Name = "lblKundenID"
        Me.lblKundenID.Size = New System.Drawing.Size(74, 17)
        Me.lblKundenID.TabIndex = 15
        Me.lblKundenID.Text = "Kunden ID"
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(737, 430)
        Me.btnAbbrechen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(91, 29)
        Me.btnAbbrechen.TabIndex = 16
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Location = New System.Drawing.Point(631, 430)
        Me.btnSpeichern.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(91, 29)
        Me.btnSpeichern.TabIndex = 17
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'btnKontoLoeschen
        '
        Me.btnKontoLoeschen.Location = New System.Drawing.Point(502, 430)
        Me.btnKontoLoeschen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnKontoLoeschen.Name = "btnKontoLoeschen"
        Me.btnKontoLoeschen.Size = New System.Drawing.Size(110, 29)
        Me.btnKontoLoeschen.TabIndex = 18
        Me.btnKontoLoeschen.Text = "Konto löschen"
        Me.btnKontoLoeschen.UseVisualStyleBackColor = True
        '
        'frmKundeKonto
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(836, 467)
        Me.Controls.Add(Me.btnKontoLoeschen)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.lblKundenID)
        Me.Controls.Add(Me.lblFirma)
        Me.Controls.Add(Me.lblGebDat)
        Me.Controls.Add(Me.lblVorname)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblNeuesPasswort)
        Me.Controls.Add(Me.lblAltesPasswort)
        Me.Controls.Add(Me.lblBenutzername)
        Me.Controls.Add(Me.txtboxKundenID)
        Me.Controls.Add(Me.txtboxFirma)
        Me.Controls.Add(Me.txtboxGebDat)
        Me.Controls.Add(Me.txtboxVorname)
        Me.Controls.Add(Me.txtboxName)
        Me.Controls.Add(Me.txtboxNeuesPasswort)
        Me.Controls.Add(Me.txtboxAltesPasswort)
        Me.Controls.Add(Me.txtboxBenutzername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmKundeKonto"
        Me.Text = "Kundenkonto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtboxBenutzername As TextBox
    Friend WithEvents txtboxAltesPasswort As TextBox
    Friend WithEvents txtboxNeuesPasswort As TextBox
    Friend WithEvents txtboxName As TextBox
    Friend WithEvents txtboxVorname As TextBox
    Friend WithEvents txtboxGebDat As TextBox
    Friend WithEvents txtboxFirma As TextBox
    Friend WithEvents txtboxKundenID As TextBox
    Friend WithEvents lblBenutzername As Label
    Friend WithEvents lblAltesPasswort As Label
    Friend WithEvents lblNeuesPasswort As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblVorname As Label
    Friend WithEvents lblGebDat As Label
    Friend WithEvents lblFirma As Label
    Friend WithEvents lblKundenID As Label
    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents btnKontoLoeschen As Button
End Class
