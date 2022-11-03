$(function () {
    $.LoaderOpen({ selector: "#dataTable" });
    var table = $("#dataTable").DataTable({
        "processing": true,
        "serverSide": true,
        "filter": true,
        "stateSave": true,
        "searching": true,
        "order": [[0, "desc"]],
        "ajax": {
            "url": '/admin/products/productList',
            "type": "POST"
        },
        "drawCallback": function () {
            //DataTable tam anlamıyla yükledikten sonra çalışacak işlemler...
            $.LoaderClose({ selector: "#dataTable" });
            $('#dataTable').on('click', '.btnDelete', function () {
                var id = $(this).attr("id");
                Swal.fire({
                    title: systemMessage.warningTitle(),
                    text: systemMessage.confirmDeleteMessage(),
                    icon: 'warning',
                    showCancelButton: true,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#d33',
                    confirmButtonText: 'Evet'
                }).then((result) => {
                    if (result.isConfirmed) {
                        Delete(id);
                    }
                });
            });
        },
        "columnDefs": [{
            "targets": [0],
            "visible": true,
            "searchable": false
        }],
        "columns": [
            { "data": "ProductId", "name": "ProductId", "autoWidth": true },
            {
                data: null,
                orderable: true,
                name: "Image",
                "render": function (data, row) {
                    if (data.Image != null) {
                        var data = "<img src='" + data.Image + "' style='height: 75px; width: 75px;'/>";
                    }
                    else {
                        var data = "<img src='/ProductImages/no-image.jpg' style='height: 75px; width: 75px;'/>";
                    }
                    return data;
                }
            },
            { "data": "Name", "name": "Name", "autoWidth": true },
            { "data": "CategoryName", "name": "CategoryName", "autoWidth": true },
            { "data": "ColorName", "name": "ColorName", "autoWidth": true },
            { "data": "Price1", "name": "Price1", "autoWidth": true },
            { "data": "Price2", "name": "Price2", "autoWidth": true },
            { "data": "Barcode", "name": "Barcode", "autoWidth": true },
            { "data": "Stock", "name": "Stock", "autoWidth": true }, 
            {
                data: null,
                orderable: true,
                name: "IsActive",
                "render": function (data, row) {
                    var data = (data.IsActive == true ? "<div class='text-center form-check' style='margin-bottom: 20px !important;'><input style='height: 18px; width: 18px;' class='form-check-input' type='checkbox' checked onclick='return false;'></div>" : "<div class='text-center form-check' style='margin-bottom: 20px !important;'><input style='height: 18px; width: 18px;' class='form-check-input' type='checkbox' onclick='return false;'></div>");
                    return data;
                }
            },
            
            { "data": "OrderNumber", "name": "OrderNumber", "autoWidth": true },
            {
                data: null,
                orderable: true,
                name: "ShowHomePage",
                "render": function (data, row) {
                    var data = (data.ShowHomePage == true ? "<div class='text-center form-check' style='margin-bottom: 20px !important;'><input style='height: 18px; width: 18px;' class='form-check-input' type='checkbox' checked onclick='return false;'></div>" : "<div class='text-center form-check' style='margin-bottom: 20px !important;'><input style='height: 18px; width: 18px;' class='form-check-input' type='checkbox' onclick='return false;'></div>");
                    return data;
                }
            },
            {
                data: null,
                orderable: false,
                "render": function (data, row) {
                    var editButton = '<a href="/admin/products/save/' + data.ProductId + '" class="btn bg-slate btn-sm"><i class="fa fa-pen"></i> Düzenle</a>';
                    var deleteButton = '<button id=' + data.ProductId + ' class="btn btn-danger btn-sm btnDelete"><i class="fa fa-trash"></i> Sil</button>';
                    return editButton + " " + deleteButton;
                }
            },
        ],
        "buttons": {
            "buttons": [
                {
                    extend: 'print',
                    text: '<i class="icon-printer"></i>',
                    className: 'btn bg-blue',
                    exportOptions: {
                        columns: ':visible'
                    }
                },
                {
                    extend: 'excelHtml5',
                    text: '<i class="fas fa-file-excel"></i>',
                    className: 'btn btn-success',
                    exportOptions: {
                        columns: ':visible'
                    }
                },
                {
                    extend: 'pdfHtml5',
                    text: '<i class="fas fa-file-pdf"></i>',
                    className: 'btn btn-danger',
                    orientation: 'landscape', //portrait
                    pageSize: 'A4', //A3, A5,A6,legal,letter
                    exportOptions: {
                        columns: ':visible',
                        search: 'applied',
                        order: 'applied'
                    }
                },
                {
                    extend: 'colvis',
                    text: '<i class="icon-three-bars"></i>',
                    className: 'btn btn-light btn-icon dropdown-toggle'
                }
            ]
        }
    }); 
});

function Delete(id) {
    $.ajax({
        type: "POST",
        url: "/admin/products/productDelete/", 
        data: { id: id },
        beforeSend: function () {
            $.LoaderOpen({ selector: ".datatable" });
        },
        success: function (result) {
            if (result.ResponseType === 2) {
                Swal.fire({
                    position: 'center',
                    icon: 'success',
                    title: systemMessage.successTitle(),
                    text: result.Message,
                    showConfirmButton: true
                });
                $('#dataTable').DataTable().ajax.reload();
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
            $.LoaderClose({ selector: ".datatable" });
        },
        error: function (errormessage) {
            Swal.fire({
                position: 'center',
                icon: 'error',
                title: systemMessage.warningTitle(),
                text: errormessage,
                showConfirmButton: true
            });
        }
    });
}