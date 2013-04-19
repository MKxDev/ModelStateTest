$(document).ready(function() {
    $('#testIt').click(function() {
        var person = {
            Name: $('#Name').val(),
            Address: {
                Address1: $('#Address_Address1').val(),
                Address2: $('#Address_Address2').val()
            }
        };

        $.ajax({
            type: 'POST',
            url: '/',
            contentType: 'application/json',
            data: JSON.stringify(person),
            success: function (data) {
                // DEBUG
                console.log('Something came back: ', data);
            },
            dataType: 'json'
        });
    });
});