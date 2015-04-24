$app.controller('DataLoadedFromApiCtrl', function ($scope, $http, $timeout) {
    $scope.people = [];

    $scope.init = function (model) {

        $http.get('/api/person')
            .success(function (data, status, headers, config) {
                // add some 'latency'
                $timeout(function () {
                    $scope.people = data;
                }, 3000);
            });

    };

    $scope.post = function (person) {

        $http.post('/api/person', person)
            .success(function (data, success, headers, config) {
                alert(data);
            });

    };
});