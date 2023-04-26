$(function(){
    //Ham active tab nao do
    function activeTab(obj){
        //Xoa class active tat ca cac tab
        $('.tab-wrapper ul li').removeClass('active');
        //Them class active vao class dang click
        $(obj).addClass('active');
        //Lay href cua tab de show content tuong ung
        var id = $(obj).find('a').attr('href');
        //An het nd cac tab dang hien thi
        $('.tab-item').hide();
        //Hien thi noi dung hien tai
        $(id).show();
    } //het ham activeTab(obj)
    //Su kien click doi tab
    $('.tab li').click(function(){
        activeTab(this);
        return false;
    })
    //Active tab dau tien khi trang web duoc chay
    activeTab($('.tab li:first-child'));
})