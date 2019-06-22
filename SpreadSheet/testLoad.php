
<?php

include_once( "func.rootpath.php"   );
$approot = rootpath( 0 );

include_once( "autoloader.php"     );

/***
 * 总感觉在 PHP 中使用 namespace 别扭。
 */
$filepaths = new FilePath();
$filepaths->AutoLoading( $approot . "/classhome/" );

//use PhpOffice\PhpSpreadsheet\Helper\Sample;

use     PhpOffice\PhpSpreadsheet\IOFactory;
use     PhpOffice\PhpSpreadsheet\Spreadsheet;
use 	PhpOffice\PhpSpreadsheet\Writer\Xlsx;

// require_once __DIR__ . '/../../src/Bootstrap.php';
// $helper = new Sample();
// if ($helper->isCli()) {
//     $helper->log('This example should only be run from a Web Browser' . PHP_EOL);
//     return;
// }

// Create new Spreadsheet object
$spreadsheet = new Spreadsheet();

// // Set document properties
// $spreadsheet->getProperties()
//             ->setCreator('Maarten Balliauw')
//             ->setLastModifiedBy('Maarten Balliauw')
//             ->setTitle('Office 2007 XLSX Test Document')
//             ->setSubject('Office 2007 XLSX Test Document')
//             ->setDescription('Test document for Office 2007 XLSX, generated using PHP classes.')
//             ->setKeywords('office 2007 openxml php')
//             ->setCategory('Test result file');

// Add some data
$spreadsheet->setActiveSheetIndex(0)
            ->setCellValue('A1', 'Hello')
            ->setCellValue('B2', 'world!')
            ->setCellValue('C1', 'Hello')
            ->setCellValue('D2', 'world!');

// // Miscellaneous glyphs, UTF-8
// $spreadsheet->setActiveSheetIndex(0)
//             ->setCellValue('A4', 'Miscellaneous glyphs')
//             ->setCellValue('A5', 'éàèùâêîôûëïüÿäöüç');

// Rename worksheet
$spreadsheet->getActiveSheet()
            ->setTitle( 'Simple' );

// Set active sheet index to the first sheet, so Excel opens this as the first sheet
$spreadsheet->setActiveSheetIndex(0);

$writer = new Xlsx( $spreadsheet );
$writer->save( 'hello-world.xlsx' );
// return;

/***
// // Redirect output to a client’s web browser (Xlsx)
// header( 'Content-Type: application/vnd.openxmlformats-officedocument.spreadsheetml.sheet'   );
// header( 'Content-Disposition: attachment;filename="01simple.xlsx"'                          );

// Redirect output to a client’s web browser (Xls)
header('Content-Type: application/vnd.ms-excel');
header('Content-Disposition: attachment;filename="01simple.xls"');

header( 'Cache-Control: max-age=0'                                                          );
// // If you're serving to IE 9, then the following may be needed
// header( 'Cache-Control: max-age=1'                                                          );

// If you're serving to IE over SSL, then the following may be needed
header( 'Expires: Mon, 26 Jul 1997 05:00:00 GMT'                                            );  // Date in the past
header( 'Last-Modified: ' . gmdate( 'D, d M Y H:i:s' ) . ' GMT'                             );  // always modified
header( 'Cache-Control: cache, must-revalidate'                                             );  // HTTP/1.1
header( 'Pragma: public'                                                                    );  // HTTP/1.0

// $writer = IOFactory::createWriter( $spreadsheet, 'Xlsx' );
// $writer->save( 'php://output' );

$writer = IOFactory::createWriter($spreadsheet, 'Xls');
$writer->save('php://output');
*/

/***
 html的实现

<head>
<!-- 以下方式定时转到其他页面 -->
<meta http-equiv="refresh" content="5;url=hello.html"> 
</head> 

优点：简单
缺点：Struts Tiles中无法使用

 

2) javascript的实现

<script language="javascript" type="text/javascript"> 

// 以下方式直接跳转
window.location.href='hello.html';

</script> 

*/

$linkpage = "hello-world.xlsx";

echo "<head>";
echo "<meta http-equiv=\"refresh\" content=\"1;url=$linkpage\">";
echo "</head>";

// echo '<script language="javascript" type="text/javascript">';
// // 以下方式直接跳转
// echo "window.location.href=$linkpage";
// echo '</script>';

exit;
