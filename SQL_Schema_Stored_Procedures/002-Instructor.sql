create table Instructor
(
    Username      varchar(50)    not null
        unique,
    Instructor_ID int identity (10000, 1)
        primary key,
    FName         varchar(50)    not null,
    LName         varchar(50)    not null,
    Password      varbinary(128) not null,
    Email         varchar(100)   not null
        unique,
    Title         varchar(50),
    Activated     bit default 1
)
go

