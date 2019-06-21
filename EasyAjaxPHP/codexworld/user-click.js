
$( document ).ready( function() {

    $( '#getUser' ).on( 'click', function() { 
	
        var user_id = $( '#user_id' ).val();

        $.ajax( {
            type		:	'POST',
            url			:	'getData.php',
            dataType	: 	"json",
            data		:	{ user_id : user_id },
        
			success		:	function( data ) {
			
                if ( data.status == 'ok' ) {
                    $( '#userName'		).text( data.result.name	);
                    $( '#userEmail'		).text( data.result.email	);
                    $( '#userPhone'		).text( data.result.phone	);
                    $( '#userCreated'	).text( data.result.created	);
                    $( '.user-content'	).slideDown();
                }
                else{
                    $( '.user-content'	).slideUp();
                    alert( "User not found..." );
                } 
                //  END:::if ( data.status == 'ok' ) {
                //
            }
			// END:::  success
			//
        });
		//  END:::  $.ajax( {
        //
    });

});
