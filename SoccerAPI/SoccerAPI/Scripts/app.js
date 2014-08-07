var app = angular.module('soccer', []);
	
app.controller('SoccerController', [ '$scope', '$http', function ($scope, $http) {
	$scope.teams = [];

	$http.get('/api/Teams').success(function (data) {
		$scope.teams = data;
		alert("teams loaded");
	});
}]);

app.controller('PlayerController', [ '$scope', '$http', function ($scope, $http) {
	$scope.players = [];

	$http.get('/api/Players').success(function (data) {
		$scope.players = data;
	});
}]);

app.controller("CommentController", [ '$scope', '$http', function ($scope, $http) {
	$scope.comments = [];
	$scope.comment = {};
	$scope.message = "n/a";

	$http.get('/api/Comments').success(function (data) {
		$scope.comments = data;
		alert("comments loaded");
	});

	$scope.getComments = function () {
		$http.get('/api/Comments').success(function (data) {
			$scope.comments = data;
		});
	};

	$scope.addComment = function (team) {
		$scope.comment.TeamId = team.Id;
		var comm = $scope.comment;
		$http.post('/api/Comments', JSON.stringify(comm)).success(function (data) {
			$scope.comment = {};
			$scope.getComments();
		});
	};
}]);

app.controller("TabController", [ '$scope', function ($scope) {
	$scope.tab = 1;
		
	$scope.selectTab = function (setTab) {
		$scope.tab = setTab;
	};

	$scope.isSelected = function (checkTab) {
		return $scope.tab === checkTab;
	};
}]);