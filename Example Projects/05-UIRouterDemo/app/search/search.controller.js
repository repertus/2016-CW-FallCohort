(function() {
    'use strict';

    angular
        .module('app')
        .controller('SearchController', SearchController);

    SearchController.$inject = [];

    /* @ngInject */
    function SearchController() {
        var vm = this;
        vm.message = 'Hello from the Search Controller!';
    }
})();