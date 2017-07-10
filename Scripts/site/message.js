$('#Save').click(function () {

    var form = $("#emailForm");
    $(form).validate();
    if (form.valid()) {
        $("#ajax_loader").show();
        $("#result").html("Sending message. Please wait");
        var url = form.attr("action");
        var formData = form.serialize();
        $.post(url, formData, function (data) {
            $("#result").html(data);
            $("#ajax_loader").hide();
        });
    } else {
        $("#result").html("Missing values. Please fill out the form correctly.");
    }
});