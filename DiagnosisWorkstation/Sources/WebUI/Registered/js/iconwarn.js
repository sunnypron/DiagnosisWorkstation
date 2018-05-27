function myfun(x, id) {　　
    if (parseInt(x) <= 1) {
        $(id).css('display', 'none');
    }
    if (parseInt(x) >= 1) {
        $(id).css('display', 'block');
    }
}

function tu(imageurl, idname, shuzi) {
    var x = document.getElementsByTagName("img").length;
    var idsharp = "#" + idname;
    if (x < 6) {
        $(InputsWrapper).append('<div class="tx" style="float:left;"><img id="btn'+idname+'" onclick="getid(this.id)" src="'+imageurl+'" /><div><span class="cicle" id="'+idname+'"></span></div></div>');
        myfun(0, idsharp);
	$(idsharp).levelup({'start' : 0});
        $(idsharp).levelup('increment',shuzi);
        myfun(shuzi, idsharp);
    }
}

function ChangeNumberAdd(idname, shuzi) {
    var idsharp = "#" + idname;
    var value= $(idsharp).levelup('get');
    var c=parseInt(value)+parseInt(shuzi);
    if(c>99){
	var jia=99-value;
	$(idsharp).levelup('increment', jia);
    }
    else{
	$(idsharp).levelup('increment', shuzi);
    }
    myfun(c, idsharp);
}

