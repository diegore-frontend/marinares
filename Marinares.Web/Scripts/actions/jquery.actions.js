$(function(){
	// Variables
	var $mnBtn = $('.ap-nav-icon'),
			$mnNav = $('.ap-nav');


	// Hamburguer menu
	$mnBtn.on('click', function(e){
		e.preventDefault();
		$(this).toggleClass('ap-nav-icon--active');
		$mnNav.toggleClass('ap-nav--is-visible');
	});


	// parallaxingCouple()
	
	// Parallaxing couple
	function parallaxingCouple() {
		$('marin').plaxify({"xRange":40,"yRange":0})
		$.plax.enable()
	}
});
