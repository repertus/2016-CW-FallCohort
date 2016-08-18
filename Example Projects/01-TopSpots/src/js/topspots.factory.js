angular.module('app').factory('topSpotFactory', function() {
	return {
		getTopSpots: function() {
			return $http.get('js/topspots.json');
		}
	};
});