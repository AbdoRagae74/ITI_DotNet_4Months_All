-- 1.	Retrieve number of students who have a value in their age. 
select count(*)
from Student
where St_Age is not null

-- 2.	Get all instructors Names without repetition

select  distinct Ins_Name
from Instructor

-- 3.	Display student with the following Format (use isNull function)

select St_Id [Student ID],concat(St_Fname,' ',St_Lname) [Student Full Name] , d.Dept_Name [Depratment Name]
from Student s join Department d
on d.Dept_Id = s.Dept_Id
where concat(St_Fname,' ',St_Lname) is not null ;

-- xx
-- 4.	Display instructor Name and Department Name  Note: display all the instructors if they are attached to a department or not

select i.Ins_Name , d.Dept_Name 
from Instructor i left join Department d
on i.Dept_Id = d.Dept_Id

-- 5.	Display student full name and the name of the course he is taking For only courses which have a grade  

select concat(St_Fname,' ',St_Lname) [Student Full Name] , c.Crs_Name
from Student s join Stud_Course sc
on s.St_Id = sc.St_Id
join course c
on sc.Crs_Id = c.Crs_Id
where sc.Grade is not null
--xx
-- 6.	Display number of courses for each topic name

select t.Top_Name, count(t.top_id)
from Course c join Topic t
on c.Top_Id = t.Top_Id
group by t.Top_Name

-- 7.	Display max and min salary for instructors

select min(Salary) , max(Salary) 
from Instructor
--where Salary is not null

-- 8.	Display instructors who have salaries less than the average salary of all instructors.
	select * 
	from Instructor
	where Salary < (select avg(salary) from Instructor)
-- 9.	Display the Department name that contains the instructor who receives the minimum salary.
select * 
from Department
where Dept_Id = (
select top(1)*
from Instructor 
order by Salary
)
-- 10.	 Select max two salaries in instructor table. 
select top(2) salary
from Instructor
order by Salary desc

-- 11.	 Selexct instructor name and his salary but if there is no salary display instructor bonus keyword. “use coalesce Function”
select Ins_Name , coalesce(Salary,'instructor bonus')
from Instructor 
-- 12.	Select Average Salary for instructors 

select AVG(salary) from Instructor

-- 13.	Select Student first name and the data of his supervisor 

select CONCAT(st.St_Fname,st.St_Lname)[Student name] ,  s.* 
from Student st join Student s
on st.St_super = s.St_Id

-- 14.	Write a query to select the highest two salaries in Each Department for instructors who have salaries.
--“using one of Ranking Functions”

select *
from (select * , ROW_NUMBER() over(partition by dept_id order by salary desc) as RN
from Instructor
where Salary is not null 
) as salaries
where RN <3

-- 15.	 Write a query to select a random student from each department.  “using one of Ranking Functions”

select 
* from(select * ,ROW_NUMBER() over(partition by dept_id order by newid()) as RN 
from Student
where Dept_Id is not null)as t
where RN = 1



select @@error 

