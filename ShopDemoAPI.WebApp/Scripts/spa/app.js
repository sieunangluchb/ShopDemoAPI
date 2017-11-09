
var myApp = angular.module('myModule', []);



myApp.controller("schoolController", schoolController);

myApp.directive("shopDemoApiDirective", shopDemoApiDirective);

myApp.service('validatorService', validatorService);



schoolController.$inject = ['$scope','validatorService'];

function schoolController($scope, Validator) {
    $scope.checkNumber = function () {
        $scope.message = validatorService.checkNumber($scope.num);
    }
    $scope.num = 1;
}

function validatorService($window) {
    return {
        checkNumber: checkNumber
    }
    function checkNumber(input) {
        if (input % 2 == 0) {
            return 'This is even';
        } else {
            return 'This is odd';
        }
    }
}

function shopDemoApiDirective() {
    return {
        restrict : "A",
        templateUrl : "/Scripts/spa/shopDemoApiDirective.html"
    }
}