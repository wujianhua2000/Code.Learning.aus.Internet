
$( "#gender" ).on( "change", function() {
	
	$.ajax( {
		type		: "POST",
		data		: {	"gender": $( "#gender"	).val()		},
		url			: "response.php",
		dataType	: "json",
		success		: function( resultJSON ) {

			var starHTML = "";
			var sex = "";

			// Loop through Object and create starHTML
			for ( var key in resultJSON ) {

				if (resultJSON.hasOwnProperty( key ) ) {
					sex = resultJSON[ key ][ "gender"	];

					starHTML += "<b>" 	+ resultJSON[ key ][ "name"	] + "</b>";
					starHTML += "   ("  + resultJSON[ key ][ "shows"	] + ")";
					starHTML += "<br />";
				}
			}
			
			var title = "<u><b>" ;
			
			if (sex == "M" ) title = title + "Actors"  		+ "</b></u> <br /> ";
			if (sex == "F" ) title = title + "Actresses" 	+ "</b></u> <br /> ";

			//	Replace table’s tbody html with starHTML
			//
			$( "#container" ).html( title + starHTML );
		}
		//	END:::	success		: function(resultJSON) {
		//
	} );
	//	END:::	$.ajax(
	//
});
