var images = [];

$(function () {
    $("#fuImages").fileinput({
        theme: "fas",
        language: "tr", 
        uploadAsync: true,
        showUpload: false, 
        size: false,
        showSize:false,
        allowedFileExtentions: ['jpeg', 'jpg', 'png', 'PNG', 'JPG', 'JPEG'],
        maxFileCount: 5
    });
    $('.stock').mask('00');
    $('.barcode').mask('0000000000000');
    $('.price').mask("#.##000,00", { reverse: true });
    var Id = parseInt($("#txtId").val());
    CategoryList(0);
    ColorList(0);

    if (Id !== 0) {
        Get(Id);
    };
    $('#btnSave').click(function () {
        var formData = new FormData();

        formData.append("ProductId", parseInt($('#txtId').val())); 
        formData.append("CategoryId", $('#drpCategoryId option:selected').val());
        formData.append("ColorId", $('#drpColorId option:selected').val());
        formData.append("Name", $('#txtProductName').val());
        formData.append("Description", $('#txtDescription').val());
        formData.append("Price1", $('#txtPrice1').val());
        formData.append("Price2", $('#txtPrice2').val());
        formData.append("Barcode", $('#txtBarcode').val());
        formData.append("Stock", $('#txtStock').val());
        formData.append("OrderNumber", $('#txtOrderNumber').val());
        formData.append("IsActive", $('#drpIsActive option:selected').val());
        formData.append("ShowHomePage", $('#drpShowHomePage option:selected').val());

        if (parseInt($('#txtId').val()) === 0) {
            var fuImages = document.getElementById("fuImages").files;
            for (var i = 0; i != fuImages.length; i++) {
                formData.append("IProductImages", fuImages[i]);
            }
            Add(formData);
        } else {
            var fuImages = document.getElementById("fuImages2").files;
            for (var i = 0; i != fuImages.length; i++) {
                formData.append("IProductImages", fuImages[i]);
            }
            Update(formData);
        }
    });
})


$('#btnCreateBarcode').click(function () {

    $.ajax({
        url: '/admin/products/CreateBarcode/',
        typr: "GET",
        dataType: "json", 
        beforeSend: function () {
            $.LoaderOpen({ selector: ".card-body" });
        },
        success: function (result) {
            if (result.ResponseType === 2) {
                $('#txtBarcode').val(result.Data);
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

});



function Get(id) {
    $.ajax({
        url: '/admin/products/ProductGet/',
        typr: "GET",
        dataType: "json",
        data: { id: id },
        beforeSend: function () {
            $.LoaderOpen({ selector: ".card-body" });
        },
        success: function (result) {
            if (result.ResponseType === 2) {
                $('#txtId').val(result.Data.ProductId);
                $('#drpCategoryId').val(result.Data.CategoryId.toString()).trigger('change');
                $('#drpColorId').val(result.Data.ColorId.toString()).trigger('change');
                $('#txtProductName').val(result.Data.Name);
                $('#txtDescription').val(result.Data.Description);
                $('#txtPrice1').val(result.Data.Price1);
                $('#txtPrice2').val(result.Data.Price2);
                $('#txtBarcode').val(result.Data.Barcode);
                $('#txtStock').val(result.Data.Stock);
                $('#txtOrderNumber').val(result.Data.OrderNumber);
                $('#drpIsActive').val(result.Data.IsActive.toString()).trigger('change');
                $('#drpShowHomePage').val(result.Data.ShowHomePage.toString()).trigger('change');

                images = [];
                $.each(result.Data.ProductImages, function (index, item) {
                    images.push("<img src='" + item.ImagePath + "' class='file-preview-image kv-preview-data' style='width: auto; height: auto; max-width: 100%; max-height: 100%; image-orientation: from-image;'>");
                });

                $("#fuImages2").fileinput({
                    initialPreview: images,
                    showCaption: false,
                    theme: "fas",
                    language: "tr",
                    uploadAsync: true,
                    showUpload: false,
                    allowedFileExtentions: ['jpeg', 'jpg', 'png', 'PNG', 'JPG', 'JPEG'],
                    maxFileCount: 5
                });
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
        url: '/admin/products/productSave/',
        type: 'POST',
        data: model,
        processData: false,
        contentType: false,
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
                        window.location.href = "/admin/products/Index/";
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
        url: '/admin/products/productSave/',
        type: 'POST',
        data: model,
        processData: false,
        contentType: false,
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
                        window.location.href = "/admin/products/Index/";
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
    var ProductName = $('#txtProductName');
    if (ProductName.val().trim() === "") {
        ProductName.focus();
        Swal.fire({
            position: 'center',
            icon: 'warning',
            title: systemMessage.warningTitle(),
            text: 'Ürün adı alanı boş olamaz!',
            showConfirmButton: true,
        });
        return false;
    };
    if ($.trim($('#drpCategoryId').select2('val')) === "") {
        $('#drpCategoryId').focus();
        Swal.fire({
            position: 'center',
            icon: 'warning',
            title: systemMessage.warningTitle(),
            text: 'Lütfen kategori seçiniz!',
            showConfirmButton: true,
        });
        return false;
    };
    if ($.trim($('#drpColorId').select2('val')) === "") {
        $('#drpColorId').focus();
        Swal.fire({
            position: 'center',
            icon: 'warning',
            title: systemMessage.warningTitle(),
            text: 'Lütfen renk seçiniz!',
            showConfirmButton: true,
        });
        return false;
    }
    var Description = $('#txtDescription')
    if (Description.val().trim() === "") {
        Description.focus();
        Swal.fire({
            position: 'center',
            icon: 'warning',
            title: systemMessage.warningTitle(),
            text: 'Açıklama alanı boş olamaz!',
            showConfirmButton: true,
        });
        return false;
    };
    var Price2 = $('#txtPrice2');
    if (Price2.val().trim() === "") {
        Price2.focus();
        Swal.fire({
            position: 'center',
            icon: 'warning',
            title: systemMessage.warningTitle(),
            text: 'Son fiyat alanı boş olamaz!',
            showConfirmButton: true,
        });
        return false;
    };
    var Barcode = $('#txtBarcode');
    if (Barcode.val().trim() === "") {
        Barcode.focus();
        Swal.fire({
            position: 'center',
            icon: 'warning',
            title: systemMessage.warningTitle(),
            text: 'Barkod alanı boş olamaz!',
            showConfirmButton: true,
        });
        return false;
    };
    var Stock = $('#txtStock');
    if (Stock.val().trim() === "") {
        Stock.focus();
        Swal.fire({
            position: 'center',
            icon: 'warning',
            title: systemMessage.warningTitle(),
            text: 'Stok alanı boş olamaz!',
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
    if ($.trim($('#drpIsActive').select2('val')) === "") {
        $('#drpIsActive').focus();
        Swal.fire({
            position: 'center',
            icon: 'warning',
            title: systemMessage.warningTitle(),
            text: 'Lütfen durum seçiniz!',
            showConfirmButton: true,
        });
        return false;
    }
    if ($.trim($('#drpShowHomePage').select2('val')) === "") {
        $('#drpShowHomePage').focus();
        Swal.fire({
            position: 'center',
            icon: 'warning',
            title: systemMessage.warningTitle(),
            text: 'Lütfen anasayfada göster seçiniz!',
            showConfirmButton: true,
        });
        return false;
    }
}







function ColorList(selectedValue) {
    $.ajax({
        url: '/admin/products/ColorListForProduct/',
        type: 'GET',
        async: false,
        beforeSend: function () {
            $.LoaderOpen({ selector: ".card-body" });
        },
        success: function (result) {
            if (result.ResponseType === 2) {
                $('#drpColorId').html('');
                $.each(result.Data, function (i, item) {
                    if (i === 0)
                        $('#drpColorId').append(new Option());
                    $('#drpColorId').append(new Option(item.Name, item.ColorId));
                });
                if (selectedValue !== undefined) {
                    $('#drpColorId').val(selectedValue).trigger("change");
                }
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
            $.LoaderClose({ selector: ".card-body" });
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
function CategoryList(selectedValue) {
    $.ajax({
        url: '/admin/products/CategoryListForProduct/',
        type: 'GET',
        async: false,
        beforeSend: function () {
            $.LoaderOpen({ selector: ".card-body" });
        },
        success: function (result) {
            if (result.ResponseType === 2) {
                $('#drpCategoryId').html('');
                $.each(result.Data, function (i, item) {
                    if (i === 0)
                        $('#drpCategoryId').append(new Option());
                    $('#drpCategoryId').append(new Option(item.Name, item.CategoryId));
                });
                if (selectedValue !== undefined) {
                    $('#drpCategoryId').val(selectedValue).trigger("change");
                }
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
            $.LoaderClose({ selector: ".card-body" });
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