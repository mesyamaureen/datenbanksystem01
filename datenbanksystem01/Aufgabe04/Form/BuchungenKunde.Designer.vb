﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuchungenKunde
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tbsBuchungen = New System.Windows.Forms.TabControl()
        Me.tbsAktivBuchungen = New System.Windows.Forms.TabPage()
        Me.ListViewAktBuchungen = New System.Windows.Forms.ListView()
        Me.colBuchungID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKurs = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colWeiterbildung = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAnzahlPers = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPreis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbsInaktiv = New System.Windows.Forms.TabPage()
        Me.ListViewInaktBuchungen = New System.Windows.Forms.ListView()
        Me.colBuchungIDInakt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKursInakt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colWeiterbildungenInakt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAnzahlPersInakt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPreisInakt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.btnLoeschen = New System.Windows.Forms.Button()
        Me.lblKundenID = New System.Windows.Forms.Label()
        Me.txtKundenID = New System.Windows.Forms.TextBox()
        Me.tbsBuchungen.SuspendLayout()
        Me.tbsAktivBuchungen.SuspendLayout()
        Me.tbsInaktiv.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbsBuchungen
        '
        Me.tbsBuchungen.Controls.Add(Me.tbsAktivBuchungen)
        Me.tbsBuchungen.Controls.Add(Me.tbsInaktiv)
        Me.tbsBuchungen.Location = New System.Drawing.Point(12, 70)
        Me.tbsBuchungen.Name = "tbsBuchungen"
        Me.tbsBuchungen.SelectedIndex = 0
        Me.tbsBuchungen.Size = New System.Drawing.Size(1230, 576)
        Me.tbsBuchungen.TabIndex = 0
        '
        'tbsAktivBuchungen
        '
        Me.tbsAktivBuchungen.Controls.Add(Me.ListViewAktBuchungen)
        Me.tbsAktivBuchungen.Location = New System.Drawing.Point(8, 39)
        Me.tbsAktivBuchungen.Name = "tbsAktivBuchungen"
        Me.tbsAktivBuchungen.Padding = New System.Windows.Forms.Padding(3)
        Me.tbsAktivBuchungen.Size = New System.Drawing.Size(1214, 529)
        Me.tbsAktivBuchungen.TabIndex = 0
        Me.tbsAktivBuchungen.Text = "Aktiv"
        Me.tbsAktivBuchungen.UseVisualStyleBackColor = True
        '
        'ListViewAktBuchungen
        '
        Me.ListViewAktBuchungen.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListViewAktBuchungen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colBuchungID, Me.colKurs, Me.colWeiterbildung, Me.colAnzahlPers, Me.colPreis})
        Me.ListViewAktBuchungen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewAktBuchungen.FullRowSelect = True
        Me.ListViewAktBuchungen.GridLines = True
        Me.ListViewAktBuchungen.HideSelection = False
        Me.ListViewAktBuchungen.HoverSelection = True
        Me.ListViewAktBuchungen.Location = New System.Drawing.Point(3, 3)
        Me.ListViewAktBuchungen.MultiSelect = False
        Me.ListViewAktBuchungen.Name = "ListViewAktBuchungen"
        Me.ListViewAktBuchungen.Size = New System.Drawing.Size(1208, 523)
        Me.ListViewAktBuchungen.TabIndex = 0
        Me.ListViewAktBuchungen.UseCompatibleStateImageBehavior = False
        Me.ListViewAktBuchungen.View = System.Windows.Forms.View.Details
        '
        'colBuchungID
        '
        Me.colBuchungID.Text = "Buchung ID"
        Me.colBuchungID.Width = 173
        '
        'colKurs
        '
        Me.colKurs.Text = "Kurs"
        Me.colKurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colKurs.Width = 171
        '
        'colWeiterbildung
        '
        Me.colWeiterbildung.Text = "Weiterbildung"
        Me.colWeiterbildung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colWeiterbildung.Width = 506
        '
        'colAnzahlPers
        '
        Me.colAnzahlPers.Text = "Anzahl Personen"
        Me.colAnzahlPers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colAnzahlPers.Width = 183
        '
        'colPreis
        '
        Me.colPreis.Text = "Preis"
        Me.colPreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colPreis.Width = 168
        '
        'tbsInaktiv
        '
        Me.tbsInaktiv.Controls.Add(Me.ListViewInaktBuchungen)
        Me.tbsInaktiv.Location = New System.Drawing.Point(8, 39)
        Me.tbsInaktiv.Name = "tbsInaktiv"
        Me.tbsInaktiv.Padding = New System.Windows.Forms.Padding(3)
        Me.tbsInaktiv.Size = New System.Drawing.Size(1214, 529)
        Me.tbsInaktiv.TabIndex = 1
        Me.tbsInaktiv.Text = "Inaktiv"
        Me.tbsInaktiv.UseVisualStyleBackColor = True
        '
        'ListViewInaktBuchungen
        '
        Me.ListViewInaktBuchungen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colBuchungIDInakt, Me.colKursInakt, Me.colWeiterbildungenInakt, Me.colAnzahlPersInakt, Me.colPreisInakt})
        Me.ListViewInaktBuchungen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewInaktBuchungen.Enabled = False
        Me.ListViewInaktBuchungen.GridLines = True
        Me.ListViewInaktBuchungen.HideSelection = False
        Me.ListViewInaktBuchungen.Location = New System.Drawing.Point(3, 3)
        Me.ListViewInaktBuchungen.Name = "ListViewInaktBuchungen"
        Me.ListViewInaktBuchungen.Size = New System.Drawing.Size(1208, 523)
        Me.ListViewInaktBuchungen.TabIndex = 0
        Me.ListViewInaktBuchungen.UseCompatibleStateImageBehavior = False
        Me.ListViewInaktBuchungen.View = System.Windows.Forms.View.Details
        '
        'colBuchungIDInakt
        '
        Me.colBuchungIDInakt.Text = "Buchung ID"
        Me.colBuchungIDInakt.Width = 173
        '
        'colKursInakt
        '
        Me.colKursInakt.Text = "Kurs"
        Me.colKursInakt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colKursInakt.Width = 171
        '
        'colWeiterbildungenInakt
        '
        Me.colWeiterbildungenInakt.Text = "Weiterbildung"
        Me.colWeiterbildungenInakt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colWeiterbildungenInakt.Width = 506
        '
        'colAnzahlPersInakt
        '
        Me.colAnzahlPersInakt.Text = "Anzahl Personen"
        Me.colAnzahlPersInakt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colAnzahlPersInakt.Width = 183
        '
        'colPreisInakt
        '
        Me.colPreisInakt.Text = "Preis"
        Me.colPreisInakt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colPreisInakt.Width = 168
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(1108, 662)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(126, 46)
        Me.btnAbbrechen.TabIndex = 1
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnLoeschen
        '
        Me.btnLoeschen.Location = New System.Drawing.Point(970, 662)
        Me.btnLoeschen.Name = "btnLoeschen"
        Me.btnLoeschen.Size = New System.Drawing.Size(126, 46)
        Me.btnLoeschen.TabIndex = 2
        Me.btnLoeschen.Text = "Löschen"
        Me.btnLoeschen.UseVisualStyleBackColor = True
        '
        'lblKundenID
        '
        Me.lblKundenID.AutoSize = True
        Me.lblKundenID.Location = New System.Drawing.Point(15, 19)
        Me.lblKundenID.Name = "lblKundenID"
        Me.lblKundenID.Size = New System.Drawing.Size(112, 25)
        Me.lblKundenID.TabIndex = 3
        Me.lblKundenID.Text = "Kunden ID"
        '
        'txtKundenID
        '
        Me.txtKundenID.Location = New System.Drawing.Point(133, 12)
        Me.txtKundenID.Multiline = True
        Me.txtKundenID.Name = "txtKundenID"
        Me.txtKundenID.ReadOnly = True
        Me.txtKundenID.Size = New System.Drawing.Size(206, 31)
        Me.txtKundenID.TabIndex = 4
        '
        'BuchungenKunde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(1254, 729)
        Me.Controls.Add(Me.txtKundenID)
        Me.Controls.Add(Me.lblKundenID)
        Me.Controls.Add(Me.btnLoeschen)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.tbsBuchungen)
        Me.Name = "BuchungenKunde"
        Me.Text = "Meine Buchungen"
        Me.tbsBuchungen.ResumeLayout(False)
        Me.tbsAktivBuchungen.ResumeLayout(False)
        Me.tbsInaktiv.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbsBuchungen As TabControl
    Friend WithEvents tbsAktivBuchungen As TabPage
    Friend WithEvents ListViewAktBuchungen As ListView
    Friend WithEvents tbsInaktiv As TabPage
    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnLoeschen As Button
    Friend WithEvents lblKundenID As Label
    Friend WithEvents txtKundenID As TextBox
    Friend WithEvents colBuchungID As ColumnHeader
    Friend WithEvents colKurs As ColumnHeader
    Friend WithEvents colWeiterbildung As ColumnHeader
    Friend WithEvents colAnzahlPers As ColumnHeader
    Friend WithEvents colPreis As ColumnHeader
    Friend WithEvents ListViewInaktBuchungen As ListView
    Friend WithEvents colBuchungIDInakt As ColumnHeader
    Friend WithEvents colKursInakt As ColumnHeader
    Friend WithEvents colWeiterbildungenInakt As ColumnHeader
    Friend WithEvents colAnzahlPersInakt As ColumnHeader
    Friend WithEvents colPreisInakt As ColumnHeader
End Class
