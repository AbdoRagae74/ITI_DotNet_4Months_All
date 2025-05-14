--1.	Create a stored procedure without parameters to show the number of students per department name
create proc stuPerDep
as
select d.Dept_Name,count(*) from
Student s
join Department d
on d.Dept_Id = s.Dept_Id
group by d.Dept_Name



--2.	
create proc showProjData
as
declare @cnt int
select cnt = count(p.pnumber)
from Works_for w
join project p 
on p.pnumber = w.Pno and p.pnumber = 100

if @cnt>3
	select 'The number of employees in the project p1 is 3 or more'
else 
select 'The following employees work for the project p1'
union all
select e.fname+e.lname [Full name]
from employee e join Works_for w
on e.ssn = w.ESSn 
and w.Pno = 100

showProjData


-- 3

alter proc updateWorksFor @oldNo int ,@newNo int ,@projNo int
as
begin try
	update Works_for 
	set essn = @newNo
	where essn = @oldNo and pno = @projNo
end try
begin catch
	select 'Error occured'
end catch

updateWorksFor 512463,102672,100 

-- 4
--alter table project add budget int

create table project_audit
(
pnumber int,
userName varchar(50),
modifiedDate date,
budgeOld int,
budgetBew int
)

alter trigger updateBudget
	on project 
	after update 
	as
	if update(budget)
	begin
		declare @oldBud int , @newBud int , @pnum int
		select @oldBud = budget from deleted
		select @newBud = budget from inserted
		select @pnum = pnumber from inserted
		insert into project_audit 
		values(@pnum , SUSER_NAME(),GETDATE(),@oldBud,@newBud)
	end


--5
use iti

create trigger preventDeptInsert
on [dbo].[Department]
instead of insert
as
select 'U cant insert new row in that table'


insert into Department
values(500,'sad','asdasd','asdg',2,GETDATE())

----6
use Company_SD
alter trigger preventOnMarch
on employee 
instead of insert
as
if format(getdate(),'MM') = 3
	begin
	select 'You cant insert any employee on march'	
	end
	else
	insert into employee
	select * from inserted 

select * from employee

insert into employee 
values('a','b',120,GETDATE(),'sadf','F',12,102672,30)

--7
create table student_audit
(
serverUserName varchar(50),
ModificationDate date,
note varchar(200)
)
alter trigger insertedData
on Student
after insert 
as
	declare @newId int
	select @newId = st_id from inserted
	insert into student_audit
	values(SUSER_NAME() , GETDATE(),  SUSER_NAME()+' inserted new row wit key =[ '+convert(varchar ,@newId)+' ] in table stduent')


-- 8
create trigger preventDelete 
on student
instead of delete 
as
	declare @delId int
	select @delId = st_id from deleted
	insert into student_audit
	values(SUSER_NAME() , GETDATE(),  SUSER_NAME()+' Tried to delete row with key = [ '+convert(varchar ,@delId)+' ] in table stduent')

	




