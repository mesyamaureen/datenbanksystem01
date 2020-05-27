<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHauptfensterKunde
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStripWeiterbildungen = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripBuchungen = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripKonto = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHilfe = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpboxThemen = New System.Windows.Forms.GroupBox()
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
        Me.vsbThemen = New System.Windows.Forms.VScrollBar()
        Me.grpboxWeiterbildung = New System.Windows.Forms.GroupBox()
        Me.lblScrum = New System.Windows.Forms.Label()
        Me.lblProjektman = New System.Windows.Forms.Label()
        Me.lblAgiles = New System.Windows.Forms.Label()
        Me.btnMehrScrum = New System.Windows.Forms.Button()
        Me.btnMehrProjektman = New System.Windows.Forms.Button()
        Me.btnMehrAgiles = New System.Windows.Forms.Button()
        Me.picboxScrum = New System.Windows.Forms.PictureBox()
        Me.picboxProjektmanagement = New System.Windows.Forms.PictureBox()
        Me.picboxAgiles = New System.Windows.Forms.PictureBox()
        Me.vsbWeiterbildung = New System.Windows.Forms.VScrollBar()
        Me.btnWarenkorb = New System.Windows.Forms.Button()
        Me.btnBeenden = New System.Windows.Forms.Button()
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
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1677, 42)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStripWeiterbildungen
        '
        Me.MenuStripWeiterbildungen.Name = "MenuStripWeiterbildungen"
        Me.MenuStripWeiterbildungen.Size = New System.Drawing.Size(205, 38)
        Me.MenuStripWeiterbildungen.Text = "Weiterbildungen"
        '
        'MenuStripBuchungen
        '
        Me.MenuStripBuchungen.Name = "MenuStripBuchungen"
        Me.MenuStripBuchungen.Size = New System.Drawing.Size(149, 38)
        Me.MenuStripBuchungen.Text = "Buchungen"
        '
        'MenuStripKonto
        '
        Me.MenuStripKonto.Name = "MenuStripKonto"
        Me.MenuStripKonto.Size = New System.Drawing.Size(90, 38)
        Me.MenuStripKonto.Text = "Konto"
        '
        'MenuStripHilfe
        '
        Me.MenuStripHilfe.Name = "MenuStripHilfe"
        Me.MenuStripHilfe.Size = New System.Drawing.Size(77, 38)
        Me.MenuStripHilfe.Text = "Hilfe"
        '
        'grpboxThemen
        '
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
        Me.grpboxThemen.Controls.Add(Me.vsbThemen)
        Me.grpboxThemen.Location = New System.Drawing.Point(16, 45)
        Me.grpboxThemen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpboxThemen.Name = "grpboxThemen"
        Me.grpboxThemen.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpboxThemen.Size = New System.Drawing.Size(435, 1045)
        Me.grpboxThemen.TabIndex = 1
        Me.grpboxThemen.TabStop = False
        Me.grpboxThemen.Text = "Themen"
        '
        'rbtnRechnundFinanz
        '
        Me.rbtnRechnundFinanz.AutoSize = True
        Me.rbtnRechnundFinanz.Location = New System.Drawing.Point(8, 718)
        Me.rbtnRechnundFinanz.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnRechnundFinanz.Name = "rbtnRechnundFinanz"
        Me.rbtnRechnundFinanz.Size = New System.Drawing.Size(351, 29)
        Me.rbtnRechnundFinanz.TabIndex = 11
        Me.rbtnRechnundFinanz.Text = "Rechnungswesen und Finanzen"
        Me.rbtnRechnundFinanz.UseVisualStyleBackColor = True
        '
        'rbtnProjProzChange
        '
        Me.rbtnProjProzChange.Location = New System.Drawing.Point(8, 628)
        Me.rbtnProjProzChange.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnProjProzChange.Name = "rbtnProjProzChange"
        Me.rbtnProjProzChange.Size = New System.Drawing.Size(384, 64)
        Me.rbtnProjProzChange.TabIndex = 10
        Me.rbtnProjProzChange.Text = "Projekt-, Prozess- und Changemanagement"
        Me.rbtnProjProzChange.UseVisualStyleBackColor = True
        '
        'rbtnOrganisationsdesign
        '
        Me.rbtnOrganisationsdesign.AutoSize = True
        Me.rbtnOrganisationsdesign.Location = New System.Drawing.Point(8, 571)
        Me.rbtnOrganisationsdesign.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnOrganisationsdesign.Name = "rbtnOrganisationsdesign"
        Me.rbtnOrganisationsdesign.Size = New System.Drawing.Size(240, 29)
        Me.rbtnOrganisationsdesign.TabIndex = 9
        Me.rbtnOrganisationsdesign.Text = "Organisationsdesign"
        Me.rbtnOrganisationsdesign.UseVisualStyleBackColor = True
        '
        'rbtnMarketingundProdman
        '
        Me.rbtnMarketingundProdman.AutoSize = True
        Me.rbtnMarketingundProdman.Location = New System.Drawing.Point(8, 504)
        Me.rbtnMarketingundProdman.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnMarketingundProdman.Name = "rbtnMarketingundProdman"
        Me.rbtnMarketingundProdman.Size = New System.Drawing.Size(384, 29)
        Me.rbtnMarketingundProdman.TabIndex = 8
        Me.rbtnMarketingundProdman.Text = "Marketing und Produktmanagement"
        Me.rbtnMarketingundProdman.UseVisualStyleBackColor = True
        '
        'rbtnGrundInnov
        '
        Me.rbtnGrundInnov.AutoSize = True
        Me.rbtnGrundInnov.Location = New System.Drawing.Point(8, 439)
        Me.rbtnGrundInnov.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnGrundInnov.Name = "rbtnGrundInnov"
        Me.rbtnGrundInnov.Size = New System.Drawing.Size(285, 29)
        Me.rbtnGrundInnov.TabIndex = 7
        Me.rbtnGrundInnov.Text = "Gründung und Innovation"
        Me.rbtnGrundInnov.UseVisualStyleBackColor = True
        '
        'rbtnGesundheit
        '
        Me.rbtnGesundheit.AutoSize = True
        Me.rbtnGesundheit.Location = New System.Drawing.Point(8, 376)
        Me.rbtnGesundheit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnGesundheit.Name = "rbtnGesundheit"
        Me.rbtnGesundheit.Size = New System.Drawing.Size(153, 29)
        Me.rbtnGesundheit.TabIndex = 6
        Me.rbtnGesundheit.Text = "Gesundheit"
        Me.rbtnGesundheit.UseVisualStyleBackColor = True
        '
        'rbtnGenManagement
        '
        Me.rbtnGenManagement.AutoSize = True
        Me.rbtnGenManagement.Location = New System.Drawing.Point(8, 315)
        Me.rbtnGenManagement.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnGenManagement.Name = "rbtnGenManagement"
        Me.rbtnGenManagement.Size = New System.Drawing.Size(250, 29)
        Me.rbtnGenManagement.TabIndex = 5
        Me.rbtnGenManagement.Text = "General Management"
        Me.rbtnGenManagement.UseVisualStyleBackColor = True
        '
        'rbtnDigBusiness
        '
        Me.rbtnDigBusiness.AutoSize = True
        Me.rbtnDigBusiness.Location = New System.Drawing.Point(8, 250)
        Me.rbtnDigBusiness.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnDigBusiness.Name = "rbtnDigBusiness"
        Me.rbtnDigBusiness.Size = New System.Drawing.Size(197, 29)
        Me.rbtnDigBusiness.TabIndex = 4
        Me.rbtnDigBusiness.Text = "Digital Business"
        Me.rbtnDigBusiness.UseVisualStyleBackColor = True
        '
        'rbtnControlling
        '
        Me.rbtnControlling.AutoSize = True
        Me.rbtnControlling.Location = New System.Drawing.Point(8, 188)
        Me.rbtnControlling.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnControlling.Name = "rbtnControlling"
        Me.rbtnControlling.Size = New System.Drawing.Size(146, 29)
        Me.rbtnControlling.TabIndex = 3
        Me.rbtnControlling.Text = "Controlling"
        Me.rbtnControlling.UseVisualStyleBackColor = True
        '
        'rbtnBetriebswirtschaft
        '
        Me.rbtnBetriebswirtschaft.AutoSize = True
        Me.rbtnBetriebswirtschaft.Location = New System.Drawing.Point(8, 121)
        Me.rbtnBetriebswirtschaft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnBetriebswirtschaft.Name = "rbtnBetriebswirtschaft"
        Me.rbtnBetriebswirtschaft.Size = New System.Drawing.Size(213, 29)
        Me.rbtnBetriebswirtschaft.TabIndex = 2
        Me.rbtnBetriebswirtschaft.Text = "Betriebswirtschaft"
        Me.rbtnBetriebswirtschaft.UseVisualStyleBackColor = True
        '
        'rbtnAlle
        '
        Me.rbtnAlle.AutoSize = True
        Me.rbtnAlle.Checked = True
        Me.rbtnAlle.Location = New System.Drawing.Point(8, 54)
        Me.rbtnAlle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnAlle.Name = "rbtnAlle"
        Me.rbtnAlle.Size = New System.Drawing.Size(79, 29)
        Me.rbtnAlle.TabIndex = 1
        Me.rbtnAlle.TabStop = True
        Me.rbtnAlle.Text = "Alle"
        Me.rbtnAlle.UseVisualStyleBackColor = True
        '
        'vsbThemen
        '
        Me.vsbThemen.Location = New System.Drawing.Point(391, 11)
        Me.vsbThemen.Name = "vsbThemen"
        Me.vsbThemen.Size = New System.Drawing.Size(30, 1034)
        Me.vsbThemen.TabIndex = 0
        '
        'grpboxWeiterbildung
        '
        Me.grpboxWeiterbildung.Controls.Add(Me.lblScrum)
        Me.grpboxWeiterbildung.Controls.Add(Me.lblProjektman)
        Me.grpboxWeiterbildung.Controls.Add(Me.lblAgiles)
        Me.grpboxWeiterbildung.Controls.Add(Me.btnMehrScrum)
        Me.grpboxWeiterbildung.Controls.Add(Me.btnMehrProjektman)
        Me.grpboxWeiterbildung.Controls.Add(Me.btnMehrAgiles)
        Me.grpboxWeiterbildung.Controls.Add(Me.picboxScrum)
        Me.grpboxWeiterbildung.Controls.Add(Me.picboxProjektmanagement)
        Me.grpboxWeiterbildung.Controls.Add(Me.picboxAgiles)
        Me.grpboxWeiterbildung.Controls.Add(Me.vsbWeiterbildung)
        Me.grpboxWeiterbildung.Location = New System.Drawing.Point(459, 45)
        Me.grpboxWeiterbildung.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpboxWeiterbildung.Name = "grpboxWeiterbildung"
        Me.grpboxWeiterbildung.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpboxWeiterbildung.Size = New System.Drawing.Size(1203, 1045)
        Me.grpboxWeiterbildung.TabIndex = 2
        Me.grpboxWeiterbildung.TabStop = False
        Me.grpboxWeiterbildung.Text = "Weiterbildungsangebote"
        '
        'lblScrum
        '
        Me.lblScrum.AutoSize = True
        Me.lblScrum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblScrum.Location = New System.Drawing.Point(329, 782)
        Me.lblScrum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScrum.Name = "lblScrum"
        Me.lblScrum.Size = New System.Drawing.Size(306, 37)
        Me.lblScrum.TabIndex = 9
        Me.lblScrum.Text = "SCRUM - Workshop"
        '
        'lblProjektman
        '
        Me.lblProjektman.AutoSize = True
        Me.lblProjektman.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblProjektman.Location = New System.Drawing.Point(329, 432)
        Me.lblProjektman.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProjektman.Name = "lblProjektman"
        Me.lblProjektman.Size = New System.Drawing.Size(303, 37)
        Me.lblProjektman.TabIndex = 8
        Me.lblProjektman.Text = "Projektmanagement"
        '
        'lblAgiles
        '
        Me.lblAgiles.AutoSize = True
        Me.lblAgiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblAgiles.Location = New System.Drawing.Point(329, 121)
        Me.lblAgiles.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAgiles.Name = "lblAgiles"
        Me.lblAgiles.Size = New System.Drawing.Size(399, 37)
        Me.lblAgiles.TabIndex = 7
        Me.lblAgiles.Text = "Agiles Projektmanagement"
        '
        'btnMehrScrum
        '
        Me.btnMehrScrum.Location = New System.Drawing.Point(336, 865)
        Me.btnMehrScrum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMehrScrum.Name = "btnMehrScrum"
        Me.btnMehrScrum.Size = New System.Drawing.Size(136, 48)
        Me.btnMehrScrum.TabIndex = 6
        Me.btnMehrScrum.Text = "Mehr"
        Me.btnMehrScrum.UseVisualStyleBackColor = True
        '
        'btnMehrProjektman
        '
        Me.btnMehrProjektman.Location = New System.Drawing.Point(336, 528)
        Me.btnMehrProjektman.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMehrProjektman.Name = "btnMehrProjektman"
        Me.btnMehrProjektman.Size = New System.Drawing.Size(136, 48)
        Me.btnMehrProjektman.TabIndex = 5
        Me.btnMehrProjektman.Text = "Mehr"
        Me.btnMehrProjektman.UseVisualStyleBackColor = True
        '
        'btnMehrAgiles
        '
        Me.btnMehrAgiles.Location = New System.Drawing.Point(336, 202)
        Me.btnMehrAgiles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMehrAgiles.Name = "btnMehrAgiles"
        Me.btnMehrAgiles.Size = New System.Drawing.Size(136, 48)
        Me.btnMehrAgiles.TabIndex = 4
        Me.btnMehrAgiles.Text = "Mehr"
        Me.btnMehrAgiles.UseVisualStyleBackColor = True
        '
        'picboxScrum
        '
        Me.picboxScrum.Location = New System.Drawing.Point(20, 714)
        Me.picboxScrum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picboxScrum.Name = "picboxScrum"
        Me.picboxScrum.Size = New System.Drawing.Size(279, 264)
        Me.picboxScrum.TabIndex = 3
        Me.picboxScrum.TabStop = False
        '
        'picboxProjektmanagement
        '
        Me.picboxProjektmanagement.Location = New System.Drawing.Point(20, 376)
        Me.picboxProjektmanagement.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picboxProjektmanagement.Name = "picboxProjektmanagement"
        Me.picboxProjektmanagement.Size = New System.Drawing.Size(279, 264)
        Me.picboxProjektmanagement.TabIndex = 2
        Me.picboxProjektmanagement.TabStop = False
        '
        'picboxAgiles
        '
        Me.picboxAgiles.Location = New System.Drawing.Point(20, 52)
        Me.picboxAgiles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picboxAgiles.Name = "picboxAgiles"
        Me.picboxAgiles.Size = New System.Drawing.Size(279, 264)
        Me.picboxAgiles.TabIndex = 1
        Me.picboxAgiles.TabStop = False
        '
        'vsbWeiterbildung
        '
        Me.vsbWeiterbildung.Location = New System.Drawing.Point(1159, 11)
        Me.vsbWeiterbildung.Name = "vsbWeiterbildung"
        Me.vsbWeiterbildung.Size = New System.Drawing.Size(30, 1034)
        Me.vsbWeiterbildung.TabIndex = 0
        '
        'btnWarenkorb
        '
        Me.btnWarenkorb.Location = New System.Drawing.Point(1237, 1145)
        Me.btnWarenkorb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnWarenkorb.Name = "btnWarenkorb"
        Me.btnWarenkorb.Size = New System.Drawing.Size(180, 49)
        Me.btnWarenkorb.TabIndex = 3
        Me.btnWarenkorb.Text = "Warenkorb"
        Me.btnWarenkorb.UseVisualStyleBackColor = True
        '
        'btnBeenden
        '
        Me.btnBeenden.Location = New System.Drawing.Point(1480, 1145)
        Me.btnBeenden.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBeenden.Name = "btnBeenden"
        Me.btnBeenden.Size = New System.Drawing.Size(180, 49)
        Me.btnBeenden.TabIndex = 4
        Me.btnBeenden.Text = "Beenden"
        Me.btnBeenden.UseVisualStyleBackColor = True
        '
        'frmHauptfensterKunde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1677, 1210)
        Me.Controls.Add(Me.btnBeenden)
        Me.Controls.Add(Me.btnWarenkorb)
        Me.Controls.Add(Me.grpboxWeiterbildung)
        Me.Controls.Add(Me.grpboxThemen)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmHauptfensterKunde"
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
    Friend WithEvents vsbWeiterbildung As VScrollBar
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
    Friend WithEvents btnMehrScrum As Button
    Friend WithEvents btnMehrProjektman As Button
    Friend WithEvents btnMehrAgiles As Button
    Friend WithEvents picboxScrum As PictureBox
    Friend WithEvents picboxProjektmanagement As PictureBox
    Friend WithEvents picboxAgiles As PictureBox
    Friend WithEvents btnWarenkorb As Button
    Friend WithEvents btnBeenden As Button
End Class
