
<?php

include_once( "func.rootpath.php"   );
$approot = rootpath( 0 );

/**
 * 加载 
 * 
 * 感觉不习惯。如不是为了使用 spreadsheet ，不想学加载。
 */
include_once( "autoloader.php"     );

/***
 * 总感觉在 PHP 中使用 namespace 别扭。
 */
$filepaths = new FilePath();
$filepaths->AutoLoading( $approot . "/classhome/" );

// return;

use 	PhpOffice\PhpSpreadsheet\Spreadsheet;
use 	PhpOffice\PhpSpreadsheet\Writer\Xlsx;

$spreadsheet = new Spreadsheet();

$sheet = $spreadsheet->getActiveSheet();

$sheet->setCellValue( 'A1', 'Hello World !' );

$writer = new Xlsx( $spreadsheet );

$writer->save( 'hello world.xlsx' );

?>