(function () {
	'use strict';

	angular
        .module('app.marinares')
        .controller('ContactController', ContactController);

	ContactController.$inject = ['ContactService'];
	function ContactController(ContactService) {
	    var vm = this;
	    vm.contact = {};

		vm.sendMessage = sendMessage;

		function sendMessage(contact) {
			if ($('form').valid()) {
				ContactService.sendMessage({ model: contact })
                .then(function (response) {
                    if (response.Status === 'success') {
                        vm.contact = {};
                    }
                	swal({
                		type: response.Status,
                		text: response.Content
                	});
                });
			}
			return false;
		}
	}
})();