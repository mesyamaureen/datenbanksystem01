<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNeueMitarbeiter
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
        Me.btnErstellen = New System.Windows.Forms.Button()
        Me.txtboxBenutzername = New System.Windows.Forms.TextBox()
        Me.txtboxPasswort = New System.Windows.Forms.TextBox()
        Me.txtboxPasswortW = New System.Windows.Forms.TextBox()
        Me.txtboxVorname = New System.Windows.Forms.TextBox()
        Me.txtboxName = New System.Windows.Forms.TextBox()
        Me.txtGebDat = New System.Windows.Forms.TextBox()
        Me.lblBenutzername = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPasswortW = New System.Windows.Forms.Label()
        Me.lblVorname = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblGebDat = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(1106, 672)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(136, 45)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnErstellen
        '
        Me.btnErstellen.Location = New System.Drawing.Point(946, 672)
        Me.btnErstellen.Name = "btnErstellen"
        Me.btnErstellen.Size = New System.Drawing.Size(136, 45)
        Me.btnErstellen.TabIndex = 1
        Me.btnErstellen.Text = "Erstellen"
        Me.btnErstellen.UseVisualStyleBackColor = True
        '
        'txtboxBenutzername
        '
        Me.txtboxBenutzername.Location = New System.Drawing.Point(242, 30)
        Me.txtboxBenutzername.Multiline = True
        Me.txtboxBenutzername.Name = "txtboxBenutzername"
        Me.txtboxBenutzername.Size = New System.Drawing.Size(1000, 51)
        Me.txtboxBenutzername.TabIndex = 2
        '
        'txtboxPasswort
        '
        Me.txtboxPasswort.Location = New System.Drawing.Point(242, 109)
        Me.txtboxPasswort.Multiline = True
        Me.txtboxPasswort.Name = "txtboxPasswort"
        Me.txtboxPasswort.Size = New System.Drawing.Size(1000, 51)
        Me.txtboxPasswort.TabIndex = 3
        '
        'txtboxPasswortW
        '
        Me.txtboxPasswortW.Location = New System.Drawing.Point(242, 194)
        Me.txtboxPasswortW.Multiline = True
        Me.txtboxPasswortW.Name = "txtboxPasswortW"
        Me.txtboxPasswortW.Size = New System.Drawing.Size(1000, 51)
        Me.txtboxPasswortW.TabIndex = 4
        '
        'txtboxVorname
        '
        Me.txtboxVorname.Location = New System.Drawing.Point(242, 277)
        Me.txtboxVorname.Multiline = True
        Me.txtboxVorname.Name = "txtboxVorname"
        Me.txtboxVorname.Size = New System.Drawing.Size(1000, 51)
        Me.txtboxVorname.TabIndex = 5
        '
        'txtboxName
        '
        Me.txtboxName.Location = New System.Drawing.Point(242, 362)
        Me.txtboxName.Multiline = True
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.Size = New System.Drawing.Size(1000, 51)
        Me.txtboxName.TabIndex = 6
        '
        'txtGebDat
        '
        Me.txtGebDat.Location = New System.Drawing.Point(242, 445)
        Me.txtGebDat.Multiline = True
        Me.txtGebDat.Name = "txtGebDat"
        Me.txtGebDat.Size = New System.Drawing.Size(1000, 51)
        Me.txtGebDat.TabIndex = 7
        '
        'lblBenutzername
        '
        Me.lblBenutzername.AutoSize = True
        Me.lblBenutzername.Location = New System.Drawing.Point(14, 44)
        Me.lblBenutzername.Name = "lblBenutzername"
        Me.lblBenutzername.Size = New System.Drawing.Size(151, 25)
        Me.lblBenutzername.TabIndex = 8
        Me.lblBenutzername.Text = "Benutzername"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Passwort"
        '
        'lblPasswortW
        '
        Me.lblPasswortW.AutoSize = True
        Me.lblPasswortW.Location = New System.Drawing.Point(14, 208)
        Me.lblPasswortW.Name = "lblPasswortW"
        Me.lblPasswortW.Size = New System.Drawing.Size(222, 25)
        Me.lblPasswortW.TabIndex = 10
        Me.lblPasswortW.Text = "Passwort wiederholen"
        '
        'lblVorname
        '
        Me.lblVorname.AutoSize = True
        Me.lblVorname.Location = New System.Drawing.Point(14, 292)
        Me.lblVorname.Name = "lblVorname"
        Me.lblVorname.Size = New System.Drawing.Size(98, 25)
        Me.lblVorname.TabIndex = 11
        Me.lblVorname.Text = "Vorname"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(14, 376)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 25)
        Me.lblName.TabIndex = 12
        Me.lblName.Text = "Name"
        '
        'lblGebDat
        '
        Me.lblGebDat.AutoSize = True
        Me.lblGebDat.Location = New System.Drawing.Point(14, 458)
        Me.lblGebDat.Name = "lblGebDat"
        Me.lblGebDat.Size = New System.Drawing.Size(147, 25)
        Me.lblGebDat.TabIndex = 13
        Me.lblGebDat.Text = "Geburtsdatum"
        '
        'frmNeueMitarbeiter
        '
        Me.AcceptButton = Me.btnErstellen
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(1254, 729)
        Me.Controls.Add(Me.lblGebDat)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblVorname)
        Me.Controls.Add(Me.lblPasswortW)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblBenutzername)
        Me.Controls.Add(Me.txtGebDat)
        Me.Controls.Add(Me.txtboxName)
        Me.Controls.Add(Me.txtboxVorname)
        Me.Controls.Add(Me.txtboxPasswortW)
        Me.Controls.Add(Me.txtboxPasswort)
        Me.Controls.Add(Me.txtboxBenutzername)
        Me.Controls.Add(Me.btnErstellen)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Name = "frmNeueMitarbeiter"
        Me.Text = "Neues Mitarbeiterkonto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnErstellen As Button
    Friend WithEvents txtboxBenutzername As TextBox
    Friend WithEvents txtboxPasswort As TextBox
    Friend WithEvents txtboxPasswortW As TextBox
    Friend WithEvents txtboxVorname As TextBox
    Friend WithEvents txtGebDat As TextBox
    Friend WithEvents lblBenutzername As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPasswortW As Label
    Friend WithEvents lblVorname As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblGebDat As Label
    Friend WithEvents txtboxName As TextBox
End Class
