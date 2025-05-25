<html>
    <body>
    <link rel="stylesheet" href="../CSS/phpstyle.css">

<?php

include("connect.php");

$user = $_POST['user'];
$pass = $_POST['pass'];

$sql = "SELECT * FROM staff WHERE user = '$user'";
$res = $conn->query($sql);

if ($res->num_rows > 0) {
    $row = $res->fetch_assoc();
    if ($row['pass'] == $pass){
        echo "<script> window.location.href = 'imprimir.php' </script>";
    }
    else {
        echo "<h3>Password incorrecta</h3>";
    }
} else {
    echo "<h3>$user não existe</h3>";
}

mysqli_close($conn);
?>
        <br>
        <br>
        <button onclick="document.location='../logindestaff.html'">Regressar</button>
    </body>
</html>

