﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgNeuerKurs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgNeuerKurs))
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.lblDatum = New System.Windows.Forms.Label()
        Me.lblOrt = New System.Windows.Forms.Label()
        Me.bolVerfuegbarkeit = New System.Windows.Forms.Label()
        Me.lblPreis = New System.Windows.Forms.Label()
        Me.txtOrt = New System.Windows.Forms.TextBox()
        Me.txtPreis = New System.Windows.Forms.TextBox()
        Me.dtpKursDatum = New System.Windows.Forms.DateTimePicker()
        Me.chkVerfuegbarYes = New System.Windows.Forms.CheckBox()
        Me.chkVerfuegbarNein = New System.Windows.Forms.CheckBox()
        Me.lblAbgesagt = New System.Windows.Forms.Label()
        Me.chkAbgesagtNein = New System.Windows.Forms.CheckBox()
        Me.chkAbgesagtJa = New System.Windows.Forms.CheckBox()
        Me.txtKursID = New System.Windows.Forms.TextBox()
        Me.lblKursID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(312, 246)
        Me.btnAbbrechen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(68, 23)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Location = New System.Drawing.Point(238, 246)
        Me.btnSpeichern.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(70, 23)
        Me.btnSpeichern.TabIndex = 1
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'lblDatum
        '
        Me.lblDatum.AutoSize = True
        Me.lblDatum.Location = New System.Drawing.Point(6, 45)
        Me.lblDatum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDatum.Name = "lblDatum"
        Me.lblDatum.Size = New System.Drawing.Size(38, 13)
        Me.lblDatum.TabIndex = 2
        Me.lblDatum.Text = "Datum"
        '
        'lblOrt
        '
        Me.lblOrt.AutoSize = True
        Me.lblOrt.Location = New System.Drawing.Point(6, 79)
        Me.lblOrt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrt.Name = "lblOrt"
        Me.lblOrt.Size = New System.Drawing.Size(21, 13)
        Me.lblOrt.TabIndex = 3
        Me.lblOrt.Text = "Ort"
        '
        'bolVerfuegbarkeit
        '
        Me.bolVerfuegbarkeit.AutoSize = True
        Me.bolVerfuegbarkeit.Location = New System.Drawing.Point(6, 112)
        Me.bolVerfuegbarkeit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.bolVerfuegbarkeit.Name = "bolVerfuegbarkeit"
        Me.bolVerfuegbarkeit.Size = New System.Drawing.Size(70, 13)
        Me.bolVerfuegbarkeit.TabIndex = 4
        Me.bolVerfuegbarkeit.Text = "Verfügbarkeit"
        '
        'lblPreis
        '
        Me.lblPreis.AutoSize = True
        Me.lblPreis.Location = New System.Drawing.Point(6, 149)
        Me.lblPreis.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPreis.Name = "lblPreis"
        Me.lblPreis.Size = New System.Drawing.Size(30, 13)
        Me.lblPreis.TabIndex = 5
        Me.lblPreis.Text = "Preis"
        '
        'txtOrt
        '
        Me.txtOrt.Location = New System.Drawing.Point(98, 6)
        Me.txtOrt.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOrt.Multiline = True
        Me.txtOrt.Name = "txtOrt"
        Me.txtOrt.ReadOnly = True
        Me.txtOrt.Size = New System.Drawing.Size(285, 21)
        Me.txtOrt.TabIndex = 7
        '
        'txtPreis
        '
        Me.txtPreis.Location = New System.Drawing.Point(98, 146)
        Me.txtPreis.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPreis.Multiline = True
        Me.txtPreis.Name = "txtPreis"
        Me.txtPreis.Size = New System.Drawing.Size(286, 22)
        Me.txtPreis.TabIndex = 9
        '
        'dtpKursDatum
        '
        Me.dtpKursDatum.Location = New System.Drawing.Point(98, 45)
        Me.dtpKursDatum.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpKursDatum.Name = "dtpKursDatum"
        Me.dtpKursDatum.Size = New System.Drawing.Size(285, 20)
        Me.dtpKursDatum.TabIndex = 10
        '
        'chkVerfuegbarYes
        '
        Me.chkVerfuegbarYes.AutoSize = True
        Me.chkVerfuegbarYes.Location = New System.Drawing.Point(97, 111)
        Me.chkVerfuegbarYes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkVerfuegbarYes.Name = "chkVerfuegbarYes"
        Me.chkVerfuegbarYes.Size = New System.Drawing.Size(40, 17)
        Me.chkVerfuegbarYes.TabIndex = 11
        Me.chkVerfuegbarYes.Text = "Ja "
        Me.chkVerfuegbarYes.UseVisualStyleBackColor = True
        '
        'chkVerfuegbarNein
        '
        Me.chkVerfuegbarNein.AutoSize = True
        Me.chkVerfuegbarNein.Location = New System.Drawing.Point(168, 111)
        Me.chkVerfuegbarNein.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkVerfuegbarNein.Name = "chkVerfuegbarNein"
        Me.chkVerfuegbarNein.Size = New System.Drawing.Size(48, 17)
        Me.chkVerfuegbarNein.TabIndex = 12
        Me.chkVerfuegbarNein.Text = "Nein"
        Me.chkVerfuegbarNein.UseVisualStyleBackColor = True
        '
        'lblAbgesagt
        '
        Me.lblAbgesagt.AutoSize = True
        Me.lblAbgesagt.Location = New System.Drawing.Point(6, 183)
        Me.lblAbgesagt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAbgesagt.Name = "lblAbgesagt"
        Me.lblAbgesagt.Size = New System.Drawing.Size(52, 13)
        Me.lblAbgesagt.TabIndex = 13
        Me.lblAbgesagt.Text = "Abgesagt"
        '
        'chkAbgesagtNein
        '
        Me.chkAbgesagtNein.AutoSize = True
        Me.chkAbgesagtNein.Location = New System.Drawing.Point(168, 183)
        Me.chkAbgesagtNein.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkAbgesagtNein.Name = "chkAbgesagtNein"
        Me.chkAbgesagtNein.Size = New System.Drawing.Size(48, 17)
        Me.chkAbgesagtNein.TabIndex = 15
        Me.chkAbgesagtNein.Text = "Nein"
        Me.chkAbgesagtNein.UseVisualStyleBackColor = True
        '
        'chkAbgesagtJa
        '
        Me.chkAbgesagtJa.AutoSize = True
        Me.chkAbgesagtJa.Location = New System.Drawing.Point(98, 183)
        Me.chkAbgesagtJa.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkAbgesagtJa.Name = "chkAbgesagtJa"
        Me.chkAbgesagtJa.Size = New System.Drawing.Size(40, 17)
        Me.chkAbgesagtJa.TabIndex = 14
        Me.chkAbgesagtJa.Text = "Ja "
        Me.chkAbgesagtJa.UseVisualStyleBackColor = True
        '
        'txtKursID
        '
        Me.txtKursID.Location = New System.Drawing.Point(97, 76)
        Me.txtKursID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtKursID.Multiline = True
        Me.txtKursID.Name = "txtKursID"
        Me.txtKursID.Size = New System.Drawing.Size(286, 22)
        Me.txtKursID.TabIndex = 17
        '
        'lblKursID
        '
        Me.lblKursID.AutoSize = True
        Me.lblKursID.Location = New System.Drawing.Point(6, 12)
        Me.lblKursID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKursID.Name = "lblKursID"
        Me.lblKursID.Size = New System.Drawing.Size(39, 13)
        Me.lblKursID.TabIndex = 16
        Me.lblKursID.Text = "KursID"
        '
        'dlgNeuerKurs
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(387, 276)
        Me.Controls.Add(Me.txtKursID)
        Me.Controls.Add(Me.lblKursID)
        Me.Controls.Add(Me.chkAbgesagtNein)
        Me.Controls.Add(Me.chkAbgesagtJa)
        Me.Controls.Add(Me.lblAbgesagt)
        Me.Controls.Add(Me.chkVerfuegbarNein)
        Me.Controls.Add(Me.chkVerfuegbarYes)
        Me.Controls.Add(Me.dtpKursDatum)
        Me.Controls.Add(Me.txtPreis)
        Me.Controls.Add(Me.txtOrt)
        Me.Controls.Add(Me.lblPreis)
        Me.Controls.Add(Me.bolVerfuegbarkeit)
        Me.Controls.Add(Me.lblOrt)
        Me.Controls.Add(Me.lblDatum)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "dlgNeuerKurs"
        Me.Text = "Neuer Kurs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents lblDatum As Label
    Friend WithEvents lblOrt As Label
    Friend WithEvents bolVerfuegbarkeit As Label
    Friend WithEvents lblPreis As Label
    Friend WithEvents txtOrt As TextBox
    Friend WithEvents txtPreis As TextBox
    Friend WithEvents dtpKursDatum As DateTimePicker
    Friend WithEvents chkVerfuegbarYes As CheckBox
    Friend WithEvents chkVerfuegbarNein As CheckBox
    Friend WithEvents lblAbgesagt As Label
    Friend WithEvents chkAbgesagtNein As CheckBox
    Friend WithEvents chkAbgesagtJa As CheckBox
    Friend WithEvents txtKursID As TextBox
    Friend WithEvents lblKursID As Label
End Class
