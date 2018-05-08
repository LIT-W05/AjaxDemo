$(() => {
    $("#email").on('blur', function () {
        const emailFromTextbox = $("#email").val();

        $.get('/home/isavailable', { email: emailFromTextbox }, function (obj) {
            if (obj.Available) {
                $("#available").show();
                $("#unavailable").hide();
            } else {
                $("#available").hide();
                $("#unavailable").show();
            }
        });

    });
});


const obj = {
    name: 'Avrumi',
    age: 36,
    address: '139 Melissa',
    cars: ['Minivan', 'Not minivan']
}