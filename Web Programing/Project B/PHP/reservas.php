<html>
    <body>
    <link rel="stylesheet" href="../CSS/phpstyle.css">

<?php

include("connect.php");

$email = $_POST['email2'];
$password = $_POST['password'];
$hora = $_POST['hora'];
$pessoas = $_POST['pessoas'];

$sql = "SELECT * FROM clientes WHERE email = '$email'";
$res = $conn->query($sql);

if ($res->num_rows > 0) {
    $row = $res->fetch_assoc();
    if ($row['password'] == $password){
        $query = "INSERT INTO reservas(email, hora, npessoas) VALUES ('$email', '$hora', '$pessoas')";
        if (mysqli_query($conn, $query)){
            echo "<h3>Reserva feita com sucesso</h3>";
        }
        else{
            echo "<h3>Erro ao criar reserva</h3>";
        }
    }
    else {
        echo "<h3>Password incorrecta</h3>";
    }
} else {
    echo "<h3>O email que introduziu não se encontra registado</h3>";
}

mysqli_close($conn);
?>
        <br>
        <br>
        <button onclick="document.location='../Projecto.php'">Regressar</button>
    </body>
</html>