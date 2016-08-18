angular.module('app').controller('HomeController', function($scope, $http) {
	$http.get('/data/topspots.json').then(
		function(data) {
			$scope.topspots = data;
		},
		function(err) {
			alert(err);
		}
	);
});