<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
   "http://www.w3.org/TR/html4/loose.dtd">

<html lang="en">
	<head>
		<title>untitled</title>
	</head>
	<body>
	
	<?php
	
		$word1 = "Hello";
		$word2 ="World";
		
		echo $word1," ",$word2."!";
	?>
	</br>
	</br>
		<?php 
		$filmName = "";
		$rating = "";
		function film_ratings($filmName, $rating) {
			if ($rating == 10) {
				echo "<b>{$filmName}</b> is a <u>MUST SEE</u>!</br>"; 
			} elseif ($rating >= 6) {
				echo "<b>{$filmName}</b> is Really Good.</br>";
			} elseif ($rating == 5) {
				echo "<b>{$filmName}</b> is OK.</br>";
			} elseif ($rating == 3) {
				echo "<b>{$filmName}</b> is pretty bad.</br>";
			} elseif ($rating === 1) {
				echo "<b>{$filmName}</b> is goddamn horrible!</br>";
			}
	}
	
		film_ratings("Jaws", 10);
		film_ratings("Event Horizon", 9);
		film_ratings("The Ice Harvest", 6);
		film_ratings("God Bless America", 5);
		film_ratings("Pandorum", 3);
		film_ratings("Noah", 1);		
	?>
	</br>
	<?php
		$month_year = 11;
		switch ($month_year) {
			
			case  0: $month = "January";	break;
			case  1: $month = "February";	break;
			case  2: $month = "March";		break;
			case  3: $month = "April";		break;
			case  4: $month = "May";		break;
			case  5: $month = "June";		break;
			case  6: $month = "July";		break;
			case  7: $month = "August";		break;
			case  8: $month = "September";	break;
			case  9: $month = "October";	break;
			case 10: $month = "November";	break;
			case 11: $month = "December";	break;
		}
		echo "It is {$month}";
	?>
	</br>
	</br>
	<?php
		switch ($month_year) {
			case  0: $greeting = " welcomes you."; 			break;
			case  1: $greeting = " is for lovers.";			break;
			case  2: $greeting = ", I hardly remember thee."; 	break;
			case  3: $greeting = ", you fools!"; 			break;
			case  4: $greeting = " the force be with you."; break;
			case  5: $greeting = " rhymes with balloon."; 	break;
			case  6: $greeting = " means less fingers."; 	break;
			case  7: $greeting = " beckons the end of summer."; 	break;
			case  8: $greeting = " is my birthday."; 		break;
			case  9: $greeting = " is when the ghosts come out."; 	break;
			case 10: $greeting = ", synonymous with gluttony."; break;
			case 11: $greeting = " "; 		break;
		}
		echo "{$month}{$greeting}";
	?>
	</body>
</html>
