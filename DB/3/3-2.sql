create table course (
CID int primary key identity(1,1),
CName varchar(20),
Duration int
-- constarint key word (Constarint name) Unique key word (column[s]) 
constraint unqCrsDuration unique (Duration)
);

create table Lab(
LID int identity(1,1),
CID int,
location varchar (20),
capacity int,
constraint LabCapacity check(capacity<20),
constraint LabPKs primary key(CID,LID),
constraint LabFK foreign key(CID) references course(CID)
on delete cascade 
on update cascade 
);

create table Instructor(
ID int primary key identity(1,1), 
Fname varchar(20),
Lname varchar(20),
BD date ,
overtime int ,
salary int default 3000,
hiredate date default getdate(),
Address varchar(20),
Age as (year(getdate()) - year(BD)) ,
NetSalary as (salary + overtime) persisted,
constraint addressValue check (Address in ('cairo','alex')) ,
constraint salaryValue check (salary between 1000 and 5000 ) ,
constraint unqOvertime unique (overtime)
)

create table crs_inst(
crsID int,
insID int,
constraint crs_instPKs primary key (crsID , insID),
)
alter table crs_inst add constraint crs_instFK_crs 
foreign key(crsID) references course (CID) 
on delete cascade 
on update cascade;

alter table  crs_inst  add constraint crs_instFK_inst
foreign key (insID) references instructor(ID)
on delete cascade 
on update cascade