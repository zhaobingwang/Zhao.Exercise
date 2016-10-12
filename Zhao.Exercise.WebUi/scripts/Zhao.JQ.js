$.ZhaoJq = {
	/*
	*设定字符显示长度；
	*add by zhao 2016-9-9
	*/
	setLength: function (obj,len) {
		for (var i = 0; i < len; i++) {
			if ($.trim(obj[i].innerText).length>len) {
				obj[i].innerText = $.trim(obj[i].innerText).substring(0, len);
			}
		}
	},
};