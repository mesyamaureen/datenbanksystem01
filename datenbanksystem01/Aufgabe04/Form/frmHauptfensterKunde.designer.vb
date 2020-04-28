<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHauptfensterKunde
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
        Me.tsmHaupt = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuchungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KontoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpbxHaupt = New System.Windows.Forms.GroupBox()
        Me.rbtnGruendInnov = New System.Windows.Forms.RadioButton()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.rbtnRechnungs = New System.Windows.Forms.RadioButton()
        Me.rbtnProdProjChange = New System.Windows.Forms.RadioButton()
        Me.rbtnOrgDesign = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.rbtnGesundheit = New System.Windows.Forms.RadioButton()
        Me.rbtnGenMan = New System.Windows.Forms.RadioButton()
        Me.rbtnDigitalBus = New System.Windows.Forms.RadioButton()
        Me.rbtnControlling = New System.Windows.Forms.RadioButton()
        Me.rbtnBetriebswirt = New System.Windows.Forms.RadioButton()
        Me.rbtnAlle = New System.Windows.Forms.RadioButton()
        Me.lblThemen = New System.Windows.Forms.Label()
        Me.grpbxSekundar = New System.Windows.Forms.GroupBox()
        Me.scrbarWeiterbildungen = New System.Windows.Forms.VScrollBar()
        Me.btnMehrScrum = New System.Windows.Forms.Button()
        Me.btnMehrProjm = New System.Windows.Forms.Button()
        Me.btnMehrAgiles = New System.Windows.Forms.Button()
        Me.lblScrum = New System.Windows.Forms.LinkLabel()
        Me.lblProjm = New System.Windows.Forms.LinkLabel()
        Me.lblAgilesProjm = New System.Windows.Forms.LinkLabel()
        Me.picboxScrum = New System.Windows.Forms.PictureBox()
        Me.picboxProjm = New System.Windows.Forms.PictureBox()
        Me.picboxAgilesProj = New System.Windows.Forms.PictureBox()
        Me.btnBeenden = New System.Windows.Forms.Button()
        Me.btnWarenkorb = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.grpbxHaupt.SuspendLayout()
        Me.grpbxSekundar.SuspendLayout()
        CType(Me.picboxScrum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxProjm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxAgilesProj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmHaupt, Me.BuchungenToolStripMenuItem, Me.KontoToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1258, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmHaupt
        '
        Me.tsmHaupt.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.tsmHaupt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tsmHaupt.Name = "tsmHaupt"
        Me.tsmHaupt.Size = New System.Drawing.Size(205, 36)
        Me.tsmHaupt.Text = "Weiterbildungen"
        '
        'BuchungenToolStripMenuItem
        '
        Me.BuchungenToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.BuchungenToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BuchungenToolStripMenuItem.Name = "BuchungenToolStripMenuItem"
        Me.BuchungenToolStripMenuItem.Size = New System.Drawing.Size(149, 36)
        Me.BuchungenToolStripMenuItem.Text = "Buchungen"
        '
        'KontoToolStripMenuItem
        '
        Me.KontoToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.KontoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.KontoToolStripMenuItem.Name = "KontoToolStripMenuItem"
        Me.KontoToolStripMenuItem.Size = New System.Drawing.Size(90, 36)
        Me.KontoToolStripMenuItem.Text = "Konto"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.HilfeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(12, Byte))
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(77, 36)
        Me.HilfeToolStripMenuItem.Text = "Hilfe"
        '
        'grpbxHaupt
        '
        Me.grpbxHaupt.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.grpbxHaupt.AutoSize = True
        Me.grpbxHaupt.Controls.Add(Me.rbtnGruendInnov)
        Me.grpbxHaupt.Controls.Add(Me.VScrollBar1)
        Me.grpbxHaupt.Controls.Add(Me.rbtnRechnungs)
        Me.grpbxHaupt.Controls.Add(Me.rbtnProdProjChange)
        Me.grpbxHaupt.Controls.Add(Me.rbtnOrgDesign)
        Me.grpbxHaupt.Controls.Add(Me.RadioButton1)
        Me.grpbxHaupt.Controls.Add(Me.rbtnGesundheit)
        Me.grpbxHaupt.Controls.Add(Me.rbtnGenMan)
        Me.grpbxHaupt.Controls.Add(Me.rbtnDigitalBus)
        Me.grpbxHaupt.Controls.Add(Me.rbtnControlling)
        Me.grpbxHaupt.Controls.Add(Me.rbtnBetriebswirt)
        Me.grpbxHaupt.Controls.Add(Me.rbtnAlle)
        Me.grpbxHaupt.Controls.Add(Me.lblThemen)
        Me.grpbxHaupt.Location = New System.Drawing.Point(13, 51)
        Me.grpbxHaupt.Name = "grpbxHaupt"
        Me.grpbxHaupt.Size = New System.Drawing.Size(320, 742)
        Me.grpbxHaupt.TabIndex = 1
        Me.grpbxHaupt.TabStop = False
        '
        'rbtnGruendInnov
        '
        Me.rbtnGruendInnov.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
        Me.rbtnGruendInnov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.rbtnGruendInnov.Location = New System.Drawing.Point(6, 355)
        Me.rbtnGruendInnov.Name = "rbtnGruendInnov"
        Me.rbtnGruendInnov.Size = New System.Drawing.Size(305, 68)
        Me.rbtnGruendInnov.TabIndex = 7
        Me.rbtnGruendInnov.Text = "Gründung " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "und Innovation"
        Me.rbtnGruendInnov.UseVisualStyleBackColor = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(288, 6)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(29, 714)
        Me.VScrollBar1.TabIndex = 5
        '
        'rbtnRechnungs
        '
        Me.rbtnRechnungs.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
        Me.rbtnRechnungs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.rbtnRechnungs.Location = New System.Drawing.Point(6, 640)
        Me.rbtnRechnungs.Name = "rbtnRechnungs"
        Me.rbtnRechnungs.Size = New System.Drawing.Size(260, 71)
        Me.rbtnRechnungs.TabIndex = 11
        Me.rbtnRechnungs.Text = "Rechnungswesen und Finanzen"
        Me.rbtnRechnungs.UseVisualStyleBackColor = True
        '
        'rbtnProdProjChange
        '
        Me.rbtnProdProjChange.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
        Me.rbtnProdProjChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.rbtnProdProjChange.Location = New System.Drawing.Point(6, 519)
        Me.rbtnProdProjChange.Name = "rbtnProdProjChange"
        Me.rbtnProdProjChange.Size = New System.Drawing.Size(270, 135)
        Me.rbtnProdProjChange.TabIndex = 10
        Me.rbtnProdProjChange.Text = "Projekt-, Prozess-, und Changemanagement"
        Me.rbtnProdProjChange.UseVisualStyleBackColor = True
        '
        'rbtnOrgDesign
        '
        Me.rbtnOrgDesign.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
        Me.rbtnOrgDesign.AutoSize = True
        Me.rbtnOrgDesign.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.rbtnOrgDesign.Location = New System.Drawing.Point(6, 483)
        Me.rbtnOrgDesign.Name = "rbtnOrgDesign"
        Me.rbtnOrgDesign.Size = New System.Drawing.Size(260, 33)
        Me.rbtnOrgDesign.TabIndex = 9
        Me.rbtnOrgDesign.Text = "Organisationsdesign"
        Me.rbtnOrgDesign.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(6, 426)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton1.Size = New System.Drawing.Size(189, 35)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.Text = "Marketing und Produktmanagement"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'rbtnGesundheit
        '
        Me.rbtnGesundheit.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
        Me.rbtnGesundheit.AutoSize = True
        Me.rbtnGesundheit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.rbtnGesundheit.Location = New System.Drawing.Point(6, 320)
        Me.rbtnGesundheit.Name = "rbtnGesundheit"
        Me.rbtnGesundheit.Size = New System.Drawing.Size(161, 33)
        Me.rbtnGesundheit.TabIndex = 6
        Me.rbtnGesundheit.Text = "Gesundheit"
        Me.rbtnGesundheit.UseVisualStyleBackColor = True
        '
        'rbtnGenMan
        '
        Me.rbtnGenMan.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
        Me.rbtnGenMan.AutoSize = True
        Me.rbtnGenMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.rbtnGenMan.Location = New System.Drawing.Point(6, 268)
        Me.rbtnGenMan.Name = "rbtnGenMan"
        Me.rbtnGenMan.Size = New System.Drawing.Size(270, 33)
        Me.rbtnGenMan.TabIndex = 5
        Me.rbtnGenMan.Text = "General Management"
        Me.rbtnGenMan.UseVisualStyleBackColor = True
        '
        'rbtnDigitalBus
        '
        Me.rbtnDigitalBus.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
        Me.rbtnDigitalBus.AutoSize = True
        Me.rbtnDigitalBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.rbtnDigitalBus.Location = New System.Drawing.Point(6, 226)
        Me.rbtnDigitalBus.Name = "rbtnDigitalBus"
        Me.rbtnDigitalBus.Size = New System.Drawing.Size(210, 33)
        Me.rbtnDigitalBus.TabIndex = 4
        Me.rbtnDigitalBus.Text = "Digital Business"
        Me.rbtnDigitalBus.UseVisualStyleBackColor = True
        '
        'rbtnControlling
        '
        Me.rbtnControlling.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
        Me.rbtnControlling.AutoSize = True
        Me.rbtnControlling.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.rbtnControlling.Location = New System.Drawing.Point(6, 178)
        Me.rbtnControlling.Name = "rbtnControlling"
        Me.rbtnControlling.Size = New System.Drawing.Size(155, 33)
        Me.rbtnControlling.TabIndex = 3
        Me.rbtnControlling.Text = "Controlling"
        Me.rbtnControlling.UseVisualStyleBackColor = True
        '
        'rbtnBetriebswirt
        '
        Me.rbtnBetriebswirt.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
        Me.rbtnBetriebswirt.AutoSize = True
        Me.rbtnBetriebswirt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.rbtnBetriebswirt.Location = New System.Drawing.Point(6, 132)
        Me.rbtnBetriebswirt.Name = "rbtnBetriebswirt"
        Me.rbtnBetriebswirt.Size = New System.Drawing.Size(228, 33)
        Me.rbtnBetriebswirt.TabIndex = 2
        Me.rbtnBetriebswirt.Text = "Betriebswirtschaft"
        Me.rbtnBetriebswirt.UseVisualStyleBackColor = True
        '
        'rbtnAlle
        '
        Me.rbtnAlle.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
        Me.rbtnAlle.AutoSize = True
        Me.rbtnAlle.Checked = True
        Me.rbtnAlle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.rbtnAlle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.rbtnAlle.Location = New System.Drawing.Point(6, 88)
        Me.rbtnAlle.Name = "rbtnAlle"
        Me.rbtnAlle.Size = New System.Drawing.Size(79, 33)
        Me.rbtnAlle.TabIndex = 1
        Me.rbtnAlle.TabStop = True
        Me.rbtnAlle.Text = "Alle"
        Me.rbtnAlle.UseVisualStyleBackColor = True
        '
        'lblThemen
        '
        Me.lblThemen.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.lblThemen.AutoSize = True
        Me.lblThemen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblThemen.Location = New System.Drawing.Point(6, 14)
        Me.lblThemen.Name = "lblThemen"
        Me.lblThemen.Size = New System.Drawing.Size(109, 29)
        Me.lblThemen.TabIndex = 0
        Me.lblThemen.Text = "Themen"
        '
        'grpbxSekundar
        '
        Me.grpbxSekundar.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.grpbxSekundar.AutoSize = True
        Me.grpbxSekundar.Controls.Add(Me.scrbarWeiterbildungen)
        Me.grpbxSekundar.Controls.Add(Me.btnMehrScrum)
        Me.grpbxSekundar.Controls.Add(Me.btnMehrProjm)
        Me.grpbxSekundar.Controls.Add(Me.btnMehrAgiles)
        Me.grpbxSekundar.Controls.Add(Me.lblScrum)
        Me.grpbxSekundar.Controls.Add(Me.lblProjm)
        Me.grpbxSekundar.Controls.Add(Me.lblAgilesProjm)
        Me.grpbxSekundar.Controls.Add(Me.picboxScrum)
        Me.grpbxSekundar.Controls.Add(Me.picboxProjm)
        Me.grpbxSekundar.Controls.Add(Me.picboxAgilesProj)
        Me.grpbxSekundar.Location = New System.Drawing.Point(377, 49)
        Me.grpbxSekundar.Name = "grpbxSekundar"
        Me.grpbxSekundar.Size = New System.Drawing.Size(872, 747)
        Me.grpbxSekundar.TabIndex = 2
        Me.grpbxSekundar.TabStop = False
        Me.grpbxSekundar.Text = " "
        '
        'scrbarWeiterbildungen
        '
        Me.scrbarWeiterbildungen.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.scrbarWeiterbildungen.Location = New System.Drawing.Point(843, 8)
        Me.scrbarWeiterbildungen.Name = "scrbarWeiterbildungen"
        Me.scrbarWeiterbildungen.Size = New System.Drawing.Size(26, 711)
        Me.scrbarWeiterbildungen.TabIndex = 9
        '
        'btnMehrScrum
        '
        Me.btnMehrScrum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.btnMehrScrum.Location = New System.Drawing.Point(310, 601)
        Me.btnMehrScrum.Name = "btnMehrScrum"
        Me.btnMehrScrum.Size = New System.Drawing.Size(97, 41)
        Me.btnMehrScrum.TabIndex = 8
        Me.btnMehrScrum.Text = "Mehr"
        Me.btnMehrScrum.UseVisualStyleBackColor = True
        '
        'btnMehrProjm
        '
        Me.btnMehrProjm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.btnMehrProjm.Location = New System.Drawing.Point(310, 357)
        Me.btnMehrProjm.Name = "btnMehrProjm"
        Me.btnMehrProjm.Size = New System.Drawing.Size(97, 42)
        Me.btnMehrProjm.TabIndex = 7
        Me.btnMehrProjm.Text = "Mehr"
        Me.btnMehrProjm.UseVisualStyleBackColor = True
        '
        'btnMehrAgiles
        '
        Me.btnMehrAgiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.btnMehrAgiles.Location = New System.Drawing.Point(310, 120)
        Me.btnMehrAgiles.Name = "btnMehrAgiles"
        Me.btnMehrAgiles.Size = New System.Drawing.Size(97, 47)
        Me.btnMehrAgiles.TabIndex = 6
        Me.btnMehrAgiles.Text = "Mehr"
        Me.btnMehrAgiles.UseVisualStyleBackColor = True
        '
        'lblScrum
        '
        Me.lblScrum.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.lblScrum.AutoSize = True
        Me.lblScrum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblScrum.LinkColor = System.Drawing.Color.Black
        Me.lblScrum.Location = New System.Drawing.Point(305, 551)
        Me.lblScrum.Name = "lblScrum"
        Me.lblScrum.Size = New System.Drawing.Size(245, 29)
        Me.lblScrum.TabIndex = 5
        Me.lblScrum.TabStop = True
        Me.lblScrum.Text = "SCRUM - Workshop"
        '
        'lblProjm
        '
        Me.lblProjm.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.lblProjm.AutoSize = True
        Me.lblProjm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblProjm.LinkColor = System.Drawing.Color.Black
        Me.lblProjm.Location = New System.Drawing.Point(306, 310)
        Me.lblProjm.Name = "lblProjm"
        Me.lblProjm.Size = New System.Drawing.Size(246, 29)
        Me.lblProjm.TabIndex = 4
        Me.lblProjm.TabStop = True
        Me.lblProjm.Text = "Projektmanagement"
        '
        'lblAgilesProjm
        '
        Me.lblAgilesProjm.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.lblAgilesProjm.AutoSize = True
        Me.lblAgilesProjm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblAgilesProjm.LinkColor = System.Drawing.Color.Black
        Me.lblAgilesProjm.LinkVisited = True
        Me.lblAgilesProjm.Location = New System.Drawing.Point(306, 77)
        Me.lblAgilesProjm.Name = "lblAgilesProjm"
        Me.lblAgilesProjm.Size = New System.Drawing.Size(326, 29)
        Me.lblAgilesProjm.TabIndex = 3
        Me.lblAgilesProjm.TabStop = True
        Me.lblAgilesProjm.Text = "Agiles Projektmanagement"
        '
        'picboxScrum
        '
        Me.picboxScrum.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic
        Me.picboxScrum.Location = New System.Drawing.Point(41, 509)
        Me.picboxScrum.Name = "picboxScrum"
        Me.picboxScrum.Size = New System.Drawing.Size(217, 213)
        Me.picboxScrum.TabIndex = 2
        Me.picboxScrum.TabStop = False
        '
        'picboxProjm
        '
        Me.picboxProjm.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic
        Me.picboxProjm.Location = New System.Drawing.Point(41, 270)
        Me.picboxProjm.Name = "picboxProjm"
        Me.picboxProjm.Size = New System.Drawing.Size(217, 204)
        Me.picboxProjm.TabIndex = 1
        Me.picboxProjm.TabStop = False
        '
        'picboxAgilesProj
        '
        Me.picboxAgilesProj.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic
        Me.picboxAgilesProj.Location = New System.Drawing.Point(41, 25)
        Me.picboxAgilesProj.Name = "picboxAgilesProj"
        Me.picboxAgilesProj.Size = New System.Drawing.Size(217, 211)
        Me.picboxAgilesProj.TabIndex = 0
        Me.picboxAgilesProj.TabStop = False
        '
        'btnBeenden
        '
        Me.btnBeenden.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.btnBeenden.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.btnBeenden.Location = New System.Drawing.Point(1105, 853)
        Me.btnBeenden.Name = "btnBeenden"
        Me.btnBeenden.Size = New System.Drawing.Size(141, 54)
        Me.btnBeenden.TabIndex = 3
        Me.btnBeenden.Text = "Beenden"
        Me.btnBeenden.UseVisualStyleBackColor = True
        '
        'btnWarenkorb
        '
        Me.btnWarenkorb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.btnWarenkorb.Location = New System.Drawing.Point(921, 853)
        Me.btnWarenkorb.Name = "btnWarenkorb"
        Me.btnWarenkorb.Size = New System.Drawing.Size(159, 54)
        Me.btnWarenkorb.TabIndex = 4
        Me.btnWarenkorb.Text = "Warenkorb"
        Me.btnWarenkorb.UseVisualStyleBackColor = True
        '
        'frmHauptfensterKunde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 968)
        Me.Controls.Add(Me.btnWarenkorb)
        Me.Controls.Add(Me.btnBeenden)
        Me.Controls.Add(Me.grpbxSekundar)
        Me.Controls.Add(Me.grpbxHaupt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmHauptfensterKunde"
        Me.Text = "Weiterbildungen time2-Akademie"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpbxHaupt.ResumeLayout(False)
        Me.grpbxHaupt.PerformLayout()
        Me.grpbxSekundar.ResumeLayout(False)
        Me.grpbxSekundar.PerformLayout()
        CType(Me.picboxScrum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxProjm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxAgilesProj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmHaupt As ToolStripMenuItem
    Friend WithEvents BuchungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KontoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpbxHaupt As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents rbtnGruendInnov As RadioButton
    Friend WithEvents rbtnGesundheit As RadioButton
    Friend WithEvents rbtnGenMan As RadioButton
    Friend WithEvents rbtnDigitalBus As RadioButton
    Friend WithEvents rbtnControlling As RadioButton
    Friend WithEvents rbtnBetriebswirt As RadioButton
    Friend WithEvents rbtnAlle As RadioButton
    Friend WithEvents lblThemen As Label
    Friend WithEvents grpbxSekundar As GroupBox
    Friend WithEvents rbtnRechnungs As RadioButton
    Friend WithEvents rbtnProdProjChange As RadioButton
    Friend WithEvents rbtnOrgDesign As RadioButton
    Friend WithEvents btnMehrScrum As Button
    Friend WithEvents btnMehrProjm As Button
    Friend WithEvents btnMehrAgiles As Button
    Friend WithEvents lblScrum As LinkLabel
    Friend WithEvents lblProjm As LinkLabel
    Friend WithEvents lblAgilesProjm As LinkLabel
    Friend WithEvents picboxScrum As PictureBox
    Friend WithEvents picboxProjm As PictureBox
    Friend WithEvents picboxAgilesProj As PictureBox
    Friend WithEvents btnBeenden As Button
    Friend WithEvents btnWarenkorb As Button
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents scrbarWeiterbildungen As VScrollBar
End Class
