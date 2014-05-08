var PhotoCollage = function () {
    var switchToDesktop = function () {
            $("ul.instructions li.desktopInstruction").show();
            $("ul.instructions li.mobileInstruction").hide();
        },
        switchToMobile = function () {
            $("ul.instructions li.desktopInstruction").hide();
            $("ul.instructions li.mobileInstruction").show();
        },
        resizeModal = function () {
            var imgHeight = $("#photoModal .modal-body img").height(),
                imgWidth = $("#photoModal .modal-body img").width();
            if (0 == imgHeight && 0 == imgWidth) {
                setTimeout(function () {
                    resizeModal();
                }, 50);
            } else {
                $("#photoModal .modal-dialog").height(imgHeight + 40);
                $("#photoModal .modal-dialog").width(imgWidth + 40);
            }
        };
    return {
        init: function () {
            $("ul.gallery-list-modal > li > div").click(function() {
                $("#photoModal .modal-body img").attr('src', $(this).attr('data-img-url'));
                $("#photoModal").modal("show");
                setTimeout(function () {
                    resizeModal();
                }, 50);
            });

            $("#DesktopView").click(switchToDesktop);
            $("#MobileView").click(switchToMobile);
            switchToDesktop();
        }
    };
}().init();