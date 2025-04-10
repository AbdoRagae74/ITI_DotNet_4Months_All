// function Person(n,a,s,pos) {
//     this.name =n; 
//     this.age =a; 
//     this.salary =s; 
//     this.position = pos; 

// };
// var person1 = new Person("ahmed",22,18000,"CEO");
// var person2 = new Person("Ali",12,18000,"ABCD");
// Person.prototype.getSetGen =  function (){
//     var caller = this;
//     (function(){        
//         var _data = {};
//         var keys = Object.keys(caller);
//         for(var i=0 ;i<keys.length;i++){
//             let key = keys[i];
//             _data[key] = caller[key];
//             Object.defineProperty(caller,key,{
//                 set:function (value){
//                     _data[key] = value;
//                 },
//                 get: function(){
//                     return _data[key];
//                 },
//                 enumerable:true
                
//             })
//         }
//     })();
// }
// person1.getSetGen();




function Person(n,a,s,pos) {
    this.name =n; 
    this.age =a; 
    this.salary =s; 
    this.position = pos; 

};
var person1 = new Person("ahmed",22,18000,"CEO");
var person2 = new Person("Ali",12,18000,"ABCD");

Person.prototype.getSetGen =  function (){
    var caller = this;
    (function(){        
        var _data = {};
        var keys = Object.keys(caller);
        for(var i=0 ;i<keys.length;i++){
            let key = keys[i];
            _data[key] = caller[key];
            Object.defineProperty(caller,key,{
                set:function (value){
                    _data[key] = value;
                },
                get: function(){
                    return _data[key];
                },
                enumerable:true
                
            })
        }
    })();
}

var user = {name:"Ali",age:10};
// person1.getSetGen.call(user);
// person1.getSetGen.apply(user);
var func = person1.getSetGen.bind(user);
func();
console.log(user);
