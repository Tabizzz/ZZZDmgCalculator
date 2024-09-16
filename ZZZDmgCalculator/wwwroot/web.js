// we have JQUERY

function download(url) {
	const a = document.createElement('img')
	a.src = url
	return a;
}

getDivIcon = (obj) => {
	var src = $(obj).attr("src");
	var url = src.replace("/48?", "/100?");
	return download(url);
}

getIcons = (selector) => {
	var container = $(selector);

	container.find("img").each((index, element) => {
		container.append(getDivIcon(element));
	});
}