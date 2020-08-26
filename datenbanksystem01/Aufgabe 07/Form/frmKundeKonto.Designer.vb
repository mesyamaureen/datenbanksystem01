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
        Me.tbBenutzername = New System.Windows.Forms.TextBox()
        Me.txtboxNeuesPasswort = New System.Windows.Forms.TextBox()
        Me.txtboxName = New System.Windows.Forms.TextBox()
        Me.txtboxVorname = New System.Windows.Forms.TextBox()
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
        Me.dtpGebDatKunde = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'tbBenutzername
        '
        Me.tbBenutzername.Enabled = False
        Me.tbBenutzername.Location = New System.Drawing.Point(242, 15)
        Me.tbBenutzername.Margin = New System.Windows.Forms.Padding(4)
        Me.tbBenutzername.Multiline = True
        Me.tbBenutzername.Name = "tbBenutzername"
        Me.tbBenutzername.Size = New System.Drawing.Size(1000, 46)
        Me.tbBenutzername.TabIndex = 0
        '
        'txtboxNeuesPasswort
        '
        Me.txtboxNeuesPasswort.Location = New System.Drawing.Point(242, 79)
        Me.txtboxNeuesPasswort.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxNeuesPasswort.Multiline = True
        Me.txtboxNeuesPasswort.Name = "txtboxNeuesPasswort"
        Me.txtboxNeuesPasswort.Size = New System.Drawing.Size(1000, 50)
        Me.txtboxNeuesPasswort.TabIndex = 2
        '
        'txtboxName
        '
        Me.txtboxName.Location = New System.Drawing.Point(242, 146)
        Me.txtboxName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxName.Multiline = True
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.Size = New System.Drawing.Size(1000, 50)
        Me.txtboxName.TabIndex = 3
        '
        'txtboxVorname
        '
        Me.txtboxVorname.Location = New System.Drawing.Point(242, 221)
        Me.txtboxVorname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxVorname.Multiline = True
        Me.txtboxVorname.Name = "txtboxVorname"
        Me.txtboxVorname.Size = New System.Drawing.Size(1000, 50)
        Me.txtboxVorname.TabIndex = 4
        '
        'txtboxFirma
        '
        Me.txtboxFirma.Location = New System.Drawing.Point(242, 363)
        Me.txtboxFirma.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxFirma.Multiline = True
        Me.txtboxFirma.Name = "txtboxFirma"
        Me.txtboxFirma.Size = New System.Drawing.Size(1000, 50)
        Me.txtboxFirma.TabIndex = 6
        '
        'txtboxKundenID
        '
        Me.txtboxKundenID.Location = New System.Drawing.Point(242, 438)
        Me.txtboxKundenID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxKundenID.Multiline = True
        Me.txtboxKundenID.Name = "txtboxKundenID"
        Me.txtboxKundenID.ReadOnly = True
        Me.txtboxKundenID.Size = New System.Drawing.Size(1000, 50)
        Me.txtboxKundenID.TabIndex = 7
        '
        'lblBenutzername
        '
        Me.lblBenutzername.AutoSize = True
        Me.lblBenutzername.Location = New System.Drawing.Point(28, 19)
        Me.lblBenutzername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBenutzername.Name = "lblBenutzername"
        Me.lblBenutzername.Size = New System.Drawing.Size(151, 25)
        Me.lblBenutzername.TabIndex = 8
        Me.lblBenutzername.Text = "Benutzername"
        '
        'lblAltesPasswort
        '
        Me.lblAltesPasswort.AutoSize = True
        Me.lblAltesPasswort.Location = New System.Drawing.Point(28, 83)
        Me.lblAltesPasswort.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAltesPasswort.Name = "lblAltesPasswort"
        Me.lblAltesPasswort.Size = New System.Drawing.Size(0, 25)
        Me.lblAltesPasswort.TabIndex = 9
        '
        'lblNeuesPasswort
        '
        Me.lblNeuesPasswort.AutoSize = True
        Me.lblNeuesPasswort.Location = New System.Drawing.Point(28, 81)
        Me.lblNeuesPasswort.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNeuesPasswort.Name = "lblNeuesPasswort"
        Me.lblNeuesPasswort.Size = New System.Drawing.Size(168, 25)
        Me.lblNeuesPasswort.TabIndex = 10
        Me.lblNeuesPasswort.Text = "Neues Passwort"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(28, 148)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 25)
        Me.lblName.TabIndex = 11
        Me.lblName.Text = "Name"
        '
        'lblVorname
        '
        Me.lblVorname.AutoSize = True
        Me.lblVorname.Location = New System.Drawing.Point(28, 223)
        Me.lblVorname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVorname.Name = "lblVorname"
        Me.lblVorname.Size = New System.Drawing.Size(98, 25)
        Me.lblVorname.TabIndex = 12
        Me.lblVorname.Text = "Vorname"
        '
        'lblGebDat
        '
        Me.lblGebDat.AutoSize = True
        Me.lblGebDat.Location = New System.Drawing.Point(28, 294)
        Me.lblGebDat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGebDat.Name = "lblGebDat"
        Me.lblGebDat.Size = New System.Drawing.Size(147, 25)
        Me.lblGebDat.TabIndex = 13
        Me.lblGebDat.Text = "Geburtsdatum"
        '
        'lblFirma
        '
        Me.lblFirma.AutoSize = True
        Me.lblFirma.Location = New System.Drawing.Point(28, 365)
        Me.lblFirma.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirma.Name = "lblFirma"
        Me.lblFirma.Size = New System.Drawing.Size(66, 25)
        Me.lblFirma.TabIndex = 14
        Me.lblFirma.Text = "Firma"
        '
        'lblKundenID
        '
        Me.lblKundenID.AutoSize = True
        Me.lblKundenID.Location = New System.Drawing.Point(28, 440)
        Me.lblKundenID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKundenID.Name = "lblKundenID"
        Me.lblKundenID.Size = New System.Drawing.Size(112, 25)
        Me.lblKundenID.TabIndex = 15
        Me.lblKundenID.Text = "Kunden ID"
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(1106, 533)
        Me.btnAbbrechen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(136, 46)
        Me.btnAbbrechen.TabIndex = 16
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnSpeichern
        '
        Me.btnSpeichern.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSpeichern.Location = New System.Drawing.Point(946, 533)
        Me.btnSpeichern.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(136, 46)
        Me.btnSpeichern.TabIndex = 17
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'btnKontoLoeschen
        '
        Me.btnKontoLoeschen.Location = New System.Drawing.Point(752, 533)
        Me.btnKontoLoeschen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKontoLoeschen.Name = "btnKontoLoeschen"
        Me.btnKontoLoeschen.Size = New System.Drawing.Size(164, 46)
        Me.btnKontoLoeschen.TabIndex = 18
        Me.btnKontoLoeschen.Text = "Löschen"
        Me.btnKontoLoeschen.UseVisualStyleBackColor = True
        '
        'dtpGebDatKunde
        '
        Me.dtpGebDatKunde.Location = New System.Drawing.Point(242, 294)
        Me.dtpGebDatKunde.Margin = New System.Windows.Forms.Padding(6)
        Me.dtpGebDatKunde.Name = "dtpGebDatKunde"
        Me.dtpGebDatKunde.Size = New System.Drawing.Size(674, 31)
        Me.dtpGebDatKunde.TabIndex = 19
        '
        'frmKundeKonto
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(1258, 615)
        Me.Controls.Add(Me.dtpGebDatKunde)
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
        Me.Controls.Add(Me.txtboxVorname)
        Me.Controls.Add(Me.txtboxName)
        Me.Controls.Add(Me.txtboxNeuesPasswort)
        Me.Controls.Add(Me.tbBenutzername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmKundeKonto"
        Me.Text = "  "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbBenutzername As TextBox
    Friend WithEvents txtboxNeuesPasswort As TextBox
    Friend WithEvents txtboxName As TextBox
    Friend WithEvents txtboxVorname As TextBox
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
    Friend WithEvents dtpGebDatKunde As DateTimePicker
End Class
