$(document).ready(function () {
    // console.log($('#title'))
    // console.log($('.page-box'))
    $('#submitButton').click(function (e) {
        e.preventDefault();

        let username = $('#username').val();

        alert("Welcome, " + username);
    })
    $('.page-box:first').addClass('btn-danger');

})