﻿(function (app) {
    app.controller('productAddController', productAddController);

    productAddController.$inject = ['apiService', '$scope', 'notificationService', '$state'];

    function productAddController(apiService, $scope, notificationService, $state) {
        $scope.product = {
            CREATEDDATE: new Date(),
            STATUS: true
        }

        $scope.ckeditorOptions = {
            language: 'vi',
            height: '200px'
        }

        $scope.AddProduct = AddProduct;

        function AddProduct() {
            apiService.post('/api/product/create', $scope.product,
                function (result) {
                    notificationService.displaySuccess(result.data.NAME + ' đã được thêm mới.');
                    $state.go('products');
                }, function (error) {
                    notificationService.displayError('Thêm mới không thành công.');
                });
        }

        function loadproductCategory() {
            apiService.get('/api/productcategory/getallparents', null, function (result) {
                $scope.productCategories = result.data;
            }, function () {
                console.log('Cannot get list parent');
            });
        }
        $scope.ChooseImage = function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl) {
                $scope.product.IMAGE = fileUrl;
            }
            finder.popup();
        }
        loadproductCategory();
    }
})(angular.module('shopdemoapi.common'));