
<?php

/****
 * 使用 PATHINFO 函数的时候，文件没有扩展名的时候，返回的 array  内不包含 extension 键。
 */


include_once( "func.rootpath.php" );

$approot = rootpath( 0 );

$newNAME =  $approot . "/files/miss-extn";

$fileinfos 	= pathinfo( $newNAME );

//print_r( $fileinfos );
foreach( $fileinfos as $key => $value )   echo "$key => $value <br/>";

echo "<hr/>";

$newNAME =  $approot . "/files/hello.txt";

$fileinfos 	= pathinfo( $newNAME );

foreach( $fileinfos as $key => $value )   echo "$key => $value <br/>";
//print_r( $fileinfos );

?>