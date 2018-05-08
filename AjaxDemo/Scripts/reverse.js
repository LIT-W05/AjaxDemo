$(() => {
    $("#reverse-button").on('click', function() {
        $.post('/home/reverse', { text: $("#original").val()}, function(obj) {
            $("#output").val(obj.ReversedText);
        });
    });
})