
$( "#gender" ).on( "change", function() {
	
	$.ajax( {
		type		: "POST",
		data		: {	"gender": $( "#gender"	).val()		},
		url			: "response.php",
		dataType	: "json",
		success		: function( resultJSON ) {

			var peopleHTML = "";

			// Loop through Object and create peopleHTML
			for ( var key in resultJSON ) {

				if (resultJSON.hasOwnProperty( key ) ) {
					peopleHTML += "<tr>";
					peopleHTML += "<td>" + resultJSON[ key ][ "name"	] + "</td>";
					peopleHTML += "<td>" + resultJSON[ key ][ "gender"	] + "</td>";
					peopleHTML += "</tr>";
				}

			}

			//	Replace table’s tbody html with peopleHTML
			//
			$( "#people tbody" ).html( peopleHTML );
		}
		//	END:::	success		: function(resultJSON) {
		//
	} );
	//	END:::	$.ajax(
	//
});
