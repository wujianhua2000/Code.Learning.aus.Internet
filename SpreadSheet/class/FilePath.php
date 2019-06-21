
<?php

/***
 * sample7_11.php
 */
class FilePath
{
	/***
	 * 
	 */
	private $pathlisting = array();

	/***
	 * 
	 */
	private $filelisting = array();

	/***.......................................................................
	 * We then call the function pointed to the directory we want to look through.
	 */
	public function SeekingPath( $thedir ) 
	{
		/**
		 * First, we ensure that the directory exists.
		 */
		$notPATH= ( ! is_dir ( $thedir ) );
		if ( $notPATH ) return;

		/**
		 * Now, we scan the files in this directory using scandir.
		 */
		$scanarray = scandir( $thedir );
		
		/**
		 * 临时存储当前目录下的子目录。
		 */
		$result = array();

		/**
		 * Then we begin parsing the array.
		 * Since scandir() counts the "." and ".." file navigation listings
		 * as files, we should not list them.
		 */
		for ( $i = 0; $i < count( $scanarray ); $i++ )
		{
			if ( $scanarray[ $i ] == "."  	) continue;
			if ( $scanarray[ $i ] == ".."  	) continue;

			/***
			 * Now, we check to make sure this is a file, and not a directory.
			 */
			$newNAME 	= $thedir . "/" . $scanarray[ $i ];
			$thisPATH 	= ( is_dir(  $newNAME ) );

			if ( $thisPATH ) $this->pathlisting[] 	= $newNAME;
			if ( $thisPATH ) $result[] 				= $newNAME;
		}

		foreach( $result as $pname ) $this->SeekingPath( $pname );

		return;
	}

	/***.......................................................................
	 * 
	 */
	private function SeekingPHP( $thedir )
	{
		$notPATH= ( ! is_dir ( $thedir ) );
		if ( $notPATH ) return;

		$scanarray = scandir( $thedir );

		for ( $i = 0; $i < count( $scanarray ); $i++ )
		{
			if ( $scanarray[ $i ] == "."  	) continue;
			if ( $scanarray[ $i ] == ".."  	) continue;

			$newNAME 	= $thedir . "/" . $scanarray[ $i ];
			$thisFILE 	= ( is_file(  $newNAME ) );
			if ( ! $thisFILE 				) continue;

			$fileinfos 	= pathinfo( $newNAME );

			$hasEXTN = array_key_exists( "extension", $fileinfos );
			if ( ! $hasEXTN 				) continue;

			$fileextn 	= strtoupper( $fileinfos[ 'extension' ] );

			if ( $fileextn != "PHP" 		) continue;

			$this->filelisting[] 	= $newNAME;
		}

		return;
	}

	/***.......................................................................
	 * 
	 */
	public function AutoLoading( $thedir )
	{
		$notPATH= ( ! is_dir ( $thedir ) );
		if ( $notPATH ) return;

		$this->pathlisting[] = $thedir;

		$this->SeekingPath( $thedir );

		foreach( $this->pathlisting as $pname )
		{
			set_include_path( get_include_path() . ";" . $pname );
		}

		spl_autoload_register( function( $class ) { include_once( $class . '.php' ); } );

		// foreach( $this->pathlisting as $pname ) $this->SeekingPHP( $pname );
		// foreach( $this->filelisting as $fname ) include_once( $fname );
		// foreach( $this->filelisting as $fname ) echo "include once :: " . $fname . "<br/>";

		return;
	}

	/***.......................................................................
	 * 
	 */
	public function Test()
	{
		foreach( $this->pathlisting as $pname ) echo $pname . "<br />";
		return;
	}

	/**
	 * 
	 */
}

?>