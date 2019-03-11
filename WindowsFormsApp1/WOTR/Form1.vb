Imports System.Data.SqlClient

Public Class FormCode
    Public ConnexionWOTR As SqlConnection = New SqlConnection("Data Source=Rose\SIOI;Initial Catalog = AEJT_WOTR;Integrated Security =True")

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        textBox1.Text += "1"
    End Sub
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        textBox1.Text += "2"
    End Sub
    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        textBox1.Text += "3"
    End Sub
    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        textBox1.Text += "4"
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        textBox1.Text += "5"
    End Sub
    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        textBox1.Text += "6"
    End Sub
    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        textBox1.Text += "7"
    End Sub
    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        textBox1.Text += "8"
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        textBox1.Text += "9"
    End Sub

    Private Sub button0_Click(sender As Object, e As EventArgs) Handles button0.Click
        textBox1.Text += "0"
    End Sub

    Private Sub buttonA_Click(sender As Object, e As EventArgs) Handles buttonA.Click
        ConnexionWOTR.Open()
        ' Instanciation et définition de la commmande
        Dim Commande As SqlCommand = New SqlCommand("SELECT codeAccesClie FROM client where idClie=01", ConnexionWOTR)
        Dim Lecteur As SqlDataReader = Commande.ExecuteReader()

        If (Lecteur.Read()) Then
            'Dim mdp = "7569"
            If (textBox1.Text = Lecteur("codeAccesClie")) Then
                buttonA.BackColor = Color.Lime
                MessageBox.Show("Accés Validé")
                Me.Close()
            Else
                buttonA.BackColor = Color.Red
                MessageBox.Show("Accés Refusé")
            End If
            ConnexionWOTR.Close()
        End If
        textBox1.Text = ""
        buttonA.BackColor = Color.Empty
    End Sub

    Private Sub buttonP_Click(sender As Object, e As EventArgs) Handles buttonP.Click


    End Sub

    Private Sub FormCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormConnexion.Close()
    End Sub
End Class
