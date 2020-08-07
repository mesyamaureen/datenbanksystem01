<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWeiterbildungsfensterMitarb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWeiterbildungsfensterMitarb))
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.txtboxSeminartitel = New System.Windows.Forms.TextBox()
        Me.lblSeminartitel = New System.Windows.Forms.Label()
        Me.tabcontrolWeiterbildungM = New System.Windows.Forms.TabControl()
        Me.tabSeminarbeschreibung = New System.Windows.Forms.TabPage()
        Me.rtxtboxSeminarbeschreibungM = New System.Windows.Forms.RichTextBox()
        Me.tabTeilnehmerkreis = New System.Windows.Forms.TabPage()
        Me.rtxtboxTeilnkreisM = New System.Windows.Forms.RichTextBox()
        Me.tabSeminarinfo = New System.Windows.Forms.TabPage()
        Me.rtxtboxSeminarinfoM = New System.Windows.Forms.RichTextBox()
        Me.tabKurse = New System.Windows.Forms.TabPage()
        Me.btnNeuerKurs = New System.Windows.Forms.Button()
        Me.btnLeerenKurs = New System.Windows.Forms.Button()
        Me.btnLoeschen = New System.Windows.Forms.Button()
        Me.lstviewKurseM = New System.Windows.Forms.ListView()
        Me.colKursIdM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKursDatumM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKursVerfuegbarkeitM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKursPreis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.tabcontrolWeiterbildungM.SuspendLayout()
        Me.tabSeminarbeschreibung.SuspendLayout()
        Me.tabTeilnehmerkreis.SuspendLayout()
        Me.tabSeminarinfo.SuspendLayout()
        Me.tabKurse.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(525, 343)
        Me.btnAbbrechen.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(96, 29)
        Me.btnAbbrechen.TabIndex = 11
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'txtboxSeminartitel
        '
        Me.txtboxSeminartitel.Location = New System.Drawing.Point(79, 11)
        Me.txtboxSeminartitel.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxSeminartitel.Multiline = True
        Me.txtboxSeminartitel.Name = "txtboxSeminartitel"
        Me.txtboxSeminartitel.Size = New System.Drawing.Size(271, 27)
        Me.txtboxSeminartitel.TabIndex = 12
        '
        'lblSeminartitel
        '
        Me.lblSeminartitel.AutoSize = True
        Me.lblSeminartitel.Location = New System.Drawing.Point(8, 18)
        Me.lblSeminartitel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSeminartitel.Name = "lblSeminartitel"
        Me.lblSeminartitel.Size = New System.Drawing.Size(61, 13)
        Me.lblSeminartitel.TabIndex = 13
        Me.lblSeminartitel.Text = "Seminartitel"
        '
        'tabcontrolWeiterbildungM
        '
        Me.tabcontrolWeiterbildungM.Controls.Add(Me.tabSeminarbeschreibung)
        Me.tabcontrolWeiterbildungM.Controls.Add(Me.tabTeilnehmerkreis)
        Me.tabcontrolWeiterbildungM.Controls.Add(Me.tabSeminarinfo)
        Me.tabcontrolWeiterbildungM.Controls.Add(Me.tabKurse)
        Me.tabcontrolWeiterbildungM.Location = New System.Drawing.Point(6, 61)
        Me.tabcontrolWeiterbildungM.Margin = New System.Windows.Forms.Padding(2)
        Me.tabcontrolWeiterbildungM.Name = "tabcontrolWeiterbildungM"
        Me.tabcontrolWeiterbildungM.SelectedIndex = 0
        Me.tabcontrolWeiterbildungM.Size = New System.Drawing.Size(614, 275)
        Me.tabcontrolWeiterbildungM.TabIndex = 14
        '
        'tabSeminarbeschreibung
        '
        Me.tabSeminarbeschreibung.Controls.Add(Me.rtxtboxSeminarbeschreibungM)
        Me.tabSeminarbeschreibung.Location = New System.Drawing.Point(4, 22)
        Me.tabSeminarbeschreibung.Margin = New System.Windows.Forms.Padding(2)
        Me.tabSeminarbeschreibung.Name = "tabSeminarbeschreibung"
        Me.tabSeminarbeschreibung.Padding = New System.Windows.Forms.Padding(2)
        Me.tabSeminarbeschreibung.Size = New System.Drawing.Size(606, 249)
        Me.tabSeminarbeschreibung.TabIndex = 0
        Me.tabSeminarbeschreibung.Text = "Seminarbeschreibung"
        Me.tabSeminarbeschreibung.UseVisualStyleBackColor = True
        '
        'rtxtboxSeminarbeschreibungM
        '
        Me.rtxtboxSeminarbeschreibungM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtboxSeminarbeschreibungM.Location = New System.Drawing.Point(2, 2)
        Me.rtxtboxSeminarbeschreibungM.Margin = New System.Windows.Forms.Padding(2)
        Me.rtxtboxSeminarbeschreibungM.Name = "rtxtboxSeminarbeschreibungM"
        Me.rtxtboxSeminarbeschreibungM.Size = New System.Drawing.Size(602, 245)
        Me.rtxtboxSeminarbeschreibungM.TabIndex = 0
        Me.rtxtboxSeminarbeschreibungM.Text = ""
        '
        'tabTeilnehmerkreis
        '
        Me.tabTeilnehmerkreis.Controls.Add(Me.rtxtboxTeilnkreisM)
        Me.tabTeilnehmerkreis.Location = New System.Drawing.Point(4, 22)
        Me.tabTeilnehmerkreis.Margin = New System.Windows.Forms.Padding(2)
        Me.tabTeilnehmerkreis.Name = "tabTeilnehmerkreis"
        Me.tabTeilnehmerkreis.Padding = New System.Windows.Forms.Padding(2)
        Me.tabTeilnehmerkreis.Size = New System.Drawing.Size(606, 249)
        Me.tabTeilnehmerkreis.TabIndex = 1
        Me.tabTeilnehmerkreis.Text = "Teilnehmerkreis"
        Me.tabTeilnehmerkreis.UseVisualStyleBackColor = True
        '
        'rtxtboxTeilnkreisM
        '
        Me.rtxtboxTeilnkreisM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtboxTeilnkreisM.Location = New System.Drawing.Point(2, 2)
        Me.rtxtboxTeilnkreisM.Margin = New System.Windows.Forms.Padding(2)
        Me.rtxtboxTeilnkreisM.Name = "rtxtboxTeilnkreisM"
        Me.rtxtboxTeilnkreisM.Size = New System.Drawing.Size(602, 245)
        Me.rtxtboxTeilnkreisM.TabIndex = 0
        Me.rtxtboxTeilnkreisM.Text = ""
        '
        'tabSeminarinfo
        '
        Me.tabSeminarinfo.Controls.Add(Me.rtxtboxSeminarinfoM)
        Me.tabSeminarinfo.Location = New System.Drawing.Point(4, 22)
        Me.tabSeminarinfo.Margin = New System.Windows.Forms.Padding(2)
        Me.tabSeminarinfo.Name = "tabSeminarinfo"
        Me.tabSeminarinfo.Padding = New System.Windows.Forms.Padding(2)
        Me.tabSeminarinfo.Size = New System.Drawing.Size(606, 249)
        Me.tabSeminarinfo.TabIndex = 2
        Me.tabSeminarinfo.Text = "Seminarinformationen"
        Me.tabSeminarinfo.UseVisualStyleBackColor = True
        '
        'rtxtboxSeminarinfoM
        '
        Me.rtxtboxSeminarinfoM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtboxSeminarinfoM.Location = New System.Drawing.Point(2, 2)
        Me.rtxtboxSeminarinfoM.Margin = New System.Windows.Forms.Padding(2)
        Me.rtxtboxSeminarinfoM.Name = "rtxtboxSeminarinfoM"
        Me.rtxtboxSeminarinfoM.Size = New System.Drawing.Size(602, 245)
        Me.rtxtboxSeminarinfoM.TabIndex = 0
        Me.rtxtboxSeminarinfoM.Text = ""
        '
        'tabKurse
        '
        Me.tabKurse.Controls.Add(Me.btnNeuerKurs)
        Me.tabKurse.Controls.Add(Me.btnLeerenKurs)
        Me.tabKurse.Controls.Add(Me.btnLoeschen)
        Me.tabKurse.Controls.Add(Me.lstviewKurseM)
        Me.tabKurse.Location = New System.Drawing.Point(4, 22)
        Me.tabKurse.Margin = New System.Windows.Forms.Padding(2)
        Me.tabKurse.Name = "tabKurse"
        Me.tabKurse.Padding = New System.Windows.Forms.Padding(2)
        Me.tabKurse.Size = New System.Drawing.Size(606, 249)
        Me.tabKurse.TabIndex = 3
        Me.tabKurse.Text = "Kurse"
        Me.tabKurse.UseVisualStyleBackColor = True
        '
        'btnNeuerKurs
        '
        Me.btnNeuerKurs.Location = New System.Drawing.Point(308, 227)
        Me.btnNeuerKurs.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNeuerKurs.Name = "btnNeuerKurs"
        Me.btnNeuerKurs.Size = New System.Drawing.Size(90, 19)
        Me.btnNeuerKurs.TabIndex = 3
        Me.btnNeuerKurs.Text = "Neuer Kurs"
        Me.btnNeuerKurs.UseVisualStyleBackColor = True
        '
        'btnLeerenKurs
        '
        Me.btnLeerenKurs.Location = New System.Drawing.Point(412, 227)
        Me.btnLeerenKurs.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLeerenKurs.Name = "btnLeerenKurs"
        Me.btnLeerenKurs.Size = New System.Drawing.Size(90, 19)
        Me.btnLeerenKurs.TabIndex = 2
        Me.btnLeerenKurs.Text = "Leeren"
        Me.btnLeerenKurs.UseVisualStyleBackColor = True
        '
        'btnLoeschen
        '
        Me.btnLoeschen.Location = New System.Drawing.Point(515, 227)
        Me.btnLoeschen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoeschen.Name = "btnLoeschen"
        Me.btnLoeschen.Size = New System.Drawing.Size(90, 19)
        Me.btnLoeschen.TabIndex = 1
        Me.btnLoeschen.Text = "Löschen"
        Me.btnLoeschen.UseVisualStyleBackColor = True
        '
        'lstviewKurseM
        '
        Me.lstviewKurseM.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstviewKurseM.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colKursIdM, Me.colKursDatumM, Me.colKursVerfuegbarkeitM, Me.colKursPreis})
        Me.lstviewKurseM.FullRowSelect = True
        Me.lstviewKurseM.GridLines = True
        Me.lstviewKurseM.HideSelection = False
        Me.lstviewKurseM.HoverSelection = True
        Me.lstviewKurseM.Location = New System.Drawing.Point(0, 0)
        Me.lstviewKurseM.Margin = New System.Windows.Forms.Padding(2)
        Me.lstviewKurseM.MultiSelect = False
        Me.lstviewKurseM.Name = "lstviewKurseM"
        Me.lstviewKurseM.Size = New System.Drawing.Size(608, 219)
        Me.lstviewKurseM.TabIndex = 0
        Me.lstviewKurseM.UseCompatibleStateImageBehavior = False
        Me.lstviewKurseM.View = System.Windows.Forms.View.Details
        '
        'colKursIdM
        '
        Me.colKursIdM.Text = "Kurs ID"
        Me.colKursIdM.Width = 100
        '
        'colKursDatumM
        '
        Me.colKursDatumM.Text = "Datum"
        Me.colKursDatumM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colKursDatumM.Width = 200
        '
        'colKursVerfuegbarkeitM
        '
        Me.colKursVerfuegbarkeitM.Text = "Verfügbarkeit"
        Me.colKursVerfuegbarkeitM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colKursVerfuegbarkeitM.Width = 100
        '
        'colKursPreis
        '
        Me.colKursPreis.Text = "Preis"
        Me.colKursPreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colKursPreis.Width = 200
        '
        'btnSpeichern
        '
        Me.btnSpeichern.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSpeichern.Location = New System.Drawing.Point(422, 343)
        Me.btnSpeichern.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(96, 29)
        Me.btnSpeichern.TabIndex = 15
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'frmWeiterbildungsfensterMitarb
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(627, 379)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.tabcontrolWeiterbildungM)
        Me.Controls.Add(Me.lblSeminartitel)
        Me.Controls.Add(Me.txtboxSeminartitel)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmWeiterbildungsfensterMitarb"
        Me.Text = "Weiterbildung bearbeiten"
        Me.tabcontrolWeiterbildungM.ResumeLayout(False)
        Me.tabSeminarbeschreibung.ResumeLayout(False)
        Me.tabTeilnehmerkreis.ResumeLayout(False)
        Me.tabSeminarinfo.ResumeLayout(False)
        Me.tabKurse.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents txtboxSeminartitel As TextBox
    Friend WithEvents lblSeminartitel As Label
    Friend WithEvents tabcontrolWeiterbildungM As TabControl
    Friend WithEvents tabSeminarbeschreibung As TabPage
    Friend WithEvents tabTeilnehmerkreis As TabPage
    Friend WithEvents tabSeminarinfo As TabPage
    Friend WithEvents tabKurse As TabPage
    Friend WithEvents rtxtboxSeminarbeschreibungM As RichTextBox
    Friend WithEvents rtxtboxTeilnkreisM As RichTextBox
    Friend WithEvents rtxtboxSeminarinfoM As RichTextBox
    Friend WithEvents btnNeuerKurs As Button
    Friend WithEvents btnLeerenKurs As Button
    Friend WithEvents btnLoeschen As Button
    Friend WithEvents lstviewKurseM As ListView
    Friend WithEvents colKursIdM As ColumnHeader
    Friend WithEvents colKursDatumM As ColumnHeader
    Friend WithEvents colKursVerfuegbarkeitM As ColumnHeader
    Friend WithEvents colKursPreis As ColumnHeader
    Friend WithEvents btnSpeichern As Button
End Class
