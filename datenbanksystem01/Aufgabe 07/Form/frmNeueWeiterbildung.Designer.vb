﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNeueWeiterbildung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNeueWeiterbildung))
        Me.txtSeminartitel = New System.Windows.Forms.TextBox()
        Me.lblSeminartitel = New System.Windows.Forms.Label()
        Me.tabcontrolNeueWeiterbildung = New System.Windows.Forms.TabControl()
        Me.tabSeminarbeschreibung = New System.Windows.Forms.TabPage()
        Me.rtxtboxSeminarbeschreibung = New System.Windows.Forms.RichTextBox()
        Me.tabTeilnehmerkreis = New System.Windows.Forms.TabPage()
        Me.rtxtboxTeilnehmerkreis = New System.Windows.Forms.RichTextBox()
        Me.tabSeminarinfo = New System.Windows.Forms.TabPage()
        Me.rtxtboxSeminarinfo = New System.Windows.Forms.RichTextBox()
        Me.tabKurse = New System.Windows.Forms.TabPage()
        Me.btnNeuerKurs = New System.Windows.Forms.Button()
        Me.btnLeeren = New System.Windows.Forms.Button()
        Me.btnLoeschen = New System.Windows.Forms.Button()
        Me.lstviewKurse = New System.Windows.Forms.ListView()
        Me.colKursID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDatum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVerfuegbarkeit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPreis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.btnErstellen = New System.Windows.Forms.Button()
        Me.tabcontrolNeueWeiterbildung.SuspendLayout()
        Me.tabSeminarbeschreibung.SuspendLayout()
        Me.tabTeilnehmerkreis.SuspendLayout()
        Me.tabSeminarinfo.SuspendLayout()
        Me.tabKurse.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSeminartitel
        '
        Me.txtSeminartitel.Location = New System.Drawing.Point(158, 22)
        Me.txtSeminartitel.Multiline = True
        Me.txtSeminartitel.Name = "txtSeminartitel"
        Me.txtSeminartitel.Size = New System.Drawing.Size(538, 48)
        Me.txtSeminartitel.TabIndex = 0
        '
        'lblSeminartitel
        '
        Me.lblSeminartitel.AutoSize = True
        Me.lblSeminartitel.Location = New System.Drawing.Point(15, 35)
        Me.lblSeminartitel.Name = "lblSeminartitel"
        Me.lblSeminartitel.Size = New System.Drawing.Size(125, 25)
        Me.lblSeminartitel.TabIndex = 1
        Me.lblSeminartitel.Text = "Seminartitel"
        '
        'tabcontrolNeueWeiterbildung
        '
        Me.tabcontrolNeueWeiterbildung.Controls.Add(Me.tabSeminarbeschreibung)
        Me.tabcontrolNeueWeiterbildung.Controls.Add(Me.tabTeilnehmerkreis)
        Me.tabcontrolNeueWeiterbildung.Controls.Add(Me.tabSeminarinfo)
        Me.tabcontrolNeueWeiterbildung.Controls.Add(Me.tabKurse)
        Me.tabcontrolNeueWeiterbildung.Location = New System.Drawing.Point(12, 118)
        Me.tabcontrolNeueWeiterbildung.Name = "tabcontrolNeueWeiterbildung"
        Me.tabcontrolNeueWeiterbildung.SelectedIndex = 0
        Me.tabcontrolNeueWeiterbildung.Size = New System.Drawing.Size(1229, 528)
        Me.tabcontrolNeueWeiterbildung.TabIndex = 2
        '
        'tabSeminarbeschreibung
        '
        Me.tabSeminarbeschreibung.Controls.Add(Me.rtxtboxSeminarbeschreibung)
        Me.tabSeminarbeschreibung.Location = New System.Drawing.Point(8, 39)
        Me.tabSeminarbeschreibung.Name = "tabSeminarbeschreibung"
        Me.tabSeminarbeschreibung.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSeminarbeschreibung.Size = New System.Drawing.Size(1213, 481)
        Me.tabSeminarbeschreibung.TabIndex = 0
        Me.tabSeminarbeschreibung.Tag = ""
        Me.tabSeminarbeschreibung.Text = "Seminarbeschreibung"
        Me.tabSeminarbeschreibung.UseVisualStyleBackColor = True
        '
        'rtxtboxSeminarbeschreibung
        '
        Me.rtxtboxSeminarbeschreibung.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtboxSeminarbeschreibung.Location = New System.Drawing.Point(3, 3)
        Me.rtxtboxSeminarbeschreibung.Name = "rtxtboxSeminarbeschreibung"
        Me.rtxtboxSeminarbeschreibung.Size = New System.Drawing.Size(1207, 475)
        Me.rtxtboxSeminarbeschreibung.TabIndex = 0
        Me.rtxtboxSeminarbeschreibung.Text = ""
        '
        'tabTeilnehmerkreis
        '
        Me.tabTeilnehmerkreis.Controls.Add(Me.rtxtboxTeilnehmerkreis)
        Me.tabTeilnehmerkreis.Location = New System.Drawing.Point(8, 39)
        Me.tabTeilnehmerkreis.Name = "tabTeilnehmerkreis"
        Me.tabTeilnehmerkreis.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTeilnehmerkreis.Size = New System.Drawing.Size(1213, 481)
        Me.tabTeilnehmerkreis.TabIndex = 1
        Me.tabTeilnehmerkreis.Text = "Teilnehmerkreis"
        Me.tabTeilnehmerkreis.UseVisualStyleBackColor = True
        '
        'rtxtboxTeilnehmerkreis
        '
        Me.rtxtboxTeilnehmerkreis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtboxTeilnehmerkreis.Location = New System.Drawing.Point(3, 3)
        Me.rtxtboxTeilnehmerkreis.Name = "rtxtboxTeilnehmerkreis"
        Me.rtxtboxTeilnehmerkreis.Size = New System.Drawing.Size(1207, 475)
        Me.rtxtboxTeilnehmerkreis.TabIndex = 0
        Me.rtxtboxTeilnehmerkreis.Text = ""
        '
        'tabSeminarinfo
        '
        Me.tabSeminarinfo.Controls.Add(Me.rtxtboxSeminarinfo)
        Me.tabSeminarinfo.Location = New System.Drawing.Point(8, 39)
        Me.tabSeminarinfo.Name = "tabSeminarinfo"
        Me.tabSeminarinfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSeminarinfo.Size = New System.Drawing.Size(1213, 481)
        Me.tabSeminarinfo.TabIndex = 2
        Me.tabSeminarinfo.Text = "Seminarinformationen"
        Me.tabSeminarinfo.UseVisualStyleBackColor = True
        '
        'rtxtboxSeminarinfo
        '
        Me.rtxtboxSeminarinfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtboxSeminarinfo.Location = New System.Drawing.Point(3, 3)
        Me.rtxtboxSeminarinfo.Name = "rtxtboxSeminarinfo"
        Me.rtxtboxSeminarinfo.Size = New System.Drawing.Size(1207, 475)
        Me.rtxtboxSeminarinfo.TabIndex = 0
        Me.rtxtboxSeminarinfo.Text = ""
        '
        'tabKurse
        '
        Me.tabKurse.Controls.Add(Me.btnNeuerKurs)
        Me.tabKurse.Controls.Add(Me.btnLeeren)
        Me.tabKurse.Controls.Add(Me.btnLoeschen)
        Me.tabKurse.Controls.Add(Me.lstviewKurse)
        Me.tabKurse.Location = New System.Drawing.Point(8, 39)
        Me.tabKurse.Name = "tabKurse"
        Me.tabKurse.Padding = New System.Windows.Forms.Padding(3)
        Me.tabKurse.Size = New System.Drawing.Size(1213, 481)
        Me.tabKurse.TabIndex = 3
        Me.tabKurse.Text = "Kurse"
        Me.tabKurse.UseVisualStyleBackColor = True
        '
        'btnNeuerKurs
        '
        Me.btnNeuerKurs.Location = New System.Drawing.Point(615, 440)
        Me.btnNeuerKurs.Name = "btnNeuerKurs"
        Me.btnNeuerKurs.Size = New System.Drawing.Size(179, 36)
        Me.btnNeuerKurs.TabIndex = 3
        Me.btnNeuerKurs.Text = "Neuer Kurs"
        Me.btnNeuerKurs.UseVisualStyleBackColor = True
        '
        'btnLeeren
        '
        Me.btnLeeren.Location = New System.Drawing.Point(823, 437)
        Me.btnLeeren.Name = "btnLeeren"
        Me.btnLeeren.Size = New System.Drawing.Size(179, 36)
        Me.btnLeeren.TabIndex = 2
        Me.btnLeeren.Text = "Leeren"
        Me.btnLeeren.UseVisualStyleBackColor = True
        '
        'btnLoeschen
        '
        Me.btnLoeschen.Location = New System.Drawing.Point(1030, 437)
        Me.btnLoeschen.Name = "btnLoeschen"
        Me.btnLoeschen.Size = New System.Drawing.Size(179, 36)
        Me.btnLoeschen.TabIndex = 1
        Me.btnLoeschen.Text = "Löschen"
        Me.btnLoeschen.UseVisualStyleBackColor = True
        '
        'lstviewKurse
        '
        Me.lstviewKurse.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colKursID, Me.colDatum, Me.colVerfuegbarkeit, Me.colPreis})
        Me.lstviewKurse.FullRowSelect = True
        Me.lstviewKurse.GridLines = True
        Me.lstviewKurse.HideSelection = False
        Me.lstviewKurse.Location = New System.Drawing.Point(0, 0)
        Me.lstviewKurse.MultiSelect = False
        Me.lstviewKurse.Name = "lstviewKurse"
        Me.lstviewKurse.Size = New System.Drawing.Size(1213, 418)
        Me.lstviewKurse.TabIndex = 0
        Me.lstviewKurse.UseCompatibleStateImageBehavior = False
        Me.lstviewKurse.View = System.Windows.Forms.View.Details
        '
        'colKursID
        '
        Me.colKursID.Text = "Kurs ID"
        Me.colKursID.Width = 180
        '
        'colDatum
        '
        Me.colDatum.Text = "Datum"
        Me.colDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colDatum.Width = 455
        '
        'colVerfuegbarkeit
        '
        Me.colVerfuegbarkeit.Text = "Verfügbarkeit"
        Me.colVerfuegbarkeit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colVerfuegbarkeit.Width = 260
        '
        'colPreis
        '
        Me.colPreis.Text = "Preis"
        Me.colPreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colPreis.Width = 313
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(1050, 659)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(191, 56)
        Me.btnAbbrechen.TabIndex = 3
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnErstellen
        '
        Me.btnErstellen.Location = New System.Drawing.Point(843, 659)
        Me.btnErstellen.Name = "btnErstellen"
        Me.btnErstellen.Size = New System.Drawing.Size(191, 56)
        Me.btnErstellen.TabIndex = 4
        Me.btnErstellen.Text = "Erstellen"
        Me.btnErstellen.UseVisualStyleBackColor = True
        '
        'frmNeueWeiterbildung
        '
        Me.AcceptButton = Me.btnErstellen
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(1254, 729)
        Me.Controls.Add(Me.btnErstellen)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.tabcontrolNeueWeiterbildung)
        Me.Controls.Add(Me.lblSeminartitel)
        Me.Controls.Add(Me.txtSeminartitel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNeueWeiterbildung"
        Me.Text = "Neue Weiterbildung"
        Me.tabcontrolNeueWeiterbildung.ResumeLayout(False)
        Me.tabSeminarbeschreibung.ResumeLayout(False)
        Me.tabTeilnehmerkreis.ResumeLayout(False)
        Me.tabSeminarinfo.ResumeLayout(False)
        Me.tabKurse.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSeminartitel As TextBox
    Friend WithEvents lblSeminartitel As Label
    Friend WithEvents tabcontrolNeueWeiterbildung As TabControl
    Friend WithEvents tabSeminarbeschreibung As TabPage
    Friend WithEvents tabTeilnehmerkreis As TabPage
    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnErstellen As Button
    Friend WithEvents rtxtboxSeminarbeschreibung As RichTextBox
    Friend WithEvents rtxtboxTeilnehmerkreis As RichTextBox
    Friend WithEvents tabSeminarinfo As TabPage
    Friend WithEvents rtxtboxSeminarinfo As RichTextBox
    Friend WithEvents tabKurse As TabPage
    Friend WithEvents lstviewKurse As ListView
    Friend WithEvents colKursID As ColumnHeader
    Friend WithEvents colDatum As ColumnHeader
    Friend WithEvents colVerfuegbarkeit As ColumnHeader
    Friend WithEvents colPreis As ColumnHeader
    Friend WithEvents btnNeuerKurs As Button
    Friend WithEvents btnLeeren As Button
    Friend WithEvents btnLoeschen As Button
End Class
