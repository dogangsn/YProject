$(function () {
    $('#btnLogin').click(function () {
        var userName = $("#txtUserName");
        var password = $("#txtPassword");
        if (userName.val().trim() === "") {
            Swal.fire({
                icon: 'warning',
                title: 'Uyarı',
                text: "Kullanıcı adı boş olamaz!",
                confirmButtonText: 'Tamam',
                confirmButtonColor: '#2196f3'
            });
            return;
        }
        if (password.val().trim() === "") {
            Swal.fire({
                icon: 'warning',
                title: 'Uyarı',
                text: 'Parola boş olamaz!',
                confirmButtonText: 'Tamam',
                confirmButtonColor: '#2196f3'
            });
            return;
        }
        var model = {
            UserName: userName.val(),
            Password: password.val()
        }
        $.LoaderOpen({ selector: ".login-form" });
        $.ajax({
            type: "POST", 
            url: "/admin/login/signIn", 
            data: model,
            beforeSend: function () {
                $.LoaderOpen({ selector: ".login-form" });
            },
            success: function (result) {
                if (result.ResponseType === 2) {
                    window.location.href = "/admin/admin/index";
                  
                }
                else {
                    $.LoaderClose({ selector: ".login-form" });
                    Swal.fire({
                        position: 'center',
                        icon: 'warning',
                        title: 'Uyarı',
                        text: result.Message,
                        confirmButtonText: 'Tamam',
                        confirmButtonColor: '#2196f3'
                    });
                    return false;
                }
            }
        });
    })

    $('input').keypress(function (event) {
        var keycode = (event.keyCode ? event.keyCode : event.which);
        if (keycode == '13') {
            $("#btnLogin").click();
        }
    });
});