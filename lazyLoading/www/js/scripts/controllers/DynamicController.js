/**
 * Created by jm96 on 14-5-6.
 */
define(["app"],function(app){
    app.register.controller("DynamicController",["$scope",function($scope){
        $scope.data=[{name:"name1",age:1,id:1},
                      {name:"name2",age:2,id:2}];
        $scope.gridOptions={
            data:'data'
            ,columnDefs:[{
                displayName:"姓名"
                ,field:"name"
            },{
                displayName:"年龄"
                ,field:"age"
            }]
        };
    }]);
});