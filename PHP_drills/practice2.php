<?php 
		$name = "test";
		$value = "hello";
		$expire = time() + (60*60*24*7*4); // add seconds
		//setcookie($name, $value, $expire);
		
		setcookie($name, null);
		
	
	?>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
   "http://www.w3.org/TR/html4/loose.dtd">

<html lang="en">
	<head>
		<title> Practice </title>
	</head>
	<body>
	
	 <?php
		
		$test = $_COOKIE["test"];
		echo $test;
	
	?>	
		
		</br>
	 <?php 
		
		
	?>
		</br>
		<?php 
			
	?>
	</body>
</html>