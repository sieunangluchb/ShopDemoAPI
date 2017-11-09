
var myApp = angular.module('myModule', []);

myApp.controller("schoolController", schoolController);
myApp.controller("studentController", studentController);
myApp.controller("teacherController", teacherController);

myApp.$inject = ["$scope"];

//declare
function schoolController($scope) {
    $scope.message = "Announcement from School";
}

function studentController($scope) {
    $scope.message = "This is my message from Student";
}

function teacherController($scope) {
    $scope.message = "This is my message from Teacher";
}