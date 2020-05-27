<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class testLogic
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
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.lblattempt = New System.Windows.Forms.Label()
        Me.lblrole = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(599, 371)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(179, 57)
        Me.btnLogIn.TabIndex = 0
        Me.btnLogIn.Text = "LogIn"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'lblattempt
        '
        Me.lblattempt.AutoSize = True
        Me.lblattempt.Location = New System.Drawing.Point(368, 236)
        Me.lblattempt.Name = "lblattempt"
        Me.lblattempt.Size = New System.Drawing.Size(40, 17)
        Me.lblattempt.TabIndex = 1
        Me.lblattempt.Text = "Hallo"
        '
        'lblrole
        '
        Me.lblrole.AutoSize = True
        Me.lblrole.Location = New System.Drawing.Point(371, 294)
        Me.lblrole.Name = "lblrole"
        Me.lblrole.Size = New System.Drawing.Size(40, 17)
        Me.lblrole.TabIndex = 2
        Me.lblrole.Text = "Rolle"
        '
        'testLogic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblrole)
        Me.Controls.Add(Me.lblattempt)
        Me.Controls.Add(Me.btnLogIn)
        Me.Name = "testLogic"
        Me.Text = "testLogic"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogIn As Button
    Friend WithEvents lblattempt As Label
    Friend WithEvents lblrole As Label
End Class
