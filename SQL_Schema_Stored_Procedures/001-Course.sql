create table Course
(
    Course_ID   int identity
        constraint Course_pk
            primary key,
    Description varchar(250),
    Course_Name varchar(50) not null
        unique
)
go

