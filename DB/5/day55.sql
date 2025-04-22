---Security
------------authentication [login Name + password]
--->windows auth
--=====> winds admin ====> SQL server admin

--->SQL Server auth
--=====> create new login + new password



------------authorization [permissions] [SQL server schema]
--[SQL Server Schema]
--object [schema Name].[object Name]
--default schema 
--dbo  database owner
select * from student
select * from dbo.student
--logical group of objects

create schema HR

create schema sales

alter schema HR transfer student

alter schema HR transfer instructor

alter schema sales transfer department

select * from hr.student

create table student
(id int,name varchar(20))

select * from Student

create table sales.student
(id int,name varchar(20))

--permissions
--login -->user --iti
--------------------student & instructor
--------------------grant     select insert
--------------------Deny      update delete
--10 steps of security
-----------------------
--1-change auth mode
--2-restart service
--3-create login
--4-create user
--5-create schema
--6-assign tables in schema
--7-link schema +user
--8-set permissions
--9-disconnect --reconnect
--10-test queries --new query
select suser_name()

alter schema dbo transfer sales.department

alter schema dbo transfer hr.instructor

use AdventureWorks2012

select * from HumanResources.JobCandidate

select * from [HumanResources].[EmployeeDepartmentHistory]

--fullpath object
--ServerName.DBName.SchemaName.ObjectName

select * from student

select * from [RAMI].[ITI].dbo.student

select * from project  --->[rami].[iti].[dbo].project

select * from Company_SD.dbo.Project

select dept_name from department
union all
select dname from Company_SD.dbo.Departments

use ITI

select * from AdventureWorks2012.HumanResources.EmployeeDepartmentHistory

--shortcut
--synonym
create synonym EDH
for AdventureWorks2012.HumanResources.EmployeeDepartmentHistory

select * from EDH
-----------------------------------------------------------
--transact-SQL queries
--top  select into  newid  insertbasedonselect bulkinsert Merge ranking
select *
from Student

select *
from Student
where St_Address='alex'

select top(2)*
from Student

select top(5) st_fname
from Student

select top(1)*
from Student

select top(1)*
from Student
where St_Address='alex'

select max(Salary)
from Instructor

select top(2) max(Salary)
from Instructor

--from select order top
select top(2) salary
from Instructor
order by salary desc

--newid  --builtin function   GUID
select NEWID()

select * , newid() as Xid
from Student
order by xid

select top(1)*
from Student

select top(1)*
from Student
order by newid()  [uniqueidentifer]

select top(10)*
from questions  
order by newid()
-----------------------------------
--select into
--ddl query
--create table from existsing
select *
from Student

select * into tab2
from Student

select * into tab3
from Student

select st_id,st_fname into tab5
from Student
where st_address ='alex'

select * into company_sd.dbo.topic
from topic

select * into hr.student  --copy
from Student

alter schema hr transfer student   --rename

select * into tab7
from student
where 1=2 --false condition   age<0

--insert based on select
insert into tab5
values(77,'ali')

insert into tab5
values(7744,'ali'),(7765,'eman'),(888,'ali')

insert into tab5
select st_id,st_fname from Student where St_Address='cairo'

--bulk insert
--insert data from file
--delimited file
bulk insert tab5
from 'f:\mydata.txt'
with (fieldterminator=',')

select *
from (select * , ROW_NUMBER() over(order by st_age desc) as RN
      from student) as newtable
where RN=1

select *
from (select * , Dense_rank() over(order by st_age desc) as DR
      from student) as newtable
where DR=1

select *
from (select * , NTile(3) over(order by st_age desc) as G
      from student) as newtable
where G=1


select *
from (select * , ROW_NUMBER() over(Partition by dept_id order by st_age desc) as RN
      from student) as newtable
where RN=1


select *
from (select * , Dense_rank() over(Partition by dept_id order by st_age desc) as DR
      from student) as newtable
where DR=1


select *
from (select * , NTile(2) over(Partition by dept_id order by st_id desc) as G
      from student) as newtable
where G=1 and Dept_Id=10


select *
from (select * , NTile(2) over( order by st_id desc) as G
      from student) as newtable
where G=1 

select * 
from (select * , NTile(2) over(Partition by dept_id order by st_id desc) as G
      from student) as newtable
where G=1 
-----------------------------------------------------
--Security
--transact-SQL



----------------------------------------------------
