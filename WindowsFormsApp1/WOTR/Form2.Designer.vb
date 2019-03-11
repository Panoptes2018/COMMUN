<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConnexion
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
        Me.Valider = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBoxCode = New System.Windows.Forms.TextBox()
        Me.textBoxMail = New System.Windows.Forms.TextBox()
        Me.textBoxMDP = New System.Windows.Forms.TextBox()
        Me.textBoxID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'buttonAnnuler
        '
        Me.buttonAnnuler.Location = New System.Drawing.Point(227, 124)
        Me.buttonAnnuler.Name = "buttonAnnuler"
        Me.buttonAnnuler.Size = New System.Drawing.Size(170, 23)
        Me.buttonAnnuler.TabIndex = 29
        Me.buttonAnnuler.Text = "Annuler"
        Me.buttonAnnuler.UseVisualStyleBackColor = True
        '
        'Valider
        '
        Me.Valider.Location = New System.Drawing.Point(12, 124)
        Me.Valider.Name = "Valider"
        Me.Valider.Size = New System.Drawing.Size(174, 23)
        Me.Valider.TabIndex = 28
        Me.Valider.Text = "Valider"
        Me.Valider.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(224, 73)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(72, 13)
        Me.label4.TabIndex = 27
        Me.label4.Text = "Code d'acces"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(9, 69)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(71, 13)
        Me.label3.TabIndex = 26
        Me.label3.Text = "Mot de passe"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(224, 18)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(67, 13)
        Me.label2.TabIndex = 25
        Me.label2.Text = "Adresse Mail"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(9, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(53, 13)
        Me.label1.TabIndex = 24
        Me.label1.Text = "Identifiant"
        '
        'textBoxCode
        '
        Me.textBoxCode.Location = New System.Drawing.Point(297, 66)
        Me.textBoxCode.Name = "textBoxCode"
        Me.textBoxCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9632)
        Me.textBoxCode.Size = New System.Drawing.Size(100, 20)
        Me.textBoxCode.TabIndex = 23
        '
        'textBoxMail
        '
        Me.textBoxMail.Location = New System.Drawing.Point(297, 15)
        Me.textBoxMail.Name = "textBoxMail"
        Me.textBoxMail.Size = New System.Drawing.Size(100, 20)
        Me.textBoxMail.TabIndex = 22
        '
        'textBoxMDP
        '
        Me.textBoxMDP.Location = New System.Drawing.Point(86, 66)
        Me.textBoxMDP.Name = "textBoxMDP"
        Me.textBoxMDP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9632)
        Me.textBoxMDP.Size = New System.Drawing.Size(100, 20)
        Me.textBoxMDP.TabIndex = 21
        '
        'textBoxID
        '
        Me.textBoxID.Location = New System.Drawing.Point(86, 15)
        Me.textBoxID.Name = "textBoxID"
        Me.textBoxID.Size = New System.Drawing.Size(100, 20)
        Me.textBoxID.TabIndex = 20
        '
        'FormConnexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 163)
        Me.Controls.Add(Me.buttonAnnuler)
        Me.Controls.Add(Me.Valider)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textBoxCode)
        Me.Controls.Add(Me.textBoxMail)
        Me.Controls.Add(Me.textBoxMDP)
        Me.Controls.Add(Me.textBoxID)
        Me.Name = "FormConnexion"
        Me.Text = "Formulaire de Connexion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents buttonAnnuler As Button
    Private WithEvents Valider As Button
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents textBoxCode As TextBox
    Private WithEvents textBoxMail As TextBox
    Private WithEvents textBoxMDP As TextBox
    Private WithEvents textBoxID As TextBox
End Class
