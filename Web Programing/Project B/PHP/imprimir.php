<html>
<head>
    <meta charset="UTF-8">
	<title>Reservas</title>
</head>

<body>

<link rel="stylesheet" href="../CSS/reservas.css">

<h3>Reservas</h3>
<div id="tabela">
<?php

include("connect.php");

$sql = "SELECT * FROM reservas s, clientes d WHERE s.email=d.email";
$result = mysqli_query($conn,$sql);

if (mysqli_num_rows($result) > 0) {
  echo "<table class='imprimir'>
    <thead>
      <tr>
        <th>E-mail</th>
        <th>Nome</th>
        <th>Nº de Pessoas</th>
        <th>Hora de Reserva</th>
      </tr>
    </thead>
    ";
  while($row = mysqli_fetch_assoc($result)) {
    echo "<tr>",
      "<td>", $row["email"],"</td>",
      "<td>", $row["nome"],"</td>",
      "<td>", $row["npessoas"],"</td>",
      "<td>", $row["hora"],"</td>",
        "</tr>";
  }
  echo  "</table>";
} else {
  echo "<h3>Não existem reservas</h3>";
}

mysqli_close($conn);
?>
</div>
        <br>
        <br>
        <button onclick="document.location='../logindestaff.html'">Regressar</button>
</body>
</html>