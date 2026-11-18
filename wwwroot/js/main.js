// BookHub - hiệu ứng giao diện cơ bản (nút "lên đầu trang")
$(function () {
    $(window).on('scroll', function () {
        $('.to-top').toggle($(this).scrollTop() > 200);
    });
    $('.to-top').on('click', function () {
        $('html, body').animate({ scrollTop: 0 }, 400);
    });
    $('.search-box input').on('focus', function () { $(this).select(); });
});
$(document).on('click', 'menu a.theloai', funtion (e) {
    if ($('#PKHD_NoiDung').length ===0 ) return;
    e.preventDefault();

    var id = $(this).data('id');
    $('.menu li').removeClass('active');
    $(this).parent().addClass('active');

    $.ajax({
        url: '/Home/PKHD_LocTheoTheLoai',
        type: 'GET',
        data: {id: id },
        success: function (html) {
            $('#PKHD_NoiDung').html(html);
        },
        error: function () {
            alert('loi tai du lieu!');
        }

    });
    });


