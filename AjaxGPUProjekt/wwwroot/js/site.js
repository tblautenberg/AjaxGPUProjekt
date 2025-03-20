$(document).ready(function () {
    $("form")[0].reset();
});


function AjaxPost(button) {
    var model = $(button).closest("form").find("input[name='model']").val();
    var producent = $(button).closest("form").find("input[name='producent']").val();
    var pris = $(button).closest("form").find("input[name='pris']").val();
    var vram = $(button).closest("form").find("input[name='vram']").val();

    var gpu =
    {
        model,
        producent,
        pris,
        vram
    };

    $.ajax({
        type: "POST",
        url: "/Gpu",
        data: gpu,
        success: function (response) {
            location.reload();
        },
        failure: function (response) {
            alert(response);
        }
    })
}

function AjaxGet() {

}

function AjaxEdit(button) {
    var row = $(button).closest("tr");

    var id = row.find("#id").text();
    var model = row.find("#model").text();
    var producent = row.find("#producent").text();
    var pris = row.find("#pris").text();
    var vram = row.find("#vram").text();

    var form = $("form").first();
    form.find("input[name='id']").val(id);
    form.find("input[name='model']").val(model);
    form.find("input[name='producent']").val(producent);
    form.find("input[name='pris']").val(pris);
    form.find("input[name='vram']").val(vram);

    var actionBtn = form.find("button[name='action']");
    actionBtn.attr("onclick", "AjaxPut(this)");
    actionBtn.text("Save changes!");
}

function AjaxPut(button) {
    var id = $(button).closest("form").find("input[name='id']").val();
    var model = $(button).closest("form").find("input[name='model']").val();
    var producent = $(button).closest("form").find("input[name='producent']").val();
    var pris = $(button).closest("form").find("input[name='pris']").val();
    var vram = $(button).closest("form").find("input[name='vram']").val();

    var gpu =
    {
        id,
        model,
        producent,
        pris,
        vram
    };

    var form = $("form").first();
    var actionBtn = form.find("button[name='action']");

    $.ajax({
        type: "PUT",
        url: "/Gpu",
        data: gpu,
        success: function (response) {
            actionBtn.attr("onclick", "AjaxPost(this)");
            actionBtn.text("Create Gpu!");

            location.reload();
        },
        failure: function (response) {
            actionBtn.attr("onclick", "AjaxPost(this)");
            actionBtn.text("Create Gpu!");

            alert(response);
        }
    })
}

function AjaxDelete(button) {
    var row = $(button).closest("tr");
    var id = row.find("#id").text();

    $.ajax({
        type: "DELETE",
        url: "/Gpu/" + id,
        data: id,
        success: function (response) {
            location.reload();
        },
        failure: function (response) {
            alert(response);
        }
    })
}