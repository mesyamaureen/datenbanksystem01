﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnNeu = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblVorname
        '
        Me.lblVorname.AutoSize = True
        Me.lblVorname.Location = New System.Drawing.Point(57, 63)
        Me.lblVorname.Name = "lblVorname"
        Me.lblVorname.Size = New System.Drawing.Size(65, 17)
        Me.lblVorname.TabIndex = 0
        Me.lblVorname.Text = "Vorname"
        '
        'lblNachname
        '
        Me.lblNachname.AutoSize = True
        Me.lblNachname.Location = New System.Drawing.Point(57, 135)
        Me.lblNachname.Name = "lblNachname"
        Me.lblNachname.Size = New System.Drawing.Size(76, 17)
        Me.lblNachname.TabIndex = 1
        Me.lblNachname.Text = "Nachname"
        '
        'lblBenutzername
        '
        Me.lblBenutzername.AutoSize = True
        Me.lblBenutzername.Location = New System.Drawing.Point(57, 207)
        Me.lblBenutzername.Name = "lblBenutzername"
        Me.lblBenutzername.Size = New System.Drawing.Size(100, 17)
        Me.lblBenutzername.TabIndex = 2
        Me.lblBenutzername.Text = "Benutzername"
        '
        'lblPasswort
        '
        Me.lblPasswort.AutoSize = True
        Me.lblPasswort.Location = New System.Drawing.Point(57, 283)
        Me.lblPasswort.Name = "lblPasswort"
        Me.lblPasswort.Size = New System.Drawing.Size(65, 17)
        Me.lblPasswort.TabIndex = 3
        Me.lblPasswort.Text = "Passwort"
        '
        'lblPasswortWdrhln
        '
        Me.lblPasswortWdrhln.AutoSize = True
        Me.lblPasswortWdrhln.Location = New System.Drawing.Point(57, 357)
        Me.lblPasswortWdrhln.Name = "lblPasswortWdrhln"
        Me.lblPasswortWdrhln.Size = New System.Drawing.Size(145, 17)
        Me.lblPasswortWdrhln.TabIndex = 4
        Me.lblPasswortWdrhln.Text = "Passwort wiederholen"
        '
        'lblGebDat
        '
        Me.lblGebDat.AutoSize = True
        Me.lblGebDat.Location = New System.Drawing.Point(57, 418)
        Me.lblGebDat.Name = "lblGebDat"
        Me.lblGebDat.Size = New System.Drawing.Size(98, 17)
        Me.lblGebDat.TabIndex = 5
        Me.lblGebDat.Text = "Geburtsdatum"
        '
        'btnErstellen
        '
        Me.btnErstellen.Location = New System.Drawing.Point(876, 704)
        Me.btnErstellen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnErstellen.Name = "btnErstellen"
        Me.btnErstellen.Size = New System.Drawing.Size(92, 31)
        Me.btnErstellen.TabIndex = 7
        Me.btnErstellen.Text = "Erstellen"
        Me.btnErstellen.UseVisualStyleBackColor = True
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(988, 704)
        Me.btnAbbrechen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(92, 31)
        Me.btnAbbrechen.TabIndex = 8
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'lblFirma
        '
        Me.lblFirma.AutoSize = True
        Me.lblFirma.Location = New System.Drawing.Point(57, 482)
        Me.lblFirma.Name = "lblFirma"
        Me.lblFirma.Size = New System.Drawing.Size(43, 17)
        Me.lblFirma.TabIndex = 9
        Me.lblFirma.Text = "Firma"
        '
        'txtVorname
        '
        Me.txtVorname.Location = New System.Drawing.Point(231, 53)
        Me.txtVorname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtVorname.Multiline = True
        Me.txtVorname.Name = "txtVorname"
        Me.txtVorname.Size = New System.Drawing.Size(848, 40)
        Me.txtVorname.TabIndex = 10
        '
        'txtNachname
        '
        Me.txtNachname.Location = New System.Drawing.Point(231, 122)
        Me.txtNachname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNachname.Multiline = True
        Me.txtNachname.Name = "txtNachname"
        Me.txtNachname.Size = New System.Drawing.Size(848, 40)
        Me.txtNachname.TabIndex = 11
        '
        'txtBenutzername
        '
        Me.txtBenutzername.Location = New System.Drawing.Point(231, 198)
        Me.txtBenutzername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBenutzername.Multiline = True
        Me.txtBenutzername.Name = "txtBenutzername"
        Me.txtBenutzername.Size = New System.Drawing.Size(848, 40)
        Me.txtBenutzername.TabIndex = 12
        '
        'txtPasswort
        '
        Me.txtPasswort.Location = New System.Drawing.Point(231, 268)
        Me.txtPasswort.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPasswort.Multiline = True
        Me.txtPasswort.Name = "txtPasswort"
        Me.txtPasswort.Size = New System.Drawing.Size(848, 40)
        Me.txtPasswort.TabIndex = 13
        '
        'txtPasswortWdrhln
        '
        Me.txtPasswortWdrhln.Location = New System.Drawing.Point(231, 345)
        Me.txtPasswortWdrhln.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPasswortWdrhln.Multiline = True
        Me.txtPasswortWdrhln.Name = "txtPasswortWdrhln"
        Me.txtPasswortWdrhln.Size = New System.Drawing.Size(848, 40)
        Me.txtPasswortWdrhln.TabIndex = 14
        '
        'txtFirma
        '
        Me.txtFirma.Location = New System.Drawing.Point(231, 468)
        Me.txtFirma.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFirma.Multiline = True
        Me.txtFirma.Name = "txtFirma"
        Me.txtFirma.Size = New System.Drawing.Size(848, 40)
        Me.txtFirma.TabIndex = 16
        '
        'datboxGebDat
        '
        Me.datboxGebDat.Location = New System.Drawing.Point(231, 414)
        Me.datboxGebDat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datboxGebDat.Name = "datboxGebDat"
        Me.datboxGebDat.Size = New System.Drawing.Size(245, 22)
        Me.datboxGebDat.TabIndex = 17
        '
        'btnNeu
        '
        Me.btnNeu.Location = New System.Drawing.Point(940, 609)
        Me.btnNeu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNeu.Name = "btnNeu"
        Me.btnNeu.Size = New System.Drawing.Size(140, 41)
        Me.btnNeu.TabIndex = 18
        Me.btnNeu.Text = "Erstellen"
        Me.btnNeu.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(759, 610)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(140, 39)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Abbrechen"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmKundenkontoerstellung
        '
        Me.AcceptButton = Me.btnErstellen
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(1117, 681)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNeu)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents btnNeu As Button
    Friend WithEvents btnCancel As Button
End Class
