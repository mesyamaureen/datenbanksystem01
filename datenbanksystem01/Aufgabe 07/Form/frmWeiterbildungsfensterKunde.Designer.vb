<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Weiterbildungsfenster_Kunde
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Weiterbildungsfenster_Kunde))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tabctrlWeiterb = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rtxtboxSeminarbeschreibung = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.rtxtboxTeilnkreis = New System.Windows.Forms.RichTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.rtxtboxSeminarinfo = New System.Windows.Forms.RichTextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lstviewKurse = New System.Windows.Forms.ListView()
        Me.colKursID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKursDatum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVerfuegbarkeit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKursPreis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblSeminartitelWeiterb = New System.Windows.Forms.Label()
        Me.txtboxSeminartitel = New System.Windows.Forms.TextBox()
        Me.btnKursBuchen = New System.Windows.Forms.Button()
        Me.tabctrlWeiterb.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1682, 1107)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 56)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Abbrechen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tabctrlWeiterb
        '
        Me.tabctrlWeiterb.Controls.Add(Me.TabPage1)
        Me.tabctrlWeiterb.Controls.Add(Me.TabPage2)
        Me.tabctrlWeiterb.Controls.Add(Me.TabPage3)
        Me.tabctrlWeiterb.Controls.Add(Me.TabPage4)
        Me.tabctrlWeiterb.Location = New System.Drawing.Point(12, 114)
        Me.tabctrlWeiterb.Name = "tabctrlWeiterb"
        Me.tabctrlWeiterb.SelectedIndex = 0
        Me.tabctrlWeiterb.Size = New System.Drawing.Size(1869, 971)
        Me.tabctrlWeiterb.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.rtxtboxSeminarbeschreibung)
        Me.TabPage1.Location = New System.Drawing.Point(8, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1853, 924)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Seminarbeschreibung"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'rtxtboxSeminarbeschreibung
        '
        Me.rtxtboxSeminarbeschreibung.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtboxSeminarbeschreibung.Location = New System.Drawing.Point(3, 3)
        Me.rtxtboxSeminarbeschreibung.Name = "rtxtboxSeminarbeschreibung"
        Me.rtxtboxSeminarbeschreibung.Size = New System.Drawing.Size(1847, 918)
        Me.rtxtboxSeminarbeschreibung.TabIndex = 0
        Me.rtxtboxSeminarbeschreibung.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.rtxtboxTeilnkreis)
        Me.TabPage2.Location = New System.Drawing.Point(8, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1853, 924)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Teilnehmerkreis"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'rtxtboxTeilnkreis
        '
        Me.rtxtboxTeilnkreis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtboxTeilnkreis.Location = New System.Drawing.Point(3, 3)
        Me.rtxtboxTeilnkreis.Name = "rtxtboxTeilnkreis"
        Me.rtxtboxTeilnkreis.Size = New System.Drawing.Size(1847, 918)
        Me.rtxtboxTeilnkreis.TabIndex = 0
        Me.rtxtboxTeilnkreis.Text = ""
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.rtxtboxSeminarinfo)
        Me.TabPage3.Location = New System.Drawing.Point(8, 39)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1853, 924)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Seminarinformationen"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'rtxtboxSeminarinfo
        '
        Me.rtxtboxSeminarinfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtboxSeminarinfo.Location = New System.Drawing.Point(3, 3)
        Me.rtxtboxSeminarinfo.Name = "rtxtboxSeminarinfo"
        Me.rtxtboxSeminarinfo.Size = New System.Drawing.Size(1847, 918)
        Me.rtxtboxSeminarinfo.TabIndex = 0
        Me.rtxtboxSeminarinfo.Text = ""
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lstviewKurse)
        Me.TabPage4.Location = New System.Drawing.Point(8, 39)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1853, 924)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Kurse"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lstviewKurse
        '
        Me.lstviewKurse.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstviewKurse.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colKursID, Me.colKursDatum, Me.colVerfuegbarkeit, Me.colKursPreis})
        Me.lstviewKurse.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstviewKurse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstviewKurse.FullRowSelect = True
        Me.lstviewKurse.GridLines = True
        Me.lstviewKurse.HideSelection = False
        Me.lstviewKurse.HoverSelection = True
        Me.lstviewKurse.Location = New System.Drawing.Point(3, 3)
        Me.lstviewKurse.Name = "lstviewKurse"
        Me.lstviewKurse.Size = New System.Drawing.Size(1847, 918)
        Me.lstviewKurse.TabIndex = 0
        Me.lstviewKurse.UseCompatibleStateImageBehavior = False
        Me.lstviewKurse.View = System.Windows.Forms.View.Details
        '
        'colKursID
        '
        Me.colKursID.Text = "Kurs ID"
        Me.colKursID.Width = 333
        '
        'colKursDatum
        '
        Me.colKursDatum.Text = "Datum"
        Me.colKursDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colKursDatum.Width = 786
        '
        'colVerfuegbarkeit
        '
        Me.colVerfuegbarkeit.Text = "Verfügbarkeit"
        Me.colVerfuegbarkeit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colVerfuegbarkeit.Width = 402
        '
        'colKursPreis
        '
        Me.colKursPreis.Text = "Preis"
        Me.colKursPreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colKursPreis.Width = 321
        '
        'lblSeminartitelWeiterb
        '
        Me.lblSeminartitelWeiterb.AutoSize = True
        Me.lblSeminartitelWeiterb.Location = New System.Drawing.Point(15, 35)
        Me.lblSeminartitelWeiterb.Name = "lblSeminartitelWeiterb"
        Me.lblSeminartitelWeiterb.Size = New System.Drawing.Size(125, 25)
        Me.lblSeminartitelWeiterb.TabIndex = 2
        Me.lblSeminartitelWeiterb.Text = "Seminartitel"
        '
        'txtboxSeminartitel
        '
        Me.txtboxSeminartitel.Enabled = False
        Me.txtboxSeminartitel.Location = New System.Drawing.Point(158, 22)
        Me.txtboxSeminartitel.Multiline = True
        Me.txtboxSeminartitel.Name = "txtboxSeminartitel"
        Me.txtboxSeminartitel.Size = New System.Drawing.Size(538, 48)
        Me.txtboxSeminartitel.TabIndex = 3
        '
        'btnKursBuchen
        '
        Me.btnKursBuchen.Location = New System.Drawing.Point(1471, 1107)
        Me.btnKursBuchen.Name = "btnKursBuchen"
        Me.btnKursBuchen.Size = New System.Drawing.Size(191, 56)
        Me.btnKursBuchen.TabIndex = 1
        Me.btnKursBuchen.Text = "Buchen"
        Me.btnKursBuchen.UseVisualStyleBackColor = True
        '
        'Weiterbildungsfenster_Kunde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1893, 1177)
        Me.Controls.Add(Me.btnKursBuchen)
        Me.Controls.Add(Me.txtboxSeminartitel)
        Me.Controls.Add(Me.lblSeminartitelWeiterb)
        Me.Controls.Add(Me.tabctrlWeiterb)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Weiterbildungsfenster_Kunde"
        Me.Text = "Weiterbildung time2-Akademie"
        Me.tabctrlWeiterb.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents tabctrlWeiterb As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents lblSeminartitelWeiterb As Label
    Friend WithEvents rtxtboxSeminarbeschreibung As RichTextBox
    Friend WithEvents rtxtboxTeilnkreis As RichTextBox
    Friend WithEvents rtxtboxSeminarinfo As RichTextBox
    Friend WithEvents lstviewKurse As ListView
    Friend WithEvents colKursID As ColumnHeader
    Friend WithEvents colKursDatum As ColumnHeader
    Friend WithEvents colVerfuegbarkeit As ColumnHeader
    Friend WithEvents colKursPreis As ColumnHeader
    Friend WithEvents txtboxSeminartitel As TextBox
    Friend WithEvents btnKursBuchen As Button
End Class
