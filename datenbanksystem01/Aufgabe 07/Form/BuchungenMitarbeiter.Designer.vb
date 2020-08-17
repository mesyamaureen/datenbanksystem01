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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuchungenMitarbeiter))
        Me.btnSchließen = New System.Windows.Forms.Button()
        Me.tbsBuchungen = New System.Windows.Forms.TabControl()
        Me.tbsAktBuchungen = New System.Windows.Forms.TabPage()
        Me.LstViewAlleBuchungen = New System.Windows.Forms.ListView()
        Me.colBuchungIDAkt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKundenBenutzername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKundenIDAkt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colWeiterbildungAkt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKursDatum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKursID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbsInaktBuchungen = New System.Windows.Forms.TabPage()
        Me.ListViewStorniertBuchungen = New System.Windows.Forms.ListView()
        Me.colIndexStorn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBuchungIDStorn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colWeiterbildungStorn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKundenIDStorn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbsBuchungen.SuspendLayout()
        Me.tbsAktBuchungen.SuspendLayout()
        Me.tbsInaktBuchungen.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSchließen
        '
        Me.btnSchließen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSchließen.Location = New System.Drawing.Point(554, 344)
        Me.btnSchließen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSchließen.Name = "btnSchließen"
        Me.btnSchließen.Size = New System.Drawing.Size(63, 23)
        Me.btnSchließen.TabIndex = 0
        Me.btnSchließen.Text = "Schließen"
        Me.btnSchließen.UseVisualStyleBackColor = True
        '
        'tbsBuchungen
        '
        Me.tbsBuchungen.Controls.Add(Me.tbsAktBuchungen)
        Me.tbsBuchungen.Controls.Add(Me.tbsInaktBuchungen)
        Me.tbsBuchungen.Location = New System.Drawing.Point(6, 16)
        Me.tbsBuchungen.Margin = New System.Windows.Forms.Padding(2)
        Me.tbsBuchungen.Name = "tbsBuchungen"
        Me.tbsBuchungen.SelectedIndex = 0
        Me.tbsBuchungen.Size = New System.Drawing.Size(615, 319)
        Me.tbsBuchungen.TabIndex = 1
        '
        'tbsAktBuchungen
        '
        Me.tbsAktBuchungen.Controls.Add(Me.LstViewAlleBuchungen)
        Me.tbsAktBuchungen.Location = New System.Drawing.Point(4, 22)
        Me.tbsAktBuchungen.Margin = New System.Windows.Forms.Padding(2)
        Me.tbsAktBuchungen.Name = "tbsAktBuchungen"
        Me.tbsAktBuchungen.Padding = New System.Windows.Forms.Padding(2)
        Me.tbsAktBuchungen.Size = New System.Drawing.Size(607, 293)
        Me.tbsAktBuchungen.TabIndex = 0
        Me.tbsAktBuchungen.Text = "Aktiv"
        Me.tbsAktBuchungen.UseVisualStyleBackColor = True
        '
        'LstViewAlleBuchungen
        '
        Me.LstViewAlleBuchungen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colBuchungIDAkt, Me.colKundenBenutzername, Me.colKundenIDAkt, Me.colWeiterbildungAkt, Me.colKursDatum, Me.colKursID})
        Me.LstViewAlleBuchungen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstViewAlleBuchungen.GridLines = True
        Me.LstViewAlleBuchungen.HideSelection = False
        Me.LstViewAlleBuchungen.Location = New System.Drawing.Point(2, 2)
        Me.LstViewAlleBuchungen.Margin = New System.Windows.Forms.Padding(2)
        Me.LstViewAlleBuchungen.Name = "LstViewAlleBuchungen"
        Me.LstViewAlleBuchungen.Size = New System.Drawing.Size(603, 289)
        Me.LstViewAlleBuchungen.TabIndex = 0
        Me.LstViewAlleBuchungen.UseCompatibleStateImageBehavior = False
        Me.LstViewAlleBuchungen.View = System.Windows.Forms.View.Details
        '
        'colBuchungIDAkt
        '
        Me.colBuchungIDAkt.Text = "Buchung ID"
        Me.colBuchungIDAkt.Width = 100
        '
        'colKundenBenutzername
        '
        Me.colKundenBenutzername.Text = "Benutzername Kunde"
        Me.colKundenBenutzername.Width = 150
        '
        'colKundenIDAkt
        '
        Me.colKundenIDAkt.Text = "KundenID"
        Me.colKundenIDAkt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colKundenIDAkt.Width = 100
        '
        'colWeiterbildungAkt
        '
        Me.colWeiterbildungAkt.Text = "Weiterbildung"
        Me.colWeiterbildungAkt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colWeiterbildungAkt.Width = 170
        '
        'colKursDatum
        '
        Me.colKursDatum.Text = "Datum des Kurses"
        Me.colKursDatum.Width = 100
        '
        'colKursID
        '
        Me.colKursID.Text = "KursID"
        Me.colKursID.Width = 100
        '
        'tbsInaktBuchungen
        '
        Me.tbsInaktBuchungen.Controls.Add(Me.ListViewStorniertBuchungen)
        Me.tbsInaktBuchungen.Location = New System.Drawing.Point(4, 22)
        Me.tbsInaktBuchungen.Margin = New System.Windows.Forms.Padding(2)
        Me.tbsInaktBuchungen.Name = "tbsInaktBuchungen"
        Me.tbsInaktBuchungen.Padding = New System.Windows.Forms.Padding(2)
        Me.tbsInaktBuchungen.Size = New System.Drawing.Size(607, 293)
        Me.tbsInaktBuchungen.TabIndex = 1
        Me.tbsInaktBuchungen.Text = "Inaktiv"
        Me.tbsInaktBuchungen.UseVisualStyleBackColor = True
        '
        'ListViewStorniertBuchungen
        '
        Me.ListViewStorniertBuchungen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colIndexStorn, Me.colBuchungIDStorn, Me.colWeiterbildungStorn, Me.colKundenIDStorn})
        Me.ListViewStorniertBuchungen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewStorniertBuchungen.Enabled = False
        Me.ListViewStorniertBuchungen.GridLines = True
        Me.ListViewStorniertBuchungen.HideSelection = False
        Me.ListViewStorniertBuchungen.Location = New System.Drawing.Point(2, 2)
        Me.ListViewStorniertBuchungen.Margin = New System.Windows.Forms.Padding(2)
        Me.ListViewStorniertBuchungen.Name = "ListViewStorniertBuchungen"
        Me.ListViewStorniertBuchungen.Size = New System.Drawing.Size(603, 289)
        Me.ListViewStorniertBuchungen.TabIndex = 0
        Me.ListViewStorniertBuchungen.UseCompatibleStateImageBehavior = False
        Me.ListViewStorniertBuchungen.View = System.Windows.Forms.View.Details
        '
        'colIndexStorn
        '
        Me.colIndexStorn.Text = "Nr"
        '
        'colBuchungIDStorn
        '
        Me.colBuchungIDStorn.Text = "Buchung ID"
        Me.colBuchungIDStorn.Width = 135
        '
        'colWeiterbildungStorn
        '
        Me.colWeiterbildungStorn.Text = "Weiterbildung"
        Me.colWeiterbildungStorn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colWeiterbildungStorn.Width = 429
        '
        'colKundenIDStorn
        '
        Me.colKundenIDStorn.Text = "Kunden ID"
        Me.colKundenIDStorn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colKundenIDStorn.Width = 158
        '
        'BuchungenMitarbeiter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSchließen
        Me.ClientSize = New System.Drawing.Size(632, 376)
        Me.Controls.Add(Me.tbsBuchungen)
        Me.Controls.Add(Me.btnSchließen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "BuchungenMitarbeiter"
        Me.Text = "Alle Buchungen"
        Me.tbsBuchungen.ResumeLayout(False)
        Me.tbsAktBuchungen.ResumeLayout(False)
        Me.tbsInaktBuchungen.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSchließen As Button
    Friend WithEvents tbsBuchungen As TabControl
    Friend WithEvents tbsAktBuchungen As TabPage
    Friend WithEvents LstViewAlleBuchungen As ListView
    Friend WithEvents colBuchungIDAkt As ColumnHeader
    Friend WithEvents colWeiterbildungAkt As ColumnHeader
    Friend WithEvents colKundenIDAkt As ColumnHeader
    Friend WithEvents tbsInaktBuchungen As TabPage
    Friend WithEvents ListViewStorniertBuchungen As ListView
    Friend WithEvents colBuchungIDStorn As ColumnHeader
    Friend WithEvents colWeiterbildungStorn As ColumnHeader
    Friend WithEvents colIndexStorn As ColumnHeader
    Friend WithEvents colKundenIDStorn As ColumnHeader
    Friend WithEvents colKundenBenutzername As ColumnHeader
    Friend WithEvents colKursDatum As ColumnHeader
    Friend WithEvents colKursID As ColumnHeader
End Class
