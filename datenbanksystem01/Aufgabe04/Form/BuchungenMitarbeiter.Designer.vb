<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuchungenMitarbeiter
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
        Me.btnSchließen = New System.Windows.Forms.Button()
        Me.tbsBuchungen = New System.Windows.Forms.TabControl()
        Me.tbsAktBuchungen = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colBuchungIDAkt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKursAkt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colWeiterbildungAkt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAnzahlPersAkt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPreisAkt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKundeIDAkt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbsStornoBuchungen = New System.Windows.Forms.TabPage()
        Me.ListViewStorniertBuchungen = New System.Windows.Forms.ListView()
        Me.colBuchungIDStorn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKursStorn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colWeiterbildungStorn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAnzahlPersStorn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPreisStorn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKundenIDStorn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbsBuchungen.SuspendLayout()
        Me.tbsAktBuchungen.SuspendLayout()
        Me.tbsStornoBuchungen.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSchließen
        '
        Me.btnSchließen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSchließen.Location = New System.Drawing.Point(1108, 662)
        Me.btnSchließen.Name = "btnSchließen"
        Me.btnSchließen.Size = New System.Drawing.Size(126, 46)
        Me.btnSchließen.TabIndex = 0
        Me.btnSchließen.Text = "Schließen"
        Me.btnSchließen.UseVisualStyleBackColor = True
        '
        'tbsBuchungen
        '
        Me.tbsBuchungen.Controls.Add(Me.tbsAktBuchungen)
        Me.tbsBuchungen.Controls.Add(Me.tbsStornoBuchungen)
        Me.tbsBuchungen.Location = New System.Drawing.Point(12, 32)
        Me.tbsBuchungen.Name = "tbsBuchungen"
        Me.tbsBuchungen.SelectedIndex = 0
        Me.tbsBuchungen.Size = New System.Drawing.Size(1230, 614)
        Me.tbsBuchungen.TabIndex = 1
        '
        'tbsAktBuchungen
        '
        Me.tbsAktBuchungen.Controls.Add(Me.ListView1)
        Me.tbsAktBuchungen.Location = New System.Drawing.Point(8, 39)
        Me.tbsAktBuchungen.Name = "tbsAktBuchungen"
        Me.tbsAktBuchungen.Padding = New System.Windows.Forms.Padding(3)
        Me.tbsAktBuchungen.Size = New System.Drawing.Size(1214, 567)
        Me.tbsAktBuchungen.TabIndex = 0
        Me.tbsAktBuchungen.Text = "Aktiv"
        Me.tbsAktBuchungen.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colBuchungIDAkt, Me.colKursAkt, Me.colWeiterbildungAkt, Me.colAnzahlPersAkt, Me.colPreisAkt, Me.colKundeIDAkt})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Enabled = False
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(3, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1208, 561)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colBuchungIDAkt
        '
        Me.colBuchungIDAkt.Text = "Buchung ID"
        Me.colBuchungIDAkt.Width = 135
        '
        'colKursAkt
        '
        Me.colKursAkt.Text = "Kurs"
        Me.colKursAkt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colKursAkt.Width = 145
        '
        'colWeiterbildungAkt
        '
        Me.colWeiterbildungAkt.Text = "Weiterbildung"
        Me.colWeiterbildungAkt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colWeiterbildungAkt.Width = 379
        '
        'colAnzahlPersAkt
        '
        Me.colAnzahlPersAkt.Text = "Anzahl Personen"
        Me.colAnzahlPersAkt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colAnzahlPersAkt.Width = 190
        '
        'colPreisAkt
        '
        Me.colPreisAkt.Text = "Preis"
        Me.colPreisAkt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colPreisAkt.Width = 168
        '
        'colKundeIDAkt
        '
        Me.colKundeIDAkt.Text = "Kunden ID"
        Me.colKundeIDAkt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colKundeIDAkt.Width = 186
        '
        'tbsStornoBuchungen
        '
        Me.tbsStornoBuchungen.Controls.Add(Me.ListViewStorniertBuchungen)
        Me.tbsStornoBuchungen.Location = New System.Drawing.Point(8, 39)
        Me.tbsStornoBuchungen.Name = "tbsStornoBuchungen"
        Me.tbsStornoBuchungen.Padding = New System.Windows.Forms.Padding(3)
        Me.tbsStornoBuchungen.Size = New System.Drawing.Size(1214, 567)
        Me.tbsStornoBuchungen.TabIndex = 1
        Me.tbsStornoBuchungen.Text = "Storniert"
        Me.tbsStornoBuchungen.UseVisualStyleBackColor = True
        '
        'ListViewStorniertBuchungen
        '
        Me.ListViewStorniertBuchungen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colBuchungIDStorn, Me.colKursStorn, Me.colWeiterbildungStorn, Me.colAnzahlPersStorn, Me.colPreisStorn, Me.colKundenIDStorn})
        Me.ListViewStorniertBuchungen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewStorniertBuchungen.Enabled = False
        Me.ListViewStorniertBuchungen.GridLines = True
        Me.ListViewStorniertBuchungen.HideSelection = False
        Me.ListViewStorniertBuchungen.Location = New System.Drawing.Point(3, 3)
        Me.ListViewStorniertBuchungen.Name = "ListViewStorniertBuchungen"
        Me.ListViewStorniertBuchungen.Size = New System.Drawing.Size(1208, 561)
        Me.ListViewStorniertBuchungen.TabIndex = 0
        Me.ListViewStorniertBuchungen.UseCompatibleStateImageBehavior = False
        Me.ListViewStorniertBuchungen.View = System.Windows.Forms.View.Details
        '
        'colBuchungIDStorn
        '
        Me.colBuchungIDStorn.Text = "Buchung ID"
        Me.colBuchungIDStorn.Width = 135
        '
        'colKursStorn
        '
        Me.colKursStorn.Text = "Kurs"
        Me.colKursStorn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colKursStorn.Width = 145
        '
        'colWeiterbildungStorn
        '
        Me.colWeiterbildungStorn.Text = "Weiterbildung"
        Me.colWeiterbildungStorn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colWeiterbildungStorn.Width = 379
        '
        'colAnzahlPersStorn
        '
        Me.colAnzahlPersStorn.Text = "Anzahl Personen"
        Me.colAnzahlPersStorn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colAnzahlPersStorn.Width = 190
        '
        'colPreisStorn
        '
        Me.colPreisStorn.Text = "Preis"
        Me.colPreisStorn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colPreisStorn.Width = 168
        '
        'colKundenIDStorn
        '
        Me.colKundenIDStorn.Text = "Kunden ID"
        Me.colKundenIDStorn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colKundenIDStorn.Width = 186
        '
        'BuchungenMitarbeiter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSchließen
        Me.ClientSize = New System.Drawing.Size(1254, 729)
        Me.Controls.Add(Me.tbsBuchungen)
        Me.Controls.Add(Me.btnSchließen)
        Me.Name = "BuchungenMitarbeiter"
        Me.Text = "Alle Buchungen"
        Me.tbsBuchungen.ResumeLayout(False)
        Me.tbsAktBuchungen.ResumeLayout(False)
        Me.tbsStornoBuchungen.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSchließen As Button
    Friend WithEvents tbsBuchungen As TabControl
    Friend WithEvents tbsAktBuchungen As TabPage
    Friend WithEvents ListView1 As ListView
    Friend WithEvents colBuchungIDAkt As ColumnHeader
    Friend WithEvents colKursAkt As ColumnHeader
    Friend WithEvents colWeiterbildungAkt As ColumnHeader
    Friend WithEvents colAnzahlPersAkt As ColumnHeader
    Friend WithEvents colPreisAkt As ColumnHeader
    Friend WithEvents colKundeIDAkt As ColumnHeader
    Friend WithEvents tbsStornoBuchungen As TabPage
    Friend WithEvents ListViewStorniertBuchungen As ListView
    Friend WithEvents colBuchungIDStorn As ColumnHeader
    Friend WithEvents colKursStorn As ColumnHeader
    Friend WithEvents colWeiterbildungStorn As ColumnHeader
    Friend WithEvents colAnzahlPersStorn As ColumnHeader
    Friend WithEvents colPreisStorn As ColumnHeader
    Friend WithEvents colKundenIDStorn As ColumnHeader
End Class
