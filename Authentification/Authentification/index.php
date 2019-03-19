<!DOCTYPE html>
<!--<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <link rel="stylesheet" href="FdS.css" />
    <title>Exercice 6</title>
</head>
<body>
    <h1>FORMULAIRE D'AUTHENTIFICATION</h1>
    <label>Avertissement : Cette page est d&eacute;id&eacute;e aux futurs &eacute;l&egrave;ves qui ne sont pas inscrit</label><br /><br />
    <!--<form name="NewContact" method="post" action="saisie.php">-->
    <form>
        <fieldset name="Situation">
            <input type="text" name="Nom" /> <br />
            <input type="submit" name="1" value="1" />
            <input type="submit" name="2" value="2" />
            <input type="submit" name="3" value="3" /> <br />
            <input type="submit" name="4" value="4" />
            <input type="submit" name="5" value="5" />
            <input type="submit" name="6" value="6" /> <br />
            <input type="submit" name="7" value="7" />
            <input type="submit" name="8" value="8" />
            <input type="submit" name="9" value="9" /> <br />
            <input type="submit" name="a" value="a" />
            <input type="submit" name="0" value="0" />
            <input type="submit" name="p" value="p" />
        </fieldset> <br />

    </form>
    <?php
    if (isset($_POST['1']))
    {
        Nom.Text=1;
    }
    ?>
</body>
</html>