<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
	<title>Le Restaurant La Ratatouille</title>
</head>

<body>

    <link rel="stylesheet" href="CSS/Style.css">
    <link rel="stylesheet" href="CSS/registo.css">

    <div class="imgbox">
        <img id="inicio" class="fit" src="IMG/ratatouille-sign.png">
    </div>

    <div id="top">
        <div class="dropdown">
            <button class="dropbtn">Quem Somos</button>
            <div class="dropdown-content">
                <a href="#sobre">Sobre</a>
                <a href="#chef">Chef</a>
            </div>
        </div>

        
        <div class="dropdown">
            <button class="dropbtn">Menu</button>
            <div class="dropdown-content">
                <a href="#pratos">Pratos Especiais</a>
                <a href="#menu">Menu</a>
            </div>
        </div>

        <a href="#inicio">
            <img src="IMG/MicrosoftTeams-image.png" height="50px">
        </a>

        <div class="dropdown">
            <button class="dropbtn">Reservas</button>
            <div class="dropdown-content">
                <a href="#registo">Registo</a>
                <a href="#reservas">Reservar</a>
            </div>
        </div>

        <a href="#contactos" class="dropbtn">Contactos</a>
    </div>
    

    <div id="sobre">
        <br><br><br><h3>Sobre</h3>
        <div class="divider">
        <p style="padding-right: 150px;">
            Desde nosso modesto início em 2007, com um pequeno espaço na elegante localidade de Paris, em França, o desenvolvimento do La Ratatouille foi animado com a energia para cozinhar e servir comida deliciosa parisiense. 
            Em contraste com outros restaurantes franceses, La Ratatouille foi feito com a expectativa explícita de esperar o inesperado. 
            La Ratatouille foi desenvolvido para incorporar as combinações mais unicas na cozinha. <br><br><br>
            Nosso grupo se orgulha de poder fornecer aos nossos novos e fiéis clientes alimentos de sabor extraordinário, o que não é normal em algum outro restaurante francês que você visite. 
            Percebemos que algumas pessoas ainda estão em busca de algo novo e diferente, e isso está bom para nós. 
            Nossa expectativa é que você se junte ao padrão de desenvolvimento que um grande número de outras pessoas encontraram oficialmente e tente La Ratatouille como uma opção notável para outros restaurantes!
        </p>
            <img src="IMG/restaurant.png" class="img" width="700px">
        </div>
    </div>

    <div id="chef">
        <br><br><br><h3 id="remi">Chef</h3>
        <div class="divider">
            <img src="IMG/Remi.png" class="img" width="350px">
        <p id=remi2 style="padding-left: 150px;">
            Nascido e criado em Paris, em 2007 frequentou o restaurant Gusteau's. 
            Após se formar como chef, ele entrou no L'Ecole Superieure de la Cuisine Francaise Gregoire-Ferrandi, obtendo um diploma em Artes Culinárias.<br><br>
            Em 2008 usando sua carreira culinária, ele e os seus dois sous chefes Colette Tatou e Alfredo Linguini Gusteau abriram o atual restaurante La Ratatouille. 
            Chef Remi teve uma extravagante abretura na qual recebeu 5 estrelas pelo critico aclamado Anton Ego. 
        </p>
        </div>
    </div>

    <div id="pratos">
        <br><br><br><br><h3 style="text-align: center;">Pratos Especiais</h3>
        <p>
            <table class="especiais">
                <tr>
                    <th><img src="IMG/Boeuf.jpg" class="img" width="400px"></th>
                    <th><img src="IMG/Ratatouille.jpg" class="img" width="400px"></th>
                    <th><img src="IMG/Coq.jpg" class="img" width="400px"></th>
                </tr>
                <tr>
                    <td class="bold">Boeuf bourguignon</td>
                    <td class="bold">Ratatouille</td>
                    <td class="bold">Coq au vin</td>
                </tr>
                <tr>
                    <td class="small">Cozido de carne temperado <br> com vinho vermelho e vegetais</td>
                    <td class="small">Vegetais fritos colocados numa cassarola <br> e levados ao forno</td>
                    <td class="small">Galinha refogada com vinho,<br> cogumelos e bacon</td>
                </tr>
            </table>
        </p>

    </div>

    <div id="menu">
        <br><br><br><p>
            <h3 style="text-align: center; padding: 20px">Menu</h3>

            <?php

            $db_host = 'localhost';
            $db_username = 'root';
            $db_password = '';
            $db_name = 'la_ratatouille';

            $conn = mysqli_connect($db_host, $db_username, $db_password, $db_name) or die("unable to connect to host");

            $sql = "SELECT * FROM menu WHERE seccao='Carne'"; 
            $result = mysqli_query($conn,$sql);

            if (mysqli_num_rows($result) > 0) {
                echo '<table class="especiais">';
                echo '<tr><th>Carne</th></tr>';
            while($row = mysqli_fetch_assoc($result)) {
                echo '<tr>';
                echo '<td class="bold">'. $row["prato"]. '	'. $row["preco"].'€</td></tr>';
                echo '<tr><td>'. $row["descricao"].'</td>'.'</tr>';
            }
            echo  '</table>';
            } else {
            echo '0 results';
            }

            mysqli_close($conn);
            ?>

            <?php

            $db_host = 'localhost';
            $db_username = 'root';
            $db_password = '';
            $db_name = 'la_ratatouille';

            $conn = mysqli_connect($db_host, $db_username, $db_password, $db_name) or die("unable to connect to host");

            $sql = "SELECT * FROM menu WHERE seccao='Peixe'"; 
            $result = mysqli_query($conn,$sql);

            if (mysqli_num_rows($result) > 0) {
                echo '<table class="especiais">';
                echo '<tr><th>Peixe</th></tr>';
            while($row = mysqli_fetch_assoc($result)) {
                echo '<tr>';
                echo '<td class="bold">'. $row["prato"]. '	'. $row["preco"].'€</td></tr>';
                echo '<tr><td>'. $row["descricao"].'</td>'.'</tr>';
            }
            echo  '</table>';
            } else {
            echo '0 results';
            }

            mysqli_close($conn);
            ?>

            <?php

            $db_host = 'localhost';
            $db_username = 'root';
            $db_password = '';
            $db_name = 'la_ratatouille';

            $conn = mysqli_connect($db_host, $db_username, $db_password, $db_name) or die("unable to connect to host");

            $sql = "SELECT * FROM menu WHERE seccao='Vegetariano'"; 
            $result = mysqli_query($conn,$sql);

            if (mysqli_num_rows($result) > 0) {
                echo '<table class="especiais">';
                echo '<tr><th>Vegetariano</th></tr>';
            while($row = mysqli_fetch_assoc($result)) {
                echo '<tr>';
                echo '<td class="bold">'. $row["prato"]. '	'. $row["preco"].'€</td></tr>';
                echo '<tr><td>'. $row["descricao"].'</td>'.'</tr>';
            }
            echo  '</table>';
            } else {
            echo '0 results';
            }

            mysqli_close($conn);
            ?>

            <?php

            $db_host = 'localhost';
            $db_username = 'root';
            $db_password = '';
            $db_name = 'la_ratatouille';

            $conn = mysqli_connect($db_host, $db_username, $db_password, $db_name) or die("unable to connect to host");

            $sql = "SELECT * FROM menu WHERE seccao='Saladas'"; 
            $result = mysqli_query($conn,$sql);

            if (mysqli_num_rows($result) > 0) {
                echo '<table class="especiais">';
                echo '<tr><th>Saladas</th></tr>';
            while($row = mysqli_fetch_assoc($result)) {
                echo '<tr>';
                echo '<td class="bold">'. $row["prato"]. '	'. $row["preco"].'€</td></tr>';
                echo '<tr><td>'. $row["descricao"].'</td>'.'</tr>';
            }
            echo  '</table>';
            } else {
            echo '0 results';
            }

            mysqli_close($conn);
            ?>

            <?php

            $db_host = 'localhost';
            $db_username = 'root';
            $db_password = '';
            $db_name = 'la_ratatouille';

            $conn = mysqli_connect($db_host, $db_username, $db_password, $db_name) or die("unable to connect to host");

            $sql = "SELECT * FROM menu WHERE seccao='Sopas'"; 
            $result = mysqli_query($conn,$sql);

            if (mysqli_num_rows($result) > 0) {
                echo '<table class="especiais">';
                echo '<tr><th>Sopas</th></tr>';
            while($row = mysqli_fetch_assoc($result)) {
                echo '<tr>';
                echo '<td class="bold">'. $row["prato"]. '	'. $row["preco"].'€</td></tr>';
                echo '<tr><td>'. $row["descricao"].'</td>'.'</tr>';
            }
            echo  '</table>';
            } else {
            echo '0 results';
            }

            mysqli_close($conn);
            ?>


        </p>
    </div>

    <div id="registo">
        <br><br><br>
        <div id="registo2">
            <div class="imgbox">
                <img class="fit" src="IMG/registo.png">
            </div>

            <h3>Registo</h3>
            <div class="container">
            <form class="reservar" action="PHP/projecto_criar.php" method="POST">
                <label for="nome" >Nome: </label>
                    <input style="font-size:20px" type="text" name="nome" placeholder="Nome próprio" required><br><br>

                <label for="email">e-mail: </label>
                    <input style="font-size:20px" type="email" name="email" placeholder="e-mail" required><br><br>

                <label for="phone">Telefone: </label>
                    <input style="font-size:20px" type="tel" name="telefone" placeholder="Numero" required><br>
                    <small>Formato Francês: 12.34.56.78.90 </small><br><br>

                <label for="pwd">Password: </label>
                    <input id="pswd" style="font-size:20px" type="password" name="pwd" placeholder="Password" pattern="(?=.*\d)(?=.*[a-z]).{8,15}" required><br><br>

                <label for="cfmpwd">Confirmar Password: </label>
                    <input id="pswd2" style="font-size:20px" type="password" name="cfmpwd" placeholder="Confirmar Password" required><br><br>

                <button type="submit">Registar</button>
            </form>
            </div>
            <div id="message">
                <h2>Password deve conter:</h2>
                <p id="letter" class="invalid">A <b>lowercase</b> letter</p>
                <p id="number" class="invalid">Um <b>numero</b></p>
                <p id="length" class="invalid">Entre <b>8 a 15 caracteres</b></p>
                <p id="igual" class="invalid">Igual à <b>confirmação de password</b></p>
            </div>
        </div>
    </div>

    <div id="reservas">
        <br><br><br><h3>Reservar</h3>
        <form class="reservar" action="PHP/reservas.php" method="POST">
            <label for="email">e-mail: </label>
                <input style="font-size:20px"type="email" name="email2" placeholder="e-mail" required><br><br>

            <label for="pwd">Password: </label>
                <input style="font-size:20px" type="password" name="password" placeholder="Password"><br><br>

            <label for="hora">Hora: </label>
                <select name="hora">
                <option value="Almoço">Almoço</option>
                <option value="Jantar">Jantar</option>
                </select>

            <label for="pessoas">Nº de Pessoas:</label>
                <select name="pessoas">
                    <option value="1">1</option>
                    <option value="2">2</option>
                    <option value="3">3</option>
                    <option value="4">4</option>
                    <option value="5">5</option>
                    <option value="6">6</option>
                    <option value="7">7</option>
                    <option value="8">8</option>
                    <option value="9">9</option>
                    <option value="10">10</option>
                </select><br><br>

            <button type="submit">Registar</button><br><br>
        </form>


    </div>
    <div id="contactos">
        <br><br><br><h3>Contactos</h3>
        <div class="divider2">
            <img src="IMG/Map.png" class="img" width="700px">
            <table class="contactos">
                <tr>
                    <th>Morada:</th>
                </tr>
                <tr>
                    <td>674 Rue Omellete du Fromage, Paris, 75006</td>
                </tr>
                <tr>
                    <th>E-mail:</th>
                </tr>
                <tr>
                    <td>geral@laratatouille.com</td>
                </tr>
                <tr>
                    <th>Telefone:</th>
                </tr>
                <tr>
                    <td>05.71.29.37.41</td>
                </tr>
            </table>
        </div>

        <div class="divider2">
            <table class="contactos">
                <tr>
                    <th>Horário:</th>
                </tr>
                <tr>
                    <th>Seg-Sáb:</th>
                    <th>Domingo:</th>
                </tr>
                <tr>
                    <td>Almoço 11:00/15:00</td>
                    <td>Fechado</td>
                </tr>
                <tr>
                    <td>Jantar 18:00/23:00</td>
                </tr>
            </table>

            <table class="contactos2">
                
                <tr>
                    <td><img src="IMG/facebook.png" width="100px"></td>
                    <td>LaRatatouille</td>
                </tr>
                <tr>
                    <td><img src="IMG/Instagram.png"width="100px"></td>
                    <td>@LaRatatouille</td>
                </tr>
                <tr>
                    <td><img src="IMG/tripadvisor.png"width="100px"></td>
                    <td>LaRatatouille</td>
                </tr>
                </tr>
            </table>
           
        </div>
    </div>
    
    
    <footer class="bottom">
        <p class="bottom">
            <button onclick="window.location.href='logindestaff.html'">Login de Staff</button>
        </p>
    </footer>
    <script>
    var pw1 = document.getElementById("pswd");
    var pw2 = document.getElementById("pswd2");
    var letter = document.getElementById("letter");
    var capital = document.getElementById("capital");
    var number = document.getElementById("number");
    var length = document.getElementById("length");

    pw1.onfocus = function() {
    document.getElementById("message").style.display = "block";
    }

    pw1.onblur = function() {
    document.getElementById("message").style.display = "none";
    }

    pw1.onkeyup = function() {

    var lowerCaseLetters = /[a-z]/g;
        if(pw1.value.match(lowerCaseLetters)) {
            letter.classList.remove("invalid");
            letter.classList.add("valid");
        } else {
            letter.classList.remove("valid");
            letter.classList.add("invalid");
        }

        var numbers = /[0-9]/g;
        if(pw1.value.match(numbers)) {
            number.classList.remove("invalid");
            number.classList.add("valid");
        } else {
            number.classList.remove("valid");
            number.classList.add("invalid");
        }

    if(pw1.value.length >= 8 && pw1.value.length <= 15) {
            length.classList.remove("invalid");
            length.classList.add("valid");
        } else {
            length.classList.remove("valid");
            length.classList.add("invalid");
        }

        if(pw1 == pw2)  
        {   
            igual.classList.remove("invalid");
            igual.classList.add("valid");
        } else {
            igual.classList.remove("valid");
            igual.classList.add("invalid");
        }
}</script>
</body>
</html>