<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
   "http://www.w3.org/TR/html4/loose.dtd">

<html lang="en">
	<head>
		<title></title>
	</head>
	<body>
		<?php
			require_once("practice2.php");
			
			$errors = array();
			
			$username = trim("");
			
			if (!has_presense($username)) {
				$errors["username"] = "Username can't be blank";
			}
		?>	 <?php echo form_errors($errors); ?>
		
		
	</body>
</html>
