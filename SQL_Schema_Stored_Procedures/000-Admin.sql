create table Admin
(
    Username  varchar(50)    not null
        unique,
    Admin_ID  int identity
        constraint Admin_pk
            primary key,
    Fname     varchar(50)    not null,
    Lname     varchar(50)    not null,
    Super_ID  int,
    Email     varchar(100)   not null
        unique,
    Password  varbinary(128) not null,
    Activated bit default 1
)
go

