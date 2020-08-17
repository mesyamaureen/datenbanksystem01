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
        Me.btnNeuerMitarbeiter = New System.Windows.Forms.Button()
        Me.btnMeinKonto = New System.Windows.Forms.Button()
        Me.btnKundenkonto = New System.Windows.Forms.Button()
        Me.btnBuchungenM = New System.Windows.Forms.Button()
        Me.grpboxWeiterbildung = New System.Windows.Forms.GroupBox()
        Me.btnLoeschen = New System.Windows.Forms.Button()
        Me.btnHinzufuegen = New System.Windows.Forms.Button()
        Me.btnOeffnenM = New System.Windows.Forms.Button()
        Me.lstviewWeiterbildungenM = New System.Windows.Forms.ListView()
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
        Me.grpboxThemen.Controls.Add(Me.btnNeuerMitarbeiter)
        Me.grpboxThemen.Controls.Add(Me.btnMeinKonto)
        Me.grpboxThemen.Controls.Add(Me.btnKundenkonto)
        Me.grpboxThemen.Controls.Add(Me.btnBuchungenM)
        Me.grpboxThemen.Location = New System.Drawing.Point(8, 6)
        Me.grpboxThemen.Margin = New System.Windows.Forms.Padding(2)
        Me.grpboxThemen.Name = "grpboxThemen"
        Me.grpboxThemen.Padding = New System.Windows.Forms.Padding(2)
        Me.grpboxThemen.Size = New System.Drawing.Size(218, 478)
        Me.grpboxThemen.TabIndex = 1
        Me.grpboxThemen.TabStop = False
        Me.grpboxThemen.Text = "Themen"
        '
        'btnNeuerMitarbeiter
        '
        Me.btnNeuerMitarbeiter.Location = New System.Drawing.Point(49, 338)
        Me.btnNeuerMitarbeiter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNeuerMitarbeiter.Name = "btnNeuerMitarbeiter"
        Me.btnNeuerMitarbeiter.Size = New System.Drawing.Size(95, 95)
        Me.btnNeuerMitarbeiter.TabIndex = 4
        Me.btnNeuerMitarbeiter.Text = "Neuer Mitarbeiter"
        Me.btnNeuerMitarbeiter.UseVisualStyleBackColor = True
        '
        'btnMeinKonto
        '
        Me.btnMeinKonto.Location = New System.Drawing.Point(49, 239)
        Me.btnMeinKonto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMeinKonto.Name = "btnMeinKonto"
        Me.btnMeinKonto.Size = New System.Drawing.Size(95, 95)
        Me.btnMeinKonto.TabIndex = 3
        Me.btnMeinKonto.Text = "Mein Konto"
        Me.btnMeinKonto.UseVisualStyleBackColor = True
        '
        'btnKundenkonto
        '
        Me.btnKundenkonto.Location = New System.Drawing.Point(49, 140)
        Me.btnKundenkonto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnKundenkonto.Name = "btnKundenkonto"
        Me.btnKundenkonto.Size = New System.Drawing.Size(95, 95)
        Me.btnKundenkonto.TabIndex = 2
        Me.btnKundenkonto.Text = "Kundenkonten"
        Me.btnKundenkonto.UseVisualStyleBackColor = True
        '
        'btnBuchungenM
        '
        Me.btnBuchungenM.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBuchungenM.Location = New System.Drawing.Point(49, 41)
        Me.btnBuchungenM.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuchungenM.Name = "btnBuchungenM"
        Me.btnBuchungenM.Size = New System.Drawing.Size(95, 95)
        Me.btnBuchungenM.TabIndex = 1
        Me.btnBuchungenM.Text = "Buchungen"
        Me.btnBuchungenM.UseVisualStyleBackColor = True
        '
        'grpboxWeiterbildung
        '
        Me.grpboxWeiterbildung.Controls.Add(Me.btnLoeschen)
        Me.grpboxWeiterbildung.Controls.Add(Me.btnHinzufuegen)
        Me.grpboxWeiterbildung.Controls.Add(Me.btnOeffnenM)
        Me.grpboxWeiterbildung.Controls.Add(Me.lstviewWeiterbildungenM)
        Me.grpboxWeiterbildung.Controls.Add(Me.lblSucheM)
        Me.grpboxWeiterbildung.Controls.Add(Me.txtboxSucheM)
        Me.grpboxWeiterbildung.Location = New System.Drawing.Point(230, 6)
        Me.grpboxWeiterbildung.Margin = New System.Windows.Forms.Padding(2)
        Me.grpboxWeiterbildung.Name = "grpboxWeiterbildung"
        Me.grpboxWeiterbildung.Padding = New System.Windows.Forms.Padding(2)
        Me.grpboxWeiterbildung.Size = New System.Drawing.Size(602, 478)
        Me.grpboxWeiterbildung.TabIndex = 2
        Me.grpboxWeiterbildung.TabStop = False
        Me.grpboxWeiterbildung.Text = "Weiterbildungsangebot"
        '
        'btnLoeschen
        '
        Me.btnLoeschen.Enabled = False
        Me.btnLoeschen.Location = New System.Drawing.Point(276, 433)
        Me.btnLoeschen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoeschen.Name = "btnLoeschen"
        Me.btnLoeschen.Size = New System.Drawing.Size(95, 29)
        Me.btnLoeschen.TabIndex = 5
        Me.btnLoeschen.Text = "Löschen"
        Me.btnLoeschen.UseVisualStyleBackColor = True
        '
        'btnHinzufuegen
        '
        Me.btnHinzufuegen.Location = New System.Drawing.Point(392, 433)
        Me.btnHinzufuegen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHinzufuegen.Name = "btnHinzufuegen"
        Me.btnHinzufuegen.Size = New System.Drawing.Size(95, 29)
        Me.btnHinzufuegen.TabIndex = 4
        Me.btnHinzufuegen.Text = "Hinzufügen"
        Me.btnHinzufuegen.UseVisualStyleBackColor = True
        '
        'btnOeffnenM
        '
        Me.btnOeffnenM.Enabled = False
        Me.btnOeffnenM.Location = New System.Drawing.Point(503, 433)
        Me.btnOeffnenM.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOeffnenM.Name = "btnOeffnenM"
        Me.btnOeffnenM.Size = New System.Drawing.Size(95, 29)
        Me.btnOeffnenM.TabIndex = 3
        Me.btnOeffnenM.Text = "Öffnen"
        Me.btnOeffnenM.UseVisualStyleBackColor = True
        '
        'lstviewWeiterbildungenM
        '
        Me.lstviewWeiterbildungenM.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colWeiterbildungIdM, Me.colWeiterbildungM, Me.colThemaM})
        Me.lstviewWeiterbildungenM.FullRowSelect = True
        Me.lstviewWeiterbildungenM.GridLines = True
        Me.lstviewWeiterbildungenM.HideSelection = False
        Me.lstviewWeiterbildungenM.Location = New System.Drawing.Point(5, 41)
        Me.lstviewWeiterbildungenM.Margin = New System.Windows.Forms.Padding(2)
        Me.lstviewWeiterbildungenM.MultiSelect = False
        Me.lstviewWeiterbildungenM.Name = "lstviewWeiterbildungenM"
        Me.lstviewWeiterbildungenM.Size = New System.Drawing.Size(594, 376)
        Me.lstviewWeiterbildungenM.TabIndex = 2
        Me.lstviewWeiterbildungenM.UseCompatibleStateImageBehavior = False
        Me.lstviewWeiterbildungenM.View = System.Windows.Forms.View.Details
        '
        'colWeiterbildungIdM
        '
        Me.colWeiterbildungIdM.Text = "Weiterbil. ID"
        Me.colWeiterbildungIdM.Width = 75
        '
        'colWeiterbildungM
        '
        Me.colWeiterbildungM.Text = "Weiterbildung"
        Me.colWeiterbildungM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colWeiterbildungM.Width = 250
        '
        'colThemaM
        '
        Me.colThemaM.Text = "Thema"
        Me.colThemaM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colThemaM.Width = 250
        '
        'lblSucheM
        '
        Me.lblSucheM.AutoSize = True
        Me.lblSucheM.Location = New System.Drawing.Point(355, 14)
        Me.lblSucheM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSucheM.Name = "lblSucheM"
        Me.lblSucheM.Size = New System.Drawing.Size(38, 13)
        Me.lblSucheM.TabIndex = 1
        Me.lblSucheM.Text = "Suche"
        '
        'txtboxSucheM
        '
        Me.txtboxSucheM.Location = New System.Drawing.Point(400, 12)
        Me.txtboxSucheM.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxSucheM.Multiline = True
        Me.txtboxSucheM.Name = "txtboxSucheM"
        Me.txtboxSucheM.Size = New System.Drawing.Size(200, 21)
        Me.txtboxSucheM.TabIndex = 0
        '
        'btnBeendenProgramm
        '
        Me.btnBeendenProgramm.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBeendenProgramm.Location = New System.Drawing.Point(733, 497)
        Me.btnBeendenProgramm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBeendenProgramm.Name = "btnBeendenProgramm"
        Me.btnBeendenProgramm.Size = New System.Drawing.Size(94, 29)
        Me.btnBeendenProgramm.TabIndex = 4
        Me.btnBeendenProgramm.Text = "Beenden"
        Me.btnBeendenProgramm.UseVisualStyleBackColor = True
        '
        'frmHauptfensterMitarbeiter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 535)
        Me.Controls.Add(Me.btnBeendenProgramm)
        Me.Controls.Add(Me.grpboxWeiterbildung)
        Me.Controls.Add(Me.grpboxThemen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(854, 574)
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
    Friend WithEvents btnMeinKonto As Button
    Friend WithEvents btnKundenkonto As Button
    Friend WithEvents btnBuchungenM As Button
    Friend WithEvents txtboxSucheM As TextBox
    Friend WithEvents lblSucheM As Label
    Friend WithEvents lstviewWeiterbildungenM As ListView
    Friend WithEvents btnHinzufuegen As Button
    Friend WithEvents btnOeffnenM As Button
    Friend WithEvents colWeiterbildungIdM As ColumnHeader
    Friend WithEvents colWeiterbildungM As ColumnHeader
    Friend WithEvents colThemaM As ColumnHeader
    Friend WithEvents btnLoeschen As Button
    Friend WithEvents btnBeendenProgramm As Button
    Friend WithEvents btnNeuerMitarbeiter As Button
End Class
