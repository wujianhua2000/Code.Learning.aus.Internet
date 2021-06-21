
$( document ).ready( function(){
	
    $.ajax({
        url			: 'ajaxfile.php'	,
        type		: 'get'				,
        dataType	: 'JSON'			,
		
        success		: function( response ) {
            var len = response.length;
			
            $( "#container" ).append( "<u><b>Actresses</b></u><br />" );
            for ( var i = 0; i < len; i ++ ) {
                var gender	= response[ i ].gender;
                var name 	= response[ i ].name;
                var work 	= response[ i ].works;

                if ( gender == "F" ) $( "#container" ).append( name + work + "<br />" );
            }

            $( "#container" ).append( "<br />" );
            $( "#container" ).append( "<u><b>Actors</b></u><br />" );
            
            for ( var i = 0; i < len; i ++ ) {
                var gender	= response[ i ].gender;
                var name 	= response[ i ].name;
                var work 	= response[ i ].works;

                if ( gender == "M" ) $( "#container" ).append( name + work + "<br />" );
            }
            $( "#container" ).append( "<br />" );
        }
        //	END::	success	
		//
    });
    //	$.ajax({
	//
});

