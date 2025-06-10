
// 1
type stringOrNumber = string | number;
let arr : stringOrNumber []=[]; 
arr.push(2);
arr.push("2");
console.log(arr);

// 2
function values(arr:stringOrNumber[]) : stringOrNumber {
    let num :number[]=[];
    let allnumbers:boolean = true;
    let allstrings:boolean = true;

    arr.forEach(element => {
        if(typeof(element)== typeof(2))
            {
                allstrings = false;
                num.push(element as number);
            }
            
        if(typeof(element)== typeof("2"))
            allnumbers = false;
    });
    
    if(allnumbers){
        let ans :number = 0;
        num.forEach(element => {
            ans = ans + (element as number);
        });
        return ans;
    }
    if(allstrings){
        let ans :string = "";
        arr.forEach(element => {
            ans = ans + (element as string);
        });
        return ans;
    }

    else {
        num.sort((a,b)=>a-b);
        let ans: string = "";
        num.forEach(element => {
           ans+=element; 
        });
        return ans; 
    }
    
}
let arrs : stringOrNumber[] = [1,9,4,"4"];
let arrs2 : stringOrNumber[] = ["1","2","3"];
console.log(values(arrs));

//3
abstract class Shape {   
    area(){
        
    }
    perimeter(){
    }
}
class Rectangle extends Shape{
    constructor(public width:number , public height:number){
        super();                
    }
    override area():number {
        return this.width * this.height;
    }

    override perimeter():number {
        return (this.width + this.height)*2;
    }
}

class Circle extends Shape{
    constructor(public radius:number ){
        super();                
    }
    override area():number {
        return 3.14 * this.radius*this.radius;
    }

    override perimeter():number {
        return 2 * 3.14*this.radius * this.radius;
    }
}

//4
interface IEmployee{
    id:number,
    fname:string,
    lname:string,
    age:number,
    salary:number,
    address:{city:string , street:string, zcode:number}
}
//5
class Employee implements IEmployee{
    constructor(
        public id:number,
        public fname:string,
        public lname:string,
        public age:number,
        public salary:number,
        public address:{city:string , street:string, zcode:number}
     ){}
     get getSalary():number{
        return this.salary;
     } 
}
let emp :Employee = new Employee(1,"ahmed","Ali",25,18000,{city:"Cairo",street:"25 st" , zcode:123});
console.log(emp.getSalary)

//6
class Manager extends Employee{
    private emps:Employee[] =[];
    addEmp (emp:Employee):void{
        this.emps.push(emp);
    }
    empData(empID:number){
        let emp = this.emps.find(e=>e.id == empID);
        if(emp)
        {
            console.log("Employee Data:");
            console.log("ID:", emp.id);
            console.log("Name:" ,emp.fname,emp.lname);
            console.log("Age:" ,emp.age)
            console.log("Salary:", emp.salary);
            console.log("Address:", emp.address.city, emp.address.street, "zcode",emp.address.zcode);
            
        }
    }
}

let manager = new Manager(1,"ahmed","Ali",25,18000,{city:"Cairo",street:"25 st" , zcode:255452});

    manager.addEmp(new Employee(1,"ahmed","Ali",25,18000,{city:"Cairo",street:"25 st" , zcode:123}));
    manager.addEmp(new Employee(2,"mohamed","Ali",26,19000,{city:"Cairo",street:"25 st" , zcode:456}));
    manager.addEmp(new Employee(3,"mona","Ali",27,20000,{city:"port said",street:"25 st" , zcode:789}));
    manager.addEmp(new Employee(4,"amr","Ali",29,21000,{city:"benha",street:"25 st" , zcode:485}));
    manager.addEmp(new Employee(5,"mostafa","Ali",29,22000,{city:"menofia",street:"25 st" , zcode:1256}));
    manager.addEmp(new Employee(6,"hassan","Ali",27,23000,{city:"alex",street:"25 st" , zcode:255452}));

manager.empData(2);





















