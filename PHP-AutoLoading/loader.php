
<?php

include_once( "func.rootpath.php" );

$incpath = get_include_path();

$pathname = rootpath( 0 ) .  '\\models\\' ;
set_include_path( get_include_path() . ";" . $pathname );

$pathname = rootpath( 0 ) . '\\classes\\'    ;
set_include_path( get_include_path() . ";" . $pathname );

/**
 * 
 */
function loadKlazz( $class )
{
    include_once( $class . '.php' );
}
   
spl_autoload_register( 'loadKlazz' );

$home = new classes\home();

echo $home->get() . "<br/>";

// $home = new views\home();
// echo $home->get(). <br>;

$home = new models\home();

echo $home->get() . "<br/>";

$all = new classes\all();

echo $all->get() . "<br/>";

// $all = new views\all();
// echo $all->get(). "<br/>";

$all = new models\all();

echo $all->get() . "<br/>";

echo "<hr/>";

echo get_include_path() . "<br/>";


