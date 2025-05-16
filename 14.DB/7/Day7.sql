create clustered index i2
on student(st_fname)  ---- XXXXX

create nonclustered index i2
on student(st_fname)

create nonclustered index i5
on student(st_address)

select * from Student where st_id=4

select * from grades where sid=4

--Primary key constraint ----> clustered index
--unqiue constraint ---------> nonclustered index

create table test3
(
 id int identity,
 ssn int primary key,
 ename varchar(20),
 salary int unique,
 overtime int unique,
 constraint cc check(salary>1000)
)


create unique index i8  ---> unique constraint + nonclustered index
on student(st_age)

create index i8  --->  nonclustered index
on student(st_age)
----------------------------------------------------
declare c1 cursor
for select st_id,st_fname from Student where St_Address='cairo'
for read only   
declare @id int,@name varchar(20)
open c1
fetch c1 into @id,@name
while @@FETCH_STATUS=0
	begin
		select @id,@name
		fetch c1 into @id,@name
	end
close c1
deallocate c1
------------------------------------------------
--Array  ---->  string   --->one cell   [ahmed,amr,fady.....]
declare c1 cursor
for select distinct st_fname from Student where st_fname is not null
for read only
declare @name varchar(20),@all_names varchar(300)=''
open c1
fetch c1 into @name
while @@FETCH_STATUS=0
	begin
		set @all_names=concat(@all_names,',',@name)
		fetch c1 into @name
	end
select @all_names
close c1
deallocate c1
-----------------------------------------
declare c1 cursor
for 
for 
declare 
open c1
fetch c1 into 
while @@FETCH_STATUS=0
	begin
	end
close c1
deallocate c1
------------------
-----------------------------------------
declare c1 cursor
for select salary from Instructor
for update --Modify
declare @sal int
open c1
fetch c1 into @sal
while @@FETCH_STATUS=0
	begin
		if @sal>=5000
			update Instructor
				set Salary=@sal*1.20
			where current of c1
		else if @sal<5000
			update Instructor
				set Salary=@sal*1.10
			where current of c1
		else
			delete from Instructor
			where current of c1
		fetch c1 into @sal
	end
close c1
deallocate c1

--Index
--cursor
--rollup cube groupingsets pivoting
--view
create view vstuds
as
	select * from Student

--calling
select * from vstuds

create view vcairo(sid,sname,sadd)
as
	select st_id,st_fname,st_address
	from Student
	where St_Address='cairo'

select * from vcairo

select sname from vcairo

alter schema hr transfer vcairo

alter schema dbo transfer hr.vcairo

create view valex(sid,sname,sadd)
as
	select st_id,st_fname,st_address
	from Student
	where St_Address='alex'

select * from valex

create view vcairo_alex
as
	select * from valex
	union all
	select * from vcairo

select * from vcairo_alex

--complex queries
alter view vjoin(sid,sname,did,dname)
with encryption
as
	select st_id,st_fname , d.dept_id,dept_name
	from Student s inner join Department d
	on d.Dept_Id=s.Dept_Id

select * from vjoin
select sname,dname from vjoin

sp_helptext 'vjoin'

create view vgrades
as
	select sname,dname,grade 
	from vjoin v inner join Stud_Course sc
	on v.sid=sc.St_Id

select * from vgrades

--DML + view
-----view     one table
alter view valex(sid,sname,sadd)
as
	select st_id,st_fname,st_address
	from Student
	where St_Address='alex'
with check option

insert into valex
values(94,'ahmed','alex')

insert into valex
values(95,'ahmed','mansoura')


select * from valex


----view      multi table
create view vjoin(sid,sname,did,dname)
as
	select st_id,st_fname , d.dept_id,dept_name
	from Student s inner join Department d
	on d.Dept_Id=s.Dept_Id

--Delete  XXXXX
--insert   update
insert into vjoin(sid,sname)
values(88,'ahmed')

insert into vjoin(did,dname)
values(1000,'hr')

update vjoin
	set sname='ali'
where sid=1


insert into vjoin
values(88,'ahmed',1000,'hr')

update vjoin
	set sname='ali',dname='cloud'
where sid=1

--Jobs   [query+time]

backup database ITI
to disk='e:\ITI.bak'

backup database ITI
to disk='e:\ITI'+getdate()+'.bak'

--backup file
--dbName_type_data_time_.bak


























