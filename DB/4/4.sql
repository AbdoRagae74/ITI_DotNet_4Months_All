
--1.	Display (Using Union Function)
select d.Dependent_name , d.Sex 
from Dependent d  join Employee e
on d.Sex = e.Sex and d.Sex ='f' and d.ESSN = e.ssn 
union
select d.Dependent_name , d.Sex 
from Dependent d  join Employee e
on d.Sex = e.Sex and d.Sex ='m' and d.ESSN = e.ssn ;
-- where d.Sex ='m' and d.ESSN = e.ssn ;

-- diff between using where or and  

-- 2.	For each project, list the project name and the total hours per week (for all employees) spent on that project.
select w.ESSn, w.Hours ,p.Pname , Pno
from Project p join Works_for w
on w.Pno = p.Pnumber

-- 3.	Display the data of the department which has the smallest employee ID over all employees' ID.

select d.* from Departments d
join Employee e
on d.Dnum = e.Dno
where e.SSN= (select min(ssn) from Employee); 
-- 4.	For each department, retrieve the department name and the maximum, minimum and average salary of its employees.

select  max(salary) Max_sal ,min(salary) Min_sal  ,avg(salary) Avg_sal , d.Dname 
from Employee e join Departments d
on e.Dno = d.Dnum
group by d.Dname

-- 5.	List the full name of all managers who have no dependents.
select *
from employee e join Departments d
on e.SSN = d.MGRSSN
where e.SSN not in (
select essn from Dependent 
)
-- 6.	For each department-- if its average salary is less than the average salary of all employees
	-- display its number, name and number of its employees.
	
	select AVG(salary) , d.Dnum ,d.Dname , count(e.dno)
	from Employee e join Departments d
	on d.Dnum = e.Dno
	group by e.dno , d.Dnum ,d.Dname
	having AVG(salary) < (select AVG(salary) from Employee)

--7.	Retrieve a list of employee’s names and the projects names they are working on ordered by department number 
 -- and within each department, ordered alphabetically by last name, first name.

 select e.dno ,e.Fname , e.Lname , p.Pname 
from Project p join Works_for w
on w.Pno = p.Pnumber
join Employee e
on e.SSN = w.ESSn 
order by e.Dno , e.Fname , e.Lname

--8.	Try to get the max 2 salaries using sub query
select max(salary),(select max(salary)from Employee where salary < ( select max(salary) from Employee ))
from Employee



--9.	Get the full name of employees that is similar to any dependent name
select fname,lname 
from Employee e
join Dependent d
on e.Fname+' '+e.Lname = d.Dependent_name

--9 Subquery
select fname,lname 
from Employee e 
where e.Fname+' '+e.Lname in (select Dependent_name from Dependent )

--10.	Display the employee number and name if at least one of them have dependents (use exists keyword) self-study.

select e.SSN , e.Fname
from Employee e
where exists (
select d.essn 
from Dependent d
where e.SSN = d.ESSN
);

--11.	In the department table insert new department called "DEPT IT”, with id 100,
--employee with SSN = 112233 as a manager for this department. The start date for this manager is '1-11-2006'
insert into Departments values('DEPT IT',100,112233,'2006-11-01')

--12
BEGIN TRY
    BEGIN TRANSACTION;

	update Departments 	set MGRSSN = 968574 
	where Dnum = 100;
    update Departments set MGRSSN = 102672
	where Dnum = 20;
	update Employee set Superssn = 102672
	where SSN = 102660 ;
	COMMIT;
END TRY
BEGIN CATCH
    ROLLBACK;
select  ERROR_MESSAGE();
END CATCH;

--13

begin try
    begin transaction;
	update Departments set MGRSSN =  102672 where MGRSSN = 223344;
	update Employee set Superssn=  102672 where Superssn = 223344;
	update Works_for set ESSn =  102672 where ESSn = 223344;
	
	delete from Dependent 
	where essn = 223344;
	delete from Employee
	where ssn = 223344;
	commit;
end try
begin catch
    rollback;
select  ERROR_MESSAGE();
end catch;

-- 14.	Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30%
update Employee set salary = salary * 1.3 
where ssn in
(select w.essn
from Employee e join Works_for w 
on e.SSN = w.ESSn
join Project p
on p.Pnumber = w.Pno and p.Pname = 'Al Rabwah');


