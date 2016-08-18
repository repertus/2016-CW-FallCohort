angular.module('app').controller('HomeController', function($scope, topSpotFactory) {
	topSpotFactory.getTopSpots().then(
		function(response) {
			$scope.topspots = response.data;
		},
		function(err) {
			alert(err);
		}
	);
});