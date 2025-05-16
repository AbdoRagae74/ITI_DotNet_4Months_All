// var obj = {
//     name:"menna",
//     age:15,
//     print:function(x){
//         //console.log(this);
//          console.log(this.name,this.age,x);
//     }
// }
// // obj.print();

// var user = {
//     name :"hamada",
//     age:30,
//     salary :2000
// }

// user.print();//change function caller

//call apply   bind  change function caller

// obj.print.call(user,5);
// obj.print.apply(user,[5]);
// var newFunc = obj.print.bind(user,5);
// newFunc();
// newFunc();

// var m = "menna";
// [].forEach.call(m,function(el){
//     console.log(el);

// })

// var obj = {
//         name:"menna",
//         age:15,
//         print:function(){
//             //this pattern
//             //=>obj = this
//            var _this = this;
//             setTimeout(function(){

//                 console.log(_this.name,_this.age);
//             },2000)
           
            // document.querySelector("div").addEventListener("click",function(){
            //     // console.log(this);
            //     console.log(_this.name,_this.age);
            // })
            // document.querySelector("div").addEventListener.call(this,"click",function(){
            //     console.log(this.name,this.age);
            // })

            
//         }
//     }
// obj.print();

//////class ==> function constructor//////////////////////

//inhertance  static class abstract class 
//override overload  static methode  private member


//user parent     name age  print();
//employee name age salary print() calcSalary(b)
//student  name age grades print() calcGrades()

function User(n,a){
    if(this.constructor ===User){
        throw("this is an abstract class");
    }
    this.name = n;
    this.age= a
}

User.prototype.print = function(){
    console.log(this.name,this.age);
}

function Employee(n,a,s,y){
    //private member
   var year  = y;
   User.call(this,n,a);
    this.salary = s;
    this.getYear = function(){
        return year;
    }
}

Employee.staticMethod = function(){
    console.log("hello myfunction")
}
Employee.prototype =  Object.create(User.prototype);
 Employee.prototype.constructor = Employee;
// Employee.prototype.print = function(){
//     console.log("hello i am employee");
// }
Employee.prototype.toString = function(){
    return this.name;
}
Employee.prototype.calcSalary = function(b){
    // if(arguments.length ==1 && typeof arguments[0] !=="number"){
    //     throw("error");

    // }
    // else if(){

    // }
    return this.salary + b;
}

// function Student(n,age,g){
//     // this.name = n;
//     // this.age = age
//     User.call(this,n,age);
//     this.grades = g
// }
// Student.prototype = Object.create(User.prototype);
// Student.prototype.calcGrades = function(){
//     return this.grades + "%";
// }
// var u = new User();
 var emp = new Employee("menna",25,3000,1994);
 console.log(emp.calcSalary(1,3));
console.log(emp.getYear());
//  emp.name = "hamada";
//  console.log(emp.name);//private method
// console.log(emp.constructor===User);
// // emp.print();
Employee.staticMethod();

// var stu = new Student("hamada",15,70);
// console.log(stu);

// document.write(emp);//emp.toString();


///////////static class
function staticClass(){
    throw("this is not a construnctor");

}
staticClass.myFunc = function(){
    console.log("static method");
}
staticClass.myFunc();

// var v = new staticClass();