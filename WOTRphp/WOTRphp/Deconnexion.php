<?php
session_start();

//supression des variables de session et de la session
$_SESSION = array();
session_destroy();
header("Location: index.php");
?>