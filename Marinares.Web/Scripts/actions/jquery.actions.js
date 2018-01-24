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

	function gotoconfirm() {
  	$('.ap-btn--confirm').on('click', function(){
  		$('.ap-nav-link-confirm').trigger( "click" );
  		returnMenu();
  	});
	}

	if ($('.ap-cp').is(':visible')) {
		gotoconfirm();

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

		// Navigation
		var waypoints = $('#ap-grid-menu').waypoint(function(direction) {
		  $heade.toggleClass('ap-header--ribbon-small');
		  $('.ap-grid-menu').toggleClass('ap-grid-menu--is-visible')
		}, {
		  offset: '25%'
		})
		var waypoints = $('#ap-class').waypoint(function(direction) {
		  $('.ap-class').toggleClass('ap-class--is-visible')
		}, {
		  offset: '25%'
		})
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


	$('.ap-woman-carou').bxSlider();

	$('.ap-man-carou').bxSlider();


	// Sections
	setTimeout(function(){
		$('.ap-section').addClass('ap-section--ready');
	},1000);
});
