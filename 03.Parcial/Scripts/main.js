var usuarios = angular.module('usuarios', ["ngSanitize"]);

usuarios.factory("listausuarios", function ($http) {
    var factoria = {};
    factoria.listausuarios = function () {
        return $http.get("http://localhost:57588/Usuarios/listausuarios");
    }
    return factoria;
});

usuarios.controller("usuarioscontroller", function ($scope, listausuarios) {
    listausuarios.listausuarios().success(function (datos) {
        $scope.listausuarios = datos

    });
});


var clientes = angular.module('clientes', ["ngSanitize"]);

clientes.factory("listaclientes", function ($http) {
    var factoria = {};
    factoria.listaclientes = function () {
        return $http.get("http://localhost:57588/Clientes/listaclientes");
    }
    return factoria;
});

clientes.controller("clientescontroller", function ($scope, listaclientes) {
    listaclientes.listaclientes().success(function (datos) {
        $scope.listaclientes = datos

    });
});

var clases = angular.module('clases', ["ngSanitize"]);

clases.factory("listaclases", function ($http) {
    var factoria = {};
    factoria.listaclases = function () {
        return $http.get("http://localhost:57588/Clases/listaclases");
    }
    return factoria;
});

clases.controller("clasescontroller", function ($scope, listaclases) {
    listaclases.listaclases().success(function (datos) {
        $scope.listaclases = datos

    });
});