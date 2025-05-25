<html>
    <body>
    <link rel="stylesheet" href="../CSS/phpstyle.css">

<?php

include("connect.php");

$nome = $_POST['nome'];
$email = $_POST['email'];
$telefone = $_POST['telefone'];
$pwd = $_POST['pwd'];

$sql = "SELECT * FROM clientes WHERE email = '$email'";
$res = $conn->query($sql);

if ($res->num_rows > 0) {
    echo "<h3>E-mail já se encontra registado</h3>";
} else{
    $query = "INSERT INTO clientes(email, nome, password, telefone) VALUES ('$email', '$nome', '$pwd', '$telefone')";
    if (mysqli_query($conn, $query)){
        echo "<h3>Cliente registado com sucesso</h3>";
    }
    else{
        echo "<h3>Erro ao registar cliente</h3>";
    }
}

mysqli_close($conn);

?>
        <br>
        <br>
        <button onclick="document.location='../Projecto.php'">Regressar</button>
    </body>
</html>