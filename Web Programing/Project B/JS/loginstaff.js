const btn =document.getElementById("aceitar");

    btn.addEventListener("click", validate);

    function validate(){
        if(   document.getElementById("nome").value == "admin" && document.getElementById("pwd").value == "ADMIN" )
        {
            alert( "validation succeeded" );
            location.href="imprimir.php";
        }
        else
        {
            alert( "validation failed" );
        }
    }