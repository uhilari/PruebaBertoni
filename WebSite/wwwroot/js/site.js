// Write your JavaScript code.
$(document).ready(function () {
    $('#btn-album').click(function () {
        $('#div-photos').html('Cargando . . .');
        $('#div-comments').html('');
        $.get('home/photos?albumId=' + $('#slt-album').val()).then(function (resp) {
            $('#div-photos').html(resp);
            $(".btn-comment").click(function () {
                $('#div-comments').html('Cargando . . .');
                $.get('home/comments?photoId=' + $(this).attr('data-photoId')).then(function (resp) {
                    $('#div-comments').html(resp);
                });
            });
        })
    });
});