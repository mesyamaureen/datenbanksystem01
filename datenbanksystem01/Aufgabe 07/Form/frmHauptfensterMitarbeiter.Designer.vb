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
        Me.grpboxWeiterbildung = New System.Windows.Forms.GroupBox()
        Me.btnBeenden = New System.Windows.Forms.Button()
        Me.btnWeiterbildungenM = New System.Windows.Forms.Button()
        Me.btnBuchungenM = New System.Windows.Forms.Button()
        Me.btnKundenkonto = New System.Windows.Forms.Button()
        Me.btnMeinKonto = New System.Windows.Forms.Button()
        Me.btnHilfeM = New System.Windows.Forms.Button()
        Me.txtboxSucheM = New System.Windows.Forms.TextBox()
        Me.lblSucheM = New System.Windows.Forms.Label()
        Me.lstviewWeiterbildungenM = New System.Windows.Forms.ListView()
        Me.btnOeffnenM = New System.Windows.Forms.Button()
        Me.btnNeueErstellen = New System.Windows.Forms.Button()
        Me.colWeiterbildungIdM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colWeiterbildungM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colThemaM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.grpboxThemen.Location = New System.Drawing.Point(16, 13)
        Me.grpboxThemen.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpboxThemen.Name = "grpboxThemen"
        Me.grpboxThemen.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpboxThemen.Size = New System.Drawing.Size(435, 1078)
        Me.grpboxThemen.TabIndex = 1
        Me.grpboxThemen.TabStop = False
        Me.grpboxThemen.Text = "Themen"
        '
        'grpboxWeiterbildung
        '
        Me.grpboxWeiterbildung.Controls.Add(Me.btnNeueErstellen)
        Me.grpboxWeiterbildung.Controls.Add(Me.btnOeffnenM)
        Me.grpboxWeiterbildung.Controls.Add(Me.lstviewWeiterbildungenM)
        Me.grpboxWeiterbildung.Controls.Add(Me.lblSucheM)
        Me.grpboxWeiterbildung.Controls.Add(Me.txtboxSucheM)
        Me.grpboxWeiterbildung.Location = New System.Drawing.Point(459, 13)
        Me.grpboxWeiterbildung.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpboxWeiterbildung.Name = "grpboxWeiterbildung"
        Me.grpboxWeiterbildung.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpboxWeiterbildung.Size = New System.Drawing.Size(1203, 1077)
        Me.grpboxWeiterbildung.TabIndex = 2
        Me.grpboxWeiterbildung.TabStop = False
        Me.grpboxWeiterbildung.Text = "Weiterbildungsangebot"
        '
        'btnBeenden
        '
        Me.btnBeenden.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBeenden.Location = New System.Drawing.Point(1480, 1145)
        Me.btnBeenden.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBeenden.Name = "btnBeenden"
        Me.btnBeenden.Size = New System.Drawing.Size(180, 48)
        Me.btnBeenden.TabIndex = 3
        Me.btnBeenden.Text = "Beenden"
        Me.btnBeenden.UseVisualStyleBackColor = True
        '
        'btnWeiterbildungenM
        '
        Me.btnWeiterbildungenM.Location = New System.Drawing.Point(109, 161)
        Me.btnWeiterbildungenM.Name = "btnWeiterbildungenM"
        Me.btnWeiterbildungenM.Size = New System.Drawing.Size(191, 56)
        Me.btnWeiterbildungenM.TabIndex = 0
        Me.btnWeiterbildungenM.Text = "Weiterbildungen"
        Me.btnWeiterbildungenM.UseVisualStyleBackColor = True
        '
        'btnBuchungenM
        '
        Me.btnBuchungenM.Location = New System.Drawing.Point(109, 325)
        Me.btnBuchungenM.Name = "btnBuchungenM"
        Me.btnBuchungenM.Size = New System.Drawing.Size(191, 56)
        Me.btnBuchungenM.TabIndex = 1
        Me.btnBuchungenM.Text = "Buchungen"
        Me.btnBuchungenM.UseVisualStyleBackColor = True
        '
        'btnKundenkonto
        '
        Me.btnKundenkonto.Location = New System.Drawing.Point(109, 502)
        Me.btnKundenkonto.Name = "btnKundenkonto"
        Me.btnKundenkonto.Size = New System.Drawing.Size(191, 56)
        Me.btnKundenkonto.TabIndex = 2
        Me.btnKundenkonto.Text = "Kundenkonto"
        Me.btnKundenkonto.UseVisualStyleBackColor = True
        '
        'btnMeinKonto
        '
        Me.btnMeinKonto.Location = New System.Drawing.Point(109, 705)
        Me.btnMeinKonto.Name = "btnMeinKonto"
        Me.btnMeinKonto.Size = New System.Drawing.Size(191, 56)
        Me.btnMeinKonto.TabIndex = 3
        Me.btnMeinKonto.Text = "Mein Konto"
        Me.btnMeinKonto.UseVisualStyleBackColor = True
        '
        'btnHilfeM
        '
        Me.btnHilfeM.Location = New System.Drawing.Point(109, 887)
        Me.btnHilfeM.Name = "btnHilfeM"
        Me.btnHilfeM.Size = New System.Drawing.Size(191, 56)
        Me.btnHilfeM.TabIndex = 4
        Me.btnHilfeM.Text = "Hilfe"
        Me.btnHilfeM.UseVisualStyleBackColor = True
        '
        'txtboxSucheM
        '
        Me.txtboxSucheM.Location = New System.Drawing.Point(801, 31)
        Me.txtboxSucheM.Multiline = True
        Me.txtboxSucheM.Name = "txtboxSucheM"
        Me.txtboxSucheM.Size = New System.Drawing.Size(395, 37)
        Me.txtboxSucheM.TabIndex = 0
        '
        'lblSucheM
        '
        Me.lblSucheM.AutoSize = True
        Me.lblSucheM.Location = New System.Drawing.Point(710, 34)
        Me.lblSucheM.Name = "lblSucheM"
        Me.lblSucheM.Size = New System.Drawing.Size(73, 25)
        Me.lblSucheM.TabIndex = 1
        Me.lblSucheM.Text = "Suche"
        '
        'lstviewWeiterbildungenM
        '
        Me.lstviewWeiterbildungenM.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstviewWeiterbildungenM.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colWeiterbildungIdM, Me.colWeiterbildungM, Me.colThemaM})
        Me.lstviewWeiterbildungenM.FullRowSelect = True
        Me.lstviewWeiterbildungenM.GridLines = True
        Me.lstviewWeiterbildungenM.HideSelection = False
        Me.lstviewWeiterbildungenM.HoverSelection = True
        Me.lstviewWeiterbildungenM.Location = New System.Drawing.Point(10, 101)
        Me.lstviewWeiterbildungenM.MultiSelect = False
        Me.lstviewWeiterbildungenM.Name = "lstviewWeiterbildungenM"
        Me.lstviewWeiterbildungenM.Size = New System.Drawing.Size(1185, 870)
        Me.lstviewWeiterbildungenM.TabIndex = 2
        Me.lstviewWeiterbildungenM.UseCompatibleStateImageBehavior = False
        Me.lstviewWeiterbildungenM.View = System.Windows.Forms.View.Details
        '
        'btnOeffnenM
        '
        Me.btnOeffnenM.Location = New System.Drawing.Point(1004, 988)
        Me.btnOeffnenM.Name = "btnOeffnenM"
        Me.btnOeffnenM.Size = New System.Drawing.Size(191, 56)
        Me.btnOeffnenM.TabIndex = 3
        Me.btnOeffnenM.Text = "Öffnen"
        Me.btnOeffnenM.UseVisualStyleBackColor = True
        '
        'btnNeueErstellen
        '
        Me.btnNeueErstellen.Location = New System.Drawing.Point(781, 988)
        Me.btnNeueErstellen.Name = "btnNeueErstellen"
        Me.btnNeueErstellen.Size = New System.Drawing.Size(191, 56)
        Me.btnNeueErstellen.TabIndex = 4
        Me.btnNeueErstellen.Text = "Neue Erstellen"
        Me.btnNeueErstellen.UseVisualStyleBackColor = True
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
        Me.colWeiterbildungM.Width = 608
        '
        'colThemaM
        '
        Me.colThemaM.Text = "Thema"
        Me.colThemaM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colThemaM.Width = 346
        '
        'frmHauptfensterMitarbeiter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBeenden
        Me.ClientSize = New System.Drawing.Size(1677, 1209)
        Me.Controls.Add(Me.btnBeenden)
        Me.Controls.Add(Me.grpboxWeiterbildung)
        Me.Controls.Add(Me.grpboxThemen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
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
    Friend WithEvents btnBeenden As Button
    Friend WithEvents btnHilfeM As Button
    Friend WithEvents btnMeinKonto As Button
    Friend WithEvents btnKundenkonto As Button
    Friend WithEvents btnBuchungenM As Button
    Friend WithEvents btnWeiterbildungenM As Button
    Friend WithEvents txtboxSucheM As TextBox
    Friend WithEvents lblSucheM As Label
    Friend WithEvents lstviewWeiterbildungenM As ListView
    Friend WithEvents btnNeueErstellen As Button
    Friend WithEvents btnOeffnenM As Button
    Friend WithEvents colWeiterbildungIdM As ColumnHeader
    Friend WithEvents colWeiterbildungM As ColumnHeader
    Friend WithEvents colThemaM As ColumnHeader
End Class
