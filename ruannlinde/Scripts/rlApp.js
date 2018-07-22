(function (window, angular) {
    'use strict';

    const homeController = function ($scope) {
        $scope.model = {
            message: 'angular works',
            titles: ['Senior .Net Developer','Technical Team Lead']
        };
    };

    //directive
    const scrambler = function () {
        'use strict';
        return {
            require: 'ngModel',
            restrict: 'A',
            replace: true,
            transclude: true,
            template: function (elements, attributes) {
                m
                 return '<h1>{{title}}</h1>';
            },
            scope: {
                nModel: '=ngModel'
            },
            compile: function (element, attributes) {
                element.removeAttr('ng-model');
                return {
                    pre: function(scope, element, attributes) {

                    }
                };
            }
        };
    };

    angular.module('rlApp', [])
        .controller('homeController', ['$scope', homeController])
        .directive('scrambler', scrambler);


})(window, angular);



