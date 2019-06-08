
<?php

class Person 
{
	/**
	 * blood color;
	 */
    public static 	$BColor;
    
    public 			$Name;
    
	protected 		$Age;
}

$reflection = new ReflectionClass( 'Person' );

$reflection->getProperty( 	'BColor' 	)
		   ->setValue( 		'red' 		);


$engineer = new Person;

$reflection->getProperty( 	'Name'					)
		   ->setValue(		$engineer, 'wolfgang'	);


$reproperty = $reflection->getProperty( 'Age' );
$reproperty->setAccessible( true );
$reproperty->setValue(	$engineer, 34	);

var_dump( Person::$BColor 						);
echo "<br>";

var_dump( $engineer->Name						);
echo "<br>";

var_dump( $reproperty->getValue( $engineer ) 	);
echo "<br>";

?> 