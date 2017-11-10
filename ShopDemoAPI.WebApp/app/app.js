(function () {
    angular.module('shopdemoapi', ['shopdemoapi.products', 'shopdemoapi.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeViewController"
        });
        $urlRouterProvider.otherwise('/admin');
    }
})();