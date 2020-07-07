<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgNeuerKurs
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
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.lblDatum = New System.Windows.Forms.Label()
        Me.lblOrt = New System.Windows.Forms.Label()
        Me.bolVerfuegbarkeit = New System.Windows.Forms.Label()
        Me.lblPreis = New System.Windows.Forms.Label()
        Me.txtDatum = New System.Windows.Forms.TextBox()
        Me.txtOrt = New System.Windows.Forms.TextBox()
        Me.txtVerfuegbarkeit = New System.Windows.Forms.TextBox()
        Me.txtPreis = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(633, 473)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(129, 44)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Location = New System.Drawing.Point(481, 473)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(141, 44)
        Me.btnSpeichern.TabIndex = 1
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'lblDatum
        '
        Me.lblDatum.AutoSize = True
        Me.lblDatum.Location = New System.Drawing.Point(29, 31)
        Me.lblDatum.Name = "lblDatum"
        Me.lblDatum.Size = New System.Drawing.Size(74, 25)
        Me.lblDatum.TabIndex = 2
        Me.lblDatum.Text = "Datum"
        '
        'lblOrt
        '
        Me.lblOrt.AutoSize = True
        Me.lblOrt.Location = New System.Drawing.Point(29, 93)
        Me.lblOrt.Name = "lblOrt"
        Me.lblOrt.Size = New System.Drawing.Size(41, 25)
        Me.lblOrt.TabIndex = 3
        Me.lblOrt.Text = "Ort"
        '
        'bolVerfuegbarkeit
        '
        Me.bolVerfuegbarkeit.AutoSize = True
        Me.bolVerfuegbarkeit.Location = New System.Drawing.Point(29, 157)
        Me.bolVerfuegbarkeit.Name = "bolVerfuegbarkeit"
        Me.bolVerfuegbarkeit.Size = New System.Drawing.Size(152, 25)
        Me.bolVerfuegbarkeit.TabIndex = 4
        Me.bolVerfuegbarkeit.Text = "Verfuegbarkeit"
        '
        'lblPreis
        '
        Me.lblPreis.AutoSize = True
        Me.lblPreis.Location = New System.Drawing.Point(29, 222)
        Me.lblPreis.Name = "lblPreis"
        Me.lblPreis.Size = New System.Drawing.Size(61, 25)
        Me.lblPreis.TabIndex = 5
        Me.lblPreis.Text = "Preis"
        '
        'txtDatum
        '
        Me.txtDatum.Location = New System.Drawing.Point(325, 44)
        Me.txtDatum.Name = "txtDatum"
        Me.txtDatum.Size = New System.Drawing.Size(100, 31)
        Me.txtDatum.TabIndex = 6
        '
        'txtOrt
        '
        Me.txtOrt.Location = New System.Drawing.Point(313, 110)
        Me.txtOrt.Name = "txtOrt"
        Me.txtOrt.Size = New System.Drawing.Size(100, 31)
        Me.txtOrt.TabIndex = 7
        '
        'txtVerfuegbarkeit
        '
        Me.txtVerfuegbarkeit.Location = New System.Drawing.Point(338, 185)
        Me.txtVerfuegbarkeit.Name = "txtVerfuegbarkeit"
        Me.txtVerfuegbarkeit.Size = New System.Drawing.Size(100, 31)
        Me.txtVerfuegbarkeit.TabIndex = 8
        '
        'txtPreis
        '
        Me.txtPreis.Location = New System.Drawing.Point(310, 250)
        Me.txtPreis.Name = "txtPreis"
        Me.txtPreis.Size = New System.Drawing.Size(154, 31)
        Me.txtPreis.TabIndex = 9
        '
        'dlgNeuerKurs
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(774, 529)
        Me.Controls.Add(Me.txtPreis)
        Me.Controls.Add(Me.txtVerfuegbarkeit)
        Me.Controls.Add(Me.txtOrt)
        Me.Controls.Add(Me.txtDatum)
        Me.Controls.Add(Me.lblPreis)
        Me.Controls.Add(Me.bolVerfuegbarkeit)
        Me.Controls.Add(Me.lblOrt)
        Me.Controls.Add(Me.lblDatum)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Name = "dlgNeuerKurs"
        Me.Text = "dlgNeuerKurs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents lblDatum As Label
    Friend WithEvents lblOrt As Label
    Friend WithEvents bolVerfuegbarkeit As Label
    Friend WithEvents lblPreis As Label
    Friend WithEvents txtDatum As TextBox
    Friend WithEvents txtOrt As TextBox
    Friend WithEvents txtVerfuegbarkeit As TextBox
    Friend WithEvents txtPreis As TextBox
End Class
