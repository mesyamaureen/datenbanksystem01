<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKundenkontoerstellung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKundenkontoerstellung))
        Me.lblVorname = New System.Windows.Forms.Label()
        Me.lblNachname = New System.Windows.Forms.Label()
        Me.lblBenutzername = New System.Windows.Forms.Label()
        Me.lblPasswort = New System.Windows.Forms.Label()
        Me.lblPasswortWdrhln = New System.Windows.Forms.Label()
        Me.lblGebDat = New System.Windows.Forms.Label()
        Me.btnErstellen = New System.Windows.Forms.Button()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.lblFirma = New System.Windows.Forms.Label()
        Me.txtVorname = New System.Windows.Forms.TextBox()
        Me.txtNachname = New System.Windows.Forms.TextBox()
        Me.txtBenutzername = New System.Windows.Forms.TextBox()
        Me.txtPasswort = New System.Windows.Forms.TextBox()
        Me.txtPasswortWdrhln = New System.Windows.Forms.TextBox()
        Me.txtFirma = New System.Windows.Forms.TextBox()
        Me.datboxGebDat = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lblVorname
        '
        Me.lblVorname.AutoSize = True
        Me.lblVorname.Location = New System.Drawing.Point(86, 98)
        Me.lblVorname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVorname.Name = "lblVorname"
        Me.lblVorname.Size = New System.Drawing.Size(98, 25)
        Me.lblVorname.TabIndex = 0
        Me.lblVorname.Text = "Vorname"
        '
        'lblNachname
        '
        Me.lblNachname.AutoSize = True
        Me.lblNachname.Location = New System.Drawing.Point(86, 211)
        Me.lblNachname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNachname.Name = "lblNachname"
        Me.lblNachname.Size = New System.Drawing.Size(115, 25)
        Me.lblNachname.TabIndex = 1
        Me.lblNachname.Text = "Nachname"
        '
        'lblBenutzername
        '
        Me.lblBenutzername.AutoSize = True
        Me.lblBenutzername.Location = New System.Drawing.Point(86, 323)
        Me.lblBenutzername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBenutzername.Name = "lblBenutzername"
        Me.lblBenutzername.Size = New System.Drawing.Size(151, 25)
        Me.lblBenutzername.TabIndex = 2
        Me.lblBenutzername.Text = "Benutzername"
        '
        'lblPasswort
        '
        Me.lblPasswort.AutoSize = True
        Me.lblPasswort.Location = New System.Drawing.Point(86, 442)
        Me.lblPasswort.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPasswort.Name = "lblPasswort"
        Me.lblPasswort.Size = New System.Drawing.Size(100, 25)
        Me.lblPasswort.TabIndex = 3
        Me.lblPasswort.Text = "Passwort"
        '
        'lblPasswortWdrhln
        '
        Me.lblPasswortWdrhln.AutoSize = True
        Me.lblPasswortWdrhln.Location = New System.Drawing.Point(86, 558)
        Me.lblPasswortWdrhln.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPasswortWdrhln.Name = "lblPasswortWdrhln"
        Me.lblPasswortWdrhln.Size = New System.Drawing.Size(222, 25)
        Me.lblPasswortWdrhln.TabIndex = 4
        Me.lblPasswortWdrhln.Text = "Passwort wiederholen"
        '
        'lblGebDat
        '
        Me.lblGebDat.AutoSize = True
        Me.lblGebDat.Location = New System.Drawing.Point(86, 653)
        Me.lblGebDat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGebDat.Name = "lblGebDat"
        Me.lblGebDat.Size = New System.Drawing.Size(147, 25)
        Me.lblGebDat.TabIndex = 5
        Me.lblGebDat.Text = "Geburtsdatum"
        '
        'btnErstellen
        '
        Me.btnErstellen.Location = New System.Drawing.Point(1314, 1100)
        Me.btnErstellen.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnErstellen.Name = "btnErstellen"
        Me.btnErstellen.Size = New System.Drawing.Size(138, 48)
        Me.btnErstellen.TabIndex = 7
        Me.btnErstellen.Text = "Erstellen"
        Me.btnErstellen.UseVisualStyleBackColor = True
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(1482, 1100)
        Me.btnAbbrechen.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(138, 48)
        Me.btnAbbrechen.TabIndex = 8
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'lblFirma
        '
        Me.lblFirma.AutoSize = True
        Me.lblFirma.Location = New System.Drawing.Point(86, 753)
        Me.lblFirma.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirma.Name = "lblFirma"
        Me.lblFirma.Size = New System.Drawing.Size(66, 25)
        Me.lblFirma.TabIndex = 9
        Me.lblFirma.Text = "Firma"
        '
        'txtVorname
        '
        Me.txtVorname.Location = New System.Drawing.Point(346, 83)
        Me.txtVorname.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtVorname.Multiline = True
        Me.txtVorname.Name = "txtVorname"
        Me.txtVorname.Size = New System.Drawing.Size(1270, 59)
        Me.txtVorname.TabIndex = 10
        '
        'txtNachname
        '
        Me.txtNachname.Location = New System.Drawing.Point(346, 191)
        Me.txtNachname.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNachname.Multiline = True
        Me.txtNachname.Name = "txtNachname"
        Me.txtNachname.Size = New System.Drawing.Size(1270, 59)
        Me.txtNachname.TabIndex = 11
        '
        'txtBenutzername
        '
        Me.txtBenutzername.Location = New System.Drawing.Point(346, 309)
        Me.txtBenutzername.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtBenutzername.Multiline = True
        Me.txtBenutzername.Name = "txtBenutzername"
        Me.txtBenutzername.Size = New System.Drawing.Size(1270, 59)
        Me.txtBenutzername.TabIndex = 12
        '
        'txtPasswort
        '
        Me.txtPasswort.Location = New System.Drawing.Point(346, 420)
        Me.txtPasswort.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPasswort.Multiline = True
        Me.txtPasswort.Name = "txtPasswort"
        Me.txtPasswort.Size = New System.Drawing.Size(1270, 59)
        Me.txtPasswort.TabIndex = 13
        '
        'txtPasswortWdrhln
        '
        Me.txtPasswortWdrhln.Location = New System.Drawing.Point(346, 539)
        Me.txtPasswortWdrhln.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPasswortWdrhln.Multiline = True
        Me.txtPasswortWdrhln.Name = "txtPasswortWdrhln"
        Me.txtPasswortWdrhln.Size = New System.Drawing.Size(1270, 59)
        Me.txtPasswortWdrhln.TabIndex = 14
        '
        'txtFirma
        '
        Me.txtFirma.Location = New System.Drawing.Point(346, 730)
        Me.txtFirma.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFirma.Multiline = True
        Me.txtFirma.Name = "txtFirma"
        Me.txtFirma.Size = New System.Drawing.Size(1270, 59)
        Me.txtFirma.TabIndex = 16
        '
        'datboxGebDat
        '
        Me.datboxGebDat.Location = New System.Drawing.Point(346, 647)
        Me.datboxGebDat.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.datboxGebDat.Name = "datboxGebDat"
        Me.datboxGebDat.Size = New System.Drawing.Size(366, 31)
        Me.datboxGebDat.TabIndex = 17
        '
        'frmKundenkontoerstellung
        '
        Me.AcceptButton = Me.btnErstellen
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(1677, 1209)
        Me.Controls.Add(Me.datboxGebDat)
        Me.Controls.Add(Me.txtFirma)
        Me.Controls.Add(Me.txtPasswortWdrhln)
        Me.Controls.Add(Me.txtPasswort)
        Me.Controls.Add(Me.txtBenutzername)
        Me.Controls.Add(Me.txtNachname)
        Me.Controls.Add(Me.txtVorname)
        Me.Controls.Add(Me.lblFirma)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.btnErstellen)
        Me.Controls.Add(Me.lblGebDat)
        Me.Controls.Add(Me.lblPasswortWdrhln)
        Me.Controls.Add(Me.lblPasswort)
        Me.Controls.Add(Me.lblBenutzername)
        Me.Controls.Add(Me.lblNachname)
        Me.Controls.Add(Me.lblVorname)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmKundenkontoerstellung"
        Me.Text = "Kundenkontoerstellung"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVorname As Label
    Friend WithEvents lblNachname As Label
    Friend WithEvents lblBenutzername As Label
    Friend WithEvents lblPasswort As Label
    Friend WithEvents lblPasswortWdrhln As Label
    Friend WithEvents lblGebDat As Label
    Friend WithEvents btnErstellen As Button
    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents lblFirma As Label
    Friend WithEvents txtVorname As TextBox
    Friend WithEvents txtNachname As TextBox
    Friend WithEvents txtBenutzername As TextBox
    Friend WithEvents txtPasswort As TextBox
    Friend WithEvents txtPasswortWdrhln As TextBox
    Friend WithEvents txtFirma As TextBox
    Friend WithEvents datboxGebDat As DateTimePicker
End Class
