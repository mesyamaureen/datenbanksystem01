<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHauptfensterKunde
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHauptfensterKunde))
        Me.grpboxMenü = New System.Windows.Forms.GroupBox()
        Me.btnHilfe = New System.Windows.Forms.Button()
        Me.btnKonto = New System.Windows.Forms.Button()
        Me.btnBuchungen = New System.Windows.Forms.Button()
        Me.btnWeiterbildungen = New System.Windows.Forms.Button()
        Me.grpboxWeiterbildung = New System.Windows.Forms.GroupBox()
        Me.btnOeffnen = New System.Windows.Forms.Button()
        Me.lstviewWeiterbildungKunde = New System.Windows.Forms.ListView()
        Me.colWeiterbildungID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colWeiterbildung = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colThema = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblSuchen = New System.Windows.Forms.Label()
        Me.txtboxSuche = New System.Windows.Forms.TextBox()
        Me.btnBeenden = New System.Windows.Forms.Button()
        Me.grpboxMenü.SuspendLayout()
        Me.grpboxWeiterbildung.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpboxMenü
        '
        Me.grpboxMenü.Controls.Add(Me.btnHilfe)
        Me.grpboxMenü.Controls.Add(Me.btnKonto)
        Me.grpboxMenü.Controls.Add(Me.btnBuchungen)
        Me.grpboxMenü.Controls.Add(Me.btnWeiterbildungen)
        Me.grpboxMenü.Location = New System.Drawing.Point(16, 13)
        Me.grpboxMenü.Margin = New System.Windows.Forms.Padding(4)
        Me.grpboxMenü.Name = "grpboxMenü"
        Me.grpboxMenü.Padding = New System.Windows.Forms.Padding(4)
        Me.grpboxMenü.Size = New System.Drawing.Size(435, 1077)
        Me.grpboxMenü.TabIndex = 1
        Me.grpboxMenü.TabStop = False
        Me.grpboxMenü.Text = "Menü"
        '
        'btnHilfe
        '
        Me.btnHilfe.Location = New System.Drawing.Point(111, 797)
        Me.btnHilfe.Name = "btnHilfe"
        Me.btnHilfe.Size = New System.Drawing.Size(191, 56)
        Me.btnHilfe.TabIndex = 3
        Me.btnHilfe.Text = "Hilfe"
        Me.btnHilfe.UseVisualStyleBackColor = True
        '
        'btnKonto
        '
        Me.btnKonto.Location = New System.Drawing.Point(111, 597)
        Me.btnKonto.Name = "btnKonto"
        Me.btnKonto.Size = New System.Drawing.Size(191, 56)
        Me.btnKonto.TabIndex = 2
        Me.btnKonto.Text = "Konto"
        Me.btnKonto.UseVisualStyleBackColor = True
        '
        'btnBuchungen
        '
        Me.btnBuchungen.Location = New System.Drawing.Point(111, 403)
        Me.btnBuchungen.Name = "btnBuchungen"
        Me.btnBuchungen.Size = New System.Drawing.Size(191, 56)
        Me.btnBuchungen.TabIndex = 1
        Me.btnBuchungen.Text = "Buchungen"
        Me.btnBuchungen.UseVisualStyleBackColor = True
        '
        'btnWeiterbildungen
        '
        Me.btnWeiterbildungen.Location = New System.Drawing.Point(111, 211)
        Me.btnWeiterbildungen.Name = "btnWeiterbildungen"
        Me.btnWeiterbildungen.Size = New System.Drawing.Size(191, 56)
        Me.btnWeiterbildungen.TabIndex = 0
        Me.btnWeiterbildungen.Text = "Weiterbildungen"
        Me.btnWeiterbildungen.UseVisualStyleBackColor = True
        '
        'grpboxWeiterbildung
        '
        Me.grpboxWeiterbildung.Controls.Add(Me.btnOeffnen)
        Me.grpboxWeiterbildung.Controls.Add(Me.lstviewWeiterbildungKunde)
        Me.grpboxWeiterbildung.Controls.Add(Me.lblSuchen)
        Me.grpboxWeiterbildung.Controls.Add(Me.txtboxSuche)
        Me.grpboxWeiterbildung.Location = New System.Drawing.Point(459, 24)
        Me.grpboxWeiterbildung.Margin = New System.Windows.Forms.Padding(4)
        Me.grpboxWeiterbildung.Name = "grpboxWeiterbildung"
        Me.grpboxWeiterbildung.Padding = New System.Windows.Forms.Padding(4)
        Me.grpboxWeiterbildung.Size = New System.Drawing.Size(1203, 1066)
        Me.grpboxWeiterbildung.TabIndex = 2
        Me.grpboxWeiterbildung.TabStop = False
        Me.grpboxWeiterbildung.Text = "Weiterbildungsangebote"
        '
        'btnOeffnen
        '
        Me.btnOeffnen.Location = New System.Drawing.Point(1004, 988)
        Me.btnOeffnen.Name = "btnOeffnen"
        Me.btnOeffnen.Size = New System.Drawing.Size(191, 56)
        Me.btnOeffnen.TabIndex = 3
        Me.btnOeffnen.Text = "Öffnen"
        Me.btnOeffnen.UseVisualStyleBackColor = True
        '
        'lstviewWeiterbildungKunde
        '
        Me.lstviewWeiterbildungKunde.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstviewWeiterbildungKunde.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colWeiterbildungID, Me.colWeiterbildung, Me.colThema})
        Me.lstviewWeiterbildungKunde.FullRowSelect = True
        Me.lstviewWeiterbildungKunde.GridLines = True
        Me.lstviewWeiterbildungKunde.HideSelection = False
        Me.lstviewWeiterbildungKunde.HoverSelection = True
        Me.lstviewWeiterbildungKunde.Location = New System.Drawing.Point(10, 97)
        Me.lstviewWeiterbildungKunde.MultiSelect = False
        Me.lstviewWeiterbildungKunde.Name = "lstviewWeiterbildungKunde"
        Me.lstviewWeiterbildungKunde.Size = New System.Drawing.Size(1185, 870)
        Me.lstviewWeiterbildungKunde.TabIndex = 2
        Me.lstviewWeiterbildungKunde.UseCompatibleStateImageBehavior = False
        Me.lstviewWeiterbildungKunde.View = System.Windows.Forms.View.Details
        '
        'colWeiterbildungID
        '
        Me.colWeiterbildungID.Text = "Weiterbildung ID"
        Me.colWeiterbildungID.Width = 225
        '
        'colWeiterbildung
        '
        Me.colWeiterbildung.Text = "Weiterbildung"
        Me.colWeiterbildung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colWeiterbildung.Width = 608
        '
        'colThema
        '
        Me.colThema.Text = "Thema"
        Me.colThema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colThema.Width = 346
        '
        'lblSuchen
        '
        Me.lblSuchen.AutoSize = True
        Me.lblSuchen.Location = New System.Drawing.Point(710, 34)
        Me.lblSuchen.Name = "lblSuchen"
        Me.lblSuchen.Size = New System.Drawing.Size(85, 25)
        Me.lblSuchen.TabIndex = 1
        Me.lblSuchen.Text = "Suchen"
        '
        'txtboxSuche
        '
        Me.txtboxSuche.Location = New System.Drawing.Point(801, 31)
        Me.txtboxSuche.Multiline = True
        Me.txtboxSuche.Name = "txtboxSuche"
        Me.txtboxSuche.Size = New System.Drawing.Size(395, 37)
        Me.txtboxSuche.TabIndex = 0
        '
        'btnBeenden
        '
        Me.btnBeenden.Location = New System.Drawing.Point(1475, 1127)
        Me.btnBeenden.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBeenden.Name = "btnBeenden"
        Me.btnBeenden.Size = New System.Drawing.Size(191, 56)
        Me.btnBeenden.TabIndex = 4
        Me.btnBeenden.Text = "Beenden"
        Me.btnBeenden.UseVisualStyleBackColor = True
        '
        'frmHauptfensterKunde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1677, 1210)
        Me.Controls.Add(Me.btnBeenden)
        Me.Controls.Add(Me.grpboxWeiterbildung)
        Me.Controls.Add(Me.grpboxMenü)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmHauptfensterKunde"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weiterbildung time2-Akademie"
        Me.grpboxMenü.ResumeLayout(False)
        Me.grpboxWeiterbildung.ResumeLayout(False)
        Me.grpboxWeiterbildung.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpboxMenü As GroupBox
    Friend WithEvents grpboxWeiterbildung As GroupBox
    Friend WithEvents btnBeenden As Button
    Friend WithEvents btnWeiterbildungen As Button
    Friend WithEvents btnBuchungen As Button
    Friend WithEvents btnHilfe As Button
    Friend WithEvents btnKonto As Button
    Friend WithEvents txtboxSuche As TextBox
    Friend WithEvents btnOeffnen As Button
    Friend WithEvents lstviewWeiterbildungKunde As ListView
    Friend WithEvents colWeiterbildungID As ColumnHeader
    Friend WithEvents colThema As ColumnHeader
    Friend WithEvents lblSuchen As Label
    Friend WithEvents colWeiterbildung As ColumnHeader
End Class
