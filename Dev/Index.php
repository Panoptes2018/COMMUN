<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
    <link rel="stylesheet" href="../CSS.css" />
    <title>Connexion</title>

</head>
<body>
    <h1>WORK ON THE ROAD</h1>
    <form method="post" class="connexion">

        <h3>
            <br />
            Connexion
            <br />
        </h3>
        <table class="connexion">

            <tr class="connexion">
                <td>Identifiant:</td>
                <td>
                    <input type="email" name="Identifiant" />
                </td>
            </tr>
            <tr class="connexion">
                <td>Mot de passe:</td>
                <td>
                    <input type="Password" name="MDP" />
                </td>
            </tr>
        </table>
        <br />
        <input class="connexion" type="submit" name="Connexion" value="Connexion" />
        <?php
        if (isset($_POST['Connexion'])){
            VerifUtil();
        }
        ?>

    </form>
    <?php

function VerifUtil()
{
    //* Connexion au serveur de BD //*
	$Connexion= new PDO("sqlsrv:Server=Rose\SIOI;Database=[AEJT_WOTR]", 'jboyer', '20111999');
	//* Exécution de la requete //*

    //Si le bouton connexion est activé :
    if (isset($_POST['Connexion'])){
        if (!empty($_POST['Identifiant']) AND !empty($_POST['MDP'])){
            $Identifiant = $_POST['Identifiant'];
            $MDP = $_POST['MDP'];
            $requete = $Connexion->prepare('SELECT mailEmp FROM EMPLOYE WHERE mailEmp = :Identifiant');
            $requete -> execute(array(
                'Identifiant' => $Identifiant));
            $result = $requete->fetch();
            //On vérifie si le compte existe:
            if ($result == ''){
                $reponse2 = "Le mot de passe est incorect ou l'utilisateur n'existe pas.";
            }
            else{
                $requete2 = $Connexion->prepare('SELECT pwdEmp FROM EMPLOYE WHERE MdpEmp = :MDP');
                $requete2->execute(array(
                    'MDP' =>$MDP));
                $result2 = $requete2->fetch();
                //On vérifie si le mot de passe est correct:
                if($result2 == ''){
                    $reponse2 = "Le mot de passe est incorect ou l'utilisateur n'existe pas.";
                }
                else{
                    $requete3 = $Connexion->prepare('SELECT * FROM EMPLOYE WHERE mailEmp = ?');
                    $requete3 -> execute(array($Identifiant));
                    while($donnees = $requete3->fetch())
                    {
                        session_start();
                        $_SESSION['ouvert'] = true;

                        header("Location: ../Accueil.php");
                    }
                    $requete3->closecursor();
                }
            }
        }
        else{
            $reponse2="Tous les champs doivent &ecirc;tre rempli.";
        }
    }
    if(isset($reponse2))
    {
        echo '<center><p style="color:red;front-size:20px">'.$reponse2.'</p></center>';
    }

}

?>
</body>

</html>