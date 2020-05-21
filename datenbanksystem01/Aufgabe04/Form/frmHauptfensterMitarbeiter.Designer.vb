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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStripWeiterbildungen = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripBuchungen = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripKonto = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHilfe = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpboxThemen = New System.Windows.Forms.GroupBox()
        Me.vsbThemen = New System.Windows.Forms.VScrollBar()
        Me.rbtnRechnundFinanz = New System.Windows.Forms.RadioButton()
        Me.rbtnProjProzChange = New System.Windows.Forms.RadioButton()
        Me.rbtnOrganisationsdesign = New System.Windows.Forms.RadioButton()
        Me.rbtnMarketingundProdman = New System.Windows.Forms.RadioButton()
        Me.rbtnGrundInnov = New System.Windows.Forms.RadioButton()
        Me.rbtnGesundheit = New System.Windows.Forms.RadioButton()
        Me.rbtnGenManagement = New System.Windows.Forms.RadioButton()
        Me.rbtnDigBusiness = New System.Windows.Forms.RadioButton()
        Me.rbtnControlling = New System.Windows.Forms.RadioButton()
        Me.rbtnBetriebswirtschaft = New System.Windows.Forms.RadioButton()
        Me.rbtnAlle = New System.Windows.Forms.RadioButton()
        Me.grpboxWeiterbildung = New System.Windows.Forms.GroupBox()
        Me.lblScrum = New System.Windows.Forms.Label()
        Me.lblProjektman = New System.Windows.Forms.Label()
        Me.lblAgiles = New System.Windows.Forms.Label()
        Me.btnBearbeitenScrum = New System.Windows.Forms.Button()
        Me.btnBearbeitenProjektman = New System.Windows.Forms.Button()
        Me.btnBearbeitenAgiles = New System.Windows.Forms.Button()
        Me.vsbWeiterbildung = New System.Windows.Forms.VScrollBar()
        Me.picboxScrum = New System.Windows.Forms.PictureBox()
        Me.picboxProjektmanagement = New System.Windows.Forms.PictureBox()
        Me.picboxAgiles = New System.Windows.Forms.PictureBox()
        Me.btnBeenden = New System.Windows.Forms.Button()
        Me.btnNeueWeiterbildung = New System.Windows.Forms.Button()
        Me.btnNeuesThema = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.grpboxThemen.SuspendLayout()
        Me.grpboxWeiterbildung.SuspendLayout()
        CType(Me.picboxScrum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxProjektmanagement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxAgiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripWeiterbildungen, Me.MenuStripBuchungen, Me.MenuStripKonto, Me.MenuStripHilfe})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1118, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStripWeiterbildungen
        '
        Me.MenuStripWeiterbildungen.Name = "MenuStripWeiterbildungen"
        Me.MenuStripWeiterbildungen.Size = New System.Drawing.Size(131, 24)
        Me.MenuStripWeiterbildungen.Text = "Weiterbildungen"
        '
        'MenuStripBuchungen
        '
        Me.MenuStripBuchungen.Name = "MenuStripBuchungen"
        Me.MenuStripBuchungen.Size = New System.Drawing.Size(94, 24)
        Me.MenuStripBuchungen.Text = "Buchungen"
        '
        'MenuStripKonto
        '
        Me.MenuStripKonto.Name = "MenuStripKonto"
        Me.MenuStripKonto.Size = New System.Drawing.Size(61, 24)
        Me.MenuStripKonto.Text = "Konto"
        '
        'MenuStripHilfe
        '
        Me.MenuStripHilfe.Name = "MenuStripHilfe"
        Me.MenuStripHilfe.Size = New System.Drawing.Size(53, 24)
        Me.MenuStripHilfe.Text = "Hilfe"
        '
        'grpboxThemen
        '
        Me.grpboxThemen.Controls.Add(Me.vsbThemen)
        Me.grpboxThemen.Controls.Add(Me.rbtnRechnundFinanz)
        Me.grpboxThemen.Controls.Add(Me.rbtnProjProzChange)
        Me.grpboxThemen.Controls.Add(Me.rbtnOrganisationsdesign)
        Me.grpboxThemen.Controls.Add(Me.rbtnMarketingundProdman)
        Me.grpboxThemen.Controls.Add(Me.rbtnGrundInnov)
        Me.grpboxThemen.Controls.Add(Me.rbtnGesundheit)
        Me.grpboxThemen.Controls.Add(Me.rbtnGenManagement)
        Me.grpboxThemen.Controls.Add(Me.rbtnDigBusiness)
        Me.grpboxThemen.Controls.Add(Me.rbtnControlling)
        Me.grpboxThemen.Controls.Add(Me.rbtnBetriebswirtschaft)
        Me.grpboxThemen.Controls.Add(Me.rbtnAlle)
        Me.grpboxThemen.Location = New System.Drawing.Point(11, 29)
        Me.grpboxThemen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxThemen.Name = "grpboxThemen"
        Me.grpboxThemen.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxThemen.Size = New System.Drawing.Size(290, 669)
        Me.grpboxThemen.TabIndex = 1
        Me.grpboxThemen.TabStop = False
        Me.grpboxThemen.Text = "Themen"
        '
        'vsbThemen
        '
        Me.vsbThemen.Location = New System.Drawing.Point(260, 7)
        Me.vsbThemen.Name = "vsbThemen"
        Me.vsbThemen.Size = New System.Drawing.Size(30, 662)
        Me.vsbThemen.TabIndex = 11
        '
        'rbtnRechnundFinanz
        '
        Me.rbtnRechnundFinanz.AutoSize = True
        Me.rbtnRechnundFinanz.Location = New System.Drawing.Point(5, 459)
        Me.rbtnRechnundFinanz.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnRechnundFinanz.Name = "rbtnRechnundFinanz"
        Me.rbtnRechnundFinanz.Size = New System.Drawing.Size(231, 21)
        Me.rbtnRechnundFinanz.TabIndex = 10
        Me.rbtnRechnundFinanz.TabStop = True
        Me.rbtnRechnundFinanz.Text = "Rechnungswesen und Finanzen"
        Me.rbtnRechnundFinanz.UseVisualStyleBackColor = True
        '
        'rbtnProjProzChange
        '
        Me.rbtnProjProzChange.Location = New System.Drawing.Point(5, 402)
        Me.rbtnProjProzChange.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnProjProzChange.Name = "rbtnProjProzChange"
        Me.rbtnProjProzChange.Size = New System.Drawing.Size(256, 41)
        Me.rbtnProjProzChange.TabIndex = 9
        Me.rbtnProjProzChange.TabStop = True
        Me.rbtnProjProzChange.Text = "Projekt-, Prozess- und Changemanagement"
        Me.rbtnProjProzChange.UseVisualStyleBackColor = True
        '
        'rbtnOrganisationsdesign
        '
        Me.rbtnOrganisationsdesign.AutoSize = True
        Me.rbtnOrganisationsdesign.Location = New System.Drawing.Point(5, 366)
        Me.rbtnOrganisationsdesign.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnOrganisationsdesign.Name = "rbtnOrganisationsdesign"
        Me.rbtnOrganisationsdesign.Size = New System.Drawing.Size(159, 21)
        Me.rbtnOrganisationsdesign.TabIndex = 8
        Me.rbtnOrganisationsdesign.TabStop = True
        Me.rbtnOrganisationsdesign.Text = "Organisationsdesign"
        Me.rbtnOrganisationsdesign.UseVisualStyleBackColor = True
        '
        'rbtnMarketingundProdman
        '
        Me.rbtnMarketingundProdman.AutoSize = True
        Me.rbtnMarketingundProdman.Location = New System.Drawing.Point(5, 322)
        Me.rbtnMarketingundProdman.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnMarketingundProdman.Name = "rbtnMarketingundProdman"
        Me.rbtnMarketingundProdman.Size = New System.Drawing.Size(254, 21)
        Me.rbtnMarketingundProdman.TabIndex = 7
        Me.rbtnMarketingundProdman.TabStop = True
        Me.rbtnMarketingundProdman.Text = "Marketing und Produktmanagement"
        Me.rbtnMarketingundProdman.UseVisualStyleBackColor = True
        '
        'rbtnGrundInnov
        '
        Me.rbtnGrundInnov.AutoSize = True
        Me.rbtnGrundInnov.Location = New System.Drawing.Point(5, 281)
        Me.rbtnGrundInnov.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnGrundInnov.Name = "rbtnGrundInnov"
        Me.rbtnGrundInnov.Size = New System.Drawing.Size(190, 21)
        Me.rbtnGrundInnov.TabIndex = 6
        Me.rbtnGrundInnov.TabStop = True
        Me.rbtnGrundInnov.Text = "Gründung und Innovation"
        Me.rbtnGrundInnov.UseVisualStyleBackColor = True
        '
        'rbtnGesundheit
        '
        Me.rbtnGesundheit.AutoSize = True
        Me.rbtnGesundheit.Location = New System.Drawing.Point(5, 241)
        Me.rbtnGesundheit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnGesundheit.Name = "rbtnGesundheit"
        Me.rbtnGesundheit.Size = New System.Drawing.Size(102, 21)
        Me.rbtnGesundheit.TabIndex = 5
        Me.rbtnGesundheit.TabStop = True
        Me.rbtnGesundheit.Text = "Gesundheit"
        Me.rbtnGesundheit.UseVisualStyleBackColor = True
        '
        'rbtnGenManagement
        '
        Me.rbtnGenManagement.AutoSize = True
        Me.rbtnGenManagement.Location = New System.Drawing.Point(5, 202)
        Me.rbtnGenManagement.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnGenManagement.Name = "rbtnGenManagement"
        Me.rbtnGenManagement.Size = New System.Drawing.Size(166, 21)
        Me.rbtnGenManagement.TabIndex = 4
        Me.rbtnGenManagement.TabStop = True
        Me.rbtnGenManagement.Text = "General Management"
        Me.rbtnGenManagement.UseVisualStyleBackColor = True
        '
        'rbtnDigBusiness
        '
        Me.rbtnDigBusiness.AutoSize = True
        Me.rbtnDigBusiness.Location = New System.Drawing.Point(5, 160)
        Me.rbtnDigBusiness.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnDigBusiness.Name = "rbtnDigBusiness"
        Me.rbtnDigBusiness.Size = New System.Drawing.Size(129, 21)
        Me.rbtnDigBusiness.TabIndex = 3
        Me.rbtnDigBusiness.TabStop = True
        Me.rbtnDigBusiness.Text = "Digital Business"
        Me.rbtnDigBusiness.UseVisualStyleBackColor = True
        '
        'rbtnControlling
        '
        Me.rbtnControlling.AutoSize = True
        Me.rbtnControlling.Location = New System.Drawing.Point(5, 120)
        Me.rbtnControlling.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnControlling.Name = "rbtnControlling"
        Me.rbtnControlling.Size = New System.Drawing.Size(96, 21)
        Me.rbtnControlling.TabIndex = 2
        Me.rbtnControlling.TabStop = True
        Me.rbtnControlling.Text = "Controlling"
        Me.rbtnControlling.UseVisualStyleBackColor = True
        '
        'rbtnBetriebswirtschaft
        '
        Me.rbtnBetriebswirtschaft.AutoSize = True
        Me.rbtnBetriebswirtschaft.Location = New System.Drawing.Point(5, 78)
        Me.rbtnBetriebswirtschaft.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnBetriebswirtschaft.Name = "rbtnBetriebswirtschaft"
        Me.rbtnBetriebswirtschaft.Size = New System.Drawing.Size(140, 21)
        Me.rbtnBetriebswirtschaft.TabIndex = 1
        Me.rbtnBetriebswirtschaft.TabStop = True
        Me.rbtnBetriebswirtschaft.Text = "Betriebswirtschaft"
        Me.rbtnBetriebswirtschaft.UseVisualStyleBackColor = True
        '
        'rbtnAlle
        '
        Me.rbtnAlle.AutoSize = True
        Me.rbtnAlle.Checked = True
        Me.rbtnAlle.Location = New System.Drawing.Point(5, 34)
        Me.rbtnAlle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnAlle.Name = "rbtnAlle"
        Me.rbtnAlle.Size = New System.Drawing.Size(52, 21)
        Me.rbtnAlle.TabIndex = 0
        Me.rbtnAlle.TabStop = True
        Me.rbtnAlle.Text = "Alle"
        Me.rbtnAlle.UseVisualStyleBackColor = True
        '
        'grpboxWeiterbildung
        '
        Me.grpboxWeiterbildung.Controls.Add(Me.Button3)
        Me.grpboxWeiterbildung.Controls.Add(Me.Button2)
        Me.grpboxWeiterbildung.Controls.Add(Me.Button1)
        Me.grpboxWeiterbildung.Controls.Add(Me.lblScrum)
        Me.grpboxWeiterbildung.Controls.Add(Me.lblProjektman)
        Me.grpboxWeiterbildung.Controls.Add(Me.lblAgiles)
        Me.grpboxWeiterbildung.Controls.Add(Me.btnBearbeitenScrum)
        Me.grpboxWeiterbildung.Controls.Add(Me.btnBearbeitenProjektman)
        Me.grpboxWeiterbildung.Controls.Add(Me.btnBearbeitenAgiles)
        Me.grpboxWeiterbildung.Controls.Add(Me.vsbWeiterbildung)
        Me.grpboxWeiterbildung.Controls.Add(Me.picboxScrum)
        Me.grpboxWeiterbildung.Controls.Add(Me.picboxProjektmanagement)
        Me.grpboxWeiterbildung.Controls.Add(Me.picboxAgiles)
        Me.grpboxWeiterbildung.Location = New System.Drawing.Point(306, 29)
        Me.grpboxWeiterbildung.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxWeiterbildung.Name = "grpboxWeiterbildung"
        Me.grpboxWeiterbildung.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxWeiterbildung.Size = New System.Drawing.Size(802, 669)
        Me.grpboxWeiterbildung.TabIndex = 2
        Me.grpboxWeiterbildung.TabStop = False
        Me.grpboxWeiterbildung.Text = "Weiterbildungsangebot"
        '
        'lblScrum
        '
        Me.lblScrum.AutoSize = True
        Me.lblScrum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblScrum.Location = New System.Drawing.Point(220, 501)
        Me.lblScrum.Name = "lblScrum"
        Me.lblScrum.Size = New System.Drawing.Size(192, 25)
        Me.lblScrum.TabIndex = 12
        Me.lblScrum.Text = "SCRUM - Workshop"
        '
        'lblProjektman
        '
        Me.lblProjektman.AutoSize = True
        Me.lblProjektman.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblProjektman.Location = New System.Drawing.Point(220, 277)
        Me.lblProjektman.Name = "lblProjektman"
        Me.lblProjektman.Size = New System.Drawing.Size(186, 25)
        Me.lblProjektman.TabIndex = 11
        Me.lblProjektman.Text = "Projektmanagement"
        '
        'lblAgiles
        '
        Me.lblAgiles.AutoSize = True
        Me.lblAgiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblAgiles.Location = New System.Drawing.Point(220, 78)
        Me.lblAgiles.Name = "lblAgiles"
        Me.lblAgiles.Size = New System.Drawing.Size(245, 25)
        Me.lblAgiles.TabIndex = 10
        Me.lblAgiles.Text = "Agiles Projektmanagement"
        '
        'btnBearbeitenScrum
        '
        Me.btnBearbeitenScrum.Location = New System.Drawing.Point(332, 543)
        Me.btnBearbeitenScrum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBearbeitenScrum.Name = "btnBearbeitenScrum"
        Me.btnBearbeitenScrum.Size = New System.Drawing.Size(91, 30)
        Me.btnBearbeitenScrum.TabIndex = 9
        Me.btnBearbeitenScrum.Text = "Bearbeiten"
        Me.btnBearbeitenScrum.UseVisualStyleBackColor = True
        '
        'btnBearbeitenProjektman
        '
        Me.btnBearbeitenProjektman.Location = New System.Drawing.Point(332, 322)
        Me.btnBearbeitenProjektman.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBearbeitenProjektman.Name = "btnBearbeitenProjektman"
        Me.btnBearbeitenProjektman.Size = New System.Drawing.Size(91, 30)
        Me.btnBearbeitenProjektman.TabIndex = 8
        Me.btnBearbeitenProjektman.Text = "Bearbeiten"
        Me.btnBearbeitenProjektman.UseVisualStyleBackColor = True
        '
        'btnBearbeitenAgiles
        '
        Me.btnBearbeitenAgiles.Location = New System.Drawing.Point(332, 115)
        Me.btnBearbeitenAgiles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBearbeitenAgiles.Name = "btnBearbeitenAgiles"
        Me.btnBearbeitenAgiles.Size = New System.Drawing.Size(91, 30)
        Me.btnBearbeitenAgiles.TabIndex = 7
        Me.btnBearbeitenAgiles.Text = "Bearbeiten"
        Me.btnBearbeitenAgiles.UseVisualStyleBackColor = True
        '
        'vsbWeiterbildung
        '
        Me.vsbWeiterbildung.Location = New System.Drawing.Point(772, 7)
        Me.vsbWeiterbildung.Name = "vsbWeiterbildung"
        Me.vsbWeiterbildung.Size = New System.Drawing.Size(30, 662)
        Me.vsbWeiterbildung.TabIndex = 3
        '
        'picboxScrum
        '
        Me.picboxScrum.Location = New System.Drawing.Point(13, 457)
        Me.picboxScrum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picboxScrum.Name = "picboxScrum"
        Me.picboxScrum.Size = New System.Drawing.Size(186, 169)
        Me.picboxScrum.TabIndex = 2
        Me.picboxScrum.TabStop = False
        '
        'picboxProjektmanagement
        '
        Me.picboxProjektmanagement.Location = New System.Drawing.Point(13, 241)
        Me.picboxProjektmanagement.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picboxProjektmanagement.Name = "picboxProjektmanagement"
        Me.picboxProjektmanagement.Size = New System.Drawing.Size(186, 169)
        Me.picboxProjektmanagement.TabIndex = 1
        Me.picboxProjektmanagement.TabStop = False
        '
        'picboxAgiles
        '
        Me.picboxAgiles.Location = New System.Drawing.Point(13, 34)
        Me.picboxAgiles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picboxAgiles.Name = "picboxAgiles"
        Me.picboxAgiles.Size = New System.Drawing.Size(186, 169)
        Me.picboxAgiles.TabIndex = 0
        Me.picboxAgiles.TabStop = False
        '
        'btnBeenden
        '
        Me.btnBeenden.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBeenden.Location = New System.Drawing.Point(987, 733)
        Me.btnBeenden.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBeenden.Name = "btnBeenden"
        Me.btnBeenden.Size = New System.Drawing.Size(120, 31)
        Me.btnBeenden.TabIndex = 3
        Me.btnBeenden.Text = "Beenden"
        Me.btnBeenden.UseVisualStyleBackColor = True
        '
        'btnNeueWeiterbildung
        '
        Me.btnNeueWeiterbildung.Location = New System.Drawing.Point(825, 733)
        Me.btnNeueWeiterbildung.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNeueWeiterbildung.Name = "btnNeueWeiterbildung"
        Me.btnNeueWeiterbildung.Size = New System.Drawing.Size(150, 30)
        Me.btnNeueWeiterbildung.TabIndex = 4
        Me.btnNeueWeiterbildung.Text = "Neue Weiterbildung"
        Me.btnNeueWeiterbildung.UseVisualStyleBackColor = True
        '
        'btnNeuesThema
        '
        Me.btnNeuesThema.Location = New System.Drawing.Point(638, 733)
        Me.btnNeuesThema.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNeuesThema.Name = "btnNeuesThema"
        Me.btnNeuesThema.Size = New System.Drawing.Size(165, 30)
        Me.btnNeuesThema.TabIndex = 5
        Me.btnNeuesThema.Text = "Themen bearbeiten"
        Me.btnNeuesThema.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(225, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 30)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Mehr"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(225, 322)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 30)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Mehr"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(225, 543)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 30)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Mehr"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmHauptfensterMitarbeiter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBeenden
        Me.ClientSize = New System.Drawing.Size(1118, 774)
        Me.Controls.Add(Me.btnNeuesThema)
        Me.Controls.Add(Me.btnNeueWeiterbildung)
        Me.Controls.Add(Me.btnBeenden)
        Me.Controls.Add(Me.grpboxWeiterbildung)
        Me.Controls.Add(Me.grpboxThemen)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmHauptfensterMitarbeiter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weiterbildung time2-Akademie"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpboxThemen.ResumeLayout(False)
        Me.grpboxThemen.PerformLayout()
        Me.grpboxWeiterbildung.ResumeLayout(False)
        Me.grpboxWeiterbildung.PerformLayout()
        CType(Me.picboxScrum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxProjektmanagement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxAgiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStripWeiterbildungen As ToolStripMenuItem
    Friend WithEvents MenuStripBuchungen As ToolStripMenuItem
    Friend WithEvents MenuStripKonto As ToolStripMenuItem
    Friend WithEvents MenuStripHilfe As ToolStripMenuItem
    Friend WithEvents grpboxThemen As GroupBox
    Friend WithEvents grpboxWeiterbildung As GroupBox
    Friend WithEvents vsbThemen As VScrollBar
    Friend WithEvents rbtnRechnundFinanz As RadioButton
    Friend WithEvents rbtnProjProzChange As RadioButton
    Friend WithEvents rbtnOrganisationsdesign As RadioButton
    Friend WithEvents rbtnMarketingundProdman As RadioButton
    Friend WithEvents rbtnGrundInnov As RadioButton
    Friend WithEvents rbtnGesundheit As RadioButton
    Friend WithEvents rbtnGenManagement As RadioButton
    Friend WithEvents rbtnDigBusiness As RadioButton
    Friend WithEvents rbtnControlling As RadioButton
    Friend WithEvents rbtnBetriebswirtschaft As RadioButton
    Friend WithEvents rbtnAlle As RadioButton
    Friend WithEvents lblScrum As Label
    Friend WithEvents lblProjektman As Label
    Friend WithEvents lblAgiles As Label
    Friend WithEvents btnBearbeitenScrum As Button
    Friend WithEvents btnBearbeitenProjektman As Button
    Friend WithEvents btnBearbeitenAgiles As Button
    Friend WithEvents vsbWeiterbildung As VScrollBar
    Friend WithEvents picboxScrum As PictureBox
    Friend WithEvents picboxProjektmanagement As PictureBox
    Friend WithEvents picboxAgiles As PictureBox
    Friend WithEvents btnBeenden As Button
    Friend WithEvents btnNeueWeiterbildung As Button
    Friend WithEvents btnNeuesThema As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
