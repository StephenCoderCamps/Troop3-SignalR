(function ($) {


    $.fn.rotate = function (options) {


        var settings = $.extend({
            degrees: 20,
            backgroundColor: 'yellow'
        });


        this.on('click', function (e) {
            e.target.style.transform = 'rotate(' + settings.degrees + 'deg)';
            e.target.style.backgroundColor = settings.backgroundColor;
        });

        return this;

    }




})(jQuery);