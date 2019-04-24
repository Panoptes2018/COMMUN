<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Verification
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.buttonAnnuler = New System.Windows.Forms.Button()
        Me.Verifier = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBoxMDPVerif = New System.Windows.Forms.TextBox()
        Me.textBoxIDVerif = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'buttonAnnuler
        '
        Me.buttonAnnuler.Location = New System.Drawing.Point(241, 77)
        Me.buttonAnnuler.Name = "buttonAnnuler"
        Me.buttonAnnuler.Size = New System.Drawing.Size(170, 23)
        Me.buttonAnnuler.TabIndex = 49
        Me.buttonAnnuler.Text = "Annuler"
        Me.buttonAnnuler.UseVisualStyleBackColor = True
        '
        'Verifier
        '
        Me.Verifier.Location = New System.Drawing.Point(26, 77)
        Me.Verifier.Name = "Verifier"
        Me.Verifier.Size = New System.Drawing.Size(174, 23)
        Me.Verifier.TabIndex = 48
        Me.Verifier.Text = "Verifier"
        Me.Verifier.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(234, 29)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(71, 13)
        Me.label3.TabIndex = 46
        Me.label3.Text = "Mot de passe"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(19, 26)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(53, 13)
        Me.label1.TabIndex = 44
        Me.label1.Text = "Identifiant"
        '
        'textBoxMDPVerif
        '
        Me.textBoxMDPVerif.Location = New System.Drawing.Point(311, 26)
        Me.textBoxMDPVerif.Name = "textBoxMDPVerif"
        Me.textBoxMDPVerif.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9632)
        Me.textBoxMDPVerif.Size = New System.Drawing.Size(100, 20)
        Me.textBoxMDPVerif.TabIndex = 41
        '
        'textBoxIDVerif
        '
        Me.textBoxIDVerif.Location = New System.Drawing.Point(96, 26)
        Me.textBoxIDVerif.Name = "textBoxIDVerif"
        Me.textBoxIDVerif.Size = New System.Drawing.Size(100, 20)
        Me.textBoxIDVerif.TabIndex = 40
        '
        'Verification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 130)
        Me.Controls.Add(Me.buttonAnnuler)
        Me.Controls.Add(Me.Verifier)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textBoxMDPVerif)
        Me.Controls.Add(Me.textBoxIDVerif)
        Me.Name = "Verification"
        Me.Text = "Verification"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents buttonAnnuler As Button
    Private WithEvents Verifier As Button
    Private WithEvents label3 As Label
    Private WithEvents label1 As Label
    Private WithEvents textBoxMDPVerif As TextBox
    Private WithEvents textBoxIDVerif As TextBox
End Class
