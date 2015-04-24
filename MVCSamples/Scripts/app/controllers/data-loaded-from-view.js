$app.controller('DataLoadedFromViewCtrl', function ($scope, $http, $timeout) {
    $scope.people = [];

    $scope.init = function (model) {

        if (typeof (model) !== 'undefined') {
          $scope.people = model;
        }

    };

    $scope.post = function (person) {

      $http.post('/api/person', person)
          .success(function (data, success, headers, config) {
            alert(data);
          });

    };
});