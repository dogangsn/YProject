$(function () {

});
function log(q) {
   return console.log(q);
}
$.LoaderOpen = function (params) {
   $(params.selector).block({
      message: '<div class="h-100 w-100 row align-items-center"> <div class="col"><div class="spinner-grow text-primary" role="status"></div> <div class="spinner-grow text-secondary" role="status"></div> <div class="spinner-grow text-success" role="status"></div> <div class="spinner-grow text-danger" role="status"></div></div> </div>',
      overlayCSS: {
         backgroundColor: '#fff',
         opacity: 0.8,
         cursor: 'wait'
      },
      centerX: false,
      centerY: false,
      css: {
         border: 'none',

         backgroundColor: 'transparent'
      }
   });
};
$.LoaderClose = function (params) {
   $(params.selector).unblock();
};
(function ($) {
   $.fn.extend({
      islemBittiMi: function (callback, timeout) {
         timeout = timeout || 1e3;
         var timeoutReference,
            doneTyping = function (el) {
               if (!timeoutReference) return;
               timeoutReference = null;
               callback.call(el);
            };
         return this.each(function (i, el) {
            var $el = $(el);
            $el.is(':input') && $el.on('keyup keypress', function (e) {
               if (e.type == 'keyup' && e.keyCode != 8) return;
               if (timeoutReference) clearTimeout(timeoutReference);
               timeoutReference = setTimeout(function () {
                  doneTyping(el);
               }, timeout);
            }).on('blur', function () {
               doneTyping(el);
            });
         });
      }
   });
})(jQuery);