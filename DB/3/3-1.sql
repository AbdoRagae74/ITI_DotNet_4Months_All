-- 1.	Display the Department id, name and id and the name of its manager.
select Dnum , Dname , MGRSSN , e.Fname+' '+e.Lname [Manager name] from 
Departments d , Employee e
where d.mgrssn = e.ssn;

--2.	Display the name of the departments and the name of the projects under its control.

select d.Dname , p.Pname 
from Departments d , Project p
where d.Dnum = p.Dnum;

--3.	Display the full data about all the dependence associated with the name of the employee they depend on him/her.
select d.* , e.Fname+' '+e.Lname[Employee name] 
from Dependent d , Employee e
where e.SSN = d.ESSN

-- 4.	Display the Id, name and location of the projects in Cairo or Alex city.

select Pname , Pnumber , Plocation  
from Project
where City in ('cairo','alex')

--5.	Display the Projects full data of the projects with a name starts with "a" letter.

select * 
from Project
where Pname like'a%'

-- 6.	display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select * 
from Employee 
where Dno = 30 and Salary between 1000 and 2000
--7.	Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.
select * 
from Employee e inner join Works_for w
on e.Dno = 10 and e.SSN = w.ESSn and w.Hours>=10
join Project p
on p.Pname = 'AL Rabwah' and p.Pnumber = w.Pno


--8.	Find the names of the employees who directly supervised with Kamel Mohamed.
select e.* 
from Employee s
inner join
employee e
on s.Fname+' '+s.Lname = 'Kamel Mohamed' and s.SSN = e.Superssn

--9.	Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
select e.Fname,e.Lname, p.Pname
from Employee e inner join Works_for w
on w.ESSn = e.SSN
inner join Project p
on p.Pnumber = w.Pno
order by p.Pname

-- 10.	For each project located in Cairo City ,
--find the project number, the controlling department name ,the department manager last name ,address and birthdate.

select p.Pnumber ,d.Dname , e.Lname , e.Address , e.Bdate   
from Project p
inner join Departments d
on p.Dnum = d.Dnum
inner join Employee e
on e.SSN = d.MGRSSN
where p.City='cairo'

select * from project
select * from Departments

--11.	Display All Data of the managers
select  e.*
from Departments d 
inner join Employee e
on e.SSN = d.MGRSSN

--12.	Display All Employees data and the data of their dependents even if they have no dependents
select *
from Employee e
left join 
Dependent d
on d.ESSN = e.SSN
order by essn
select * from Employee
-- 13.	Insert your personal data to the employee table as a new 
--employee in department number 30, SSN = 102672, Superssn = 112233, salary=3000.
insert into Employee values('AbdelRahman','Ragae',102672,'2001-02-28','Banha','M','3000',112233,30)

--14.	Insert another employee with personal data your friend as
--new employee in department number 30, SSN = 102660, but don’t enter any value for salary or supervisor number to him.
insert into Employee(Fname,Lname,SSN,Bdate,Address,Sex,Dno)
values('Ahmed','Mahmoud',102660,'2001-7-15','Banha','M',30)

-- 15.	Upgrade your salary by 20 % of its last value.
update Employee
set Salary = Salary*1.2 
where ssn = 102672
