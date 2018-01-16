$(function(){
	// Variables
	var $mnBtn = $('.ap-nav-icon'),
			$mnNav = $('.ap-nav'),
			$heade = $('.ap-header');


	// Hamburguer menu
	$mnBtn.on('click', function(e){
		e.preventDefault();
		returnMenu()
	});

	$('.ap-nav-link').on('click', function(){
		returnMenu()
	});

	$('#ap-nav').onePageNav({
		currentClass: 'ap-nav-item--active',
		changeHash: false,
		scrollSpeed: 750,
		scrollThreshold: 0.5,
		filter: '',
		easing: 'swing',
		begin: function() {
		},
		end: function() {
			//I get fired when the animation is ending
		},
		scrollChange: function($currentListItem) {
			$heade.toggleClass('ap-header--slim');
		}
	});

	function returnMenu() {
		$mnBtn.toggleClass('ap-nav-icon--active');
		$mnNav.toggleClass('ap-nav--is-visible');
	}

	if ($('.ap-cp').is(':visible')) {
		setTimeout(function(){
			$heade.toggleClass('ap-header--ribbon')
			parallaxingCouple();
		},10);
	}
	
	// Parallaxing couple
	function parallaxingCouple() {
		$('.ap-img-sp--flag-left').plaxify({"xRange":-10,"yRange":0,"invert":true})
		$('.ap-img-sp--flag-right').plaxify({"xRange":10,"yRange":0,"invert":true})
		$('.ap-img-sp--marin').plaxify({"xRange":-10,"yRange":0})
		$('.ap-img-sp--ares').plaxify({"xRange":-10,"yRange":0, "invert":true})
		$.plax.enable()
	}
});
