-- 1.	 Create a scalar function that takes date and returns Month name of that date.

alter function getMonth(@date datetime)
returns varchar(10)
as
begin 
declare @dateName varchar(10)
	set @dateName = convert(varchar,datename(month,getdate()))
	return @dateName;
end

select dbo.getMonth(getdate())

-- 2.	 Create a multi-statements table-valued function that takes 2 integers and returns the values between them.

create function getValuesInBetween(@start int , @end int)
returns @numbers table (num int)
as 
begin
	while @start<=@end
	begin 
		insert into @numbers select @start
		set	@start+=1
	end

return 
end;

SELECT * FROM getValuesInBetween(12, 80);

-- 3.	 Create inline function that takes Student No and returns Department Name with Student full name.

alter function getStdData(@id int)
returns table
as
return(

select  concat_ws(' ',s.St_Fname , s.St_Lname ) Fullname , d.Dept_Name
from Student s join Department d
on d.Dept_Id = s.Dept_Id and s.St_Id = @id
)

select * from getStdData(2)





--select datename(month,GETDATE())
SELECT SQL_VARIANT_PROPERTY(GETDATE(), 'BaseType') AS DataType;

--4.	Create a scalar function that takes Student ID and returns a message to user 
-- a.	If first name and Last name are null then display 'First name & last name are null'
-- b.	If First name is null then display 'first name is null'
-- c.	If Last name is null then display 'last name is null'
-- d.	Else display 'First name & last name are not null'

alter function checkUserName(@id int)
returns varchar(50)
as
begin
 declare @fname varchar(50) , @lname varchar(50),@message varchar(80);
 set @fname = (select St_Fname from Student where St_Id = @id)
 set @lname = (select s.St_Lname from Student s where St_Id = @id)
 if @fname is null and @lname is null 
 set @message =  'First name & last name are null'
 else if @fname is null 
 set @message = 'first name is null'
 else if @lname is null 
 set @message = 'last name is null'
 else
 set @message = 'First name & last name are not null'
 return @message
end

select dbo.checkUserName(17)


--SELECT *
--INTO ITI.dbo.Employee
--FROM [Company_SD].[dbo].[Employee]

--SELECT *
--INTO ITI.[dbo].[Departments]
--FROM [Company_SD].[dbo].[Departments]

--5.	Create inline function that takes integer which represents manager ID 
--and displays department name, Manager Name and hiring date 
alter function getManagerData (@mId int)
returns table 
as 
return
(
select d.Dept_Name, i.Ins_Name , d.Manager_hiredate
from Instructor i join Department d
on d.Dept_Manager = i.Ins_Id and d.Dept_Manager = @mId
)
select * from dbo.getManagerData(3)

select * from Instructor
select * from Department
select * from Instructor
--6.	Create multi-statements table-valued function that takes a string
--If string='first name' returns student first name
--If string='last name' returns student last name 
--If string='full name' returns Full Name from student table 
--Note: Use “ISNULL” function


alter function getSTduents(@str varchar(15))
returns @names table(name varchar(50)) 
as
begin
	if @str='first name'
	begin
		insert into @names
		select isnull(St_Fname,'first name is null')
		from Student
	end
	else if @str ='last name'
	begin
		insert into @names
		select isnull(St_Fname,'last name is null')
		from Student
	end

	 else if @str= 'full name'
    BEGIN
        INSERT INTO @names
        SELECT isnull(CONCAT(St_Fname,' ',St_Lname),'full name is null')
        FROM Student;
    END
return
end


--7.	Write a query that returns the Student No and Student first name without the last char

select s.St_Id , Left (s.St_Fname , len(s.St_Fname)-1) 
from Student s

--8.	Wirte query to delete all grades for the students Located in SD Department 
--24 row

delete sc
from Stud_Course sc join  Student s
on s.St_Id = sc.St_Id
join Department d
on d.Dept_Name ='SD'  and s.Dept_Id = d.Dept_Id

/*
select sc.St_Id , s.Dept_Id
from Stud_Course sc join  Student s
on s.St_Id = sc.St_Id
join Department d
on d.Dept_Name ='SD'  and s.Dept_Id = d.Dept_Id
*/

-- 9.	Using Merge statement between the following two tables [User ID, Transaction Amount]

--create table dailyTransactions(
--userId int primary key,
--Transaction_Amount int
--)

--create table LastTransactions(
--userId int primary key,
--Transaction_Amount int
--)

merge into LastTransactions as t
using dailyTransactions as s
on t.userId = s.userId
when matched then
	update set t.Transaction_Amount = s.Transaction_Amount
	when not matched then 
	insert (userId,Transaction_Amount)
	values(s.userId,s.Transaction_Amount);