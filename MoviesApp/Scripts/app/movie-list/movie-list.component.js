'use strict';

angular.
  module('movieList').
    component('movieList', {
    templateUrl: 'Scripts/app/movie-list/movie-list.template.html',
    controller: ['$http', function MovieListController($http) {
      var self = this;
      self.orderProp = 'Title';

      //$http.get('Scripts/app/movies/movies.json').then(function(response) {
      //  self.movies = response.data;
      //});
      $http.get('api/Movie').then(function(response) {
        self.movies = response.data;
      });

    }]
  });