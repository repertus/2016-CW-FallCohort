(function() {
    'use strict';

    angular
        .module('app')
        .controller('DetailController', DetailController);

    DetailController.$inject = ['$stateParams'];

    /* @ngInject */
    function DetailController($stateParams) {
        var vm = this;
        vm.movie = 'Star Wars!!!!';

        vm.currentMovieId = $stateParams.movieId;
    }
})();