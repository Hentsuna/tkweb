$(function(){
    $('#nav ul.nav__child').removeClass('nav__child');
    $('#nac ul.nav__child__child').removeClass('nav__child__child');
    $('#nav li').has('ul').hover(
        function(){
            $(this).addClass('current').children('ul').addClass('shadow').slideDown(10)},
            function(){
                $(this).removeClass('current').children('ul').stop(true, true).slideUp(1000)
        })
})