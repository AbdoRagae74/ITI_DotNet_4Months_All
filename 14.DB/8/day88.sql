

create Proc getdata
as
	SELECT Course.Crs_Name, Stud_Course.Grade, Student.St_Fname
	FROM   Course INNER JOIN
             Stud_Course ON Course.Crs_Id = Stud_Course.Crs_Id INNER JOIN
             Student ON Stud_Course.St_Id = Student.St_Id
	WHERE (Stud_Course.Grade > 50)
	ORDER BY Course.Crs_Name

getdata
execute getdata
exec getdata

alter Proc getstbyadd @add varchar(30)
as
	select st_id , st_fname
	from Student
	where St_Address=@add

getstbyadd 'cairo'
getstbyadd 'alex'

alter schema hr transfer getstbyadd

hr.getstbyadd 'cairo'

alter schema dbo transfer hr.getstbyadd

drop proc getstbyadd

--SP   DML

alter proc deltopic @tid int
as
	if not exists(select top_id from course where top_id=@tid)
		delete from topic where top_id=@tid
	else
		select 'table has relationship'

deltopic 30
--------------------------------------------------------------
--Paramaters & return values
alter proc sumdata @x int=200,@y int=100
as
	select @x+@y

sumdata 4,7  --passing parameters by position
sumdata @y=9,@x=1 --passing parameters by name
sumdata 3
sumdata
----------------------------------------------
--return values
alter Proc getstbyadd @add varchar(30)
as
	select st_id , st_fname
	from Student
	where St_Address=@add

declare @t table(x int,y varchar(20))
	insert into @t
	execute getstbyadd 'cairo'
select * from @t
select count(*) from @t

insert into tab5
execute getstbyadd 'cairo'
---------------------------------------------------
--return one value   [scalar function]
create proc getmydata @id int
as
	declare @age int
		select @age =st_age from Student
		where st_id=@id
	return @age

declare @x int
	execute @x=getmydata 1
select @x
---------------------------------------------------------
alter proc getmydata @id int , @age int output
as
		select @age =st_age from Student
		where st_id=@id
	
declare @x int
	execute getmydata 1 ,@x output
select @x
-------------------------------------------
alter proc getmydata @id int , @age int output , @name varchar(20) output
as
		select @age =st_age,@name =st_fname from Student
		where st_id=@id

declare @x int , @y varchar(20)
	execute getmydata 4 ,@x output,@y output
select @x,@y
---------------------------------------------
alter proc getmydata  @z int output , @name varchar(20) output
as
		select @z =st_age,@name =st_fname from Student
		where st_id=@z

declare @x int=4 , @y varchar(20)
	execute getmydata @x output,@y output
select @x,@y
----------------------------------------------
--dynamic query
create proc getvalues @col varchar(20),@t varchar(20)
as
	execute('select '+@col+' from '+@t)

--calling
getvalues 'salary','instructor'
-------------------------------------------------
--3 types of SP
----------------
--1- user defined SP
deltopic  getstuds   getstbyadd  sumdata

--2-builtin sP
sp_bindrule  sp_addtype  sp_rename  sp_helptext .......

--3-trigger
--special type of SP
--can't call
--can't Parameters
--implicit code
--automatic firing according action
--triggers [tables]   [insert,update,delete]        [select,truncate]XXXX


create trigger tr_1
on student
after insert
as
	select 'welcome to ITI'

insert into Student(st_id,st_fname)
values(399,'ahmed')
-------------------------------------------------
create trigger tr_2
on student
for update
as
	select getdate(),suser_name(),db_name(),host_name()

update student set st_age+=1
-----------------------------------------------
create trigger tr_3
on student
instead of delete
as
	select 'not allowed'

delete from student where st_id=14
----------------------------------------------
create trigger tr_4
on department
instead of insert,update,delete
as
	select 'not allowed for user = ' +suser_name()

update department
	set dept_name='cloud'
where dept_id=10

alter table department disable trigger tr_4
alter table department enable trigger tr_4

--Levels
--server    --db     --schema   --object
---------------------------------------------------
alter trigger tr_5
on course
after update
as
	if update(crs_name)
		select 'welcome to ITI'


update course
	set crs_duration=100
where crs_id=100
------------------------------------------------------
create trigger tr_10
on course
after update
as
	select * from inserted
	select * from deleted

update course
	set crs_name='html',crs_duration=90,top_id=5
where crs_id=100

update course
	set crs_name='cloud',crs_duration=100,top_id=1
where crs_id=200

create trigger tr_11
on course
instead of delete
as
	select 'not allowed to delete course name = '+(select crs_name from deleted)

delete from course where crs_id=1000
delete from course where crs_id=1200

create trigger tr_90
on student
instead of insert
as
	if format(getdate(),'dddd')='friday'
		select 'not allowed'
	else
		insert into student
		select * from inserted

create trigger tr_90
on student
after insert
as
	if format(getdate(),'dddd')='friday'
		begin
			select 'not allowed'
			delete from studnet where st_id =(select st_id from inserted)
		end

-----------------------------------------------------------------
create table history_audit
(
 _user varchar(100),
 _date date,
 _olddata int,
 _newdata int,
 _ActionNote varchar(100)
)

create trigger tr_100
on topic 
instead of update
as
	if update(top_id)
		begin
			declare @old int,@new int
				select @old=top_id from deleted
				select @new=top_id from inserted
			insert into [history_audit]
			values(suser_name(),getdate(),@old,@new,'update topic table')
		end
		

create trigger tr_200
on topic 
instead of delete
as
	insert into [history_audit]
	values(suser_name(),getdate(),(select top_id from deleted),NULL,'delete topic')
	

create trigger tr_600
on department 
after update
as
	insert into [history_audit]
	values(suser_name(),getdate(),(select dept_id from deleted),(select dept_id from inserted),'update department table')

-----------------------------------------------------
--table  view  function SP trigger constraint rule
----------------------------------------------------
--types of backups
---full backup
---differential backup
---transaction Log backup

--db   .mdf    .ldf

























