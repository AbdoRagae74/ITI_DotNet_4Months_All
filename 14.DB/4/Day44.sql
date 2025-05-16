use ITI

select salary
from Instructor

select sum(salary) as totalbud
from Instructor

select count(ins_id) as cnt
from Instructor

select min(salary),Max(salary)
from Instructor

select count(*),count(st_id),count(st_fname),count(st_age)
from Student 

select avg(st_age)
from Student

select avg(isnull(st_age,0))
from Student

select sum(St_Age)/count(*)
from Student

select sum(salary),dept_id
from Instructor
group by Dept_Id

select sum(salary),d.dept_id,dept_name
from Instructor i inner join Department d
	on d.Dept_Id = i.Dept_Id
group by d.dept_id,dept_name

select count(st_id),st_address
from Student
group by St_Address

select count(st_id),dept_id
from Student
group by dept_id

select count(st_id),st_address,Dept_Id
from Student
group by st_address,Dept_Id

select sum(salary),Ins_Degree
from Instructor
group by Ins_Degree

select sum(salary),Dept_Id
from Instructor
group by Dept_Id

select sum(salary),Dept_Id,Ins_Degree
from Instructor
group by Dept_Id,Ins_Degree

select sum(salary),Dept_Id
from Instructor
group by Dept_Id

select sum(salary),Dept_Id
from Instructor
where Salary>1000
group by Dept_Id

select sum(salary),Dept_Id
from Instructor
group by Dept_Id

select sum(salary),Dept_Id
from Instructor
group by Dept_Id
having sum(Salary)>30000

select sum(salary),Dept_Id
from Instructor
group by Dept_Id
having count(ins_id)>6
---------------------------------------------
--subqueries
select *
from Student
where st_age<(select avg(st_age) from Student)

select * , (select count(st_id) from Student)
from Student

select dept_name
from Department
where Dept_Id  in ( select distinct dept_id
                   from Student
				   where dept_id is not null)

select distinct dept_name
from Student s inner join Department d
	on d.Dept_Id = s.Dept_Id

--joins   + DML
--subqueries + DML
delete from Stud_Course
where St_Id=1

delete from Stud_Course
where crs_id in (select crs_id from course where crs_name in('db','html'))
-------------------------------------------------------------------------
--set operators
union all    union     intersect    except

--batch  --set of independent queries
select st_fname
from Student
union all
select ins_name
from Instructor

select st_fname as [names]
from Student
union all
select ins_name
from Instructor

select st_fname,st_id
from Student
union all
select ins_name , ins_id
from Instructor

select convert(varchar(10),st_id)
from Student
union all
select ins_name
from Instructor

select st_fname
from Student
union --distinct -->order + unique
select ins_name
from Instructor

select st_fname
from Student
intersect
select ins_name
from Instructor

select st_fname,st_id
from Student
intersect
select ins_name,ins_id
from Instructor

select st_fname
from Student
except
select ins_name
from Instructor


--grouping  Agg functions
--subqueries
--set operators
--Data types
----------Numeric DT
bit      --boolean    false:true   0:1
tinyint  --1byte      0:255
smallint --2B      -32768:+32767
int      --4B
bigint   --8B
----------Decimal DT
smallmoney   --4B    .0000$
money        --8B    .0000P    
real                 .0000000
float                .0000000000000000000000000
dec  decimal    dec(5,2)  123.43    12.3      65.322 XXXXXX
----------Text   DT
char(10)     --Arrays  --fixed length character   ahmed 10    ali 10   على محمد ???
varchar(10)  --variable length character   ahmed 5   ali 3
nchar(10)    unicode Language محمد 
nvarchar(10) unicode Language 
nvarchar(max) --up to 2GB
----------Date & Time DT
Date   MM/dd/yyyy
Time   hh:mm:12.876
Time(7) hh:mm:12.8768743
smalldatetime MM/dd/yyyy hh:mm:00           [year range 100]
datetime      MM/dd/yyyy hh:mm:ss.432       [year range 1753:9999]
datetime2(7)  MM/dd/yyyy hh:mm:ss.5343344   [year range 1:9999]
datetimeoffset  5/5/2025  10:30 +2:00
----------binary DT
binary     1000011  1111110  111100101
image
----------other DT
xml
uniqueidentifier
geography
sql_variant
hierarchyid
----------------------------------------------------
select st_fname,dept_id,st_age
from Student
where St_Address ='cairo'

select st_fname,dept_id,st_age
from Student
order by st_address

select st_fname,dept_id,st_age
from Student
order by 1

select st_fname,dept_id,st_age
from Student
order by 3

select st_fname,dept_id,st_age
from Student
order by dept_id asc,st_age desc

select st_fname+' '+st_lname as fullname
from Student
order by fullname

select st_fname+' '+st_lname as fullname
from Student
where fullname='ahmed hassan'

select st_fname+' '+st_lname as fullname
from Student
where st_fname+' '+st_lname='ahmed hassan'

select *
from (select st_fname+' '+st_lname as fullname
      from Student) as newtable
where fullname='ahmed hassan'

--execution order
--from
--join
--on
--where
--group by
--having
--select
--order 
--top
--into

drop table student  --DDL    data & metadata   --child

delete from student  --Data DML     where   slower  --log file  --rollback
                     --parent   child

truncate table student --data   faster  --sometimes log  --can't rollback
                       --child   reset identity  --ddl

insert into test values('omar')
select * from test
delete from test
truncate table test
----------------------------------------------------
--batch   script   transaction
--batch
--set of ind queries

insert
update
delete

--ddl
--script
create table
go
drop table
go
sp_bindrule
go
create rule

--transaction
--set of dependent queries
--run as single of work

create table parent (Pid int primary key)

create table child (cid int foreign key references parent(pid))

insert into Parent  values(1)
insert into Parent  values(2)
insert into Parent  values(3)
insert into Parent  values(4)
insert into Parent  values(5)

insert into child values(1)
insert into child values(22)
insert into child values(3)

begin transaction
	insert into child values(1)
	insert into child values(2)
	insert into child values(3)
rollback




begin try
	begin transaction
		insert into child values(1)
		insert into child values(20)
		insert into child values(3)
	commit
end try
begin catch
	rollback
	select ERROR_LINE() , ERROR_MESSAGE(), ERROR_NUMBER()
end catch



select * from child
truncate table child


begin try
	insert into child values(1)
end try
begin catch
	select 'duplicate ID'	
end catch

--transaction Properties   ACID

begin transaction
	insert
	truncate   --log
	update
	delete -----> error    rollback

-----------------------------------------
















--script & transaction






