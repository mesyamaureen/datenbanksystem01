<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlleMitarbeiter
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnBeenden = New System.Windows.Forms.Button()
        Me.btnNeu = New System.Windows.Forms.Button()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.btnLoeschen = New System.Windows.Forms.Button()
        Me.lblBenutzerAlle = New System.Windows.Forms.Label()
        Me.Index = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Benutzername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Vorname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Index, Me.Benutzername, Me.Name, Me.Vorname})
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(163, 93)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(696, 298)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnBeenden
        '
        Me.btnBeenden.Location = New System.Drawing.Point(727, 477)
        Me.btnBeenden.Name = "btnBeenden"
        Me.btnBeenden.Size = New System.Drawing.Size(132, 39)
        Me.btnBeenden.TabIndex = 1
        Me.btnBeenden.Text = "Beenden"
        Me.btnBeenden.UseVisualStyleBackColor = True
        '
        'btnNeu
        '
        Me.btnNeu.Location = New System.Drawing.Point(727, 418)
        Me.btnNeu.Name = "btnNeu"
        Me.btnNeu.Size = New System.Drawing.Size(132, 39)
        Me.btnNeu.TabIndex = 2
        Me.btnNeu.Text = "Neu..."
        Me.btnNeu.UseVisualStyleBackColor = True
        '
        'btnDetails
        '
        Me.btnDetails.Location = New System.Drawing.Point(554, 418)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(123, 39)
        Me.btnDetails.TabIndex = 3
        Me.btnDetails.Text = "Details"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'btnLoeschen
        '
        Me.btnLoeschen.Location = New System.Drawing.Point(366, 418)
        Me.btnLoeschen.Name = "btnLoeschen"
        Me.btnLoeschen.Size = New System.Drawing.Size(132, 39)
        Me.btnLoeschen.TabIndex = 4
        Me.btnLoeschen.Text = "Löschen"
        Me.btnLoeschen.UseVisualStyleBackColor = True
        '
        'lblBenutzerAlle
        '
        Me.lblBenutzerAlle.AutoSize = True
        Me.lblBenutzerAlle.Location = New System.Drawing.Point(166, 75)
        Me.lblBenutzerAlle.Name = "lblBenutzerAlle"
        Me.lblBenutzerAlle.Size = New System.Drawing.Size(318, 17)
        Me.lblBenutzerAlle.TabIndex = 5
        Me.lblBenutzerAlle.Text = "Alle Mitarbeiter und Kunden der Time2-Akademie"
        '
        'Index
        '
        Me.Index.Text = "Index"
        '
        'Benutzername
        '
        Me.Benutzername.Text = "Benutzername"
        '
        'Name
        '
        Me.Name.Text = "Name"
        '
        'Vorname
        '
        Me.Vorname.Text = "Vorname"
        '
        'frmAlleMitarbeiter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 525)
        Me.Controls.Add(Me.lblBenutzerAlle)
        Me.Controls.Add(Me.btnLoeschen)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.btnNeu)
        Me.Controls.Add(Me.btnBeenden)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "frmAlleMitarbeiter"
        Me.Text = "Alle Mitarbeiter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnBeenden As Button
    Friend WithEvents btnNeu As Button
    Friend WithEvents btnDetails As Button
    Friend WithEvents btnLoeschen As Button
    Friend WithEvents lblBenutzerAlle As Label
    Friend WithEvents Index As ColumnHeader
    Friend WithEvents Benutzername As ColumnHeader
    Friend WithEvents Name As ColumnHeader
    Friend WithEvents Vorname As ColumnHeader
End Class
