<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBenutzerAlle
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
        Me.AlleBenutzer = New System.Windows.Forms.ListView()
        Me.lblIndex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtBenutzername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Vorname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblLstvAlleBenutzer = New System.Windows.Forms.Label()
        Me.btnHinzufuegen = New System.Windows.Forms.Button()
        Me.btnBeenden = New System.Windows.Forms.Button()
        Me.btnBearbeiten = New System.Windows.Forms.Button()
        Me.btnLoeschen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AlleBenutzer
        '
        Me.AlleBenutzer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lblIndex, Me.txtBenutzername, Me.Name, Me.Vorname})
        Me.AlleBenutzer.FullRowSelect = True
        Me.AlleBenutzer.GridLines = True
        Me.AlleBenutzer.HideSelection = False
        Me.AlleBenutzer.Location = New System.Drawing.Point(168, 58)
        Me.AlleBenutzer.Name = "AlleBenutzer"
        Me.AlleBenutzer.Size = New System.Drawing.Size(631, 304)
        Me.AlleBenutzer.TabIndex = 0
        Me.AlleBenutzer.UseCompatibleStateImageBehavior = False
        Me.AlleBenutzer.View = System.Windows.Forms.View.Details
        '
        'lblIndex
        '
        Me.lblIndex.Text = "Index"
        Me.lblIndex.Width = 64
        '
        'txtBenutzername
        '
        Me.txtBenutzername.Text = "Benutzername"
        Me.txtBenutzername.Width = 140
        '
        'Name
        '
        Me.Name.Text = "Name"
        Me.Name.Width = 161
        '
        'Vorname
        '
        Me.Vorname.Text = "Vorname"
        Me.Vorname.Width = 174
        '
        'lblLstvAlleBenutzer
        '
        Me.lblLstvAlleBenutzer.AutoSize = True
        Me.lblLstvAlleBenutzer.Location = New System.Drawing.Point(165, 38)
        Me.lblLstvAlleBenutzer.Name = "lblLstvAlleBenutzer"
        Me.lblLstvAlleBenutzer.Size = New System.Drawing.Size(318, 17)
        Me.lblLstvAlleBenutzer.TabIndex = 1
        Me.lblLstvAlleBenutzer.Text = "Alle Mitarbeiter und Kunden der Time2-Akademie"
        '
        'btnHinzufuegen
        '
        Me.btnHinzufuegen.Location = New System.Drawing.Point(667, 382)
        Me.btnHinzufuegen.Name = "btnHinzufuegen"
        Me.btnHinzufuegen.Size = New System.Drawing.Size(132, 39)
        Me.btnHinzufuegen.TabIndex = 2
        Me.btnHinzufuegen.Text = "Neu"
        Me.btnHinzufuegen.UseVisualStyleBackColor = True
        '
        'btnBeenden
        '
        Me.btnBeenden.Location = New System.Drawing.Point(666, 448)
        Me.btnBeenden.Name = "btnBeenden"
        Me.btnBeenden.Size = New System.Drawing.Size(132, 39)
        Me.btnBeenden.TabIndex = 3
        Me.btnBeenden.Text = "Beenden"
        Me.btnBeenden.UseVisualStyleBackColor = True
        '
        'btnBearbeiten
        '
        Me.btnBearbeiten.Location = New System.Drawing.Point(513, 383)
        Me.btnBearbeiten.Name = "btnBearbeiten"
        Me.btnBearbeiten.Size = New System.Drawing.Size(132, 39)
        Me.btnBearbeiten.TabIndex = 4
        Me.btnBearbeiten.Text = "Details"
        Me.btnBearbeiten.UseVisualStyleBackColor = True
        '
        'btnLoeschen
        '
        Me.btnLoeschen.Location = New System.Drawing.Point(351, 382)
        Me.btnLoeschen.Name = "btnLoeschen"
        Me.btnLoeschen.Size = New System.Drawing.Size(132, 39)
        Me.btnLoeschen.TabIndex = 5
        Me.btnLoeschen.Text = "Löschen"
        Me.btnLoeschen.UseVisualStyleBackColor = True
        '
        'frmBenutzerAlle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 510)
        Me.Controls.Add(Me.btnLoeschen)
        Me.Controls.Add(Me.btnBearbeiten)
        Me.Controls.Add(Me.btnBeenden)
        Me.Controls.Add(Me.btnHinzufuegen)
        Me.Controls.Add(Me.lblLstvAlleBenutzer)
        Me.Controls.Add(Me.AlleBenutzer)
        Me.Name.Text = "frmBenutzerAlle"
        Me.Text = "Alle Benutzer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AlleBenutzer As ListView
    Friend WithEvents lblLstvAlleBenutzer As Label
    Friend WithEvents lblIndex As ColumnHeader
    Friend WithEvents txtBenutzername As ColumnHeader
    Friend WithEvents Name As ColumnHeader
    Friend WithEvents Vorname As ColumnHeader
    Friend WithEvents btnHinzufuegen As Button
    Friend WithEvents btnBeenden As Button
    Friend WithEvents btnBearbeiten As Button
    Friend WithEvents btnLoeschen As Button
End Class
