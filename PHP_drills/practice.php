<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
   "http://www.w3.org/TR/html4/loose.dtd">

<html lang="en">
	<head>
		<title> Practice </title>
	</head>
	<body>
	
		
	 <?php 
		 
		 $errors = array();
		 
		function form_errors($errors=array()) {
			$output = "";
			if (!empty($errors)) {
				$output .= "<div class=\"error\">";
				$output .= "Please fix the following errors:";
				$output .= "<ul>";
				foreach ($errors as $key => $error) {
					$output .= "<li>{$error}</li>";
				}
				$output .= "</ul>";
				$output .= "</div>";
			}
			return $output;
		}	
	?>
		</br>
	
	 <?php
		echo form_errors($errors);
		
	
	?>	
		</br>
	 <?php 
		
		
	?>
		</br>
		<?php 
			
	?>
	</pre>
	</body>
</html>