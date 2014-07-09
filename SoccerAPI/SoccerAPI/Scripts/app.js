(function () {
	var app = angular.module('soccer', []);
	
	app.controller('SoccerController', [ '$http', function ($http) {
		var soccer = this;
		soccer.teams = [];

		$http.get('/api/Teams').success(function (data) {
			soccer.teams = data;
		});
	}]);

	app.controller('PlayerController', ['$http', function ($http) {
		var playerCtrl = this;
		playerCtrl.players = [];

		$http.get('/api/Players').success(function (data) {
			playerCtrl.players = data;
		});
	}]);

	app.controller("CommentController", ['$http', function ($http) {
		var commentCtrl = this;
		commentCtrl.comments = [];
		commentCtrl.comment = {};
		commentCtrl.message = "n/a";

		$http.get('/api/Comments').success(function (data) {
			commentCtrl.comments = data;
		});

		this.getComments = function () {
			$http.get('/api/Comments').success(function (data) {
				commentCtrl.comments = data;
			});
		};

		this.addComment = function (team) {
			commentCtrl.comment.TeamId = team.Id;
			var comm = commentCtrl.comment;
			$http.post('/api/Comments', JSON.stringify(comm)).success(function (data) {
				commentCtrl.comment = {};
				commentCtrl.getComments();
			});
		};
	}]);

	app.controller("TabController", function () {
		this.tab = 1;
		
		this.selectTab = function(setTab) {
			this.tab = setTab;
		};

		this.isSelected = function (checkTab) {
			return this.tab === checkTab;
		};
	});
})();