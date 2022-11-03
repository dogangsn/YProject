$(function () {

    $('.order').mask('00');
    var Id = parseInt($("#txtId").val());


    if (Id !== 0) {
        Get(Id);
    } else {
        $('#txtOrderNumber').val('0');
    };
    $('#btnSave').click(function () {
        var model = {
            CategoryId: parseInt($('#txtId').val()),
            Name: $('#txtCategoryName').val(),
            OrderNumber: $('#txtOrderNumber').val(),
            IsActive: true
        };
        if (model.CategoryId === 0) {
            Add(model);
        } else {
            Update(model);
        }
    });
})

function Get(id) {
    $.ajax({
        url: '/admin/categories/categoryGet/',
        typr: "GET",
        dataType: "json",
        data: { id: id },
        beforeSend: function () {
            $.LoaderOpen({ selector: ".card-body" });
        },
        success: function (result) {
            if (result.ResponseType === 2) {
                $('#txtId').val(result.Data.CategoryId);
                $('#txtCategoryName').val(result.Data.Name);
                $('#txtOrderNumber').val(result.Data.OrderNumber);
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
        url: '/admin/categories/CategorySave/',
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
                        window.location.href = "/admin/categories/Index/";
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
        url: '/admin/categories/CategorySave/',
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
                        window.location.href = "/admin/categories/Index/";
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

    var CategoryName = $('#txtCategoryName');
    if (CategoryName.val().trim() === "") {
        CategoryName.focus();
        Swal.fire({
            position: 'center',
            icon: 'warning',
            title: systemMessage.warningTitle(),
            text: 'Kategori adı alanı boş olamaz!',
            showConfirmButton: true,
        });
        return false;
    };
    var OrderNumber = $('#txtOrderNumber')
    if (OrderNumber.val().trim() === "") {
        OrderNumber.focus();
        Swal.fire({
            position: 'center',
            icon: 'warning',
            title: systemMessage.warningTitle(),
            text: 'Sıra numarası alanı boş olamaz!',
            showConfirmButton: true,
        });
        return false;
    };
}