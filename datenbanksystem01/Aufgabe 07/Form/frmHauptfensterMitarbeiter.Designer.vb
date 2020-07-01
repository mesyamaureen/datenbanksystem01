<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHauptfensterMitarbeiter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHauptfensterMitarbeiter))
        Me.grpboxThemen = New System.Windows.Forms.GroupBox()
        Me.btnHilfeM = New System.Windows.Forms.Button()
        Me.btnMeinKonto = New System.Windows.Forms.Button()
        Me.btnKundenkonto = New System.Windows.Forms.Button()
        Me.btnBuchungenM = New System.Windows.Forms.Button()
        Me.btnWeiterbildungenM = New System.Windows.Forms.Button()
        Me.grpboxWeiterbildung = New System.Windows.Forms.GroupBox()
        Me.btnLoeschen = New System.Windows.Forms.Button()
        Me.btnHinzufuegen = New System.Windows.Forms.Button()
        Me.btnOeffnenM = New System.Windows.Forms.Button()
        Me.lstviewWeiterbildungenM = New System.Windows.Forms.ListView()
        Me.colIndex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colWeiterbildungIdM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colWeiterbildungM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colThemaM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblSucheM = New System.Windows.Forms.Label()
        Me.txtboxSucheM = New System.Windows.Forms.TextBox()
        Me.btnBeendenProgramm = New System.Windows.Forms.Button()
        Me.grpboxThemen.SuspendLayout()
        Me.grpboxWeiterbildung.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpboxThemen
        '
        Me.grpboxThemen.Controls.Add(Me.btnHilfeM)
        Me.grpboxThemen.Controls.Add(Me.btnMeinKonto)
        Me.grpboxThemen.Controls.Add(Me.btnKundenkonto)
        Me.grpboxThemen.Controls.Add(Me.btnBuchungenM)
        Me.grpboxThemen.Controls.Add(Me.btnWeiterbildungenM)
        Me.grpboxThemen.Location = New System.Drawing.Point(11, 8)
        Me.grpboxThemen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxThemen.Name = "grpboxThemen"
        Me.grpboxThemen.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxThemen.Size = New System.Drawing.Size(290, 588)
        Me.grpboxThemen.TabIndex = 1
        Me.grpboxThemen.TabStop = False
        Me.grpboxThemen.Text = "Themen"
        '
        'btnHilfeM
        '
        Me.btnHilfeM.Location = New System.Drawing.Point(65, 533)
        Me.btnHilfeM.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHilfeM.Name = "btnHilfeM"
        Me.btnHilfeM.Size = New System.Drawing.Size(127, 36)
        Me.btnHilfeM.TabIndex = 4
        Me.btnHilfeM.Text = "Hilfe"
        Me.btnHilfeM.UseVisualStyleBackColor = True
        '
        'btnMeinKonto
        '
        Me.btnMeinKonto.Location = New System.Drawing.Point(65, 416)
        Me.btnMeinKonto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMeinKonto.Name = "btnMeinKonto"
        Me.btnMeinKonto.Size = New System.Drawing.Size(127, 36)
        Me.btnMeinKonto.TabIndex = 3
        Me.btnMeinKonto.Text = "Mein Konto"
        Me.btnMeinKonto.UseVisualStyleBackColor = True
        '
        'btnKundenkonto
        '
        Me.btnKundenkonto.Location = New System.Drawing.Point(65, 286)
        Me.btnKundenkonto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnKundenkonto.Name = "btnKundenkonto"
        Me.btnKundenkonto.Size = New System.Drawing.Size(127, 36)
        Me.btnKundenkonto.TabIndex = 2
        Me.btnKundenkonto.Text = "Kundenkonto"
        Me.btnKundenkonto.UseVisualStyleBackColor = True
        '
        'btnBuchungenM
        '
        Me.btnBuchungenM.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBuchungenM.Location = New System.Drawing.Point(65, 173)
        Me.btnBuchungenM.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuchungenM.Name = "btnBuchungenM"
        Me.btnBuchungenM.Size = New System.Drawing.Size(127, 36)
        Me.btnBuchungenM.TabIndex = 1
        Me.btnBuchungenM.Text = "Buchungen"
        Me.btnBuchungenM.UseVisualStyleBackColor = True
        '
        'btnWeiterbildungenM
        '
        Me.btnWeiterbildungenM.Location = New System.Drawing.Point(65, 68)
        Me.btnWeiterbildungenM.Margin = New System.Windows.Forms.Padding(2)
        Me.btnWeiterbildungenM.Name = "btnWeiterbildungenM"
        Me.btnWeiterbildungenM.Size = New System.Drawing.Size(127, 36)
        Me.btnWeiterbildungenM.TabIndex = 0
        Me.btnWeiterbildungenM.Text = "Weiterbildungen"
        Me.btnWeiterbildungenM.UseVisualStyleBackColor = True
        '
        'grpboxWeiterbildung
        '
        Me.grpboxWeiterbildung.Controls.Add(Me.btnLoeschen)
        Me.grpboxWeiterbildung.Controls.Add(Me.btnHinzufuegen)
        Me.grpboxWeiterbildung.Controls.Add(Me.btnOeffnenM)
        Me.grpboxWeiterbildung.Controls.Add(Me.lstviewWeiterbildungenM)
        Me.grpboxWeiterbildung.Controls.Add(Me.lblSucheM)
        Me.grpboxWeiterbildung.Controls.Add(Me.txtboxSucheM)
        Me.grpboxWeiterbildung.Location = New System.Drawing.Point(306, 8)
        Me.grpboxWeiterbildung.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxWeiterbildung.Name = "grpboxWeiterbildung"
        Me.grpboxWeiterbildung.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxWeiterbildung.Size = New System.Drawing.Size(803, 588)
        Me.grpboxWeiterbildung.TabIndex = 2
        Me.grpboxWeiterbildung.TabStop = False
        Me.grpboxWeiterbildung.Text = "Weiterbildungsangebot"
        '
        'btnLoeschen
        '
        Me.btnLoeschen.Location = New System.Drawing.Point(368, 533)
        Me.btnLoeschen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoeschen.Name = "btnLoeschen"
        Me.btnLoeschen.Size = New System.Drawing.Size(127, 36)
        Me.btnLoeschen.TabIndex = 5
        Me.btnLoeschen.Text = "Löschen"
        Me.btnLoeschen.UseVisualStyleBackColor = True
        '
        'btnHinzufuegen
        '
        Me.btnHinzufuegen.Location = New System.Drawing.Point(523, 533)
        Me.btnHinzufuegen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHinzufuegen.Name = "btnHinzufuegen"
        Me.btnHinzufuegen.Size = New System.Drawing.Size(127, 36)
        Me.btnHinzufuegen.TabIndex = 4
        Me.btnHinzufuegen.Text = "Hinzufügen"
        Me.btnHinzufuegen.UseVisualStyleBackColor = True
        '
        'btnOeffnenM
        '
        Me.btnOeffnenM.Location = New System.Drawing.Point(671, 533)
        Me.btnOeffnenM.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOeffnenM.Name = "btnOeffnenM"
        Me.btnOeffnenM.Size = New System.Drawing.Size(127, 36)
        Me.btnOeffnenM.TabIndex = 3
        Me.btnOeffnenM.Text = "Öffnen"
        Me.btnOeffnenM.UseVisualStyleBackColor = True
        '
        'lstviewWeiterbildungenM
        '
        Me.lstviewWeiterbildungenM.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colIndex, Me.colWeiterbildungIdM, Me.colWeiterbildungM, Me.colThemaM})
        Me.lstviewWeiterbildungenM.FullRowSelect = True
        Me.lstviewWeiterbildungenM.GridLines = True
        Me.lstviewWeiterbildungenM.HideSelection = False
        Me.lstviewWeiterbildungenM.Location = New System.Drawing.Point(7, 51)
        Me.lstviewWeiterbildungenM.Margin = New System.Windows.Forms.Padding(2)
        Me.lstviewWeiterbildungenM.MultiSelect = False
        Me.lstviewWeiterbildungenM.Name = "lstviewWeiterbildungenM"
        Me.lstviewWeiterbildungenM.Size = New System.Drawing.Size(791, 462)
        Me.lstviewWeiterbildungenM.TabIndex = 2
        Me.lstviewWeiterbildungenM.UseCompatibleStateImageBehavior = False
        Me.lstviewWeiterbildungenM.View = System.Windows.Forms.View.Details
        '
        'colIndex
        '
        Me.colIndex.Text = "Nr"
        '
        'colWeiterbildungIdM
        '
        Me.colWeiterbildungIdM.Text = "Weiterbildung ID"
        Me.colWeiterbildungIdM.Width = 225
        '
        'colWeiterbildungM
        '
        Me.colWeiterbildungM.Text = "Weiterbildung"
        Me.colWeiterbildungM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colWeiterbildungM.Width = 546
        '
        'colThemaM
        '
        Me.colThemaM.Text = "Thema"
        Me.colThemaM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colThemaM.Width = 346
        '
        'lblSucheM
        '
        Me.lblSucheM.AutoSize = True
        Me.lblSucheM.Location = New System.Drawing.Point(473, 17)
        Me.lblSucheM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSucheM.Name = "lblSucheM"
        Me.lblSucheM.Size = New System.Drawing.Size(48, 17)
        Me.lblSucheM.TabIndex = 1
        Me.lblSucheM.Text = "Suche"
        '
        'txtboxSucheM
        '
        Me.txtboxSucheM.Location = New System.Drawing.Point(534, 15)
        Me.txtboxSucheM.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxSucheM.Multiline = True
        Me.txtboxSucheM.Name = "txtboxSucheM"
        Me.txtboxSucheM.Size = New System.Drawing.Size(265, 25)
        Me.txtboxSucheM.TabIndex = 0
        '
        'btnBeendenProgramm
        '
        Me.btnBeendenProgramm.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBeendenProgramm.Location = New System.Drawing.Point(977, 621)
        Me.btnBeendenProgramm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBeendenProgramm.Name = "btnBeendenProgramm"
        Me.btnBeendenProgramm.Size = New System.Drawing.Size(125, 36)
        Me.btnBeendenProgramm.TabIndex = 4
        Me.btnBeendenProgramm.Text = "Beenden"
        Me.btnBeendenProgramm.UseVisualStyleBackColor = True
        '
        'frmHauptfensterMitarbeiter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 675)
        Me.Controls.Add(Me.btnBeendenProgramm)
        Me.Controls.Add(Me.grpboxWeiterbildung)
        Me.Controls.Add(Me.grpboxThemen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(1134, 722)
        Me.Name = "frmHauptfensterMitarbeiter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weiterbildung time2-Akademie"
        Me.grpboxThemen.ResumeLayout(False)
        Me.grpboxWeiterbildung.ResumeLayout(False)
        Me.grpboxWeiterbildung.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpboxThemen As GroupBox
    Friend WithEvents grpboxWeiterbildung As GroupBox
    Friend WithEvents btnHilfeM As Button
    Friend WithEvents btnMeinKonto As Button
    Friend WithEvents btnKundenkonto As Button
    Friend WithEvents btnBuchungenM As Button
    Friend WithEvents btnWeiterbildungenM As Button
    Friend WithEvents txtboxSucheM As TextBox
    Friend WithEvents lblSucheM As Label
    Friend WithEvents lstviewWeiterbildungenM As ListView
    Friend WithEvents btnHinzufuegen As Button
    Friend WithEvents btnOeffnenM As Button
    Friend WithEvents colWeiterbildungIdM As ColumnHeader
    Friend WithEvents colWeiterbildungM As ColumnHeader
    Friend WithEvents colThemaM As ColumnHeader
    Friend WithEvents btnLoeschen As Button
    Friend WithEvents colIndex As ColumnHeader
    Friend WithEvents btnBeendenProgramm As Button
End Class
