(function () {
    'use strict';

    angular.module('swal.core', [])
        .config(setDefaultConfigSwal);

    function setDefaultConfigSwal() {
        swal.setDefaults({
            confirmButtonText: 'Aceptar',
            cancelButtonText: 'Cancelar',
            confirmButtonColor: '#C00418',
            allowOutsideClick: false,
            allowEscapeKey: false
        });
    }
})();