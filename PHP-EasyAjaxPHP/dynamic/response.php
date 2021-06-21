

<?php

	//	https://www.cinemablend.com/new/10-Most-Popular-Movie-Stars-World-According-Fandango-68913.html

	//	 Here is the complete list of the fan favorite movie stars who will be toplining 2015 movies:

	$listing = array();

	$listing[] = array( "gender" => "F", "name" => "1. Jennifer Lawrence", 	"works" => array( "The Hunger Games: Mockingjay - Part 2", 
																							  "Joy" ) );
	
	$listing[] = array( "gender" => "F", "name" => "2. Scarlett Johansson", "works" => array( "Avengers: Age of Ultron" ) );
	$listing[] = array( "gender" => "F", "name" => "3. Angelina Jolie", 	"works" => array( "By the Sea" 				) );
	$listing[] = array( "gender" => "F", "name" => "4. Melissa McCarthy", 	"works" => array( "Spy" 					) );
	$listing[] = array( "gender" => "F", "name" => "5. Halle Berry", 		"works" => array( "Kidnap" 					) );
						
	$listing[] = array( "gender" => "M", "name" => "1. Robert Downey Jr.", 	"works" => array( "Avengers: Age of Ultron" ) );
	
	$listing[] = array( "gender" => "M", "name" => "2. Chris Hemsworth", 	"works" => array( "Avengers: Age of Ultron", 
																							  "Blackhat", 
																							  "In the Heart of the Sea" ) );
																							  
	$listing[] = array( "gender" => "M", "name" => "3. Daniel Craig", 		"works" => array( "Spectre" 				) );
	$listing[] = array( "gender" => "M", "name" => "4. Chris Pratt", 		"works" => array( "Jurassic World" 			) );
	$listing[] = array( "gender" => "M", "name" => "5. Tom Cruise", 		"works" => array( "Mission: Impossible 5"	) );

	//	Get POST gender value
	$gender = $_POST[ "gender"	];

	if ( $gender == "" )	$gender = 'M';
	
	// Create empty array to hold query results
	$starlist = [];

	foreach( $listing as $star )
	{
		if ( $gender != $star[ "gender" ] ) continue;
		
		$shows = "";
		foreach( $star["works"] as $movie ) $shows = $shows . "<i>" . $movie . "</i> ; &nbsp; ";

		array_push( $starlist, 	[ 	"gender" 	=> $gender, 
									"name" 		=> $star[ "name" ], 
									"shows" 	=> $shows  
								] 
								);
	}

	$starsJSON = json_encode( $starlist );
	echo $starsJSON;

?>
