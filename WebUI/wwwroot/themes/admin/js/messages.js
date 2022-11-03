//#region SİSTEM MESAJLARI
var systemMessage = function () {
   return {
      errorTitle: function () {
         return "Bir hata oluştu";
      },
      warningTitle: function () {
         return "Uyarı";
      },
      successTitle: function () {
         return "Başarılı";
      },
      confirmDeleteMessage: function () {
         return "Silmek istediğinize emin misiniz?";
      },
      createPermissionsMessage: function () {
         return "Default yetkiler sistem yöneticisi tarafından otomatik olarak eklenecektir. Onaylıyor musunuz?";
      }
   }
}();
//#endredion
