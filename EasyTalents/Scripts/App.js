var app = angular.module("talentsApp", []);
app.controller("talentsCtrl", function ($scope, $http) {

    $scope.addTalent = function (talent, update) {
        console.log(update);
        if (update) {
            $http.post("/Home/updateTalent/", { uptTalent: talent })
            .then(function (result) {
                $scope.talents = result.data
                window.location.href = "#";
            }).catch(function (data) {
                console.log(data);
            });
        } else {
            $http.post("/Home/addTalent/", { newTalent: talent })
            .then(function (result) {
                $scope.talents = result.data
                window.location.href = "#";
            }).catch(function (data) {
                console.log(data);
            });
        }

    }

    $scope.deleteTalent = function (talent) {
        if (confirm("Tem certeza que deseja excluir este registro?")) {
            $http.post("/Home/deleteTalent/", { delTalent: talent })
            .then(function (result) {
                $scope.talents = result.data
            }).catch(function (data) {
                console.log(data);
            });
        }
    }

    $scope.editTalent = function (talent) {
        $scope.update = true;
        $http.post("/Home/editTalent", { uptTalent: talent })
        .then(function (result) {
            $scope.talent = talent
        }).catch(function (data) {
            console.log(data);
        });
    }

    $scope.filterValue = function ($event) {
        if (isNaN(String.fromCharCode($event.keyCode))) {
            $event.preventDefault();
        }
    };

    $http.get("/Home/getTalents")
    .then(function (result) {
        $scope.talents = result.data;
    }).catch(function (data) {
        console.log(data);
    });

    $http.get("/Home/getAvailabilities")
    .then(function (result) {
        $scope.availabilities = result.data;
    }).catch(function (data) {
        console.log(data);
    });


    $http.get("/Home/getBesttimes")
    .then(function (result) {
        $scope.besttimes = result.data;
    }).catch(function (data) {
        console.log(data);
    });



});