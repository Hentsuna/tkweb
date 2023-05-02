$(function(){
    //ham check
    $('body').on('click','.check', function() {
        var vnf_regex = /((09|03|07|08|05)+([0-9]{8})\b)/g;
        var mobile = $('#mobile').val();
        if(mobile !==''){
            if (vnf_regex.test(mobile) == false) 
            {
                alert('Số điện thoại của bạn không đúng định dạng!');
            }else{
                alert('Số điện thoại của bạn hợp lệ!');
            }
        }else{
            alert('Bạn chưa điền số điện thoại!');
        }
        var filter = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
        var email = $('#email').val();
        if(email !==''){
            if(filter.test(email) == false)
            {
                alert('Email của bạn không đúng định dạng');
            }else{
                alert('Email của bạn hợp lệ');
            }
        }else{
            alert('Bạn chưa điển email');
        }
        });
});