﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMeinKontoMitarbeiter
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
        Me.txtBenutzername = New System.Windows.Forms.TextBox()
        Me.txtboxAltesPasswort = New System.Windows.Forms.TextBox()
        Me.txtboxNeuesPasswort = New System.Windows.Forms.TextBox()
        Me.txtboxVorname = New System.Windows.Forms.TextBox()
        Me.txtboxName = New System.Windows.Forms.TextBox()
        Me.txtboxGebDat = New System.Windows.Forms.TextBox()
        Me.txtboxMitarbeiterID = New System.Windows.Forms.TextBox()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.btnLoeschen = New System.Windows.Forms.Button()
        Me.btnErstellen = New System.Windows.Forms.Button()
        Me.lblBenutzername = New System.Windows.Forms.Label()
        Me.lblAltesPasswort = New System.Windows.Forms.Label()
        Me.lblNeuesPasswort = New System.Windows.Forms.Label()
        Me.lblVorname = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblGebDat = New System.Windows.Forms.Label()
        Me.lblMitarbeiterID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtBenutzername
        '
        Me.txtBenutzername.Location = New System.Drawing.Point(230, 24)
        Me.txtBenutzername.Multiline = True
        Me.txtBenutzername.Name = "txtBenutzername"
        Me.txtBenutzername.Size = New System.Drawing.Size(1012, 50)
        Me.txtBenutzername.TabIndex = 0
        '
        'txtboxAltesPasswort
        '
        Me.txtboxAltesPasswort.Location = New System.Drawing.Point(230, 99)
        Me.txtboxAltesPasswort.Multiline = True
        Me.txtboxAltesPasswort.Name = "txtboxAltesPasswort"
        Me.txtboxAltesPasswort.Size = New System.Drawing.Size(1012, 50)
        Me.txtboxAltesPasswort.TabIndex = 1
        '
        'txtboxNeuesPasswort
        '
        Me.txtboxNeuesPasswort.Location = New System.Drawing.Point(230, 175)
        Me.txtboxNeuesPasswort.Multiline = True
        Me.txtboxNeuesPasswort.Name = "txtboxNeuesPasswort"
        Me.txtboxNeuesPasswort.Size = New System.Drawing.Size(1012, 47)
        Me.txtboxNeuesPasswort.TabIndex = 2
        '
        'txtboxVorname
        '
        Me.txtboxVorname.Location = New System.Drawing.Point(230, 250)
        Me.txtboxVorname.Multiline = True
        Me.txtboxVorname.Name = "txtboxVorname"
        Me.txtboxVorname.Size = New System.Drawing.Size(1012, 47)
        Me.txtboxVorname.TabIndex = 3
        '
        'txtboxName
        '
        Me.txtboxName.Location = New System.Drawing.Point(230, 327)
        Me.txtboxName.Multiline = True
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.Size = New System.Drawing.Size(1012, 47)
        Me.txtboxName.TabIndex = 4
        '
        'txtboxGebDat
        '
        Me.txtboxGebDat.Location = New System.Drawing.Point(230, 405)
        Me.txtboxGebDat.Multiline = True
        Me.txtboxGebDat.Name = "txtboxGebDat"
        Me.txtboxGebDat.Size = New System.Drawing.Size(1012, 47)
        Me.txtboxGebDat.TabIndex = 5
        '
        'txtboxMitarbeiterID
        '
        Me.txtboxMitarbeiterID.Location = New System.Drawing.Point(230, 482)
        Me.txtboxMitarbeiterID.Multiline = True
        Me.txtboxMitarbeiterID.Name = "txtboxMitarbeiterID"
        Me.txtboxMitarbeiterID.Size = New System.Drawing.Size(1012, 47)
        Me.txtboxMitarbeiterID.TabIndex = 6
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.Location = New System.Drawing.Point(1106, 672)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(136, 45)
        Me.btnAbbrechen.TabIndex = 7
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Location = New System.Drawing.Point(950, 672)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(136, 45)
        Me.btnSpeichern.TabIndex = 8
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'btnLoeschen
        '
        Me.btnLoeschen.Location = New System.Drawing.Point(788, 672)
        Me.btnLoeschen.Name = "btnLoeschen"
        Me.btnLoeschen.Size = New System.Drawing.Size(136, 45)
        Me.btnLoeschen.TabIndex = 9
        Me.btnLoeschen.Text = "Löschen"
        Me.btnLoeschen.UseVisualStyleBackColor = True
        '
        'btnErstellen
        '
        Me.btnErstellen.Location = New System.Drawing.Point(535, 672)
        Me.btnErstellen.Name = "btnErstellen"
        Me.btnErstellen.Size = New System.Drawing.Size(234, 45)
        Me.btnErstellen.TabIndex = 10
        Me.btnErstellen.Text = "Neues Konto erstellen"
        Me.btnErstellen.UseVisualStyleBackColor = True
        '
        'lblBenutzername
        '
        Me.lblBenutzername.AutoSize = True
        Me.lblBenutzername.Location = New System.Drawing.Point(12, 27)
        Me.lblBenutzername.Name = "lblBenutzername"
        Me.lblBenutzername.Size = New System.Drawing.Size(151, 25)
        Me.lblBenutzername.TabIndex = 11
        Me.lblBenutzername.Text = "Benutzername"
        '
        'lblAltesPasswort
        '
        Me.lblAltesPasswort.AutoSize = True
        Me.lblAltesPasswort.Location = New System.Drawing.Point(12, 102)
        Me.lblAltesPasswort.Name = "lblAltesPasswort"
        Me.lblAltesPasswort.Size = New System.Drawing.Size(154, 25)
        Me.lblAltesPasswort.TabIndex = 12
        Me.lblAltesPasswort.Text = "Altes Passwort"
        '
        'lblNeuesPasswort
        '
        Me.lblNeuesPasswort.AutoSize = True
        Me.lblNeuesPasswort.Location = New System.Drawing.Point(12, 178)
        Me.lblNeuesPasswort.Name = "lblNeuesPasswort"
        Me.lblNeuesPasswort.Size = New System.Drawing.Size(168, 25)
        Me.lblNeuesPasswort.TabIndex = 13
        Me.lblNeuesPasswort.Text = "Neues Passwort"
        '
        'lblVorname
        '
        Me.lblVorname.AutoSize = True
        Me.lblVorname.Location = New System.Drawing.Point(12, 253)
        Me.lblVorname.Name = "lblVorname"
        Me.lblVorname.Size = New System.Drawing.Size(98, 25)
        Me.lblVorname.TabIndex = 14
        Me.lblVorname.Text = "Vorname"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 330)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 25)
        Me.lblName.TabIndex = 15
        Me.lblName.Text = "Name"
        '
        'lblGebDat
        '
        Me.lblGebDat.AutoSize = True
        Me.lblGebDat.Location = New System.Drawing.Point(12, 408)
        Me.lblGebDat.Name = "lblGebDat"
        Me.lblGebDat.Size = New System.Drawing.Size(147, 25)
        Me.lblGebDat.TabIndex = 16
        Me.lblGebDat.Text = "Geburtsdatum"
        '
        'lblMitarbeiterID
        '
        Me.lblMitarbeiterID.AutoSize = True
        Me.lblMitarbeiterID.Location = New System.Drawing.Point(12, 485)
        Me.lblMitarbeiterID.Name = "lblMitarbeiterID"
        Me.lblMitarbeiterID.Size = New System.Drawing.Size(140, 25)
        Me.lblMitarbeiterID.TabIndex = 17
        Me.lblMitarbeiterID.Text = "Mitarbeiter ID"
        '
        'frmMeinKontoMitarbeiter
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(1254, 729)
        Me.Controls.Add(Me.lblMitarbeiterID)
        Me.Controls.Add(Me.lblGebDat)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblVorname)
        Me.Controls.Add(Me.lblNeuesPasswort)
        Me.Controls.Add(Me.lblAltesPasswort)
        Me.Controls.Add(Me.lblBenutzername)
        Me.Controls.Add(Me.btnErstellen)
        Me.Controls.Add(Me.btnLoeschen)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.txtboxMitarbeiterID)
        Me.Controls.Add(Me.txtboxGebDat)
        Me.Controls.Add(Me.txtboxName)
        Me.Controls.Add(Me.txtboxVorname)
        Me.Controls.Add(Me.txtboxNeuesPasswort)
        Me.Controls.Add(Me.txtboxAltesPasswort)
        Me.Controls.Add(Me.txtBenutzername)
        Me.Name = "frmMeinKontoMitarbeiter"
        Me.Text = "frmMeinKontoMitarbeiter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBenutzername As TextBox
    Friend WithEvents txtboxAltesPasswort As TextBox
    Friend WithEvents txtboxNeuesPasswort As TextBox
    Friend WithEvents txtboxVorname As TextBox
    Friend WithEvents txtboxName As TextBox
    Friend WithEvents txtboxGebDat As TextBox
    Friend WithEvents txtboxMitarbeiterID As TextBox
    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents btnLoeschen As Button
    Friend WithEvents btnErstellen As Button
    Friend WithEvents lblBenutzername As Label
    Friend WithEvents lblAltesPasswort As Label
    Friend WithEvents lblNeuesPasswort As Label
    Friend WithEvents lblVorname As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblGebDat As Label
    Friend WithEvents lblMitarbeiterID As Label
End Class
