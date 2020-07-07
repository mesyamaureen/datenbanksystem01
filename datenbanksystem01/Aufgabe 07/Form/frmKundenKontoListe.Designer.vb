<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKundenKontoListe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKundenKontoListe))
        Me.btnSchliessen = New System.Windows.Forms.Button()
        Me.lstviewKundenKonten = New System.Windows.Forms.ListView()
        Me.colKundenID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBenutzername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVorname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colGebDat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFirma = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnLaden = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSchliessen
        '
        Me.btnSchliessen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSchliessen.Location = New System.Drawing.Point(1062, 669)
        Me.btnSchliessen.Name = "btnSchliessen"
        Me.btnSchliessen.Size = New System.Drawing.Size(182, 56)
        Me.btnSchliessen.TabIndex = 0
        Me.btnSchliessen.Text = "Schließen"
        Me.btnSchliessen.UseVisualStyleBackColor = True
        '
        'lstviewKundenKonten
        '
        Me.lstviewKundenKonten.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colKundenID, Me.colBenutzername, Me.colVorname, Me.colName, Me.colGebDat, Me.colFirma})
        Me.lstviewKundenKonten.Enabled = False
        Me.lstviewKundenKonten.FullRowSelect = True
        Me.lstviewKundenKonten.GridLines = True
        Me.lstviewKundenKonten.HideSelection = False
        Me.lstviewKundenKonten.Location = New System.Drawing.Point(12, 12)
        Me.lstviewKundenKonten.MultiSelect = False
        Me.lstviewKundenKonten.Name = "lstviewKundenKonten"
        Me.lstviewKundenKonten.Size = New System.Drawing.Size(1230, 627)
        Me.lstviewKundenKonten.TabIndex = 1
        Me.lstviewKundenKonten.UseCompatibleStateImageBehavior = False
        Me.lstviewKundenKonten.View = System.Windows.Forms.View.Details
        '
        'colKundenID
        '
        Me.colKundenID.Text = "ID"
        Me.colKundenID.Width = 110
        '
        'colBenutzername
        '
        Me.colBenutzername.Text = "Benutzername"
        Me.colBenutzername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colBenutzername.Width = 255
        '
        'colVorname
        '
        Me.colVorname.Text = "Vorname"
        Me.colVorname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colVorname.Width = 272
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colName.Width = 244
        '
        'colGebDat
        '
        Me.colGebDat.Text = "Geburtsdatum"
        Me.colGebDat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colGebDat.Width = 173
        '
        'colFirma
        '
        Me.colFirma.Text = "Firma"
        Me.colFirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colFirma.Width = 171
        '
        'btnLaden
        '
        Me.btnLaden.Location = New System.Drawing.Point(828, 669)
        Me.btnLaden.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLaden.Name = "btnLaden"
        Me.btnLaden.Size = New System.Drawing.Size(182, 56)
        Me.btnLaden.TabIndex = 2
        Me.btnLaden.Text = "Details"
        Me.btnLaden.UseVisualStyleBackColor = True
        '
        'frmKundenKontoListe
        '
        Me.AcceptButton = Me.btnLaden
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSchliessen
        Me.ClientSize = New System.Drawing.Size(1262, 745)
        Me.Controls.Add(Me.btnLaden)
        Me.Controls.Add(Me.lstviewKundenKonten)
        Me.Controls.Add(Me.btnSchliessen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmKundenKontoListe"
        Me.Text = "Liste von Kundenkonten"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSchliessen As Button
    Friend WithEvents lstviewKundenKonten As ListView
    Friend WithEvents colKundenID As ColumnHeader
    Friend WithEvents colBenutzername As ColumnHeader
    Friend WithEvents colVorname As ColumnHeader
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colGebDat As ColumnHeader
    Friend WithEvents colFirma As ColumnHeader
    Friend WithEvents btnLaden As Button
End Class
