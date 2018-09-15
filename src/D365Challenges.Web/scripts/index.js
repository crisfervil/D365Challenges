var SERVER_URL = "http://localhost:7071";

$(document).ready(function () {

	$.ajax({
		url: SERVER_URL + "/api/GetChallenges",
		success: GetChallenges_success
	});

});

function GetChallenges_success(challenges) {

	for (var i = 0; i < challenges.length; i++) {
		var challenge = challenges[i];
		$('#challengeSelector').append($('<option>', { value: challenge, text: challenge }));
	}

	if (challenges.length > 0) {
		//$('#challengeSelector').find('option:eq(1)').prop('selected', true); 
	}
}