<?php

//	https://www.cinemablend.com/new/10-Most-Popular-Movie-Stars-World-According-Fandango-68913.html

//	 Here is the complete list of the fan favorite movie stars who will be toplining 2015 movies:

$listing = array();

//	改写的添加数据行。
//	"<u><b>Actresses</b></u><br />																							 ",	
$listing[] = array("gender" => "F", "name" => "<b>1. Jennifer Lawrence</b> ", 	"works" => "(<i>The Hunger Games: Mockingjay - Part 2</i>, <i>Joy</i>)" );
$listing[] = array("gender" => "F", "name" => "<b>2. Scarlett Johansson</b> ", 	"works" => "(<i>Avengers: Age of Ultron</i>)" );
$listing[] = array("gender" => "F", "name" => "<b>3. Angelina Jolie</b> ", 		"works" => "(<i>By the Sea</i>)" );
$listing[] = array("gender" => "F", "name" => "<b>4. Melissa McCarthy</b> ", 	"works" => "(<i>Spy</i>)" );
$listing[] = array("gender" => "F", "name" => "<b>5. Halle Berry</b> ", 		"works" => "(<i>Kidnap</i>)" );

//	"<br /><br />                                                                                                            ",
//	"<u><b>Actors</b></u><br />                                                                                              ",
$listing[] = array("gender" => "M", "name" => "<b>1. Robert Downey Jr.</b> ", 	"works" => "(<i>Avengers: Age of Ultron</i>)" );
$listing[] = array("gender" => "M", "name" => "<b>2. Chris Hemsworth</b> ", 	"works" => "(<i>Avengers: Age of Ultron</i>, <i>Blackhat</i>, <i>In the Heart of the Sea</i>)" );
$listing[] = array("gender" => "M", "name" => "<b>3. Daniel Craig</b> ", 		"works" => "(<i>Spectre</i>)" );
$listing[] = array("gender" => "M", "name" => "<b>4. Chris Pratt</b> ", 		"works" => "(<i>Jurassic World</i>)" );
$listing[] = array("gender" => "M", "name" => "<b>5. Tom Cruise</b> ", 			"works" => "(<i>Mission: Impossible 5</i>)"	);
			
echo json_encode( $listing );

?>
