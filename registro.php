<?php
	$con = mysqli_connect('50.116.112.135','cone8757_conex','.]f64xpS40','cone8757_conex'); //(endereco do banco, username, senha, nome do banco)

	//checkar se a conexao aconteceu
	if(mysqli_connect_errno()){
		echo "1 - conexao falha"; 
		exit();
	}


	$nome = $_POST["nome"];
	$email = $_POST["email"];
	$genero = $_POST["genero"];
	$pontos = $_POST["pontos"];

	//checkar se email já existe

	$emailcheckquery = "SELECT email FROM players WHERE email='" . $email . "';";

	$emailcheck = mysqli_query($con, $emailcheckquery) or die("2 - check de email falhou");

	if(mysqli_num_rows($emailcheck) > 0){
		echo "3 - email ja existe";
		exit();
	}

	//adicionar o usuario
	$insertuserquery = "INSERT INTO conex_quiz_users (user_name,user_email,user_genero,user_acertos) VALUES ('" . $nome . "', '" . $email . "', '" . $genero . "', ' . $pontos . ');";
	mysqli_query($con, $insertuserquery) or die("6 - insert falhou");

	echo("0");
?>