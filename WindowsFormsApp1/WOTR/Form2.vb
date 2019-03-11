Imports System.Data.SqlClient

Public Class FormConnexion
    'Connexion au Serveur MySQL et à la BD
    Public ConnexionWOTR As SqlConnection = New SqlConnection("Data Source=Rose\SIOI;Initial Catalog = AEJT_WOTR;Integrated Security =True")

    Private Sub FormConnexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub buttonAnnuler_Click(sender As Object, e As EventArgs) Handles buttonAnnuler.Click
        textBoxCode.Text = ""
        textBoxID.Text = ""
        textBoxMail.Text = ""
        textBoxMDP.Text = ""
    End Sub

    Private Sub Valider_Click(sender As Object, e As EventArgs) Handles Valider.Click
        ConnexionWOTR.Open()
        ' Instanciation et définition de la commmande
        Dim Commande As SqlCommand = New SqlCommand("SELECT idClie, pwdClie, codeAccesClie, mailClie FROM client where idClie=01", ConnexionWOTR)
        Dim Lecteur As SqlDataReader = Commande.ExecuteReader()

        If (Lecteur.Read()) Then
            Dim count = 0
            'MessageBox.Show(Lecteur("idClie") + " " + Lecteur("pwdClie") + " " + Lecteur("codeAccesClie") + " " + Lecteur("mailClie"))
            If (textBoxID.Text = Lecteur("idClie") And textBoxMDP.Text = Lecteur("pwdClie") And textBoxMail.Text = Lecteur("mailClie") And textBoxCode.Text = Lecteur("codeAccesClie")) Then
                FormCode.Show()
            End If
        End If
        ConnexionWOTR.Close()
    End Sub

End Class