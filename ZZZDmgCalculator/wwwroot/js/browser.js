window.getDimensions = function() {
	return {
		width: window.innerWidth,
		height: window.innerHeight
	};
};

window.registerViewportChangeCallback = (dotnetHelper) => {
	window.addEventListener('resize', () => {
		dotnetHelper.invokeMethodAsync('OnResizeEvent', window.innerWidth, window.innerHeight);
	});
};