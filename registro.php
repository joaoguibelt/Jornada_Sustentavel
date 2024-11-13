<?php
	$con = mysqli_connect('localhost','cone8757_conex','.]f64xpS40','cone8757_conex'); //(endereco do banco, username, senha, nome do banco)

	//checkar se a conexao aconteceu
	if(mysqli_connect_errno()){
		echo "1 - conexao falha"; 
		exit();
	}


	$nome = $_POST["nome"];
	$email = $_POST["email"];
	$genero = $_POST["genero"];
	$pontosEu = intval($_POST["pontosEu"]);
	$pontosFamilia = intval($_POST["pontosFamilia"]);
	$pontosTrabalho = intval($_POST["pontosTrabalho"]);
	$pontosSociedade = intval($_POST["pontosSociedade"]);
	$venceu = $_POST["ganhou"];
	$ganhou = false;
	//checkar se email já existe

	$emailcheckquery = "SELECT user_email FROM conex_quiz_users WHERE user_email='" . $email . "';";

	$emailcheck = mysqli_query($con, $emailcheckquery) or die("2 - check de email falhou");

	if(mysqli_num_rows($emailcheck) > 0){
		echo "3 - email ja existe";
		exit();
	}

	//botar o venceu em boleano

	if($venceu == "true"){
		$ganhou = true;
	}
	else{
		$ganhou = false;
	}

	$ganhou = $ganhou ? 1 : 0;

	//adicionar o usuario
	$insertuserquery = "INSERT INTO conex_quiz_users (user_name, user_email, user_genero, user_acertos_eu, user_acertos_familia, user_acertos_trabalho, user_acertos_sociedade, user_venceu) VALUES ('$nome', '$email', '$genero', $pontosEu, $pontosFamilia, $pontosTrabalho, $pontosSociedade, $ganhou);";
	mysqli_query($con, $insertuserquery) or die("6 - insert falhou");

	echo("0");
	mysqli_close($con);
?>