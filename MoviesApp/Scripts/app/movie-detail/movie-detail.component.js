'use strict';

// Register `movieDetail` component, along with its associated controller and template
angular.
  module('movieDetail').
  component('movieDetail', {
      templateUrl: 'Scripts/app/movie-detail/movie-details.template.html',
    controller: ['$routeParams','$http',
        function movieDetailController($routeParams, $http) {  
            var self = this;
            $http.get('api/Movie/' + $routeParams.movieId).then(function (response) {
                self.movie = response.data;
          });
      }
    ]
  });