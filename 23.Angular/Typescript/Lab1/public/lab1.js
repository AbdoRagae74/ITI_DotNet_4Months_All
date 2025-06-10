"use strict";
let arr = [];
arr.push(2);
arr.push("2");
console.log(arr);
// 2
function values(arr) {
    let num = [];
    let allnumbers = true;
    let allstrings = true;
    arr.forEach(element => {
        if (typeof (element) == typeof (2)) {
            allstrings = false;
            num.push(element);
        }
        if (typeof (element) == typeof ("2"))
            allnumbers = false;
    });
    if (allnumbers) {
        let ans = 0;
        num.forEach(element => {
            ans = ans + element;
        });
        return ans;
    }
    if (allstrings) {
        let ans = "";
        arr.forEach(element => {
            ans = ans + element;
        });
        return ans;
    }
    else {
        num.sort((a, b) => a - b);
        let ans = "";
        num.forEach(element => {
            ans += element;
        });
        return ans;
    }
}
let arrs = [1, 9, 4, "4"];
let arrs2 = ["1", "2", "3"];
console.log(values(arrs));
//3
class Shape {
    area() {
    }
    perimeter() {
    }
}
class Rectangle extends Shape {
    constructor(width, height) {
        super();
        this.width = width;
        this.height = height;
    }
    area() {
        return this.width * this.height;
    }
    perimeter() {
        return (this.width + this.height) * 2;
    }
}
class Circle extends Shape {
    constructor(radius) {
        super();
        this.radius = radius;
    }
    area() {
        return 3.14 * this.radius * this.radius;
    }
    perimeter() {
        return 2 * 3.14 * this.radius * this.radius;
    }
}
//5
class Employee {
    constructor(id, fname, lname, age, salary, address) {
        this.id = id;
        this.fname = fname;
        this.lname = lname;
        this.age = age;
        this.salary = salary;
        this.address = address;
    }
    get getSalary() {
        return this.salary;
    }
}
let emp = new Employee(1, "ahmed", "Ali", 25, 18000, { city: "Cairo", street: "25 st", zcode: 123 });
console.log(emp.getSalary);
//6
class Manager extends Employee {
    empData(empID) {
        if (this.id == empID) {
            console.log("Employee Data:");
            console.log("ID:", this.id);
            console.log("Name:", this.fname, this.lname);
            console.log("Age:", this.age);
            console.log("Salary:", this.salary);
            console.log("Address:", this.address.city, this.address.street, "zcode", this.address.zcode);
        }
    }
}
let manager = new Manager(1, "ahmed", "Ali", 25, 18000, { city: "Cairo", street: "25 st", zcode: 255452 });
manager.empData(1);
// let emps:Employee[] =
//  [
//     new Employee(1,"ahmed","Ali",25,18000,{city:"Cairo",street:"25 st" , zcode:123}),
//     new Employee(2,"mohamed","Ali",26,19000,{city:"Cairo",street:"25 st" , zcode:456}),
//     new Employee(3,"mona","Ali",27,20000,{city:"port said",street:"25 st" , zcode:789}),
//     new Employee(4,"amr","Ali",29,21000,{city:"benha",street:"25 st" , zcode:485}),
//     new Employee(5,"mostafa","Ali",29,22000,{city:"menofia",street:"25 st" , zcode:1256}),
//     new Employee(6,"hassan","Ali",27,23000,{city:"alex",street:"25 st" , zcode:255452}),
// ]
