create table Student
(
    Username   varchar(50)    not null
        unique,
    StudentID  int identity (50000, 1)
        constraint PK_Student
            primary key,
    FName      varchar(50)    not null,
    LName      varchar(50)    not null,
    Password   varbinary(128) not null,
    Email      varchar(100)   not null
        unique,
    Birth_Date date,
    year       int,
    Activated  bit default 1
)
go

