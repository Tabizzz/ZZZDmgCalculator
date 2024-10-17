window.getDimensions = function() {
	return {
		width: window.innerWidth,
		height: window.innerHeight
	};
};

window.getElementDimensions = function(element) {
	return {
		width: element.clientWidth,
		height: element.clientHeight
	};
};

window.registerViewportChangeCallback = (dotnetHelper) => {
	window.addEventListener('resize', () => {
		dotnetHelper.invokeMethodAsync('OnResizeEvent', window.innerWidth, window.innerHeight);
	});
};