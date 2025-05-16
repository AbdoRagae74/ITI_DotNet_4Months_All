//class factory

//anynmous literal object
// var obj = {
//     name:"menna",
//     age:25,
//     print:function(){
//         console.log(this);
//     }
// }
// obj.salary = 2000;
// // obj.print();
// console.log(obj);

// var obj2 = {
//     name:"hamada",

// }

// //dot notation
// obj.name = "ahmed";
// console.log(typeof obj);


//subscribe notation

//class ==> function constructor 
//Employee name age salary 
//print() calcSalary();
// function Employee(n,a,s){

//     // console.log(this);//
//     this.name = n;
//     this.age = a;
//     this.salary = s;
//     // this.print = function(){
//     //     console.log(this.name,this.age);
//     // }
// //return undefiend
// }
// Employee.prototype.print = function(){
//     console.log(this.name,this.age);
// }
// var emp = new Employee("menna",25,3000);
// // emp.name = "hamada";
// // emp.email = "menna@aaa.comm";
// // delete emp.name;
// console.log(emp);// {constructor :Employee}
// emp["print"]();
// console.log(emp.constructor ===Employee);
// var emp2 = new Employee("hamada",30,3000);
// console.log(emp2);
// console.log(emp2.constructor ===Employee);
// emp2.print();


//this refer to function caller

// var div = document.querySelector("div");
// div.addEventListener("click",function(){
//     console.log(this);//div
// })

///////////////////////////
function Student(n, a, g) {
    Object.defineProperty(this,"name",{
       get:function(){
        
       },
        enumerable:true
    }

    )
    //  /this.name = n;
    this.age = a;
    this.grades = g

}
Student.prototype.calcGrades = function () {
    return this.grades + "%";
}

var stu = new Student("menna", 15, 60);
// console.log(stu.calcGrades());
console.log(stu);
var stu2 = new Student("menna", 15, 70);
// console.log(stu2.calcGrades());

// for (const key in stu) {

//     console.log(key);
// }
// console.log(Object.keys(stu));

// var obj = {
//     name: "menna",
//     age: 20
// };
//data descriptor
// Object.defineProperty(obj,"name",{
//     value:"hamada",
//     writable:false,
//     // enumerable:false,//loop
//     // configurable:false//delete

// })

// obj.name = "aya";
// delete obj.name;
// console.log(Object.keys(obj));
// console.log(obj.name);
//accessor descriptor
// (function(){
//  var data = obj.name;

// Object.defineProperty(obj,"name",{

//    set:function(value){
//     if(typeof value !=="string"){
//         throw("value must be string");
//     }

//         data = value;//

//    },
//    get:function(){
//         // return this.name;//get//
//         return data;


//    }
//     // enumerable:false,//loop
//     // configurable:false//delete

// });
// })();

// obj.name = "aya";//set
// console.log(obj.name);//get
//  Object.defineProperties(obj,{
//     "name":{
//         value:"hamada",
//         writable:false
//     },
//     "age":{
//         get:function(){

//         }
//     }

//  });

//closure 
// var counterAdd= (function () {
//     var counter = 0;
//     var x = 10;

//     return function () {
//         counter += 1;
//         return counter;
//     }
// })();

// console.log(counterAdd());
// console.log(counterAdd());
// console.log(counterAdd());

