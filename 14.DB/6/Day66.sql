use ITI

declare @x int =(select avg(St_age) from Student)

set @x=9

select @x=8

select @x

declare @y int
	select @y=st_Age from Student
	where st_id=9
select @y

declare @y int=100
	select @y=st_Age from Student
	where st_id=-1
select @y

declare @y int
	select @y=st_Age from Student
	where St_Address='cairo'
select @y

--Arrays  ---table variable
declare @t table(col1 int) -- 1D array of integers
	insert into @t
	values(9),(66),(3)
select * from @t
select count(*) from @t

declare @t table(col1 int) -- 1D array of integers
	insert into @t
	select st_age from Student where St_Address='cairo'
select * from @t
select count(*) from @t

declare @t table(col1 int,col2 varchar(20)) -- 2D array
	insert into @t
	select st_age,st_fname from Student where St_Address='cairo'
select * from @t
select count(*) from @t

declare @z int,@name varchar(20)
	select @z=st_age , @name=isnull(st_fname,'') from student
	where st_id=3
select @z,@name

declare @x int
	update Instructor
		set Ins_Name='omar' , @x=salary
	where Ins_Id=4
select @x

--> dynamic query
declare @par int=7

select * from Student
where st_id=@par

declare @par int=4

select top(@par)*
from Student

--dynamic  + metadata
declare @col varchar(10)='*',@t varchar(20)='student'
select @col from @t

declare @col varchar(10)='salary',@t varchar(20)='instructor'
execute('select '+@col+' from '+@t)

declare @col varchar(10)='*',@t varchar(20)='instructor',@cond varchar(20)='salary>3000'
execute('select '+@col+' from '+@t+' where '+@cond)

select 'select * from student'
execute( 'select * from student')

--Global var
select @@SERVERNAME

select @@VERSION

update Instructor set Salary+=1000
select @@ROWCOUNT

select * from Instructor where Salary>6000
select @@ROWCOUNT

select * from Student where st_age>25
select @@ROWCOUNT
select @@ROWCOUNT

select * from Studen where st_age>25
go
select @@ERROR

insert into test values('omar')
select @@IDENTITY

--control of flow statements
--if
declare @x int
update Instructor set Salary+=100
set @x=@@ROWCOUNT
if @x>0
	begin
		select 'multi rows affected'
		select 'selcome to ITI'
	end
else 
	begin
		select 'zero rows affected'
	end


--begin end
--if exists if not exists

if exists(select top_id from course where top_id=10)
	select 'table has relation'
else
	delete from topic where top_id=10

begin try
	delete from topic where top_id=1
end try
begin catch
	select 'table has relation'
end catch

--while
declare @x int=10
	while @x<=20
		begin
			set @x+=1
			if @x=14
				continue
			if @x=16
				break
			select @x
		end
--continue break
--case  iif
select ins_name , salary,
                 case
					when salary>=5000 then 'high salary'
					when salary<5000 then 'low'
					else 'no data'
				 end as Newcol
from Instructor

select ins_name , iif(salary>=5000,'high','low')
from Instructor

update Instructor	
	set salary=Salary*1.20

update Instructor	
	set salary=
				case
					when Salary>=5000 then Salary*1.20
					else Salary*1.10
				end
--choose
--waitfor
------------------------------------------------------------------
--vaiables & control of flow statements
--function
--use defined
--scalar
-------fun_name   Parameters    return_val   body
alter function getsname(@sid int)
returns varchar(30)
	begin
		declare @name varchar(30)
			select @name=st_fname from student
			where st_id=@sid
		return @name
	end

--calling
select dbo.getsname(1)
alter schema hr transfer getsname
select hr.getsname(1)
alter schema dbo transfer hr.getsname
drop function getsname

--inline
create function getinsts(@did int)
returns table
as
	return
		(
		 select ins_name , salary*12 as annualsal
		 from Instructor
		 where Dept_Id=@did
		)
--call
select * from getinsts(10)
select ins_name from getinsts(10)
select sum(annualsal) from getinsts(10)

--multi
create function getstuds(@format varchar(20))
returns @t table(id int,name varchar(20))
as
	begin
		if @format='first'
			insert into @t
			select st_id,st_fname from Student
		else if @format='last'
			insert into @t
			select st_id,st_lname from Student
		else if @format='fullname'
			insert into @t
			select st_id,concat(st_fname,' ',st_lname) from Student
		return 
	end

--calling
select * from getstuds('first')

--dynamic function XXXXXX
create function ------
returns ---
	begin
		execute()
	end

--builtin functions
---null
select isnull(st_fname,'')
from Student

select coalesce(st_fname,st_lname,st_address,'')
from Student

--data conversion
select convert(varchar(50),getdate())
select cast(getdate() as varchar(50))

select convert(varchar(50),getdate(),101)
select convert(varchar(50),getdate(),102)
select convert(varchar(50),getdate(),104)
select convert(varchar(50),getdate(),111)
select convert(varchar(50),getdate(),103)

select format(getdate(),'dd-MM-yyyy')
select format(getdate(),'dddd MMMM yyyy')
select format(getdate(),'ddd MMM yy')
select format(getdate(),'dddd')
select format(getdate(),'MMMM')
select format(getdate(),'hh:mm:ss')
select format(getdate(),'hh')
select format(getdate(),'hh tt')
select format(getdate(),'dd-MM-yyyy hh:mm:ss tt')

select format(getdate(),'yyyy')   --return string
select year(getdate()) --return int

select eomonth(getdate())
select format(eomonth(getdate()),'dd')
select format(eomonth(getdate()),'dddd')

select eomonth(getdate(),2)
select eomonth(getdate(),-1)

--system function
select db_name()

select suser_name()

select SCOPE_IDENTITY()

select IDENT_CURRENT('test')

select OBJECT_ID('exam') 

if OBJECT_ID('student') is not null
	select * from student

select name from sys.tables

--Agg function
select count(st_id),count(st_lname)
from Student

--date function
select getdate()

select datediff(year,'1/1/2012','1/1/2017')
select datediff(month,'1/1/2012','1/1/2017')
select datediff(DAY,'1/1/2012','1/1/2017')

--math
sin cos tan log power sqrt abs

select SQRT(25)

select power(salary,2)
from Instructor

--logical
iif

select isdate('1/1')
select isdate('1/1/2010')

select ISNUMERIC('3232h')
select ISNUMERIC('3232')

--string functions
select upper(st_fname), lower(st_lname)
from Student

select len(st_fname),st_fname
from Student

select substring(st_fname,1,3)
from Student

select substring(st_fname,3,3)
from Student

select substring(st_fname,1,len(st_fname)-1)
from Student

select *
from Student
where len(st_fname)>4

select top(1) st_fname
from Student
order by len(St_fname) desc

select st_fname+' '+st_age
from Student

select isnull(st_fname,'')+' '+convert(varchar(20),isnull(st_age,0))
from Student

select concat(st_fname,' ',st_age)
from Student

select concat('ahmed','1/1/2010',NULL,123,'eman',656.33)
select concat_ws(' - ','ahmed','1/1/2010',NULL,123,'eman',656.33)

select REVERSE('ahmed')

select REPLACE('ahmed$gmail.com','$','@')

select stuff('ahmedomarkhalid',6,4,'ali')

select CHARINDEX('a','mohamed')
select CHARINDEX('x','mohamed')

select trim('    ahmed   ')
select ltrim('    ahmed   ')
select Rtrim('    ahmed   ')



