$(function () {
   //#region DataTables ayarları yapılıyor...
   $.extend($.fn.dataTable.defaults, {
      autoWidth: false,
      dom: '<"datatable-header"fBl><"datatable-scroll-wrap"t><"datatable-footer"ip>',
      language: {
         "decimal": ",",
         "emptyTable": "Tabloda herhangi bir veri mevcut değil",
         "info": "_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor",
         "infoEmpty": "Kayıt yok",
         "infoFiltered": "(_MAX_ kayıt içerisinden bulunan)",
         "infoThousands": ".",
         "lengthMenu": "Sayfada _MENU_ kayıt göster",
         "loadingRecords": "Yükleniyor...",
         "processing": "İşleniyor...",
         "search": "Ara:",
         "zeroRecords": "Eşleşen kayıt bulunamadı",
         "paginate": {
            "first": "İlk",
            "last": "Son",
            "next": "Sonraki",
            "previous": "Önceki"
         },
         "aria": {
            "sortAscending": ": artan sütun sıralamasını aktifleştir",
            "sortDescending": ": azalan sütun sıralamasını aktifleştir"
         },
         "select": {
            "rows": {
               "_": "%d kayıt seçildi",
               "1": "1 kayıt seçildi"
            }
         }
      }
   });
   //#endregion
   setTimeout(function () {
   }, 600);
   $(".select2").select2({
      allowClear: true,
      search: true,
      placeholder: '-- Seçiniz --'
   });
   $('[data-popup="lightbox"]').fancybox({
      padding: 3
   });
});

function showTime() {
   var date = new Date();
   var h = date.getHours();
   var m = date.getMinutes();
   var s = date.getSeconds();

   if (h == 0) {
      h = 12;
   }

   h = (h < 10) ? "0" + h : h;
   m = (m < 10) ? "0" + m : m;
   s = (s < 10) ? "0" + s : s;

   var time = h + ":" + m + ":" + s + " ";
   $('#time').text(time);

   setTimeout(showTime, 1000);
}
