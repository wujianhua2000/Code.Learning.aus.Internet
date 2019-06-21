
<?php

/***...........................................................................
 * rev. 1
 * 2019-05-10， 9:50， 吴建华。天安数码城 601。
 * 
 * 一直困扰于代码之间的相互 include 。
 * 由于 PHP APP 没有实际意义的上的根目录，很多人使用了下面的这些技术
 *      __FILE__
 *      dirname( __FILE__ ) 
 *      $_SERVER[ "DOCUMENT_ROOT" ]
 * 
 * 但是结果并不理想。
 * 
 * 我的办法：
 * 
 * 在项目的根目录，建立本文件。
 * 每一个需要引用其他文件的代码都首先 include 本文件。
 * 
 * $root = rootpath( 1 );
 * 
 * 将会返回项目的根目录。
 * 
 * $upsnum 向上追溯的层数。即是回退多少层是项目的根目录。
 * 
 */
function rootpath( $upsnum )
{
    $approot =  realpath( "./" );

    $listing =  explode( "\\", $approot );

    for ( $idx = 0; $idx < $upsnum; $idx++ )    {      array_pop( $listing );       }

    return      implode( "\\", $listing );
}

/***...........................................................................
 * 
 */

?>