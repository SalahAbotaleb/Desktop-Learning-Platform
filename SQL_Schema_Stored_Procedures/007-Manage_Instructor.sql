create table Manage_Instructor
(
    Admin_ID      int          not null
        constraint Manage_Instructor_Admin_Admin_ID_fk
            references Admin,
    Instructor_ID int          not null
        constraint Manage_Instructor_Instructor_InstructorID_fk
            references Instructor,
    Operation     varchar(100) not null,
    Date          datetime     not null,
    constraint Manage_Instructor_pk
        primary key (Admin_ID, Instructor_ID, Operation, Date)
)
go

