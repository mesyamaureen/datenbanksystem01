<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuchungenKunde))
        Me.tbsBuchungen = New System.Windows.Forms.TabControl()
        Me.tbsAktivBuchungen = New System.Windows.Forms.TabPage()
        Me.ListViewAktBuchungen = New System.Windows.Forms.ListView()
        Me.colBuchungID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKurs = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colWeiterbildung = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbsInaktiv = New System.Windows.Forms.TabPage()
        Me.ListViewInaktBuchungen = New System.Windows.Forms.ListView()
        Me.colBuchungIDInakt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKursInakt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colWeiterbildungenInakt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.lblKundenID = New System.Windows.Forms.Label()
        Me.txtKundenID = New System.Windows.Forms.TextBox()
        Me.btnLoeschen = New System.Windows.Forms.Button()
        Me.tbsBuchungen.SuspendLayout()
        Me.tbsAktivBuchungen.SuspendLayout()
        Me.tbsInaktiv.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbsBuchungen
        '
        Me.tbsBuchungen.Controls.Add(Me.tbsAktivBuchungen)
        Me.tbsBuchungen.Controls.Add(Me.tbsInaktiv)
        Me.tbsBuchungen.Location = New System.Drawing.Point(6, 36)
        Me.tbsBuchungen.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tbsBuchungen.Name = "tbsBuchungen"
        Me.tbsBuchungen.SelectedIndex = 0
        Me.tbsBuchungen.Size = New System.Drawing.Size(615, 300)
        Me.tbsBuchungen.TabIndex = 0
        '
        'tbsAktivBuchungen
        '
        Me.tbsAktivBuchungen.Controls.Add(Me.ListViewAktBuchungen)
        Me.tbsAktivBuchungen.Location = New System.Drawing.Point(4, 22)
        Me.tbsAktivBuchungen.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tbsAktivBuchungen.Name = "tbsAktivBuchungen"
        Me.tbsAktivBuchungen.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tbsAktivBuchungen.Size = New System.Drawing.Size(607, 274)
        Me.tbsAktivBuchungen.TabIndex = 0
        Me.tbsAktivBuchungen.Text = "Aktiv"
        Me.tbsAktivBuchungen.UseVisualStyleBackColor = True
        '
        'ListViewAktBuchungen
        '
        Me.ListViewAktBuchungen.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListViewAktBuchungen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colBuchungID, Me.colKurs, Me.colWeiterbildung})
        Me.ListViewAktBuchungen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewAktBuchungen.FullRowSelect = True
        Me.ListViewAktBuchungen.GridLines = True
        Me.ListViewAktBuchungen.HideSelection = False
        Me.ListViewAktBuchungen.HoverSelection = True
        Me.ListViewAktBuchungen.Location = New System.Drawing.Point(2, 3)
        Me.ListViewAktBuchungen.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ListViewAktBuchungen.MultiSelect = False
        Me.ListViewAktBuchungen.Name = "ListViewAktBuchungen"
        Me.ListViewAktBuchungen.Size = New System.Drawing.Size(603, 268)
        Me.ListViewAktBuchungen.TabIndex = 0
        Me.ListViewAktBuchungen.UseCompatibleStateImageBehavior = False
        Me.ListViewAktBuchungen.View = System.Windows.Forms.View.Details
        '
        'colBuchungID
        '
        Me.colBuchungID.Text = "Buchung ID"
        Me.colBuchungID.Width = 100
        '
        'colKurs
        '
        Me.colKurs.Text = "Kurs Datum"
        Me.colKurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colKurs.Width = 125
        '
        'colWeiterbildung
        '
        Me.colWeiterbildung.Text = "Weiterbildung"
        Me.colWeiterbildung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colWeiterbildung.Width = 350
        '
        'tbsInaktiv
        '
        Me.tbsInaktiv.Controls.Add(Me.ListViewInaktBuchungen)
        Me.tbsInaktiv.Location = New System.Drawing.Point(4, 22)
        Me.tbsInaktiv.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tbsInaktiv.Name = "tbsInaktiv"
        Me.tbsInaktiv.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tbsInaktiv.Size = New System.Drawing.Size(607, 274)
        Me.tbsInaktiv.TabIndex = 1
        Me.tbsInaktiv.Text = "Inaktiv"
        Me.tbsInaktiv.UseVisualStyleBackColor = True
        '
        'ListViewInaktBuchungen
        '
        Me.ListViewInaktBuchungen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colBuchungIDInakt, Me.colKursInakt, Me.colWeiterbildungenInakt})
        Me.ListViewInaktBuchungen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewInaktBuchungen.GridLines = True
        Me.ListViewInaktBuchungen.HideSelection = False
        Me.ListViewInaktBuchungen.Location = New System.Drawing.Point(2, 3)
        Me.ListViewInaktBuchungen.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ListViewInaktBuchungen.Name = "ListViewInaktBuchungen"
        Me.ListViewInaktBuchungen.Size = New System.Drawing.Size(603, 268)
        Me.ListViewInaktBuchungen.TabIndex = 0
        Me.ListViewInaktBuchungen.UseCompatibleStateImageBehavior = False
        Me.ListViewInaktBuchungen.View = System.Windows.Forms.View.Details
        '
        'colBuchungIDInakt
        '
        Me.colBuchungIDInakt.Text = "Buchung ID"
        Me.colBuchungIDInakt.Width = 100
        '
        'colKursInakt
        '
        Me.colKursInakt.Text = "Kurs"
        Me.colKursInakt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colKursInakt.Width = 125
        '
        'colWeiterbildungenInakt
        '
        Me.colWeiterbildungenInakt.Text = "Weiterbildung"
        Me.colWeiterbildungenInakt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colWeiterbildungenInakt.Width = 350
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(548, 344)
        Me.btnAbbrechen.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(68, 23)
        Me.btnAbbrechen.TabIndex = 1
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'lblKundenID
        '
        Me.lblKundenID.AutoSize = True
        Me.lblKundenID.Location = New System.Drawing.Point(8, 10)
        Me.lblKundenID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKundenID.Name = "lblKundenID"
        Me.lblKundenID.Size = New System.Drawing.Size(58, 13)
        Me.lblKundenID.TabIndex = 3
        Me.lblKundenID.Text = "Kunden ID"
        '
        'txtKundenID
        '
        Me.txtKundenID.Location = New System.Drawing.Point(67, 6)
        Me.txtKundenID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtKundenID.Multiline = True
        Me.txtKundenID.Name = "txtKundenID"
        Me.txtKundenID.ReadOnly = True
        Me.txtKundenID.Size = New System.Drawing.Size(105, 18)
        Me.txtKundenID.TabIndex = 4
        '
        'btnLoeschen
        '
        Me.btnLoeschen.Location = New System.Drawing.Point(476, 344)
        Me.btnLoeschen.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnLoeschen.Name = "btnLoeschen"
        Me.btnLoeschen.Size = New System.Drawing.Size(63, 23)
        Me.btnLoeschen.TabIndex = 2
        Me.btnLoeschen.Text = "Löschen"
        Me.btnLoeschen.UseVisualStyleBackColor = True
        '
        'BuchungenKunde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(627, 380)
        Me.Controls.Add(Me.txtKundenID)
        Me.Controls.Add(Me.lblKundenID)
        Me.Controls.Add(Me.btnLoeschen)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.tbsBuchungen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
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
    Friend WithEvents lblKundenID As Label
    Friend WithEvents txtKundenID As TextBox
    Friend WithEvents colBuchungID As ColumnHeader
    Friend WithEvents colKurs As ColumnHeader
    Friend WithEvents colWeiterbildung As ColumnHeader
    Friend WithEvents ListViewInaktBuchungen As ListView
    Friend WithEvents colBuchungIDInakt As ColumnHeader
    Friend WithEvents colKursInakt As ColumnHeader
    Friend WithEvents colWeiterbildungenInakt As ColumnHeader
    Friend WithEvents btnHinzufuegen As Button
    Friend WithEvents btnLoeschen As Button
End Class
