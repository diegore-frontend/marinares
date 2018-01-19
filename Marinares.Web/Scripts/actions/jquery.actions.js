$(function(){
	// Variables
	var $mnBtn = $('.ap-nav-icon'),
			$mnNav = $('.ap-nav'),
			$heade = $('.ap-header'),
			$layot = $('.ap-layout');


	// Hamburguer menu
	$mnBtn.on('click', function(e){
		e.preventDefault();
		returnMenu()
	});

	$('.ap-nav-link').on('click', function(){
		returnMenu()
	});

	function returnMenu() {
		$mnBtn.toggleClass('ap-nav-icon--active');
		$mnNav.toggleClass('ap-nav--is-visible');
		$layot.toggleClass('ap-layout--nav-open');
	}

	if ($('.ap-cp').is(':visible')) {
		setTimeout(function(){
			$heade.toggleClass('ap-header--ribbon')
			$('#ap-nav').onePageNav({
				currentClass: 'ap-nav-item--active',
				changeHash: false,
				scrollSpeed: 750,
				scrollThreshold: 0.5,
				filter: '',
				easing: 'swing'
			});
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

	// Japan
	if ($('.ap-jp-gallery').is(':visible')) {
		setTimeout(function(){
			sliderGallery.init();
		},10);
	}

	// NAvigation
	var $head = $( '#ha-header' );
	$( '.ha-waypoint' ).each( function(i) {
		var $el = $( this ),
			animClassDown = $el.data( 'animateDown' ),
			animClassUp = $el.data( 'animateUp' );

		$el.waypoint( function( direction ) {
			if( direction === 'down' && animClassDown ) {
				$head.attr('class', 'ha-header ' + animClassDown);
			}
			else if( direction === 'up' && animClassUp ){
				$head.attr('class', 'ha-header ' + animClassUp);
			}
		}, { offset: '100%' } );
	} );
});
