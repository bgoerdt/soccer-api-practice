var soccerApp = angular.module('soccerApp', []);

soccerApp.controller('TeamController', function ($scope, $http) {
	$http.get('/api/Teams').success(function (data) {
		$scope.teams = data;
	});
});

soccerApp.controller('PlayerController', function ($scope, $http) {
	$http.get('/api/Players').success(function (data) {
		$scope.players = data;
	});
});

soccerApp.controller('CommentController', function ($scope, $http) {
	$scope.newComment = {};
	$http.get('/api/Comments').success(function (data) {
		$scope.comments = data;
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
});

soccerApp.controller('TabController', function ($scope) {
	$scope.selectedTab = 1;

	$scope.isSelected = function (tab) {
		return $scope.selectedTab == tab;
	};

	$scope.selectTab = function (tab) {
		$scope.selectedTab = tab;
	};
});