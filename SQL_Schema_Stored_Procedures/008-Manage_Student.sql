create table Manage_Student
(
    Admin_ID   int          not null
        constraint Manage_Student_Admin_Admin_ID_fk
            references Admin,
    Student_ID int          not null
        constraint Manage_Student_Student_StudentID_fk
            references Student,
    Operation  varchar(100) not null,
    Date       datetime     not null,
    constraint Manage_Student_pk
        primary key (Admin_ID, Student_ID, Operation, Date)
)
go

