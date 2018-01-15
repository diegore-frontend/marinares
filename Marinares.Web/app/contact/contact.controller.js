(function () {
	'use strict';

	angular
        .module('app.marinares')
        .controller('ContactController', ContactController);

	ContactController.$inject = ['ContactService'];
	function ContactController(ContactService) {
		var vm = this;

		vm.sendMessage = sendMessage;

		function sendMessage(contact) {
			if ($('form').valid()) {
				ContactService.sendMessage({ model: contact })
                .then(function (response) {
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