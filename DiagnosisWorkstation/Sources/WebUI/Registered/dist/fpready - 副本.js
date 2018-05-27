	function fp_ready(){
	//自定义设置
	//Flatpickr.l10n.firstDayOfWeek = 1;
	
Flatpickr.l10n.weekdays = {
	shorthand: ['周日', '周一', '周二', '周三', '周四', '周五', '周六'],
	longhand: ['星期日', '星期一', '星期二', '星期三', '星期四', '星期五', '星期六']
};


	Flatpickr.l10n.months = {
	shorthand: ['一月', '二月', '三月', '四月', '五月', '六月', '七月', '八月', '九月', '十月', '十一月', '十二月'],
	longhand: ['一月', '二月', '三月', '四月', '五月', '六月', '七月', '八月', '九月', '十月', '十一月', '十二月']
};


	//注册日历
	document.getElementById("flatpickr-tryme").flatpickr();
	document.getElementsByClassName("calendar").flatpickr();

	var calendars = document.getElementsByClassName("flatpickr").flatpickr();

	var enent_flatpickr_style = document.getElementById("flatpickr-style");
	document.getElementById("flatpickr-style").flatpickr({
		minDate: "today",
		onChange: function() {
			enent_flatpickr_style.focus();
		},
		onOpen: function(){
			
		},
		onClose: function(){
			
		}
	});

	var enent_flatpickr_tryme = document.getElementById("flatpickr-tryme");
	document.getElementById("flatpickr-tryme").flatpickr({
		minDate: "today",
		onChange: function() {
			enent_flatpickr_tryme.focus();
		},
		onOpen: function(){
			enent_flatpickr_tryme.focus();
		},
		onClose: function(){
			
		}
	});

	//往下可以加各种时间控件功能函数

	}