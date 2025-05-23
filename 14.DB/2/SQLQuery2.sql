-- 1.	Display all the employees Data.

select * 
from Employee;

--2.	Display the employee First name, last name, Salary and Department number.

select Fname,Lname , Salary , Dno
from Employee;

--3.	Display all the projects names, locations and the department which is respons2ible about it.

select Pname,Plocation,Dnum 
from Project
-- 4.Display each employee full name and his annual commission in an ANNUAL COMM column (alias).

select  Fname+' ' +Lname [Full name] , (Salary * 0.1 * 12) [ANNUAL COMM] 
from Employee   ;

--5.	Display the employees Id, name who earns more than 1000 LE monthly.
select SSN , Fname+' ' + Lname [Full Name]--, Salary 
from Employee	
where Salary>1000;

--6.	Display the employees Id, name who earns more than 10000 LE annually.

select SSN , Fname+' ' + Lname [Full Name], Salary 
from Employee	
where Salary*12>10000;

-- 7.	Display the names and salaries of the female employees 

select Fname , Lname , Salary 
from Employee
where sex='F';

--8.	Display each department id, name which managed by a manager with id equals 968574.
select Dname , Dnum
from Departments
where MGRSSN=968574;

--9.	Dispaly the ids, names and locations of  the pojects which controled with department 10.
select Pname,Pnumber ,Plocation
from Project
where Dnum = 10;