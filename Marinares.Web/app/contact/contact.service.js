(function () {
    'use strict';

    angular
        .module('app.marinares')
        .service('ContactService', ContactService);

    ContactService.$inject = ['HttpService'];

    function ContactService(HttpService) {
        var service = {
            sendMessage: sendMessage
        };

        return service;

        function sendMessage(params) {
            return HttpService.makePostRequest(getRoute('SendMessage'), params)
            .then(getResponse);
        }


        function getResponse(response) {
            return response;
        }

        function getRoute(route) {
            return String.format('{0}{1}', url, route);
        }
    }
})();