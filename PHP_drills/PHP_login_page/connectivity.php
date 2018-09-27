<?php
	// 1. Create a database connection 
	/* $dbhost = "localhost";
	$dbuser = "admin";
	$dbpass = "password";
	$dbname = "login"; */
	
	define("DB_HOST", "localhost");
	define("DB_NAME", "login");
	define("DB_USER","admin");
	define("DB_PASSWORD","password");
	// $connection = mysqli_connect($dbhost, $dbuser, $dbpass, $dbname);
	
	$con = mysqli_connect(DB_HOST,DB_USER,DB_PASSWORD,DB_NAME) or die ("Failed to connect to MySQL: " . mysqli_error());
	// $db = mysqli_select_db(DB_NAME,$con) or die ("Failed to connect to MySQL: " . mysqli_error());


	// Test if connection occurred
/*	if(mysqli_connect_errno()) {
		die("Database connection failed: " .
		mysqli_connect_error() .
		"(" . mysqli_connect_errno() . ")"
		);
	}
	*/
function SignIn()
 { 
session_start(); //starting the session for user profile page 
if(!empty($_POST['user'])) //checking the 'user' name which is from Sign-In.html, is it empty or have some text 
{ 
$query = mysqli_query("SELECT * FROM UserName where userName = '$_POST[user]' AND pass = '$_POST[pass]'") or die (mysqli_error()); 
$row = mysqli_fetch_array($query) or die (mysqli_error()); 
if(!empty($row['userName']) AND !empty($row['pass'])) 
{ 
$_SESSION['userName'] = $row['pass']; 
echo "SUCCESSFULLY LOGIN TO USER PROFILE PAGE..."; 
} 
else 
{ echo "SORRY... YOU ENTERD WRONG ID AND PASSWORD... PLEASE RETRY..."; 
} 
	} 
} 
if(isset($_POST['submit'])) 
{ 
	SignIn(); 
	
	} 

?>


<?php /*
	// 2. Perform database query
	$query = "SELECT * ";
	$query .= "FROM username ";
	$query .= "Where userName = 'Admin' ";
	$query .= "ORDER BY UserNameID ASC";
	
	
	$result = mysqli_query($connection, $query);
	// Test if ther ewas a query error
	if (!$result) {
		die("Database query failed.");
	}
*/
	?> 

<?php /*
<!DOCTYPE html>

<html lang="en">
	<head>
		<title>Databases</title>
	</head>
	<body>
	
	
<ul>
	*/ 
	?>
	<?php
	/*
	// 3. Use return data is any
	while($subject = mysqli_fetch_assoc($result)) {
		// Output data from each row
	?>
		<li><?php echo $subject["userName"]; ?></li>
	<?php
	}	
*/
	?>
	
	<?php
	/*
	// 4. Release returned data
	mysqli_free_result($result);
*/	?>
	

<?php 
// 5. close database connection
mysqli_close($con);
?>