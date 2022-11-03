$(function () {

    var Id = parseInt($("#txtId").val());
    if (Id !== 0) {
        Get(Id);
    };
    $('#btnSave').click(function () {
        var model = {
            ColorId: parseInt($('#txtId').val()),
            Name: $('#txtColorName').val(),
        };
        if (model.ColorId === 0) {
            Add(model);
        } else {
            Update(model);
        }
    });
})

function Get(id) {
    $.ajax({
        url: '/admin/colors/colorGet/',
        typr: "GET",
        dataType: "json",
        data: { id: id },
        beforeSend: function () {
            $.LoaderOpen({ selector: ".card-body" });
        },
        success: function (result) {
            if (result.ResponseType === 2) {
                $('#txtId').val(result.Data.ColorId);
                $('#txtColorName').val(result.Data.Name); 
            }
            else {
                Swal.fire({
                    position: 'center',
                    icon: 'warning',
                    title: systemMessage.warningTitle(),
                    text: result.Message,
                    showConfirmButton: true,
                });
                return;
            }
        },
        complete: function () {
            $.LoaderClose({ selector: ".card-body" });
        },
        error: function (errormessage) {
            Swal.fire({
                position: 'center',
                icon: 'error',
                title: systemMessage.errorTitle(),
                text: errormessage,
                showConfirmButton: true,
            });
        }
    });
    return false;
}

function Update(model) { 
    var valid = FormValidation();
    if (valid === false)
        return;

    $.ajax({
        url: '/admin/colors/colorSave/',
        type: 'POST',
        data: model,
        beforeSend: function () {
            $.LoaderOpen({ selector: ".content" });
            $("#btnSave").addClass("disabled");
        },
        success: function (result) {
            if (result.ResponseType === 2) {
                Swal.fire({
                    position: 'center',
                    icon: 'success',
                    title: systemMessage.successTitle(),
                    text: result.Message,
                    showConfirmButton: true
                }).then((result) => {
                    if (result.isConfirmed) {
                        window.location.href = "/admin/colors/Index/";
                    }
                });
            }
            else {
                Swal.fire({
                    position: 'center',
                    icon: 'warning',
                    title: systemMessage.warningTitle(),
                    text: result.Message,
                    showConfirmButton: true
                });
                return;
            }
        },
        complete: function () {
            $.LoaderClose({ selector: ".content" });
            $("#btnSave").removeClass("disabled");
        },
        error: function (errormessage) {
            Swal.fire({
                position: 'center',
                icon: 'error',
                title: systemMessage.errorTitle(),
                text: errormessage,
                showConfirmButton: true
            });
        }
    });
}


function Add(model) {

    var valid = FormValidation();
    if (valid === false)
        return;

    $.ajax({
        url: '/admin/colors/colorSave/',
        type: 'POST',
        data: model,
        beforeSend: function () {
            $.LoaderOpen({ selector: ".content" });
            $("#btnSave").addClass("disabled");
        },
        success: function (result) {
            if (result.ResponseType === 2) {
                Swal.fire({
                    position: 'center',
                    icon: 'success',
                    title: systemMessage.successTitle(),
                    text: result.Message,
                    showConfirmButton: true
                }).then((result) => {
                    if (result.isConfirmed) {
                        window.location.href = "/admin/colors/Index/";
                    }
                });

            }
            else {
                Swal.fire({
                    position: 'center',
                    icon: 'warning',
                    title: systemMessage.warningTitle(),
                    text: result.Message,
                    showConfirmButton: true
                });
                return;
            }
        },
        complete: function () {
            $.LoaderClose({ selector: ".content" });
            $("#btnSave").removeClass("disabled");
        },
        error: function (errormessage) {
            Swal.fire({
                position: 'center',
                icon: 'error',
                title: systemMessage.errorTitle(),
                text: errormessage,
                showConfirmButton: true
            });
        }
    });
}




function FormValidation() {

    var ColorName = $('#txtColorName');
    if (ColorName.val().trim() === "") {
        ColorName.focus();
        Swal.fire({
            position: 'center',
            icon: 'warning',
            title: systemMessage.warningTitle(),
            text: 'Renk adı alanı boş olamaz!',
            showConfirmButton: true,
        });
        return false;
    };
}