(function () {
    'use strict';

    angular.module('app.marinares')
    .factory('HttpService', HttpService);

    HttpService.$inject = ['$http'];

    function HttpService($http) {
        var service = {
            request: request,
            makeGetRequest: makeGetRequest,
            makePostRequest: makePostRequest,
            makePutRequest: makePutRequest,
            makeDeleteRequest: makeDeleteRequest
        };
        return service;

        function request(config) {
            return $http(config)
            .then(function (response) {
                return response.data;
            });
        }

        function makeGetRequest(url, params, headers) {
            return makeRequest(url, params, 'GET', headers);
        }

        function makePostRequest(url, params, headers) {
            return makeRequest(url, params, 'POST', headers);
        }

        function makePutRequest(url, params, headers) {
            return makeRequest(url, params, 'PUT', headers);
        }

        function makeDeleteRequest(url, params, headers) {
            return makeRequest(url, params, 'DELETE', headers);
        }

        function makeRequest(url, params, method, headers) {
            return $http(getParamTypeByMethod(url, params, method, headers)).then(function (response) {
                return response.data;
            });
        }

        function getParamTypeByMethod(url, params, method, headers) {
            var data = {
                method: method,
                url: url,
                headers: headers
            };

            method = method.toUpperCase();

            if (method === 'GET' || method === 'DELETE') {
                data.params = params;
            } else {
                data.data = params;
            }

            return data;
        }
    }
})();